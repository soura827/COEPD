using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayerHelper
{
    public class clsSupportData
    {

        public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();

        public void AddUpdate(clsSupport obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Support_AddUpdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@SupportId", obj.SupportId);
                    objCmd.Parameters.AddWithValue("@Subject", obj.Subject);
                    objCmd.Parameters.AddWithValue("@SupportTypeId", obj.SupportTypeId);
                    objCmd.Parameters.AddWithValue("@Description", obj.Description);
                    objCmd.Parameters.AddWithValue("@PriorityId", obj.PriorityId);
                    objCmd.Parameters.AddWithValue("@StatusId", obj.StatusId);
                    //objCmd.Parameters.AddWithValue("@CreatedOn", obj.CreatedOn);
                    //objCmd.Parameters.AddWithValue("@ModifiedOn", obj.ModifiedOn);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.Parameters.AddWithValue("@ModifiedBy", obj.ModifiedBy);
                    objCmd.ExecuteNonQuery();
                }
            }
        }

        public clsSupport Load(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Support_Get", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@SupportId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsSupport objInfo = new clsSupport();
                            objInfo.SupportId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.Subject = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.SupportTypeId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.Description = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.PriorityId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[4]);
                            objInfo.StatusId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[5]);
                            objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[6]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }

        public List<clsSupport> LoadAll(clsSupport obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Support_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@keywords", obj.keywords);
                    objCmd.Parameters.AddWithValue("@PriorityId", obj.PriorityId);
                    objCmd.Parameters.AddWithValue("@StatusId", obj.StatusId);
                    objCmd.Parameters.AddWithValue("@EmployeeId", obj.EmployeeId);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);

                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsSupport> objList = new List<clsSupport>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsSupport objInfo = new clsSupport();
                                objInfo.SNo = cnt + 1;
                                objInfo.SupportId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Subject = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.SupportTypeId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.Description = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.PriorityId = Convert.ToInt16(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.StatusId = Convert.ToInt16(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.EmployeeId = Convert.ToInt16(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[9] != DBNull.Value)
                                    objInfo.ModifiedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objInfo.ModifiedBy = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }

        public List<clsSupport> LoadAllList(clsSupport obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Support_List_All", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@keywords", obj.keywords);
                    objCmd.Parameters.AddWithValue("@PriorityId", obj.PriorityId);
                    objCmd.Parameters.AddWithValue("@StatusId", obj.StatusId);
                    objCmd.Parameters.AddWithValue("@EmployeeId", obj.EmployeeId);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);

                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsSupport> objList = new List<clsSupport>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsSupport objInfo = new clsSupport();
                                objInfo.SNo = cnt + 1;
                                objInfo.SupportId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Subject = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.SupportTypeId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.Description = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.PriorityId = Convert.ToInt16(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.StatusId = Convert.ToInt16(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.EmployeeId = Convert.ToInt16(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[9] != DBNull.Value)
                                    objInfo.ModifiedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objInfo.ModifiedBy = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[10]);
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
                using (SqlCommand objCmd = new SqlCommand("Support_Remove", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@SupportId", Id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }
        public void UpdateStatus(clsSupport obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("SupportClosed_Update", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@SupportId", obj.SupportId);
                    objCmd.Parameters.AddWithValue("@StatusId", obj.StatusId);
                    objCmd.Parameters.AddWithValue("@ModifiedBy", obj.ModifiedBy);
                    objCmd.ExecuteNonQuery();
                }

                //using (SqlCommand objCmd = new SqlCommand("Update tblSupport Set StatusId = @StatusId,ModifiedBy=@ModifiedBy where SupportId = @SupportId", objConn))
                //{
                //    objConn.Open();
                //    objCmd.Parameters.AddWithValue("@SupportId", obj.SupportId);
                //    objCmd.Parameters.AddWithValue("@StatusId", obj.StatusId);
                //    objCmd.Parameters.AddWithValue("@ModifiedBy", obj.ModifiedBy);
                //    //objCmd.Parameters.AddWithValue("IsDeleted", obj.IsDeleted);
                //    objCmd.ExecuteNonQuery();
                //}
            }
        }

    }
}
