using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayerHelper
{
    public class clsPlacementReviewsData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();

        public void AddUpdate(clsPlacementReviews obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("PlacementReviews_AddUpdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@PlacementReviewsId", obj.PlacementReviewsId);
                    objCmd.Parameters.AddWithValue("@PlacementReviewsName", obj.PlacementReviewsName);
                    objCmd.Parameters.AddWithValue("@ImagePath", obj.ImagePath);
                    objCmd.Parameters.AddWithValue("@ImageThumbPath", obj.ImageThumbPath);
                    objCmd.Parameters.AddWithValue("@IsFeatured", obj.IsFeatured);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.ExecuteNonQuery();
                }
            }
        }
        public clsPlacementReviews Load(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("PlacementReviews_Get", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@PlacementReviewsId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsPlacementReviews objInfo = new clsPlacementReviews();
                            objInfo.PlacementReviewsId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.PlacementReviewsName = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.ImagePath = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.ImageThumbPath = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.IsFeatured = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[4]);
                            objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[5]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }
        public List<clsPlacementReviews> LoadAll(clsPlacementReviews obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("PlacementReviews_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@keywords", obj.Keywords);
                    objCmd.Parameters.AddWithValue("@IsFeatured", obj.IsFeatured);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);

                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsPlacementReviews> objList = new List<clsPlacementReviews>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsPlacementReviews objInfo = new clsPlacementReviews();
                                objInfo.SNo = cnt + 1;
                                objInfo.PlacementReviewsId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.PlacementReviewsName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.ImagePath = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.ImageThumbPath = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.IsFeatured = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[5]);
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
                using (SqlCommand objCmd = new SqlCommand("PlacementReviews_Remove", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@PlacementReviewsId", Id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }

    }
}