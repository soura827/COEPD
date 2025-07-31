using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace DataAccessLayerHelper
{
    public class clsTimeSheetData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();

        public void AddUpdate(clsTimeSheet obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("TimeSheet_AddUpdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@TimeSheetId", obj.TimeSheetId);
                    objCmd.Parameters.AddWithValue("@EmployeeId", obj.EmployeeId);
                    objCmd.Parameters.AddWithValue("@StartTime", obj.StartTime);
                    objCmd.Parameters.AddWithValue("@EndTime", obj.EndTime);
                    objCmd.Parameters.AddWithValue("@Note", obj.Note);
                    objCmd.Parameters.AddWithValue("@ProjectId", obj.ProjectId);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.Parameters.AddWithValue("@Date", obj.Date);
                    objCmd.ExecuteNonQuery();
                }
            }
        }
        public clsTimeSheet Load(int Id)
        {
            using (SqlConnection objconn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("TimeSheet_Get", objconn))
                {
                    objconn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@TimeSheetId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsTimeSheet objInfo = new clsTimeSheet();
                            objInfo.TimeSheetId = Convert.ToInt32(objDset.Tables[0].Rows[0]["TimeSheetId"]);
                            objInfo.EmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[0]["EmployeeId"]);
                            objInfo.Date = Convert.ToDateTime(objDset.Tables[0].Rows[0]["Date"]);
                            objInfo.StartTime = Convert.ToDateTime(objDset.Tables[0].Rows[0]["StartTime"]);
                            if (objDset.Tables[0].Rows[0]["EndTime"] != DBNull.Value)
                                objInfo.EndTime = Convert.ToDateTime(objDset.Tables[0].Rows[0]["EndTime"]);
                            objInfo.Note = Convert.ToString(objDset.Tables[0].Rows[0]["Note"]);
                            objInfo.ProjectId = Convert.ToInt32(objDset.Tables[0].Rows[0]["ProjectId"]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }
        public List<clsTimeSheet> LoadAll(clsTimeSheet obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("TimeSheet_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@keywords", obj.keywords);
                    objCmd.Parameters.AddWithValue("@EmployeeId", obj.EmployeeId);
                    objCmd.Parameters.AddWithValue("@Date", obj.Date);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsTimeSheet> objList = new List<clsTimeSheet>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsTimeSheet objInfo = new clsTimeSheet();
                                objInfo.SNo = cnt + 1;
                                objInfo.TimeSheetId = Convert.ToInt32(objDset.Tables[0].Rows[cnt]["TimeSheetId"]);
                                objInfo.EmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[cnt]["EmployeeId"]);
                                objInfo.Date = Convert.ToDateTime(objDset.Tables[0].Rows[cnt]["Date"]);
                                objInfo.StartTime = Convert.ToDateTime(objDset.Tables[0].Rows[cnt]["StartTime"]);
                                if (objDset.Tables[0].Rows[cnt]["CreatedOn"] != DBNull.Value)
                                    objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt]["CreatedOn"]);
                                if (objDset.Tables[0].Rows[cnt]["EndTime"] != DBNull.Value)
                                    objInfo.EndTime = Convert.ToDateTime(objDset.Tables[0].Rows[cnt]["EndTime"]);
                                if (objDset.Tables[0].Rows[cnt]["ModifiedOn"] != DBNull.Value)
                                    objInfo.ModifiedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt]["ModifiedOn"]);
                                objInfo.Client = Convert.ToString(objDset.Tables[0].Rows[cnt]["Client"]);
                                objInfo.Project = Convert.ToString(objDset.Tables[0].Rows[cnt]["Project"]);
                                objInfo.Note = Convert.ToString(objDset.Tables[0].Rows[cnt]["Note"]);
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
                using (SqlCommand objCmd = new SqlCommand("TimeSheet_Remove", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@TimeSheetId", Id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }

        public List<clsTimeSheet> LoadAllReports(clsTimeSheet obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("TimeSheet_List_Reports", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@keywords", obj.keywords);
                    objCmd.Parameters.AddWithValue("@EmployeeId", obj.EmployeeId);
                    objCmd.Parameters.AddWithValue("@ClientId", obj.ClientId);
                    objCmd.Parameters.AddWithValue("@ProjectId", obj.ProjectId);
                    objCmd.Parameters.AddWithValue("@FromDate", obj.FromDate);
                    objCmd.Parameters.AddWithValue("@ToDate", obj.ToDate);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsTimeSheet> objList = new List<clsTimeSheet>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsTimeSheet objInfo = new clsTimeSheet();
                                objInfo.SNo = cnt + 1;
                                objInfo.TimeSheetId = Convert.ToInt32(objDset.Tables[0].Rows[cnt]["TimeSheetId"]);
                                objInfo.EmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[cnt]["EmployeeId"]);
                                objInfo.Date = Convert.ToDateTime(objDset.Tables[0].Rows[cnt]["Date"]);
                                objInfo.StartTime = Convert.ToDateTime(objDset.Tables[0].Rows[cnt]["StartTime"]);
                                if (objDset.Tables[0].Rows[cnt]["EndTime"] != DBNull.Value)
                                    objInfo.EndTime = Convert.ToDateTime(objDset.Tables[0].Rows[cnt]["EndTime"]);
                                objInfo.Project = Convert.ToString(objDset.Tables[0].Rows[cnt]["Project"]);
                                objInfo.Note = Convert.ToString(objDset.Tables[0].Rows[cnt]["Note"]);
                                objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[cnt]["Employee"]);
                                objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt]["CreatedOn"]);
                                if (objDset.Tables[0].Rows[cnt]["ModifiedOn"] != DBNull.Value)
                                    objInfo.ModifiedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt]["ModifiedOn"]);
                                objInfo.Client = Convert.ToString(objDset.Tables[0].Rows[cnt]["Client"]);
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