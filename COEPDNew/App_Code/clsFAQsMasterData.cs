using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayerHelper
{
    public class clsFAQsMasterData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs4"].ConnectionString.ToString();

        public void AddUpdate(clsFAQsMaster obj)
        {
            using (SqlConnection objconn = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("FAQs_AddUpdate", objconn))
                {
                    objconn.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@FAQsId", obj.FAQsId);
                    objcmd.Parameters.AddWithValue("@InterviewStatusId", obj.InterviewStatusId);
                    objcmd.Parameters.AddWithValue("@CompanyName", obj.CompanyName);
                    objcmd.Parameters.AddWithValue("@Experience", obj.Experience);
                    objcmd.Parameters.AddWithValue("@SkilSet", obj.SkilSet);
                    objcmd.Parameters.AddWithValue("@UniqueId", obj.UniqueId);
                    objcmd.Parameters.AddWithValue("@IsSourceParticipant", obj.IsSourceParticipant);
                    objcmd.Parameters.AddWithValue("@NoOfQuestions", obj.NoOfQuestions);
                    objcmd.Parameters.AddWithValue("@FAQs", obj.FAQs);
                    objcmd.Parameters.AddWithValue("@RevisedBy", obj.RevisedBy);
                    objcmd.Parameters.AddWithValue("@IsRevised", obj.IsRevised);
                    objcmd.Parameters.AddWithValue("@RevisedOn", obj.RevisedOn);
                    objcmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objcmd.ExecuteNonQuery();
                }
            }
        }

        public clsFAQsMaster Load(string id)
        {
            using (SqlConnection objconn = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("FAQs_Get", objconn))
                {
                    objconn.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@UniqueId", id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objcmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsFAQsMaster objInfo = new clsFAQsMaster();
                            objInfo.FAQsId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.CompanyName = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.Experience = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.SkilSet = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.UniqueId = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[4]);
                            objInfo.IsSourceParticipant = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[5]);
                            objInfo.NoOfQuestions = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[6]);
                            if (objDset.Tables[0].Rows[0].ItemArray[7] != DBNull.Value)
                                objInfo.RevisedBy = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[7]);
                            objInfo.IsRevised = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[8]);
                            if (objDset.Tables[0].Rows[0].ItemArray[9] != DBNull.Value)
                                objInfo.RevisedOn = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[9]);
                            objInfo.FAQs = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[10]);
                            objInfo.InterviewStatusId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[11]);
                            return objInfo;
                        }
                    }
                    return null;
                }

            }

        }

        public List<clsFAQsMaster> LoadAll(clsFAQsMaster obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("FAQs_List", objConn))
                {
                    objConn.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@CompanyName", obj.CompanyName);
                    objcmd.Parameters.AddWithValue("@Experience", obj.Experience);
                    objcmd.Parameters.AddWithValue("@SkilSet", obj.SkilSet);
                    objcmd.Parameters.AddWithValue("@IsRevised", obj.IsRevised);
                    objcmd.Parameters.AddWithValue("@IsSourceParticipant", obj.IsSourceParticipant);
                    objcmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objcmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsFAQsMaster> objList = new List<clsFAQsMaster>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsFAQsMaster objInfo = new clsFAQsMaster();
                                objInfo.SNo = cnt + 1;
                                objInfo.FAQsId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.CompanyName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.Experience = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.SkilSet = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.UniqueId = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.IsSourceParticipant = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.NoOfQuestions = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.IsRevised = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[8] != DBNull.Value)
                                    objInfo.RevisedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[9] != DBNull.Value)
                                    objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objInfo.FullName = (string)objDset.Tables[0].Rows[cnt].ItemArray[10];
                                objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[11]);
                                objInfo.InterviewStatus = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[12]);
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