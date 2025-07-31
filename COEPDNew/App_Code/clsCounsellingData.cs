using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayerHelper
{
    public class clsCounsellingData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();

        public void AddUpdate(clsCounselling obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Counselling_AddUpdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@CounsellingId", obj.CounsellingId);
                    objCmd.Parameters.AddWithValue("@Counselling", obj.Counselling);
                    objCmd.Parameters.AddWithValue("@CounsellingStatusId", obj.CounsellingStatusId);
                    objCmd.Parameters.AddWithValue("@LeadId", obj.LeadId);
                    objCmd.Parameters.AddWithValue("@Date", obj.Date);
                    objCmd.Parameters.AddWithValue("@StartTime", obj.StartTime);
                    objCmd.Parameters.AddWithValue("@EndTime", obj.EndTime);
                    objCmd.Parameters.AddWithValue("@PrimaryMobile", obj.PrimaryMobile);
                    objCmd.Parameters.AddWithValue("@SecondaryMobile", obj.SecondaryMobile);
                    objCmd.Parameters.AddWithValue("@PrimaryEmail", obj.PrimaryEmail);
                    objCmd.Parameters.AddWithValue("@SecondaryEmail", obj.SecondaryEmail);
                    objCmd.Parameters.AddWithValue("@Address", obj.Address);
                    objCmd.Parameters.AddWithValue("@Comments", obj.Comments);
                    objCmd.Parameters.AddWithValue("@Remarks", obj.Remarks);
                    objCmd.Parameters.AddWithValue("@EmployeeId", obj.EmployeeId);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);

                    objCmd.ExecuteNonQuery();
                }
            }
        }
        public clsCounselling Load(int Id)
        {
            using (SqlConnection objconn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Counselling_Get", objconn))
                {
                    objconn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@CounsellingId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsCounselling objInfo = new clsCounselling();
                            objInfo.CounsellingId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.Counselling = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.CounsellingStatusId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.LeadId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.Date = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[4]);
                            objInfo.StartTime = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[5]);
                            objInfo.EndTime = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[6]);
                            objInfo.PrimaryMobile = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[7]);
                            objInfo.PrimaryEmail = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[8]);
                            objInfo.Address = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[9]);
                            objInfo.Comments = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[10]);
                            objInfo.Remarks = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[11]);
                            objInfo.EmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[12]);

                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }
        public List<clsCounselling> LoadAll(clsCounselling obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Counselling_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@keywords", obj.keywords);
                    objCmd.Parameters.AddWithValue("@EmployeeId", obj.EmployeeId);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsCounselling> objList = new List<clsCounselling>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsCounselling objInfo = new clsCounselling();
                                objInfo.SNo = cnt + 1;
                                objInfo.CounsellingId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Counselling = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.CounsellingStatusId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.LeadId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.Date = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.StartTime = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.EndTime = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.PrimaryMobile = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.PrimaryEmail = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.Address = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objInfo.Comments = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                objInfo.Remarks = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[11]);
                                objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[12]);
                                objInfo.CreatedBy = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[13]);
                                objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[14]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }


        public List<clsCounselling> LoadAllReports(clsCounselling obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Counselling_List_Report", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@keywords", obj.keywords);
                    objCmd.Parameters.AddWithValue("@EmployeeId", obj.EmployeeId);
                    objCmd.Parameters.AddWithValue("@FromDate", obj.FromDate);
                    objCmd.Parameters.AddWithValue("@ToDate", obj.ToDate);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsCounselling> objList = new List<clsCounselling>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsCounselling objInfo = new clsCounselling();
                                objInfo.SNo = cnt + 1;
                                objInfo.CounsellingId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Counselling = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.CounsellingStatusId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.LeadId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.Date = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.StartTime = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.EndTime = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.PrimaryMobile = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.PrimaryEmail = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.Address = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objInfo.Comments = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                objInfo.Remarks = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[11]);
                                objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[12]);
                                objInfo.CreatedBy = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[13]);
                                objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[14]);
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
                using (SqlCommand objCmd = new SqlCommand("Counselling_Remove", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@CounsellingId", Id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }
    }
}