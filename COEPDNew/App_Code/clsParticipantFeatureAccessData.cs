using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayerHelper
{

    public class clsParticipantFeatureAccessData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();

        //This method is using Add Assign Feature to Participant from ParticipantFeatureAccess_AddUpdate. 
        public void AddUpdate(clsParticipantFeatureAccess obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ParticipantFeatureAccess_AddUpdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@FeatureAccessId", obj.FeatureAccessId);
                    objCmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    objCmd.Parameters.AddWithValue("@FeatureId", obj.FeatureId);
                    objCmd.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                    objCmd.ExecuteNonQuery();
                }
            }
        }

        //This method is used to get the Assigned Features to Participant from ParticipantFeatureAccess_Get
        //Now This Method is not used ,In Future it wil be use. 

        //public clsParticipantFeatureAccess Load(int Id)
        //{
        //    using (SqlConnection objConn = new SqlConnection(Constr))
        //    {
        //        using (SqlCommand objCmd = new SqlCommand("ParticipantFeatureAccess_Get", objConn))
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
        //                    clsParticipantFeatureAccess objInfo = new clsParticipantFeatureAccess();
        //                    objInfo.FeatureAccessId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[0]);
        //                    objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[1]);
        //                    objInfo.FeatureId = Convert.ToInt32(objDset.Tables[0].Rows[0].ItemArray[2]);
        //                    return objInfo;
        //                }
        //            }
        //            return null;
        //        }
        //    }
        //}

        //This Method is used to Load All assigned Features to one paticipants and module from PaticipantsFeatureAccess_List StoredProcedure.
        //Keywords functionality not used now.
        public List<clsParticipantFeatureAccess> LoadAll(clsParticipantFeatureAccess obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ParticipantFeatureAccess_List", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    //objCmd.Parameters.AddWithValue("@keywords", obj.Keywords);
                    objCmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    objCmd.Parameters.AddWithValue("@ModuleId", obj.ModuleId);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            List<clsParticipantFeatureAccess> objList = new List<clsParticipantFeatureAccess>();
                            for (int cnt = 0; cnt < objDset.Tables[0].Rows.Count; cnt++)
                            {
                                clsParticipantFeatureAccess objInfo = new clsParticipantFeatureAccess();
                                objInfo.SNo = cnt + 1;
                                objInfo.FeatureAccessId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[0]);
                                objInfo.ParticipantId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[1]);
                                objInfo.FeatureId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[2]);
                                objInfo.Feature = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[3]);
                                objInfo.PageName = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[4]);
                                if (objDset.Tables[0].Rows[cnt].ItemArray[5] != DBNull.Value)
                                    objInfo.ModuleId = Convert.ToInt32(objDset.Tables[0].Rows[cnt].ItemArray[5]);
                                objInfo.Module = Convert.ToString(objDset.Tables[0].Rows[cnt].ItemArray[6]);
                                objList.Add(objInfo);
                            }
                            return objList;
                        }
                    }
                    return null;
                }
            }
        }

        //This method is used to Remove the Participant assigned feature from ParticipantFeatureAccess_Remove StoredProcedure
        public void RemoveByParticipant(clsParticipantFeatureAccess obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ParticipantFeatureAccess_RemoveByParticipant", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@FeatureId", obj.FeatureId);
                    objCmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    objCmd.ExecuteNonQuery();
                }
            }
        }
        public void Remove(clsParticipantFeatureAccess obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ParticipantFeatureAccess_Remove", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@FeatureAccessId", obj.FeatureAccessId);
                    objCmd.ExecuteNonQuery();
                }
            }
        }

        public int ParticipantFeatureValidation(clsParticipantFeatureAccess obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ParticipantFeatureAccess_Validation", objConn))
                {

                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    objCmd.Parameters.AddWithValue("@FeatureId", obj.FeatureId);
                    int Count = Convert.ToInt32(objCmd.ExecuteScalar());
                    return Count;
                }
            }
        }

        //This method is used to Send mail Assigned feature to the Participant.
        public virtual clsParticipantFeatureAccess LoadParticipantAssignedFeatures(int ParticipantId)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ParticipantAssignedFeatures_SendEmail", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("ParticipantId", ParticipantId);
                    DataSet objDset = new DataSet();
                    SqlDataAdapter objAdp = new SqlDataAdapter(objCmd);
                    objAdp.Fill(objDset);
                    if (objDset.Tables.Count > 0)
                    {
                        if (objDset.Tables[0].Rows.Count > 0)
                        {
                            clsParticipantFeatureAccess objInfo = new clsParticipantFeatureAccess();
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