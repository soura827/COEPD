using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace DataAccessLayerHelper
{
    public class clsBatchData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();

        public void AddUpdate(clsBatch obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Batch_AddUpdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@BatchId", obj.BatchId);
                    objCmd.Parameters.AddWithValue("@StartDate", obj.StartDate);
                    objCmd.Parameters.AddWithValue("@CourseId", obj.CourseId);
                    objCmd.Parameters.AddWithValue("@BatchTypeId", obj.BatchTypeId);
                    objCmd.Parameters.AddWithValue("@LocationId", obj.LocationId);
                    objCmd.Parameters.AddWithValue("@StatusId", obj.StatusId);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.Parameters.AddWithValue("@EmployeeId", obj.EmployeeId);
                    objCmd.Parameters.AddWithValue("@BatchTimeId", obj.BatchTimeId);
                    objCmd.ExecuteNonQuery();
                }
            }
        }

        public clsBatch Load(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Batch_Get", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@BatchId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsBatch objInfo = new clsBatch();
                            objInfo.BatchId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.StartDate = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.CourseId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.BatchTypeId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.LocationId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[4]);
                            objInfo.EmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[5]);
                            objInfo.BatchTimeId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[6]);
                            objInfo.StatusId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[7]);
                            objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[8]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }
        public List<clsBatch> LoadAll(clsBatch obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Batch_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@keywords", obj.keywords);
                    objCmd.Parameters.AddWithValue("@CourseId", obj.CourseId);
                    objCmd.Parameters.AddWithValue("@BatchTypeId", obj.BatchTypeId);
                    objCmd.Parameters.AddWithValue("@LocationId", obj.LocationId);
                    objCmd.Parameters.AddWithValue("@EmployeeId", obj.EmployeeId);
                    objCmd.Parameters.AddWithValue("@BatchTimeId", obj.BatchTimeId);
                    objCmd.Parameters.AddWithValue("@StatusId", obj.StatusId);


                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);

                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsBatch> objList = new List<clsBatch>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsBatch objInfo = new clsBatch();
                                objInfo.SNo = cnt + 1;
                                objInfo.BatchId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.StartDate = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.Batch = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.CourseId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.Course = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.BatchTypeId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.BatchType = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.LocationId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.Location = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.EmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                objInfo.StartTime = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[11]);
                                objInfo.EndTime = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[12]);
                                objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[cnt].ItemArray[13]);
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
                using (SqlCommand objCmd = new SqlCommand("Batch_Remove", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@BatchId", Id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }

        public clsBatch LoadParticipantByBatch(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Batch_Get_ParticipantNurture", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@BatchId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsBatch objInfo = new clsBatch();
                            objInfo.BatchId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.Course = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.BatchType = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.Location = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[4]);
                            objInfo.StartDate = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[5]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }
    }
}

