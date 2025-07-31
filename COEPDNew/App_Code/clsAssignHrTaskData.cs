using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace DataAccessLayerHelper
{
    public class clsAssignHrTaskData
    {
        public string constr = ConfigurationManager.ConnectionStrings["cs6"].ConnectionString.ToString();
        public void AddUpdate(clsAssignHrTask obj)
        {
            using (SqlConnection objConn = new SqlConnection(constr))
            {
                using (SqlCommand objCmd = new SqlCommand("AssignHrTask_AddUpdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@AssignHrTaskId", obj.AssignHrTaskId);
                    objCmd.Parameters.AddWithValue("@HrTaskId", obj.HrProcessStageTaskId);
                    objCmd.Parameters.AddWithValue("@HrProcessSlotsId", obj.HrProcessSlotsId);
                    objCmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    objCmd.Parameters.AddWithValue("@TargetDate", obj.TargetDate);
                    objCmd.Parameters.AddWithValue("@TargetDateInterval", obj.TargetDateInterval);
                    objCmd.Parameters.AddWithValue("@HrProcessStageTaskId", obj.HrProcessStageTaskId);
                    objCmd.Parameters.AddWithValue("@MentorInputs", obj.MentorInputs);
                    objCmd.Parameters.AddWithValue("@ParticipantInputs", obj.ParticipantInputs);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.Parameters.AddWithValue("@ExamScore", obj.ExamScore);
                    //SqlParameter paramout = new SqlParameter("@Out_msg", SqlDbType.VarChar, 500);
                    //paramout.Direction = ParameterDirection.Output;
                    //objCmd.Parameters.Add(paramout);
                    objCmd.ExecuteNonQuery();
                    //int outmsg = Convert.ToInt32(paramout.SqlValue.ToString());
                    //return outmsg;
                }
            }
        }
        public clsAssignHrTask Load(int Id)
        {
            using (SqlConnection objconn = new SqlConnection(constr))
            {
                using (SqlCommand objCmd = new SqlCommand("AssignHrTask_Get", objconn))
                {
                    objconn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@AssignHrTaskId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsAssignHrTask objInfo = new clsAssignHrTask();
                            objInfo.AssignHrTaskId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            if (objDset.Tables[0].Rows[0].ItemArray[1] != DBNull.Value)
                                objInfo.HrTaskId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[1]);
                            if (objDset.Tables[0].Rows[0].ItemArray[2] != DBNull.Value)
                                objInfo.HrProcessSlotsId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.HrProcessStageId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.HrProcessStageTaskId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[4]);
                            objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[5]);
                            objInfo.Participant = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[6]);
                            if (objDset.Tables[0].Rows[0].ItemArray[7] != DBNull.Value)
                                objInfo.TaskAssignedTo = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[7]);
                            if (objDset.Tables[0].Rows[0].ItemArray[8] != DBNull.Value)
                                objInfo.TaskCompletedOn = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[8]);
                            if (objDset.Tables[0].Rows[0].ItemArray[9] != DBNull.Value)
                                objInfo.TargetDate = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[9]);
                            if (objDset.Tables[0].Rows[0].ItemArray[10] != DBNull.Value)
                                objInfo.EvaluatedBy = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[10]);
                            if (objDset.Tables[0].Rows[0].ItemArray[11] != DBNull.Value)
                                objInfo.EvaluatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[11]);
                            if (objDset.Tables[0].Rows[0].ItemArray[12] != DBNull.Value)
                                objInfo.ApprovedBy = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[12]);
                            if (objDset.Tables[0].Rows[0].ItemArray[13] != DBNull.Value)
                                objInfo.ApprovedOn = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[13]);
                            objInfo.IsApproved = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[14]);
                            objInfo.SenderImagePath = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[15]);
                            objInfo.TaskInputs = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[16]);
                            if (objDset.Tables[0].Rows[0].ItemArray[17] != DBNull.Value)
                                objInfo.ExamScore = Convert.ToDecimal(objDset.Tables[0].Rows[0].ItemArray[17]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }
        public List<clsAssignHrTask> LoadAll(clsAssignHrTask obj)
        {
            using (SqlConnection objConn = new SqlConnection(constr))
            {
                using (SqlCommand objCmd = new SqlCommand("AssignHrTask_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@Keywords", obj.keywords);
                    objCmd.Parameters.AddWithValue("@Location", obj.Location);
                    objCmd.Parameters.AddWithValue("@HrProcessStageTaskName", obj.HrProcessStageTaskName);
                    objCmd.Parameters.AddWithValue("@IsApproved", obj.IsApproved);
                    objCmd.Parameters.AddWithValue("@ApprovedBy", obj.ApprovedBy);
                    objCmd.Parameters.AddWithValue("@ExamScore", obj.ExamScore);
                    objCmd.Parameters.AddWithValue("@HrProcessStageId", obj.HrProcessStageId);
                    objCmd.Parameters.AddWithValue("@HrProcessStageTaskId", obj.HrProcessStageTaskId);
                    objCmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    objCmd.Parameters.AddWithValue("@AssignedByName", obj.Fullname);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsAssignHrTask> objList = new List<clsAssignHrTask>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsAssignHrTask objInfo = new clsAssignHrTask();
                                objInfo.SNo = cnt + 1;
                                objInfo.AssignHrTaskId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.Participant = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.Location = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[4] != DBNull.Value)
                                    objInfo.HrProcessStageTaskId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.HrProcessStageName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.HrProcessStageTaskName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.SenderImagePath = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.ReceiverImagePath = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.Fullname = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[10] != DBNull.Value)
                                    objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[11] != DBNull.Value)
                                    objInfo.TargetDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[11]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[12] != DBNull.Value)
                                    objInfo.TaskAssignedTo = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[12]);
                                objInfo.TaskInputs = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[13]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[14] != DBNull.Value)
                                    objInfo.SlotDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[14]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[15] != DBNull.Value)
                                    objInfo.SlotStartTime = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[15]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[16] != DBNull.Value)
                                    objInfo.SlotEndTime = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[16]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[17] != DBNull.Value)
                                    objInfo.TaskCompletedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[17]);
                                objInfo.IsApproved = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[18]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[19] != DBNull.Value)
                                    objInfo.ApprovedBy = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[19]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[20] != DBNull.Value)
                                    objInfo.ApprovedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[20]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[21] != DBNull.Value)
                                    objInfo.EvaluatedBy = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[21]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[22] != DBNull.Value)
                                    objInfo.EvaluatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[22]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[23] != DBNull.Value)
                                    objInfo.ExamScore = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[23]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }
        public int LoadAssignNurturingTaskValidation(clsAssignHrTask obj)
        {
            using (SqlConnection objConn = new SqlConnection(constr))
            {
                using (SqlCommand objCmd = new SqlCommand("AssignHrTask_Validation", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    objCmd.Parameters.AddWithValue("@HrProcessStageTaskId", obj.HrProcessStageTaskId);
                    int Count = Convert.ToInt32(objCmd.ExecuteScalar());
                    return Count;
                }
            }
        }

        public void UpdateExamFile(clsAssignHrTask obj)
        {
            using (SqlConnection objConn = new SqlConnection(constr))
            {
                using (SqlCommand objCmd = new SqlCommand("AssignHrTask_UpdateExamFile", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@AssignHrTaskId", obj.AssignHrTaskId);
                    objCmd.Parameters.AddWithValue("@ReceiverImagePath", obj.ReceiverImagePath);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.ExecuteNonQuery();

                }
            }
        }
    }
}
