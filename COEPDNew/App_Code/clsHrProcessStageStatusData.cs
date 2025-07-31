using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

//public class clsHrProcessStageStatusData
//{
//    public clsHrProcessStageStatusData()
//    {

//    }
//}
namespace DataAccessLayerHelper
{
    public class clsHrProcessStageStatusData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs6"].ConnectionString.ToString();
        public virtual void AddUpdate(clsHrProcessStageStatus obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("HrProcessStageStatus_AddUpdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@HrProcessStageStatusId", obj.HrProcessStageStatusId);
                    objCmd.Parameters.AddWithValue("@HrProcessStageId", obj.HrProcessStageId);
                    objCmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    objCmd.ExecuteNonQuery();
                }
            }
        }
        public virtual clsHrProcessStageStatus Load(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("HrProcessStageStatus_Get", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@HrProcessStageStatusId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsHrProcessStageStatus objInfo = new clsHrProcessStageStatus();
                            objInfo.HrProcessStageStatusId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.HrProcessStageId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[2]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }
        public virtual clsHrProcessStageStatus LoadGetDuration(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("HrProcessStageStatus_GetDuration", objConn))
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
                            clsHrProcessStageStatus objInfo = new clsHrProcessStageStatus();
                            objInfo.StageStartOn = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[0]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }
        public virtual clsHrProcessStageStatus LoadHrProcessStageStatusId(int ParticipantId, int HrProcessStageId)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("HrProcessStageStatus_GetHrProcessStageStatusId", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ParticipantId", ParticipantId);
                    objCmd.Parameters.AddWithValue("@HrProcessStageId", HrProcessStageId);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsHrProcessStageStatus objInfo = new clsHrProcessStageStatus();
                            objInfo.HrProcessStageStatusId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }
        public virtual List<clsHrProcessStageStatus> LoadAll(clsHrProcessStageStatus obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("HrProcessStageStatus_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ParticipantName", obj.ParticipantName);
                    objCmd.Parameters.AddWithValue("@HrProcessStageId", obj.HrProcessStageId);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsHrProcessStageStatus> objList = new List<clsHrProcessStageStatus>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsHrProcessStageStatus objInfo = new clsHrProcessStageStatus();
                                objInfo.SNo = cnt + 1;
                                objInfo.HrProcessStageStatusId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.HrProcessStageId = Convert.ToInt16(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.StageStartOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.ParticipantName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.HrProcessStageName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[5]);
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
                using (SqlCommand objCmd = new SqlCommand("HrProcessStageStatus_Exit", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@HrProcessStageStatusId", id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }
        public int LoadHrProcessStageStatusValidation(clsHrProcessStageStatus obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("HrProcessStageStatus_Validation", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    objCmd.Parameters.AddWithValue("@HrProcessStageId", obj.HrProcessStageId);
                    int Count = Convert.ToInt16(objCmd.ExecuteScalar());
                    return Count;
                }
            }
        }
        //public int LoadHrProcessStageStatusCount(clsHrProcessStageStatus obj)
        //{
        //    using (SqlConnection objConn = new SqlConnection(Constr))
        //    {
        //        using (SqlCommand objCmd = new SqlCommand("HrProcessStageStatus_Count", objConn))
        //        {
        //            objConn.Open();
        //            objCmd.CommandType = CommandType.StoredProcedure;
        //            objCmd.Parameters.AddWithValue("@HrProcessStageId", obj.HrProcessStageId);
        //            int Count = Convert.ToInt32(objCmd.ExecuteScalar());
        //            return Count;
        //        }
        //    }
        //}

        //public clsHrProcessStageStatus HrDashboardCount(clsHrProcessStageStatus Obj)
        //{
        //    using (SqlConnection objConn = new SqlConnection(Constr))
        //    {
        //        using (SqlCommand objCmd = new SqlCommand("HrProcessStageStatus_Count", objConn))
        //        {
        //            objCmd.CommandType = CommandType.StoredProcedure;
        //            // objCmd.Parameters.AddWithValue("@ParticipantId", Obj.ParticipantId);
        //            DataSet objDset = new DataSet();
        //            SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
        //            objAdp.Fill(objDset);
        //            if (objDset.Tables.Count > 0)
        //            {
        //                if (objDset.Tables[0].Rows.Count > 0)
        //                {
        //                    clsHrProcessStageStatus objInfo = new clsHrProcessStageStatus();
        //                    objInfo.TotalBAConceptsRevision = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
        //                    objInfo.TotalCapstoneProjects = Convert.ToInt32(objDset.Tables[0].Rows[1].ItemArray[0]);
        //                    objInfo.TotalProfileBuilding = Convert.ToInt32(objDset.Tables[0].Rows[2].ItemArray[0]);
        //                    objInfo.TotalWaterfallModel = Convert.ToInt32(objDset.Tables[0].Rows[3].ItemArray[0]);
        //                    objInfo.TotalAgileScrumModel = Convert.ToInt32(objDset.Tables[0].Rows[4].ItemArray[0]);
        //                    objInfo.TotalBAExposure = Convert.ToInt32(objDset.Tables[0].Rows[5].ItemArray[0]);
        //                    objInfo.TotalMocks = Convert.ToInt32(objDset.Tables[0].Rows[6].ItemArray[0]);
        //                    objInfo.TotalResume = Convert.ToInt32(objDset.Tables[0].Rows[7].ItemArray[0]);
        //                    objInfo.TotalInterviewReady = Convert.ToInt32(objDset.Tables[0].Rows[8].ItemArray[0]);
        //                    objInfo.TotalPreparation = Convert.ToInt32(objDset.Tables[0].Rows[9].ItemArray[0]);
        //                    return objInfo;
        //                }
        //            }
        //            return null;
        //        }
        //    }
        //}
    }
}
