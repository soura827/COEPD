using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace DataAccessLayerHelper
{
    public class clsCareerData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();

        public void AddUpdate(clsCareer obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Career_AddUpdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@CareerId", obj.CareerId);
                    objCmd.Parameters.AddWithValue("@EmailId", obj.EmailId);
                    objCmd.Parameters.AddWithValue("@Mobile", obj.Mobile);
                    objCmd.Parameters.AddWithValue("@JobTitle", obj.JobTitle);
                    objCmd.Parameters.AddWithValue("@JobDescription", obj.JobDescription);
                    objCmd.Parameters.AddWithValue("@KeySkills", obj.KeySkills);
                    objCmd.Parameters.AddWithValue("@Experience", obj.Experience);
                    objCmd.Parameters.AddWithValue("@Date", obj.Date);
                    objCmd.Parameters.AddWithValue("@IsActive", obj.IsActive);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.ExecuteNonQuery();
                }
            }
        }

        public clsCareer Load(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Career_Get", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@CareerId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsCareer objInfo = new clsCareer();
                            objInfo.CareerId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.EmailId = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.Mobile = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.JobTitle = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.JobDescription = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[4]);
                            objInfo.KeySkills = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[5]);
                            objInfo.Experience = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[6]);
                            objInfo.Date = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[7]);
                            objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[8]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }

        public List<clsCareer> LoadAll(clsCareer obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Career_List", objConn))
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
                            List<clsCareer> objList = new List<clsCareer>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsCareer objInfo = new clsCareer();
                                objInfo.SNo = cnt + 1;
                                objInfo.CareerId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.EmailId = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.Mobile = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.JobTitle = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.JobDescription = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.KeySkills = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.Experience = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.Date = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[7]);
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
                using (SqlCommand objCmd = new SqlCommand("Career_Remove", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@CareerId", Id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }

        public void AddUpdate1(clsCareer obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Career_AddUpdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@CareerId", obj.CareerId);
                    objCmd.Parameters.AddWithValue("@EmailId", obj.EmailId);
                    objCmd.Parameters.AddWithValue("@Mobile", obj.Mobile);
                    objCmd.Parameters.AddWithValue("@JobTitle", obj.JobTitle);
                    objCmd.Parameters.AddWithValue("@JobDescription", obj.JobDescription);
                    objCmd.Parameters.AddWithValue("@KeySkills", obj.KeySkills);
                    objCmd.Parameters.AddWithValue("@Experience", obj.Experience);
                    objCmd.Parameters.AddWithValue("@Date", obj.Date);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.ExecuteNonQuery();
                }
            }
        }
    }
}