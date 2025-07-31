using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayerHelper
{
    public class clsTaskData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();

        public void AddUpdate(clsTask obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Task_AddUpdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@TaskId", obj.TaskId);
                    objCmd.Parameters.AddWithValue("@Task", obj.Task);
                    objCmd.Parameters.AddWithValue("@Description", obj.Description);
                    objCmd.Parameters.AddWithValue("@EmployeeId", obj.EmployeeId);
                    objCmd.Parameters.AddWithValue("@AssignedEmployeeId", obj.AssignedEmployeeId);
                    objCmd.Parameters.AddWithValue("@PriorityId", obj.PriorityId);
                    objCmd.Parameters.AddWithValue("@StatusId", obj.StatusId);
                    objCmd.Parameters.AddWithValue("@TaskStatusId", obj.TaskStatusId);
                    objCmd.Parameters.AddWithValue("@FileUploadPath", obj.FileUploadPath);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.Parameters.AddWithValue("@ModifiedBy", obj.ModifiedBy);

                    objCmd.ExecuteNonQuery();
                }
            }
        }

        public clsTask Load(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Task_Get", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@TaskId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsTask objInfo = new clsTask();
                            objInfo.TaskId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.Task = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.Description = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.EmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.AssignedEmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[4]);
                            objInfo.PriorityId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[5]);
                            objInfo.StatusId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[6]);
                            objInfo.TaskStatusId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[7]);
                            objInfo.FileUploadPath = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[8]);

                            objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[9]);
                           // objInfo.ModifiedBy = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[10]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }

        public List<clsTask> LoadAll(clsTask obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Task_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@keywords", obj.keywords);
                    objCmd.Parameters.AddWithValue("@EmployeeId", obj.EmployeeId);
                    objCmd.Parameters.AddWithValue("@AssignedEmployeeId", obj.AssignedEmployeeId);
                    objCmd.Parameters.AddWithValue("@PriorityId", obj.PriorityId);
                    objCmd.Parameters.AddWithValue("@StatusId", obj.StatusId);
                    objCmd.Parameters.AddWithValue("@TaskStatusId", obj.TaskStatusId);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);

                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsTask> objList = new List<clsTask>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsTask objInfo = new clsTask();
                                objInfo.SNo = cnt + 1;
                                objInfo.TaskId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Task = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.Description = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.EmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.AssignedEmployee = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.AssignedEmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.PriorityId = Convert.ToInt16(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.TaskStatusId = Convert.ToInt16(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.FileUploadPath = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objInfo.StatusId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[11]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[12] != DBNull.Value)
                                objInfo.ModifiedOn = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[12]);
                                objInfo.ModifiedBy = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[13]);


                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }
        public List<clsTask> LoadAllReports(clsTask obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Task_List_Report", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@keywords", obj.keywords);
                    objCmd.Parameters.AddWithValue("@AssignedEmployeeId", obj.AssignedEmployeeId);
                    objCmd.Parameters.AddWithValue("@PriorityId", obj.PriorityId);
                    objCmd.Parameters.AddWithValue("@StatusId", obj.StatusId);
                    objCmd.Parameters.AddWithValue("@TaskStatusId", obj.TaskStatusId);
                    objCmd.Parameters.AddWithValue("@FromDate", obj.FromDate);
                    objCmd.Parameters.AddWithValue("@ToDate", obj.ToDate);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);

                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsTask> objList = new List<clsTask>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsTask objInfo = new clsTask();
                                objInfo.SNo = cnt + 1;
                                objInfo.TaskId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Task = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.Description = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.EmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.AssignedEmployee = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.PriorityId = Convert.ToInt16(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.TaskStatusId = Convert.ToInt16(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.StatusId = Convert.ToInt16(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[10]);
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
                using (SqlCommand objCmd = new SqlCommand("Task_Remove", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@TaskId", Id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateStatus(clsTask obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Update tblTask Set StatusId = @StatusId, TaskStatusId = @TaskStatusId where TaskId = @TaskId", objConn))
                {
                    objConn.Open();
                    objCmd.Parameters.AddWithValue("@TaskId", obj.TaskId);
                    objCmd.Parameters.AddWithValue("@StatusId", obj.StatusId);
                    objCmd.Parameters.AddWithValue("@TaskStatusId", obj.TaskStatusId);
                    objCmd.ExecuteNonQuery();
                }
            }
        }
    }
}