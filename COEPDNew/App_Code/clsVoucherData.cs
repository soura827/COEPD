using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayerHelper
{

    public class clsVoucherData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();

        public virtual string AddUpdate(clsVoucher obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Voucher_AddUpdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@VoucherId", obj.VoucherId);
                    objCmd.Parameters.AddWithValue("@Voucher", obj.Voucher);
                    objCmd.Parameters.AddWithValue("@VoucherTypeId", obj.VoucherTypeId);
                    objCmd.Parameters.AddWithValue("@VendorId", obj.VendorId);
                    objCmd.Parameters.AddWithValue("@PaymentTypeId", obj.PaymentTypeId);
                    objCmd.Parameters.AddWithValue("@Notes", obj.Notes);
                    objCmd.Parameters.AddWithValue("@Amount", obj.Amount);
                    objCmd.Parameters.AddWithValue("@CompanyId", obj.CompanyId);
                    objCmd.Parameters.AddWithValue("@ChequeNo", obj.ChequeNo);
                    objCmd.Parameters.AddWithValue("@ChequeDate", obj.ChequeDate);
                    objCmd.Parameters.AddWithValue("@ChequeStatusId", obj.ChequeStatusId);
                    objCmd.Parameters.AddWithValue("@NameOnAccount", obj.NameOnAccount);
                    objCmd.Parameters.AddWithValue("@BankName", obj.BankName);
                    objCmd.Parameters.AddWithValue("@BankBranch", obj.BankBranch);
                    objCmd.Parameters.AddWithValue("@AccountNumber", obj.AccountNumber);
                    objCmd.Parameters.AddWithValue("@VoucherDate", obj.VoucherDate);
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

        public virtual clsVoucher Load(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Voucher_Get", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("VoucherId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsVoucher objInfo = new clsVoucher();
                            objInfo.VoucherId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.Voucher = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.VoucherTypeId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.VendorId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.PaymentTypeId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[4]);
                            objInfo.Notes = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[5]);
                            objInfo.Amount = Convert.ToDecimal(objDset.Tables[0].Rows[0].ItemArray[6]);
                            objInfo.CompanyId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[7]);
                            objInfo.ChequeNo = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[8]);
                            if (objDset.Tables[0].Rows[0].ItemArray[8] != DBNull.Value)
                                objInfo.ChequeDate = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[9]);
                            objInfo.ChequeStatusId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[10]);
                            objInfo.BankName = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[11]);
                            objInfo.BankBranch = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[12]);
                            objInfo.AccountNumber = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[13]);
                            objInfo.VoucherDate = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[14]);
                            objInfo.NameOnAccount = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[15]);
                            objInfo.Tax = Convert.ToDecimal(objDset.Tables[0].Rows[0].ItemArray[16]);
                            objInfo.Total = Convert.ToDecimal(objDset.Tables[0].Rows[0].ItemArray[17]);
                            return objInfo;

                        }
                    }
                    return null;
                }
            }
        }

        public virtual List<clsVoucher> LoadAll(clsVoucher obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Voucher_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@keywords", obj.keywords);
                    objCmd.Parameters.AddWithValue("@VendorId", obj.VendorId);
                    objCmd.Parameters.AddWithValue("@PaymentTypeId", obj.PaymentTypeId);
                    objCmd.Parameters.AddWithValue("@CompanyId", obj.CompanyId);

                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsVoucher> objList = new List<clsVoucher>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsVoucher objInfo = new clsVoucher();
                                objInfo.SNo = cnt + 1;
                                objInfo.VoucherId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Voucher = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.VoucherType = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.Vendor = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.PaymentType = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.Notes = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.Amount = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.Company = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.ChequeNo = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[8] != DBNull.Value)
                                    objInfo.ChequeDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objInfo.ChequeStatusId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                objInfo.BankName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[11]);
                                objInfo.BankBranch = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[12]);
                                objInfo.AccountNumber = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[13]);
                                objInfo.VoucherDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[14]);
                                objInfo.NameOnAccount = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[15]);
                                objInfo.Tax = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[16]);
                                objInfo.Total = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[17]);
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
                using (SqlCommand objCmd = new SqlCommand("Voucher_Remove", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@VoucherId", Id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }




    }
}