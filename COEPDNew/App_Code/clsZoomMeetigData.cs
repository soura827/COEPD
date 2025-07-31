using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayerHelper
{
    public class clsZoomMeetigData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["Zoom"].ConnectionString.ToString();
        public void AddUpdate(clsZoomMeeting obj)
        {
            using (SqlConnection objconn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ZoomMeeting_AddUpdate", objconn))
                {
                    objconn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ZoomMeetingCategoryId", obj.ZoomMeetingCategory);
                    objCmd.Parameters.AddWithValue("@ZoomMeetingValueId", obj.ZoomMeetingValueId);
                    objCmd.Parameters.AddWithValue("@PassCode", obj.PassCode);
                    objCmd.Parameters.AddWithValue("@HostEmployeeId", obj.HostEmployeeId);
                    objCmd.Parameters.AddWithValue("@URL", obj.URL);
                    //objCmd.Parameters.AddWithValue("@IsZoomMeetingStarted", obj.IsZoomMeetingStarted);
                    objCmd.Parameters.AddWithValue("@ZoomMeetingStartTimeOn", obj.ZoomMeetingStartedTime);
                    //objCmd.Parameters.AddWithValue("@ZoomMeetingStartedTime", obj.ZoomMeetingStartTimeOn);
                    //objCmd.Parameters.AddWithValue("@ZoomMeetingEndedTime", obj.ZoomMeetingEndTimeOn);
                    objCmd.Parameters.AddWithValue("@ZoomMeetingDate", obj.ZoomMeetingDate);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.Parameters.AddWithValue("@BatchId", obj.BatchId);
                    objCmd.Parameters.AddWithValue("@IsBatchOnly", obj.IsBatchOnly);
                    objCmd.Parameters.AddWithValue("@JoinURL", obj.JoinURL);
                    objCmd.Parameters.AddWithValue("@HostURL", obj.HostURL);
                    //objCmd.Parameters.AddWithValue("@ZoomMeetingEndTimeOn ", obj.ZoomMeetingEndedTime);
                    //objCmd.Parameters.AddWithValue("@IsZoomMeetingEnded", obj.IsZoomMeetingEnded);
                    objCmd.ExecuteNonQuery();
                }
            }
        }
        public clsZoomMeeting Load(string Id)
        {
            using (SqlConnection objconn = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("ZoomMeeting_Get", objconn))
                {
                    objconn.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@ZoomMeetingId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objcmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsZoomMeeting objInfo = new clsZoomMeeting();
                            objInfo.ZoomMeetingId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.ZoomMeetingValueId = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.ZoomMeetingCategory = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.HostEmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.URL = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[4]);
                            if (objDset.Tables[0].Rows[0].ItemArray[5] != DBNull.Value)
                                objInfo.ZoomMeetingDate = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[5]);
                            if (objDset.Tables[0].Rows[0].ItemArray[6] != DBNull.Value)
                                objInfo.ZoomMeetingStartedTime = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[6]);
                            if (objDset.Tables[0].Rows[0].ItemArray[7] != DBNull.Value)
                                objInfo.ZoomMeetingEndedTime = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[7]);
                            objInfo.PassCode = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[8]);
                            objInfo.BatchId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[9]);
                            objInfo.IsBatchOnly = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[10]);
                            if (objDset.Tables[0].Rows[0].ItemArray[11] != DBNull.Value)
                                objInfo.JoinURL = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[11]);
                            objInfo.HostURL = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[12]);
                            if (objDset.Tables[0].Rows[0].ItemArray[13] != DBNull.Value)
                                objInfo.IsZoomMeetingStarted = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[13]);
                            if (objDset.Tables[0].Rows[0].ItemArray[14] != DBNull.Value)
                                objInfo.ZoomMeetingStartTimeOn = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[14]);
                            if (objDset.Tables[0].Rows[0].ItemArray[15] != DBNull.Value)
                                objInfo.ZoomMeetingEndTimeOn = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[15]);
                            if (objDset.Tables[0].Rows[0].ItemArray[16] != DBNull.Value)
                                objInfo.IsZoomMeetingEnded = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[16]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }
        public virtual List<clsZoomMeeting> LoadAll(clsZoomMeeting obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ZoomMeeting_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@Employee", obj.Employee);
                    objCmd.Parameters.AddWithValue("@ZoomMeetingCategoryId", obj.ZoomMeetingCategoryId);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsZoomMeeting> objList = new List<clsZoomMeeting>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsZoomMeeting objInfo = new clsZoomMeeting();
                                objInfo.SNo = cnt + 1;
                                objInfo.ZoomMeetingId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.ZoomMeetingCategory = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[2] != DBNull.Value)
                                    objInfo.ZoomMeetingValueId = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.URL = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[5] != DBNull.Value)
                                    objInfo.ZoomMeetingDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                //if (objDset.Tables[0].Rows[cnt].ItemArray[6] != DBNull.Value)
                                //    objInfo.ZoomMeetingStartedTime = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                //if (objDset.Tables[0].Rows[cnt].ItemArray[7] != DBNull.Value)
                                //    objInfo.ZoomMeetingEndedTime = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.PassCode = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[7] != DBNull.Value)
                                    objInfo.IsBatchOnly = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.FullName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.Batch = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objInfo.JoinURL = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                objInfo.HostURL = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[11]);
                                //if (objDset.Tables[0].Rows[cnt].ItemArray[14] != DBNull.Value)
                                //    objInfo.IsZoomMeetingStarted = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[14]);
                                //if (objDset.Tables[0].Rows[cnt].ItemArray[15] != DBNull.Value)
                                //    objInfo.ZoomMeetingStartTimeOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[15]);
                                //if (objDset.Tables[0].Rows[cnt].ItemArray[16] != DBNull.Value)
                                //    objInfo.ZoomMeetingEndTimeOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[16]);
                                //if (objDset.Tables[0].Rows[cnt].ItemArray[17] != DBNull.Value)
                                //    objInfo.IsZoomMeetingEnded = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[17]);
                                objList.Add(objInfo);

                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }
        public int LoadRequestFAQsValidation(clsZoomMeeting obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ZoomMeeting_Validation", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ZoomMeetingId", obj.ZoomMeetingId);
                    int count = Convert.ToInt16(objCmd.ExecuteScalar());
                    return count;
                }
            }
        }



        //public clsZoomMeeting LoadZoomMeetingAttendance(string Id)
        //{
        //    using (SqlConnection objconn = new SqlConnection(Constr))
        //    {
        //        using (SqlCommand objcmd = new SqlCommand("ZoomMeetingAttendance_Get", objconn))
        //        {
        //            objconn.Open();
        //            objcmd.CommandType = CommandType.StoredProcedure;
        //            objcmd.Parameters.AddWithValue("@ZoomMeetingAttendanceId", Id);
        //            DataSet objDset = new DataSet();
        //            SqlDataAdapter objAdp = new SqlDataAdapter(objcmd);
        //            objAdp.Fill(objDset);
        //            if (objDset.Tables.Count > 0)
        //            {
        //                if (objDset.Tables[0].Rows.Count > 0)
        //                {
        //                    clsZoomMeeting objInfo = new clsZoomMeeting();
        //                    objInfo.ZoomMeetingAttendanceId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
        //                    objInfo.ZoomMeetingId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[1]);
        //                    objInfo.Username = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[2]);
        //                    if (objDset.Tables[0].Rows[0].ItemArray[3] != DBNull.Value)
        //                        objInfo.IsZoomMeetingAttended = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[3]);
        //                    if (objDset.Tables[0].Rows[0].ItemArray[4] != DBNull.Value)
        //                        objInfo.ZoomMeetingStartingTime = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[4]);
        //                    if (objDset.Tables[0].Rows[0].ItemArray[5] != DBNull.Value)
        //                        objInfo.ZoomMeetingEndingTime = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[5]);
        //                    if (objDset.Tables[0].Rows[0].ItemArray[6] != DBNull.Value)
        //                        objInfo.ZoomMeetingEndedOn = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[6]);
        //                    objInfo.Feedback = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[7]);
        //                    if (objDset.Tables[0].Rows[0].ItemArray[8] != DBNull.Value)
        //                        objInfo.FeedbackAddedOn = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[8]);
        //                    if (objDset.Tables[0].Rows[0].ItemArray[9] != DBNull.Value)
        //                        objInfo.IsFeedbackAdded = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[9]);
        //                    return objInfo;
        //                }
        //            }
        //            return null;
        //        }
        //    }
        //}



    }
}


