using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace DataAccessLayerHelper
{
    public class clsStatisticsData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();
        public void AddUpdate(clsStatistics obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Statistics_AddUpdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@StatisticsId", obj.StatisticsId);
                    objCmd.Parameters.AddWithValue("@BatchesCompleted", obj.BatchesCompleted);
                    objCmd.Parameters.AddWithValue("@StudentsTrained", obj.StudentsTrained);
                    objCmd.Parameters.AddWithValue("@Placements", obj.Placements);
                    objCmd.Parameters.AddWithValue("@Corporates", obj.Corporates);
                    objCmd.Parameters.AddWithValue("@BSchools", obj.BSchools);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.ExecuteNonQuery();
                }
            }
        }

        public clsStatistics Load(int Id)
        {
            using (SqlConnection objconn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Statistics_Get", objconn))
                {
                    objconn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@StatisticsId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsStatistics objInfo = new clsStatistics();
                            objInfo.StatisticsId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.BatchesCompleted = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.StudentsTrained = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.Placements = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.Corporates = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[4]);
                            objInfo.BSchools = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[5]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }

        public List<clsStatistics> LoadAll(clsStatistics obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Statistics_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@keywords", obj.Keywords);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsStatistics> objList = new List<clsStatistics>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsStatistics objInfo = new clsStatistics();
                                objInfo.SNo = cnt + 1;
                                objInfo.StatisticsId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.BatchesCompleted = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.StudentsTrained = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.Placements = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.Corporates = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.BSchools = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[5]);
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
                using (SqlCommand objCmd = new SqlCommand("Statistics_Remove", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@StatisticsId", Id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }
    }
}
