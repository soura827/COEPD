using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayerHelper
{
    public class clsFeatureData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();
        //Employee Feature
        //This method is used to  Add and Update Employee Features in Feature_AddUpdate StoredProcedure. 
        public void AddUpdate(clsFeature obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Feature_AddUpdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@FeatureId", obj.FeatureId);
                    objCmd.Parameters.AddWithValue("@ModuleId", obj.ModuleId);
                    objCmd.Parameters.AddWithValue("@Feature", obj.Feature);
                    objCmd.Parameters.AddWithValue("@PageName", obj.PageName);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.ExecuteNonQuery();
                }
            }
        }

        //Employee Feature
        // This Method is used to Get Features of Employees from Feature_Get StoredProcedure.
        public clsFeature Load(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Feature_Get", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("FeatureId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsFeature objInfo = new clsFeature();
                            objInfo.FeatureId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.ModuleId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[1]);
                            objInfo.Feature = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[2]);
                            objInfo.PageName = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[3]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }
        //Employee Feature
        //This Method is used to Load All Features to Employees from Feature_List StoredProcedure.
        //Based on keywords,finding the features by used this method.
        //Based on ModuleId Loading the  FeatureId,Module,Features,PageName  into  gridview

        public List<clsFeature> LoadAll(clsFeature obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Feature_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@keywords", obj.keywords);
                    objCmd.Parameters.AddWithValue("@ModuleId", obj.ModuleId);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsFeature> objList = new List<clsFeature>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsFeature objInfo = new clsFeature();
                                objInfo.SNo = cnt + 1;
                                objInfo.FeatureId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Module = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.Feature = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.PageName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }

        //Employee Feature
        //This Method is  used to returns List of feature of a particular Module which are  not assigned to given Employee  from Feature_List_Assign.

        public List<clsFeature> LoadAllAvilable(clsFeature obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Feature_List_NotAssigned", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    //objCmd.Parameters.AddWithValue("@keywords", obj.keywords);
                    objCmd.Parameters.AddWithValue("@ModuleId", obj.ModuleId);
                    objCmd.Parameters.AddWithValue("@EmployeeId", obj.EmployeeId);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsFeature> objList = new List<clsFeature>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsFeature objInfo = new clsFeature();
                                objInfo.SNo = cnt + 1;
                                objInfo.FeatureId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Module = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.Feature = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.PageName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }
        //Employee Feature
        //This Method is used to Remove Feature to employees from Feature_Remove StoredProcedure.
        //This Method is not used now it will be  use in Feature Implementation.
        //public void Remove(int Id)
        //{
        //    using (SqlConnection objConn = new SqlConnection(Constr))
        //    {
        //        using (SqlCommand objCmd = new SqlCommand("Feature_Remove", objConn))
        //        {
        //            objConn.Open();
        //            objCmd.CommandType = CommandType.StoredProcedure;
        //            objCmd.Parameters.AddWithValue("@FeatureId", Id);
        //            objCmd.ExecuteNonQuery();
        //        }
        //    }
        //}
    }
}