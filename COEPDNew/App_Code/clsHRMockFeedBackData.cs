using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayerHelper
{
    public class clsHRMockFeedBackData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();
        public void AddUpdate(clsHRMockFeedBack obj)
        {
            using (SqlConnection objconn = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("HRMockFeedbackForm_AddUpdate", objconn))
                {
                    objconn.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@PlacementInductionId", obj.PlacementInductionId);
                    objcmd.Parameters.AddWithValue("@HRMockQuestionId", obj.HRMockQuestionId);
                    //objcmd.Parameters.AddWithValue("@RemarksId", obj.Remarks);
                    objcmd.Parameters.AddWithValue("@Rating", obj.Rating);
                    objcmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);

                    objcmd.ExecuteNonQuery();
                }
            }


        }


        public List<clsHRMockFeedBack> LoadAll(clsHRMockFeedBack obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("HRMockFeedbackForm_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@placementInductionId", obj.PlacementInductionId);

                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);

                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsHRMockFeedBack> objList = new List<clsHRMockFeedBack>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsHRMockFeedBack objInfo = new clsHRMockFeedBack();
                                objInfo.SNo = cnt + 1;
                                objInfo.QuestionName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Remarks = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.Rating = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);


                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }

        public int LoadInductionValidation(clsHRMockFeedBack obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Induction_Validation", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@PlacementInductionId", obj.PlacementInductionId);
                    int Count = Convert.ToInt32(objCmd.ExecuteScalar());
                    return Count;
                }
            }
        }





    }







}

