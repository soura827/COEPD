using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayerHelper
{
    public class clsCMSData
    {

        public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();

        public void AddUpdate(clsCMS obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("CMS_AddUpdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@CMSId", obj.CMSId);
                    objCmd.Parameters.AddWithValue("@CMSTitle", obj.CMSTitle);
                    objCmd.Parameters.AddWithValue("@MetaTitle", obj.MetaTitle);
                    objCmd.Parameters.AddWithValue("@MetaContent", obj.MetaContent);
                    objCmd.Parameters.AddWithValue("@MetaDescription", obj.MetaDescription);
                    objCmd.Parameters.AddWithValue("@CMSContent", obj.CMSContent);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.Parameters.AddWithValue("@CannonicalLink", obj.CannonicalLink);
                    objCmd.Parameters.AddWithValue("@CMSLink", obj.CMSLink);
                    objCmd.Parameters.AddWithValue("@RemapLink", obj.RemapLink);
                    objCmd.ExecuteNonQuery();
                }
            }
        }
        public clsCMS Load(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("CMS_Get", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@CMSId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsCMS objInfo = new clsCMS();
                            objInfo.CMSId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.CMSTitle = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.MetaTitle = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.MetaContent = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.MetaDescription = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[4]);
                            objInfo.CMSContent = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[5]);
                            objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[6]);
                            objInfo.CannonicalLink = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[7]);
                            objInfo.CMSLink = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[8]);
                            objInfo.RemapLink = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[9]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }
        public clsCMS Load_CMSLink(string Link)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("CMS_Get_CMSLink", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@CMSLink", Link);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsCMS objInfo = new clsCMS();
                            objInfo.CMSId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.CMSTitle = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.MetaTitle = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.MetaContent = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.MetaDescription = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[4]);
                            objInfo.CMSContent = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[5]);
                            objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[6]);
                            objInfo.CannonicalLink = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[7]);
                            objInfo.CMSLink = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[8]);
                            objInfo.RemapLink = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[9]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }
        public List<clsCMS> LoadAll(clsCMS obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("CMS_List", objConn))
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
                            List<clsCMS> objList = new List<clsCMS>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsCMS objInfo = new clsCMS();
                                objInfo.SNo = cnt + 1;
                                objInfo.CMSId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.CMSTitle = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.MetaTitle = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.MetaContent = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.MetaDescription = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.CMSContent = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.CannonicalLink = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.CMSLink = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.RemapLink = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[9]);
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
                using (SqlCommand objCmd = new SqlCommand("CMS_Remove", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@CMSId", Id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }
    }
}