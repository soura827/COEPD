using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayerHelper
{
    public class clsActivityFeatureLinkData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();
        public void AddUpdate(clsActivityFeatureLink obj)
        {
            using (SqlConnection objconn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ActivityFeatureLink_Addupdate", objconn))
                {

                    objconn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ActivityFeatureLinkId", obj.ActivityFeatureLinkId);
                    objCmd.Parameters.AddWithValue("@ActivityFeatureName", obj.ActivityFeatureName);
                    objCmd.Parameters.AddWithValue("@ActivityAddressName", obj.ActivityAddressName);
                    objCmd.Parameters.AddWithValue("@ActivityId", obj.ActivityId);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.ExecuteNonQuery();

                }
            }
        }
        public clsActivityFeatureLink Load(int id)
        {
            using (SqlConnection objconn = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("ActivityFeatureLink_Get", objconn))
                {
                    objconn.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@ActivityFeatureLinkId", id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objcmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsActivityFeatureLink objInfo = new clsActivityFeatureLink();
                            objInfo.ActivityFeatureLinkId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.ActivityFeatureName = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.ActivityAddressName = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[3]);
                            return objInfo;
                        }
                    }
                    return null;
                }

            }

        }
        //This method is used to get All  ActivityFeatureLink records  From  ActivityFeatureLink_List StoredProcedure
        public List<clsActivityFeatureLink> LoadAll(clsActivityFeatureLink obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("ActivityFeatureLink_List", objConn))
                {
                    objConn.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@ActivityFeatureName", obj.ActivityFeatureName);


                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objcmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsActivityFeatureLink> objList = new List<clsActivityFeatureLink>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsActivityFeatureLink objInfo = new clsActivityFeatureLink();
                                objInfo.SNo = cnt + 1;
                                objInfo.ActivityFeatureLinkId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.ActivityFeatureName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.ActivityAddressName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                if (objDset.Tables[0].Rows[cnt][3] != DBNull.Value)
                                    objInfo.ActivityId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                if (objDset.Tables[0].Rows[cnt][4] != DBNull.Value)
                                    objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                if (objDset.Tables[0].Rows[cnt][5] != DBNull.Value)
                                    objInfo.ModifiedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }

                    }
                    return null;
                }
            }
        }

        //This method is used to Remove to validate  ActivityFeatureLink   From  ActivityFeatureLink_Remove StoredProcedure
        public void Remove(int id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ActivityFeatureLink_Remove", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ActivityFeatureLinkId", id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }

    }

}
