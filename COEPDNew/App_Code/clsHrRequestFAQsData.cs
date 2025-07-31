using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;



namespace DataAccessLayerHelper
{
    public class clsHrRequestFAQsData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs3"].ConnectionString.ToString();

        public void AddUpdate(clsHrRequestFAQs obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("HrRequestFAQs_AddUpdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@HrRequestFAQsId", obj.HrRequestFAQsId);
                    objCmd.Parameters.AddWithValue("@ResumeSubmissionId", obj.ResumeSubmissionId);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.Parameters.AddWithValue("@IsSent", obj.IsSent);
                    objCmd.ExecuteNonQuery();
                }
            }
        }

        public clsHrRequestFAQs Load(int Id)

        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {

                using (SqlCommand objCmd = new SqlCommand("HrRequestFAQs_Get", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@HrRequestFAQsId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsHrRequestFAQs objInfo = new clsHrRequestFAQs();
                            if (objDset.Tables[0].Rows[0].ItemArray[0] != DBNull.Value)
                                objInfo.HrRequestFAQsId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            if (objDset.Tables[0].Rows[0].ItemArray[1] != DBNull.Value)
                                objInfo.ResumeSubmissionId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[1]);
                            if (objDset.Tables[0].Rows[0].ItemArray[2] != DBNull.Value)
                                objInfo.IsSent = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.CompanyName = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.Experience = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[4]);
                            objInfo.JobDescription = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[5]);
                            objInfo.InterviewStatusId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[6]);
                            return objInfo;
                        }
                    }
                    return null;
                }

            }

        }

        public List<clsHrRequestFAQs> LoadAll(clsHrRequestFAQs obj)
        {

            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("HrRequestFAQs_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@CompanyName", obj.CompanyName);
                    objCmd.Parameters.AddWithValue("@Domain", obj.Domain);
                    objCmd.Parameters.AddWithValue("@Location", obj.Location);
                    objCmd.Parameters.AddWithValue("@IsSent", obj.IsSent);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsHrRequestFAQs> objList = new List<clsHrRequestFAQs>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsHrRequestFAQs objInfo = new clsHrRequestFAQs();
                                objInfo.SNo = cnt + 1;
                                objInfo.HrRequestFAQsId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.ResumeSubmissionId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[2] != DBNull.Value)
                                    objInfo.IsSent = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[3] != DBNull.Value)
                                    objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[4] != DBNull.Value)
                                    objInfo.CreatedBy = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[5] != DBNull.Value)
                                    objInfo.ModifiedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[6] != DBNull.Value)
                                    objInfo.ModifiedBy = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[7] != DBNull.Value)
                                    objInfo.Fullname = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.ModifiedByName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.CompanyName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objInfo.Location = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                objInfo.Experience = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[11]);
                                objInfo.Domain = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[12]);
                                objList.Add(objInfo);

                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }

        public int LoadHrRequestFAQsResumeSubmission_Validation(clsHrRequestFAQs obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("HrRequestFAQsResumeSubmission_Validation", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ResumeSubmissionId", obj.ResumeSubmissionId);
                    int count = Convert.ToInt16(objCmd.ExecuteScalar());
                    return count;
                }
            }
        }


    }

}

