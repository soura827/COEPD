using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayerHelper
{
    public class clsReceiptData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();

        public virtual string AddUpdate(clsReceipt obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Receipt_AddUpdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ReceiptId", obj.ReceiptId);
                    objCmd.Parameters.AddWithValue("@Receipt", obj.Receipt);
                    objCmd.Parameters.AddWithValue("@ReceiptTypeId", obj.ReceiptTypeId);
                    objCmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    objCmd.Parameters.AddWithValue("@PaymentTypeId", obj.PaymentTypeId);
                    objCmd.Parameters.AddWithValue("@Notes", obj.Notes);
                    objCmd.Parameters.AddWithValue("@Amount", obj.Amount);
                    objCmd.Parameters.AddWithValue("@CompanyId", obj.CompanyId);
                    objCmd.Parameters.AddWithValue("@ChequeNo", obj.ChequeNo);
                    objCmd.Parameters.AddWithValue("@ChequeDate", obj.ChequeDate);
                    objCmd.Parameters.AddWithValue("@ChequeStatusId", obj.ChequeStatusId);
                    objCmd.Parameters.AddWithValue("@BankName", obj.BankName);
                    objCmd.Parameters.AddWithValue("@BankBranch", obj.BankBranch);
                    objCmd.Parameters.AddWithValue("@AccountNumber", obj.AccountNumber);
                    objCmd.Parameters.AddWithValue("@ReceiptDate", obj.ReceiptDate);
                    objCmd.Parameters.AddWithValue("@NameOnAccount", obj.NameOnAccount);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.Parameters.AddWithValue("@Tax", obj.Tax);
                    objCmd.Parameters.AddWithValue("@Total", obj.Total);
                    SqlParameter paramout = new SqlParameter("@Out_msg", SqlDbType.VarChar, 1000);
                    paramout.Direction = ParameterDirection.Output;
                    objCmd.Parameters.Add(paramout);
                    objCmd.ExecuteNonQuery();
                    string outmsg = paramout.SqlValue.ToString();
                    return outmsg;
                }
            }
        }

        public virtual clsReceipt Load(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Receipt_Get", objConn))
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
                            clsReceipt objInfo = new clsReceipt();
                            objInfo.ReceiptId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.Receipt = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.PaymentTypeId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.Notes = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[4]);
                            objInfo.Amount = Convert.ToDecimal(objDset.Tables[0].Rows[0].ItemArray[5]);
                            objInfo.CompanyId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[6]);
                            objInfo.ChequeNo = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[7]);
                            if (objDset.Tables[0].Rows[0].ItemArray[8] != DBNull.Value)
                                objInfo.ChequeDate = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[8]);
                            objInfo.ChequeStatusId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[9]);
                            objInfo.BankName = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[10]);
                            objInfo.BankBranch = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[11]);
                            objInfo.AccountNumber = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[12]);
                            objInfo.ReceiptDate = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[13]);
                            objInfo.NameOnAccount = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[14]);
                            objInfo.Tax = Convert.ToDecimal(objDset.Tables[0].Rows[0].ItemArray[15]);
                            objInfo.ReceiptTypeId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[16]);
                            objInfo.Participant = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[17]);
                            objInfo.LocationId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[18]);
                            objInfo.Location = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[19]);
                            objInfo.PaymentType = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[20]);
                            objInfo.Fullname = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[21]);
                            if (objDset.Tables[0].Rows[0].ItemArray[22] != DBNull.Value)
                                objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[22]);
                            return objInfo;

                        }
                    }
                    return null;
                }
            }
        }

        public virtual List<clsReceipt> LoadAll(clsReceipt obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Receipt_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@keywords", obj.keywords);
                    objCmd.Parameters.AddWithValue("@ReceiptTypeId", obj.ReceiptTypeId);
                    objCmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    objCmd.Parameters.AddWithValue("@PaymentTypeId", obj.PaymentTypeId);
                    objCmd.Parameters.AddWithValue("@CompanyId", obj.CompanyId);

                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsReceipt> objList = new List<clsReceipt>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsReceipt objInfo = new clsReceipt();
                                objInfo.SNo = cnt + 1;
                                objInfo.ReceiptId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Receipt = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.Participant = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.PaymentType = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.Notes = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.Amount = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.Company = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.ChequeNo = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[8] != DBNull.Value)
                                    objInfo.ChequeDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.ChequeStatusId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objInfo.BankName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                objInfo.BankBranch = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[11]);
                                objInfo.AccountNumber = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[12]);
                                objInfo.ReceiptDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[13]);
                                objInfo.NameOnAccount = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[14]);
                                objInfo.Tax = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[15]);
                                objInfo.Total = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[16]);
                                objInfo.ReceiptType = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[17]);
                                objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[18]);

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
                using (SqlCommand objCmd = new SqlCommand("Receipt_Remove", objConn))
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
