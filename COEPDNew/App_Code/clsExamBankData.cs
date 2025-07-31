using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace DataAccessLayerHelper
{
    public class clsExamBankData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();

        public int AddUpdate(clsExamBank obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ExamBank_AddUpdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ExamBankId", obj.ExamBankId);
                    objCmd.Parameters.AddWithValue("@ExamId", obj.ExamId);
                    objCmd.Parameters.AddWithValue("@UserId", obj.UserId);
                    objCmd.Parameters.AddWithValue("@StartDate", obj.StartDate);
                    objCmd.Parameters.AddWithValue("@EndDate", obj.EndDate);
                    objCmd.Parameters.AddWithValue("@StatusId", obj.StatusId);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    SqlParameter paramout = new SqlParameter("@Out_msg", SqlDbType.VarChar, 500);
                    paramout.Direction = ParameterDirection.Output;
                    objCmd.Parameters.Add(paramout);
                    objCmd.ExecuteNonQuery();
                    int outmsg = Convert.ToInt16(paramout.SqlValue.ToString());
                    return outmsg;
                }
            }
        }
        public clsExamBank Load(int Id)
        {
            using (SqlConnection objconn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ExamBank_Get", objconn))
                {
                    objconn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ExamBankId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsExamBank objInfo = new clsExamBank();
                            objInfo.ExamBankId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.ExamId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.UserId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.StartDate = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.EndDate = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[4]);
                            objInfo.StatusId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[5]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }
        public List<clsExamBank> LoadAll(clsExamBank obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ExamBank_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@keywords", obj.keywords);
                    objCmd.Parameters.AddWithValue("@ExamId", obj.ExamId);
                    objCmd.Parameters.AddWithValue("@StatusId", obj.StatusId);
                    objCmd.Parameters.AddWithValue("@UserId", obj.UserId);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsExamBank> objList = new List<clsExamBank>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsExamBank objInfo = new clsExamBank();
                                objInfo.SNo = cnt + 1;
                                objInfo.ExamBankId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.ExamId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.Exam = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.UserId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.StartDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.EndDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.StatusId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.Status = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.ExamTime = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[8]);
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
                using (SqlCommand objCmd = new SqlCommand("ExamBank_Remove", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ExambankId", Id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }
    }
}