using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace DataAccessLayerHelper
{
    public class clsCampaignData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();
        public void AddUpdate(clsCampaign obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Campaign_AddUpdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@Offer", obj.Offer);
                    objCmd.Parameters.AddWithValue("@Title", obj.Title);
                    objCmd.Parameters.AddWithValue("@Campaign_Keywords", obj.Campaign_Keywords);
                    objCmd.Parameters.AddWithValue("@StartDate", obj.StartDate);
                    objCmd.Parameters.AddWithValue("@EndDate", obj.EndDate);
                    objCmd.Parameters.AddWithValue("@FilePath", obj.FilePath);
                    objCmd.Parameters.AddWithValue("@USP1", obj.USP1);
                    objCmd.Parameters.AddWithValue("@USP2", obj.USP2);
                    objCmd.Parameters.AddWithValue("@USP3", obj.USP3);
                    objCmd.Parameters.AddWithValue("@USP4", obj.USP4);
                    objCmd.Parameters.AddWithValue("@USP5", obj.USP5);
                    objCmd.Parameters.AddWithValue("@USP6", obj.USP6);
                    objCmd.Parameters.AddWithValue("@USP7", obj.USP7);
                    objCmd.Parameters.AddWithValue("@USP8", obj.USP8);
                    objCmd.Parameters.AddWithValue("@USP9", obj.USP9);
                    objCmd.Parameters.AddWithValue("@USP10", obj.USP10);
                    objCmd.Parameters.AddWithValue("@MobileNumberRequired", obj.MobileNumberRequired);
                    objCmd.Parameters.AddWithValue("@EmailIdRequired", obj.EmailIdRequired);
                    objCmd.Parameters.AddWithValue("@SpecificEnquiryRequired", obj.SpecificEnquiryRequired);
                    objCmd.Parameters.AddWithValue("@FollowUpURL", obj.FollowUpURL);
                    objCmd.Parameters.AddWithValue("@IsActive", obj.IsActive);
                    objCmd.Parameters.AddWithValue("@IsDeleted", obj.IsDeleted);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.ExecuteNonQuery();
                }
            }
        }
        public clsCampaign Load(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Campaign_Get", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;

                    objCmd.Parameters.AddWithValue("@Offer", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsCampaign objInfo = new clsCampaign();
                            objInfo.Offer = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.Title = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.Campaign_Keywords = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.StartDate = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.EndDate = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[4]);
                            objInfo.FilePath = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[5]);
                            objInfo.USP1 = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[6]);
                            objInfo.USP2 = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[7]);
                            objInfo.USP3 = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[8]);
                            objInfo.USP4 = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[9]);
                            objInfo.USP5 = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[10]);
                            objInfo.USP6 = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[11]);
                            objInfo.USP7 = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[12]);
                            objInfo.USP8 = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[13]);
                            objInfo.USP9 = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[14]);
                            objInfo.USP10 = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[15]);
                            objInfo.MobileNumberRequired = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[16]);
                            objInfo.EmailIdRequired = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[17]);
                            objInfo.SpecificEnquiryRequired = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[18]);
                            objInfo.URL = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[19]);
                            objInfo.FollowUpURL = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[20]);
                            objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[21]);
                            objInfo.IsDeleted = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[22]);
                            objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[23]);
                            objInfo.CreatedBy = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[24]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }
        public List<clsCampaign> LoadAll(clsCampaign obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Campaign_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@keywords", obj.Keywords);
                    objCmd.Parameters.AddWithValue("@IsActive", obj.IsActive);
                    objCmd.Parameters.AddWithValue("@IsDeleted", obj.IsDeleted);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);

                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsCampaign> objList = new List<clsCampaign>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsCampaign objInfo = new clsCampaign();
                                objInfo.SNo = cnt + 1;
                                objInfo.Offer = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Title = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.StartDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.EndDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.FilePath = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.URL = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.FollowUpURL = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.IsDeleted = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objInfo.CreatedBy = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                objInfo.FullName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[11]);
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
                using (SqlCommand objCmd = new SqlCommand("Campaign_Remove", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@Offer", Id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }
    }
}