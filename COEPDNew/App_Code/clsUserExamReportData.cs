using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace DataAccessLayerHelper
{
    public class clsUserExamReportData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();
        public void AddUpdate(clsUserExamReport obj)
        {
            using (SqlConnection objcon = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("UserExamReport_AddUpdate", objcon))
                {
                    objcon.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@UserExamReportId", obj.UserExamReportId);
                    objcmd.Parameters.AddWithValue("@UserId", obj.UserId);
                    objcmd.Parameters.AddWithValue("@ExamId", obj.ExamId);
                    objcmd.Parameters.AddWithValue("@Category", obj.Category);
                    objcmd.Parameters.AddWithValue("@Topic", obj.Topic);
                    objcmd.Parameters.AddWithValue("@TotalQuestions", obj.TotalQuestions);
                    objcmd.Parameters.AddWithValue("@CorrectAnswers", obj.CorrectAnswers);
                    objcmd.Parameters.AddWithValue("@StartDate", obj.StartDate);
                    objcmd.Parameters.AddWithValue("@StartTime", obj.StartTime);
                    objcmd.Parameters.AddWithValue("@EndTime", obj.EndTime);
                    objcmd.Parameters.AddWithValue("@Duration", obj.Duration);
                    objcmd.Parameters.AddWithValue("@RetakeExamCount", obj.RetakeExamCount);
                    objcmd.Parameters.AddWithValue("@MarksPersontage", obj.MarksPersontage);
                    objcmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objcmd.ExecuteNonQuery();
                }
            }
        }
        public clsUserExamReport Load(int id)
        {
            using (SqlConnection objcon = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("UserExamReport_Get", objcon))
                {
                    objcon.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@UserExamReportId", id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objcmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsUserExamReport objInfo = new clsUserExamReport();
                            objInfo.UserExamReportId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.UserId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.ExamId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.Category = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.Topic = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[4]);
                            objInfo.TotalQuestions = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[5]);
                            objInfo.CorrectAnswers = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[6]);
                            objInfo.StartDate = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[7]);
                            objInfo.StartTime = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[8]);
                            objInfo.EndTime = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[9]);
                            objInfo.Duration = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[10]);
                            objInfo.RetakeExamCount = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[11]);
                            objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[12]);
                            objInfo.MarksPersontage = Convert.ToInt16(objDset.Tables[0].Rows[0].ItemArray[13]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }
        public List<clsUserExamReport> LoadAll(clsUserExamReport obj)
        {
            using (SqlConnection objcon = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("UserExamReport_List", objcon))
                {
                    objcon.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@FromDate", obj.FromDate);
                    objcmd.Parameters.AddWithValue("@ToDate", obj.ToDate);
                    objcmd.Parameters.AddWithValue("@keywords", obj.Keywords);
                    objcmd.Parameters.AddWithValue("@LocationId", obj.LocationId);
                    objcmd.Parameters.AddWithValue("@EmployeeId", obj.EmployeeId);
                    objcmd.Parameters.AddWithValue("@CategoryId", obj.CategoryId);
                    objcmd.Parameters.AddWithValue("@TopicId", obj.TopicId);
                    objcmd.Parameters.AddWithValue("@IsActive", obj.IsActive);
                    objcmd.Parameters.AddWithValue("@IsDeleted", obj.IsDeleted);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objcmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsUserExamReport> objList = new List<clsUserExamReport>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsUserExamReport objInfo = new clsUserExamReport();
                                objInfo.Sno = cnt + 1;
                                objInfo.UserExamReportId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.UserId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[2] != DBNull.Value)
                                    objInfo.BatchDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.Location = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[4] != DBNull.Value)
                                    objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.ExamId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.Category = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.Topic = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.TotalQuestions = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.CorrectAnswers = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objInfo.StartDate = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                objInfo.StartTime = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[11]);
                                objInfo.EndTime = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[12]);
                                objInfo.Duration = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[13]);
                                objInfo.RetakeExamCount = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[14]);
                                objInfo.CreatedBy = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[15]);
                                objInfo.Fullname = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[16]);
                                objInfo.BranchId = Convert.ToInt16(objDset.Tables[0].Rows[cnt].ItemArray[17]);
                                objInfo.MarksPersontage = Convert.ToInt16(objDset.Tables[0].Rows[cnt].ItemArray[18]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }

                    }
                    return null;
                }
            }
        }

        public List<clsUserExamReport> LoadAllEmployee(clsUserExamReport obj)
        {
            using (SqlConnection objcon = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("UserExamReport_EmployeesList", objcon))
                {
                    objcon.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@keywords", obj.Keywords);
                    objcmd.Parameters.AddWithValue("@LocationId", obj.LocationId);
                    objcmd.Parameters.AddWithValue("@CategoryId", obj.CategoryId);
                    objcmd.Parameters.AddWithValue("@TopicId", obj.TopicId);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objcmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsUserExamReport> objList = new List<clsUserExamReport>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsUserExamReport objInfo = new clsUserExamReport();
                                objInfo.Sno = cnt + 1;
                                objInfo.UserExamReportId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.UserId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.ExamId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.Category = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.Topic = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.TotalQuestions = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.CorrectAnswers = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.StartDate = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.StartTime = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.EndTime = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objInfo.Duration = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                objInfo.RetakeExamCount = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[11]);
                                objInfo.CreatedBy = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[12]);
                                objInfo.Fullname = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[13]);
                                objInfo.BranchId = Convert.ToInt16(objDset.Tables[0].Rows[cnt].ItemArray[14]);
                                objInfo.MarksPersontage = Convert.ToInt16(objDset.Tables[0].Rows[cnt].ItemArray[15]);
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
            using (SqlConnection objcon = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("UserExamReport_Remove", objcon))
                {
                    objcon.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@UserExamReportId", id);
                    objcmd.ExecuteNonQuery();
                }
            }
        }

        public int UserExamReportCount()
        {

            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                //string Query = "Select COUNT(*) from tblRetakeExam WHERE IsDeleted = 0 AND RetakeStatusId = 0";
                string Query = "Select COUNT (*)from tblUserExamReport where UserId = @UserId And Category = @Category And Topic = @Topic";
                using (SqlCommand objCmd = new SqlCommand(Query, objConn))
                {
                    objConn.Open();

                    int ExamCount = Convert.ToInt32(objCmd.ExecuteScalar());
                    return ExamCount;
                }
            }
        }
    }
}
