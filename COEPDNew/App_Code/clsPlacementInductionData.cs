using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayerHelper
{
    public class clsPlacementInductionData
    {

        public string Constr = ConfigurationManager.ConnectionStrings["cs3"].ConnectionString.ToString();
        public void AddUpdate(clsPlacementInduction obj)
        {
            using (SqlConnection objconn = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("PlacementInduction_AddUpdate", objconn))
                {
                    objconn.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@PlacementInductionId", obj.PlacementInductionId);
                    objcmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    objcmd.Parameters.AddWithValue("@AttendedOn", obj.AttendedOn);
                    objcmd.Parameters.AddWithValue("@IsTermsAccepted", obj.IsTermsAccepted);
                    objcmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objcmd.Parameters.AddWithValue("@HRMockFeebackImagePath", obj.HRMockFeebackImagePath);
                    objcmd.Parameters.AddWithValue("@Score", obj.Score);
                    objcmd.Parameters.AddWithValue("@HRMockInputs", obj.HRMockInputs);
                    objcmd.Parameters.AddWithValue("@Qualification", obj.Qualification);
                    objcmd.Parameters.AddWithValue("@IsHRMockApproved", obj.IsHRMockApproved);

                    objcmd.ExecuteNonQuery();
                }


            }
        }
        public clsPlacementInduction Load(int Id)

        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("PlacementInduction_Get", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@PlacementInductionId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsPlacementInduction objInfo = new clsPlacementInduction();

                            objInfo.PlacementInductionId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[1]);
                            if (objDset.Tables[0].Rows[0].ItemArray[2] != DBNull.Value)
                                objInfo.AttendedOn = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.IsTermsAccepted = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.HRMockFeebackImagePath = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[4]);
                            if (objDset.Tables[0].Rows[0].ItemArray[5] != DBNull.Value)
                                objInfo.Score = Convert.ToDecimal(objDset.Tables[0].Rows[0].ItemArray[5]);
                            objInfo.HRMockInputs = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[6]);
                            objInfo.IsHRMockApproved = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[7]);
                            objInfo.TotalExperience = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[8]);
                            objInfo.Location = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[9]);
                            objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[10]);
                            objInfo.Qualification = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[11]);


                            return objInfo;
                        }
                    }
                    return null;
                }

            }

        }

        public List<clsPlacementInduction> LoadAll(clsPlacementInduction obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("PlacementInduction_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    objCmd.Parameters.AddWithValue("@KeyWords", obj.KeyWords);
                    objCmd.Parameters.AddWithValue("@FromDate", obj.FromDate);
                    objCmd.Parameters.AddWithValue("@ToDate", obj.ToDate);
                    objCmd.Parameters.AddWithValue("@Location", obj.Location);
                    objCmd.Parameters.AddWithValue("@Employee", obj.Employee);
                    objCmd.Parameters.AddWithValue("@IsHRMockApproved", obj.IsHRMockApproved);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);

                    objAdp.Fill(objDset);

                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsPlacementInduction> objList = new List<clsPlacementInduction>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsPlacementInduction objInfo = new clsPlacementInduction();
                                objInfo.SNo = cnt + 1;
                                objInfo.PlacementInductionId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.Participant = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.Mobile = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.Email = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.ReferenceNo = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.SubscriptionExpiredOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.IsTermsAccepted = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[7]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[8] != DBNull.Value)
                                    objInfo.AttendedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.HRMockFeebackImagePath = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[10] != DBNull.Value)
                                    objInfo.Score = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                objInfo.IsHRMockApproved = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[11]);
                                objInfo.StartDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[12]);
                                objInfo.Location = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[13]);
                                objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[14]);
                                objInfo.ProfileOwner = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[15]);
                                objInfo.Qualification = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[16]);
                                objInfo.HRMockInputs = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[17]);

                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }

        public int LoadPlacementInductionValidation(clsPlacementInduction obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("PlacementInduction_Validation", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    int count = Convert.ToInt16(objCmd.ExecuteScalar());
                    return count;
                }
            }
        }

        public string Constr1 = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();
        public void AddUpdateHRMock(clsPlacementInduction obj)
        {
            using (SqlConnection objconn = new SqlConnection(Constr1))
            {
                using (SqlCommand objcmd = new SqlCommand("HRMockFeedbackForm_AddUpdate", objconn))
                {
                    objconn.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@ConductHRMcokFeedBackFormId", obj.ConductHRMcokFeedBackFormId);
                    objcmd.Parameters.AddWithValue("@PlacementInductionId", obj.PlacementInductionId);
                    objcmd.Parameters.AddWithValue("@HRMockQuestionId", obj.HRMockQuestionId);
                    objcmd.Parameters.AddWithValue("@RemarksId", obj.RemarksId);
                    objcmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objcmd.ExecuteNonQuery();
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


