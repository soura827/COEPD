using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayerHelper
{
    public class clsResumePreparationData
    {

        public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();

        public void AddUpdate(clsResumePreparation obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ResumePreparation_AddUpdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ResumePreparationId", obj.ResumePreparationId);
                    objCmd.Parameters.AddWithValue("@JobExpectedDomain", obj.JobExpectedDomain);
                    objCmd.Parameters.AddWithValue("@JobExperienceDomain", obj.JobExperienceDomain);
                    objCmd.Parameters.AddWithValue("@ExpInYears", obj.ExpInYears);
                    objCmd.Parameters.AddWithValue("@ExpectedSalary", obj.ExpectedSalary);
                    objCmd.Parameters.AddWithValue("@PreferedLocations", obj.PreferedLocations);
                    objCmd.Parameters.AddWithValue("@ListOfCompentencies", obj.ListOfCompentencies);
                    objCmd.Parameters.AddWithValue("@Skills", obj.Skills);
                    objCmd.Parameters.AddWithValue("@Comments", obj.Comments);
                    objCmd.Parameters.AddWithValue("@ResumePath", obj.ResumePath);
                    objCmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    objCmd.Parameters.AddWithValue("@ResumeStatus", obj.ResumeStatus);
                    objCmd.Parameters.AddWithValue("@HrStatus", obj.HrStatus);
                    objCmd.Parameters.AddWithValue("@HrNotShortlist", obj.HrNotShortlist);
                    objCmd.Parameters.AddWithValue("@SampleResumeRequest", obj.SampleResumeRequest);
                    objCmd.Parameters.AddWithValue("@InterviewQuestionRequest", obj.InterviewQuestionRequest);
                    objCmd.Parameters.AddWithValue("@EmployeeId", obj.EmployeeId);
                    objCmd.Parameters.AddWithValue("@ApprovedDate", obj.ApprovedDate);
                    objCmd.Parameters.AddWithValue("@SampleResumeReceive", obj.SampleResumeReceive);
                    objCmd.Parameters.AddWithValue("@InterviewQuestionReceive", obj.InterviewQuestionReceive);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.ExecuteNonQuery();
                }
            }
        }


        public clsResumePreparation Load(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ResumePreparation_Get", objConn))
                {
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ParticipantId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsResumePreparation objInfo = new clsResumePreparation();
                            objInfo.ResumePreparationId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.JobExperienceDomain = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.JobExpectedDomain = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.ExpInYears = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.ExpectedSalary = Convert.ToDecimal(objDset.Tables[0].Rows[0].ItemArray[4]);
                            objInfo.PreferedLocations = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[5]);
                            objInfo.ListOfCompentencies = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[6]);
                            objInfo.Skills = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[7]);
                            objInfo.ResumePath = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[8]);
                            objInfo.Comments = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[9]);
                            objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[10]);
                            objInfo.ResumeStatus = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[11]);
                            objInfo.HrStatus = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[12]);
                            objInfo.SampleResumeRequest = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[13]);
                            objInfo.InterviewQuestionRequest = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[14]);
                            objInfo.SampleResumeReceive = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[15]);
                            objInfo.ApprovedBy = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[16]);
                            objInfo.ApprovedDate = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[17]);
                            objInfo.InterviewQuestionReceive = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[18]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }

        }


        public clsResumePreparation LoadById(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ResumePreparation_GetById", objConn))
                {
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ResumePreparationId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsResumePreparation objInfo = new clsResumePreparation();
                            objInfo.ResumePreparationId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.JobExperienceDomain = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.JobExpectedDomain = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.ExpInYears = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.ExpectedSalary = Convert.ToDecimal(objDset.Tables[0].Rows[0].ItemArray[4]);
                            objInfo.PreferedLocations = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[5]);
                            objInfo.ListOfCompentencies = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[6]);
                            objInfo.Skills = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[7]);
                            objInfo.ResumePath = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[8]);
                            objInfo.Comments = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[9]);
                            objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[10]);
                            objInfo.ResumeStatus = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[11]);
                            objInfo.HrStatus = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[12]);
                            objInfo.SampleResumeRequest = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[13]);
                            objInfo.InterviewQuestionRequest = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[14]);
                            objInfo.SampleResumeReceive = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[15]);
                            objInfo.ApprovedBy = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[16]);
                            objInfo.ApprovedDate = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[17]);
                            objInfo.InterviewQuestionReceive = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[18]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }

        }
        public List<clsResumePreparation> LoadAll(clsResumePreparation obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ResumePrepartion_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@keywords", obj.keywords);
                    objCmd.Parameters.AddWithValue("@ResumeStatus", obj.ResumeStatus);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);

                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsResumePreparation> objList = new List<clsResumePreparation>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsResumePreparation objInfo = new clsResumePreparation();
                                objInfo.SNo = cnt + 1;
                                objInfo.ResumePreparationId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.JobExpectedDomain = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.JobExperienceDomain = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.ExpInYears = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.ExpectedSalary = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.PreferedLocations = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.ListOfCompentencies = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.Skills = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.ResumePath = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.ResumeStatus = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objInfo.HrStatus = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                objInfo.SampleResumeRequest = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[11]);
                                objInfo.InterviewQuestionRequest = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[12]);
                                objInfo.Participant = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[13]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[14] != DBNull.Value)
                                    objInfo.StartDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[14]);
                                objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[15]);
                                objInfo.Location = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[16]);
                                objInfo.SampleResumeReceive = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[17]);
                                objInfo.ApprovedBy = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[18]);
                                objInfo.ApprovedDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[19]);
                                objInfo.InterviewQuestionReceive = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[20]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }

        public List<clsResumePreparation> LoadAllHR(clsResumePreparation obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ResumePrepartion_ListHR", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@keywords", obj.keywords);
                    objCmd.Parameters.AddWithValue("@ResumeStatus", obj.ResumeStatus);
                    objCmd.Parameters.AddWithValue("@HrStatus", obj.HrStatus);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);

                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsResumePreparation> objList = new List<clsResumePreparation>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsResumePreparation objInfo = new clsResumePreparation();
                                objInfo.SNo = cnt + 1;
                                objInfo.ResumePreparationId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.JobExpectedDomain = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.JobExperienceDomain = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.ExpInYears = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.ExpectedSalary = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.PreferedLocations = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.ListOfCompentencies = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.Skills = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.ResumePath = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.ResumeStatus = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objInfo.HrStatus = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                objInfo.SampleResumeRequest = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[11]);
                                objInfo.InterviewQuestionRequest = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[12]);
                                objInfo.Participant = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[13]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[14] != DBNull.Value)
                                    objInfo.StartDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[14]);
                                objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[15]);
                                objInfo.Location = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[16]);
                                objInfo.SampleResumeReceive = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[17]);
                                objInfo.ApprovedBy = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[18]);
                                objInfo.ApprovedDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[19]);
                                objInfo.InterviewQuestionReceive = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[20]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }
        public clsResumePreparation MentorRequestsCount(clsResumePreparation Obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Resumes_Count", objConn))
                {
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@keywords", Obj.keywords);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsResumePreparation objInfo = new clsResumePreparation();
                            objInfo.ResumesProcessCount = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.ResumesApprovedCount = Convert.ToInt32(objDset.Tables[0].Rows[1].ItemArray[0]);
                            objInfo.SampleResumesRequests = Convert.ToInt32(objDset.Tables[0].Rows[2].ItemArray[0]);
                            objInfo.InterviewQuestionRequests = Convert.ToInt32(objDset.Tables[0].Rows[3].ItemArray[0]);
                            objInfo.ShortlistedResumes = Convert.ToInt32(objDset.Tables[0].Rows[4].ItemArray[0]);
                            objInfo.NotShortlistedResumes = Convert.ToInt32(objDset.Tables[0].Rows[5].ItemArray[0]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }
    }
}