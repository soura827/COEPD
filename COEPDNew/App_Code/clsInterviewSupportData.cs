using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayerHelper
{
    public class clsInterviewSupportData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs3"].ConnectionString;
        public void AddUpdate(clsInterviewSupport obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("InterviewSupport_AddUpdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@InterviewSupportId", obj.InterviewSupportId);
                    objCmd.Parameters.AddWithValue("@ResumeSubmissionId", obj.ResumeSubmissionId);
                    objCmd.Parameters.AddWithValue("@CaseStudyPath", obj.CaseStudyPath);
                    objCmd.Parameters.AddWithValue("@CaseStudyReplyPath", obj.CaseStudyReplyPath);
                    objCmd.Parameters.AddWithValue("@TargetDate", obj.TargetDate);
                    objCmd.Parameters.AddWithValue("@Notes", obj.Notes);
                    objCmd.Parameters.AddWithValue("@InterviewStatusId", obj.InterviewStatusId);
                    objCmd.Parameters.AddWithValue("@IsApproved", obj.IsApproved);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.ExecuteNonQuery();
                }
            }
        }

        public void AddMentor(clsInterviewSupport obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("InterviewSupport_Add_Mentor", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@InterviewSupportId", obj.InterviewSupportId);
                    objCmd.Parameters.AddWithValue("@IsMentorAssigned", obj.IsMentorAssigned);
                    objCmd.Parameters.AddWithValue("@MentorId", obj.MentorId);
                    objCmd.Parameters.AddWithValue("@MentorAssignedBy", obj.MentorAssignedBy);
                    objCmd.ExecuteNonQuery();
                }
            }
        }
        public clsInterviewSupport Load(int Id)

        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {

                using (SqlCommand objCmd = new SqlCommand("InterviewSupport_Get", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@InterviewSupportId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsInterviewSupport objInfo = new clsInterviewSupport();
                            objInfo.InterviewSupportId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.ResumeSubmissionId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.CaseStudyPath = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[2]);
                            if (objDset.Tables[0].Rows[0].ItemArray[3] != DBNull.Value)
                                objInfo.TargetDate = (DateTime)(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.Notes = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[4]);
                            objInfo.CaseStudyReplyPath = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[5]);
                            objInfo.IsApproved = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[6]);
                            objInfo.CompanyName = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[7]);
                            objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[8]);
                            return objInfo;
                        }
                    }
                    return null;
                }

            }

        }
        public List<clsInterviewSupport> LoadAll(clsInterviewSupport obj)
        {

            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("InterviewSupport_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    objCmd.Parameters.AddWithValue("@KeyWords", obj.KeyWords);
                    objCmd.Parameters.AddWithValue("@Location", obj.Location);
                    objCmd.Parameters.AddWithValue("@IsApproved", obj.IsApproved);
                    objCmd.Parameters.AddWithValue("@MentorId", obj.MentorId);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);

                    objAdp.Fill(objDset);

                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsInterviewSupport> objList = new List<clsInterviewSupport>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsInterviewSupport objInfo = new clsInterviewSupport();
                                objInfo.SNo = cnt + 1;
                                objInfo.InterviewSupportId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.Participant = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.Location = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.CaseStudyPath = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.CaseStudyReplyPath = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.IsApproved = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.Notes = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[9] != DBNull.Value)
                                    objInfo.ModifiedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objInfo.StartDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[11]);
                                objInfo.CompanyName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[12]);
                                objInfo.ModifiedName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[13]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[14] != DBNull.Value)
                                    objInfo.TotalExperience = Convert.ToInt16(objDset.Tables[0].Rows[cnt].ItemArray[14]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[15] != DBNull.Value)
                                    objInfo.RelevantExperience = (int)(objDset.Tables[0].Rows[cnt].ItemArray[15]);
                                objInfo.JobExperienceDomain = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[16]);
                                objInfo.JobExpectedDomain = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[17]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[18] != DBNull.Value)
                                    objInfo.TargetDate = (DateTime)objDset.Tables[0].Rows[cnt].ItemArray[18];
                                objInfo.InterviewStatus = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[19]);
                                objInfo.ProfileOwner = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[20]);
                                objInfo.Email = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[21]);
                                objInfo.Mobile = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[22]);
                                objInfo.IsMentorAssigned = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[23]);
                                objInfo.MentorName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[24]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[25] != DBNull.Value)
                                    objInfo.MentorAssignedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[25]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }

        public int LoadInterviewSupportValidation(clsInterviewSupport obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("InterviewSupport_Validation", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ResumeSubmissionId", obj.ResumeSubmissionId);
                    objCmd.Parameters.AddWithValue("@InterviewStatusId", obj.InterviewStatusId);
                    int count = Convert.ToInt16(objCmd.ExecuteScalar());
                    return count;
                }
            }
        }





    }
}
