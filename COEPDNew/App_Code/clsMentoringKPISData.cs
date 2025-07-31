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
    public class clsMentoringKPISData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();
        public void AddUpdate(clsMentoringKPIS obj)
        {
            using (SqlConnection objconn = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("MentoringKPIS_AddUpdate", objconn))
                {
                    objconn.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@MentorId", obj.MentorId);
                    objcmd.Parameters.AddWithValue("@EmployeeId", obj.EmployeeId);
                    objcmd.Parameters.AddWithValue("@BranchId", obj.BranchId);
                    objcmd.Parameters.AddWithValue("@DesignationId", obj.DesignationId);
                    objcmd.Parameters.AddWithValue("@KPIId", obj.KPIId);
                    objcmd.Parameters.AddWithValue("@Tragets", obj.Tragets);
                    objcmd.Parameters.AddWithValue("@CreatedBy ", obj.CreatedBy);
                    objcmd.ExecuteNonQuery();
                }
            }
        }
        public List<clsMentoringKPIS> LoadALL(clsMentoringKPIS obj)
        {

            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("MentoringKPIS_List", objConn))
                {
                    objConn.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@KPIName", obj.KPIName);
                    objcmd.Parameters.AddWithValue("@Employee", obj.Employee);
                    //objcmd.Parameters.AddWithValue("@CreatedName", obj.CreatedName);
                    //objcmd.Parameters.AddWithValue("@ModifiedName", obj.ModifiedName);
                    //objcmd.Parameters.AddWithValue("@Branch", obj.Branch);
                    //objcmd.Parameters.AddWithValue("@Designation", obj.Designation);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objcmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {

                            List<clsMentoringKPIS> objList = new List<clsMentoringKPIS>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsMentoringKPIS objInfo = new clsMentoringKPIS();
                                objInfo.Sno = cnt + 1;
                                objInfo.MentorId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.Branch = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.Designation = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.KPIName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.Tragets = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[5]);

                                if (objDset.Tables[0].Rows[cnt].ItemArray[6] != DBNull.Value)
                                    objInfo.ModifiedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[6]);

                                if (objDset.Tables[0].Rows[cnt].ItemArray[7] != DBNull.Value)
                                    objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                               
                                

                                
                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }

        public List<clsMentoringKPIS> LoadAllMentor(clsMentoringKPIS obj)
        {

            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("MentorIndividualDeltails_List", objConn))
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
                            List<clsMentoringKPIS> objList = new List<clsMentoringKPIS>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsMentoringKPIS objInfo = new clsMentoringKPIS();
                                objInfo.Sno = cnt + 1;
                                objInfo.MentorId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Employee = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.Branch = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.Designation = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.KPIName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                objInfo.Tragets = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[5]);

                                if (objDset.Tables[0].Rows[cnt].ItemArray[6] != DBNull.Value)
                                    objInfo.ModifiedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[7] != DBNull.Value)
                                    objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[7]);
                                objInfo.UserId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[8]);

                                objInfo.EmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[9]);

                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }


        public clsMentoringKPIS LoadMentor(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("MentorsKPISIndividual_Get", objConn))
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
                            clsMentoringKPIS objInfo = new clsMentoringKPIS();
                            objInfo.UserId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            return objInfo;
                        }

                    }
                    return null;

                }

            }


        }


        public clsMentoringKPIS Load(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objcmd = new SqlCommand("MentoringKPIS_Get", objConn))
                {
                    objConn.Open();
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@MentorId", Id);

                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objcmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                                clsMentoringKPIS objInfo = new clsMentoringKPIS();

                                objInfo.MentorId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);

                            if (objDset.Tables[0].Rows[0].ItemArray[1] != DBNull.Value)
                                objInfo.EmployeeId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[1]);
                            if (objDset.Tables[0].Rows[0].ItemArray[2] != DBNull.Value)
                                objInfo.BranchId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[2]);
                            if (objDset.Tables[0].Rows[0].ItemArray[3] != DBNull.Value)
                                objInfo.DesignationId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[3]);
                            if (objDset.Tables[0].Rows[0].ItemArray[4] != DBNull.Value)
                                objInfo.KPIId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[4]);

                               objInfo.Tragets = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[5]);
                             

                                return objInfo;
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
                using (SqlCommand objCmd = new SqlCommand("KPISMentor_Remove", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@MentorId", Id);
                    objCmd.ExecuteNonQuery();
                }
            }
        }

    }
}