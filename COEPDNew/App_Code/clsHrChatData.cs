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
    public class clsHrChatData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs6"].ConnectionString.ToString();

        public void AddUpdate(clsHrChat obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("HrChat_AddUpdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@HrChatId", obj.HrChatId);
                    objCmd.Parameters.AddWithValue("@Chat", obj.Chat);
                    objCmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    objCmd.Parameters.AddWithValue("@EmployeeId", obj.EmployeeId);
                    objCmd.Parameters.AddWithValue("@HrProcessStageId", obj.HrProcessStageId);
                    objCmd.Parameters.AddWithValue("@HrProcessStageTaskId", obj.HrProcessStageTaskId);
                    objCmd.Parameters.AddWithValue("@IsReplied", obj.IsReplied);
                    objCmd.Parameters.AddWithValue("@SenderImagePath", obj.SenderImagePath);
                    objCmd.Parameters.AddWithValue("@ReceiverImagePath", obj.ReceiverImagePath);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.ExecuteNonQuery();
                }
            }
        }
        public clsHrChat Load(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("HrChat_Get", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@HrChatId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsHrChat objInfo = new clsHrChat();
                            objInfo.HrChatId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.Chat = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.EmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.HrProcessStageId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[4]);
                            objInfo.HrProcessStageTaskId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[5]);
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
        public clsHrChat LoadTopOne(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("HrChat_TopOneList", objConn))
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
                            clsHrChat objInfo = new clsHrChat();
                            objInfo.HrChatId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
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
        public List<clsHrChat> LoadAll(clsHrChat obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("HrChat_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    //objCmd.Parameters.AddWithValue("@Keywords", obj.Keywords);
                    objCmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    //objCmd.Parameters.AddWithValue("@EmployeeId", obj.EmployeeId);
                    //objCmd.Parameters.AddWithValue("@HrProcessStageTaskId", obj.HrProcessStageTaskId);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsHrChat> objList = new List<clsHrChat>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsHrChat objInfo = new clsHrChat();
                                objInfo.SNo = cnt + 1;
                                objInfo.HrChatId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Chat = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.Participant = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.EmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.HrProcessStageTaskId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.HrProcessStageTaskName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[7]);
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

        public List<clsHrChat> LoadAllTasks(clsHrChat obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("HrChat_ListByTasks", objConn))
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
                            List<clsHrChat> objList = new List<clsHrChat>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsHrChat objInfo = new clsHrChat();
                                objInfo.SNo = cnt + 1;
                                objInfo.HrChatId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Chat = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.Participant = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.EmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.HrProcessStageTaskId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.HrProcessStageTaskName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[7]);
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

        public List<clsHrChat> LoadParticipantsAll(clsHrChat obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("HrChat_ParticipantsList", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@Keywords", obj.Keywords);
                    objCmd.Parameters.AddWithValue("@Location", obj.Location);
                    objCmd.Parameters.AddWithValue("@HrProcessStageTaskName", obj.HrProcessStageTaskName);
                    objCmd.Parameters.AddWithValue("@IsReplied", obj.IsReplied);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsHrChat> objList = new List<clsHrChat>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsHrChat objInfo = new clsHrChat();
                                objInfo.SNo = cnt + 1;
                                objInfo.HrChatId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Chat = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.Participant = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.EmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.HrProcessStageTaskId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.HrProcessStageTaskName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[6]);
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
                using (SqlCommand objCmd = new SqlCommand("HrChat_Remove", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@HrChatId", Id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }


        //public clsHrChat HrChatPendingCount(clsHrChat Obj)
        //{
        //    using (SqlConnection objConn = new SqlConnection(Constr))
        //    {
        //        using (SqlCommand objCmd = new SqlCommand("HrChat_Pending_Count", objConn))
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
        //                    clsHrChat objInfo = new clsHrChat();
        //                    objInfo.HrChatBlog = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
        //                    objInfo.HrChatDocument = Convert.ToInt32(objDset.Tables[0].Rows[1].ItemArray[0]);
        //                    objInfo.HrChatMockInterviews = Convert.ToInt32(objDset.Tables[0].Rows[2].ItemArray[0]);
        //                    objInfo.HrChatExam = Convert.ToInt32(objDset.Tables[0].Rows[3].ItemArray[0]);
        //                    objInfo.HrChatProject = Convert.ToInt32(objDset.Tables[0].Rows[4].ItemArray[0]);
        //                    objInfo.HrChatTool = Convert.ToInt32(objDset.Tables[0].Rows[5].ItemArray[0]);
        //                    objInfo.HrChatUml = Convert.ToInt32(objDset.Tables[0].Rows[6].ItemArray[0]);
        //                    return objInfo;
        //                }
        //            }
        //            return null;
        //        }
        //    }
        //}
        //public int HrPendingChatCount()
        //{
        //    using (SqlConnection objConn = new SqlConnection(Constr))
        //    {
        //        string Query = "select COUNT(*) from tblHrChat  where IsDeleted = 0 AND IsReplied=0";
        //        using (SqlCommand objCmd = new SqlCommand(Query, objConn))
        //        {
        //            objConn.Open();

        //            int HrChatChatCount = Convert.ToInt32(objCmd.ExecuteScalar());
        //            return HrChatChatCount;
        //        }
        //    }
        //}
        public int HrPendingChatCount(clsHrChat obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("HrPendingChat_Count", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    //objCmd.Parameters.AddWithValue("@HrChatId", obj.HrChatId);
                    int HrPendingChatCount = Convert.ToInt32(objCmd.ExecuteScalar());
                    return HrPendingChatCount;
                }
            }
        }
        public clsHrChat GetByPendingChat(int ParticipantId)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("HrChat_GetByPending_Chat", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ParticipantId", ParticipantId);
                   // objCmd.Parameters.AddWithValue("@HrProcessStageTaskId", HrChatTypeLinkId);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsHrChat objInfo = new clsHrChat();

                            objInfo.HrChatId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.Chat = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.EmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.HrProcessStageId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[4]);
                            //objInfo.HrProcessStageTaskId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[5]);
                            objInfo.IsReplied = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[5]);
                            objInfo.SenderImagePath = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[6]);
                            objInfo.ReceiverImagePath = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[7]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }
        public int LoadHrChatValidation(clsHrChat obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("HrChat_Validation", objConn))
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