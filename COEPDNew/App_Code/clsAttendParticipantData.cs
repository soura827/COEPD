using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayerHelper
{
    public class clsAttendParticipantData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();

        public void AddUpdate(clsAttendParticipant obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("AttendParticipant_AddUpdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@AttendParticipantId", obj.AttendParticipantId);
                    objCmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    objCmd.Parameters.AddWithValue("@EnterTime", obj.EnterTime);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.Parameters.AddWithValue("@Date", obj.Date);
                    objCmd.ExecuteNonQuery();
                }
            }
        }

        public clsAttendParticipant Load(int Id)
        {
            using (SqlConnection objconn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("AttendParticipant_Get", objconn))
                {
                    objconn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@AttendParticipantId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsAttendParticipant objInfo = new clsAttendParticipant();
                            objInfo.AttendParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[0]["AttendParticipantId"]);
                            objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[0]["ParticipantId"]);
                            objInfo.Date = Convert.ToDateTime(objDset.Tables[0].Rows[0]["Date"]);
                            if (objDset.Tables[0].Rows[0]["EnterTime"] != DBNull.Value)
                                objInfo.EnterTime = Convert.ToDateTime(objDset.Tables[0].Rows[0]["EnterTime"]);
                            objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[0]["IsActive"]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }


        public List<clsAttendParticipant> LoadAll(clsAttendParticipant obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("AttendParticipant_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@keywords", obj.keywords);
                    objCmd.Parameters.AddWithValue("@Date", obj.Date);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsAttendParticipant> objList = new List<clsAttendParticipant>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsAttendParticipant objInfo = new clsAttendParticipant();
                                objInfo.SNo = cnt + 1;
                                objInfo.AttendParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[cnt]["AttendParticipantId"]);
                                objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[cnt]["ParticipantId"]);
                                objInfo.Participant = Convert.ToString(objDset.Tables[0].Rows[cnt]["Participant"]);
                                if (objDset.Tables[0].Rows[cnt]["ReferenceNo"] != DBNull.Value && objDset.Tables[0].Rows[cnt]["ReferenceNo"] != "")
                                    objInfo.ReferenceNo = Convert.ToInt32(objDset.Tables[0].Rows[cnt]["ReferenceNo"]);
                                if (objDset.Tables[0].Rows[cnt]["BatchId"] != DBNull.Value && objDset.Tables[0].Rows[cnt]["BatchId"] != "")
                                    objInfo.BatchId = Convert.ToInt32(objDset.Tables[0].Rows[cnt]["BatchId"]);
                                objInfo.StartDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt]["StartDate"]);
                                if (objDset.Tables[0].Rows[cnt]["EnterTime"] != DBNull.Value)
                                    objInfo.EnterTime = Convert.ToDateTime(objDset.Tables[0].Rows[cnt]["EnterTime"]);
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
                using (SqlCommand objCmd = new SqlCommand("AttendParticipant_Remove", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@AttendParticipantId", Id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }

    }
}