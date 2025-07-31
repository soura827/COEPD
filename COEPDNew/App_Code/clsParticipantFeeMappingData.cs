using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayerHelper
{
    public class clsParticipantFeeMappingData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs5"].ConnectionString.ToString();

        public void AddUpdate(clsParticipantFeeMapping obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ParticipantFeeMapping_AddUpdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ParticipantFeeMapId", obj.ParticipantFeeMapId);
                    objCmd.Parameters.AddWithValue("@LeadId", obj.LeadId);
                    objCmd.Parameters.AddWithValue("@ServiceId", obj.ServiceId);
                    objCmd.Parameters.AddWithValue("@DiscountFee", obj.Discount);
                    objCmd.Parameters.AddWithValue("@ActualFee", obj.ActualFee);
                    objCmd.Parameters.AddWithValue("@AgreedFee", obj.AgreedFee);
                    objCmd.Parameters.AddWithValue("@ServicesName", obj.ServicesName);
                    objCmd.Parameters.AddWithValue("@DiscountAssociate", obj.DiscountAssociate);
                    objCmd.Parameters.AddWithValue("@LeadOwnerId", obj.LeadOwnerId);
                    objCmd.Parameters.AddWithValue("@BatchId", obj.BatchId);
                    objCmd.Parameters.AddWithValue("@LocationId", obj.LocationId);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.ExecuteNonQuery();
                }
            }
        }


        public clsParticipantFeeMapping Load(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ParticipantFeeMapping_Get", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ParticipantFeeMapId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsParticipantFeeMapping objInfo = new clsParticipantFeeMapping();
                            objInfo.ParticipantFeeMapId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.LeadId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.ServiceId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.Discount = Convert.ToDecimal(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.ActualFee = Convert.ToDecimal(objDset.Tables[0].Rows[0].ItemArray[4]);
                            objInfo.AgreedFee = Convert.ToDecimal(objDset.Tables[0].Rows[0].ItemArray[5]);
                            objInfo.ServicesName = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[6]);
                            objInfo.DiscountAssociate = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[7]);
                            objInfo.LeadOwnerId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[8]);
                            if (objDset.Tables[0].Rows[0].ItemArray[9] != DBNull.Value)
                                objInfo.BatchId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[9]);
                            objInfo.LocationId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[10]);
                            objInfo.Location = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[11]);
                            objInfo.ServiceName = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[12]);
                            objInfo.ServiceOwnerName = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[13]);
                            objInfo.PrimaryMobile = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[14]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }
        public clsParticipantFeeMapping LoadLead(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Leadfeemapping_Get", objConn))
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
                            clsParticipantFeeMapping objInfo = new clsParticipantFeeMapping();
                            if (objDset.Tables[0].Rows[0].ItemArray[0] != DBNull.Value)
                                objInfo.FeeInstallmentId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            if (objDset.Tables[0].Rows[0].ItemArray[1] != DBNull.Value)
                                objInfo.LeadId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.AgreedFee = Convert.ToDecimal(objDset.Tables[0].Rows[0].ItemArray[2]);
                            if (objDset.Tables[0].Rows[0].ItemArray[3] != DBNull.Value)
                                objInfo.LocationId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[3]);
                            if (objDset.Tables[0].Rows[0].ItemArray[4] != DBNull.Value)
                                objInfo.ServiceId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[4]);
                                objInfo.Fullname = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[5]);
                            objInfo.PrimaryMobile = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[6]);





                           





                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }

        public List<clsParticipantFeeMapping> LoadAll(clsParticipantFeeMapping obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ParticipantFeeMaaping_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@keywords", obj.Keywords);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsParticipantFeeMapping> objList = new List<clsParticipantFeeMapping>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsParticipantFeeMapping objInfo = new clsParticipantFeeMapping();
                                objInfo.SNo = cnt + 1;
                                objInfo.ParticipantFeeMapId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Lead = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.ServiceName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[3] != DBNull.Value)
                                    objInfo.ActualFee = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[4] != DBNull.Value)
                                    objInfo.AgreedFee = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[5] != DBNull.Value)
                                    objInfo.DiscountFee = Convert.ToDecimal(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.ServicesName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.DiscountAssociate = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.Employees = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[9] != DBNull.Value)
                                    objInfo.StartDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objInfo.Location = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[11] != DBNull.Value)
                                    objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[11]);
                                objInfo.Fullname = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[12]);
                                objInfo.ModifiedName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[13]);


                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }

        public int LoadLeadValidation(clsParticipantFeeMapping obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Lead_Validation", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@lead", obj.Lead);
                    int count = Convert.ToInt16(objCmd.ExecuteScalar());
                    return count;
                }
            }
        }


    }
}