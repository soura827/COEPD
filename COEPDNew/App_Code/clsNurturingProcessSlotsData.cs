using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace DataAccessLayerHelper
{
    public class clsNurturingProcessSlotsData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs"].ToString();
        public void AddUpdate(clsNurturingProcessSlots obj)
        {
            using (SqlConnection objconn = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("NurturingProcessSlots_AddUpdate", objconn))
                {
                    objconn.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@NurturingProcessSlotsId", obj.NurturingProcessSlotsId);
                    objcmd.Parameters.AddWithValue("@EmployeeId", obj.EmployeeId);
                    objcmd.Parameters.AddWithValue("@NurturingProcessStageTaskId", obj.NurturingProcessStageTaskId);
                    objcmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    objcmd.Parameters.AddWithValue("@SlotDate", obj.SlotDate);
                    objcmd.Parameters.AddWithValue("@SlotStartTime", obj.SlotStartTime);
                    objcmd.Parameters.AddWithValue("@SlotEndTime", obj.SlotEndTime);
                    objcmd.Parameters.AddWithValue("@IsSlotAssigned", obj.IsSlotAssigned);
                    objcmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objcmd.Parameters.AddWithValue("@StartEndTime", obj.StartEndTime);
                    objcmd.Parameters.AddWithValue("@NurturingProcessId", obj.NurturingProcessId);
                    objcmd.Parameters.AddWithValue("@SlotsStatusId", obj.SlotsStatusId);
                    objcmd.ExecuteNonQuery();
                }
            }
        }
        public void CancelSlot(clsNurturingProcessSlots obj)
        {
            using (SqlConnection objconn = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("NurturingProcessSlots_Cancel", objconn))
                {
                    objconn.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@NurturingProcessSlotsId", obj.NurturingProcessSlotsId);
                    objcmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objcmd.Parameters.AddWithValue("@SlotsStatusId", obj.SlotsStatusId);
                    objcmd.Parameters.AddWithValue("@ActionValue", obj.ActionValue);
                    objcmd.Parameters.AddWithValue("@NewNurturingProcessSlotsId", obj.NewNurturingProcessSlotsId);
                    objcmd.Parameters.AddWithValue("@NurturingProcessId", obj.NurturingProcessId);
                    objcmd.ExecuteNonQuery();
                }
            }
        }


        public clsNurturingProcessSlots Load(int Id)
        {
            using (SqlConnection objconn = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("NurturingProcessSlots_Get", objconn))
                {
                    objconn.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@NurturingProcessSlotsId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objcmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsNurturingProcessSlots objInfo = new clsNurturingProcessSlots();
                            objInfo.NurturingProcessSlotsId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.EmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.NurturingProcessStageTaskId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.SlotDate = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[4]);
                            objInfo.SlotStartTime = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[5]);
                            objInfo.SlotEndTime = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[6]);
                            objInfo.IsSlotAssigned = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[7]);
                            objInfo.StartEndTime = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[8]);
                            if (objDset.Tables[0].Rows[0].ItemArray[9] != DBNull.Value)
                                objInfo.NurturingProcessId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[9]);
                            if (objDset.Tables[0].Rows[0].ItemArray[10] != DBNull.Value)
                                objInfo.SlotsStatusId = Convert.ToInt16(objDset.Tables[0].Rows[0].ItemArray[10]);
                            if (objDset.Tables[0].Rows[0].ItemArray[11] != DBNull.Value)
                                objInfo.Participant = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[11]);
                            if (objDset.Tables[0].Rows[0].ItemArray[12] != DBNull.Value)
                                objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[12]);
                            if (objDset.Tables[0].Rows[0].ItemArray[13] != DBNull.Value)
                                objInfo.NurturingProcessStageTaskName = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[13]);
                            return objInfo;
                        }
                    }
                    return null;
                }

            }
        }

        public int LoadNurturingProcessSlotsValidation(clsNurturingProcessSlots obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("NurturingProcessSlots_Validation", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@EmployeeId", obj.EmployeeId);
                    objCmd.Parameters.AddWithValue("@SlotDate", obj.SlotDate);
                    objCmd.Parameters.AddWithValue("@SlotStartTime", obj.SlotStartTime);
                    int Count = Convert.ToInt32(objCmd.ExecuteScalar());
                    return Count;
                }
            }
        }

        public int LoadSlotValidation(clsNurturingProcessSlots obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("NurturingProcessSlots_SlotValidation", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("NurturingProcessSlotsId", obj.NurturingProcessSlotsId);
                    int Count = Convert.ToInt16(objCmd.ExecuteScalar());
                    return Count;
                }
            }
        }

        public List<clsNurturingProcessSlots> LoadAll(clsNurturingProcessSlots obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("NurturingProcessSlots_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@Keywords", obj.Keywords);
                    objCmd.Parameters.AddWithValue("@IsSlotAssigned", obj.IsSlotAssigned);
                    objCmd.Parameters.AddWithValue("@EmployeeId", obj.EmployeeId);
                    objCmd.Parameters.AddWithValue("@FromDate", obj.FromDate);
                    objCmd.Parameters.AddWithValue("@ToDate", obj.ToDate);
                    objCmd.Parameters.AddWithValue("@ParticipantDetails", obj.ParticipantDetails);
                    objCmd.Parameters.AddWithValue("@NurturingProcessStageTaskName", obj.NurturingProcessStageTaskName);
                    objCmd.Parameters.AddWithValue("@SlotsStatusId", obj.SlotsStatusId);
                    objCmd.Parameters.AddWithValue("@Location", obj.Location);  
                    //if(obj.SlotDate != null)
                    //objCmd.Parameters.AddWithValue("@SlotDate", obj.SlotDate);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsNurturingProcessSlots> objList = new List<clsNurturingProcessSlots>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsNurturingProcessSlots objInfo = new clsNurturingProcessSlots();
                                objInfo.SNo = cnt + 1;
                                objInfo.NurturingProcessSlotsId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.EmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.SlotDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.SlotStartTime = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.SlotEndTime = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.IsSlotAssigned = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[7] != DBNull.Value)
                                    objInfo.Participant = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[8] != DBNull.Value)
                                    objInfo.Email = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[9] != DBNull.Value)
                                    objInfo.Mobile = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[10] != DBNull.Value)
                                    objInfo.NurturingProcessStageTaskName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[11] != DBNull.Value)
                                    objInfo.NurturingProcessId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[11]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[12] != DBNull.Value)
                                    objInfo.SlotStatus = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[12]);
                                objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[13]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[14] != DBNull.Value)
                                    objInfo.SlotsStatusId = Convert.ToInt16(objDset.Tables[0].Rows[cnt].ItemArray[14]);
                                objInfo.Location = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[15]);

                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }

        public List<clsNurturingProcessSlots> LoadPriorityAll(clsNurturingProcessSlots obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("NurturingProcessSlotsPriority_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@NurturingProcessStageTaskId", obj.NurturingProcessStageTaskId);
                    //objCmd.Parameters.AddWithValue("@FromDate", obj.FromDate);
                    //objCmd.Parameters.AddWithValue("@ToDate", obj.ToDate);
                    objCmd.Parameters.AddWithValue("@SlotDate", obj.SlotDate);
                    objCmd.Parameters.AddWithValue("SlotStartTime", obj.SlotStartTime);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsNurturingProcessSlots> objList = new List<clsNurturingProcessSlots>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsNurturingProcessSlots objInfo = new clsNurturingProcessSlots();
                                objInfo.SNo = cnt + 1;
                                objInfo.NurturingProcessSlotsId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.EmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.SlotDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.SlotStartTime = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.SlotEndTime = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.StartEndTime = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.TaskPriority = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.NurturingProcessStageTaskId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }

        public List<clsNurturingProcessSlots> LoadChangeMentorAll(clsNurturingProcessSlots obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("NurturingProcessSlotsPriority_ChangeMentorList", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@NurturingProcessStageTaskId", obj.NurturingProcessStageTaskId);
                    objCmd.Parameters.AddWithValue("SlotStartTime", obj.SlotStartTime);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsNurturingProcessSlots> objList = new List<clsNurturingProcessSlots>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsNurturingProcessSlots objInfo = new clsNurturingProcessSlots();
                                objInfo.SNo = cnt + 1;
                                objInfo.NurturingProcessSlotsId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.EmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.SlotDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.SlotStartTime = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.SlotEndTime = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.StartEndTime = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.TaskPriority = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.NurturingProcessStageTaskId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }

        public clsNurturingProcessSlots LoadTopOne(clsNurturingProcessSlots obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("NurturingProcessSlots_TopOne", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@NurturingProcessStageTaskId", obj.NurturingProcessStageTaskId);
                    objCmd.Parameters.AddWithValue("@SlotStartTime", obj.SlotStartTime);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsNurturingProcessSlots objInfo = new clsNurturingProcessSlots();
                            if (objDset.Tables[0].Rows[0].ItemArray[0] != DBNull.Value)
                                objInfo.SlotStartTime = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[0]);
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
                using (SqlCommand objCmd = new SqlCommand("NurturingProcessSlots_Remove", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("NurturingProcessSlotsId", Id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }

        public void Approve(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("NurturingProcessSlots_Approve", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@NurturingProcessSlotsId", Id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }



        public List<clsNurturingProcessSlots> LoadAlLReShedule(clsNurturingProcessSlots obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("SlotsReshedule_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsNurturingProcessSlots> objList = new List<clsNurturingProcessSlots>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsNurturingProcessSlots objInfo = new clsNurturingProcessSlots();
                                if (objDset.Tables[0].Rows[cnt].ItemArray[0] != DBNull.Value)
                                    objInfo.SlotsStatusId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.SlotStatus = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }


                    }
                    return null;

                }
            }
        }

        public int LoadSlotStatusValidation(clsNurturingProcessSlots obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("SlotStatus_Validation", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;

                    objCmd.Parameters.AddWithValue("@SlotsStatusId", obj.SlotsStatusId);
                    int Count = Convert.ToInt32(objCmd.ExecuteScalar());
                    return Count;
                }
            }
        }




    }
}
