using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace DataAccessLayerHelper
{
    public class clsEnquiryData
    {

        public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();
        public void AddUpdate(clsEnquiry obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Enquiry_AddUpdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@EnquiryId", obj.EnquiryId);
                    objCmd.Parameters.AddWithValue("@Name", obj.Name);
                    objCmd.Parameters.AddWithValue("@Phone", obj.Phone);
                    objCmd.Parameters.AddWithValue("@Email", obj.Email);
                    objCmd.Parameters.AddWithValue("@City", obj.City);
                    objCmd.Parameters.AddWithValue("@State", obj.State);
                    objCmd.Parameters.AddWithValue("@CourseName", obj.CourseName);
                    objCmd.Parameters.AddWithValue("@Message", obj.Message);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.Parameters.AddWithValue("@TimeRequired", obj.PlanId);
                    objCmd.Parameters.AddWithValue("@CourseId", obj.CourseId);
                    objCmd.ExecuteNonQuery();
                }
            }
        }
        public clsEnquiry Load(int Id)
        {
            using (SqlConnection objconn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Enquiry_Get", objconn))
                {
                    objconn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@EnquiryId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsEnquiry objInfo = new clsEnquiry();
                            objInfo.EnquiryId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.Name = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.Email = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.Phone = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.City = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[4]);
                            objInfo.State = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[5]);
                            objInfo.CourseName = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[6]);
                            objInfo.Message = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[7]);
                            objInfo.PlanId = Convert.ToInt16(objDset.Tables[0].Rows[0].ItemArray[8]);
                            objInfo.CourseId = Convert.ToInt16(objDset.Tables[0].Rows[0].ItemArray[9]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }
        public List<clsEnquiry> LoadAll(clsEnquiry obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Enquiry_List", objConn))
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
                            List<clsEnquiry> objList = new List<clsEnquiry>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsEnquiry objInfo = new clsEnquiry();
                                objInfo.SNo = cnt + 1;
                                objInfo.EnquiryId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Name = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.Email = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.Phone = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.City = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.State = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.CourseName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.Message = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.TimeRequired = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.Course = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[10]);
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
                using (SqlCommand objCmd = new SqlCommand("Enquiry_Remove", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@EnquiryId", Id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }
        public List<clsEnquiry> LoadAllReports(clsEnquiry obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Enquiry_List_Reports", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@keywords", obj.keywords);
                    objCmd.Parameters.AddWithValue("@CourseId", obj.CourseId);
                    objCmd.Parameters.AddWithValue("@PlanId", obj.PlanId);
                    objCmd.Parameters.AddWithValue("@FromDate", obj.FromDate);
                    objCmd.Parameters.AddWithValue("@ToDate", obj.ToDate);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsEnquiry> objList = new List<clsEnquiry>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsEnquiry objInfo = new clsEnquiry();
                                objInfo.SNo = cnt + 1;
                                objInfo.EnquiryId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Name = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.Email = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.Phone = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.City = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.State = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.CourseName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.Message = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.TimeRequired = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.Course = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }

        public int LoadEnquiryValidation(clsEnquiry obj)
        {
            using (SqlConnection objconn = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("Enquiry_Validation", objconn))
                {
                    objconn.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@Email", obj.Email);
                    objcmd.Parameters.AddWithValue("@Phone", obj.Phone);
                    int count = Convert.ToInt32(objcmd.ExecuteScalar());
                    return count;
                }
            }
        }
    }
}