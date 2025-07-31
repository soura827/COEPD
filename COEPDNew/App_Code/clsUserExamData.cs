using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayerHelper
{
    public class clsUserExamData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs2"].ConnectionString.ToString();

        public void AddUpdate(clsUserExam obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("UserExam_AddUpdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@UserExamId", obj.UserExamId);
                    objCmd.Parameters.AddWithValue("@QuestionId", obj.QuestionId);
                    objCmd.Parameters.AddWithValue("@AnswerId", obj.AnswerId);
                    objCmd.Parameters.AddWithValue("@IsChecked", obj.IsChecked);
                    objCmd.Parameters.AddWithValue("@StatusId", obj.StatusId);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.ExecuteNonQuery();
                }
            }
        }
        public clsUserExam Load(Int64 Id)
        {
            using (SqlConnection objconn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("UserExam_Get", objconn))
                {
                    objconn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@UserExamId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsUserExam objInfo = new clsUserExam();
                            objInfo.UserExamId = Convert.ToInt64(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.QuestionId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.AnswerId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.IsChecked = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.ExamId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[4]);
                            objInfo.StatusId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[5]);
                            objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[6]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }
        public List<clsUserExam> LoadAll(clsUserExam obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("UserExam_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@keywords", obj.keywords);
                    objCmd.Parameters.AddWithValue("@QuestionId", obj.QuestionId);
                    objCmd.Parameters.AddWithValue("@ExamId", obj.ExamId);

                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsUserExam> objList = new List<clsUserExam>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsUserExam objInfo = new clsUserExam();
                                objInfo.SNo = cnt + 1;
                                objInfo.UserExamId = Convert.ToInt64(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.QuestionId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.Question = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.AnswerId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.IsChecked = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.Answer = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.ExamId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.StatusId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[8] != DBNull.Value)
                                    objInfo.Marks = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.CorrentAnswer = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }
        public List<clsUserExam> LoadAllWrong(clsUserExam obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("UserExam_WrongList", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ExamId", obj.ExamId);

                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsUserExam> objList = new List<clsUserExam>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsUserExam objInfo = new clsUserExam();
                                objInfo.SNo = cnt + 1;
                                objInfo.Question = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Answer = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[2] != DBNull.Value)
                                    objInfo.Marks = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.Description = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
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
                using (SqlCommand objCmd = new SqlCommand("UserExam_Remove", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@UserExamId", Id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }
        public void RemoveExam(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("UserExam_RemoveExam", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("ExamId", Id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }

        public List<clsUserExam> LoadAll_History(clsUserExam obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("UserExam_History", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ExamId", obj.ExamId);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsUserExam> objList = new List<clsUserExam>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsUserExam objInfo = new clsUserExam();
                                objInfo.SNo = cnt + 1;
                                objInfo.Question = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Marks = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }
        public clsUserExam LoadAllQuestions_History(clsUserExam obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("UserExamQuestions_History", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ExamId", obj.ExamId);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            //List<clsUserExam> objList = new List<clsUserExam>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsUserExam objInfo = new clsUserExam();
                                objInfo.SNo = cnt + 1;
                                objInfo.TotalQuestions = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[1]);
                                objInfo.CorrectAnswers = Convert.ToInt32(objDset.Tables[0].Rows[1].ItemArray[1]);
                                return objInfo;

                            }

                        }
                    }
                    return null;
                }
            }
        }

    }
}