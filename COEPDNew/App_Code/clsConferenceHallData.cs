using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.Services;

namespace DataAccessLayerHelper
{
    public class clsConferenceHallData
    {
        public string constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();

        [WebMethod]
        public void AddUpdate(clsConferenceHall obj)
        {
            using (SqlConnection objCon = new SqlConnection(constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ConferenceHall_AddUpdate", objCon))
                {
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCon.Open();
                    objCmd.Parameters.AddWithValue("@HallId", obj.HallId);
                    objCmd.Parameters.AddWithValue("@ConferenceHall", obj.ConferenceHall);
                    objCmd.Parameters.AddWithValue("@ImagePath", obj.ImagePath);
                    objCmd.Parameters.AddWithValue("@Capacity", obj.Capacity);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.ExecuteNonQuery();
                }
            }
        }

        public clsConferenceHall Load(int Id)
        {
            using (SqlConnection objCon = new SqlConnection(constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ConferenceHall_Get", objCon))
                {
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCon.Open();
                    objCmd.Parameters.AddWithValue("@HallId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsConferenceHall objInfo = new clsConferenceHall();
                            objInfo.HallId = Convert.ToInt16(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.ConferenceHall = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.ImagePath = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.Capacity = Convert.ToInt16(objDset.Tables[0].Rows[0].ItemArray[3]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }

        public List<clsConferenceHall> LoadAll(clsConferenceHall obj)
        {
            using (SqlConnection objCon = new SqlConnection(constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ConferenceHall_List", objCon))
                {
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCon.Open();
                    objCmd.Parameters.AddWithValue("@Keywords", obj.Keywords);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsConferenceHall> objList = new List<clsConferenceHall>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsConferenceHall objInfo = new clsConferenceHall();
                                objInfo.SNo = cnt + 1;
                                objInfo.HallId = Convert.ToInt16(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.ConferenceHall = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.ImagePath = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.Capacity = Convert.ToInt16(objDset.Tables[0].Rows[cnt].ItemArray[3]);
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
            using (SqlConnection objCon = new SqlConnection(constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ConferenceHall_Remove", objCon))
                {
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCon.Open();
                    objCmd.Parameters.AddWithValue("@HallId", Id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }
    }
}