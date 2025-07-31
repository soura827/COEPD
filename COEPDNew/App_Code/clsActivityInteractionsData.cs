using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace DataAccessLayerHelper
{
    public class clsActivityInteractionsData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs"].ToString();
        public void AddUpdate(clsActivityInteractions obj)
        {
            using (SqlConnection objconn = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("ActivityInteractions_AddUpdate", objconn))
                {
                    objconn.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@ActivityInteractionsId", obj.ActivityInteractionsId);
                    objcmd.Parameters.AddWithValue("@ActivityInstanceId", obj.ActivityInstanceId);
                    //objcmd.Parameters.AddWithValue("@EmployeeId", obj.EmployeeId);
                    //objcmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    objcmd.Parameters.AddWithValue("@ActivityInteractionInputs", obj.ActivityInteractionInputs);
                    //objcmd.Parameters.AddWithValue("@DateToWorkOn", obj.DateToWorkOn); 
                    //objcmd.Parameters.AddWithValue("@Description", obj.Description);
                    objcmd.Parameters.AddWithValue("@SystemStartTime", obj.SystemStartTime);
                    objcmd.Parameters.AddWithValue("@SystemEndTime", obj.SystemEndTime);
                    objcmd.Parameters.AddWithValue("@EnteredStartTime", obj.EnteredStartTime);
                    objcmd.Parameters.AddWithValue("@EnteredEndTime", obj.EnteredEndTime);
                    objcmd.Parameters.AddWithValue("@Date", obj.Date);
                    objcmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objcmd.ExecuteNonQuery();
                }
            }
        }
        public clsActivityInteractions Load(int Id)
        {
            using (SqlConnection objconn = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("ActivityInteractions_Get", objconn))
                {
                    objconn.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@ActivityInteractionsId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objcmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsActivityInteractions objInfo = new clsActivityInteractions();
                            objInfo.ActivityInteractionsId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.ActivityInstanceId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[1]);
                            //objInfo.EmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[2]);
                            //objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[3]);  
                            objInfo.ActivityInteractionInputs = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[2]);
                            //objInfo.StartDate = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[5]);
                            //objInfo.EndDate = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[6]);
                            //objInfo.StartTime = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[7]);
                            //objInfo.EndTime = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[8]);
                            objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.CreatedBy = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[4]);
                            if (objDset.Tables[0].Rows[0].ItemArray[5] != DBNull.Value)
                                objInfo.ModifiedOn = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[5]);
                            if (objDset.Tables[0].Rows[0].ItemArray[6] != DBNull.Value)
                                objInfo.ModifiedBy = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[6]);
                            objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[7]);
                            //if (objDset.Tables[0].Rows[0].ItemArray[8] != DBNull.Value)
                            //    objInfo.DateToWorkOn = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[8]);                               
                            //objInfo.Description = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[9]);
                            objInfo.Activity = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[8]);
                            objInfo.ActivityCategory = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[9]);
                            objInfo.ActivitySubcategory = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[10]);
                            return objInfo;
                        }
                    }
                    return null;
                }

            }
        }
        //public clsActivityInteractions LoadActivityInstanceId(int Id)
        //{
        //    using (SqlConnection objconn = new SqlConnection(Constr))
        //    {
        //        using (SqlCommand objcmd = new SqlCommand("ActivityInteractions_GetInstanceId", objconn))
        //        {
        //            objconn.Open();
        //            objcmd.CommandType = CommandType.StoredProcedure;
        //            objcmd.Parameters.AddWithValue("@ActivityInstanceId", Id);
        //            DataSet objDset = new DataSet();
        //            SqlDataAdapter objAdp = new SqlDataAdapter(objcmd);
        //            objAdp.Fill(objDset);
        //            if (objDset.Tables.Count > 0)
        //            {
        //                if (objDset.Tables[0].Rows.Count > 0)
        //                {
        //                    clsActivityInteractions objInfo = new clsActivityInteractions();
        //                    objInfo.ActivityInteractionsId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
        //                    objInfo.ActivityInstanceId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[1]);
        //                    //objInfo.EmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[2]);
        //                    //objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[3]);  
        //                    objInfo.ActivityInteractionInputs = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[2]);
        //                    //objInfo.StartDate = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[5]);
        //                    //objInfo.EndDate = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[6]);
        //                    //objInfo.StartTime = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[7]);
        //                    //objInfo.EndTime = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[8]);
        //                    objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[3]);
        //                    objInfo.CreatedBy = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[4]);
        //                    if (objDset.Tables[0].Rows[0].ItemArray[5] != DBNull.Value)
        //                        objInfo.ModifiedOn = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[5]);
        //                    if (objDset.Tables[0].Rows[0].ItemArray[6] != DBNull.Value)
        //                        objInfo.ModifiedBy = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[6]);
        //                    objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[7]);
        //                    objInfo.DateToWorkOn = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[8]);
        //                    objInfo.Description = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[9]);
        //                    return objInfo;
        //                }
        //            }
        //            return null;
        //        }

        //    }
        //}
        public List<clsActivityInteractions> LoadAll(clsActivityInteractions obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("ActivityInteractions_List", objConn))
                {
                    objConn.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@keywords", obj.Keywords);
                    objcmd.Parameters.AddWithValue("@EmployeeId", obj.EmployeeId);
                    objcmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    objcmd.Parameters.AddWithValue("@ActivityInstanceId", obj.ActivityInstanceId);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objcmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsActivityInteractions> objList = new List<clsActivityInteractions>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsActivityInteractions objInfo = new clsActivityInteractions();
                                objInfo.SNo = cnt + 1;
                                objInfo.ActivityInteractionsId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.ActivityInstanceId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                //objInfo.EmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                //objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.ActivityInteractionInputs = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                //objInfo.StartDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                //objInfo.EndDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                //objInfo.StartTime = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                //objInfo.EndTime = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.CreatedBy = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[5] != DBNull.Value)
                                    objInfo.ModifiedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[6] != DBNull.Value)
                                    objInfo.ModifiedBy = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                //objInfo.Activity = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                //objInfo.ActivityCategory = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                //objInfo.ActivitySubcategory = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                //objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[11]);
                                //objInfo.Participant = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[12]);
                                objInfo.Fullname = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.ModifiedName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                //if(objDset.Tables[0].Rows[cnt].ItemArray[15] != DBNull.Value)
                                //    objInfo.DateToWorkOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[15]);                          
                                //objInfo.Description = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[16]);
                                //objInfo.Location = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[21]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }

                    }
                    return null;
                }
            }
        }
        public List<clsActivityInteractions> LoadAllTasks(clsActivityInteractions obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ActivityInteractions_ListByTasks", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@Activity", obj.Activity);
                    objCmd.Parameters.AddWithValue("@ActivityCategory", obj.ActivityCategory);
                    objCmd.Parameters.AddWithValue("@ActivitySubCategory", obj.ActivitySubcategory);
                    objCmd.Parameters.AddWithValue("@InputsEnteredBy", obj.InputsEnteredBy);
                    objCmd.Parameters.AddWithValue("@InvolvedEmployees", obj.InvolvedEmployees);
                    objCmd.Parameters.AddWithValue("@InvolvedParticipants", obj.InvolvedParticipants);
                    objCmd.Parameters.AddWithValue("@InvolvedLeads", obj.InvolvedLeads);
                    objCmd.Parameters.AddWithValue("@InvolvedVendros", obj.InvolvedVendros);
                    //objCmd.Parameters.AddWithValue("@Participant", obj.Participant);
                    //objCmd.Parameters.AddWithValue("@Lead", obj.Lead);
                    //objCmd.Parameters.AddWithValue("@Vendor", obj.Vendor);
                    objCmd.Parameters.AddWithValue("@Branch", obj.Branch);
                    objCmd.Parameters.AddWithValue("@FromDate", obj.FromDate);
                    objCmd.Parameters.AddWithValue("@ToDate", obj.ToDate);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsActivityInteractions> objList = new List<clsActivityInteractions>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsActivityInteractions objInfo = new clsActivityInteractions();
                                objInfo.SNo = cnt + 1;
                                objInfo.ActivityInstanceId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.ActivityCategoryId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.ActivitySubCategoryId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.ActivityId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.NoOfEmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.NoOfParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.NoOfLeads = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.NoOfVendors = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.CreatedBy = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[10] != DBNull.Value)
                                    objInfo.ModifiedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[11] != DBNull.Value)
                                    objInfo.ModifiedBy = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[11]);
                                objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[12]);
                                objInfo.Activity = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[13]);
                                objInfo.ActivityCategory = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[14]);
                                objInfo.ActivitySubcategory = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[15]);
                                objInfo.Fullname = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[16]);
                                objInfo.ModifiedName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[17]);
                                objInfo.DateToWorkOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[18]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[19] != DBNull.Value)
                                    objInfo.FollowUpId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[19]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[20] != DBNull.Value)
                                    objInfo.Status = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[20]);
                                //if (objDset.Tables[0].Rows[cnt].ItemArray[21] != DBNull.Value)
                                //    objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[21]);
                                //if (objDset.Tables[0].Rows[cnt].ItemArray[22] != DBNull.Value)
                                //    objInfo.Participant = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[22]);
                                //if (objDset.Tables[0].Rows[cnt].ItemArray[23] != DBNull.Value)
                                //    objInfo.Lead = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[23]);
                                //if (objDset.Tables[0].Rows[cnt].ItemArray[24] != DBNull.Value)
                                //    objInfo.Vendor = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[24]);
                                objInfo.ActivityInteractionInputs = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[21]);
                                objInfo.BranchId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[22]);
                                objInfo.Branch = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[23]);
                                objInfo.InvolvedEmployees = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[24]);
                                objInfo.InvolvedParticipants = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[25]);
                                objInfo.InvolvedLeads = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[26]);
                                objInfo.InvolvedVendros = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[27]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[28] != DBNull.Value)
                                    objInfo.SystemMinutes = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[28]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[29] != DBNull.Value)
                                    objInfo.EnteredMinutes = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[29]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[30] != DBNull.Value)
                                    objInfo.SystemStartTime = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[30]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[31] != DBNull.Value)
                                    objInfo.SystemEndTime = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[31]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[32] != DBNull.Value)
                                    objInfo.EnteredStartTime = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[32]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[33] != DBNull.Value)
                                    objInfo.EnteredEndTime = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[33]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }
        public List<clsActivityInteractions> LoadAllParticipantInteractions(clsActivityInteractions obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ActivityParticipantInteractions_ListByTasks", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@Activity", obj.Activity);
                    objCmd.Parameters.AddWithValue("@ActivityCategory", obj.ActivityCategory);
                    objCmd.Parameters.AddWithValue("@ActivitySubCategory", obj.ActivitySubcategory);
                    objCmd.Parameters.AddWithValue("@InputsEnteredBy", obj.InputsEnteredBy);
                    objCmd.Parameters.AddWithValue("@InvolvedEmployees", obj.InvolvedEmployees);
                    objCmd.Parameters.AddWithValue("@InvolvedParticipants", obj.InvolvedParticipants);
                    objCmd.Parameters.AddWithValue("@Branch", obj.Branch);
                    objCmd.Parameters.AddWithValue("@FromDate", obj.FromDate);
                    objCmd.Parameters.AddWithValue("@ToDate", obj.ToDate);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsActivityInteractions> objList = new List<clsActivityInteractions>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsActivityInteractions objInfo = new clsActivityInteractions();
                                objInfo.SNo = cnt + 1;
                                objInfo.ActivityInstanceId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.ActivityCategoryId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.ActivitySubCategoryId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.ActivityId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.NoOfEmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.NoOfParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.CreatedBy = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[8] != DBNull.Value)
                                    objInfo.ModifiedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[9] != DBNull.Value)
                                    objInfo.ModifiedBy = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                objInfo.Activity = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[11]);
                                objInfo.ActivityCategory = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[12]);
                                objInfo.ActivitySubcategory = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[13]);
                                objInfo.Fullname = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[14]);
                                objInfo.ModifiedName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[15]);
                                objInfo.DateToWorkOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[16]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[17] != DBNull.Value)
                                    objInfo.FollowUpId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[17]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[18] != DBNull.Value)
                                    objInfo.Status = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[18]);
                                objInfo.ActivityInteractionInputs = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[19]);
                                objInfo.BranchId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[20]);
                                objInfo.Branch = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[21]);
                                objInfo.InvolvedEmployees = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[22]);
                                objInfo.InvolvedParticipants = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[23]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[24] != DBNull.Value)
                                    objInfo.SystemMinutes = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[24]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[25] != DBNull.Value)
                                    objInfo.EnteredMinutes = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[25]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[26] != DBNull.Value)
                                    objInfo.SystemStartTime = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[26]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[27] != DBNull.Value)
                                    objInfo.SystemEndTime = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[27]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[28] != DBNull.Value)
                                    objInfo.EnteredStartTime = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[28]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[29] != DBNull.Value)
                                    objInfo.EnteredEndTime = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[29]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[30] != DBNull.Value)
                                    objInfo.InvolvedVendros = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[30]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[31] != DBNull.Value)
                                    objInfo.Description = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[31]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }
        public List<clsActivityInteractions> LoadDailyReportByEmployee(clsActivityInteractions obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ActivityInteractions_DailyReportByEmployee", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@Date", obj.Date);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsActivityInteractions> objList = new List<clsActivityInteractions>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsActivityInteractions objInfo = new clsActivityInteractions();
                                objInfo.SNo = cnt + 1;
                                objInfo.ActivityInstanceId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.ActivityCategoryId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.ActivitySubCategoryId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.ActivityId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.CreatedBy = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.Activity = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.ActivityCategory = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.ActivitySubcategory = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.Fullname = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objInfo.DateToWorkOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[11] != DBNull.Value)
                                    objInfo.Status = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[11]);
                                objInfo.ActivityInteractionInputs = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[12]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[13] != DBNull.Value)
                                    objInfo.SystemStartTime = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[13]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[14] != DBNull.Value)
                                    objInfo.SystemEndTime = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[14]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[15] != DBNull.Value)
                                    objInfo.SystemMinutes = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[15]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[16] != DBNull.Value)
                                    objInfo.EnteredStartTime = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[16]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[17] != DBNull.Value)
                                    objInfo.EnteredEndTime = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[17]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[18] != DBNull.Value)
                                    objInfo.EnteredMinutes = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[18]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[19] != DBNull.Value)
                                    objInfo.Date = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[19]);
                                objInfo.Description = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[20]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }

        public List<string> LoadDailySummaryByEmployee(clsActivityInteractions obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ActivityInteractions_DailySummaryByEmployee", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@Date", obj.Date);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            //List<clsActivityInteractions> objList = new List<clsActivityInteractions>();

                            List<string> summary = new List<string>();
                            string summaryDetails = "";

                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                for (int col = 0; col < objDset.Tables[0].Columns.Count; col++)
                                {
                                    summaryDetails = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[col]);
                                    summary.Add(summaryDetails);
                                }
                            }

                            return summary;

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
                using (SqlCommand objCmd = new SqlCommand("ActivityInteractions_Remove", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ActivityInteractionsId", Id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }
    }
}
