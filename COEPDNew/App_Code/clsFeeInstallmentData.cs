using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using BusinessLayer;

namespace DataAccessLayerHelper
{


    public class clsFeeInstallmentData
    {

        public string Constr = ConfigurationManager.ConnectionStrings["cs5"].ConnectionString.ToString();

        public void AddUpdate(clsFeeInstallment obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("FeeInstallment_AddUpdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@FeeInstallmentId", obj.FeeInstallmentId);
                    objCmd.Parameters.AddWithValue("@ParticipantFeeMapId", obj.ParticipantFeeMapId);
                    objCmd.Parameters.AddWithValue("@LeadId", obj.LeadId);
                    objCmd.Parameters.AddWithValue("@AgreedFee", obj.AgreedFee);
                    objCmd.Parameters.AddWithValue("@InstallmentDate", obj.InstallmentDate);
                    objCmd.Parameters.AddWithValue("@Amount", obj.Amount);
                    objCmd.Parameters.AddWithValue("@Due", obj.Due);
                    objCmd.Parameters.AddWithValue("@Description", obj.Installments);
                    objCmd.Parameters.AddWithValue("@ServiceOwner", obj.ServiceOwner);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.Parameters.AddWithValue("@IsInstallmentStatus", obj.IsInstallmentStatus);

                    objCmd.ExecuteNonQuery();
                }
            }
        }



        public clsFeeInstallment LoadEdit(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("InstallmentFollowUp_Get", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@FeeInstallmentId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsFeeInstallment objInfo = new clsFeeInstallment();


                            if (objDset.Tables[0].Rows[0].ItemArray[0] != DBNull.Value)
                                objInfo.LeadId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);

                            if (objDset.Tables[0].Rows[0].ItemArray[1] != DBNull.Value)
                                objInfo.StartDate = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[1]);

                            objInfo.ServiceOwner = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[2]);

                            objInfo.Installments = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[3]);

                            if (objDset.Tables[0].Rows[0].ItemArray[4] != DBNull.Value)
                                objInfo.InstallmentDate = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[4]);

                            if (objDset.Tables[0].Rows[0].ItemArray[5] != DBNull.Value)
                                objInfo.AgreedFee = Convert.ToDecimal(objDset.Tables[0].Rows[0].ItemArray[5]);

                            if (objDset.Tables[0].Rows[0].ItemArray[6] != DBNull.Value)
                                objInfo.Amount = Convert.ToDecimal(objDset.Tables[0].Rows[0].ItemArray[6]);


                            if (objDset.Tables[0].Rows[0].ItemArray[7] != DBNull.Value)
                                objInfo.Due = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[7]);

                            if (objDset.Tables[0].Rows[0].ItemArray[8] != DBNull.Value)
                                objInfo.IsInstallmentStatus = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[8]);





                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }


        public clsFeeInstallment Load(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("FeeInstallment_Get", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("LeadId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsFeeInstallment objInfo = new clsFeeInstallment();

                            if (objDset.Tables[0].Rows[0].ItemArray[0] != DBNull.Value)

                                objInfo.AgreedFee = Convert.ToDecimal(objDset.Tables[0].Rows[0].ItemArray[0]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }

        public List<clsFeeInstallment> LoadAll(clsFeeInstallment obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("FeeInstallment_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@LeadId", obj.LeadId);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsFeeInstallment> objList = new List<clsFeeInstallment>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsFeeInstallment objInfo = new clsFeeInstallment();
                                objInfo.SNo = cnt + 1;
                                if (objDset.Tables[0].Rows[cnt].ItemArray[0] != DBNull.Value)
                                    objInfo.ParticipantFeeMapId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Lead = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[2] != DBNull.Value)
                                    objInfo.InstallmentDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[2]);

                                if (objDset.Tables[0].Rows[cnt].ItemArray[3] != DBNull.Value)
                                    objInfo.AgreedFee = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[3]);

                                objInfo.Amount = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.Due = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[5]);

                                objInfo.Installments = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.ServiceOwner = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[8] != DBNull.Value)
                                    objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.Fullname = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objInfo.IsInstallmentStatus = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }

        public List<clsFeeInstallment> LoadForALL(clsFeeInstallment obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("FeeInstallmentFollowUp_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@Lead", obj.Lead);
                    objCmd.Parameters.AddWithValue("@FromDate", obj.FromDate);
                    objCmd.Parameters.AddWithValue("@ToDate", obj.ToDate);
                    objCmd.Parameters.AddWithValue("@Mobile", obj.Mobile);
                    objCmd.Parameters.AddWithValue("@Fullname", obj.Fullname);
                    objCmd.Parameters.AddWithValue("@Installments", obj.Installments);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsFeeInstallment> objList = new List<clsFeeInstallment>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsFeeInstallment objInfo = new clsFeeInstallment();
                                objInfo.SNo = cnt + 1;

                                if (objDset.Tables[0].Rows[cnt].ItemArray[0] != DBNull.Value)
                                    objInfo.FeeInstallmentId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Lead = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[2] != DBNull.Value)
                                    objInfo.StartDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[3] != DBNull.Value)
                                    objInfo.InstallmentDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[4] != DBNull.Value)
                                    objInfo.AgreedFee = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[5] != DBNull.Value)
                                    objInfo.Amount = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[6] != DBNull.Value)
                                    objInfo.Due = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.Installments = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[7]);

                                if (objDset.Tables[0].Rows[cnt].ItemArray[8] != DBNull.Value)
                                    objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.Fullname = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objInfo.IsInstallmentStatus = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                objInfo.Mobile = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[11]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }





        public List<clsFeeInstallment> FeeRevenue(clsFeeInstallment obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("FeeRevenue_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@LeadId", obj.LeadId);
                    objCmd.Parameters.AddWithValue("@FromDate", obj.FromDate);
                    objCmd.Parameters.AddWithValue("@ToDate", obj.ToDate);
                    objCmd.Parameters.AddWithValue("@Description", obj.Installments);
                    objCmd.Parameters.AddWithValue("@IsInstallmentStatus", obj.IsInstallmentStatus);

                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsFeeInstallment> objList = new List<clsFeeInstallment>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsFeeInstallment objInfo = new clsFeeInstallment();
                                objInfo.SNo = cnt + 1;
                                if (objDset.Tables[0].Rows[cnt].ItemArray[0] != DBNull.Value)
                                    objInfo.FeeInstallmentId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);


                                objInfo.Lead = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[2] != DBNull.Value)
                                    objInfo.StartDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[3] != DBNull.Value)
                                    objInfo.InstallmentDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[4] != DBNull.Value)
                                    objInfo.AgreedFee = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[5] != DBNull.Value)
                                    objInfo.Amount = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[6] != DBNull.Value)
                                    objInfo.Due = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.Installments = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[8] != DBNull.Value)
                                    objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.Fullname = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objInfo.IsInstallmentStatus = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }
        public List<clsFeeInstallment> LoadFeeAll(clsFeeInstallment obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("FeeInstallmentPay_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@LeadId", obj.LeadId);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsFeeInstallment> objList = new List<clsFeeInstallment>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsFeeInstallment objInfo = new clsFeeInstallment();
                                objInfo.SNo = cnt + 1;
                                if (objDset.Tables[0].Rows[cnt].ItemArray[0] != DBNull.Value)
                                    objInfo.ParticipantFeeMapId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Lead = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[2] != DBNull.Value)
                                    objInfo.InstallmentDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[2]);

                                if (objDset.Tables[0].Rows[cnt].ItemArray[3] != DBNull.Value)
                                    objInfo.AgreedFee = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[3]);

                                objInfo.Amount = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.Due = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.Installments = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.ServiceOwner = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[8] != DBNull.Value)
                                    objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.Fullname = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objInfo.IsInstallmentStatus = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }


        public List<clsFeeInstallment> LoadALLPendings(clsFeeInstallment obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("FeeInstallmentsPendings_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@Lead", obj.Lead);
                    objCmd.Parameters.AddWithValue("@FromDate", obj.FromDate);
                    objCmd.Parameters.AddWithValue("@ToDate", obj.ToDate);
                    objCmd.Parameters.AddWithValue("@IsInstallmentStatus", obj.IsInstallmentStatus);
                    objCmd.Parameters.AddWithValue("@Mobile", obj.Mobile);
                    objCmd.Parameters.AddWithValue("@Fullname", obj.Fullname);
                    objCmd.Parameters.AddWithValue("@Installments", obj.Installments);


                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsFeeInstallment> objList = new List<clsFeeInstallment>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsFeeInstallment objInfo = new clsFeeInstallment();
                                objInfo.SNo = cnt + 1;
                                if (objDset.Tables[0].Rows[cnt].ItemArray[0] != DBNull.Value)
                                    objInfo.FeeInstallmentId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);


                                objInfo.Lead = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[2] != DBNull.Value)
                                    objInfo.StartDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[3] != DBNull.Value)
                                    objInfo.InstallmentDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[4] != DBNull.Value)
                                    objInfo.AgreedFee = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[5] != DBNull.Value)
                                    objInfo.Amount = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[6] != DBNull.Value)
                                    objInfo.Due = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.Installments = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[8] != DBNull.Value)
                                    objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.Fullname = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objInfo.IsInstallmentStatus = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                objInfo.Mobile = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[11]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }















        public List<clsFeeInstallment> ParticipantBadDebts(clsFeeInstallment obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ParticipantBadDebts_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@Lead", obj.Lead);
                    objCmd.Parameters.AddWithValue("@FromDate", obj.FromDate);
                    objCmd.Parameters.AddWithValue("@ToDate", obj.ToDate);
                    objCmd.Parameters.AddWithValue("@IsInstallmentStatus", obj.IsInstallmentStatus);
                    objCmd.Parameters.AddWithValue("@Mobile", obj.Mobile);
                    objCmd.Parameters.AddWithValue("@Fullname", obj.Fullname);
                    objCmd.Parameters.AddWithValue("@Installments", obj.Installments);

                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsFeeInstallment> objList = new List<clsFeeInstallment>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsFeeInstallment objInfo = new clsFeeInstallment();
                                objInfo.SNo = cnt + 1;
                                if (objDset.Tables[0].Rows[cnt].ItemArray[0] != DBNull.Value)
                                    objInfo.FeeInstallmentId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);


                                objInfo.Lead = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[2] != DBNull.Value)
                                    objInfo.StartDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[3] != DBNull.Value)
                                    objInfo.InstallmentDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[4] != DBNull.Value)
                                    objInfo.AgreedFee = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[5] != DBNull.Value)
                                    objInfo.Amount = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[6] != DBNull.Value)
                                    objInfo.Due = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.Installments = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[8] != DBNull.Value)
                                    objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.Fullname = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objInfo.IsInstallmentStatus = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                objInfo.Mobile = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[11]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }







        public List<clsFeeInstallment> ParticipantFeeLost(clsFeeInstallment obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ParticipantFeeLost_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@Lead", obj.Lead);
                    objCmd.Parameters.AddWithValue("@FromDate", obj.FromDate);
                    objCmd.Parameters.AddWithValue("@ToDate", obj.ToDate);
                    objCmd.Parameters.AddWithValue("@IsInstallmentStatus", obj.IsInstallmentStatus);
                    objCmd.Parameters.AddWithValue("@Mobile", obj.Mobile);
                    objCmd.Parameters.AddWithValue("@Fullname", obj.Fullname);
                    objCmd.Parameters.AddWithValue("@Installments", obj.Installments);

                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsFeeInstallment> objList = new List<clsFeeInstallment>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsFeeInstallment objInfo = new clsFeeInstallment();
                                objInfo.SNo = cnt + 1;

                                if (objDset.Tables[0].Rows[cnt].ItemArray[0] != DBNull.Value)
                                    objInfo.FeeInstallmentId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Lead = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[2] != DBNull.Value)
                                    objInfo.StartDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[3] != DBNull.Value)
                                    objInfo.InstallmentDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[4] != DBNull.Value)
                                    objInfo.AgreedFee = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[5] != DBNull.Value)
                                    objInfo.Amount = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[6] != DBNull.Value)
                                    objInfo.Due = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.Installments = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[7]);

                                if (objDset.Tables[0].Rows[cnt].ItemArray[8] != DBNull.Value)
                                    objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.Fullname = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objInfo.IsInstallmentStatus = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                objInfo.Mobile = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[11]);
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