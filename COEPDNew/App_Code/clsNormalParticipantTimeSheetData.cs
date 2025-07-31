using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayerHelper
{
    public class clsNormalParticipantTimeSheetData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();

        public void AddUpdate(clsNormalParticipantTimeSheet obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("NormalParticipantTimeSheet_AddUpdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@TimeSheetId", obj.TimeSheetId);
                    objCmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    objCmd.Parameters.AddWithValue("@StartTime", obj.StartTime);
                    objCmd.Parameters.AddWithValue("@EndTime", obj.EndTime);
                    objCmd.Parameters.AddWithValue("@Note", obj.Note);
                    objCmd.Parameters.AddWithValue("@NurturingId", obj.NurturingId);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.Parameters.AddWithValue("@Date", obj.Date);
                    objCmd.Parameters.AddWithValue("@StartTimeAmPm", obj.StartTimeAmPm);
                    objCmd.Parameters.AddWithValue("@EndTimeAmPm", obj.EndTimeAmPm);
                    objCmd.Parameters.AddWithValue("@LoginIPAddress", obj.LoginIPAddress);
                    objCmd.Parameters.AddWithValue("@LogoutIPAddress", obj.LogoutIPAddress);
                    objCmd.ExecuteNonQuery();
                }
            }
        }
        public clsNormalParticipantTimeSheet Load(int Id)
        {
            using (SqlConnection objconn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("NormalParticipantTimeSheet_Get", objconn))
                {
                    objconn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@TimeSheetId", Id);

                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsNormalParticipantTimeSheet objInfo = new clsNormalParticipantTimeSheet();
                            if (objDset.Tables[0].Rows[0]["TimeSheetId"] != DBNull.Value)
                                objInfo.TimeSheetId = Convert.ToInt32(objDset.Tables[0].Rows[0]["TimeSheetId"]);
                            objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[0]["ParticipantId"]);
                            objInfo.Date = Convert.ToDateTime(objDset.Tables[0].Rows[0]["Date"]);
                            objInfo.StartTime = Convert.ToDateTime(objDset.Tables[0].Rows[0]["StartTime"]);
                            //if (objDset.Tables[0].Rows[0]["EndTime"] != DBNull.Value)
                            objInfo.EndTime = Convert.ToDateTime(objDset.Tables[0].Rows[0]["EndTime"]);
                            objInfo.Note = Convert.ToString(objDset.Tables[0].Rows[0]["Note"]);
                            objInfo.StartTimeAmPm = Convert.ToString(objDset.Tables[0].Rows[0]["StartTimeAmPm"]);
                            objInfo.EndTimeAmPm = Convert.ToString(objDset.Tables[0].Rows[0]["EndTimeAmPm"]);
                            objInfo.LoginIPAddress = Convert.ToString(objDset.Tables[0].Rows[0]["LoginIpAddress"]);
                            if (objDset.Tables[0].Rows[0].ItemArray[6] != DBNull.Value)
                                objInfo.LogoutIPAddress = Convert.ToString(objDset.Tables[0].Rows[0]["LogoutIpAddress"]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }
        public List<clsNormalParticipantTimeSheet> LoadAll(clsNormalParticipantTimeSheet obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("NormalParticipantTimeSheet_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@keywords", obj.keywords);
                    objCmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    objCmd.Parameters.AddWithValue("@Date", obj.Date);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsNormalParticipantTimeSheet> objList = new List<clsNormalParticipantTimeSheet>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsNormalParticipantTimeSheet objInfo = new clsNormalParticipantTimeSheet();
                                objInfo.SNo = cnt + 1;
                                objInfo.TimeSheetId = Convert.ToInt32(objDset.Tables[0].Rows[cnt]["TimeSheetId"]);
                                objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[cnt]["ParticipantId"]);
                                objInfo.Participant = Convert.ToString(objDset.Tables[0].Rows[cnt]["Participant"]);
                                objInfo.Date = Convert.ToDateTime(objDset.Tables[0].Rows[cnt]["Date"]);
                                objInfo.StartTime = Convert.ToDateTime(objDset.Tables[0].Rows[cnt]["StartTime"]);
                                if (objDset.Tables[0].Rows[cnt]["EndTime"] != DBNull.Value)
                                    objInfo.EndTime = Convert.ToDateTime(objDset.Tables[0].Rows[cnt]["EndTime"]);
                                objInfo.Note = Convert.ToString(objDset.Tables[0].Rows[cnt]["Note"]);
                                objInfo.NurturingId = Convert.ToInt32(objDset.Tables[0].Rows[cnt]["NurturingId"]);
                                objInfo.StartTimeAmPm = Convert.ToString(objDset.Tables[0].Rows[cnt]["StartTimeAmPm"]);
                                objInfo.EndTimeAmPm = Convert.ToString(objDset.Tables[0].Rows[cnt]["EndTimeAmPm"]);
                                objInfo.LoginIPAddress = Convert.ToString(objDset.Tables[0].Rows[cnt]["LoginIpAddress"]);
                                objInfo.LogoutIPAddress = Convert.ToString(objDset.Tables[0].Rows[cnt]["LogoutIpAddress"]);
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
                using (SqlCommand objCmd = new SqlCommand("NormalParticipantTimeSheet_Remove", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@TimeSheetId", Id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }

        public List<clsNormalParticipantTimeSheet> LoadAllReports(clsNormalParticipantTimeSheet obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("NormalParticipantTimeSheet_List_Reports", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@keywords", obj.keywords);
                    objCmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    objCmd.Parameters.AddWithValue("@BranchId", obj.BranchId);
                    objCmd.Parameters.AddWithValue("@FromDate", obj.FromDate);
                    objCmd.Parameters.AddWithValue("@ToDate", obj.ToDate);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsNormalParticipantTimeSheet> objList = new List<clsNormalParticipantTimeSheet>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsNormalParticipantTimeSheet objInfo = new clsNormalParticipantTimeSheet();
                                objInfo.SNo = cnt + 1;
                                objInfo.TimeSheetId = Convert.ToInt32(objDset.Tables[0].Rows[cnt]["TimeSheetId"]);
                                objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[cnt]["ParticipantId"]);
                                objInfo.Date = Convert.ToDateTime(objDset.Tables[0].Rows[cnt]["Date"]);
                                objInfo.StartTime = Convert.ToDateTime(objDset.Tables[0].Rows[cnt]["StartTime"]);
                                if (objDset.Tables[0].Rows[cnt]["EndTime"] != DBNull.Value)
                                    objInfo.EndTime = Convert.ToDateTime(objDset.Tables[0].Rows[cnt]["EndTime"]);
                                objInfo.NurturingId = Convert.ToInt32(objDset.Tables[0].Rows[cnt]["NurturingId"]);
                                objInfo.Note = Convert.ToString(objDset.Tables[0].Rows[cnt]["Note"]);
                                objInfo.Participant = Convert.ToString(objDset.Tables[0].Rows[cnt]["Participant"]);
                                objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt]["CreatedOn"]);
                                if (objDset.Tables[0].Rows[cnt]["ModifiedOn"] != DBNull.Value)
                                    objInfo.ModifiedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt]["ModifiedOn"]);
                                objInfo.Location = Convert.ToString(objDset.Tables[0].Rows[cnt]["Location"]);
                                objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[cnt]["Employee"]);
                                if (objDset.Tables[0].Rows[cnt]["StartDate"] != DBNull.Value)
                                    objInfo.InternBatchDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt]["StartDate"]);
                                objInfo.ReferenceNo = Convert.ToString(objDset.Tables[0].Rows[cnt]["ReferenceNo"]);
                                objInfo.StartTimeAmPm = Convert.ToString(objDset.Tables[0].Rows[cnt]["StartTimeAmPm"]);
                                objInfo.EndTimeAmPm = Convert.ToString(objDset.Tables[0].Rows[cnt]["EndTimeAmPm"]);
                                objInfo.BranchId = Convert.ToInt32(objDset.Tables[0].Rows[cnt]["BranchId"]);
                                objInfo.LoginIPAddress = Convert.ToString(objDset.Tables[0].Rows[cnt]["LoginIpAddress"]);
                                objInfo.LogoutIPAddress = Convert.ToString(objDset.Tables[0].Rows[cnt]["LogoutIpAddress"]);

                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }


        public clsNormalParticipantTimeSheet LoadTimeSheet(clsNormalParticipantTimeSheet obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("NormalparticipantTimeSheetLogOut_Get", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    objCmd.Parameters.AddWithValue("@Date", obj.Date);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsNormalParticipantTimeSheet objInfo = new clsNormalParticipantTimeSheet();
                            objInfo.TimeSheetId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.Date = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.StartTime = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[3]);
                            if (objDset.Tables[0].Rows[0].ItemArray[4] != DBNull.Value)
                                objInfo.EndTime = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[4]);
                            objInfo.LoginIPAddress = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[5]);
                            if (objDset.Tables[0].Rows[0].ItemArray[6] != DBNull.Value)
                                objInfo.LogoutIPAddress = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[6]);
                            objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[7]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }

        internal clsNormalParticipantTimeSheet LoadTimeSheet(int obj)
        {
            throw new NotImplementedException();
        }
    }
}