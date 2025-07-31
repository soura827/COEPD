using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayerHelper
{
    public class clsVendorData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();

        public void AddUpdate(clsVendor obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Vendor_AddUpdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@VendorId", obj.VendorId);
                    objCmd.Parameters.AddWithValue("@Vendor", obj.Vendor);
                    objCmd.Parameters.AddWithValue("@ContactName", obj.ContactName);
                    objCmd.Parameters.AddWithValue("@Email", obj.Email);
                    objCmd.Parameters.AddWithValue("@Mobile", obj.Mobile);
                    objCmd.Parameters.AddWithValue("@Phone", obj.Phone);
                    objCmd.Parameters.AddWithValue("@Website", obj.Website);
                    objCmd.Parameters.AddWithValue("@Notes", obj.Notes);
                    objCmd.Parameters.AddWithValue("@VendorCategoryId", obj.VendorCategoryId);
                    objCmd.Parameters.AddWithValue("@LocationId", obj.LocationId);
                    objCmd.Parameters.AddWithValue("@LocationOffice", obj.LocationOffice);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.ExecuteNonQuery();
                }
            }
        }
        public clsVendor Load(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Vendor_Get", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@VendorId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsVendor objInfo = new clsVendor();
                            objInfo.VendorId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.Vendor = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.ContactName = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.Email = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.Mobile = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[4]);
                            objInfo.Phone = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[5]);
                            objInfo.Website = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[6]);
                            objInfo.VendorCategoryId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[7]);
                            objInfo.Notes = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[8]);
                            objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[9]);
                            objInfo.LocationId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[10]);
                            objInfo.LocationOffice = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[11]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }
        public List<clsVendor> LoadAll(clsVendor obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Vendor_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@keywords", obj.keywords);
                    objCmd.Parameters.AddWithValue("@VendorCategoryId", obj.VendorCategoryId);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);

                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsVendor> objList = new List<clsVendor>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsVendor objInfo = new clsVendor();
                                objInfo.SNo = cnt + 1;
                                objInfo.VendorId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Vendor = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.ContactName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.Email = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.Mobile = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.Phone = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.Website = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.Notes = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.VendorCategory = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objInfo.Location = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                objInfo.LocationOffice = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[11]);
                                objInfo.Fullname = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[12]);
                                objInfo.CreatedOn = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[13]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }
        public List<clsVendor> LoadAllMultiple(clsVendor obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Vendor_ListMultiple", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@keywords1", obj.Keywords1);
                    objCmd.Parameters.AddWithValue("@keywords2", obj.Keywords2);
                    objCmd.Parameters.AddWithValue("@keywords3", obj.Keywords3);
                    objCmd.Parameters.AddWithValue("@keywords4", obj.Keywords4);
                    objCmd.Parameters.AddWithValue("@keywords5", obj.Keywords5);
                    objCmd.Parameters.AddWithValue("@keywords6", obj.Keywords6);
                    objCmd.Parameters.AddWithValue("@keywords7", obj.Keywords7);
                    objCmd.Parameters.AddWithValue("@keywords8", obj.Keywords8);
                    objCmd.Parameters.AddWithValue("@keywords9", obj.Keywords9);
                    objCmd.Parameters.AddWithValue("@keywords10", obj.Keywords10);
                    objCmd.Parameters.AddWithValue("@keywords11", obj.Keywords11);
                    objCmd.Parameters.AddWithValue("@keywords12", obj.Keywords12);
                    objCmd.Parameters.AddWithValue("@keywords13", obj.Keywords13);
                    objCmd.Parameters.AddWithValue("@keywords14", obj.Keywords14);
                    objCmd.Parameters.AddWithValue("@keywords15", obj.Keywords15);
                    objCmd.Parameters.AddWithValue("@keywords16", obj.Keywords16);
                    objCmd.Parameters.AddWithValue("@keywords17", obj.Keywords17);
                    objCmd.Parameters.AddWithValue("@keywords18", obj.Keywords18);
                    objCmd.Parameters.AddWithValue("@keywords19", obj.Keywords19);
                    objCmd.Parameters.AddWithValue("@keywords20", obj.Keywords20);
                    objCmd.Parameters.AddWithValue("@keywords21", obj.Keywords21);
                    objCmd.Parameters.AddWithValue("@keywords22", obj.Keywords22);
                    objCmd.Parameters.AddWithValue("@keywords23", obj.Keywords23);
                    objCmd.Parameters.AddWithValue("@keywords24", obj.Keywords24);
                    objCmd.Parameters.AddWithValue("@keywords25", obj.Keywords25);
                    objCmd.Parameters.AddWithValue("@keywords26", obj.Keywords26);
                    objCmd.Parameters.AddWithValue("@keywords27", obj.Keywords27);
                    objCmd.Parameters.AddWithValue("@keywords28", obj.Keywords28);
                    objCmd.Parameters.AddWithValue("@keywords29", obj.Keywords29);
                    objCmd.Parameters.AddWithValue("@keywords30", obj.Keywords30);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);

                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsVendor> objList = new List<clsVendor>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsVendor objInfo = new clsVendor();
                                objInfo.SNo = cnt + 1;
                                objInfo.VendorId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Vendor = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.ContactName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.Email = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.Mobile = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.Phone = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.Website = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.Notes = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.VendorCategory = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objInfo.Location = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                objInfo.LocationOffice = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[11]);
                                objInfo.Fullname = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[12]);
                                objInfo.CreatedOn = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[13]);
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
                using (SqlCommand objCmd = new SqlCommand("Vendor_Remove", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@VendorId", Id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }
    }
}