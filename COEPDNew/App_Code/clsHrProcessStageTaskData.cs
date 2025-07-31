using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace DataAccessLayerHelper
{


    public class clsHrProcessStageTaskData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs6"].ConnectionString.ToString();
        public virtual void AddUpdate(clsHrProcessStageTask obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("HrProcessStageTask_AddUpdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@HrProcessStageTaskId", obj.HrProcessStageTaskId);
                    objCmd.Parameters.AddWithValue("@HrProcessStageTaskName", obj.HrProcessStageTaskName);
                    objCmd.Parameters.AddWithValue("@HrProcessStageId", obj.HrProcessStageId);
                 
                    objCmd.Parameters.AddWithValue("@Weightage", obj.Weightage);
                    objCmd.Parameters.AddWithValue("@TimeFrame", obj.TimeFrame);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.ExecuteNonQuery();
                }
            }
        }
        public int LoadHrProcessStageTaskValidation(clsHrProcessStageTask obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("HrProcessStageTask_Validation", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@HrProcessStageTaskName", obj.HrProcessStageTaskName);
                    int Count = Convert.ToInt16(objCmd.ExecuteScalar());
                    return Count;
                }
            }
        }
        public virtual List<clsHrProcessStageTask> LoadAll(clsHrProcessStageTask obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("HrProcessStageTask_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@HrProcessStageTaskName", obj.HrProcessStageTaskName);
                    objCmd.Parameters.AddWithValue("@HrProcessStageName", obj.HrProcessStageName);
                    objCmd.Parameters.AddWithValue("@CreatedName", obj.CreatedName);
                    objCmd.Parameters.AddWithValue("@ModifiedName", obj.ModifiedName);
                    objCmd.Parameters.AddWithValue("@HrProcessStageId", obj.HrProcessStageId);
                    //objCmd.Parameters.AddWithValue("@HrProcessStageTaskId", obj.HrProcessStageTaskId);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsHrProcessStageTask> objList = new List<clsHrProcessStageTask>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsHrProcessStageTask objInfo = new clsHrProcessStageTask();
                                objInfo.SNo = cnt + 1;
                                objInfo.HrProcessStageTaskId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.HrProcessStageId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.HrProcessStageTaskName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.Weightage = Convert.ToInt16(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.TimeFrame = Convert.ToInt16(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.HrProcessStageName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[5]);
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
       
        public virtual clsHrProcessStageTask Load(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("HrProcessStageTask_Get", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("HrProcessStageTaskId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsHrProcessStageTask objInfo = new clsHrProcessStageTask();
                            if (objDset.Tables[0].Rows[0].ItemArray[0] != null)
                                objInfo.HrProcessStageTaskId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.HrProcessStageId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.HrProcessStageTaskName = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.Weightage = Convert.ToInt16(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.TimeFrame = Convert.ToInt16(objDset.Tables[0].Rows[0].ItemArray[4]);
                            //if (objDset.Tables[0].Rows[0].ItemArray[5] != null)
                            //    objInfo.StatusCode = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[5]);
                            
                            return objInfo;
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
                using (SqlCommand objCmd = new SqlCommand("HrProcessStageTask_Remove", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("HrProcessStageTaskId", Id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }












        public clsHrProcessStageTask HrDashboardCount(clsHrProcessStageTask Obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("HrDashboard_Count", objConn))
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
                            clsHrProcessStageTask objInfo = new clsHrProcessStageTask();
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

        public List<clsHrProcessStageTask> LoadAllAvilable(clsHrProcessStageTask obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("HrProcessStageTask_List_NotAssigned", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    //objCmd.Parameters.AddWithValue("@keywords", obj.keywords);
                    objCmd.Parameters.AddWithValue("@HrProcessStageId", obj.HrProcessStageId);
                    objCmd.Parameters.AddWithValue("@EmployeeId", obj.EmployeeId);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsHrProcessStageTask> objList = new List<clsHrProcessStageTask>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsHrProcessStageTask objInfo = new clsHrProcessStageTask();
                                objInfo.SNo = cnt + 1;
                                objInfo.HrProcessStageId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.HrProcessStageTaskId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.HrProcessStageName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.HrProcessStageTaskName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
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