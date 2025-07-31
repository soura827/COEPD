using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayerHelper
{
    public class clsNurturingProcessStageTaskData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();
        public virtual void AddUpdate(clsNurturingProcessStageTask obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("NurturingProcessStageTask_AddUpdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@NurturingProcessStageTaskId", obj.NurturingProcessStageTaskId);
                    objCmd.Parameters.AddWithValue("@NurturingProcessStageId", obj.NurturingProcessStageId);
                    objCmd.Parameters.AddWithValue("@NurturingProcessStageTaskName", obj.NurturingProcessStageTaskName);
                    objCmd.Parameters.AddWithValue("@Weightage", obj.Weightage);
                    objCmd.Parameters.AddWithValue("@TimeFrame", obj.TimeFrame);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.ExecuteNonQuery();
                }
            }
        }
        public virtual clsNurturingProcessStageTask Load(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("NurturingProcessStageTask_Get", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("NurturingProcessStageTaskId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsNurturingProcessStageTask objInfo = new clsNurturingProcessStageTask();
                            objInfo.NurturingProcessStageTaskId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.NurturingProcessStageId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.NurturingProcessStageTaskName = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.Weightage = Convert.ToInt16(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.TimeFrame = Convert.ToInt16(objDset.Tables[0].Rows[0].ItemArray[4]);
                            if (objDset.Tables[0].Rows[0].ItemArray[5] != null)
                            {
                                objInfo.StatusCode = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[5]);
                            }
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }
        public virtual List<clsNurturingProcessStageTask> LoadAll(clsNurturingProcessStageTask obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("NurturingProcessStageTask_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@NurturingProcessStageTaskName", obj.NurturingProcessStageTaskName);
                    objCmd.Parameters.AddWithValue("@NurturingProcessStageName", obj.NurturingProcessStageTaskName);
                    objCmd.Parameters.AddWithValue("@CreatedName", obj.CreatedName);
                    objCmd.Parameters.AddWithValue("@ModifiedName", obj.ModifiedName);
                    objCmd.Parameters.AddWithValue("NurturingProcessStageId", obj.NurturingProcessStageId);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsNurturingProcessStageTask> objList = new List<clsNurturingProcessStageTask>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsNurturingProcessStageTask objInfo = new clsNurturingProcessStageTask();
                                objInfo.SNo = cnt + 1;
                                objInfo.NurturingProcessStageTaskId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.NurturingProcessStageId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.NurturingProcessStageTaskName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.Weightage = Convert.ToInt16(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.TimeFrame = Convert.ToInt16(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.NurturingProcessStageName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.CreatedName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[8] != DBNull.Value)
                                    objInfo.ModifiedName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[9] != DBNull.Value)
                                    objInfo.ModifiedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }
        public void Remove(int id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("NurturingProcessStageTask_Remove", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("NurturingProcessStageTaskId", id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }
        public int LoadNurturingProcessStageTaskValidation(clsNurturingProcessStageTask obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("NurturingProcessStageTask_Validation", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@NurturingProcessStageTaskName", obj.NurturingProcessStageTaskName);
                    int Count = Convert.ToInt16(objCmd.ExecuteScalar());
                    return Count;
                }
            }
        }
        public clsNurturingProcessStageTask NurturingDashboardCount(clsNurturingProcessStageTask Obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("NurturingDashboard_Count", objConn))
                {
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ParticipantId", Obj.ParticipantId);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsNurturingProcessStageTask objInfo = new clsNurturingProcessStageTask();
                            objInfo.TotalBAConceptsRevision = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.TotalCapstoneProjects = Convert.ToInt32(objDset.Tables[0].Rows[1].ItemArray[0]);
                            objInfo.TotalProfileBuilding = Convert.ToInt32(objDset.Tables[0].Rows[2].ItemArray[0]);
                            objInfo.TotalWaterfallModel = Convert.ToInt32(objDset.Tables[0].Rows[3].ItemArray[0]);
                            objInfo.TotalAgileScrumModel = Convert.ToInt32(objDset.Tables[0].Rows[4].ItemArray[0]);
                            objInfo.TotalBAExposure = Convert.ToInt32(objDset.Tables[0].Rows[5].ItemArray[0]);
                            objInfo.TotalMocks = Convert.ToInt32(objDset.Tables[0].Rows[6].ItemArray[0]);
                            objInfo.TotalResume = Convert.ToInt32(objDset.Tables[0].Rows[7].ItemArray[0]);
                            objInfo.TotalInterviewReady = Convert.ToInt32(objDset.Tables[0].Rows[8].ItemArray[0]);
                            objInfo.CountBAConceptsRevision = Convert.ToInt32(objDset.Tables[0].Rows[9].ItemArray[0]);
                            objInfo.CountCapstoneProjects = Convert.ToInt32(objDset.Tables[0].Rows[10].ItemArray[0]);
                            objInfo.CountProfileBuilding = Convert.ToInt32(objDset.Tables[0].Rows[11].ItemArray[0]);
                            objInfo.CountWaterfallModel = Convert.ToInt32(objDset.Tables[0].Rows[12].ItemArray[0]);
                            objInfo.CountAgileScrumModel = Convert.ToInt32(objDset.Tables[0].Rows[13].ItemArray[0]);
                            objInfo.CountBAExposure = Convert.ToInt32(objDset.Tables[0].Rows[14].ItemArray[0]);
                            objInfo.CountMocks = Convert.ToInt32(objDset.Tables[0].Rows[15].ItemArray[0]);
                            objInfo.CountResume = Convert.ToInt32(objDset.Tables[0].Rows[16].ItemArray[0]);
                            objInfo.CountInterviewReady = Convert.ToInt32(objDset.Tables[0].Rows[17].ItemArray[0]);
                            objInfo.TotalPreparation = Convert.ToInt32(objDset.Tables[0].Rows[18].ItemArray[0]);
                            objInfo.CountPreparation = Convert.ToInt32(objDset.Tables[0].Rows[19].ItemArray[0]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }

        public List<clsNurturingProcessStageTask> LoadAllAvilable(clsNurturingProcessStageTask obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("NurturingProcessStageTask_List_NotAssigned", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    //objCmd.Parameters.AddWithValue("@keywords", obj.keywords);
                    objCmd.Parameters.AddWithValue("@NurturingProcessStageId", obj.NurturingProcessStageId);
                    objCmd.Parameters.AddWithValue("@EmployeeId", obj.EmployeeId);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsNurturingProcessStageTask> objList = new List<clsNurturingProcessStageTask>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsNurturingProcessStageTask objInfo = new clsNurturingProcessStageTask();
                                objInfo.SNo = cnt + 1;
                                objInfo.NurturingProcessStageTaskId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.NurturingProcessStageName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.NurturingProcessStageTaskName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
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
