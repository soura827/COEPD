using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayerHelper
{
    public class clsOnJobSupportData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs3"].ConnectionString.ToString();

        public void AddUpdate(clsOnJobSupport obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("OnJobSupport_AddUpdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@OnJobSupportId", obj.OnJobSupportId);
                    objCmd.Parameters.AddWithValue("@ResumeSubmissionId", obj.ResumeSubmissionId);
                    objCmd.Parameters.AddWithValue("@Project", obj.Project);
                    objCmd.Parameters.AddWithValue("@Notes", obj.Notes);
                    objCmd.Parameters.AddWithValue("@GoogleReviewPath", obj.GoogleReviewPath);
                    objCmd.Parameters.AddWithValue("@CaseStudyPath", obj.CaseStudyPath);
                    objCmd.Parameters.AddWithValue("@CaseStudyReplyPath", obj.CaseStudyReplyPath);
                    objCmd.Parameters.AddWithValue("@IsApproved", obj.IsApproved);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.ExecuteNonQuery();
                }
            }
        }
        public clsOnJobSupport Load(int Id)

        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {

                using (SqlCommand objCmd = new SqlCommand("OnJobSupport_Get", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@OnJobSupportId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsOnJobSupport objInfo = new clsOnJobSupport();
                            objInfo.OnJobSupportId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.ResumeSubmissionId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.Project = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.Notes = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.GoogleReviewPath = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[4]);
                            objInfo.CaseStudyPath = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[5]);
                            objInfo.CaseStudyReplyPath = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[6]);
                            objInfo.CompanyName = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[7]);
                            objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[8]);
                            return objInfo;
                        }
                    }
                    return null;
                }

            }

        }
        public List<clsOnJobSupport> LoadAll(clsOnJobSupport obj)
        {

            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("OnJobSupport_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@Project", obj.Project);
                    objCmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    objCmd.Parameters.AddWithValue("@KeyWords", obj.KeyWords);
                    objCmd.Parameters.AddWithValue("@Location", obj.Location);
                    objCmd.Parameters.AddWithValue("@IsApproved", obj.IsApproved);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);

                    objAdp.Fill(objDset);

                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsOnJobSupport> objList = new List<clsOnJobSupport>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsOnJobSupport objInfo = new clsOnJobSupport();
                                objInfo.SNo = cnt + 1;
                                objInfo.OnJobSupportId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.ResumeSubmissionId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.Participant = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.Location = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.GoogleReviewPath = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.CaseStudyPath = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.CaseStudyReplyPath = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.Project = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.Domain = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objInfo.Notes = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                objInfo.IsApproved = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[11]);
                                objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[12]);
                                if (objDset.Tables[0].Rows[0].ItemArray[13] != DBNull.Value)
                                    objInfo.ModifiedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[13]);
                                objInfo.StartDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[14]);
                                objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[15]);
                                objInfo.CompanyName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[16]);
                                objInfo.ModifiedName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[17]);
                                objInfo.TotalExperience = Convert.ToInt16(objDset.Tables[0].Rows[cnt].ItemArray[18]);
                                objInfo.RelevantExperience = (int)(objDset.Tables[0].Rows[cnt].ItemArray[19]);
                                objInfo.JobExperienceDomain = (string)(objDset.Tables[0].Rows[cnt].ItemArray[20]);
                                objInfo.JobExpectedDomain = (string)objDset.Tables[0].Rows[cnt].ItemArray[21];
                                objInfo.ProfileOwner = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[22]);
                                objInfo.Email = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[23]);
                                objInfo.Mobile = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[24]);
                                objInfo.InterviewStatus = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[25]);
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
                using (SqlCommand objCmd = new SqlCommand("OnJobsupport_Remove", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@OnJobSupport", Id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }
    }
}