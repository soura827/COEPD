using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayerHelper
{
    public class clsFeatureAccessData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();

        //This Method is used Add the Assigned Feature to Employees from FeatureAccess_AddUpdate StoredProcedure.
        public void AddUpdate(clsFeatureAccess obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("FeatureAccess_AddUpdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@FeatureAccessId", obj.FeatureAccessId);
                    objCmd.Parameters.AddWithValue("@EmployeeId", obj.EmployeeId);
                    objCmd.Parameters.AddWithValue("@FeatureId", obj.FeatureId);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.ExecuteNonQuery();
                }
            }
        }
        //This Method is not used now.
        // This Method is used to Get Assigned Feature to Employees from FeatureAccess_Get StoredProcedure.
        //public clsFeatureAccess Load(int Id)
        //{
        //    using (SqlConnection objConn = new SqlConnection(Constr))
        //    {
        //        using (SqlCommand objCmd = new SqlCommand("FeatureAccess_Get", objConn))
        //        {
        //            objConn.Open();
        //            objCmd.CommandType = CommandType.StoredProcedure;
        //            objCmd.Parameters.AddWithValue("@FeatureAccessId", Id);
        //            DataSet objDset = new DataSet();
        //            SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
        //            objAdp.Fill(objDset);
        //            if (objDset.Tables.Count > 0)
        //            {
        //                if (objDset.Tables[0].Rows.Count > 0)
        //                {
        //                    clsFeatureAccess objInfo = new clsFeatureAccess();
        //                    objInfo.FeatureAccessId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
        //                    objInfo.EmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[1]);
        //                    objInfo.FeatureId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[2]);
        //                    return objInfo;
        //                }
        //            }
        //            return null;
        //        }
        //    }
        //}

        //This Method is used to Load All assigned Features to one Employee and module from FeatureAccess_List StoredProcedure.
        //Keywords functionality not used now.
        public List<clsFeatureAccess> LoadAll(clsFeatureAccess obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("FeatureAccess_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    //objCmd.Parameters.AddWithValue("@keywords", obj.keywords);
                    objCmd.Parameters.AddWithValue("@EmployeeId", obj.EmployeeId);
                    objCmd.Parameters.AddWithValue("@ModuleId", obj.ModuleId);
                    objCmd.Parameters.AddWithValue("@FeatureId", obj.FeatureId);
                    objCmd.Parameters.AddWithValue("@DesignationId", obj.DesignationId);
                    objCmd.Parameters.AddWithValue("@LocationId", obj.LocationId);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsFeatureAccess> objList = new List<clsFeatureAccess>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsFeatureAccess objInfo = new clsFeatureAccess();
                                objInfo.SNo = cnt + 1;
                                objInfo.FeatureAccessId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.EmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.FeatureId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.Feature = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.PageName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.ModuleId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.Module = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.Designation = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[8]);
                                objInfo.Location = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[9]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }
        //This Method is used to Remove Assigned Feature to one employee from FeatureAccess_Remove StoredProcedure.
        public void Remove(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("FeatureAccess_Remove", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@FeatureAccessId", Id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }

        //This Method is used in Employee Dashboard.aspx.cs
        //This Method is used to check the assigned Feature displayed when Employee logged in. 
        public int FeaturePageValidation(clsFeatureAccess obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("FeaturePageValidation", objConn))
                {

                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@EmployeeId", obj.EmployeeId);
                    objCmd.Parameters.AddWithValue("@PageName", obj.PageName);
                    int Id = Convert.ToInt32(objCmd.ExecuteScalar());
                    return Id;
                }
            }
        }
        //This method is used to Send mail Assigned feature to the Employee.
        public virtual clsFeatureAccess LoadEmployeeAssignedFeatures(int EmployeeId)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("EmployeeAssignedFeatures_SendEmail", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("EmployeeId", EmployeeId);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsFeatureAccess objInfo = new clsFeatureAccess();
                            objInfo.Feature = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[0]);
                            return objInfo;
                        }
                    }
                    return null;

                }
            }
        }
    }
}