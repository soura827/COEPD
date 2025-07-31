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
    public class clsDemoAttendenceData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();

        public void AddUpdate(clsDemoAttendence obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("DemoAttendence_AddUpdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@DemoAttendenceId", obj.DemoAttendenceId);
                    objCmd.Parameters.AddWithValue("@LeadId", obj.LeadId);
                    objCmd.Parameters.AddWithValue("@DemoId", obj.DemoId);
                    objCmd.Parameters.AddWithValue("@IsInterested", obj.IsInterested);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.Parameters.AddWithValue("@IsDemoAttended", obj.IsDemoAttended);
                    objCmd.ExecuteNonQuery();
                }
            }
        }





        public List<clsDemoAttendence> LoadAll(clsDemoAttendence obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("DemoAttendence_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;

                    objCmd.Parameters.AddWithValue("@LeadId", obj.LeadId);
                    objCmd.Parameters.AddWithValue("@IsDemoAttended", obj.IsDemoAttended);

                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);

                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsDemoAttendence> objList = new List<clsDemoAttendence>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsDemoAttendence objInfo = new clsDemoAttendence();
                                objInfo.SNo = cnt + 1;
                                objInfo.DemoAttendenceId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[1] != DBNull.Value)
                                    objInfo.DemoId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[1]);

                                if (objDset.Tables[0].Rows[cnt].ItemArray[2] != DBNull.Value)
                                    objInfo.LeadId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[2]);

                                if (objDset.Tables[0].Rows[cnt].ItemArray[3] != DBNull.Value)
                                    objInfo.IsInterested = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[3]);

                                if (objDset.Tables[0].Rows[cnt].ItemArray[4] != DBNull.Value)
                                    objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[4]);

                                if (objDset.Tables[0].Rows[cnt].ItemArray[5] != DBNull.Value)
                                    objInfo.CreatedBy = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[5]);

                                if (objDset.Tables[0].Rows[cnt].ItemArray[6] != DBNull.Value)
                                    objInfo.ModifiedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[6]);

                                if (objDset.Tables[0].Rows[cnt].ItemArray[7] != DBNull.Value)
                                    objInfo.ModifiedBy = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[7]);

                                if (objDset.Tables[0].Rows[cnt].ItemArray[8] != DBNull.Value)
                                    objInfo.IsDemoAttended = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[8]);

                                objInfo.CreatedByName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[9]);

                                objInfo.ModifiedByName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[10]);

                                if (objDset.Tables[0].Rows[cnt].ItemArray[11] != DBNull.Value)
                                    objInfo.DemoDateTime = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[11]);

                                if (objDset.Tables[0].Rows[cnt].ItemArray[12] != DBNull.Value)
                                    objInfo.DemoTrainerName = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[12]);

                                objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[13]);
                                objInfo.LeadName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[14]);

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
                using (SqlCommand objCmd = new SqlCommand("DemoAttendence_Remove", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@DemoAttendenceId", Id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }


    }
}

