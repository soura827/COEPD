using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayerHelper
{
    public class clsNurturingProcessStageTaskAccessData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();
        public void AddUpdate(clsNurturingProcessStageTaskAccess obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("NurturingProcessStageTaskAccess_AddUpdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@NurturingProcessStageTaskAccessId", obj.NurturingProcessStageTaskAccessId);
                    objCmd.Parameters.AddWithValue("@EmployeeId", obj.EmployeeId);
                    objCmd.Parameters.AddWithValue("@NurturingProcessStageTaskId", obj.NurturingProcessStageTaskId);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.Parameters.AddWithValue("@TaskPriority", obj.TaskPriority);
                    objCmd.ExecuteNonQuery();
                }
            }
        }

        public clsNurturingProcessStageTaskAccess Load(int id)
        {
            using (SqlConnection objconn = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("NurturingProcessStageTaskAccess_Get", objconn))
                {
                    objconn.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@NurturingProcessStageTaskAccessId", id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objcmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsNurturingProcessStageTaskAccess objInfo = new clsNurturingProcessStageTaskAccess();
                            objInfo.NurturingProcessStageTaskAccessId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.EmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.NurturingProcessStageTaskId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[2]);
                            if (objDset.Tables[0].Rows[0].ItemArray[3] != DBNull.Value)
                                objInfo.TaskPriority = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[3]);
                            return objInfo;
                        }
                    }
                    return null;
                }

            }

        }
        public List<clsNurturingProcessStageTaskAccess> LoadAll(clsNurturingProcessStageTaskAccess obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("NurturingProcessStageTaskAccess_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    //objCmd.Parameters.AddWithValue("@keywords", obj.keywords);
                    objCmd.Parameters.AddWithValue("@EmployeeId", obj.EmployeeId);
                    objCmd.Parameters.AddWithValue("@NurturingProcessStageId", obj.NurturingProcessStageId);
                    objCmd.Parameters.AddWithValue("@NurturingProcessStageName", obj.NurturingProcessStageName);
                    objCmd.Parameters.AddWithValue("@NurturingProcessStageTaskName", obj.NurturingProcessStageTaskName);
                    objCmd.Parameters.AddWithValue("@Employee", obj.Employee);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsNurturingProcessStageTaskAccess> objList = new List<clsNurturingProcessStageTaskAccess>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsNurturingProcessStageTaskAccess objInfo = new clsNurturingProcessStageTaskAccess();
                                objInfo.SNo = cnt + 1;
                                objInfo.NurturingProcessStageTaskAccessId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.EmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.NurturingProcessStageTaskId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.NurturingProcessStageTaskName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.NurturingProcessStageId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.NurturingProcessStageName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[6] != DBNull.Value)
                                    objInfo.TaskPriority = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[7]);
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
                using (SqlCommand objCmd = new SqlCommand("NurturingProcessStageTaskAccess_Remove", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@NurturingProcessStageTaskAccessId", Id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }
    }
}
