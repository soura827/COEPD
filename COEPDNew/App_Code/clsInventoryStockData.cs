using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayerHelper
{
    public class clsInventoryStockData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();
        public string AddUpdate(clsInventoryStock obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("InventoryStock_AddUpdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@InventoryStockId", obj.InventoryStockId);
                    objCmd.Parameters.AddWithValue("@InventoryTypeId", obj.InventoryTypeId);
                    objCmd.Parameters.AddWithValue("@InventoryId", obj.InventoryId);
                    objCmd.Parameters.AddWithValue("@Quantity", obj.Quantity);
                    objCmd.Parameters.AddWithValue("@EmployeeId", obj.EmployeeId);
                    objCmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    SqlParameter paramout = new SqlParameter("@Out_msg", SqlDbType.VarChar, 500);
                    paramout.Direction = ParameterDirection.Output;
                    objCmd.Parameters.Add(paramout);
                    objCmd.ExecuteNonQuery();
                    string outmsg = paramout.SqlValue.ToString();
                    return outmsg;
                }
            }
        }

        public clsInventoryStock Load(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("InventoryStock_Get", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@InventoryStockId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsInventoryStock objInfo = new clsInventoryStock();
                            objInfo.InventoryStockId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.InventoryTypeId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.InventoryId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.Quantity = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[4]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }

        public List<clsInventoryStock> LoadAll(clsInventoryStock obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("InventoryStock_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@keywords", obj.keywords);
                    objCmd.Parameters.AddWithValue("@InventoryTypeId", obj.InventoryTypeId);
                    objCmd.Parameters.AddWithValue("@InventoryId", obj.InventoryId);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);

                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsInventoryStock> objList = new List<clsInventoryStock>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsInventoryStock objInfo = new clsInventoryStock();
                                objInfo.SNo = cnt + 1;
                                objInfo.InventoryStockId = Convert.ToInt16(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.InventoryType = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.InventoryName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.Quantity = Convert.ToInt16(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[4]);
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
                using (SqlCommand objCmd = new SqlCommand("InventoryStock_Remove", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@InventoryStockId", Id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }

    }
}