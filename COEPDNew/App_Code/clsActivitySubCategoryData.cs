using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace DataAccessLayerHelper
{
    public class clsActivitySubCategoryData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();
        //This method is used to Add and Update  ActivitySubCategory From ActivitySubCategory_AddUpdate StoredProcedure
        public void AddUpdate(clsActivitySubCategory obj)
        {
            using (SqlConnection objconn = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("ActivitySubCategory_AddUpdate", objconn))
                {
                    objconn.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@ActivitySubCategoryId", obj.ActivitySubCategoryId);
                    objcmd.Parameters.AddWithValue("@ActivityCategoryId", obj.ActivityCategoryId);
                    objcmd.Parameters.AddWithValue("@ActivitySubCategory", obj.ActivitySubCategory);
                    objcmd.Parameters.AddWithValue("@Description", obj.Description);
                    objcmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objcmd.ExecuteNonQuery();
                }
            }
        }
        //This method is used to get Selected  ActivitySubCategory record  From ActivitySubCategory_Get StoredProcedure
        public clsActivitySubCategory Load(int id)
        {
            using (SqlConnection objconn = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("ActivitySubCategory_Get", objconn))
                {
                    objconn.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@ActivitySubCategoryId", id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objcmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsActivitySubCategory objInfo = new clsActivitySubCategory();
                            objInfo.ActivitySubCategoryId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.ActivityCategoryId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.ActivitySubCategory = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.Description = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[4]);
                            return objInfo;
                        }
                    }
                    return null;
                }

            }

        }
        //This method is used to get All  ActivitySubCategory records  From ActivitySubCategory_List StoredProcedure
        public List<clsActivitySubCategory> LoadAll(clsActivitySubCategory obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("ActivitySubCategory_List", objConn))
                {
                    objConn.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    //objcmd.Parameters.AddWithValue("@keywords", obj.Keywords);
                    objcmd.Parameters.AddWithValue("@ActivityCategory", obj.ActivityCategory);
                    objcmd.Parameters.AddWithValue("@ActivitySubCategory", obj.ActivitySubCategory);
                    objcmd.Parameters.AddWithValue("@Fullname", obj.Fullname);
                    objcmd.Parameters.AddWithValue("@Modifiedname", obj.Modifiedname);
                    // objcmd.Parameters.AddWithValue("@Description", obj.Description);
                    objcmd.Parameters.AddWithValue("@ActivityCategoryId", obj.ActivityCategoryId);
                    // objcmd.Parameters.AddWithValue("@Employee", obj.Employee);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objcmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsActivitySubCategory> objList = new List<clsActivitySubCategory>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsActivitySubCategory objInfo = new clsActivitySubCategory();
                                objInfo.SNo = cnt + 1;
                                objInfo.ActivitySubCategoryId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.ActivityCategoryId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.ActivitySubCategory = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.Description = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.ActivityCategory = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.CreatedBy = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[7] != DBNull.Value)
                                    objInfo.ModifiedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[8] != DBNull.Value)
                                    objInfo.ModifiedBy = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.Fullname = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[10] != DBNull.Value)
                                    objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }

                    }
                    return null;
                }
            }
        }
        //This method is used to Remove to validate  ActivitySubCategory   From ActivitySubCategory_Remove StoredProcedure
        public void Remove(int id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ActivitySubCategory_Remove", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ActivitySubCategoryId", id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }


    }

}
