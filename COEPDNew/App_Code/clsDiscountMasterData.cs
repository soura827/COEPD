 
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
    public class clsDiscountMasterData

    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs5"].ConnectionString.ToString();
        public void DIscountMasterAddUpdate(clsDiscountMaster obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("DiscountMaster_AddUpdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@DiscountMasterId", obj.DiscountMasterId);
                    objCmd.Parameters.AddWithValue("@DiscountGivenTo", obj.DiscountGivenTo);
                    objCmd.Parameters.AddWithValue("@DiscountAmt", obj.DiscountAmt);
                    objCmd.Parameters.AddWithValue("@Description", obj.Description);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.ExecuteNonQuery();
                }
            }
        }

        public List<clsDiscountMaster> DiscountMasterLoadAll(clsDiscountMaster obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("DiscountMaster_List", objConn))
                {
                    objConn.Open();
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);

                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsDiscountMaster> objList = new List<clsDiscountMaster>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsDiscountMaster objInfo = new clsDiscountMaster();
                                objInfo.SNo = cnt + 1;
                                // objInfo.DiscountId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.DiscountGivenTo = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.DiscountAmt = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.Description = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[3] != DBNull.Value)
                                    objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.Fullname = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[4]);


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

