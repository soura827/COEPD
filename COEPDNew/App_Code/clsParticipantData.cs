using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace DataAccessLayerHelper
{
    public class clsParticipantData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();

        public void AddUpdate(clsParticipant obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Participant_AddUpdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    objCmd.Parameters.AddWithValue("@Participant", obj.Participant);
                    objCmd.Parameters.AddWithValue("@BatchId", obj.BatchId);
                    objCmd.Parameters.AddWithValue("@LocationId", obj.LocationId);
                    objCmd.Parameters.AddWithValue("@BranchId", obj.BranchId);
                    objCmd.Parameters.AddWithValue("@DomainId", obj.DomainId);
                    objCmd.Parameters.AddWithValue("@Email", obj.Email);
                    objCmd.Parameters.AddWithValue("@Mobile", obj.Mobile);
                    objCmd.Parameters.AddWithValue("@YearsOfExp", obj.YearsOfExp);
                    objCmd.Parameters.AddWithValue("@MonthsOfExp", obj.MonthsOfExp);
                    objCmd.Parameters.AddWithValue("@Remarks", obj.Remarks);
                    //objCmd.Parameters.AddWithValue("@IsActive", obj.IsActive);
                    objCmd.Parameters.AddWithValue("@ReferenceNo", obj.ReferenceNo);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.Parameters.AddWithValue("@StatusId", obj.StatusId);
                    objCmd.Parameters.AddWithValue("@CertificatePath", obj.CertificatePath);
                    objCmd.Parameters.AddWithValue("@Fee", obj.Fee);
                    objCmd.Parameters.AddWithValue("@IsIntern", obj.IsIntern);
                    objCmd.Parameters.AddWithValue("@LeadId", obj.LeadId);
                    objCmd.Parameters.AddWithValue("@InternBatchId", obj.InternBatchId);
                    objCmd.Parameters.AddWithValue("@IsExamPermit", obj.IsExamPermit);
                    objCmd.Parameters.AddWithValue("@SubscriptionExpiredOn", obj.SubscriptionExpiredOn);
                    objCmd.Parameters.AddWithValue("@LeadSourceId", obj.LeadSourceId);
                    objCmd.Parameters.AddWithValue("@AlternateMobileNo", obj.AlternateMobileNo);
                    objCmd.Parameters.AddWithValue("@SkypeId", obj.SkypeId);
                    objCmd.ExecuteNonQuery();
                }
            }
        }

        public clsParticipant Load(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Participant_Get", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ParticipantId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsParticipant objInfo = new clsParticipant();
                            objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.Participant = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.Code = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.BatchId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.BranchId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[4]);
                            objInfo.LocationId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[5]);
                            objInfo.DomainId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[6]);
                            objInfo.Email = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[7]);
                            objInfo.Mobile = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[8]);
                            objInfo.YearsOfExp = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[9]);
                            objInfo.MonthsOfExp = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[10]);
                            objInfo.Remarks = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[11]);
                            //objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[12]);
                            objInfo.ReferenceNo = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[12]);
                            objInfo.StatusId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[13]);
                            objInfo.CertificatePath = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[14]);
                            objInfo.Fee = Convert.ToDecimal(objDset.Tables[0].Rows[0].ItemArray[15]);
                            objInfo.IsIntern = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[16]);
                            objInfo.InternBatchId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[17]);
                            if (objDset.Tables[0].Rows[0].ItemArray[18] != DBNull.Value)
                                objInfo.IsExamPermit = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[18]);
                            if (objDset.Tables[0].Rows[0].ItemArray[19] != DBNull.Value)
                                objInfo.SubscriptionExpiredOn = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[19]);
                            if (objDset.Tables[0].Rows[0].ItemArray[20] != DBNull.Value)
                                objInfo.LastSlotStartTime = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[20]);
                            if (objDset.Tables[0].Rows[0].ItemArray[21] != DBNull.Value)
                                objInfo.IsPlacementPermit = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[21]);
                            if (objDset.Tables[0].Rows[0].ItemArray[22] != DBNull.Value)
                                objInfo.SpecialNote = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[22]);
                            if (objDset.Tables[0].Rows[0].ItemArray[23] != DBNull.Value)
                                objInfo.ProfileOwnerId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[23]);
                            if (objDset.Tables[0].Rows[0].ItemArray[24] != DBNull.Value)
                                objInfo.StartDate = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[24]);
                            if (objDset.Tables[0].Rows[0].ItemArray[25] != DBNull.Value)
                                objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[25]);
                            if (objDset.Tables[0].Rows[0].ItemArray[26] != DBNull.Value)
                                objInfo.Location = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[26]);
                            objInfo.IsGoalSet = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[27]);
                            objInfo.PurposeOfAttending = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[28]);
                            if (objDset.Tables[0].Rows[0].ItemArray[29] != DBNull.Value)
                                objInfo.TargetDate = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[29]);
                            if (objDset.Tables[0].Rows[0].ItemArray[30] != DBNull.Value)
                                objInfo.DailyTimeSpend = Convert.ToInt16(objDset.Tables[0].Rows[0].ItemArray[30]);
                            if (objDset.Tables[0].Rows[0].ItemArray[31] != DBNull.Value)
                                objInfo.SetGoalOn = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[31]);
                            if (objDset.Tables[0].Rows[0].ItemArray[32] != DBNull.Value)
                                objInfo.TotalExperience = Convert.ToInt16(objDset.Tables[0].Rows[0].ItemArray[32]);
                            if (objDset.Tables[0].Rows[0].ItemArray[33] != DBNull.Value)
                                objInfo.RelevantExperience = Convert.ToInt16(objDset.Tables[0].Rows[0].ItemArray[33]);
                            if (objDset.Tables[0].Rows[0].ItemArray[34] != DBNull.Value)
                                objInfo.CommunicationSkillsRating = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[34]);
                            objInfo.BASkills = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[35]);
                            if (objDset.Tables[0].Rows[0].ItemArray[36] != DBNull.Value)
                                objInfo.CurrentCTC = Convert.ToDecimal(objDset.Tables[0].Rows[0].ItemArray[36]);
                            if (objDset.Tables[0].Rows[0].ItemArray[37] != DBNull.Value)
                                objInfo.ExpectedCTC = Convert.ToDecimal(objDset.Tables[0].Rows[0].ItemArray[37]);
                            if (objDset.Tables[0].Rows[0].ItemArray[38] != DBNull.Value)
                                objInfo.TotalExperienceMonths = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[38]);
                            if (objDset.Tables[0].Rows[0].ItemArray[39] != DBNull.Value)
                                objInfo.RelevantExperienceMonths = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[39]);
                            if (objDset.Tables[0].Rows[0].ItemArray[40] != DBNull.Value)
                                objInfo.LeadSourceId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[40]);

                            if (objDset.Tables[0].Rows[0].ItemArray[41] != DBNull.Value)
                                objInfo.AlternateMobileNo = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[41]);

                            if (objDset.Tables[0].Rows[0].ItemArray[42] != DBNull.Value)
                                objInfo.SkypeId = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[42]);

                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }

        public clsParticipant LoadByEmailRefNo(string Email, string ReferenceNo)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Participant_Get_EmailRefNo", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@Email", Email);
                    objCmd.Parameters.AddWithValue("@ReferenceNo", ReferenceNo);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsParticipant objInfo = new clsParticipant();
                            objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.Participant = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.Batch = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[2]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }

        public List<clsParticipant> LoadAll(clsParticipant obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Participant_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@keywords", obj.keywords);
                    objCmd.Parameters.AddWithValue("@CourseId", obj.CourseId);
                    objCmd.Parameters.AddWithValue("@BatchTypeId", obj.BatchTypeId);
                    objCmd.Parameters.AddWithValue("@LocationId", obj.LocationId);
                    objCmd.Parameters.AddWithValue("@EmployeeId", obj.EmployeeId);
                    objCmd.Parameters.AddWithValue("@IsIntern", obj.IsIntern);
                    objCmd.Parameters.AddWithValue("@BatchId", obj.BatchId);
                    objCmd.Parameters.AddWithValue("@IsExamPermit", obj.IsExamPermit);
                    objCmd.Parameters.AddWithValue("@FromDate", obj.FromDate);
                    objCmd.Parameters.AddWithValue("@ToDate", obj.ToDate);
                    objCmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    objCmd.Parameters.AddWithValue("@StatusCode", obj.StatusCode);
                    objCmd.Parameters.AddWithValue("@CreatedName", obj.CreatedName);
                    objCmd.Parameters.AddWithValue("@ModifiedName", obj.ModifiedName);


                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);

                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsParticipant> objList = new List<clsParticipant>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsParticipant objInfo = new clsParticipant();
                                objInfo.SNo = cnt + 1;
                                objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Participant = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.Code = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.BatchId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.LocationId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.DomainId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.Email = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.Mobile = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.YearsOfExp = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.MonthsOfExp = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objInfo.Remarks = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[11]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[12] != DBNull.Value)
                                    objInfo.StartDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[12]);
                                objInfo.Location = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[13]);
                                objInfo.Domain = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[14]);
                                objInfo.ReferenceNo = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[15]);
                                objInfo.StatusId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[16]);
                                objInfo.CertificatePath = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[17]);
                                objInfo.Fee = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[18]);
                                objInfo.IsIntern = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[19]);
                                objInfo.InternBatchId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[20]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[21] != DBNull.Value)
                                    objInfo.InternDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[21]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[22] != DBNull.Value)
                                    objInfo.IsExamPermit = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[22]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[23] != DBNull.Value)
                                    objInfo.Pwd = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[23]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[24] != DBNull.Value)
                                    objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[24]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[25] != DBNull.Value)
                                    objInfo.SubscriptionExpiredOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[25]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[26] != DBNull.Value)
                                    objInfo.LastSlotStartTime = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[26]);
                                objInfo.StatusName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[27]);

                                if (objDset.Tables[0].Rows[0].ItemArray[28] != DBNull.Value)
                                    objInfo.AlternateMobileNo = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[28]);

                                if (objDset.Tables[0].Rows[0].ItemArray[29] != DBNull.Value)
                                    objInfo.SkypeId = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[29]);

                                ////objInfo.Fullname = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[30]);

                                //objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[31]);

                                //if (objDset.Tables[0].Rows[cnt].ItemArray[32] != DBNull.Value)
                                //    objInfo.ModifiedName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[32]);

                                //if (objDset.Tables[0].Rows[cnt].ItemArray[33] != DBNull.Value)
                                //    objInfo.ModifiedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[33]);

                                //if (objDset.Tables[0].Rows[cnt].ItemArray[28] != DBNull.Value)
                                //    objInfo.StatusCode = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[28]);

                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }

        public List<clsParticipant> LoadAllPlacement(clsParticipant obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Participant_PlacementsList", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@keywords", obj.keywords);
                    objCmd.Parameters.AddWithValue("@LocationId", obj.LocationId);
                    objCmd.Parameters.AddWithValue("@EmployeeId", obj.EmployeeId);
                    objCmd.Parameters.AddWithValue("@FromDate", obj.FromDate);
                    objCmd.Parameters.AddWithValue("@ToDate", obj.ToDate);
                    objCmd.Parameters.AddWithValue("@ProfileOwnerId", obj.ProfileOwnerId);

                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);

                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsParticipant> objList = new List<clsParticipant>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsParticipant objInfo = new clsParticipant();
                                objInfo.SNo = cnt + 1;
                                objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Participant = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.BatchId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.LocationId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.DomainId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.Email = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.Mobile = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.YearsOfExp = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.MonthsOfExp = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[10] != DBNull.Value)
                                    objInfo.StartDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                objInfo.Location = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[11]);
                                objInfo.Domain = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[12]);
                                objInfo.ReferenceNo = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[13]);
                                objInfo.CertificatePath = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[14]);
                                objInfo.Fee = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[15]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[16] != DBNull.Value)
                                    objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[16]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[17] != DBNull.Value)
                                    objInfo.SubscriptionExpiredOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[17]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[18] != DBNull.Value)
                                    objInfo.ProfileOwnerId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[18]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[19] != DBNull.Value)
                                    objInfo.ProfileOwnerName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[19]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[20] != DBNull.Value)
                                    objInfo.IsProfileOwnerAssigned = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[20]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[21] != DBNull.Value)
                                    objInfo.MovedToPlacementOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[21]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[22] != DBNull.Value)
                                    objInfo.MovedToPlacementByName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[22]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[23] != DBNull.Value)
                                    objInfo.ProfileOwnerAssignedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[23]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[24] != DBNull.Value)
                                    objInfo.ProfileOwnerAssignedByName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[24]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }

        public List<clsParticipant> LoadAllNurturing(clsParticipant obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Participant_NurturingList", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@keywords", obj.keywords);
                    objCmd.Parameters.AddWithValue("@LocationId", obj.LocationId);
                    objCmd.Parameters.AddWithValue("@EmployeeId", obj.EmployeeId);
                    objCmd.Parameters.AddWithValue("@FromDate", obj.FromDate);
                    objCmd.Parameters.AddWithValue("@ToDate", obj.ToDate);
                    objCmd.Parameters.AddWithValue("IsSubscriptionExpired", obj.IsSubscriptionExpired);

                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);

                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsParticipant> objList = new List<clsParticipant>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsParticipant objInfo = new clsParticipant();
                                objInfo.SNo = cnt + 1;
                                objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Participant = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.Code = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.BatchId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.LocationId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.DomainId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.Email = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.Mobile = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.YearsOfExp = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.MonthsOfExp = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objInfo.Remarks = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[11]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[12] != DBNull.Value)
                                    objInfo.StartDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[12]);
                                objInfo.Location = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[13]);
                                objInfo.Domain = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[14]);
                                objInfo.ReferenceNo = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[15]);
                                objInfo.StatusId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[16]);
                                objInfo.CertificatePath = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[17]);
                                objInfo.Fee = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[18]);
                                objInfo.IsIntern = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[19]);
                                objInfo.InternBatchId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[20]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[21] != DBNull.Value)
                                    objInfo.InternDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[21]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[22] != DBNull.Value)
                                    objInfo.IsExamPermit = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[22]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[23] != DBNull.Value)
                                    objInfo.Pwd = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[23]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[24] != DBNull.Value)
                                    objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[24]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[25] != DBNull.Value)
                                    objInfo.SubscriptionExpiredOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[25]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[26] != DBNull.Value)
                                    objInfo.LastSlotStartTime = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[26]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }

        public List<clsParticipant> LoadAllMultiple(clsParticipant obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Participant_ListMultiple", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@keywords1", obj.Keywords1);
                    objCmd.Parameters.AddWithValue("@keywords2", obj.Keywords2);
                    objCmd.Parameters.AddWithValue("@keywords3", obj.Keywords3);
                    objCmd.Parameters.AddWithValue("@keywords4", obj.Keywords4);
                    objCmd.Parameters.AddWithValue("@keywords5", obj.Keywords5);
                    objCmd.Parameters.AddWithValue("@keywords6", obj.Keywords6);
                    objCmd.Parameters.AddWithValue("@keywords7", obj.Keywords7);
                    objCmd.Parameters.AddWithValue("@keywords8", obj.Keywords8);
                    objCmd.Parameters.AddWithValue("@keywords9", obj.Keywords9);
                    objCmd.Parameters.AddWithValue("@keywords10", obj.Keywords10);
                    objCmd.Parameters.AddWithValue("@keywords11", obj.Keywords11);
                    objCmd.Parameters.AddWithValue("@keywords12", obj.Keywords12);
                    objCmd.Parameters.AddWithValue("@keywords13", obj.Keywords13);
                    objCmd.Parameters.AddWithValue("@keywords14", obj.Keywords14);
                    objCmd.Parameters.AddWithValue("@keywords15", obj.Keywords15);
                    objCmd.Parameters.AddWithValue("@keywords16", obj.Keywords16);
                    objCmd.Parameters.AddWithValue("@keywords17", obj.Keywords17);
                    objCmd.Parameters.AddWithValue("@keywords18", obj.Keywords18);
                    objCmd.Parameters.AddWithValue("@keywords19", obj.Keywords19);
                    objCmd.Parameters.AddWithValue("@keywords20", obj.Keywords20);
                    objCmd.Parameters.AddWithValue("@keywords21", obj.Keywords21);
                    objCmd.Parameters.AddWithValue("@keywords22", obj.Keywords22);
                    objCmd.Parameters.AddWithValue("@keywords23", obj.Keywords23);
                    objCmd.Parameters.AddWithValue("@keywords24", obj.Keywords24);
                    objCmd.Parameters.AddWithValue("@keywords25", obj.Keywords25);
                    objCmd.Parameters.AddWithValue("@keywords26", obj.Keywords26);
                    objCmd.Parameters.AddWithValue("@keywords27", obj.Keywords27);
                    objCmd.Parameters.AddWithValue("@keywords28", obj.Keywords28);
                    objCmd.Parameters.AddWithValue("@keywords29", obj.Keywords29);
                    objCmd.Parameters.AddWithValue("@keywords30", obj.Keywords30);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);

                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsParticipant> objList = new List<clsParticipant>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsParticipant objInfo = new clsParticipant();
                                objInfo.SNo = cnt + 1;
                                objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Participant = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.Code = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.BatchId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.LocationId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.DomainId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.Email = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.Mobile = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.YearsOfExp = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.MonthsOfExp = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objInfo.Remarks = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[11]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[12] != DBNull.Value)
                                    objInfo.StartDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[12]);
                                objInfo.Location = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[13]);
                                objInfo.Domain = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[14]);
                                objInfo.ReferenceNo = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[15]);
                                objInfo.StatusId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[16]);
                                objInfo.CertificatePath = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[17]);
                                objInfo.Fee = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[18]);
                                objInfo.IsIntern = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[19]);
                                objInfo.InternBatchId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[20]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[21] != DBNull.Value)
                                    objInfo.InternDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[21]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[22] != DBNull.Value)
                                    objInfo.IsExamPermit = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[22]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[23] != DBNull.Value)
                                    objInfo.Pwd = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[23]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[24] != DBNull.Value)
                                    objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[24]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }
        public List<clsParticipant> LoadAllIntern(clsParticipant obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Participant_List_Intern", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@keywords", obj.keywords);
                    //objCmd.Parameters.AddWithValue("@CourseId", obj.CourseId);
                    //objCmd.Parameters.AddWithValue("@BatchTypeId", obj.BatchTypeId);
                    //objCmd.Parameters.AddWithValue("@LocationId", obj.LocationId);
                    //objCmd.Parameters.AddWithValue("@EmployeeId", obj.EmployeeId);
                    objCmd.Parameters.AddWithValue("@IsIntern", obj.IsIntern);
                    objCmd.Parameters.AddWithValue("@InternBatchId", obj.InternBatchId);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);

                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsParticipant> objList = new List<clsParticipant>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsParticipant objInfo = new clsParticipant();
                                objInfo.SNo = cnt + 1;
                                objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Participant = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.Code = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.BatchId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.LocationId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.DomainId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.Email = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.Mobile = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.YearsOfExp = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.MonthsOfExp = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objInfo.Remarks = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[11]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[12] != DBNull.Value)
                                    objInfo.StartDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[12]);
                                objInfo.Location = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[13]);
                                objInfo.Domain = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[14]);
                                objInfo.ReferenceNo = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[15]);
                                objInfo.StatusId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[16]);
                                objInfo.CertificatePath = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[17]);
                                objInfo.Fee = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[18]);
                                objInfo.IsIntern = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[19]);
                                objInfo.InternBatchId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[20]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[21] != DBNull.Value)
                                    objInfo.InternDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[21]);
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
                using (SqlCommand objCmd = new SqlCommand("Participant_Remove", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ParticipantId", Id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteCertificate(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("UPDATE tblParticipant SET CertificatePath='" + null + "' WHERE ParticipantId='" + Id + "'", objConn))
                {
                    objConn.Open();
                    objCmd.ExecuteNonQuery();
                }
            }
        }
        public List<clsParticipant> LoadDueAmount(clsParticipant obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Participant_DueAmount", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@keywords", obj.keywords);
                    objCmd.Parameters.AddWithValue("@BatchId", obj.BatchId);

                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);

                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsParticipant> objList = new List<clsParticipant>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsParticipant objInfo = new clsParticipant();
                                objInfo.SNo = cnt + 1;
                                objInfo.Participant = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Mobile = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.Email = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.StartDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.BatchType = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.Location = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.Fee = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.ReceivedAmount = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.Due = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }

        public List<clsParticipant> LoadAllByBatch(clsParticipant obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Participant_List_ByBatchId", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@keywords", obj.keywords);
                    objCmd.Parameters.AddWithValue("@BatchId", obj.BatchId);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);

                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsParticipant> objList = new List<clsParticipant>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsParticipant objInfo = new clsParticipant();
                                objInfo.SNo = cnt + 1;
                                objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Participant = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.BatchId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[4] != DBNull.Value)
                                    objInfo.StartDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }

        public void AddToIntrnship(clsParticipant obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Participant_Add_Internship", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    objCmd.Parameters.AddWithValue("@InternBatchId", obj.InternBatchId);
                    objCmd.Parameters.AddWithValue("@IsIntern", obj.IsIntern);
                    objCmd.ExecuteNonQuery();
                }
            }
        }

        public void AddToPlacement(clsParticipant obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Participant_Add_Placement", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    objCmd.Parameters.AddWithValue("@IsPlacementPermit", obj.IsPlacementPermit);
                    objCmd.Parameters.AddWithValue("@SpecialNote", obj.SpecialNote);
                    objCmd.Parameters.AddWithValue("@TotalExperience", obj.TotalExperience);
                    objCmd.Parameters.AddWithValue("@RelevantExperience", obj.RelevantExperience);
                    objCmd.Parameters.AddWithValue("@CommunicationSkillsRating", obj.CommunicationSkillsRating);
                    objCmd.Parameters.AddWithValue("@BASkills", obj.BASkills);
                    objCmd.Parameters.AddWithValue("@CurrentCTC", obj.CurrentCTC);
                    objCmd.Parameters.AddWithValue("@ExpectedCTC", obj.ExpectedCTC);
                    objCmd.Parameters.AddWithValue("@TotalExperienceMonths", obj.TotalExperienceMonths);
                    objCmd.Parameters.AddWithValue("@RelevantExperienceMonths", obj.RelevantExperienceMonths);
                    objCmd.Parameters.AddWithValue("@MovedToPlacementBy", obj.MovedToPlacementBy);
                    objCmd.ExecuteNonQuery();
                }
            }
        }

        public void AddProfileOwner(clsParticipant obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Participant_Add_ProfileOwner", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    objCmd.Parameters.AddWithValue("@IsProfileOwnerAssigned", obj.IsProfileOwnerAssigned);
                    objCmd.Parameters.AddWithValue("@ProfileOwnerId", obj.ProfileOwnerId);
                    objCmd.Parameters.AddWithValue("@ProfileOwnerAssignedBy", obj.ProfileOwnerAssignedBy);
                    objCmd.ExecuteNonQuery();
                }
            }
        }

        public List<clsParticipant> LoadAll_CertificationList(clsParticipant obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Participant_Certification_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@keywords", obj.keywords);
                    objCmd.Parameters.AddWithValue("@CourseId", obj.CourseId);
                    objCmd.Parameters.AddWithValue("@BatchTypeId", obj.BatchTypeId);
                    objCmd.Parameters.AddWithValue("@LocationId", obj.LocationId);
                    objCmd.Parameters.AddWithValue("@EmployeeId", obj.EmployeeId);
                    objCmd.Parameters.AddWithValue("@BatchId", obj.BatchId);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);

                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsParticipant> objList = new List<clsParticipant>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsParticipant objInfo = new clsParticipant();
                                objInfo.SNo = cnt + 1;
                                objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Participant = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.Code = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.BatchId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.LocationId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.DomainId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.Email = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.Mobile = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.YearsOfExp = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.MonthsOfExp = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objInfo.Remarks = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[11]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[12] != DBNull.Value)
                                    objInfo.StartDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[12]);
                                objInfo.Location = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[13]);
                                objInfo.Domain = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[14]);
                                objInfo.ReferenceNo = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[15]);
                                objInfo.StatusId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[16]);
                                objInfo.CertificatePath = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[17]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }

        public int LoadParticipantValidation(clsParticipant obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Participant_Validation", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@Mobile", obj.Mobile);
                    int Count = Convert.ToInt16(objCmd.ExecuteScalar());
                    return Count;
                }

            }
        }

        public void GoalSettingAddUpdate(clsParticipant obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Participant_GoalSettingAddUpdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    objCmd.Parameters.AddWithValue("@IsGoalSet", obj.IsGoalSet);
                    objCmd.Parameters.AddWithValue("@PurposeOfAttending", obj.PurposeOfAttending);
                    objCmd.Parameters.AddWithValue("@TargetDate", obj.TargetDate);
                    objCmd.Parameters.AddWithValue("@DailyTimeSpend", obj.DailyTimeSpend);
                    objCmd.ExecuteNonQuery();
                }
            }
        }

        public void AddUpdateStatusCode(clsParticipant obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Participant_AddUpdate_StatusCode", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    objCmd.Parameters.AddWithValue("@StatusCode", obj.StatusCode);
                    objCmd.ExecuteNonQuery();
                }
            }
        }

        public List<clsParticipant> LoadAllStatus(clsParticipant obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ParticipantLoadStatus_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@keywords", obj.keywords);
                    objCmd.Parameters.AddWithValue("@StatusName", obj.StatusName);
                    objCmd.Parameters.AddWithValue("@StatusCode", obj.StatusCode);


                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);

                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsParticipant> objList = new List<clsParticipant>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsParticipant objInfo = new clsParticipant();
                                objInfo.SNo = cnt + 1;

                                objInfo.Participant = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[27] != DBNull.Value)
                                    objInfo.StatusCode = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.StatusName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);

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

