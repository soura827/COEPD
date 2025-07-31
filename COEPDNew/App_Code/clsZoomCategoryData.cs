using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace DataAccessLayerHelper
{

    public class clsZoomCategoryData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["Zoom"].ConnectionString.ToString();
        public void AddUpdate(clsZoomCategory obj)
        {
            using (SqlConnection objconn = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("ZoomCategory_AddUpdate", objconn))
                {
                    objconn.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@ZoomMeetingCategoryId", obj.ZoomMeetingCategoryId);
                    objcmd.Parameters.AddWithValue("@ZoommeetingCategory", obj.ZoomMeetingCategory);
                    objcmd.Parameters.AddWithValue("@Description", obj.Description);
                    objcmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objcmd.ExecuteNonQuery();
                }
            }
        }
        public clsZoomCategory Load(int id)
        {
            using (SqlConnection objconn = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("ZoomCategory_Get", objconn))
                {
                    objconn.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@ZoomMeetingCategoryId", id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objcmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsZoomCategory objInfo = new clsZoomCategory();
                            objInfo.ZoomMeetingCategoryId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.ZoomMeetingCategory = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.Description = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[2]);
                            //objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[3]);
                            return objInfo;
                        }
                    }
                    return null;
                }

            }
        }
        public List<clsZoomCategory> LoadAll(clsZoomCategory obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("ZoomCategory_List", objConn))
                {
                    objConn.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@ZoomMeetingCategory", obj.ZoomMeetingCategory);
                    objcmd.Parameters.AddWithValue("@Fullname", obj.Fullname);
                    objcmd.Parameters.AddWithValue("@Modifiedname", obj.Modifiedname);

                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objcmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsZoomCategory> objList = new List<clsZoomCategory>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsZoomCategory objInfo = new clsZoomCategory();
                                objInfo.SNO = cnt + 1;
                                objInfo.ZoomMeetingCategoryId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.ZoomMeetingCategory = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.Description = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[5] != DBNull.Value)
                                    objInfo.ModifiedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.Fullname = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }

                    }
                    return null;
                }
            }
        }
        public void Remove(int id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ZoomCategory_Remove", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("ZoomCategoryId", id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }


        public int LoadZoomMeetingCategoryValidation(clsZoomCategory obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ZoomCategory_Validation", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ZoomMeetingCategory", obj.ZoomMeetingCategory);


                    int count = Convert.ToInt16(objCmd.ExecuteScalar());
                    return count;
                }
            }
        }
    }
}

