
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayerHelper
{


    public class clsParticipantDiscountData
    {


        public string Constr = ConfigurationManager.ConnectionStrings["cs5"].ConnectionString.ToString();

        public void AddUpdate(clsParticipantDiscount obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ParticipantDiscount_AddUpdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@DiscountId", obj.DiscountId);
                    objCmd.Parameters.AddWithValue("@LeadId", obj.LeadId);
                    objCmd.Parameters.AddWithValue("@ServiceId", obj.ServiceId);
                    objCmd.Parameters.AddWithValue("@AssociateId", obj.AssociateId);
                    objCmd.Parameters.AddWithValue("@DiscountAmt", obj.DiscountAmt);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.ExecuteNonQuery();
                }
            }
        }


        public List<clsParticipantDiscount> DiscountLoadAll(clsParticipantDiscount obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ParticipantDiscount_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    



                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);

                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsParticipantDiscount> objList = new List<clsParticipantDiscount>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsParticipantDiscount objInfo = new clsParticipantDiscount();
                                objInfo.SNo = cnt + 1;
                                // objInfo.DiscountId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Lead = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.ServiceName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.DiscountUser = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.DiscountAmt = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[4] != DBNull.Value)
                                    objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.Fullname = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[5]);


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