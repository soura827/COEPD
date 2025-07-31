using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace DataAccessLayerHelper
{
    public class clsJobData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs1"].ConnectionString.ToString();

        public void AddUpdate(clsJob obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Job_AddUpdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@JobId", obj.JobId);
                    objCmd.Parameters.AddWithValue("@JobCategoryId", obj.JobCategoryId);
                    objCmd.Parameters.AddWithValue("@JobTitle", obj.JobTitle);
                    objCmd.Parameters.AddWithValue("@Location", obj.Location);
                    objCmd.Parameters.AddWithValue("@JobDate", obj.JobDate);
                    objCmd.Parameters.AddWithValue("@Company", obj.Company);
                    objCmd.Parameters.AddWithValue("@Weblink", obj.Weblink);
                    objCmd.Parameters.AddWithValue("@FullDescription", obj.FullDescription);
                    objCmd.Parameters.AddWithValue("@JobDomainId", obj.JobDomainId);
                    objCmd.Parameters.AddWithValue("@Phone", obj.Phone);
                    objCmd.Parameters.AddWithValue("@Email", obj.Email);
                    objCmd.Parameters.AddWithValue("@Experience", obj.Experience);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.ExecuteNonQuery();
                }
            }
        }

        public clsJob Load(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Job_Get", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@JobId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsJob objInfo = new clsJob();
                            objInfo.JobId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.JobCategoryId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.JobTitle = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.Location = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.JobDate = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[4]);
                            objInfo.Company = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[5]);
                            objInfo.Weblink = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[6]);
                            objInfo.FullDescription = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[7]);
                            objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[8]);
                            objInfo.JobDomainId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[9]);
                            objInfo.Phone = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[10]);
                            objInfo.Email = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[11]);
                            objInfo.Experience = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[12]);
                            objInfo.JobDomain = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[13]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }

        public List<clsJob> LoadAll(clsJob obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Job_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@keywords", obj.keywords);
                    objCmd.Parameters.AddWithValue("@JobCategoryId", obj.JobCategoryId);
                    objCmd.Parameters.AddWithValue("@JobDomainId", obj.JobDomainId);
                    objCmd.Parameters.AddWithValue("@JobDate", obj.JobDate);

                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);

                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsJob> objList = new List<clsJob>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsJob objInfo = new clsJob();
                                objInfo.SNo = cnt + 1;
                                objInfo.JobId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.JobCategoryId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.JobTitle = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.Location = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.JobDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.Company = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.Weblink = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.FullDescription = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.JobDomainId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objInfo.Phone = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                objInfo.Email = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[11]);
                                objInfo.Experience = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[12]);
                                objInfo.JobCategory = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[13]);
                                objInfo.JobDomain = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[14]);
                                objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[15]);
                                objInfo.FullName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[16]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }
        public List<clsJob> LoadAllReports(clsJob obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Job_List_Report", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@keywords", obj.keywords);
                    objCmd.Parameters.AddWithValue("@JobCategoryId", obj.JobCategoryId);
                    objCmd.Parameters.AddWithValue("@JobDomainId", obj.JobDomainId);
                    objCmd.Parameters.AddWithValue("@FromDate", obj.FromDate);
                    objCmd.Parameters.AddWithValue("@ToDate", obj.ToDate);
                    objCmd.Parameters.AddWithValue("@Experience", obj.Experience);

                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);

                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsJob> objList = new List<clsJob>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsJob objInfo = new clsJob();
                                objInfo.SNo = cnt + 1;
                                objInfo.JobId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.JobCategoryId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.JobTitle = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.Location = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.JobDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.Company = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.Weblink = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.FullDescription = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.JobDomainId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objInfo.Phone = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                objInfo.Email = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[11]);
                                objInfo.Experience = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[12]);
                                objInfo.JobCategory = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[13]);
                                objInfo.JobDomain = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[14]);
                                objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[15]);
                                objInfo.FullName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[16]);
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
                using (SqlCommand objCmd = new SqlCommand("Job_Remove", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@JobId", Id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }

        public List<clsJob> LoadLatestJobs(clsJob obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Job_List_LatestJobs ", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@JobCategoryId", obj.JobCategoryId);
                    objCmd.Parameters.AddWithValue("@JobDomainId", obj.JobDomainId);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);

                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsJob> objList = new List<clsJob>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsJob objInfo = new clsJob();
                                objInfo.SNo = cnt + 1;
                                objInfo.JobId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.JobCategoryId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.JobTitle = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.Location = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.JobDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.Company = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.Weblink = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.JobDomainId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.Phone = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.Email = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objInfo.Experience = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                objInfo.JobCategory = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[11]);
                                objInfo.JobDomain = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[12]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }
    }
}