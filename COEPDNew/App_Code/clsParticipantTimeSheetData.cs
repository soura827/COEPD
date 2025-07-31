using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace DataAccessLayerHelper
{
    public class clsParticipantTimeSheetData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();

        public void AddUpdate(clsParticipantTimeSheet obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ParticipantTimeSheet_AddUpdate", objConn))
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
                    objCmd.ExecuteNonQuery();
                }
            }
        }
        public clsParticipantTimeSheet Load(int Id)
        {
            using (SqlConnection objconn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ParticipantTimeSheet_Get", objconn))
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
                            clsParticipantTimeSheet objInfo = new clsParticipantTimeSheet();
                            objInfo.TimeSheetId = Convert.ToInt32(objDset.Tables[0].Rows[0]["TimeSheetId"]);
                            objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[0]["ParticipantId"]);
                            objInfo.Date = Convert.ToDateTime(objDset.Tables[0].Rows[0]["Date"]);
                            objInfo.StartTime = Convert.ToDateTime(objDset.Tables[0].Rows[0]["StartTime"]);
                            if (objDset.Tables[0].Rows[0]["EndTime"] != DBNull.Value)
                                objInfo.EndTime = Convert.ToDateTime(objDset.Tables[0].Rows[0]["EndTime"]);
                            objInfo.Note = Convert.ToString(objDset.Tables[0].Rows[0]["Note"]);

                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }
        public List<clsParticipantTimeSheet> LoadAll(clsParticipantTimeSheet obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ParticipantTimeSheet_List", objConn))
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
                            List<clsParticipantTimeSheet> objList = new List<clsParticipantTimeSheet>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsParticipantTimeSheet objInfo = new clsParticipantTimeSheet();
                                objInfo.SNo = cnt + 1;
                                objInfo.TimeSheetId = Convert.ToInt32(objDset.Tables[0].Rows[cnt]["TimeSheetId"]);
                                objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[cnt]["ParticipantId"]);
                                objInfo.Date = Convert.ToDateTime(objDset.Tables[0].Rows[cnt]["Date"]);
                                objInfo.StartTime = Convert.ToDateTime(objDset.Tables[0].Rows[cnt]["StartTime"]);
                                if (objDset.Tables[0].Rows[cnt]["EndTime"] != DBNull.Value)
                                    objInfo.EndTime = Convert.ToDateTime(objDset.Tables[0].Rows[cnt]["EndTime"]);
                                objInfo.Note = Convert.ToString(objDset.Tables[0].Rows[cnt]["Note"]);
                                objInfo.NurturingId = Convert.ToInt32(objDset.Tables[0].Rows[cnt]["NurturingId"]);
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
                using (SqlCommand objCmd = new SqlCommand("ParticipantTimeSheet_Remove", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@TimeSheetId", Id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }

        public List<clsParticipantTimeSheet> LoadAllReports(clsParticipantTimeSheet obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ParticipantTimeSheet_List_Reports", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@keywords", obj.keywords);
                    objCmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    objCmd.Parameters.AddWithValue("@FromDate", obj.FromDate);
                    objCmd.Parameters.AddWithValue("@ToDate", obj.ToDate);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsParticipantTimeSheet> objList = new List<clsParticipantTimeSheet>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsParticipantTimeSheet objInfo = new clsParticipantTimeSheet();
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
                                if (objDset.Tables[0].Rows[cnt]["InternBatchDate"] != DBNull.Value)
                                    objInfo.InternBatchDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt]["InternBatchDate"]);
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