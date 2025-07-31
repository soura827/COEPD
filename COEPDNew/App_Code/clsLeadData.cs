using BusinessLayer;
using System;
using System.Activities;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayerHelper
{
    public class clsLeadData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();

        public void AddUpdate(clsLead obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Lead_AddUpdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@LeadId", obj.LeadId);
                    objCmd.Parameters.AddWithValue("@Lead", obj.Lead);
                    objCmd.Parameters.AddWithValue("@BatchTypeId", obj.BatchTypeId);
                    objCmd.Parameters.AddWithValue("@LeadSourceId", obj.LeadSourceId);
                    objCmd.Parameters.AddWithValue("@LeadCategoryId", obj.LeadCategoryId);
                    objCmd.Parameters.AddWithValue("@LeadStatusId", obj.LeadStatusId);
                    objCmd.Parameters.AddWithValue("@LeadDate", obj.LeadDate);
                    objCmd.Parameters.AddWithValue("@FollowUpDate", obj.FollowUpDate);
                    objCmd.Parameters.AddWithValue("@BranchId", obj.BranchId);
                    objCmd.Parameters.AddWithValue("@CourseId", obj.CourseId);
                    objCmd.Parameters.AddWithValue("@LocationId", obj.LocationId);
                    objCmd.Parameters.AddWithValue("@CommunicationTypeId", obj.CommunicationTypeId);
                    objCmd.Parameters.AddWithValue("@PrimaryMobile", obj.PrimaryMobile);
                    objCmd.Parameters.AddWithValue("@SecondaryMobile", obj.SecondaryMobile);
                    objCmd.Parameters.AddWithValue("@PrimaryEmail", obj.PrimaryEmail);
                    objCmd.Parameters.AddWithValue("@SecondaryEmail", obj.SecondaryEmail);
                    objCmd.Parameters.AddWithValue("@Phone", obj.Phone);
                    objCmd.Parameters.AddWithValue("@City", obj.City);
                    objCmd.Parameters.AddWithValue("@Address", obj.Address);
                    objCmd.Parameters.AddWithValue("@Comments", obj.Comments);
                    objCmd.Parameters.AddWithValue("@Remarks", obj.Remarks);
                    objCmd.Parameters.AddWithValue("@Qualification", obj.Qualification);
                    objCmd.Parameters.AddWithValue("@Experience", obj.Experience);
                    objCmd.Parameters.AddWithValue("@domain", obj.Domain);
                    objCmd.Parameters.AddWithValue("@BatchId", obj.BatchId);
                    objCmd.Parameters.AddWithValue("@Fee", obj.Fee);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    objCmd.Parameters.AddWithValue("@FromTime", obj.FromTime);
                    objCmd.Parameters.AddWithValue("@ToTime", obj.ToTime);
                    objCmd.Parameters.AddWithValue("@ReferFriendId", obj.ReferFriendId);
                    objCmd.Parameters.AddWithValue("@ProofPaymentPath", obj.ProofPaymentPath);
                    objCmd.Parameters.AddWithValue("@ReferAmount", obj.ReferAmount);
                    objCmd.Parameters.AddWithValue("@LeadOwner", obj.LeadOwner);


                    objCmd.Parameters.AddWithValue("@BetterPay", obj.BetterPay);
                    objCmd.Parameters.AddWithValue("@IJM", obj.IJM);
                    objCmd.Parameters.AddWithValue("@Certification", obj.Certification);
                    objCmd.Parameters.AddWithValue("@KnowledgeEnhancement", obj.KnowledgeEnhancement);
                    objCmd.Parameters.AddWithValue("@WantToShiftToIT", obj.WantToShiftToIT);
                    objCmd.Parameters.AddWithValue("@Marriage", obj.Marriage);
                    objCmd.Parameters.AddWithValue("@MoveToDifferentCity", obj.MoveToDifferentCity);
                    objCmd.Parameters.AddWithValue("@StableJob", obj.StableJob);
                    objCmd.Parameters.AddWithValue("@NoTensionJob", obj.NoTensionJob);
                    objCmd.Parameters.AddWithValue("@JobLess", obj.JobLess);
                    objCmd.Parameters.AddWithValue("@NoMoney", obj.NoMoney);
                    objCmd.Parameters.AddWithValue("@Presentlyworking", obj.Presentlyworking);
                    objCmd.Parameters.AddWithValue("@WeekendsAvailable", obj.WeekendsAvailable);
                    objCmd.Parameters.AddWithValue("@WeekDaysDailyOneHour", obj.WeekDaysDailyOneHour);
                    objCmd.Parameters.AddWithValue("@PutDownPapers", obj.PutDownPapers);
                    objCmd.Parameters.AddWithValue("@InThreeMonthsWantANewJob", obj.InThreeMonthsWantANewJob);
                    objCmd.Parameters.AddWithValue("@DontWantToKeepPseudoExperience", obj.DontWantToKeepPseudoExperience);
                    objCmd.Parameters.AddWithValue("@KeenToRetainPreviousExperience", obj.KeenToRetainPreviousExperience);
                    objCmd.Parameters.AddWithValue("@SlowLearner", obj.SlowLearner);
                    objCmd.Parameters.AddWithValue("@NewToThisSubjectBA", obj.NewToThisSubjectBA);
                    objCmd.Parameters.AddWithValue("@FriendsAdvise", obj.FriendsAdvise);
                    objCmd.Parameters.AddWithValue("@FamilyMemberGuidance", obj.FamilyMemberGuidance);
                    objCmd.Parameters.AddWithValue("@COEPDPreviousPlacements", obj.COEPDPreviousPlacements);
                    objCmd.Parameters.AddWithValue("@COEPDGoodReviews", obj.COEPDGoodReviews);
                    objCmd.Parameters.AddWithValue("@Fees", obj.Fees);
                    objCmd.Parameters.AddWithValue("@Discounts", obj.Discounts);
                    objCmd.Parameters.AddWithValue("@SelfSponsored", obj.SelfSponsored);
                    objCmd.Parameters.AddWithValue("@SponsoredByAFriendFamilyMember", obj.SponsoredByAFriendFamilyMember);
                    objCmd.Parameters.AddWithValue("@TimeSlotsAvailability", obj.TimeSlotsAvailability);
                    objCmd.Parameters.AddWithValue("@ClassroomPreferences", obj.ClassroomPreferences);
                    objCmd.Parameters.AddWithValue("@ConfidenceOfDoingThisCourseAndGettingAJob", obj.ConfidenceOfDoingThisCourseAndGettingAJob);
                    
                   



                    objCmd.ExecuteNonQuery();
                }
            }
        }

        public clsLead Load(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Lead_Get", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@LeadId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsLead objInfo = new clsLead();
                            objInfo.LeadId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.Lead = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.BatchTypeId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.LeadSourceId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.LeadCategoryId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[4]);
                            objInfo.LeadStatusId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[5]);
                            if (objDset.Tables[0].Rows[0].ItemArray[6] != DBNull.Value)/**/
                                objInfo.LeadDate = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[6]);
                            if (objDset.Tables[0].Rows[0].ItemArray[7] != DBNull.Value)/**/
                                objInfo.FollowUpDate = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[7]);
                            objInfo.BranchId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[8]);
                            objInfo.CourseId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[9]);
                            objInfo.LocationId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[10]);
                            objInfo.CommunicationTypeId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[11]);
                            objInfo.PrimaryMobile = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[12]);
                            objInfo.SecondaryMobile = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[13]);
                            objInfo.PrimaryEmail = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[14]);
                            objInfo.SecondaryEmail = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[15]);
                            objInfo.Phone = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[16]);
                            objInfo.City = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[17]);
                            objInfo.Address = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[18]);
                            objInfo.Comments = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[19]);
                            objInfo.Remarks = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[20]);
                            objInfo.Qualification = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[21]);
                            objInfo.Experience = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[22]);
                            objInfo.Domain = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[23]);
                            objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[24]);

                            objInfo.BatchId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[25]);
                            objInfo.Fee = Convert.ToDecimal(objDset.Tables[0].Rows[0].ItemArray[26]);
                           
                            objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[27]);
                            if (objDset.Tables[0].Rows[0].ItemArray[28] != DBNull.Value)
                                objInfo.FromTime = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[28]);
                            if (objDset.Tables[0].Rows[0].ItemArray[29] != DBNull.Value)
                                objInfo.ToTime = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[29]);
                            if (objDset.Tables[0].Rows[0].ItemArray[30] != DBNull.Value)
                                objInfo.ReferFriendId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[30]);
                            objInfo.ProofPaymentPath = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[31]);
                            objInfo.ReferAmount = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[32]);



                            if (objDset.Tables[0].Rows[0].ItemArray[33] != DBNull.Value)
                                objInfo.BetterPay = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[33]);
                            if (objDset.Tables[0].Rows[0].ItemArray[34] != DBNull.Value)
                                objInfo.IJM = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[34]);
                            if (objDset.Tables[0].Rows[0].ItemArray[35] != DBNull.Value)
                                objInfo.Certification = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[35]);
                            if (objDset.Tables[0].Rows[0].ItemArray[36] != DBNull.Value)
                                objInfo.KnowledgeEnhancement = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[36]);
                            if (objDset.Tables[0].Rows[0].ItemArray[37] != DBNull.Value)
                                objInfo.WantToShiftToIT = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[37]);
                            if (objDset.Tables[0].Rows[0].ItemArray[38] != DBNull.Value)
                                objInfo.Marriage = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[38]);
                            if (objDset.Tables[0].Rows[0].ItemArray[39] != DBNull.Value)
                                objInfo.MoveToDifferentCity = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[39]);
                            if (objDset.Tables[0].Rows[0].ItemArray[40] != DBNull.Value)
                                objInfo.StableJob = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[40]);
                            if (objDset.Tables[0].Rows[0].ItemArray[41] != DBNull.Value)
                                objInfo.NoTensionJob = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[41]);
                            if (objDset.Tables[0].Rows[0].ItemArray[42] != DBNull.Value)
                                objInfo.JobLess = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[42]);
                            if (objDset.Tables[0].Rows[0].ItemArray[43] != DBNull.Value)
                                objInfo.NoMoney = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[43]);
                            if (objDset.Tables[0].Rows[0].ItemArray[44] != DBNull.Value)
                                objInfo.Presentlyworking = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[44]);
                            if (objDset.Tables[0].Rows[0].ItemArray[45] != DBNull.Value)
                                objInfo.WeekendsAvailable = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[45]);
                            if (objDset.Tables[0].Rows[0].ItemArray[46] != DBNull.Value)
                                objInfo.WeekDaysDailyOneHour = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[46]);
                            if (objDset.Tables[0].Rows[0].ItemArray[47] != DBNull.Value)
                                objInfo.PutDownPapers = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[47]);
                            if (objDset.Tables[0].Rows[0].ItemArray[48] != DBNull.Value)
                                objInfo.InThreeMonthsWantANewJob = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[48]);
                            if (objDset.Tables[0].Rows[0].ItemArray[49] != DBNull.Value)
                                objInfo.DontWantToKeepPseudoExperience = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[49]);
                            if (objDset.Tables[0].Rows[0].ItemArray[50] != DBNull.Value)
                                objInfo.KeenToRetainPreviousExperience = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[50]);
                            if (objDset.Tables[0].Rows[0].ItemArray[51] != DBNull.Value)
                                objInfo.SlowLearner = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[51]);
                            if (objDset.Tables[0].Rows[0].ItemArray[52] != DBNull.Value)
                                objInfo.NewToThisSubjectBA = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[52]);
                            if (objDset.Tables[0].Rows[0].ItemArray[53] != DBNull.Value)
                                objInfo.FriendsAdvise = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[53]);
                            if (objDset.Tables[0].Rows[0].ItemArray[54] != DBNull.Value)
                                objInfo.FamilyMemberGuidance = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[54]);
                            if (objDset.Tables[0].Rows[0].ItemArray[55] != DBNull.Value)
                                objInfo.COEPDPreviousPlacements = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[55]);
                            if (objDset.Tables[0].Rows[0].ItemArray[56] != DBNull.Value)
                                objInfo.COEPDGoodReviews = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[56]);
                            if (objDset.Tables[0].Rows[0].ItemArray[57] != DBNull.Value)
                                objInfo.Fees = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[57]);
                            if (objDset.Tables[0].Rows[0].ItemArray[58] != DBNull.Value)
                                objInfo.Discounts = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[58]);
                            if (objDset.Tables[0].Rows[0].ItemArray[59] != DBNull.Value)
                                objInfo.SelfSponsored = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[59]);
                            if (objDset.Tables[0].Rows[0].ItemArray[60] != DBNull.Value)
                                objInfo.SponsoredByAFriendFamilyMember = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[60]);
                            if (objDset.Tables[0].Rows[0].ItemArray[61] != DBNull.Value)
                                objInfo.TimeSlotsAvailability = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[61]);
                            if (objDset.Tables[0].Rows[0].ItemArray[62] != DBNull.Value)
                                objInfo.ClassroomPreferences = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[62]);
                            if (objDset.Tables[0].Rows[0].ItemArray[63] != DBNull.Value)
                                objInfo.ConfidenceOfDoingThisCourseAndGettingAJob = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[63]);

                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }
        public List<clsLead> LoadAll(clsLead obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Lead_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@keywords", obj.keywords);
                    objCmd.Parameters.AddWithValue("@BatchTypeId", obj.BatchTypeId);
                    objCmd.Parameters.AddWithValue("@LeadSourceId", obj.LeadSourceId);
                    objCmd.Parameters.AddWithValue("@LeadCategoryId", obj.LeadCategoryId);
                    objCmd.Parameters.AddWithValue("@LeadStatusId", obj.LeadStatusId);
                    objCmd.Parameters.AddWithValue("@BranchId", obj.BranchId);
                    objCmd.Parameters.AddWithValue("@CourseId", obj.CourseId);
                    objCmd.Parameters.AddWithValue("@LocationId", obj.LocationId);
                    objCmd.Parameters.AddWithValue("@CommunicationTypeId", obj.CommunicationTypeId);
                    objCmd.Parameters.AddWithValue("@BatchId", obj.BatchId);
                    objCmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    objCmd.Parameters.AddWithValue("@AspirantName", obj.AspirantName);
                    objCmd.Parameters.AddWithValue("@PrimaryMobile", obj.PrimaryMobile);
                    objCmd.Parameters.AddWithValue("@PrimaryEmail", obj.PrimaryEmail);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);

                    //objCmd.Parameters.AddWithValue("@FromTime", obj.FromTime);
                    //objCmd.Parameters.AddWithValue("@ToTime", obj.ToTime);
                    //objCmd.Parameters.AddWithValue("@IsDemoAttended", obj.IsDemoAttended);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);

                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsLead> objList = new List<clsLead>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsLead objInfo = new clsLead();
                                objInfo.SNo = cnt + 1;
                                objInfo.LeadId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Lead = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.BatchType = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.LeadSource = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.LeadCategory = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.LeadStatus = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[6] != DBNull.Value)
                                    objInfo.LeadDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[7] != DBNull.Value)/**/
                                    objInfo.FollowUpDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.Branch = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.Course = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objInfo.Location = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                objInfo.CommunicationType = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[11]);
                                objInfo.PrimaryMobile = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[12]);
                                objInfo.SecondaryMobile = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[13]);
                                objInfo.PrimaryEmail = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[14]);
                                objInfo.SecondaryEmail = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[15]);
                                objInfo.Phone = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[16]);
                                objInfo.City = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[17]);
                                objInfo.Address = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[18]);
                                objInfo.Comments = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[19]);
                                objInfo.Remarks = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[20]);
                                objInfo.Qualification = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[21]);
                                objInfo.Experience = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[22]);
                                objInfo.Domain = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[23]);
                                objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[24]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[25] != DBNull.Value)/**/
                                    objInfo.BatchId = Convert.ToInt16(objDset.Tables[0].Rows[cnt].ItemArray[25]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[26] != DBNull.Value)/**/
                                    objInfo.BatchDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[26]);
                                objInfo.Fee = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[27]);
                                objInfo.Username = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[28]);
                                objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[29]);
                                objInfo.Participant = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[30]);
                                

                                //if (objDset.Tables[0].Rows[cnt].ItemArray[30] != DBNull.Value)/**/
                                    //objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[30]);
                                //if (objDset.Tables[0].Rows[cnt].ItemArray[31] != DBNull.Value)/**/
                                //    objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[31]);
                                //if (objDset.Tables[0].Rows[cnt].ItemArray[32] != DBNull.Value)/**/
                                //    objInfo.IsDemoAttended = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[32]);

                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }

        public List<clsLead> LoadAll_ServiceOwner(clsLead obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Lead_List_VerifyServieOwner", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@PrimaryEmail", obj.PrimaryEmail);
                    objCmd.Parameters.AddWithValue("@PrimaryMobile", obj.PrimaryMobile);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsLead> objList = new List<clsLead>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsLead objInfo = new clsLead();
                                objInfo.SNo = cnt + 1;
                                objInfo.LeadId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.PrimaryMobile = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.PrimaryEmail = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[3] != DBNull.Value)
                                    objInfo.CreatedBy = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[3]);

                                objInfo.Fullname = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.ServiceOwnerMobile = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.ServiceOwnerEmail = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[3] != DBNull.Value)
                                    objInfo.LocationId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.Location = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }

   
        public List<clsLead> LoadAllReport(clsLead obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Lead_List_Report", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@keywords", obj.keywords);
                    objCmd.Parameters.AddWithValue("@LeadStatusId", obj.LeadStatusId);
                    objCmd.Parameters.AddWithValue("@BatchTypeId", obj.BatchTypeId);
                    objCmd.Parameters.AddWithValue("@LeadSourceId", obj.LeadSourceId);
                    objCmd.Parameters.AddWithValue("@LeadCategoryId", obj.LeadCategoryId);
                    objCmd.Parameters.AddWithValue("@BranchId", obj.BranchId);
                    objCmd.Parameters.AddWithValue("@CourseId", obj.CourseId);
                    objCmd.Parameters.AddWithValue("@LocationId", obj.LocationId);
                    objCmd.Parameters.AddWithValue("@CommunicationTypeId", obj.CommunicationTypeId);
                    objCmd.Parameters.AddWithValue("@BatchId", obj.BatchId);
                    objCmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    objCmd.Parameters.AddWithValue("@EmployeeId", obj.EmployeeId);
                    objCmd.Parameters.AddWithValue("@FromDate", obj.FromDate);
                    objCmd.Parameters.AddWithValue("@ToDate", obj.ToDate);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);

                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsLead> objList = new List<clsLead>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsLead objInfo = new clsLead();
                                objInfo.SNo = cnt + 1;
                                objInfo.LeadId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Lead = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.BatchType = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.LeadSource = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.LeadCategory = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.LeadStatus = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.LeadDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.FollowUpDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.Branch = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.Course = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objInfo.Location = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                objInfo.CommunicationType = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[11]);
                                objInfo.PrimaryMobile = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[12]);
                                objInfo.SecondaryMobile = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[13]);
                                objInfo.PrimaryEmail = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[14]);
                                objInfo.SecondaryEmail = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[15]);
                                objInfo.Phone = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[16]);
                                objInfo.City = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[17]);
                                objInfo.Address = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[18]);
                                objInfo.Comments = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[19]);
                                objInfo.Remarks = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[20]);
                                objInfo.Qualification = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[21]);
                                objInfo.Experience = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[22]);
                                objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[23]);
                                objInfo.BatchId = Convert.ToInt16(objDset.Tables[0].Rows[cnt].ItemArray[24]);
                                objInfo.BatchDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[25]);
                                objInfo.Fee = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[26]);
                                objInfo.Username = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[27]);
                                objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[28]);
                                objInfo.Participant = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[29]);
                                objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[30]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }
        public List<clsLead> LoadAllRegistrationReport(clsLead obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Lead_List_Report_Registred", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@keywords", obj.keywords);
                    objCmd.Parameters.AddWithValue("@BatchTypeId", obj.BatchTypeId);
                    objCmd.Parameters.AddWithValue("@LeadSourceId", obj.LeadSourceId);
                    objCmd.Parameters.AddWithValue("@LeadCategoryId", obj.LeadCategoryId);
                    objCmd.Parameters.AddWithValue("@BranchId", obj.BranchId);
                    objCmd.Parameters.AddWithValue("@CourseId", obj.CourseId);
                    objCmd.Parameters.AddWithValue("@LocationId", obj.LocationId);
                    objCmd.Parameters.AddWithValue("@BatchId", obj.BatchId);
                    objCmd.Parameters.AddWithValue("@EmployeeId", obj.EmployeeId);
                    objCmd.Parameters.AddWithValue("@FromDate", obj.FromDate);
                    objCmd.Parameters.AddWithValue("@ToDate", obj.ToDate);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);

                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsLead> objList = new List<clsLead>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsLead objInfo = new clsLead();
                                objInfo.SNo = cnt + 1;
                                objInfo.LeadId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Lead = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.BatchType = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.LeadSource = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.LeadCategory = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.LeadStatus = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.LeadDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.FollowUpDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.Branch = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.Course = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objInfo.Location = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                objInfo.CommunicationType = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[11]);
                                objInfo.PrimaryMobile = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[12]);
                                objInfo.SecondaryMobile = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[13]);
                                objInfo.PrimaryEmail = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[14]);
                                objInfo.SecondaryEmail = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[15]);
                                objInfo.Phone = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[16]);
                                objInfo.City = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[17]);
                                objInfo.Address = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[18]);
                                objInfo.Comments = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[19]);
                                objInfo.Remarks = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[20]);
                                objInfo.Qualification = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[21]);
                                objInfo.Experience = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[22]);
                                objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[23]);
                                objInfo.BatchId = Convert.ToInt16(objDset.Tables[0].Rows[cnt].ItemArray[24]);
                                objInfo.BatchDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[25]);
                                objInfo.Fee = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[26]);
                                objInfo.Username = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[27]);
                                objInfo.Participant = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[28]);
                                objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[29]);
                                objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[32]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }
        public List<clsLead> LoadAllFollowups(clsLead obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Lead_List_Reminder", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@keywords", obj.keywords);
                    objCmd.Parameters.AddWithValue("@LocationId", obj.LocationId);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);

                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsLead> objList = new List<clsLead>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsLead objInfo = new clsLead();
                                objInfo.SNo = cnt + 1;
                                objInfo.LeadId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Lead = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.Location = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.PrimaryMobile = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.PrimaryEmail = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.BatchId = Convert.ToInt16(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.FollowUpDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[8] != DBNull.Value)
                                    objInfo.FromTime = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[9] != DBNull.Value)
                                    objInfo.ToTime = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objInfo.Username = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }
        public List<clsLead> LoadAllMultiple(clsLead obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Lead_ListMultiple", objConn))
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
                            List<clsLead> objList = new List<clsLead>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsLead objInfo = new clsLead();
                                objInfo.SNo = cnt + 1;
                                objInfo.LeadId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Lead = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.BatchType = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.LeadSource = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.LeadCategory = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.LeadStatus = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.LeadDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.FollowUpDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.Branch = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.Course = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objInfo.Location = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                objInfo.CommunicationType = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[11]);
                                objInfo.PrimaryMobile = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[12]);
                                objInfo.SecondaryMobile = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[13]);
                                objInfo.PrimaryEmail = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[14]);
                                objInfo.SecondaryEmail = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[15]);
                                objInfo.Phone = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[16]);
                                objInfo.City = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[17]);
                                objInfo.Address = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[18]);
                                objInfo.Comments = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[19]);
                                objInfo.Remarks = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[20]);
                                objInfo.Qualification = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[21]);
                                objInfo.Experience = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[22]);
                                objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[23]);
                                objInfo.BatchId = Convert.ToInt16(objDset.Tables[0].Rows[cnt].ItemArray[24]);
                                objInfo.BatchDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[25]);
                                objInfo.Fee = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[26]);
                                objInfo.Username = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[27]);
                                objInfo.Participant = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[28]);
                                objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[29]);
                                //objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[30]);
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
                using (SqlCommand objCmd = new SqlCommand("Lead_Remove", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@LeadId", Id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }



        public List<clsLead> LoadforAll(clsLead obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("AllLead_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@keywords", obj.keywords);
                    objCmd.Parameters.AddWithValue("@BatchTypeId", obj.BatchTypeId);
                    objCmd.Parameters.AddWithValue("@LeadSourceId", obj.LeadSourceId);
                    objCmd.Parameters.AddWithValue("@LeadCategoryId", obj.LeadCategoryId);
                    objCmd.Parameters.AddWithValue("@LeadStatusId", obj.LeadStatusId);
                    objCmd.Parameters.AddWithValue("@BranchId", obj.BranchId);
                    objCmd.Parameters.AddWithValue("@CourseId", obj.CourseId);
                    objCmd.Parameters.AddWithValue("@LocationId", obj.LocationId);
                    objCmd.Parameters.AddWithValue("@CommunicationTypeId", obj.CommunicationTypeId);
                    objCmd.Parameters.AddWithValue("@BatchId ", obj.BatchId);
                    objCmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    objCmd.Parameters.AddWithValue("@AspirantName", obj.AspirantName);
                    objCmd.Parameters.AddWithValue("@PrimaryMobile ", obj.PrimaryMobile);
                    objCmd.Parameters.AddWithValue("@PrimaryEmail", obj.PrimaryEmail);
                 
               
	
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);

                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsLead> objList = new List<clsLead>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsLead objInfo = new clsLead();
                                objInfo.SNo = cnt + 1;
                                objInfo.LeadId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Lead = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.BatchType = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.LeadSource = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.LeadCategory = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.LeadStatus = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[6] != DBNull.Value)
                                    objInfo.LeadDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[7] != DBNull.Value)/**/
                                    objInfo.FollowUpDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.Branch = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.Course = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objInfo.Location = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                objInfo.CommunicationType = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[11]);
                                objInfo.PrimaryMobile = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[12]);
                                objInfo.SecondaryMobile = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[13]);
                                objInfo.PrimaryEmail = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[14]);
                                objInfo.SecondaryEmail = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[15]);
                                objInfo.Phone = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[16]);
                                objInfo.City = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[17]);
                                objInfo.Address = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[18]);
                                objInfo.Comments = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[19]);
                                objInfo.Remarks = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[20]);
                                objInfo.Qualification = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[21]);
                                objInfo.Experience = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[22]);
                                objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[23]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[24] != DBNull.Value)/**/
                                    objInfo.BatchId = Convert.ToInt16(objDset.Tables[0].Rows[cnt].ItemArray[24]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[25] != DBNull.Value)/**/
                                    objInfo.BatchDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[25]);
                                objInfo.Fee = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[26]);
                                objInfo.Username = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[27]);
                                objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[28]);
                                objInfo.Participant = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[29]);

                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }

        public int LoadLeadMobileValidation(clsLead obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("LeadMobile_Validation", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@PrimaryMobile", obj.PrimaryMobile);


                    int count = Convert.ToInt16(objCmd.ExecuteScalar());
                    return count;
                }
            }
        }


        public int LoadLeadEmailValidation(clsLead obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("LeadEmail_Validation", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@PrimaryEmail", obj.PrimaryEmail);
                    int count = Convert.ToInt16(objCmd.ExecuteScalar());
                    return count;
                }
            }
        }



    }
}




