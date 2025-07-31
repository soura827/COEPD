using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BusinessLayer;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DataAccessLayerHelper
{
    public class clsParticipantPlacementAssistanceDataSheetData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs3"].ConnectionString.ToString();
        public void AddUpdate(clsParticipantPlacementAssistanceDataSheet obj)
        {
            using (SqlConnection objconn = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("ParticipantPlacementAssistanceDataSheet_AddUpdate", objconn))
                {
                    objconn.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@ParticipantPlacementAssistanceDataSheetId", obj.ParticipantPlacementAssistanceDataSheetId);
                    objcmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId); 
                    objcmd.Parameters.AddWithValue("@FullName", obj.FullName);
                    objcmd.Parameters.AddWithValue("@DateOfBirth", obj.DateOfBirth);
                    objcmd.Parameters.AddWithValue("@ActiveMobile", obj.ActiveMobile);
                    objcmd.Parameters.AddWithValue("@Email", obj.Email);
                    objcmd.Parameters.AddWithValue("@Batch", obj.Batch);
                    objcmd.Parameters.AddWithValue("@TrainerName", obj.TrainerName);
                    objcmd.Parameters.AddWithValue("@LocationOfTraining", obj.LocationOfTraining);
                    objcmd.Parameters.AddWithValue("@NurturingStatusId", obj.NurturingStatusId);
                    objcmd.Parameters.AddWithValue("@TotalFeePaid", obj.TotalFeePaid);
                    objcmd.Parameters.AddWithValue("@TotalExperience", obj.TotalExperience);
                    objcmd.Parameters.AddWithValue("@RelevantExperience", obj.RelevantExperience);
                    objcmd.Parameters.AddWithValue("@JobExperienceDomain", obj.JobExperienceDomain);
                    objcmd.Parameters.AddWithValue("@JobExpectedDomain", obj.JobExpectedDomain);
                    objcmd.Parameters.AddWithValue("@CommunicationSkillsRating", obj.CommunicationSkillsRating);
                    objcmd.Parameters.AddWithValue("@BASkills", obj.BASkills);
                    objcmd.Parameters.AddWithValue("@CurrentCTC", obj.CurrentCTC);
                    objcmd.Parameters.AddWithValue("@ExpectedCTC", obj.ExpectedCTC);
                    objcmd.Parameters.AddWithValue("@CurrentLocation", obj.CurrentLocation);
                    objcmd.Parameters.AddWithValue("@PreferredLocations", obj.PreferredLocations);
                    objcmd.Parameters.AddWithValue("@ResumeFinalizedOn", obj.ResumeFinalizedOn);
                    objcmd.Parameters.AddWithValue("@PassportSizePhotoImagePath", obj.PassportSizePhotoImagePath);
                    objcmd.Parameters.AddWithValue("@AadharCardFrontImagePath", obj.AadharCardFrontImagePath);
                    objcmd.Parameters.AddWithValue("@AadharCardBackImagePath", obj.AadharCardBackImagePath);
                    objcmd.Parameters.AddWithValue("@IsDataSheetApproved", obj.IsDataSheetApproved);
                    objcmd.Parameters.AddWithValue("@SalarySlipImagePath", obj.SalarySlipImagePath);
                    objcmd.Parameters.AddWithValue("@NoticePeriodId", obj.NoticePeriodId);
                    objcmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objcmd.Parameters.AddWithValue("@TotalExperienceMonths", obj.TotalExperienceMonths);
                    objcmd.Parameters.AddWithValue("@RelevantExperienceMonths", obj.RelevantExperienceMonths);
                    objcmd.Parameters.AddWithValue("@ServiceFormImagePath", obj.ServiceFormImagePath);
                    objcmd.ExecuteNonQuery();
                }
            }
        }
        public clsParticipantPlacementAssistanceDataSheet Load(int id)
        {
            using (SqlConnection objconn = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("ParticipantPlacementAssistanceDataSheet_Get", objconn))
                {
                    objconn.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@ParticipantPlacementAssistanceDataSheetId", id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objcmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsParticipantPlacementAssistanceDataSheet objInfo = new clsParticipantPlacementAssistanceDataSheet();
                            objInfo.ParticipantPlacementAssistanceDataSheetId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.FullName = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.DateOfBirth = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.ActiveMobile = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[4]);
                            objInfo.Email = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[5]);
                            objInfo.Batch = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[6]);
                            objInfo.TrainerName = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[7]);
                            objInfo.LocationOfTraining = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[8]);
                            objInfo.NurturingStatusId = Convert.ToInt16(objDset.Tables[0].Rows[0].ItemArray[9]);
                            objInfo.TotalFeePaid = Convert.ToDecimal(objDset.Tables[0].Rows[0].ItemArray[10]);
                            objInfo.TotalExperience = Convert.ToInt16(objDset.Tables[0].Rows[0].ItemArray[11]);
                            objInfo.RelevantExperience = Convert.ToInt16(objDset.Tables[0].Rows[0].ItemArray[12]);
                            objInfo.JobExperienceDomain = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[13]);
                            objInfo.JobExpectedDomain = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[14]);
                            objInfo.CommunicationSkillsRating = Convert.ToInt16(objDset.Tables[0].Rows[0].ItemArray[15]);
                            objInfo.BASkills = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[16]);
                            objInfo.CurrentCTC = Convert.ToDecimal(objDset.Tables[0].Rows[0].ItemArray[17]);
                            objInfo.ExpectedCTC = Convert.ToDecimal(objDset.Tables[0].Rows[0].ItemArray[18]);
                            objInfo.CurrentLocation = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[19]);
                            objInfo.PreferredLocations = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[20]);
                            objInfo.ResumeFinalizedOn = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[21]);
                            objInfo.PassportSizePhotoImagePath = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[22]);
                            objInfo.AadharCardFrontImagePath = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[23]);
                            objInfo.AadharCardBackImagePath = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[24]);
                            objInfo.IsDataSheetApproved = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[25]);
                            objInfo.SalarySlipImagePath = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[26]);
                            if (objDset.Tables[0].Rows[0].ItemArray[27] != DBNull.Value)
                                objInfo.NoticePeriodId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[27]);
                            if (objDset.Tables[0].Rows[0].ItemArray[28] != DBNull.Value)
                                objInfo.TotalExperienceMonths = Convert.ToInt16(objDset.Tables[0].Rows[0].ItemArray[28]);
                            if (objDset.Tables[0].Rows[0].ItemArray[29] != DBNull.Value)
                                objInfo.RelevantExperienceMonths = Convert.ToInt16(objDset.Tables[0].Rows[0].ItemArray[29]);
                            objInfo.ServiceFormImagePath = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[30]);
                            return objInfo;
                        }
                    }
                    return null;
                }

            }

        }

        public List<clsParticipantPlacementAssistanceDataSheet> LoadAll(clsParticipantPlacementAssistanceDataSheet obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ParticipantPlacementAssistanceDataSheet_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@keywords", obj.Keywords);
                    objCmd.Parameters.AddWithValue("@ProfileOwnerId", obj.ProfileOwnerId);
                    objCmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    objCmd.Parameters.AddWithValue("@IsDataSheetApproved", obj.IsDataSheetApproved);
                    objCmd.Parameters.AddWithValue("@ProfileOwnerKeywords", obj.ProfileOwnerKeywords);
                    objCmd.Parameters.AddWithValue("@PreferredLocations", obj.PreferredLocations);
                    objCmd.Parameters.AddWithValue("@TotalExperience", obj.TotalExperience);
                    objCmd.Parameters.AddWithValue("@RelevantExperience", obj.RelevantExperience);
                    objCmd.Parameters.AddWithValue("@JobExperienceDomain", obj.JobExperienceDomain);
                    objCmd.Parameters.AddWithValue("@JobExpectedDomain", obj.JobExpectedDomain);
                    objCmd.Parameters.AddWithValue("@IsSubscriptionExpired", obj.IsSubscriptionExpired);

                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);

                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsParticipantPlacementAssistanceDataSheet> objList = new List<clsParticipantPlacementAssistanceDataSheet>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsParticipantPlacementAssistanceDataSheet objInfo = new clsParticipantPlacementAssistanceDataSheet();
                                objInfo.SNo = cnt + 1;
                                objInfo.ParticipantPlacementAssistanceDataSheetId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.FullName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.DateOfBirth = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.ActiveMobile = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.Email = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.Batch = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.TrainerName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.LocationOfTraining = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.NurturingStatusId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objInfo.TotalFeePaid = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                objInfo.TotalExperience = Convert.ToInt16(objDset.Tables[0].Rows[cnt].ItemArray[11]);
                                objInfo.RelevantExperience = Convert.ToInt16(objDset.Tables[0].Rows[cnt].ItemArray[12]);
                                objInfo.JobExperienceDomain = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[13]);
                                objInfo.JobExpectedDomain = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[14]);
                                objInfo.CommunicationSkillsRating = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[15]);
                                objInfo.BASkills = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[16]);
                                objInfo.CurrentCTC = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[17]);
                                objInfo.ExpectedCTC = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[18]);
                                objInfo.CurrentLocation = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[19]);
                                objInfo.PreferredLocations = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[20]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[21] != DBNull.Value)
                                    objInfo.ResumeFinalizedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[21]);
                                objInfo.NoticePeriod = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[22]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[23] != DBNull.Value)
                                    objInfo.PassportSizePhotoImagePath = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[23]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[24] != DBNull.Value)
                                    objInfo.AadharCardFrontImagePath = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[24]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[25] != DBNull.Value)
                                    objInfo.AadharCardBackImagePath = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[25]);
                                objInfo.IsDataSheetApproved = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[26]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[27] != DBNull.Value)
                                    objInfo.ProfileOwnerName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[27]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[28] != DBNull.Value)
                                    objInfo.SubscriptionExpiredOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[28]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[29] != DBNull.Value)
                                    objInfo.IsProfileOwnerAssigned = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[29]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[30] != DBNull.Value)
                                    objInfo.SalarySlipImagePath = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[30]);
                                objInfo.TotalExperiencess = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[31]);
                                objInfo.RelevantExperiencess = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[32]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[33] != DBNull.Value)
                                    objInfo.ServiceFormImagePath = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[33]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }




        public List<clsParticipantPlacementAssistanceDataSheet> LoadForAll(clsParticipantPlacementAssistanceDataSheet obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ParticipantPlacementAssistanceDataSheetSearch_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@keywords", obj.Keywords);
                    objCmd.Parameters.AddWithValue("@ProfileOwnerId", obj.ProfileOwnerId);
                    objCmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    objCmd.Parameters.AddWithValue("@IsDataSheetApproved", obj.IsDataSheetApproved);
                    objCmd.Parameters.AddWithValue("@ProfileOwnerKeywords", obj.ProfileOwnerKeywords);
                    //objCmd.Parameters.AddWithValue("@PreferredLocations", obj.PreferredLocations);
                    //objCmd.Parameters.AddWithValue("@TotalExperience", obj.TotalExperience);
                    //objCmd.Parameters.AddWithValue("@RelevantExperience", obj.RelevantExperience);
                    //objCmd.Parameters.AddWithValue("@JobExperienceDomain", obj.JobExperienceDomain);
                    //objCmd.Parameters.AddWithValue("@JobExpectedDomain", obj.JobExpectedDomain);
                   // objCmd.Parameters.AddWithValue("@IsSubscriptionExpired", obj.IsSubscriptionExpired);

                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);

                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsParticipantPlacementAssistanceDataSheet> objList = new List<clsParticipantPlacementAssistanceDataSheet>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsParticipantPlacementAssistanceDataSheet objInfo = new clsParticipantPlacementAssistanceDataSheet();
                                objInfo.SNo = cnt + 1;
                                objInfo.ParticipantPlacementAssistanceDataSheetId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.FullName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.DateOfBirth = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.ActiveMobile = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.Email = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.Batch = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.TrainerName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.LocationOfTraining = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.NurturingStatusId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objInfo.TotalFeePaid = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                objInfo.TotalExperience = Convert.ToInt16(objDset.Tables[0].Rows[cnt].ItemArray[11]);
                                objInfo.RelevantExperience = Convert.ToInt16(objDset.Tables[0].Rows[cnt].ItemArray[12]);
                                objInfo.JobExperienceDomain = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[13]);
                                objInfo.JobExpectedDomain = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[14]);
                                objInfo.CommunicationSkillsRating = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[15]);
                                objInfo.BASkills = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[16]);
                                objInfo.CurrentCTC = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[17]);
                                objInfo.ExpectedCTC = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[18]);
                                objInfo.CurrentLocation = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[19]);
                                objInfo.PreferredLocations = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[20]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[21] != DBNull.Value)
                                    objInfo.ResumeFinalizedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[21]);
                                objInfo.NoticePeriod = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[22]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[23] != DBNull.Value)
                                    objInfo.PassportSizePhotoImagePath = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[23]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[24] != DBNull.Value)
                                    objInfo.AadharCardFrontImagePath = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[24]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[25] != DBNull.Value)
                                    objInfo.AadharCardBackImagePath = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[25]);
                                objInfo.IsDataSheetApproved = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[26]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[27] != DBNull.Value)
                                    objInfo.ProfileOwnerName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[27]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[28] != DBNull.Value)
                                    objInfo.SubscriptionExpiredOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[28]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[29] != DBNull.Value)
                                    objInfo.IsProfileOwnerAssigned = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[29]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[30] != DBNull.Value)
                                    objInfo.SalarySlipImagePath = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[30]);
                                objInfo.TotalExperiencess = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[31]);
                                objInfo.RelevantExperiencess = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[32]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[33] != DBNull.Value)
                                    objInfo.ServiceFormImagePath = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[33]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }

















































        public int LoadParticipantPlacementAssistanceDataSheetValidation(clsParticipantPlacementAssistanceDataSheet obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ParticipantPlacementAssistanceDataSheet_Validation", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    int count = Convert.ToInt16(objCmd.ExecuteScalar());
                    return count;
                }
            }
        }
        public List<clsParticipantPlacementAssistanceDataSheet> LoadAllNoticePeriod(clsParticipantPlacementAssistanceDataSheet obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("NoticePeriod_List", objConn))
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
                            List<clsParticipantPlacementAssistanceDataSheet> objList = new List<clsParticipantPlacementAssistanceDataSheet>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsParticipantPlacementAssistanceDataSheet objInfo = new clsParticipantPlacementAssistanceDataSheet();

                                objInfo.NoticePeriodId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.NoticePeriod = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }


                    }
                    return null;

                }
            }
        }

    }
}
