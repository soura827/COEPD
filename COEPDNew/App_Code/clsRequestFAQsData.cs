using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace DataAccessLayerHelper
{
    public class clsRequestFAQsData
    {

        public string Constr = ConfigurationManager.ConnectionStrings["cs3"].ConnectionString.ToString();

        public void AddUpdate(clsRequestFAQs obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("RequestFAQs_AddUpdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@RequestFAQsId", obj.RequestFAQsId);
                    objCmd.Parameters.AddWithValue("@ResumeSubmissionId", obj.ResumeSubmissionId);
                    objCmd.Parameters.AddWithValue("@FAQsId", obj.FAQsId);
                    objCmd.Parameters.AddWithValue("@ProofOfInterviewPath", obj.ProofOfInterviewPath);
                    objCmd.Parameters.AddWithValue("@Notes", obj.Notes);
                    objCmd.Parameters.AddWithValue("@InterviewStatusId", obj.InterviewStatusId);
                    objCmd.Parameters.AddWithValue("@InterviewDate", obj.InterviewDate);
                    objCmd.Parameters.AddWithValue("@IsApproved", obj.IsApproved);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.ExecuteNonQuery();
                }
            }
        }
        public clsRequestFAQs Load(int Id)

        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {

                using (SqlCommand objCmd = new SqlCommand("RequestFAQs_Get", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@RequestFAQsId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsRequestFAQs objInfo = new clsRequestFAQs();
                            objInfo.RequestFAQsId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.ResumeSubmissionId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.CompanyName = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.ProofOfInterviewPath = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.Notes = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[4]);
                            objInfo.IsApproved = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[5]);
                            if (objDset.Tables[0].Rows[0].ItemArray[6] != DBNull.Value)
                                objInfo.FAQsId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[6]);
                            objInfo.FAQs = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[7]);
                            objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[8]);
                            if (objDset.Tables[0].Rows[0].ItemArray[9] != DBNull.Value)
                                objInfo.InterviewDate = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[9]);
                            return objInfo;
                        }
                    }
                    return null;
                }

            }

        }
        public List<clsRequestFAQs> LoadAll(clsRequestFAQs obj)
        {

            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("RequestFAQs_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
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
                            List<clsRequestFAQs> objList = new List<clsRequestFAQs>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsRequestFAQs objInfo = new clsRequestFAQs();
                                objInfo.SNo = cnt + 1;
                                objInfo.RequestFAQsId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.ResumeSubmissionId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.Participant = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.Location = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.ProofOfInterviewPath = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.IsApproved = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.Notes = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[9] != DBNull.Value)
                                    objInfo.ModifiedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[10] != DBNull.Value)
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
                                objInfo.InterviewStatus = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[18]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[19] != DBNull.Value)
                                    objInfo.InterviewDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[19]);
                                objInfo.ProfileOwner = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[20]);
                                objInfo.Email = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[21]);
                                objInfo.Mobile = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[22]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }

        public int LoadRequestFAQsValidation(clsRequestFAQs obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("RequestFAQs_Validation", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    int count = Convert.ToInt16(objCmd.ExecuteScalar());
                    return count;
                }
            }
        }

        public void Remove(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("RequestFAQs_Remove", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@RequestFAQsId", Id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }

        public int LoadRequestFAQsMultiValidation(clsRequestFAQs obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("RequestFAQs_MultiValidation", objConn))
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


