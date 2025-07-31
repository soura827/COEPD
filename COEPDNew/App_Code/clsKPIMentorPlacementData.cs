using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using BusinessLayer;

namespace DataAccessLayerHelper
{
    public class clsKPIMentorPlacementData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs10"].ConnectionString.ToString();

        public void AddUpdate(clsKPIMentorPlacement obj)
        {
            using (SqlConnection objconn = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("KPISMonthlyTarget_AddUpdate", objconn))
                {
                    objconn.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@EmployeeKPIId", obj.EmployeeKPIId);
                    objcmd.Parameters.AddWithValue("@Employee", obj.Employee);
                    objcmd.Parameters.AddWithValue("@DesignationId", obj.DesignationId);
                    objcmd.Parameters.AddWithValue("@KPIApplicableToId", obj.KPIApplicableToId);
                    objcmd.Parameters.AddWithValue("@KPIName", obj.KPIName);
                    objcmd.Parameters.AddWithValue("@MonthlyTarget", obj.MonthlyTarget);
                    objcmd.Parameters.AddWithValue("@Achieved", obj.Achieved);
                    objcmd.Parameters.AddWithValue("@CreatedBy ", obj.CreatedBy);
                    objcmd.Parameters.AddWithValue("@EmployeeId ", obj.EmployeeId);
                    objcmd.ExecuteNonQuery();
                }
            }
        }

        public clsKPIMentorPlacement Load(int Id)
        {
            using (SqlConnection objconn = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("KPIMonthlyTarget_Get", objconn))
                {
                    objconn.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("EmployeeKPIId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objcmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)  
                        {
                            clsKPIMentorPlacement objInfo = new clsKPIMentorPlacement();

                            objInfo.EmployeeKPIId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.DesignationId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.KPIName = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[3]);
                            objInfo.MonthlyTarget = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[4]);
                            objInfo.IsActive = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[5]);
                            objInfo.IsDeleted = Convert.ToBoolean(objDset.Tables[0].Rows[0].ItemArray[6]);
                            objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[7]);
                            objInfo.CreatedBy = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[8]);

                            if (objDset.Tables[0].Rows[0].ItemArray[9] != DBNull.Value)
                                objInfo.ModifiedOn = Convert.ToDateTime(objDset.Tables[0].Rows[0].ItemArray[9]);

                            if (objDset.Tables[0].Rows[0].ItemArray[10] != DBNull.Value)
                                objInfo.ModifiedBy = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[10]);
                            return objInfo;
                        }

                    }
                    return null;
                }
            }
        }


        public List<clsKPIMentorPlacement> LoadAll(clsKPIMentorPlacement obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("KPIMonthlyTarget_List", objConn))
                {
                    objConn.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;

                    objcmd.Parameters.AddWithValue("@CreatedName", obj.CreatedName);
                    objcmd.Parameters.AddWithValue("@ModifiedName", obj.ModifiedName);
                    objcmd.Parameters.AddWithValue("@Employee", obj.Employee);
                    objcmd.Parameters.AddWithValue("@KPIName", obj.KPIName);
                    objcmd.Parameters.AddWithValue("@KPIApplicableTo", obj.KPIApplicableTo);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objcmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsKPIMentorPlacement> objList = new List<clsKPIMentorPlacement>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsKPIMentorPlacement objInfo = new clsKPIMentorPlacement();
                                objInfo.Sno = cnt + 1;
                                objInfo.EmployeeKPIId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.Designation = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.KPIName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.MonthlyTarget = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[4]);

                                if (objDset.Tables[0].Rows[cnt].ItemArray[5] != DBNull.Value)
                                    objInfo.CreatedName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[5]);

                                if (objDset.Tables[0].Rows[cnt].ItemArray[6] != DBNull.Value)
                                    objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[6]);

                                if (objDset.Tables[0].Rows[cnt].ItemArray[7] != DBNull.Value)
                                    objInfo.ModifiedName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[7]);

                                if (objDset.Tables[0].Rows[cnt].ItemArray[8] != DBNull.Value)
                                    objInfo.ModifiedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.KPIApplicableTo = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objList.Add(objInfo);

                            }
                            return objList;
                        }
                    }

                }
                return null;
            }

        }
        public clsKPIMentorPlacement LoadUsers(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("LoginLogoutGet", objConn))
                {
                    objConn.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@UserId", Id);

                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objcmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsKPIMentorPlacement objInfo = new clsKPIMentorPlacement();
                            objInfo.UserId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            return objInfo;
                        }

                    }
                    return null;

                }

            }
        }

        public List<clsKPIMentorPlacement> LoadAllUsers(clsKPIMentorPlacement obj)
        {

            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("IndividualDeltails_List", objConn))
                {
                    objConn.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@UserId", obj.UserId);
                    objcmd.Parameters.AddWithValue("@EmployeeId", obj.EmployeeId);

                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objcmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsKPIMentorPlacement> objList = new List<clsKPIMentorPlacement>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsKPIMentorPlacement objInfo = new clsKPIMentorPlacement();
                                objInfo.Sno = cnt + 1;
                                objInfo.EmployeeKPIId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.Designation = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.KPIName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.MonthlyTarget = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[4]);

                                if (objDset.Tables[0].Rows[cnt].ItemArray[5] != DBNull.Value)
                                    objInfo.ModifiedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[6] != DBNull.Value)
                                    objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                 objInfo.UserId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[7]);

                                objInfo.EmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.Achieved = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[9]);

                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }

        public void Remove(int id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("KPISMonthlyTarget_Remove", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("EmployeeKPIId", id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }

    }
}