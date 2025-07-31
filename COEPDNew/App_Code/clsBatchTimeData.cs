using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayerHelper
{
    public class clsBatchTimeData
    {

        public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();

        public void AddUpdate(clsBatchTime obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("BatchTime_AddUpdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@BatchTimeId", obj.BatchTimeId);
                    objCmd.Parameters.AddWithValue("@StartTime", obj.StartTime);
                    objCmd.Parameters.AddWithValue("@EndTime", obj.EndTime);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.ExecuteNonQuery();
                }
            }
        }

        public clsBatchTime Load(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("BatchTime_Get", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@BatchTimeId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsBatchTime objInfo = new clsBatchTime();
                            objInfo.BatchTimeId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.StartTime = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.EndTime = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[3]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }
        public List<clsBatchTime> LoadAll(clsBatchTime obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("BatchTime_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@keywords", obj.keywords);
                    objCmd.Parameters.AddWithValue("@BatchTimeId", obj.BatchTimeId);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);

                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsBatchTime> objList = new List<clsBatchTime>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsBatchTime objInfo = new clsBatchTime();
                                objInfo.SNo = cnt + 1;
                                objInfo.BatchTimeId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.StartTime = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.EndTime = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.BatchTime = Convert.ToString(objInfo.StartTime.ToString("HH:mm") + " to " + objInfo.EndTime.ToString("HH:mm"));
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
                using (SqlCommand objCmd = new SqlCommand("BatchTime_Remove", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@BatchTimeId", Id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }



    }
}
