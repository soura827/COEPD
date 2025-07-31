using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayerHelper
{
    public class clsJobRequirementData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();

        public void AddUpdate(clsJobRequirement obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("JobRequirement_AddUpdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@JobRequirementId", obj.JobRequirementId);
                    objCmd.Parameters.AddWithValue("@CompanyName", obj.CompanyName);
                    objCmd.Parameters.AddWithValue("@ContactPerson", obj.ContactPerson);
                    objCmd.Parameters.AddWithValue("@EmailId", obj.EmailId);
                    objCmd.Parameters.AddWithValue("@Mobile", obj.Mobile);
                    objCmd.Parameters.AddWithValue("@JobDescription", obj.JobDescription);
                    objCmd.Parameters.AddWithValue("@KeySkills", obj.KeySkills);
                    objCmd.Parameters.AddWithValue("@AvailableTimings", obj.AvailableTimings);
                    objCmd.Parameters.AddWithValue("@Location", obj.Location);
                    objCmd.Parameters.AddWithValue("@JobRole", obj.JobRole);
                    objCmd.Parameters.AddWithValue("@YearsOfExperience", obj.YearsOfExp);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.Parameters.AddWithValue("@ExpiryDate", Convert.ToDateTime(obj.ExpiryDate));
                    objCmd.ExecuteNonQuery();
                }
            }
        }

        public clsJobRequirement Load(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("JobRequirement_Get", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@JobRequirementId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsJobRequirement objInfo = new clsJobRequirement();
                            objInfo.JobRequirementId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.CompanyName = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.ContactPerson = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.EmailId = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.Mobile = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[4]);
                            objInfo.JobDescription = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[5]);
                            objInfo.KeySkills = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[6]);
                            objInfo.AvailableTimings = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[7]);
                            objInfo.Location = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[8]);
                            objInfo.JobRole = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[9]);
                            objInfo.YearsOfExp = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[10]);
                            objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[11]);
                            if (objDset.Tables[0].Rows[0].ItemArray[12] != DBNull.Value)
                                objInfo.ExpiryDate = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[12]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }

        public List<clsJobRequirement> LoadAll(clsJobRequirement obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("JobRequirement_List", objConn))
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
                            List<clsJobRequirement> objList = new List<clsJobRequirement>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsJobRequirement objInfo = new clsJobRequirement();
                                objInfo.SNo = cnt + 1;
                                objInfo.JobRequirementId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.CompanyName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.ContactPerson = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.EmailId = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.Mobile = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.JobDescription = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.KeySkills = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.AvailableTimings = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.Location = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.JobRole = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objInfo.YearsOfExp = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[11]);
                                objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[12]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[13] != DBNull.Value)
                                    objInfo.ExpiryDate = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[13]);
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
                using (SqlCommand objCmd = new SqlCommand("JobRequirement_Remove", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@JobRequirementId", Id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }
    }
}