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
    public class clsHrProcessSlotsData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs6"].ToString();
        public void AddUpdate(clsHrProcessSlots obj)
        {
            using (SqlConnection objconn = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("HrProcessSlots_AddUpdate", objconn))
                {
                    objconn.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@EmployeeId", obj.EmployeeId);
                    objcmd.Parameters.AddWithValue("@HrProcessStageTaskId", obj.HrProcessStageTaskId);
                    objcmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    objcmd.Parameters.AddWithValue("@SlotDate", obj.SlotDate);
                    objcmd.Parameters.AddWithValue("@SlotStartTime", obj.SlotStartTime);
                    objcmd.Parameters.AddWithValue("@SlotEndTime", obj.SlotEndTime);
                    objcmd.Parameters.AddWithValue("@IsSlotAssigned", obj.IsSlotAssigned);
                    objcmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objcmd.Parameters.AddWithValue("@StartEndTime", obj.StartEndTime);
                    objcmd.Parameters.AddWithValue("@HrProcessId", obj.HrProcessId);
                    objcmd.Parameters.AddWithValue("@HrSlotsStatusId", obj.HrSlotsStatusId);
                    objcmd.ExecuteNonQuery();
                }
            }
        }
        public int LoadHrProcessSlotsValidation(clsHrProcessSlots obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("HrProcessSlots_Validation", objConn))
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

        public List<clsHrProcessSlots> LoadAll(clsHrProcessSlots obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("HrProcessSlots_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@Keywords", obj.Keywords);
                    objCmd.Parameters.AddWithValue("@IsSlotAssigned", obj.IsSlotAssigned);
                    objCmd.Parameters.AddWithValue("@EmployeeId", obj.EmployeeId);
                    objCmd.Parameters.AddWithValue("@FromDate", obj.FromDate);
                    objCmd.Parameters.AddWithValue("@ToDate", obj.ToDate);
                    objCmd.Parameters.AddWithValue("@ParticipantDetails", obj.ParticipantDetails);
                    objCmd.Parameters.AddWithValue("@HrProcessStageTaskName", obj.HrProcessStageTaskName);
                    //objCmd.Parameters.AddWithValue("@ParicipantId", obj.ParticipantId);
                    //objCmd.Parameters.AddWithValue("@HrSlotsStatusId", obj.HrSlotsStatusId);

                    //if(obj.SlotDate != null)


                    //objCmd.Parameters.AddWithValue("@SlotDate", obj.SlotDate);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsHrProcessSlots> objList = new List<clsHrProcessSlots>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsHrProcessSlots objInfo = new clsHrProcessSlots();
                                objInfo.SNo = cnt + 1;
                                objInfo.HrProcessSlotsId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
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
                                    objInfo.Location = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[11] != DBNull.Value)
                                    objInfo.StartDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[11]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[12] != DBNull.Value)
                                    objInfo.Qualification = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[12]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[13] != DBNull.Value)
                                    objInfo.HrProcessStageTaskName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[13]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[14] != DBNull.Value)
                                    objInfo.HrProcessId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[14]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[15] != DBNull.Value)
                                    objInfo.SlotStatus = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[15]);
                                objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[16]);
                                //if (objDset.Tables[0].Rows[cnt].ItemArray[14] != DBNull.Value)
                                //    objInfo.HrSlotsStatusId = Convert.ToInt16(objDset.Tables[0].Rows[cnt].ItemArray[14]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }




        public List<clsHrProcessSlots> LoadAllParticipant(clsHrProcessSlots obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("HrProcessSlots_List_Participant", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@Keywords", obj.Keywords);
                    objCmd.Parameters.AddWithValue("@IsSlotAssigned", obj.IsSlotAssigned);
                    objCmd.Parameters.AddWithValue("@EmployeeId", obj.EmployeeId);
                    objCmd.Parameters.AddWithValue("@FromDate", obj.FromDate);
                    objCmd.Parameters.AddWithValue("@ToDate", obj.ToDate);
                    objCmd.Parameters.AddWithValue("@ParticipantDetails", obj.ParticipantDetails);
                    objCmd.Parameters.AddWithValue("@HrProcessStageTaskName", obj.HrProcessStageTaskName);
                    objCmd.Parameters.AddWithValue("@ParicipantId", obj.ParticipantId);
                    //objCmd.Parameters.AddWithValue("@HrSlotsStatusId", obj.HrSlotsStatusId);

                    //if(obj.SlotDate != null)


                    //objCmd.Parameters.AddWithValue("@SlotDate", obj.SlotDate);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsHrProcessSlots> objList = new List<clsHrProcessSlots>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsHrProcessSlots objInfo = new clsHrProcessSlots();
                                objInfo.SNo = cnt + 1;
                                objInfo.HrProcessSlotsId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
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
                                    objInfo.Location = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[11] != DBNull.Value)
                                    objInfo.StartDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[11]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[12] != DBNull.Value)
                                    objInfo.Qualification = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[12]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[13] != DBNull.Value)
                                    objInfo.HrProcessStageTaskName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[13]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[14] != DBNull.Value)
                                    objInfo.HrProcessId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[14]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[15] != DBNull.Value)
                                    objInfo.SlotStatus = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[15]);
                                objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[16]);
                                //if (objDset.Tables[0].Rows[cnt].ItemArray[14] != DBNull.Value)
                                //    objInfo.HrSlotsStatusId = Convert.ToInt16(objDset.Tables[0].Rows[cnt].ItemArray[14]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }



        public void Approve(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("HrProcessSlots_Approve", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@HrProcessSlotsId", Id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }
        public void Remove(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("HrProcessSlots_Remove", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("HrProcessSlotsId", Id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }


        public void CancelSlot(clsHrProcessSlots obj)
        {
            using (SqlConnection objconn = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("HrProcessSlots_Cancel", objconn))
                {
                    objconn.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@HrProcessSlotsId", obj.HrProcessSlotsId);
                    objcmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objcmd.Parameters.AddWithValue("@HrSlotsStatusId", obj.HrSlotsStatusId);
                    objcmd.Parameters.AddWithValue("@ActionValue", obj.ActionValue);
                    objcmd.Parameters.AddWithValue("@NewHrProcessSlotsId", obj.NewHrProcessSlotsId);
                    objcmd.Parameters.AddWithValue("@HrProcessId", obj.HrProcessId);
                    objcmd.ExecuteNonQuery();
                }
            }
        }


        public clsHrProcessSlots Load(int Id)
        {
            using (SqlConnection objconn = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("HrProcessSlots_Get", objconn))
                {
                    objconn.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@HrProcessSlotsId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objcmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsHrProcessSlots objInfo = new clsHrProcessSlots();
                            objInfo.HrProcessSlotsId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.EmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[1]);
                            if (objDset.Tables[0].Rows[0].ItemArray[2] != DBNull.Value)
                                objInfo.HrProcessStageTaskId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.SlotDate = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[4]);
                            objInfo.SlotStartTime = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[5]);
                            objInfo.SlotEndTime = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[6]);
                            objInfo.IsSlotAssigned = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[7]);
                            objInfo.StartEndTime = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[8]);
                            if (objDset.Tables[0].Rows[0].ItemArray[9] != DBNull.Value)
                                objInfo.HrProcessId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[9]);
                            //if (objDset.Tables[0].Rows[0].ItemArray[10] != DBNull.Value)
                            //    objInfo.HrSlotsStatusId = Convert.ToInt16(objDset.Tables[0].Rows[0].ItemArray[10]);
                            //if (objDset.Tables[0].Rows[0].ItemArray[11] != DBNull.Value)
                            //    objInfo.Participant = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[11]);
                            //if (objDset.Tables[0].Rows[0].ItemArray[12] != DBNull.Value)
                            //    objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[12]);
                            if (objDset.Tables[0].Rows[0].ItemArray[10] != DBNull.Value)
                                objInfo.HrProcessStageTaskName = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[10]);
                            return objInfo;
                        }
                    }
                    return null;
                }

            }
        }



        public int LoadSlotValidation(clsHrProcessSlots obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("HrProcessSlots_SlotValidation", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("HrProcessSlotsId", obj.HrProcessSlotsId);
                    int Count = Convert.ToInt16(objCmd.ExecuteScalar());
                    return Count;
                }
            }
        }



        public List<clsHrProcessSlots> LoadPriorityAll(clsHrProcessSlots obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("HrProcessSlotsPriority_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@HrProcessStageTaskId", obj.HrProcessStageTaskId);
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
                            List<clsHrProcessSlots> objList = new List<clsHrProcessSlots>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsHrProcessSlots objInfo = new clsHrProcessSlots();
                                objInfo.SNo = cnt + 1;
                                objInfo.HrProcessSlotsId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.EmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.SlotDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.SlotStartTime = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.SlotEndTime = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.StartEndTime = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.TaskPriority = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.HrProcessStageTaskId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }

        public List<clsHrProcessSlots> LoadChangeMentorAll(clsHrProcessSlots obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("HrProcessSlotsPriority_ChangeMentorList", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@HrProcessStageTaskId", obj.HrProcessStageTaskId);
                    objCmd.Parameters.AddWithValue("SlotStartTime", obj.SlotStartTime);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsHrProcessSlots> objList = new List<clsHrProcessSlots>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsHrProcessSlots objInfo = new clsHrProcessSlots();
                                objInfo.SNo = cnt + 1;
                                objInfo.HrProcessSlotsId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.EmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.SlotDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.SlotStartTime = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.SlotEndTime = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.StartEndTime = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.TaskPriority = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.HrProcessStageTaskId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[7]);
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

        public clsHrProcessSlots LoadTopOne(clsHrProcessSlots obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("HrProcessSlots_TopOne", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@HrProcessStageTaskId", obj.HrProcessStageTaskId);
                    objCmd.Parameters.AddWithValue("@SlotStartTime", obj.SlotStartTime);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsHrProcessSlots objInfo = new clsHrProcessSlots();
                            if (objDset.Tables[0].Rows[0].ItemArray[0] != DBNull.Value)
                                objInfo.SlotStartTime = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[0]);
                            return objInfo;
                        }
                    }
                    return null;

                }
            }
        }


        public List<clsHrProcessSlots> LoadAlLReShedule(clsHrProcessSlots obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("HrSlotsReshedule_List", objConn))
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
                            List<clsHrProcessSlots> objList = new List<clsHrProcessSlots>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsHrProcessSlots objInfo = new clsHrProcessSlots();
                                if (objDset.Tables[0].Rows[cnt].ItemArray[0] != DBNull.Value)
                                    objInfo.HrSlotsStatusId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.HrSlotStatus = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }


                    }
                    return null;

                }
            }
        }

        public int LoadSlotStatusValidation(clsHrProcessSlots obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("HrSlotStatus_Validation", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;

                    objCmd.Parameters.AddWithValue("@HrSlotsStatusId", obj.HrSlotsStatusId);
                    int Count = Convert.ToInt32(objCmd.ExecuteScalar());
                    return Count;
                }
            }
        }




    }
}

