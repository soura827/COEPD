using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayerHelper
{
    public class clsNurturingChatData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();

        public void AddUpdate(clsNurturingChat obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("NurturingChat_AddUpdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@NurturingChatId", obj.NurturingChatId);
                    objCmd.Parameters.AddWithValue("@Chat", obj.Chat);
                    objCmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    objCmd.Parameters.AddWithValue("@EmployeeId", obj.EmployeeId);
                    objCmd.Parameters.AddWithValue("@NurturingProcessStageId", obj.NurturingProcessStageId);
                    objCmd.Parameters.AddWithValue("@NurturingProcessStageTaskId", obj.NurturingProcessStageTaskId);
                    objCmd.Parameters.AddWithValue("@IsReplied", obj.IsReplied);
                    objCmd.Parameters.AddWithValue("@SenderImagePath", obj.SenderImagePath);
                    objCmd.Parameters.AddWithValue("@ReceiverImagePath", obj.ReceiverImagePath);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.ExecuteNonQuery();
                }
            }
        }
        public clsNurturingChat Load(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("NurturingChat_Get", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@NurturingChatId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsNurturingChat objInfo = new clsNurturingChat();
                            objInfo.NurturingChatId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.Chat = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.EmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.NurturingProcessStageId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[4]);
                            objInfo.NurturingProcessStageTaskId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[5]);
                            objInfo.IsReplied = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[6]);
                            objInfo.SenderImagePath = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[7]);
                            objInfo.ReceiverImagePath = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[8]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }
        public clsNurturingChat LoadTopOne(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("NurturingChat_TopOneList", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("ParticipantId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsNurturingChat objInfo = new clsNurturingChat();
                            objInfo.NurturingChatId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.Chat = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.Participant = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[4]);
                            objInfo.RoleId = Convert.ToInt16(objDset.Tables[0].Rows[0].ItemArray[5]);
                            objInfo.SenderImagePath = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[6]);
                            objInfo.ReceiverImagePath = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[7]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }
        public List<clsNurturingChat> LoadAll(clsNurturingChat obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("NurturingChat_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@Keywords", obj.Keywords);
                    objCmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    objCmd.Parameters.AddWithValue("@EmployeeId", obj.EmployeeId);
                    objCmd.Parameters.AddWithValue("@NurturingProcessStageTaskId", obj.NurturingProcessStageTaskId);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsNurturingChat> objList = new List<clsNurturingChat>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsNurturingChat objInfo = new clsNurturingChat();
                                objInfo.SNo = cnt + 1;
                                objInfo.NurturingChatId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Chat = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.Participant = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.EmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.NurturingProcessStageTaskId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.NurturingProcessStageTaskName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.RoleId = Convert.ToInt16(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objInfo.SenderImagePath = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                objInfo.ReceiverImagePath = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[11]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }

        public List<clsNurturingChat> LoadAllTasks(clsNurturingChat obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("NurturingChat_ListByTasks", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsNurturingChat> objList = new List<clsNurturingChat>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsNurturingChat objInfo = new clsNurturingChat();
                                objInfo.SNo = cnt + 1;
                                objInfo.NurturingChatId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Chat = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.Participant = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.EmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.NurturingProcessStageTaskId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.NurturingProcessStageTaskName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.RoleId = Convert.ToInt16(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }

        public List<clsNurturingChat> LoadParticipantsAll(clsNurturingChat obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("NurturingChat_ParticipantsList", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@Keywords", obj.Keywords);
                    objCmd.Parameters.AddWithValue("@Location", obj.Location);
                    objCmd.Parameters.AddWithValue("@NurturingProcessStageTaskName", obj.NurturingProcessStageTaskName);
                    objCmd.Parameters.AddWithValue("@IsReplied", obj.IsReplied);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsNurturingChat> objList = new List<clsNurturingChat>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsNurturingChat objInfo = new clsNurturingChat();
                                objInfo.SNo = cnt + 1;
                                objInfo.NurturingChatId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Chat = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.Participant = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.EmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.NurturingProcessStageTaskId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.NurturingProcessStageTaskName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.RoleId = Convert.ToInt16(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.Email = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objInfo.Mobile = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                objInfo.Username = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[11]);
                                objInfo.Location = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[12]);
                                objInfo.IsReplied = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[13]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[14] != DBNull.Value)
                                    objInfo.ModifiedName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[14]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[15] != DBNull.Value)
                                    objInfo.ModifiedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[15]);
                                objInfo.SenderImagePath = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[16]);
                                objInfo.ReceiverImagePath = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[17]);
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
                using (SqlCommand objCmd = new SqlCommand("NurturingChat_Remove", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@NurturingChatId", Id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }


        //public clsNurturingChat NurturingChatPendingCount(clsNurturingChat Obj)
        //{
        //    using (SqlConnection objConn = new SqlConnection(Constr))
        //    {
        //        using (SqlCommand objCmd = new SqlCommand("NurturingChat_Pending_Count", objConn))
        //        {
        //            objCmd.CommandType = CommandType.StoredProcedure;
        //            objCmd.Parameters.AddWithValue("@keywords", Obj.keywords);
        //            DataSet objDset = new DataSet();
        //            SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
        //            objAdp.Fill(objDset);
        //            if (objDset.Tables.Count > 0)
        //            {
        //                if (objDset.Tables[0].Rows.Count > 0)
        //                {
        //                    clsNurturingChat objInfo = new clsNurturingChat();
        //                    objInfo.NurturingChatBlog = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
        //                    objInfo.NurturingChatDocument = Convert.ToInt32(objDset.Tables[0].Rows[1].ItemArray[0]);
        //                    objInfo.NurturingChatMockInterviews = Convert.ToInt32(objDset.Tables[0].Rows[2].ItemArray[0]);
        //                    objInfo.NurturingChatExam = Convert.ToInt32(objDset.Tables[0].Rows[3].ItemArray[0]);
        //                    objInfo.NurturingChatProject = Convert.ToInt32(objDset.Tables[0].Rows[4].ItemArray[0]);
        //                    objInfo.NurturingChatTool = Convert.ToInt32(objDset.Tables[0].Rows[5].ItemArray[0]);
        //                    objInfo.NurturingChatUml = Convert.ToInt32(objDset.Tables[0].Rows[6].ItemArray[0]);
        //                    return objInfo;
        //                }
        //            }
        //            return null;
        //        }
        //    }
        //}
        //public int NurturingPendingChatCount()
        //{
        //    using (SqlConnection objConn = new SqlConnection(Constr))
        //    {
        //        string Query = "select COUNT(*) from tblNurturingChat  where IsDeleted = 0 AND IsReplied=0";
        //        using (SqlCommand objCmd = new SqlCommand(Query, objConn))
        //        {
        //            objConn.Open();

        //            int NurturingChatChatCount = Convert.ToInt32(objCmd.ExecuteScalar());
        //            return NurturingChatChatCount;
        //        }
        //    }
        //}
        public int NurturingPendingChatCount(clsNurturingChat obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("NurturingPendingChat_Count", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    //objCmd.Parameters.AddWithValue("@NurturingChatId", obj.NurturingChatId);
                    int NurturingPendingChatCount = Convert.ToInt32(objCmd.ExecuteScalar());
                    return NurturingPendingChatCount;
                }
            }
        }
        public clsNurturingChat GetByPendingChat(int ParticipantId, int NurturingChatTypeLinkId)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("NurturingChat_GetByPending_Chat", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ParticipantId", ParticipantId);
                    objCmd.Parameters.AddWithValue("@NurturingProcessStageTaskId", NurturingChatTypeLinkId);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsNurturingChat objInfo = new clsNurturingChat();

                            objInfo.NurturingChatId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.Chat = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.EmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.NurturingProcessStageId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[4]);
                            objInfo.NurturingProcessStageTaskId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[5]);
                            objInfo.IsReplied = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[6]);
                            objInfo.SenderImagePath = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[7]);
                            objInfo.ReceiverImagePath = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[8]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }
        public int LoadNurturingChatValidation(clsNurturingChat obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("NurturingChat_Validation", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    int Count = Convert.ToInt16(objCmd.ExecuteScalar());
                    return Count;
                }
            }
        }
    }
}