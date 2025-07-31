using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayerHelper
{
    public class clsEmployeeData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();

        public void AddUpdate(clsEmployee obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Employee_AddUpdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@EmployeeId", obj.EmployeeId);
                    objCmd.Parameters.AddWithValue("@Employee", obj.Employee);
                    objCmd.Parameters.AddWithValue("@Code", obj.Code);
                    objCmd.Parameters.AddWithValue("@LocationId", obj.LocationId);
                    objCmd.Parameters.AddWithValue("@BranchId", obj.BranchId);
                    objCmd.Parameters.AddWithValue("@DesignationId", obj.DesignationId);
                    objCmd.Parameters.AddWithValue("@Email", obj.Email);
                    objCmd.Parameters.AddWithValue("@OfficeEmail", obj.OfficeEmail);
                    objCmd.Parameters.AddWithValue("@Mobile", obj.Mobile);
                    objCmd.Parameters.AddWithValue("@CUGMobile", obj.CUGMobile);
                    objCmd.Parameters.AddWithValue("@Phone", obj.Phone);
                    objCmd.Parameters.AddWithValue("@Summary", obj.Summary);
                    objCmd.Parameters.AddWithValue("@Remarks", obj.Remarks);
                    objCmd.Parameters.AddWithValue("@Salary", obj.Salary);
                    objCmd.Parameters.AddWithValue("@Address", obj.Address);
                    objCmd.Parameters.AddWithValue("@City", obj.City);
                    objCmd.Parameters.AddWithValue("@State", obj.State);
                    objCmd.Parameters.AddWithValue("@Zip", obj.Zip);
                    objCmd.Parameters.AddWithValue("@JoinDate", obj.JoinDate);
                    objCmd.Parameters.AddWithValue("@EmergencyContact", obj.EmergencyContact);
                    objCmd.Parameters.AddWithValue("@EmergencyPhone", obj.EmergencyPhone);
                    objCmd.Parameters.AddWithValue("@IsLeadPermit", obj.IsLeadPermit);
                    objCmd.Parameters.AddWithValue("@DepartmentId", obj.DepartmentId);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.Parameters.AddWithValue("@IsActive", obj.IsActive);
                    objCmd.Parameters.AddWithValue("@Roles", obj.Roles);
                    objCmd.Parameters.AddWithValue("@NurturePermit", obj.NurturePermit);
                    objCmd.Parameters.AddWithValue("@ResumePath", obj.ResumePath);
                    objCmd.Parameters.AddWithValue("@PhonePayNumber", obj.PhonePayNumber);
                    objCmd.Parameters.AddWithValue("@GooglePayNumber", obj.GooglePayNumber);
                    objCmd.Parameters.AddWithValue("@PaytmNumber", obj.PaytmNumber);
                    objCmd.Parameters.AddWithValue("@AccountHolderName", obj.AccountHolderName);
                    objCmd.Parameters.AddWithValue("@BankAccountNumber", obj.BankAccountNumber);
                    objCmd.Parameters.AddWithValue("@IFSCCode", obj.IFSCCode);
                    objCmd.Parameters.AddWithValue("@BankName", obj.BankName);
                    objCmd.Parameters.AddWithValue("@BranchName", obj.BranchName);
                    objCmd.Parameters.AddWithValue("@PassbookFilePath", obj.PassbookFilePath);
                    objCmd.Parameters.AddWithValue("@PancardFilePath", obj.PancardFilePath);
                    objCmd.Parameters.AddWithValue("@AadharFrontFilePath", obj.AadharFrontFilePath);
                    objCmd.Parameters.AddWithValue("@AadharBackFilePath", obj.AadharBackFilePath);
                    objCmd.Parameters.AddWithValue("@IsTrainer", obj.IsTrainer);
                    objCmd.Parameters.AddWithValue("@IsProcess", obj.IsProcess);
                    objCmd.Parameters.AddWithValue("@IsMentor", obj.IsMentor);
                    objCmd.Parameters.AddWithValue("@IsDiscounter", obj.IsDiscounter);
                    objCmd.Parameters.AddWithValue("@IsReportingManager", obj.IsReportingManager);
                    objCmd.Parameters.AddWithValue("@IsAssociate", obj.IsAssociate);
                    objCmd.Parameters.AddWithValue("@IsVerticalHead", obj.IsVerticalHead);
                    objCmd.ExecuteNonQuery();
                }
            }
        }


        public clsEmployee Load(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Employee_Get", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@EmployeeId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsEmployee objInfo = new clsEmployee();
                            objInfo.EmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.Code = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.DesignationId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.LocationId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[4]);
                            objInfo.BranchId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[5]);
                            objInfo.Email = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[6]);
                            objInfo.OfficeEmail = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[7]);
                            objInfo.Mobile = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[8]);
                            objInfo.CUGMobile = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[9]);
                            objInfo.Phone = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[10]);
                            objInfo.Summary = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[11]);
                            objInfo.Remarks = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[12]);
                            objInfo.Salary = Convert.ToDecimal(objDset.Tables[0].Rows[0].ItemArray[13]);
                            objInfo.Address = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[14]);
                            objInfo.City = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[15]);
                            objInfo.State = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[16]);
                            objInfo.Zip = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[17]);
                            objInfo.JoinDate = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[18]);
                            objInfo.EmergencyContact = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[19]);
                            objInfo.EmergencyPhone = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[20]);
                            if (objDset.Tables[0].Rows[0].ItemArray[21] != DBNull.Value)
                                objInfo.IsLeadPermit = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[21]);
                            objInfo.DepartmentId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[22]);
                            objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[23]);
                            objInfo.Roles = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[24]);
                            objInfo.NurturePermit = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[25]);
                            if (objDset.Tables[0].Rows[0].ItemArray[26] != DBNull.Value)
                                objInfo.ResumePath = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[26]);
                            if (objDset.Tables[0].Rows[0].ItemArray[27] != DBNull.Value)
                                objInfo.PhonePayNumber = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[27]);
                            if (objDset.Tables[0].Rows[0].ItemArray[28] != DBNull.Value)
                                objInfo.GooglePayNumber = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[28]);
                            if (objDset.Tables[0].Rows[0].ItemArray[29] != DBNull.Value)
                                objInfo.PaytmNumber = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[29]);
                            if (objDset.Tables[0].Rows[0].ItemArray[30] != DBNull.Value)
                                objInfo.AccountHolderName = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[30]);
                            if (objDset.Tables[0].Rows[0].ItemArray[31] != DBNull.Value)
                                objInfo.BankAccountNumber = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[31]);
                            if (objDset.Tables[0].Rows[0].ItemArray[32] != DBNull.Value)
                                objInfo.IFSCCode = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[32]);
                            if (objDset.Tables[0].Rows[0].ItemArray[33] != DBNull.Value)
                                objInfo.BankName = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[33]);
                            if (objDset.Tables[0].Rows[0].ItemArray[34] != DBNull.Value)
                                objInfo.BranchName = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[34]);
                            if (objDset.Tables[0].Rows[0].ItemArray[35] != DBNull.Value)
                                objInfo.PassbookFilePath = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[35]);
                            if (objDset.Tables[0].Rows[0].ItemArray[36] != DBNull.Value)
                                objInfo.PancardFilePath = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[36]);
                            if (objDset.Tables[0].Rows[0].ItemArray[37] != DBNull.Value)
                                objInfo.AadharFrontFilePath = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[37]);
                            if (objDset.Tables[0].Rows[0].ItemArray[38] != DBNull.Value)
                                objInfo.AadharBackFilePath = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[38]);
                            if (objDset.Tables[0].Rows[0].ItemArray[39] != DBNull.Value)
                                objInfo.IsTrainer = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[39]);
                            if (objDset.Tables[0].Rows[0].ItemArray[40] != DBNull.Value)
                                objInfo.IsProcess = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[40]);
                            if (objDset.Tables[0].Rows[0].ItemArray[41] != DBNull.Value)
                                objInfo.IsMentor = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[41]);
                            if (objDset.Tables[0].Rows[0].ItemArray[42] != DBNull.Value)
                                objInfo.IsDiscounter = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[42]);
                            if (objDset.Tables[0].Rows[0].ItemArray[43] != DBNull.Value)
                                objInfo.IsReportingManager = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[43]);
                            if (objDset.Tables[0].Rows[0].ItemArray[44] != DBNull.Value)
                                objInfo.IsAssociate = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[44]);
                            if (objDset.Tables[0].Rows[0].ItemArray[45] != DBNull.Value)
                                objInfo.IsVerticalHead = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[45]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }

        public clsEmployee Loadfew(int id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ProcessLocationid", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@Userid", id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsEmployee objInfo = new clsEmployee();
                            objInfo.LocationId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }


        public List<clsEmployee> LoadAll(clsEmployee obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Employee_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@keywords", obj.keywords);
                    objCmd.Parameters.AddWithValue("@BranchId", obj.BranchId);
                    objCmd.Parameters.AddWithValue("@DesignationId", obj.DesignationId);
                    objCmd.Parameters.AddWithValue("@DepartmentId", obj.DepartmentId);
                    objCmd.Parameters.AddWithValue("@IsLeadPermit", obj.IsLeadPermit);
                    objCmd.Parameters.AddWithValue("@NurturePermit", obj.NurturePermit);
                    objCmd.Parameters.AddWithValue("@IsActive", obj.IsActive);
                    objCmd.Parameters.AddWithValue("@IsDeleted", obj.IsDeleted);
                    objCmd.Parameters.AddWithValue("@IsReportingManager", obj.IsReportingManager);
                    objCmd.Parameters.AddWithValue("@LocationId", obj.LocationId);
                    objCmd.Parameters.AddWithValue("@IsVerticalHead", obj.IsVerticalHead);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);

                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsEmployee> objList = new List<clsEmployee>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsEmployee objInfo = new clsEmployee();
                                objInfo.SNo = cnt + 1;
                                objInfo.EmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.Code = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.Location = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.Branch = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.Designation = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.Email = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.OfficeEmail = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.Mobile = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.CUGMobile = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objInfo.Phone = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                objInfo.Summary = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[11]);
                                objInfo.Remarks = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[12]);
                                objInfo.Salary = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[13]);
                                objInfo.Address = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[14]);
                                objInfo.City = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[15]);
                                objInfo.State = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[16]);
                                objInfo.Zip = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[17]);
                                objInfo.JoinDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[18]);
                                objInfo.EmergencyContact = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[19]);
                                objInfo.EmergencyPhone = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[20]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[21] != DBNull.Value)
                                    objInfo.IsLeadPermit = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[21]);
                                objInfo.Department = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[22]);
                                objInfo.Roles = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[23]);
                                objInfo.NurturePermit = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[24]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[25] != DBNull.Value)
                                    objInfo.ResumePath = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[25]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[26] != DBNull.Value)
                                    objInfo.PhonePayNumber = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[26]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[27] != DBNull.Value)
                                    objInfo.GooglePayNumber = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[27]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[28] != DBNull.Value)
                                    objInfo.PaytmNumber = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[28]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[29] != DBNull.Value)
                                    objInfo.AccountHolderName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[29]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[30] != DBNull.Value)
                                    objInfo.BankAccountNumber = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[30]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[31] != DBNull.Value)
                                    objInfo.IFSCCode = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[31]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[32] != DBNull.Value)
                                    objInfo.BankName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[32]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[33] != DBNull.Value)
                                    objInfo.BranchName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[33]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[34] != DBNull.Value)
                                    objInfo.PassbookFilePath = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[34]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[35] != DBNull.Value)
                                    objInfo.PancardFilePath = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[35]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[36] != DBNull.Value)
                                    objInfo.AadharFrontFilePath = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[36]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[37] != DBNull.Value)
                                    objInfo.AadharBackFilePath = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[37]);
                                objInfo.LocationId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[38]);

                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }
        public List<clsEmployee> LoadAllMultiple(clsEmployee obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Employee_ListMultiple", objConn))
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
                            List<clsEmployee> objList = new List<clsEmployee>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsEmployee objInfo = new clsEmployee();
                                objInfo.SNo = cnt + 1;
                                objInfo.EmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.Code = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.Branch = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.Designation = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.Email = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.OfficeEmail = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.Mobile = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.CUGMobile = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.Phone = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objInfo.Summary = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                objInfo.Remarks = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[11]);
                                objInfo.Salary = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[12]);
                                objInfo.Address = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[13]);
                                objInfo.City = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[14]);
                                objInfo.State = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[15]);
                                objInfo.Zip = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[16]);
                                objInfo.JoinDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[17]);
                                objInfo.EmergencyContact = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[18]);
                                objInfo.EmergencyPhone = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[19]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[20] != DBNull.Value)
                                    objInfo.IsLeadPermit = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[20]);
                                objInfo.Department = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[21]);
                                objInfo.Roles = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[22]);
                                objInfo.NurturePermit = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[23]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[24] != DBNull.Value)
                                    objInfo.ResumePath = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[24]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }

        public List<clsEmployee> LoadAllReports(clsEmployee obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Employee_List_Report", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@keywords", obj.keywords);
                    objCmd.Parameters.AddWithValue("@BranchId", obj.BranchId);
                    objCmd.Parameters.AddWithValue("@DepartmentId", obj.DepartmentId);
                    objCmd.Parameters.AddWithValue("@DesignationId", obj.DesignationId);
                    objCmd.Parameters.AddWithValue("@EmployeeId", obj.EmployeeId);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);

                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsEmployee> objList = new List<clsEmployee>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsEmployee objInfo = new clsEmployee();
                                objInfo.SNo = cnt + 1;
                                objInfo.EmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.Code = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.Branch = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.Designation = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.Email = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.OfficeEmail = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.Mobile = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.CUGMobile = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.Phone = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objInfo.Summary = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                objInfo.Remarks = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[11]);
                                objInfo.Salary = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[12]);
                                objInfo.Address = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[13]);
                                objInfo.City = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[14]);
                                objInfo.State = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[15]);
                                objInfo.Zip = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[16]);
                                objInfo.JoinDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[17]);
                                objInfo.EmergencyContact = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[18]);
                                objInfo.EmergencyPhone = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[19]);
                                objInfo.Department = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[20]);
                                objInfo.Roles = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[21]);
                                //objInfo.NurturePermit = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[23]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }

        public List<clsEmployee> LoadAllEmployee(clsEmployee obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Employee_List_GetbyId", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@EmployeeId", obj.EmployeeId);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);

                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsEmployee> objList = new List<clsEmployee>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsEmployee objInfo = new clsEmployee();
                                objInfo.SNo = cnt + 1;
                                objInfo.EmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }
        public List<clsEmployee> LoadAll_InActive(clsEmployee obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Employee_List_InActve", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@keywords", obj.keywords);
                    objCmd.Parameters.AddWithValue("@BranchId", obj.BranchId);
                    objCmd.Parameters.AddWithValue("@DesignationId", obj.DesignationId);
                    objCmd.Parameters.AddWithValue("@DepartmentId", obj.DepartmentId);
                    objCmd.Parameters.AddWithValue("@IsLeadPermit", obj.IsLeadPermit);
                    objCmd.Parameters.AddWithValue("@NurturePermit", obj.NurturePermit);
                    objCmd.Parameters.AddWithValue("@isActive", obj.IsActive);
                    objCmd.Parameters.AddWithValue("@IsDeleted", obj.IsDeleted);
                    //objCmd.Parameters.AddWithValue("@LocationId", obj.LocationId);
                    //objCmd.Parameters.AddWithValue("@Location", obj.Location);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);

                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsEmployee> objList = new List<clsEmployee>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsEmployee objInfo = new clsEmployee();
                                objInfo.SNo = cnt + 1;
                                objInfo.EmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.Code = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.Branch = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.Designation = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.Email = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.OfficeEmail = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.Mobile = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.CUGMobile = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.Phone = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objInfo.Summary = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                objInfo.Remarks = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[11]);
                                objInfo.Salary = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[12]);
                                objInfo.Address = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[13]);
                                objInfo.City = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[14]);
                                objInfo.State = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[15]);
                                objInfo.Zip = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[16]);
                                objInfo.JoinDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[17]);
                                objInfo.EmergencyContact = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[18]);
                                objInfo.EmergencyPhone = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[19]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[20] != DBNull.Value)
                                    objInfo.IsLeadPermit = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[20]);
                                objInfo.Department = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[21]);
                                objInfo.Roles = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[22]);
                                objInfo.NurturePermit = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[23]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[24] != DBNull.Value)
                                    objInfo.ResumePath = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[24]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[25] != DBNull.Value)
                                    objInfo.PhonePayNumber = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[25]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[26] != DBNull.Value)
                                    objInfo.GooglePayNumber = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[26]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[27] != DBNull.Value)
                                    objInfo.PaytmNumber = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[27]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[28] != DBNull.Value)
                                    objInfo.AccountHolderName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[28]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[29] != DBNull.Value)
                                    objInfo.BankAccountNumber = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[29]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[30] != DBNull.Value)
                                    objInfo.IFSCCode = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[30]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[31] != DBNull.Value)
                                    objInfo.BankName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[31]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[32] != DBNull.Value)
                                    objInfo.BranchName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[32]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[33] != DBNull.Value)
                                    objInfo.PassbookFilePath = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[33]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[34] != DBNull.Value)
                                    objInfo.PancardFilePath = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[34]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[35] != DBNull.Value)
                                    objInfo.AadharFrontFilePath = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[35]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[36] != DBNull.Value)
                                    objInfo.AadharBackFilePath = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[36]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[37] != DBNull.Value)
                                    objInfo.LocationId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[37]);
                                    objInfo.Location = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[38]);
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
                using (SqlCommand objCmd = new SqlCommand("Employee_Remove", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@EmployeeId", Id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }
        public List<clsEmployee> LoadAll_VerifyCertificate(clsEmployee obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Employee_List_VerifyCertificate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@Email", obj.Email);
                    objCmd.Parameters.AddWithValue("@CertificateId", obj.CertificateId);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsEmployee> objList = new List<clsEmployee>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsEmployee objInfo = new clsEmployee();
                                objInfo.SNo = cnt + 1;
                                objInfo.EmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.Email = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.CertificateId = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.AwardName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.DateOfIssued = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[6] != DBNull.Value)
                                    objInfo.IssuedFortheMonth = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }
        public List<clsEmployee> LoadForAll(clsEmployee obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("EmployeeProfile_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@keywords", obj.keywords);
                    objCmd.Parameters.AddWithValue("@BranchId", obj.BranchId);
                    objCmd.Parameters.AddWithValue("@DesignationId", obj.DesignationId);
                    objCmd.Parameters.AddWithValue("@DepartmentId", obj.DepartmentId);
                    objCmd.Parameters.AddWithValue("@IsLeadPermit", obj.IsLeadPermit);
                    objCmd.Parameters.AddWithValue("@NurturePermit", obj.NurturePermit);
                    objCmd.Parameters.AddWithValue("@IsActive", obj.IsActive);
                    objCmd.Parameters.AddWithValue("@IsDeleted", obj.IsDeleted);
                    objCmd.Parameters.AddWithValue("@IsReportingManager", obj.IsReportingManager);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);

                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsEmployee> objList = new List<clsEmployee>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsEmployee objInfo = new clsEmployee();
                                objInfo.SNo = cnt + 1;
                                objInfo.EmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.Code = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.Location = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.Branch = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.Designation = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.Email = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.OfficeEmail = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.Mobile = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.CUGMobile = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objInfo.Phone = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                objInfo.Summary = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[11]);
                                objInfo.Remarks = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[12]);
                                objInfo.Salary = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[13]);
                                objInfo.Address = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[14]);
                                objInfo.City = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[15]);
                                objInfo.State = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[16]);
                                objInfo.Zip = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[17]);
                                objInfo.JoinDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[18]);
                                objInfo.EmergencyContact = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[19]);
                                objInfo.EmergencyPhone = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[20]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[21] != DBNull.Value)
                                    objInfo.IsLeadPermit = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[21]);
                                objInfo.Department = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[22]);
                                objInfo.Roles = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[23]);
                                objInfo.NurturePermit = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[24]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[25] != DBNull.Value)
                                    objInfo.ResumePath = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[25]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[26] != DBNull.Value)
                                    objInfo.PhonePayNumber = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[26]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[27] != DBNull.Value)
                                    objInfo.GooglePayNumber = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[27]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[28] != DBNull.Value)
                                    objInfo.PaytmNumber = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[28]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[29] != DBNull.Value)
                                    objInfo.AccountHolderName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[29]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[30] != DBNull.Value)
                                    objInfo.BankAccountNumber = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[30]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[31] != DBNull.Value)
                                    objInfo.IFSCCode = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[31]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[32] != DBNull.Value)
                                    objInfo.BankName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[32]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[33] != DBNull.Value)
                                    objInfo.BranchName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[33]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[34] != DBNull.Value)
                                    objInfo.PassbookFilePath = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[34]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[35] != DBNull.Value)
                                    objInfo.PancardFilePath = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[35]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[36] != DBNull.Value)
                                    objInfo.AadharFrontFilePath = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[36]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[37] != DBNull.Value)
                                    objInfo.AadharBackFilePath = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[37]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }


        public List<clsEmployee> DisplayEmployee(clsEmployee obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("EmployeeDetails_Display", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@DesignationId", obj.DesignationId);
                    objCmd.Parameters.AddWithValue("@Employee", obj.Employee);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);

                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsEmployee> objList = new List<clsEmployee>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsEmployee objInfo = new clsEmployee();
                                objInfo.SNo = cnt + 1;
                                objInfo.EmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.LocationId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.DesignationId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[3]);
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