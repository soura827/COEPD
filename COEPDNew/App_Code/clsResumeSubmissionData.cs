using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayerHelper
{
    public class clsResumeSubmissionData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs3"].ConnectionString.ToString();
        public void AddUpdate(clsResumeSubmission obj)
        {
            using (SqlConnection objconn = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("ResumeSubmission_AddUpdate", objconn))
                {
                    objconn.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@ResumeSubmissionId", obj.ResumeSubmissionId);
                    objcmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    objcmd.Parameters.AddWithValue("@InterviewStatusId", obj.InterviewStatusId);
                    objcmd.Parameters.AddWithValue("@CompanyName", obj.CompanyName);
                    objcmd.Parameters.AddWithValue("@JobDescription", obj.JobDescription);
                    objcmd.Parameters.AddWithValue("@Location", obj.Location);
                    objcmd.Parameters.AddWithValue("@Experience", obj.Experience);
                    objcmd.Parameters.AddWithValue("@Domain", obj.Domain);
                    objcmd.Parameters.AddWithValue("@AppliedOn", obj.AppliedOn);


                    objcmd.Parameters.AddWithValue("@AppliedThroughId", obj.AppliedThroughId);
                    objcmd.Parameters.AddWithValue("@Designation", obj.Designation);
                    objcmd.Parameters.AddWithValue("@PackageOffered", obj.PackageOffered);
                    objcmd.Parameters.AddWithValue("@DateofJoining", obj.DateofJoining);
                    objcmd.Parameters.AddWithValue("@IsRegisteredOnJobSupport", obj.IsRegisteredOnJobSupport);
                    objcmd.Parameters.AddWithValue("@InitialDiscussionRound", obj.InitialDiscussionRound);
                    objcmd.Parameters.AddWithValue("@SelectedorRejected", obj.SelectedorRejected);
                    objcmd.Parameters.AddWithValue("@Remarks", obj.Remarks);
                    



                    objcmd.Parameters.AddWithValue("@InterviewRound1On", obj.InterviewRound1On);
                    objcmd.Parameters.AddWithValue("@InterviewRound2On", obj.InterviewRound2On);
                    objcmd.Parameters.AddWithValue("@InterviewRound3On", obj.InterviewRound3On);
                    objcmd.Parameters.AddWithValue("@OfferAcceptedOn", obj.OfferAcceptedOn);
                    objcmd.Parameters.AddWithValue("@OfferReleasedOn", obj.OfferReleasedOn);
                    objcmd.Parameters.AddWithValue("IsOfferAccepted", obj.IsOfferAccepted);
                    objcmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objcmd.ExecuteNonQuery();
                }
            }
        }
        public clsResumeSubmission Load(int Id)
        {
            using (SqlConnection objconn = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("ResumeSubmission_Get", objconn))
                {
                    objconn.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@ResumeSubmissionId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objcmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsResumeSubmission objInfo = new clsResumeSubmission();
                            objInfo.ResumeSubmissionId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.CompanyName = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.JobDescription = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.Location = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[4]);
                            objInfo.Experience = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[5]);
                            objInfo.Domain = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[6]);
                            if (objDset.Tables[0].Rows[0].ItemArray[7] != DBNull.Value)
                                objInfo.AppliedOn = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[7]);
                            objInfo.AppliedThroughId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[8]);
                            objInfo.InterviewStatusId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[9]);
                            objInfo.Designation = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[10]);
                            objInfo.PackageOffered = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[11]);
                            if (objDset.Tables[0].Rows[0].ItemArray[12] != DBNull.Value)
                                objInfo.DateofJoining = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[12]);
                            objInfo.GoogleReviewLink = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[13]);
                            if (objDset.Tables[0].Rows[0].ItemArray[14] != DBNull.Value)
                                objInfo.InterviewRound1On = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[14]);
                            if (objDset.Tables[0].Rows[0].ItemArray[15] != DBNull.Value)
                                objInfo.InterviewRound2On = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[15]);
                            if (objDset.Tables[0].Rows[0].ItemArray[16] != DBNull.Value)
                                objInfo.InterviewRound3On = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[16]);
                            if (objDset.Tables[0].Rows[0].ItemArray[17] != DBNull.Value)
                                objInfo.OfferReleasedOn = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[17]);
                            if (objDset.Tables[0].Rows[0].ItemArray[18] != DBNull.Value)
                                objInfo.OfferAcceptedOn = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[18]);
                            if (objDset.Tables[0].Rows[0].ItemArray[19] != DBNull.Value)
                                objInfo.IsOfferAccepted = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[19]);

                            return objInfo;
                        }
                    }
                    return null;
                }

            }

        }

        public List<clsResumeSubmission> LoadAll(clsResumeSubmission obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("ResumeSubmission_List", objConn))
                {
                    objConn.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@CompanyName", obj.CompanyName);
                    objcmd.Parameters.AddWithValue("@Keywords", obj.Keywords);
                    objcmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    objcmd.Parameters.AddWithValue("@InterviewStatus", obj.InterviewStatus);
                    objcmd.Parameters.AddWithValue("@AppliedThroughId", obj.AppliedThroughId);
                    objcmd.Parameters.AddWithValue("@Fullname", obj.Fullname);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objcmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsResumeSubmission> objList = new List<clsResumeSubmission>();

                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsResumeSubmission objInfo = new clsResumeSubmission();
                                objInfo.SNo = cnt + 1;
                                objInfo.ResumeSubmissionId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.Participant = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.Location = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.Trainer = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[5] != DBNull.Value)
                                    objInfo.StartDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.CompanyName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.JobDescription = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.Experience = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.Domain = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                               


                                objInfo.AppliedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                objInfo.InitialDiscussionRound = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[11]);
                                objInfo.SelectedorRejected = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[12]);
                                objInfo.Remarks = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[13]);

                               






                                objInfo.ParticipantLocation = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[14]);
                                objInfo.AppliedThroughId = (int)(objDset.Tables[0].Rows[cnt].ItemArray[15]);
                                objInfo.InterviewStatus = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[16]);
                                objInfo.Designation = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[17]);
                                objInfo.PackageOffered = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[18]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[19] != DBNull.Value)
                                    objInfo.DateofJoining = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[19]);
                                objInfo.IsRegisteredOnJobSupport = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[20]);
                                objInfo.AppliedThrough = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[21]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[22] != DBNull.Value)
                                    objInfo.InterviewRound1On = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[22]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[23] != DBNull.Value)
                                    objInfo.InterviewRound2On = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[23]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[24] != DBNull.Value)
                                    objInfo.InterviewRound3On = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[24]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[25] != DBNull.Value)
                                    objInfo.OfferReleasedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[25]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[26] != DBNull.Value)
                                    objInfo.OfferAcceptedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[26]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[27] != DBNull.Value)
                                    objInfo.IsOfferAccepted = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[27]);
                                objInfo.ProfileOwner = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[28]);
                                objInfo.Email = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[29]);
                                objInfo.Mobile = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[30]);
                                objInfo.Fullname = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[31]);
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
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ResumeSubmission_Remove", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ResumeSubmissionId", id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }




    }
}