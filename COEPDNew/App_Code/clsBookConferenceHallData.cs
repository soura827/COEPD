using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayerHelper
{
    public class clsBookConferenceHallData
    {
        public string constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();

        public void AddUpdate(clsBookConferenceHall obj)
        {
            using (SqlConnection objCon = new SqlConnection(constr))
            {
                using (SqlCommand objCmd = new SqlCommand("BookConferenceHall_AddUpdate", objCon))
                {
                    objCon.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ConferenceHallId", obj.ConferenceHallId);
                    objCmd.Parameters.AddWithValue("@HallId", obj.HallId);
                    objCmd.Parameters.AddWithValue("@EmployeeId", obj.EmployeeId);
                    objCmd.Parameters.AddWithValue("@Date", obj.Date);
                    objCmd.Parameters.AddWithValue("@StartTime", obj.StartTime);
                    objCmd.Parameters.AddWithValue("@EndTime", obj.EndTime);
                    objCmd.Parameters.AddWithValue("@Purpose", obj.Purpose);
                    objCmd.ExecuteNonQuery();
                }
            }
        }

        public clsBookConferenceHall Load(int Id)
        {
            using (SqlConnection objCon = new SqlConnection(constr))
            {
                using (SqlCommand objCmd = new SqlCommand("BookConferenceHall_Get", objCon))
                {
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCon.Open();
                    objCmd.Parameters.AddWithValue("@ConferenceHallId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsBookConferenceHall objInfo = new clsBookConferenceHall();
                            objInfo.ConferenceHallId = Convert.ToInt16(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.HallId = Convert.ToInt16(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.EmployeeId = Convert.ToInt16(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.Date = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.StartTime = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[4]);
                            objInfo.EndTime = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[5]);
                            objInfo.Purpose = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[6]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }

        public List<clsBookConferenceHall> LoadAll(clsBookConferenceHall obj)
        {
            using (SqlConnection objCon = new SqlConnection(constr))
            {
                using (SqlCommand objCmd = new SqlCommand("BookConferenceHall_List", objCon))
                {
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCon.Open();
                    objCmd.Parameters.AddWithValue("@Keywords", obj.Keywords);
                    objCmd.Parameters.AddWithValue("@HallId", obj.HallId);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsBookConferenceHall> objList = new List<clsBookConferenceHall>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsBookConferenceHall objInfo = new clsBookConferenceHall();
                                objInfo.SNo = cnt + 1;
                                objInfo.ConferenceHallId = Convert.ToInt16(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.HallId = Convert.ToInt16(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.ConferenceHall = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.EmployeeId = Convert.ToInt16(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.Date = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.StartTime = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.EndTime = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.Purpose = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[8]);
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
                using (SqlCommand objCmd = new SqlCommand("BookConferenceHall_Remove", objCon))
                {
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCon.Open();
                    objCmd.Parameters.AddWithValue("@ConferenceHallId", Id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }
    }
}