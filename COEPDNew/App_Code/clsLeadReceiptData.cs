using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;


namespace DataAccessLayerHelper
{
    public class clsLeadReceiptData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs5"].ConnectionString.ToString();
        public void AddUpdate(clsLeadReceipt obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ParticipantReceipt_AddUpdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ReceiptId", obj.ReceiptId);
                    objCmd.Parameters.AddWithValue("@LeadId", obj.LeadId);
                    objCmd.Parameters.AddWithValue("@GSTTypeCompany", obj.GSTTypeCompany);
                    objCmd.Parameters.AddWithValue("@CompanyName", obj.CompanyName);
                    objCmd.Parameters.AddWithValue("@GSTNumber", obj.GSTNumber);


                    objCmd.Parameters.AddWithValue("@Address", obj.Address);
                    objCmd.Parameters.AddWithValue("@PayingDate", obj.PayingDate);
                    objCmd.Parameters.AddWithValue("@PayingAmount", obj.PayingAmount);
                    objCmd.Parameters.AddWithValue("@FeeAmount", obj.FeeAmount);
                    objCmd.Parameters.AddWithValue("@GST", obj.GST);



                    objCmd.Parameters.AddWithValue("@PendingAmount", obj.PendingAmount);
                    objCmd.Parameters.AddWithValue("@InputCompany", obj.InputCompany);
                    objCmd.Parameters.AddWithValue("@PaymentGateway", obj.PaymentGateway);
                    objCmd.Parameters.AddWithValue("@ReferenceNumber", obj.ReferenceNumber);
                    objCmd.Parameters.AddWithValue("@AccountName", obj.AccountName);



                    objCmd.Parameters.AddWithValue("@AccountNumber", obj.AccountNumber);
                    objCmd.Parameters.AddWithValue("@BankName", obj.BankName);
                    objCmd.Parameters.AddWithValue("@BankBranch", obj.BankBranch);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.ExecuteNonQuery();
                }
            }
        }

        public List<clsLeadReceipt> LoadAll(clsLeadReceipt obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Confirmation_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                   objCmd.Parameters.AddWithValue("@IsConfirmation", obj.IsConfirmation);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);

                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsLeadReceipt> objList = new List<clsLeadReceipt>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsLeadReceipt objInfo = new clsLeadReceipt();
                                objInfo.SNo = cnt + 1;
                                objInfo.ReceiptId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.LeadId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.GSTTypeCompany = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.CompanyName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.GSTNumber = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.Address = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.PayingDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.PayingAmount = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.FeeAmount = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.GST = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objInfo.PendingAmount = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                objInfo.InputCompany = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[11]);
                                objInfo.PaymentGateway = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[12]);
                                objInfo.ReferenceNumber = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[13]);
                                objInfo.AccountName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[14]);
                                objInfo.AccountNumber = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[15]);
                                objInfo.BankName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[16]);
                                objInfo.BankBranch = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[17]);
                                objInfo.CreatedBy = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[18]);
                                objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[19]);
                                objInfo.CreatedByName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[20]);

                                objInfo.LeadName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[21]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[22] != DBNull.Value)
                                    objInfo.StartDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[22]);
                                objInfo.Location = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[23]);
                                objInfo.ServiceOwnerName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[24]);
                                objInfo.PaymentType = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[25]);

                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }
        public List<clsLeadReceipt> LoadForAll(clsLeadReceipt obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ConfirmationReceipt_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@IsConfirmation", obj.IsConfirmation);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);

                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsLeadReceipt> objList = new List<clsLeadReceipt>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsLeadReceipt objInfo = new clsLeadReceipt();
                                objInfo.SNo = cnt + 1;
                                objInfo.ReceiptId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.LeadId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.GSTTypeCompany = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.CompanyName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.GSTNumber = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.Address = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.PayingDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.PayingAmount = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.FeeAmount = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.GST = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objInfo.PendingAmount = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                objInfo.InputCompany = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[11]);


                                objInfo.PaymentType = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[12]);

                                objInfo.ReferenceNumber = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[13]);
                                objInfo.AccountName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[14]);
                                objInfo.AccountNumber = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[15]);
                                objInfo.BankName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[16]);
                                objInfo.BankBranch = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[17]);
                                objInfo.CreatedBy = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[18]);
                                objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[19]);
                                objInfo.CreatedByName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[20]);

                                objInfo.LeadName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[21]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[22] != DBNull.Value)
                                    objInfo.StartDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[22]);
                                objInfo.Location = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[23]);
                                objInfo.ServicesName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[24]);
                                objInfo.PaymentType = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[25]);

                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }
        public clsLeadReceipt Load(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Receipt_Get", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ReceiptId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsLeadReceipt objInfo = new clsLeadReceipt();
                            objInfo.ReceiptId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.LeadId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.GSTTypeCompany = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.CompanyName = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.GSTNumber = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[4]);
                            objInfo.Address = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[5]);
                            objInfo.PayingDate = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[6]);
                            objInfo.PayingAmount = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[7]);
                            objInfo.FeeAmount = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[8]);
                            objInfo.GST = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[9]);
                            objInfo.PendingAmount = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[10]);
                            objInfo.InputCompany = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[11]);
                            objInfo.PaymentGateway = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[12]);
                            objInfo.ReferenceNumber = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[13]);
                            objInfo.AccountName = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[14]);
                            objInfo.AccountNumber = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[15]);
                            objInfo.BankName = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[16]);
                            objInfo.BankBranch = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[17]);
                            objInfo.LocationId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[18]);
                            objInfo.PrimaryMobile = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[19]);
                            objInfo.AgreedFee = Convert.ToDecimal(objDset.Tables[0].Rows[0].ItemArray[20]);
                            if (objDset.Tables[0].Rows[0].ItemArray[21] != DBNull.Value)
                                objInfo.ServiceOwnerId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[21]);
                            objInfo.ServiceOwnerName = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[22]);
                            if (objDset.Tables[0].Rows[0].ItemArray[23] != DBNull.Value)
                                objInfo.ServiceId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[23]);
                            objInfo.Location = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[24]);
                            objInfo.ServiceName = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[25]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }
        public void Update(clsLeadReceipt obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ParticipantFeePayReceipt_Update", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ReceiptId", obj.ReceiptId);
                    objCmd.Parameters.AddWithValue("@ConfirmationReferenceNo", obj.ConfirmationReferenceNo);
                    objCmd.Parameters.AddWithValue("@ConfirmationBy", obj.ConfirmationBy);
                    objCmd.Parameters.AddWithValue("@IsConfirmation", obj.IsConfirmation);

                    objCmd.ExecuteNonQuery();
                }
            }
        }
        public virtual clsLeadReceipt LoadReceipt(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("LeadFeeReceipt_Get", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ReceiptId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsLeadReceipt objInfo = new clsLeadReceipt();
                            objInfo.ReceiptId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.LeadId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.Lead = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[2]);
                            if (objDset.Tables[0].Rows[0].ItemArray[3] != DBNull.Value)
                                objInfo.PayingDate = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.PayingAmount = Convert.ToDecimal(objDset.Tables[0].Rows[0].ItemArray[4]);
                            objInfo.PaymentType = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[5]);
                            objInfo.CreatedByName = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[6]);
                            objInfo.Location = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[7]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }





























    }
}