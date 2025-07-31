using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayerHelper
{
    public class clsParticipantModuleData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();

        //ParticipantModule
        //This method is used to Add and Update the ParticipantModule from ParticipantModule_AddUpdate.

        public void AddUpdate(clsParticipantModule obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ParticipantModule_AddUpdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ModuleId", obj.ModuleId);
                    objCmd.Parameters.AddWithValue("@Module", obj.Module);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.ExecuteNonQuery();
                }
            }
        }

        //ParticipantModule
        //This Method is used to get the ParticipantModule from Participant_Get StoredProcedure
        public clsParticipantModule Load(int Id)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ParticipantModule_Get", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("ModuleId", Id);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsParticipantModule objInfo = new clsParticipantModule();
                            objInfo.ModuleId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
                            objInfo.Module = Convert.ToString(objDset.Tables[0].Rows[0].ItemArray[1]);
                            return objInfo;
                        }
                    }
                    return null;
                }
            }
        }

        //ParticipantModule
        //This method is used to search and Load all Participant modules based on Keywords by using ParticipantModule_List .
        public List<clsParticipantModule> LoadAll(clsParticipantModule obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ParticipantModule_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@keywords", obj.keywords);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsParticipantModule> objList = new List<clsParticipantModule>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsParticipantModule objInfo = new clsParticipantModule();
                                objInfo.SNo = cnt + 1;
                                objInfo.ModuleId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.Module = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[2] != DBNull.Value)
                                    objInfo.CreatedOn = Convert.ToDateTime(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }

        //ParticipantModule
        //This method is not used  Now In future it will be Use.
        //This method is used to Remove the Module Based on ModulId.
        //        public void Remove(int Id)
        //        {
        //            using (SqlConnection objConn = new SqlConnection(Constr))
        //            {
        //                using (SqlCommand objCmd = new SqlCommand("ParticipantModule_Remove", objConn))
        //                {
        //                    objConn.Open();
        //                    objCmd.CommandType = CommandType.StoredProcedure;
        //                    objCmd.Parameters.AddWithValue("@ModuleId", Id);
        //                    objCmd.ExecuteNonQuery();
        //                }
        //            }
        //        }

    }
}
