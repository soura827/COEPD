using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace DataAccessLayerHelper
{
    public class clsBestPracticesData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();

        public void AddUpdate(clsBestPractices obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("BestPractices_AddUpdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@BestPracticesId", obj.BestPracticesId);
                    objCmd.Parameters.AddWithValue("@Stream", obj.Stream);
                    objCmd.Parameters.AddWithValue("@Practices", obj.Practices);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);

                    objCmd.ExecuteNonQuery();
                }
            }
        }
        public clsBestPractices Load(int Id)
        {
            using (SqlConnection objconn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("BestPractices_Get", objconn))
                {
                    objconn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@BestPracticesId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsBestPractices objInfo = new clsBestPractices();
                            objInfo.BestPracticesId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.Stream = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.Practices = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[2]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }
        public List<clsBestPractices> LoadAll(clsBestPractices obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("BestPractices_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@keywords", obj.keywords);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsBestPractices> objList = new List<clsBestPractices>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsBestPractices objInfo = new clsBestPractices();
                                objInfo.SNo = cnt + 1;
                                objInfo.BestPracticesId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Stream = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.Practices = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.ModifiedOn = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                //if (objDset.Tables[0].Rows[cnt].ItemArray[5] != DBNull.Value)
                                //    objInfo.ModifiedBy = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }


        public void Remove(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("BestPractices_Remove", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@BestPracticesId", Id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }

    }
}