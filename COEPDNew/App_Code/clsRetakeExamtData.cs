using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayerHelper
{
    public class clsRetakeExamtData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();

        public void AddUpdate(clsRetakeExam obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("RetakeExam_AddUpdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@RetakeExamID", obj.RetakeExamID);
                    objCmd.Parameters.AddWithValue("@ExamID", obj.ExamID);
                    objCmd.Parameters.AddWithValue("@Description", obj.Description);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.Parameters.AddWithValue("@UserComments", obj.UserComments);
                    objCmd.Parameters.AddWithValue("@RetakeStatusId", obj.RetakeStatusId);
                    objCmd.ExecuteNonQuery();
                }
            }
        }

        public clsRetakeExam Load(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("RetakeExam_Get", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("RetakeExamId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsRetakeExam objInfo = new clsRetakeExam();
                            objInfo.ExamID = Convert.ToInt32(objDset.Tables[0].Rows[0]["ExamID"]);
                            objInfo.RetakeExamID = Convert.ToInt32(objDset.Tables[0].Rows[0]["RetakeExamID"]);
                            objInfo.Description = Convert.ToString(objDset.Tables[0].Rows[0]["Description"]);
                            objInfo.UserComments = Convert.ToString(objDset.Tables[0].Rows[0]["UserComments"]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }

        public List<clsRetakeExam> LoadAll(clsRetakeExam obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("RetakeExam_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@keywords", obj.keywords);
                    objCmd.Parameters.AddWithValue("@ExamID", obj.ExamID);
                    objCmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    objCmd.Parameters.AddWithValue("@RetakeStatusId", obj.RetakeStatusId);

                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsRetakeExam> objList = new List<clsRetakeExam>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsRetakeExam objInfo = new clsRetakeExam();
                                objInfo.SNo = cnt + 1;

                                objInfo.ExamID = Convert.ToInt32(objDset.Tables[0].Rows[cnt]["ExamID"]);
                                objInfo.RetakeExamID = Convert.ToInt32(objDset.Tables[0].Rows[cnt]["RetakeExamID"]);
                                objInfo.Description = Convert.ToString(objDset.Tables[0].Rows[cnt]["Description"]);
                                objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[cnt]["ParticipantId"]);
                                objInfo.Participant = Convert.ToString(objDset.Tables[0].Rows[cnt]["Participant"]);
                                objInfo.Topic = Convert.ToString(objDset.Tables[0].Rows[cnt]["Topic"]);
                                objInfo.UserComments = Convert.ToString(objDset.Tables[0].Rows[cnt]["UserComments"]);
                                if (objDset.Tables[0].Rows[cnt]["StartDate"] != DBNull.Value)
                                    objInfo.BatchDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt]["StartDate"]);
                                objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[cnt]["Employee"]);
                                objInfo.Location = Convert.ToString(objDset.Tables[0].Rows[cnt]["Location"]);
                                objInfo.RetakeStatusId = Convert.ToInt32(objDset.Tables[0].Rows[cnt]["RetakeStatusId"]);
                                objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt]["CreatedOn"]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[12] != DBNull.Value)
                                    objInfo.MarksPercentage = Convert.ToInt16(objDset.Tables[0].Rows[cnt].ItemArray[12]);
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
                using (SqlCommand objCmd = new SqlCommand("RetakeExam_Remove", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@RetakeExamId", Id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateStatus(clsRetakeExam obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("RetakeExam_UpdateStatus", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@RetakeExamID", obj.RetakeExamID);
                    objCmd.Parameters.AddWithValue("@ModifiedBy", obj.ModifiedBy);
                    objCmd.Parameters.AddWithValue("@UserComments", obj.UserComments);
                    objCmd.Parameters.AddWithValue("@RetakeStatusId", obj.RetakeStatusId);
                    objCmd.ExecuteNonQuery();
                }
            }
        }

        public int RetakeExamCount()
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                //string Query = "Select COUNT(*) from tblRetakeExam WHERE IsDeleted = 0 AND RetakeStatusId = 0";
                string Query = "select COUNT(*)from tblRetakeExam RE, tblExam E where RE.IsDeleted = 0 and RE.RetakeStatusId = 0 and RE.ExamId = E.ExamId and RE.CreatedBy > 0";
                using (SqlCommand objCmd = new SqlCommand(Query, objConn))
                {
                    objConn.Open();

                    int ExamCount = Convert.ToInt32(objCmd.ExecuteScalar());
                    return ExamCount;
                }
            }
        }


    }

}
