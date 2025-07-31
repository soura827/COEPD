using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace DataAccessLayerHelper
{
    public class clsEmployeeLogInLogOutReportData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();
        public void AddUpdate(clsEmployeeLogInLogOutReport obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("EmployeeLogInLogOutReport_AddUpdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@EmployeeLogInLogOutReportId", obj.EmployeeLogInLogOutReportId);
                    objCmd.Parameters.AddWithValue("@EmployeeId", obj.EmployeeId);
                    objCmd.Parameters.AddWithValue("@Date", obj.Date);
                    objCmd.Parameters.AddWithValue("@StartTime", obj.StartTime);
                    objCmd.Parameters.AddWithValue("@EndTime", obj.EndTime);
                    objCmd.Parameters.AddWithValue("@LoginIPAddress", obj.LoginIPAddress);
                    objCmd.Parameters.AddWithValue("@LogoutIPAddress", obj.LogoutIPAddress);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.ExecuteNonQuery();
                }
            }
        }
        public clsEmployeeLogInLogOutReport Load(clsEmployeeLogInLogOutReport obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("EmployeeLogInLogOutReport_Get", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@EmployeeId", obj.EmployeeId);
                    objCmd.Parameters.AddWithValue("@Date", obj.Date);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsEmployeeLogInLogOutReport objInfo = new clsEmployeeLogInLogOutReport();
                            objInfo.EmployeeLogInLogOutReportId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.EmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.Date = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.StartTime = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[3]);
                            if (objDset.Tables[0].Rows[0].ItemArray[4] != DBNull.Value)
                                objInfo.EndTime = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[4]);
                            objInfo.LoginIPAddress = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[5]);
                            if (objDset.Tables[0].Rows[0].ItemArray[6] != DBNull.Value)
                                objInfo.LogoutIPAddress = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[6]);
                            objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[7]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }
        public List<clsEmployeeLogInLogOutReport> LoadAll(clsEmployeeLogInLogOutReport obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("EmployeeLogInLogOutReport_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@keywords", obj.Keywords);
                    objCmd.Parameters.AddWithValue("@Branch", obj.Branch);
                    objCmd.Parameters.AddWithValue("@FromDate", obj.FromDate);
                    objCmd.Parameters.AddWithValue("@ToDate", obj.ToDate);
                    objCmd.Parameters.AddWithValue("@UserId", obj.UserId);

                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsEmployeeLogInLogOutReport> objList = new List<clsEmployeeLogInLogOutReport>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsEmployeeLogInLogOutReport objInfo = new clsEmployeeLogInLogOutReport();
                                objInfo.SNo = cnt + 1;
                                objInfo.EmployeeLogInLogOutReportId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.EmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.Date = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.StartTime = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[4] != DBNull.Value)
                                    objInfo.EndTime = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.LoginIPAddress = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[6] != DBNull.Value)
                                    objInfo.LogoutIPAddress = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.Code = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.Branch = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objInfo.Designation = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[10]);
                                objInfo.UserId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[11]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[12] != DBNull.Value)
                                    objInfo.Duration = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[12]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }



        public clsEmployeeLogInLogOutReport Loadfew(int id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("LoginLogoutGet", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@Userid", id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsEmployeeLogInLogOutReport objInfo = new clsEmployeeLogInLogOutReport();
                            objInfo.UserId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }


    }
}
