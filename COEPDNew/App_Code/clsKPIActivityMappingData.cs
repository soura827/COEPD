using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayerHelper
{
    public class clsKPIActivityMappingData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();
        public void AddUpdate(clsKPIActivityMapping obj)
        {
            using (SqlConnection objconn = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("KPIActivityMapping_AddUpdate", objconn))
                {
                    objconn.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("KPIActivityMappingId", obj.KPIActivityMappingId);
                    objcmd.Parameters.AddWithValue("ActivityCategoryId", obj.ActivityCategoryId);
                    objcmd.Parameters.AddWithValue("ActivitySubCategoryId", obj.ActivitySubCategoryId);
                    objcmd.Parameters.AddWithValue("ActivityId", obj.ActivityId);
                    objcmd.Parameters.AddWithValue("KPIId", obj.KPIId);
                    objcmd.Parameters.AddWithValue("valueAlloted", obj.ValueAlloted);
                    objcmd.Parameters.AddWithValue("CreatedBy", obj.CreatedBy);
                    objcmd.ExecuteNonQuery();
                }
            }
        }

        public clsKPIActivityMapping Load(int Id)
        {
            using (SqlConnection objconn = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("KPIActivityMapping_Get", objconn))
                {
                    objconn.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@KPIActivityMappingId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objcmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsKPIActivityMapping objInfo = new clsKPIActivityMapping();
                            objInfo.KPIActivityMappingId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.ActivityCategoryId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.ActivitySubCategoryId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.ActivityId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.KPIId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[4]);
                            objInfo.ValueAlloted = Convert.ToSingle(objDset.Tables[0].Rows[0].ItemArray[5]);
                            objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[6]);
                            objInfo.IsDeleted = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[7]);
                            objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[8]);
                            objInfo.CreatedBy = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[9]);
                            if (objDset.Tables[0].Rows[0].ItemArray[10] != DBNull.Value)
                                objInfo.ModifiedOn = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[10]);
                            if (objDset.Tables[0].Rows[0].ItemArray[11] != DBNull.Value)
                                objInfo.ModifiedBy = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[11]);
                            return objInfo;
                        }

                    }
                    return null;
                }
            }
        }
        public int LoadKPIActivityValidation(clsKPIActivityMapping obj)
        {
            using (SqlConnection objconn = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("KPIActivityMapping_Validation", objconn))
                {
                    objconn.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@ActivityId", obj.ActivityId);
                    objcmd.Parameters.AddWithValue("@KPIId", obj.KPIId);
                    int count = Convert.ToInt32(objcmd.ExecuteScalar());
                    return count;
                }
            }
        }

        public List<clsKPIActivityMapping> LoadAll(clsKPIActivityMapping obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("KPIActivityMapping_List", objConn))
                {
                    objConn.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@KPIName", obj.KPIName);
                    objcmd.Parameters.AddWithValue("@Activity", obj.Activity);
                    objcmd.Parameters.AddWithValue("@CreatedName", obj.CreatedName);
                    objcmd.Parameters.AddWithValue("@ModifiedName", obj.ModifiedName);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objcmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsKPIActivityMapping> objList = new List<clsKPIActivityMapping>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsKPIActivityMapping objInfo = new clsKPIActivityMapping();
                                objInfo.SNO = cnt + 1;
                                objInfo.KPIActivityMappingId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Activity = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.KPIName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.ValueAlloted = Convert.ToSingle(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.CreatedName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[6] != DBNull.Value)
                                    objInfo.ModifiedName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[7] != DBNull.Value)
                                    objInfo.ModifiedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objList.Add(objInfo);

                            }
                            return objList;
                        }
                    }

                }
                return null;
            }
        }
        public void Remove(int id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("KPIActivityMapping_Remove", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("KPIActivityMappingId", id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }
    }
}
