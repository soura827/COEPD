using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace DataAccessLayerHelper
{
    public class clsAutoAssignData
    {
        public string constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();

        public void AddUpdate(clsAutoAssign obj)
        {
            using (SqlConnection objConn = new SqlConnection(constr))
            {
                using (SqlCommand objCmd = new SqlCommand("NurturingAutoAssignTasks_AddUpdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@NurturingAutoAssignId", obj.NurturingAutoAssignId);
                    //objCmd.Parameters.AddWithValue("@NurturingProcessStageId", obj.NurturingProcessStageId);
                    objCmd.Parameters.AddWithValue("@NurturingProcessStageTaskId", obj.NurturingProcessStageTaskId);
                    objCmd.Parameters.AddWithValue("@SenderImagePath", obj.SenderImagePath);
                    objCmd.Parameters.AddWithValue("@TargetDateInterval", obj.TargetDateInterval);
                    objCmd.Parameters.AddWithValue("@Notes", obj.Notes);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.ExecuteNonQuery();
                }
            }
        }
        public clsAutoAssign Load(int Id)
        {
            using (SqlConnection objconn = new SqlConnection(constr))
            {
                using (SqlCommand objCmd = new SqlCommand("NurturingAutoAssignTasks_Get", objconn))
                {
                    objconn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@NurturingAutoAssignId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsAutoAssign objInfo = new clsAutoAssign();
                            objInfo.NurturingAutoAssignId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.NurturingProcessStageId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.NurturingProcessStageTaskId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.SenderImagePath = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.TargetDateInterval = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[4]);
                            objInfo.Notes = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[5]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }
        public List<clsAutoAssign> LoadAll(clsAutoAssign obj)
        {
            using (SqlConnection objConn = new SqlConnection(constr))
            {
                using (SqlCommand objCmd = new SqlCommand("NurturingAutoAssignTasks_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    //objCmd.Parameters.AddWithValue("@NurturingAutoAssignId", obj.NurturingAutoAssignId);
                    objCmd.Parameters.AddWithValue("@NurturingProcessStageId", obj.NurturingProcessStageId);
                    objCmd.Parameters.AddWithValue("@NurturingProcessStageTaskId", obj.NurturingProcessStageTaskId);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsAutoAssign> objList = new List<clsAutoAssign>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsAutoAssign objInfo = new clsAutoAssign();
                                objInfo.SNo = cnt + 1;
                                objInfo.NurturingAutoAssignId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.NurturingProcessStageName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.NurturingProcessStageTaskName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.SenderImagePath = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.TargetDateInterval = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.Notes = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[5]);
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
            using (SqlConnection objConn = new SqlConnection(constr))
            {
                using (SqlCommand objCmd = new SqlCommand("NurturingAutoAssignTasks_Remove", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@NurturingAutoAssignId", Id);
                    objCmd.ExecuteNonQuery();
                }
            }

        }
    }
}