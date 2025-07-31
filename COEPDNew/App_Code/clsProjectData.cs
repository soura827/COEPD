using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayerHelper
{
    public class clsProjectData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();

        public void AddUpdate(clsProject obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Project_AddUpdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ProjectId", obj.ProjectId);
                    objCmd.Parameters.AddWithValue("@Project", obj.Project);
                    objCmd.Parameters.AddWithValue("@ClientId", obj.ClientId);
                    objCmd.Parameters.AddWithValue("@Description", obj.Description);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.ExecuteNonQuery();
                }
            }
        }
        public clsProject Load(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Project_Get", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("ProjectId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsProject objInfo = new clsProject();
                            objInfo.ProjectId = Convert.ToInt32(objDset.Tables[0].Rows[0]["ProjectId"]);
                            objInfo.ClientId = Convert.ToInt32(objDset.Tables[0].Rows[0]["ClientId"]);
                            objInfo.Project = Convert.ToString(objDset.Tables[0].Rows[0]["Project"]);
                            objInfo.Description = Convert.ToString(objDset.Tables[0].Rows[0]["Description"]);
                            objInfo.Client = Convert.ToString(objDset.Tables[0].Rows[0]["Client"]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }

        public List<clsProject> LoadAll(clsProject obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Project_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@keywords", obj.keywords);
                    objCmd.Parameters.AddWithValue("@ClientId", obj.ClientId);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsProject> objList = new List<clsProject>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsProject objInfo = new clsProject();
                                objInfo.SNo = cnt + 1;
                                objInfo.ProjectId = Convert.ToInt32(objDset.Tables[0].Rows[cnt]["ProjectId"]);
                                objInfo.ClientId = Convert.ToInt32(objDset.Tables[0].Rows[cnt]["ClientId"]);
                                objInfo.Project = Convert.ToString(objDset.Tables[0].Rows[cnt]["Project"]);
                                objInfo.Description = Convert.ToString(objDset.Tables[0].Rows[cnt]["Description"]);
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

        public void Remove(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("Project_Remove", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ProjectId", Id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }

    }
}
