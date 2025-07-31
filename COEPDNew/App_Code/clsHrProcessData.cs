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
    public class clsHrProcessData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs6"].ConnectionString.ToString();

        public void AddUpdate(clsHrProcess obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("HrProcess_AddUpdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@HrProcessStageTaskId", obj.HrProcessStageTaskId);
                    objCmd.Parameters.AddWithValue("@HrProcessStageId", obj.HrProcessStageId);
                    objCmd.Parameters.AddWithValue("@EmployeeId", obj.EmployeeId);
                    objCmd.Parameters.AddWithValue("@AssignedEmployeeId", obj.AssignedEmployeeId);
                    objCmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    objCmd.Parameters.AddWithValue("@ExamDateTime", obj.ExamDate);
                    objCmd.Parameters.AddWithValue("@EvaluatedBy", obj.EvaluatedBy);
                    objCmd.Parameters.AddWithValue("@EvaluatedOn", obj.EvaluatedOn);
                    objCmd.Parameters.AddWithValue("@ApprovedBy", obj.ApprovedBy);
                    objCmd.Parameters.AddWithValue("@ApprovedDate", obj.ApprovedDate);
                    objCmd.Parameters.AddWithValue("@ExamScore", obj.ExamScore);
                    objCmd.Parameters.AddWithValue("@SenderImagePath", obj.SenderImagePath);
                    objCmd.Parameters.AddWithValue("@ReceiverImagePath", obj.ReceiverImagePath);
                    objCmd.Parameters.AddWithValue("@Notes", obj.Notes);
                    objCmd.Parameters.AddWithValue("@IsApproved", obj.IsApproved);
                    //objCmd.Parameters.AddWithValue("@CreatedOn", obj.CreatedOn);
                     objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.Parameters.AddWithValue("@TargetDate", obj.TargetDate);
                    objCmd.Parameters.AddWithValue("@HrProcessSlotsId", obj.HrProcessSlotsId);
                    objCmd.Parameters.AddWithValue("@PlacementInductionId", obj.PlacementInductionId);
                    objCmd.ExecuteNonQuery();
                }
            }
        }

        public clsHrProcess Load(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("HrProcess_Get", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@HrProcessId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsHrProcess objInfo = new clsHrProcess();
                            objInfo.HrProcessId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.HrProcessStageId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.HrProcessStageTaskId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.EmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.AssignedEmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[4]);
                            objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[5]);
                            if (objDset.Tables[0].Rows[0].ItemArray[6] != DBNull.Value)
                                objInfo.ExamDate = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[6]);
                            if (objDset.Tables[0].Rows[0].ItemArray[7] != DBNull.Value)
                                objInfo.EvaluatedBy = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[7]);
                            if (objDset.Tables[0].Rows[0].ItemArray[8] != DBNull.Value)
                                objInfo.EvaluatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[8]);
                            if (objDset.Tables[0].Rows[0].ItemArray[9] != DBNull.Value)
                                objInfo.ExamScore = Convert.ToDecimal(objDset.Tables[0].Rows[0].ItemArray[9]);
                            objInfo.ApprovedBy = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[10]);
                            if (objDset.Tables[0].Rows[0].ItemArray[11] != DBNull.Value)
                                objInfo.ApprovedDate = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[11]);
                            objInfo.SenderImagePath = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[12]);
                            objInfo.ReceiverImagePath = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[13]);
                            objInfo.Notes = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[14]);
                            objInfo.IsApproved = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[15]);
                            if (objDset.Tables[0].Rows[0].ItemArray[16] != DBNull.Value)
                                objInfo.TargetDate = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[16]);
                            if (objDset.Tables[0].Rows[0].ItemArray[17] != DBNull.Value)
                                objInfo.HrProcessSlotsId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[17]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }

        public clsHrProcess LoadFinalizedResume(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("HrProcess_GetFinalizedResume", objConn))
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
                            clsHrProcess objInfo = new clsHrProcess();
                            objInfo.HrProcessId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.HrProcessStageTaskId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.ApprovedDate = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.ReceiverImagePath = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[4]);
                            objInfo.IsApproved = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[5]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }

        public List<clsHrProcess> LoadAll(clsHrProcess obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("HrProcess_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@Keywords", obj.Keywords);
                    objCmd.Parameters.AddWithValue("@IsApproved", obj.IsApproved);
                    //objCmd.Parameters.AddWithValue("@HrProcessStageTaskId", obj.HrProcessStageTaskId);
                    objCmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    objCmd.Parameters.AddWithValue("@HrProcessStageId", obj.HrProcessStageId);
                    objCmd.Parameters.AddWithValue("@Location", obj.Location);
                    //objCmd.Parameters.AddWithValue("@HrProcessStageTaskName", obj.HrProcessStageTaskName);
                    objCmd.Parameters.AddWithValue("@ExamScore", obj.ExamScore);
                    objCmd.Parameters.AddWithValue("@ApprovedEmployee", obj.ApprovedEmployee);
                    //objCmd.Parameters.AddWithValue("@TargetDate", obj.TargetDate);
                    objCmd.Parameters.AddWithValue("@FromDate", obj.FromDate);
                    objCmd.Parameters.AddWithValue("@ToDate", obj.ToDate);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsHrProcess> objList = new List<clsHrProcess>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsHrProcess objInfo = new clsHrProcess();
                                objInfo.SNo = cnt + 1;
                                objInfo.HrProcessStageTaskId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.HrProcessId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.HrProcessStageTaskName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.EmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.AssignedEmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.CoOrdinator = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.Participant = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[8]);

                                if (objDset.Tables[0].Rows[cnt].ItemArray[9] != DBNull.Value)
                                    objInfo.ApprovedBy = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objInfo.ApprovedEmployee = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[11] != DBNull.Value)
                                    objInfo.ExamDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[11]);


                                if (objDset.Tables[0].Rows[cnt].ItemArray[12] != DBNull.Value)
                                    objInfo.ApprovedDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[12]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[13] != DBNull.Value)
                                    objInfo.ExamScore = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[13]);
                                objInfo.SenderImagePath = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[14]);



                                objInfo.ReceiverImagePath = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[15]);
                                objInfo.Notes = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[16]);
                                objInfo.IsApproved = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[17]);
                                //objInfo.HrProcessStageTaskName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[16]);
                                objInfo.Email = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[18]);



                                objInfo.Mobile = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[19]);
                                objInfo.Username = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[20]);
                                objInfo.Location = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[21]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[22] != DBNull.Value)


                                    objInfo.EvaluatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[22]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[23] != DBNull.Value)
                                    objInfo.EvaluatedEmployee = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[23]);

                                objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[24]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[25] != DBNull.Value)
                                    objInfo.TargetDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[25]); 

                                if (objDset.Tables[0].Rows[cnt].ItemArray[26] != DBNull.Value)
                                    objInfo.SlotDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[26]);

                                if (objDset.Tables[0].Rows[cnt].ItemArray[27] != DBNull.Value)
                                    objInfo.SlotStartTime = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[27]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[28] != DBNull.Value)
                                    objInfo.SlotEndTime = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[28]);


                                if (objDset.Tables[0].Rows[cnt].ItemArray[29] != DBNull.Value)
                                    objInfo.TaskAssignedTo = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[29]);

                                if (objDset.Tables[0].Rows[cnt].ItemArray[30] != DBNull.Value)
                                    objInfo.Qualification = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[30]);

                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }

        public clsHrProcess LoadNextStageTask(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("HrProcess_GetNextTask", objConn))
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
                            clsHrProcess objInfo = new clsHrProcess();
                            if (objDset.Tables[0].Rows[0].ItemArray[0] != DBNull.Value)
                                objInfo.HrProcessStageId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            if (objDset.Tables[0].Rows[0].ItemArray[1] != DBNull.Value)
                                objInfo.HrProcessStageTaskId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[1]);
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
                using (SqlCommand objCmd = new SqlCommand("HrProcess_Remove", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@HrProcessId", Id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }

        public int LoadHrProcessValidation(clsHrProcess obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("HrProcess_Validation", objConn))
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

        public void UpdateExamFile(clsHrProcess obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("HrProcess_UpdateExamFile", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@HrProcessId", obj.HrProcessId);
                    objCmd.Parameters.AddWithValue("@ReceiverImagePath", obj.ReceiverImagePath);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.ExecuteNonQuery();

                }
            }
        }

    }
}
