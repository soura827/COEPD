using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayerHelper
{
    public class clsZoomMeetingAttendanceData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["Zoom"].ConnectionString.ToString();
        public void AddUpdate(clsZoomMeetingAttendance obj)
        {
            using (SqlConnection objconn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ZoomMeetingAttendance_AddUpdate", objconn))
                {
                    objconn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ZoomMeetingAttendanceId", obj.ZoomMeetingAttendanceId);
                    objCmd.Parameters.AddWithValue("@ZoomMeetingId", obj.ZoomMeetingId);
                    objCmd.Parameters.AddWithValue("@UserId", obj.UserId);
                    objCmd.Parameters.AddWithValue("@IsZoomMeetingAttended", obj.IsZoomMeetingAttended);
                    objCmd.Parameters.AddWithValue("@ZoomMeetingAttendedOn", obj.ZoomMeetingAttendedOn);
                    objCmd.Parameters.AddWithValue("@ZoomMeetingEndedOn", obj.ZoomMeetingEndedOn);
                    objCmd.Parameters.AddWithValue("@IsZoomMeetingEnded ", obj.IsZoomMeetingEnded);
                    objCmd.Parameters.AddWithValue("@Feedback", obj.Feedback);
                    objCmd.Parameters.AddWithValue("@IsFeedbackAdded ", obj.IsFeedbackAdded);
                    objCmd.Parameters.AddWithValue("@FeedbackAddedOn", obj.FeedbackAddedOn);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.ExecuteNonQuery();
                }
            }
        }
        public clsZoomMeetingAttendance Load(string Id)
        {
            using (SqlConnection objconn = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("ZoomMeetingAttendance_Get", objconn))
                {
                    objconn.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@ZoomMeetingAttendanceId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objcmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsZoomMeetingAttendance objInfo = new clsZoomMeetingAttendance();
                            objInfo.ZoomMeetingAttendanceId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.ZoomMeetingId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.Username = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.IsZoomMeetingAttended = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[3]);
                            if (objDset.Tables[0].Rows[0].ItemArray[4] != DBNull.Value)
                                objInfo.ZoomMeetingAttendedOn = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[4]);
                            objInfo.IsZoomMeetingEnded = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[5]);
                            if (objDset.Tables[0].Rows[0].ItemArray[6] != DBNull.Value)
                                objInfo.ZoomMeetingEndedOn = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[6]);
                            objInfo.Feedback = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[7]);
                            if (objDset.Tables[0].Rows[0].ItemArray[8] != DBNull.Value)
                                objInfo.FeedbackAddedOn = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[8]);
                            objInfo.IsFeedbackAdded = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[9]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }
        public virtual List<clsZoomMeetingAttendance> LoadAll(clsZoomMeetingAttendance obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ZoomMeetingAttendance_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    //objCmd.Parameters.AddWithValue("@UserId", obj.UserId);

                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsZoomMeetingAttendance> objList = new List<clsZoomMeetingAttendance>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsZoomMeetingAttendance objInfo = new clsZoomMeetingAttendance();
                                objInfo.SNo = cnt + 1;
                                objInfo.ZoomMeetingAttendanceId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Username = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[2] != DBNull.Value)
                                    objInfo.ZoomMeetingId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[3] != DBNull.Value)
                                    objInfo.IsZoomMeetingAttended = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[4] != DBNull.Value)
                                    objInfo.ZoomMeetingAttendedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[5] != DBNull.Value)
                                    objInfo.IsZoomMeetingEnded = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[6] != DBNull.Value)
                                    objInfo.ZoomMeetingEndedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.Feedback = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[8] != DBNull.Value)
                                    objInfo.FeedbackAddedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[9] != DBNull.Value)
                                    objInfo.IsFeedbackAdded = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objInfo.Feedback = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[10]);

                                objList.Add(objInfo);

                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }

    }
}





