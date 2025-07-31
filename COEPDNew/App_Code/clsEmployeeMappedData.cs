using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayerHelper
{
    public class clsEmployeeMappedData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();

        public clsEmployeeMapped Load(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("EmployeeMapped_Get", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("EmployeeMappedId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsEmployeeMapped objInfo = new clsEmployeeMapped();
                            objInfo.EmployeeMappedId = Convert.ToInt32(objDset.Tables[0].Rows[0]["EmployeeMappedId"]);
                            objInfo.EmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[0]["EmployeeId"]);
                            objInfo.ParentEmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[0]["ParentEmployeeId"]);
                            objInfo.IsAssigned = Convert.ToBoolean(objDset.Tables[0].Rows[0]["IsAssigned"]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }

 


        public List<clsEmployeeMapped> Hierarchy(clsEmployeeMapped obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("EmpList_Hierarchy", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@EmployeeId", obj.EmployeeId);

                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsEmployeeMapped> objList = new List<clsEmployeeMapped>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsEmployeeMapped objInfo = new clsEmployeeMapped();
                                objInfo.SNo = cnt + 1;
                                objInfo.EmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[cnt]["EmployeeId"]);
                                objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[cnt]["Employee"]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }

        public List<clsEmployeeMapped> UnAssignedList(clsEmployeeMapped obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("EmployeeMapped_UnAssignedList", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@keywords", obj.keywords);
                    objCmd.Parameters.AddWithValue("@EmployeeId", obj.EmployeeId);
                    objCmd.Parameters.AddWithValue("@DesignationId", obj.DesignationId);

                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsEmployeeMapped> objList = new List<clsEmployeeMapped>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsEmployeeMapped objInfo = new clsEmployeeMapped();
                                objInfo.SNo = cnt + 1;
                                objInfo.EmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////







        public List<clsEmployeeMapped> ReportingManagerHistoryLoadAll(clsEmployeeMapped obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ReportingManagerHistory_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ReportingTeam", obj.ReportingTeam);
                    objCmd.Parameters.AddWithValue("@ReportingManager", obj.ReportingManager);
                    objCmd.Parameters.AddWithValue("@AssignedBy", obj.AssignedBy);
                    objCmd.Parameters.AddWithValue("@FromDate", obj.FromDate);
                    objCmd.Parameters.AddWithValue("@ToDate", obj.ToDate);

                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsEmployeeMapped> objList = new List<clsEmployeeMapped>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsEmployeeMapped objInfo = new clsEmployeeMapped();
                                objInfo.SNo = cnt + 1;
                                objInfo.EmployeeMappedId = Convert.ToInt32(objDset.Tables[0].Rows[cnt]["EmployeeMappedId"]);
                                objInfo.EmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[cnt]["EmployeeId"]);
                                objInfo.ParentEmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[cnt]["ParentEmployeeId"]);
                                objInfo.IsAssigned = Convert.ToBoolean(objDset.Tables[0].Rows[cnt]["IsAssigned"]);

                                objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[cnt]["IsActive"]);
                                objInfo.IsDeleted = Convert.ToBoolean(objDset.Tables[0].Rows[cnt]["IsDeleted"]);
                                objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt]["CreatedOn"]);
                                objInfo.CreatedBy = Convert.ToInt32(objDset.Tables[0].Rows[cnt]["CreatedBy"]);
                                objInfo.IsRecordLatest = Convert.ToBoolean(objDset.Tables[0].Rows[cnt]["IsActive"]);


                                objInfo.ReportingTeam = Convert.ToString(objDset.Tables[0].Rows[cnt]["ReportingTeam"]);
                                objInfo.ReportingManager = Convert.ToString(objDset.Tables[0].Rows[cnt]["ReportingManager"]);
                                objInfo.AssignedBy = Convert.ToString(objDset.Tables[0].Rows[cnt]["AssignedBy"]);



                                
                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }

        public List<clsEmployeeMapped> UnAssignedEmployeeList(clsEmployeeMapped obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("EmployeeMapped_UnAssignedEmployeeList", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@keywords", obj.keywords);
                    objCmd.Parameters.AddWithValue("@IsVerticalHead", obj.IsVerticalHead);
                    objCmd.Parameters.AddWithValue("@IsReportingManager", obj.IsReportingManager);
                    objCmd.Parameters.AddWithValue("@IsReportingTo", obj.IsReportingTo);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsEmployeeMapped> objList = new List<clsEmployeeMapped>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsEmployeeMapped objInfo = new clsEmployeeMapped();
                                objInfo.SNo = cnt + 1;
                                objInfo.EmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }
        public void AddUpdate(clsEmployeeMapped obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("EmployeeMapped_AddUpdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@EmployeeMappedId", obj.EmployeeMappedId);
                    objCmd.Parameters.AddWithValue("@EmployeeId", obj.EmployeeId);
                    objCmd.Parameters.AddWithValue("@ParentEmployeeId", obj.ParentEmployeeId);
                    objCmd.Parameters.AddWithValue("@IsAssigned", obj.IsAssigned);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.ExecuteNonQuery();
                }
            }
        }








        public void Remove(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("EmployeeMapped_Remove", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@EmployeeMappedId", Id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }





        public void AddUpdates(clsEmployeeMapped obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ReportingManagerEmployeeMapped_AddUpdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ReportingEmployeeMappedId", obj.ReportingEmployeeMappedId);
                    objCmd.Parameters.AddWithValue("@ReportingManagerEmployeeId ", obj.ReportingManagerEmployeeId);
                    objCmd.Parameters.AddWithValue("@VerticalHeadEmployeeId", obj.VerticalHeadEmployeeId);
                    objCmd.Parameters.AddWithValue("@IsAssigned", obj.IsAssigned);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.ExecuteNonQuery();
                }
            }
        }
        public void ReportingRemove(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ReportingEmployeeMapped_Remove", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ReportingEmployeeMappedId", Id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }

        public List<clsEmployeeMapped> ReportingLoadAll(clsEmployeeMapped obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ReportingEmployeeMapped_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@keywords", obj.keywords);
                    objCmd.Parameters.AddWithValue("@EmployeeId", obj.EmployeeId);

                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsEmployeeMapped> objList = new List<clsEmployeeMapped>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsEmployeeMapped objInfo = new clsEmployeeMapped();
                                objInfo.SNo = cnt + 1;
                                objInfo.ReportingEmployeeMappedId = Convert.ToInt32(objDset.Tables[0].Rows[cnt]["ReportingEmployeeMappedId"]);
                                objInfo.ReportingManagerEmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[cnt]["ReportingManagerEmployeeId"]);
                                objInfo.VerticalHeadEmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[cnt]["VerticalHeadEmployeeId"]);
                                objInfo.IsAssigned = Convert.ToBoolean(objDset.Tables[0].Rows[cnt]["IsAssigned"]);
                                objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[cnt]["Employee"]);
                                objInfo.OfficeEmail = Convert.ToString(objDset.Tables[0].Rows[cnt]["OfficeEmail"]);
                                objInfo.CUGMobile = Convert.ToString(objDset.Tables[0].Rows[cnt]["CUGMobile"]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }






        public List<clsEmployeeMapped> LoadAll(clsEmployeeMapped obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("EmployeeMapped_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@keywords", obj.keywords);
                    objCmd.Parameters.AddWithValue("@EmployeeId", obj.EmployeeId);

                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsEmployeeMapped> objList = new List<clsEmployeeMapped>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsEmployeeMapped objInfo = new clsEmployeeMapped();
                                objInfo.SNo = cnt + 1;
                                objInfo.EmployeeMappedId = Convert.ToInt32(objDset.Tables[0].Rows[cnt]["EmployeeMappedId"]);
                                objInfo.EmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[cnt]["EmployeeId"]);
                                objInfo.ParentEmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[cnt]["ParentEmployeeId"]);
                                objInfo.IsAssigned = Convert.ToBoolean(objDset.Tables[0].Rows[cnt]["IsAssigned"]);
                                objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[cnt]["Employee"]);
                                //objInfo.OfficeEmail = Convert.ToString(objDset.Tables[0].Rows[cnt]["OfficeEmail"]);
                                //objInfo.CUGMobile = Convert.ToString(objDset.Tables[0].Rows[cnt]["CUGMobile"]);
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
