using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayerHelper
{
    public class clsNurturingProcessStageStatusData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();
        public virtual void AddUpdate(clsNurturingProcessStageStatus obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("NurturingProcessStageStatus_AddUpdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@NurturingProcessStageStatusId", obj.NurturingProcessStageStatusId);
                    objCmd.Parameters.AddWithValue("@NurturingProcessStageId", obj.NurturingProcessStageId);
                    objCmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    objCmd.ExecuteNonQuery();
                }
            }
        }
        public virtual clsNurturingProcessStageStatus Load(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("NurturingProcessStageStatus_Get", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@NurturingProcessStageStatusId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsNurturingProcessStageStatus objInfo = new clsNurturingProcessStageStatus();
                            objInfo.NurturingProcessStageStatusId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.NurturingProcessStageId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[2]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }
        public virtual clsNurturingProcessStageStatus LoadGetDuration(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("NurturingProcessStageStatus_GetDuration", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ParticipantId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsNurturingProcessStageStatus objInfo = new clsNurturingProcessStageStatus();
                            objInfo.StageStartOn = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[0]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }
        public virtual clsNurturingProcessStageStatus LoadNurturingProcessStageStatusId(int ParticipantId, int NurturingProcessStageId)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("NurturingProcessStageStatus_GetNurturingProcessStageStatusId", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ParticipantId", ParticipantId);
                    objCmd.Parameters.AddWithValue("@NurturingProcessStageId", NurturingProcessStageId);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsNurturingProcessStageStatus objInfo = new clsNurturingProcessStageStatus();
                            objInfo.NurturingProcessStageStatusId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }
        public virtual List<clsNurturingProcessStageStatus> LoadAll(clsNurturingProcessStageStatus obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("NurturingProcessStageStatus_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ParticipantName", obj.ParticipantName);
                    objCmd.Parameters.AddWithValue("@NurturingProcessStageId", obj.NurturingProcessStageId);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsNurturingProcessStageStatus> objList = new List<clsNurturingProcessStageStatus>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsNurturingProcessStageStatus objInfo = new clsNurturingProcessStageStatus();
                                objInfo.SNo = cnt + 1;
                                objInfo.NurturingProcessStageStatusId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.NurturingProcessStageId = Convert.ToInt16(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.StageStartOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.ParticipantName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.NurturingProcessStageName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }
        public void Exit(int id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("NurturingProcessStageStatus_Exit", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@NurturingProcessStageStatusId", id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }
        public int LoadNurturingProcessStageStatusValidation(clsNurturingProcessStageStatus obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("NurturingProcessStageStatus_Validation", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    objCmd.Parameters.AddWithValue("@NurturingProcessStageId", obj.NurturingProcessStageId);
                    int Count = Convert.ToInt16(objCmd.ExecuteScalar());
                    return Count;
                }
            }
        }
        //public int LoadNurturingProcessStageStatusCount(clsNurturingProcessStageStatus obj)
        //{
        //    using (SqlConnection objConn = new SqlConnection(Constr))
        //    {
        //        using (SqlCommand objCmd = new SqlCommand("NurturingProcessStageStatus_Count", objConn))
        //        {
        //            objConn.Open();
        //            objCmd.CommandType = CommandType.StoredProcedure;
        //            objCmd.Parameters.AddWithValue("@NurturingProcessStageId", obj.NurturingProcessStageId);
        //            int Count = Convert.ToInt32(objCmd.ExecuteScalar());
        //            return Count;
        //        }
        //    }
        //}

        public clsNurturingProcessStageStatus NurturingDashboardCount(clsNurturingProcessStageStatus Obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("NurturingProcessStageStatus_Count", objConn))
                {
                    objCmd.CommandType = CommandType.StoredProcedure;
                    // objCmd.Parameters.AddWithValue("@ParticipantId", Obj.ParticipantId);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsNurturingProcessStageStatus objInfo = new clsNurturingProcessStageStatus();
                            objInfo.TotalBAConceptsRevision = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.TotalCapstoneProjects = Convert.ToInt32(objDset.Tables[0].Rows[1].ItemArray[0]);
                            objInfo.TotalProfileBuilding = Convert.ToInt32(objDset.Tables[0].Rows[2].ItemArray[0]);
                            objInfo.TotalWaterfallModel = Convert.ToInt32(objDset.Tables[0].Rows[3].ItemArray[0]);
                            objInfo.TotalAgileScrumModel = Convert.ToInt32(objDset.Tables[0].Rows[4].ItemArray[0]);
                            objInfo.TotalBAExposure = Convert.ToInt32(objDset.Tables[0].Rows[5].ItemArray[0]);
                            objInfo.TotalMocks = Convert.ToInt32(objDset.Tables[0].Rows[6].ItemArray[0]);
                            objInfo.TotalResume = Convert.ToInt32(objDset.Tables[0].Rows[7].ItemArray[0]);
                            objInfo.TotalInterviewReady = Convert.ToInt32(objDset.Tables[0].Rows[8].ItemArray[0]);
                            objInfo.TotalPreparation = Convert.ToInt32(objDset.Tables[0].Rows[9].ItemArray[0]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }
    }
}

