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
    public class clsParticipantFeePayReceiptData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs5"].ConnectionString.ToString();
        public void AddUpdate(clsParticipantFeePayReceipt obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ParticipantFeePayReceipt_AddUpdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ReceiptId", obj.ReceiptId);
                    objCmd.Parameters.AddWithValue("@ReceiptTypeId", obj.ReceiptTypeId);
                    objCmd.Parameters.AddWithValue("@LeadId", obj.LeadId);
                    objCmd.Parameters.AddWithValue("@ServiceId", obj.ServiceId);
                    objCmd.Parameters.AddWithValue("@PaymentRecivingCompanyId", obj.PaymentRecivingCompanyId);
                    objCmd.Parameters.AddWithValue("@PaymentTypeId", obj.PaymentTypeId);
                    objCmd.Parameters.AddWithValue("@ChequeNo", obj.ChequeNo);
                    objCmd.Parameters.AddWithValue("@ChequeDate", obj.ChequeDate);
                    objCmd.Parameters.AddWithValue("@BankName", obj.BankName);
                    objCmd.Parameters.AddWithValue("@BankBranch", obj.BankBranch);
                    objCmd.Parameters.AddWithValue("@AccountNumber", obj.AccountNumber);
                    objCmd.Parameters.AddWithValue("@ReceiptDate", obj.ReceiptDate);
                    objCmd.Parameters.AddWithValue("@NameOnAccount", obj.NameOnAccount);
                    objCmd.Parameters.AddWithValue("@ReferenceNumber", obj.ReferenceNumber);
                    //objCmd.Parameters.AddWithValue("@AgreedFee", obj.AgreedFee);
                    //objCmd.Parameters.AddWithValue("@PreviousAmount", obj.PreviousAmount);
                    //objCmd.Parameters.AddWithValue("@PayingAmount", obj.PayingAmount);
                    //objCmd.Parameters.AddWithValue("@GSTtype", obj.GSTtype);
                    //objCmd.Parameters.AddWithValue("@WithOutGSTfees", obj.WithOutGSTfees);
                    //objCmd.Parameters.AddWithValue("@GSTtax", obj.GSTtax);
                    //objCmd.Parameters.AddWithValue("@PreviousAmountPayingAmountFee", obj.PreviousAmountPayingAmountFee);
                    //objCmd.Parameters.AddWithValue("@PendingAmount", obj.PendingAmount);
                    objCmd.Parameters.AddWithValue("@Notes", obj.Notes);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.ExecuteNonQuery();

                }
            }
        }
        public virtual clsParticipantFeePayReceipt Load(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ParticipantFeePayReceipt_Get", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("ReceiptId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsParticipantFeePayReceipt objInfo = new clsParticipantFeePayReceipt();
                            objInfo.ReceiptId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.ReceiptTypeId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.ServiceId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.PaymentRecivingCompanyId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[4]);
                            objInfo.PaymentTypeId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[5]);
                            objInfo.ChequeNo = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[6]);
                            if (objDset.Tables[0].Rows[0].ItemArray[7] != DBNull.Value)
                                objInfo.ChequeDate = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[7]);
                            objInfo.BankName = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[8]);
                            objInfo.BankBranch = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[9]);
                            objInfo.AccountNumber = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[10]);
                            objInfo.ReceiptDate = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[11]);
                            objInfo.NameOnAccount = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[12]);
                            objInfo.ReferenceNumber = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[13]);
                            if (objDset.Tables[0].Rows[0].ItemArray[14] != DBNull.Value)
                                objInfo.AgreedFee = Convert.ToDecimal(objDset.Tables[0].Rows[0].ItemArray[14]);
                            if (objDset.Tables[0].Rows[0].ItemArray[15] != DBNull.Value)
                                objInfo.PreviousAmount = Convert.ToDecimal(objDset.Tables[0].Rows[0].ItemArray[15]);
                            if (objDset.Tables[0].Rows[0].ItemArray[16] != DBNull.Value)
                                objInfo.PayingAmount = Convert.ToDecimal(objDset.Tables[0].Rows[0].ItemArray[16]);
                            objInfo.GSTtype = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[17]);
                            if (objDset.Tables[0].Rows[0].ItemArray[18] != DBNull.Value)
                                objInfo.WithOutGSTfees = Convert.ToDecimal(objDset.Tables[0].Rows[0].ItemArray[18]);
                            if (objDset.Tables[0].Rows[0].ItemArray[19] != DBNull.Value)
                                objInfo.GSTtax = Convert.ToDecimal(objDset.Tables[0].Rows[0].ItemArray[19]);
                            if (objDset.Tables[0].Rows[0].ItemArray[20] != DBNull.Value)
                                objInfo.PreviousAmountPayingAmountFee = Convert.ToDecimal(objDset.Tables[0].Rows[0].ItemArray[20]);
                            if (objDset.Tables[0].Rows[0].ItemArray[21] != DBNull.Value)
                                objInfo.PendingAmount = Convert.ToDecimal(objDset.Tables[0].Rows[0].ItemArray[21]);
                            objInfo.Notes = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[22]);
                            objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[23]);
                            objInfo.Participant = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[24]);
                            objInfo.LocationId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[25]);
                            objInfo.Location = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[26]);
                            objInfo.PaymentType = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[27]);
                            objInfo.Fullname = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[28]);
                            objInfo.ServiceName = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[29]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }
        public virtual List<clsParticipantFeePayReceipt> LoadAll(clsParticipantFeePayReceipt obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ParticipantFeePayReceipt_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    // objCmd.Parameters.AddWithValue("@keywords", obj.keywords);
                    //objCmd.Parameters.AddWithValue("@ReceiptTypeId", obj.ReceiptTypeId);
                    //objCmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    //objCmd.Parameters.AddWithValue("@PaymentTypeId", obj.PaymentTypeId);
                    //objCmd.Parameters.AddWithValue("@CompanyId", obj.CompanyId);

                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsParticipantFeePayReceipt> objList = new List<clsParticipantFeePayReceipt>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsParticipantFeePayReceipt objInfo = new clsParticipantFeePayReceipt();
                                objInfo.SNo = cnt + 1;
                                objInfo.ReceiptId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.ReceiptTypeId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[2] != DBNull.Value)
                                    objInfo.LeadId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.ServiceId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.PaymentRecivingCompanyId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.PaymentTypeId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.ChequeNo = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[7] != DBNull.Value)
                                    objInfo.ChequeDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.BankName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.BankBranch = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objInfo.AccountNumber = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                objInfo.ReceiptDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[11]);
                                objInfo.NameOnAccount = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[12]);
                                objInfo.ReferenceNumber = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[13]);
                                //objInfo.AgreedFee = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[14]);
                                //objInfo.PreviousAmount = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[15]);
                                //objInfo.PayingAmount = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[16]);
                                //objInfo.GSTtype = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[17]);
                                //objInfo.WithOutGSTfees = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[18]);
                                //objInfo.GSTtax = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[19]);
                                //objInfo.PreviousAmountPayingAmountFee = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[20]);
                                //objInfo.PendingAmount = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[21]);
                                objInfo.Notes = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[14]);
                                objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[15]);
                                objInfo.Participant = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[16]);
                                objInfo.LocationId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[17]);
                                objInfo.Location = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[18]);
                                objInfo.PaymentType = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[19]);
                                objInfo.Fullname = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[20]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }




        public virtual void Remove(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ParticipantFeePayReceipt_Remove", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ReceiptId", Id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }





    }
}