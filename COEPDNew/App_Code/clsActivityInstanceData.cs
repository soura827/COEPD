using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace DataAccessLayerHelper
{
    public class clsActivityInstanceData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();
        //This method is used to Add and Update  ActivityInstance From ActivityInstance_AddUpdate StoredProcedure
        public void AddUpdate(clsActivityInstance obj)
        {
            using (SqlConnection objconn = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("ActivityInstance_AddUpdate", objconn))
                {
                    objconn.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@ActivityInstanceId", obj.ActivityInstanceId);
                    objcmd.Parameters.AddWithValue("@ActivityCategoryId", obj.ActivityCategoryId);
                    objcmd.Parameters.AddWithValue("@ActivitySubCategoryId", obj.ActivitySubCategoryId);
                    objcmd.Parameters.AddWithValue("@ActivityId", obj.ActivityId);
                    objcmd.Parameters.AddWithValue("@NoOfEmployeeId", obj.NoOfEmployeeId);
                    objcmd.Parameters.AddWithValue("@InvolvedEmployees", obj.InvolvedEmployees);
                    objcmd.Parameters.AddWithValue("@EmployeesPhoneNumbers", obj.EmployeesPhoneNumbers);
                    objcmd.Parameters.AddWithValue("@NoOfParticipantId", obj.NoOfParticipantId);
                    objcmd.Parameters.AddWithValue("@InvolvedParticipants", obj.InvolvedParticipants);
                    objcmd.Parameters.AddWithValue("@ParticipantsPhoneNumbers", obj.ParticipantsPhoneNumbers);
                    objcmd.Parameters.AddWithValue("@NoOfLeads", obj.NoOfLeads);
                    objcmd.Parameters.AddWithValue("@InvolvedLeads", obj.InvolvedLeads);
                    objcmd.Parameters.AddWithValue("@LeadsPhoneNumbers", obj.LeadsPhoneNumbers);
                    objcmd.Parameters.AddWithValue("@NoOfVendors", obj.NoOfVendors);
                    objcmd.Parameters.AddWithValue("@InvolvedVendors", obj.InvolvedVendors);
                    objcmd.Parameters.AddWithValue("@VendorsPhoneNumbers", obj.VendorsPhoneNumbers);
                    //objcmd.Parameters.AddWithValue("@LocationId", obj.LocationId);
                    objcmd.Parameters.AddWithValue("@UniqueId", obj.UniqueId);
                    objcmd.Parameters.AddWithValue("@Description", obj.Description);
                    objcmd.Parameters.AddWithValue("@DateToWorkOn", obj.DateToWorkOn);
                    objcmd.Parameters.AddWithValue("@FollowUpId", obj.FollowUpId);
                    objcmd.Parameters.AddWithValue("@Status", obj.Status);
                    objcmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objcmd.Parameters.AddWithValue("@JobDescription", obj.JobDescription);
                    objcmd.ExecuteNonQuery();
                }
            }
        }
        //This method is used to get Selected  ActivityInstance record  From ActivityInstance_Get StoredProcedure
        public clsActivityInstance Load(int id)
        {
            using (SqlConnection objconn = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("ActivityInstance_Get", objconn))
                {
                    objconn.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@ActivityInstanceId", id);

                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objcmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsActivityInstance objInfo = new clsActivityInstance();
                            objInfo.ActivityInstanceId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.ActivityCategoryId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.ActivitySubCategoryId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.ActivityId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.NoOfEmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[4]);
                            objInfo.NoOfParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[5]);
                            objInfo.NoOfLeads = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[6]);
                            objInfo.NoOfVendors = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[7]);
                            objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[8]);
                            objInfo.CreatedBy = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[9]);
                            if (objDset.Tables[0].Rows[0].ItemArray[10] != DBNull.Value)
                                objInfo.ModifiedOn = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[10]);
                            if (objDset.Tables[0].Rows[0].ItemArray[11] != DBNull.Value)
                                objInfo.ModifiedBy = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[11]);
                            objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[12]);
                            objInfo.Description = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[13]);
                            if (objDset.Tables[0].Rows[0].ItemArray[14] != DBNull.Value)
                                objInfo.DateToWorkOn = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[14]);
                            if (objDset.Tables[0].Rows[0].ItemArray[15] != DBNull.Value)
                                objInfo.FollowUpId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[15]);
                            if (objDset.Tables[0].Rows[0].ItemArray[16] != DBNull.Value)
                                objInfo.Status = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[16]);
                            objInfo.UniqueId = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[17]);
                            objInfo.ActivityCategory = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[18]);
                            objInfo.ActivitySubcategory = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[19]);
                            objInfo.Activity = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[20]);
                            objInfo.InvolvedEmployees = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[21]);
                            objInfo.InvolvedParticipants = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[22]);
                            objInfo.InvolvedLeads = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[23]);
                            objInfo.InvolvedVendors = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[24]);
                            if (objDset.Tables[0].Rows[0].ItemArray[25] != DBNull.Value)
                                objInfo.ParticipantsPhoneNumbers = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[25]);
                            if (objDset.Tables[0].Rows[0].ItemArray[26] != DBNull.Value)
                                objInfo.LeadsPhoneNumbers = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[26]);
                            if (objDset.Tables[0].Rows[0].ItemArray[27] != DBNull.Value)
                                objInfo.VendorsPhoneNumbers = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[27]);
                            if (objDset.Tables[0].Rows[0].ItemArray[28] != DBNull.Value)
                                objInfo.EmployeesPhoneNumbers = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[28]);
                            return objInfo;
                        }
                    }
                    return null;
                }

            }

        }

        public clsActivityInstance LoadUniqueId(string id)
        {
            using (SqlConnection objconn = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("ActivityInstance_GetUniqueId", objconn))
                {
                    objconn.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@UniqueId", id);

                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objcmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsActivityInstance objInfo = new clsActivityInstance();
                            objInfo.ActivityInstanceId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.ActivityCategoryId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.ActivitySubCategoryId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.ActivityId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.NoOfEmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[4]);
                            objInfo.NoOfParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[5]);

                            objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[6]);
                            objInfo.CreatedBy = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[7]);
                            if (objDset.Tables[0].Rows[0].ItemArray[8] != DBNull.Value)
                                objInfo.ModifiedOn = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[8]);
                            if (objDset.Tables[0].Rows[0].ItemArray[9] != DBNull.Value)
                                objInfo.ModifiedBy = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[9]);
                            objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[10]);
                            //objInfo.LocationId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[11]);
                            objInfo.UniqueId = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[11]);
                            objInfo.Description = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[12]);
                            if (objDset.Tables[0].Rows[0].ItemArray[13] != DBNull.Value)
                                objInfo.DateToWorkOn = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[13]);
                            if (objDset.Tables[0].Rows[0].ItemArray[14] != DBNull.Value)
                                objInfo.FollowUpId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[14]);
                            if (objDset.Tables[0].Rows[0].ItemArray[15] != DBNull.Value)
                                objInfo.Status = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[15]);
                            return objInfo;
                        }
                    }
                    return null;
                }

            }
        }
        //This method is used to get All  ActivityInstance records  From ActivityInstance_List StoredProcedure
        public List<clsActivityInstance> LoadAll(clsActivityInstance obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("ActivityInstance_List", objConn))
                {
                    objConn.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@Keywords", obj.Keywords);
                    objcmd.Parameters.AddWithValue("@EmployeeId", obj.EmployeeId);
                    objcmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    objcmd.Parameters.AddWithValue("@ActivityCategory", obj.ActivityCategory);
                    objcmd.Parameters.AddWithValue("@ActivitySubCategory", obj.ActivitySubcategory);
                    objcmd.Parameters.AddWithValue("@Activity", obj.Activity);
                    objcmd.Parameters.AddWithValue("@Fullname", obj.Fullname);
                    objcmd.Parameters.AddWithValue("@InvolvedEmployees", obj.InvolvedEmployees);
                    objcmd.Parameters.AddWithValue("@InvolvedParticipants", obj.InvolvedParticipants);
                    objcmd.Parameters.AddWithValue("@ParticipantsPhoneNumbers", obj.ParticipantsPhoneNumbers);
                    objcmd.Parameters.AddWithValue("@InvolvedLeads", obj.InvolvedLeads);
                    objcmd.Parameters.AddWithValue("@LeadsPhoneNumbers", obj.LeadsPhoneNumbers);
                    objcmd.Parameters.AddWithValue("@InvolvedVendros", obj.InvolvedVendors);
                    objcmd.Parameters.AddWithValue("@Status", obj.Status);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objcmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsActivityInstance> objList = new List<clsActivityInstance>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsActivityInstance objInfo = new clsActivityInstance();
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
                                //objInfo.LocationId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[11]);
                                objInfo.Activity = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[13]);
                                objInfo.ActivityCategory = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[14]);
                                objInfo.ActivitySubcategory = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[15]);
                                //objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[15]);
                                //objInfo.Participant = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[16]);
                                objInfo.Fullname = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[16]);
                                objInfo.ModifiedName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[17]);
                                objInfo.Description = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[18]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[19] != DBNull.Value)
                                    objInfo.DateToWorkOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[19]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[20] != DBNull.Value)
                                    objInfo.FollowUpId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[20]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[21] != DBNull.Value)
                                    objInfo.Status = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[21]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[22] != DBNull.Value)
                                    objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[22]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[23] != DBNull.Value)
                                    objInfo.Participant = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[23]);
                                objInfo.InvolvedEmployees = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[24]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[25] != DBNull.Value)
                                    objInfo.InvolvedParticipants = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[25]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[26] != DBNull.Value)
                                    objInfo.InvolvedLeads = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[26]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[27] != DBNull.Value)
                                    objInfo.InvolvedVendors = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[27]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[28] != DBNull.Value)
                                    objInfo.ParticipantsPhoneNumbers = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[28]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[29] != DBNull.Value)
                                    objInfo.LeadsPhoneNumbers = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[29]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[30] != DBNull.Value)
                                    objInfo.VendorsPhoneNumbers = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[30]);
                                objInfo.JobDescription = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[31]);

                                objList.Add(objInfo);
                            }
                            return objList;
                        }

                    }
                    return null;
                }
            }
        }
        //This method is used to Remove to validate  ActivityInstance  From ActivityInstance_Remove StoredProcedure
        public void Remove(int id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ActivityInstance_Remove", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ActivityCategoryId", id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }
    }
}
