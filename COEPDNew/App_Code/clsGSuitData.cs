using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayerHelper
{
    public class clsGSuitData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["Inventory"].ConnectionString.ToString();
        public void AddUpdate(clsGSuit obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("GSuitEmail_AddUpdate", objConn))
                {
                    objConn.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@GSuitEmailId", obj.GSuitEmailId);
                    objcmd.Parameters.AddWithValue("@GSuitEmail", obj.GSuitEmail);
                    objcmd.Parameters.AddWithValue("@IsCreated", obj.IsCreated);
                    objcmd.Parameters.AddWithValue("@DateOfCreation", obj.DateOfCreation);
                    objcmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objcmd.ExecuteNonQuery();
                }
            }
        }
        public clsGSuit Load(int id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("GSuitEmail_Get", objConn))
                {
                    objConn.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@GSuitEmailId", id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objcmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsGSuit objInfo = new clsGSuit();
                            objInfo.GSuitEmailId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.GSuitEmail = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.IsCreated = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[2]);
                            if (objDset.Tables[0].Rows[0].ItemArray[3] != DBNull.Value)
                                objInfo.DateOfCreation = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[3]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }
        public List<clsGSuit> LoadAll(clsGSuit obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("GSuitEmail_List", objConn))
                {
                    objConn.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@GSuitEmail", obj.GSuitEmail);
                    objcmd.Parameters.AddWithValue("@IsCreated", obj.IsCreated);
                    objcmd.Parameters.AddWithValue("@IsEmailAssigned", obj.IsEmailAssigned);
                    objcmd.Parameters.AddWithValue("@CreatedName", obj.CreatedName);
                    objcmd.Parameters.AddWithValue("@ModifiedName", obj.ModifiedName);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objcmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsGSuit> objList = new List<clsGSuit>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsGSuit objInfo = new clsGSuit();
                                objInfo.SNo = cnt + 1;
                                objInfo.GSuitEmailId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.GSuitEmail = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[2] != DBNull.Value)
                                    objInfo.IsCreated = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[3] != DBNull.Value)
                                    objInfo.DateOfCreation = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[5] != DBNull.Value)
                                    objInfo.ModifiedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.CreatedName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[7] != DBNull.Value)
                                    objInfo.ModifiedName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }
        public void Remove(int id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("GSuitEmail_Remove", objConn))
                {
                    objConn.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@GSuitEmailId", id);
                    objcmd.ExecuteNonQuery();
                }
            }
        }
        public int LoadEmailValidation(clsGSuit obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("GSuitEmail_Validation", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@GSuitEmail", obj.GSuitEmail);
                    int Count = Convert.ToInt16(objCmd.ExecuteScalar());
                    return Count;
                }
            }
        }
    }
}
