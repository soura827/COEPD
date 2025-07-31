using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayerHelper
{
    public class clsCUGSimAssignData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();
        public void AddUpdate(clsCUGSimAssign obj)
        {
            using (SqlConnection objconn = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("CUGSimAssign_AddUpdate", objconn))
                {
                    objconn.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@CUGSimAssignId", obj.CUGSimAssignId);
                    objcmd.Parameters.AddWithValue("@CUGSimId", obj.CUGSimId);
                    objcmd.Parameters.AddWithValue("@EmployeeId", obj.EmployeeId);
                    objcmd.Parameters.AddWithValue("@SimUsedFor", obj.SimUsedFor);
                    objcmd.Parameters.AddWithValue("@IsSimUnAssigned", obj.IsSimUnAssigned);
                    objcmd.Parameters.AddWithValue("@AadharNumber", obj.AadharNumber);
                    objcmd.Parameters.AddWithValue("@Remarks", obj.Remarks);
                    objcmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objcmd.ExecuteNonQuery();
                }
            }
        }

        public clsCUGSimAssign Load(int id)
        {
            using (SqlConnection objconn = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("CUGSimAssign_Get", objconn))
                {
                    objconn.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@CUGSimAssignId", id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objcmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsCUGSimAssign objInfo = new clsCUGSimAssign();
                            objInfo.CUGSimAssignId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.CUGSimId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.EmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.SimUsedFor = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.AadharNumber = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[4]);
                            objInfo.SimAssignedDate = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[5]);
                            objInfo.Remarks = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[6]);
                            return objInfo;
                        }
                    }
                    return null;
                }

            }

        }
        public List<clsCUGSimAssign> LoadAll(clsCUGSimAssign obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("CUGSimAssign_List", objConn))
                {
                    objConn.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@keywords", obj.Keywords);
                    objcmd.Parameters.AddWithValue("@Mobile", obj.Mobile);
                    objcmd.Parameters.AddWithValue("@SimUsedFor", obj.SimUsedFor);
                    objcmd.Parameters.AddWithValue("@IsSimUnAssigned", obj.IsSimUnAssigned);
                    objcmd.Parameters.AddWithValue("@EmployeeId", obj.EmployeeId);
                    objcmd.Parameters.AddWithValue("@Code", obj.Code);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objcmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsCUGSimAssign> objList = new List<clsCUGSimAssign>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsCUGSimAssign objInfo = new clsCUGSimAssign();
                                objInfo.SNo = cnt + 1;
                                objInfo.CUGSimAssignId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.AadharNumber = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.Mobile = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.SimUsedFor = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.SimAssignedDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[6] != DBNull.Value)
                                    objInfo.SimUnAssignedDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.IsSimUnAssigned = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.Remarks = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[10] != DBNull.Value)
                                    objInfo.ModifiedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                objInfo.Fullname = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[11]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[12] != DBNull.Value)
                                    objInfo.ModifiedByName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[12]);
                                objInfo.TarifPlan = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[13]);
                                objInfo.Code = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[14]);

                                objList.Add(objInfo);
                            }
                            return objList;
                        }

                    }
                    return null;
                }
            }
        }
    }
}

