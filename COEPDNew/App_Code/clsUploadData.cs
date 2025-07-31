using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace DataAccessLayerHelper
{
    public class clsUploadData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();

        public void AddUpdate(clsUpload obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Upload_AddUpdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@UploadId", obj.UploadId);
                    objCmd.Parameters.AddWithValue("@Upload", obj.Upload);
                    objCmd.Parameters.AddWithValue("@DocPath", obj.DocPath);
                    objCmd.Parameters.AddWithValue("@UserId", obj.UserId);
                    objCmd.Parameters.AddWithValue("@DocCategoryId", obj.DocCategoryId);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.ExecuteNonQuery();
                }
            }
        }
        public clsUpload Load(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Upload_Get", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@UploadId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsUpload objInfo = new clsUpload();
                            objInfo.UploadId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.Upload = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.DocPath = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.DocCategoryId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[4]);
                            objInfo.UserId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[5]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }
        public List<clsUpload> LoadAll(clsUpload obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Upload_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@keywords", obj.keywords);
                    objCmd.Parameters.AddWithValue("@UserId", obj.UserId);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);

                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsUpload> objList = new List<clsUpload>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsUpload objInfo = new clsUpload();
                                objInfo.SNo = cnt + 1;
                                objInfo.UploadId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Upload = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.DocPath = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.UserId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.DocCategoryId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[5]);
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
                using (SqlCommand objCmd = new SqlCommand("Upload_Remove", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@UploadId", Id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }

    }
}