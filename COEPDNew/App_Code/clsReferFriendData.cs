using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayerHelper
{
    public class clsReferFriendData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["ReferFriend"].ConnectionString.ToString();
        public void AddUpdate(clsReferFriend obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ReferFriend_AddUpdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ReferFriendId", obj.ReferFriendId);
                    objCmd.Parameters.AddWithValue("@ReferralName", obj.ReferralName);
                    objCmd.Parameters.AddWithValue("@ReferralContact", obj.ReferralContact);
                    objCmd.Parameters.AddWithValue("@ReferralEmail", obj.ReferralEmail);
                    objCmd.Parameters.AddWithValue("@ReferralLocationPreference", obj.ReferralLocationPreference);
                    objCmd.Parameters.AddWithValue("@Domain", obj.Domain);
                    objCmd.Parameters.AddWithValue("@PlanningToJoinTheCourse", obj.PlanningToJoinTheCourse);
                    objCmd.Parameters.AddWithValue("@ReferralAvailableTimeSchedule", obj.ReferralAvailableTimeSchedule);
                    objCmd.Parameters.AddWithValue("@IsReferralBonus", obj.IsReferralBonus);
                    objCmd.Parameters.AddWithValue("@ParticipantUPIID", obj.ParticipantUPIID);
                    objCmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    objCmd.Parameters.AddWithValue("@EmployeeId", obj.EmployeeId);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.Parameters.AddWithValue("@ProcessExecutiveLocationId", obj.ProcessExecutiveLocationId);
                    objCmd.ExecuteNonQuery();
                }
            }
        }
        public clsReferFriend Load(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ReferFriend_Get", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ReferFriendId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsReferFriend objInfo = new clsReferFriend();
                            objInfo.ReferFriendId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.ReferralName = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.ReferralContact = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.ReferralEmail = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.ReferralLocationPreference = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[4]);
                            objInfo.Domain = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[5]);
                            objInfo.PlanningToJoinTheCourse = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[6]);
                            objInfo.ReferralAvailableTimeSchedule = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[7]);
                            objInfo.IsReferralBonus = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[8]);
                            objInfo.ParticipantUPIID = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[9]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }

        public List<clsReferFriend> LoadAll(clsReferFriend obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ReferFriend_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@keywords", obj.Keywords);
                    objCmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    objCmd.Parameters.AddWithValue("@ParticipantUPIID", obj.ParticipantUPIID);
                    objCmd.Parameters.AddWithValue("@EmployeeId", obj.EmployeeId);
                    objCmd.Parameters.AddWithValue("@PlanningToJoinTheCourse", obj.PlanningToJoinTheCourse);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);

                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsReferFriend> objList = new List<clsReferFriend>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsReferFriend objInfo = new clsReferFriend();
                                objInfo.SNo = cnt + 1;
                                objInfo.ReferFriendId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.ReferralName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.ReferralContact = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.ReferralEmail = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.ReferralLocationPreference = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.Domain = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.PlanningToJoinTheCourse = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.ReferralAvailableTimeSchedule = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.IsReferralBonus = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.ParticipantUPIID = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                objInfo.EmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[11]);
                                objInfo.Location = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[12]);
                                objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[13]);
                                objInfo.CreatedBy = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[14]);
                                objInfo.Participant = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[15]);
                                objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[16]);
                                objInfo.ProofPaymentPath = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[17]);
                                objInfo.ReferAmount = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[18]);
                                objInfo.LeadCategoryId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[19]);
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
                using (SqlCommand objCmd = new SqlCommand("ReferFriend_Remove", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ReferFriendId", Id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }

        public int LoadReferFriendNameValidation(clsReferFriend obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ReferFriendName_Validation", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ReferralName", obj.ReferralName);
                    int count = Convert.ToInt16(objCmd.ExecuteScalar());
                    return count;
                }
            }
        }
        public int LoadReferFriendEmailValidation(clsReferFriend obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ReferFriendEmail_Validation", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ReferralName", obj.ReferralEmail);
                    int count = Convert.ToInt16(objCmd.ExecuteScalar());
                    return count;
                }
            }
        }

    }
}