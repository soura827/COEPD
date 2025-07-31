using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace DataAccessLayerHelper
{
    public class clsNurturingRevisionData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();
        public void AddUpdate(clsNurturingRevision obj)
        {
            using (SqlConnection objcon = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("NurturingRevision_AddUpdate", objcon))
                {
                    objcon.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@NurturingRevisionId", obj.NurturingRevisionId);
                    objcmd.Parameters.AddWithValue("@NurturingProcessStageId", obj.NurturingProcessStageId);
                    objcmd.Parameters.AddWithValue("@NurturingProcessStageTaskId", obj.NurturingProcessStageTaskId);
                    objcmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    objcmd.Parameters.AddWithValue("@ExamId", obj.ExamId);
                    objcmd.Parameters.AddWithValue("@TopicId", obj.TopicId);
                    objcmd.Parameters.AddWithValue("@TotalQuestions", obj.TotalQuestions);
                    objcmd.Parameters.AddWithValue("@CorrectAnswers", obj.CorrectAnswers);
                    objcmd.Parameters.AddWithValue("@MarksPersontage", obj.MarksPersontage);
                    objcmd.Parameters.AddWithValue("@IsApproved", obj.IsApproved);
                    objcmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objcmd.ExecuteNonQuery();
                }
            }
        }
        public clsNurturingRevision Load(clsNurturingRevision obj)
        {
            using (SqlConnection objcon = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("NurturingRevision_Get", objcon))
                {
                    objcon.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@NurturingProcessStageTaskId", obj.NurturingProcessStageTaskId);
                    objcmd.Parameters.AddWithValue("ParticipantId", obj.ParticipantId);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objcmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsNurturingRevision objInfo = new clsNurturingRevision();
                            objInfo.NurturingRevisionId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.NurturingProcessStageId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.NurturingProcessStageTaskId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.ExamId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[4]);
                            objInfo.TopicId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[5]);
                            objInfo.TotalQuestions = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[6]);
                            objInfo.CorrectAnswers = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[7]);
                            objInfo.MarksPersontage = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[8]);
                            objInfo.IsApproved = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[9]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }
        public List<clsNurturingRevision> LoadAll(clsNurturingRevision obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("NurturingRevision_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    objCmd.Parameters.AddWithValue("@IsApproved", obj.IsApproved);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsNurturingRevision> objList = new List<clsNurturingRevision>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsNurturingRevision objInfo = new clsNurturingRevision();
                                objInfo.Sno = cnt + 1;
                                objInfo.NurturingRevisionId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.NurturingProcessStageId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.NurturingProcessStageTaskId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.ExamId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.TopicId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.TotalQuestions = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.CorrectAnswers = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.MarksPersontage = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objInfo.Participant = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                objInfo.Topic = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[11]);
                                objInfo.Category = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[12]);
                                objInfo.IsApproved = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[13]);
                                objInfo.NurturingProcessStageName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[14]);
                                objInfo.NurturingProcessStageTaskName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[15]);
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
            using (SqlConnection objcon = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("NurturingRevision_Remove", objcon))
                {
                    objcon.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@NurturingRevisionId", id);
                    objcmd.ExecuteNonQuery();
                }
            }
        }
        public int LoadNurturingRevisionValidation(clsNurturingRevision obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("NurturingRevision_Validation", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    objCmd.Parameters.AddWithValue("@TopicId", obj.TopicId);
                    int Count = Convert.ToInt32(objCmd.ExecuteScalar());
                    return Count;
                }
            }
        }
    }
}
