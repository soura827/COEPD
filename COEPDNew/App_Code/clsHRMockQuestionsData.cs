using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayerHelper
{
    public class clsHRMockQuestionsData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();
        public void AddUpdate(clsHRMockQuestions obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("HRMockQuestions_Addupdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    //objCmd.Parameters.AddWithValue("@HRMockQuestionsId", obj.HRMockQuestionId); 
                    objCmd.Parameters.AddWithValue("@QuestionName", obj.QuestionName);
                    //objCmd.Parameters.AddWithValue("@Answer", obj.Answer);
                    objCmd.Parameters.AddWithValue("@RemarksId", obj.RemarksId);
                    objCmd.Parameters.AddWithValue("@RatingId", obj.RatingId);
                    //objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.ExecuteNonQuery();
                }
            }
        }
        public clsHRMockQuestions Load(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("HRMockQuestions_Get", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@HRMockQuestionId ", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsHRMockQuestions objInfo = new clsHRMockQuestions();
                            objInfo.HRMockQuestionId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.QuestionName = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.Answer = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[2]);
                            //objInfo.RemarksId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[3]);
                            //objInfo.RatingId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[4]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }
        public List<clsHRMockQuestions> LoadAll(clsHRMockQuestions obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("HRMockQuestions_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@QuestionName", obj.QuestionName);

                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);

                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsHRMockQuestions> objList = new List<clsHRMockQuestions>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsHRMockQuestions objInfo = new clsHRMockQuestions();
                                objInfo.SNo = cnt + 1;
                                objInfo.HRMockQuestionId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.QuestionName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                //objInfo.Answer = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[3] != DBNull.Value)
                                    objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[4] != DBNull.Value)
                                    objInfo.ModifiedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[5] != DBNull.Value)
                                    objInfo.ModifiedName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                // objInfo.Remarks = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                //objInfo.Rating = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[7]);

                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }

        public List<clsHRMockQuestions> LoadAlLRemarks(clsHRMockQuestions obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Remarks_List", objConn))
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
                            List<clsHRMockQuestions> objList = new List<clsHRMockQuestions>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsHRMockQuestions objInfo = new clsHRMockQuestions();

                                objInfo.RemarksId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Remarks = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }


                    }
                    return null;

                }
            }
        }

        public List<clsHRMockQuestions> LoadAlLRating(clsHRMockQuestions obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Rating_List", objConn))
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
                            List<clsHRMockQuestions> objList = new List<clsHRMockQuestions>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsHRMockQuestions objInfo = new clsHRMockQuestions();

                                objInfo.RatingId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Rating = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }


                    }
                    return null;

                }
            }
        }
        public void ConductHRMockFeedbackFomrAddUpdateAddUpdate(clsHRMockQuestions obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("HRMockQuestions_Addupdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    //objCmd.Parameters.AddWithValue("@HRMockQuestionsId", obj.HRMockQuestionId); 
                    objCmd.Parameters.AddWithValue("@QuestionName", obj.QuestionName);
                    //objCmd.Parameters.AddWithValue("@Answer", obj.Answer);
                    objCmd.Parameters.AddWithValue("@RemarksId", obj.RemarksId);
                    objCmd.Parameters.AddWithValue("@RatingId", obj.RatingId);
                    //objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.ExecuteNonQuery();
                }
            }
        }

    }

}







