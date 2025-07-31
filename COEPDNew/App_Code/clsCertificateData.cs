using BusinessLayer;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayerHelper
{

    public class clsCertificateData
    {
        public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();

        public void AddUpdate(clsCertificate obj)
        {
            using (SqlConnection objConn = new SqlConnection(Constr))
            {
                using (SqlCommand objCmd = new SqlCommand("ParticipantCertificate_AddUpdate", objConn))
                {
                    objConn.Open();
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@ParticipantId", obj.ParticipantId);
                    objCmd.Parameters.AddWithValue("@CourseEndDate", obj.CourseEndDate);
                    objCmd.Parameters.AddWithValue("@CertificateNumber", obj.CertificateNumber);
                    objCmd.Parameters.AddWithValue("@CertificatePath", obj.CertificatePath);
                    objCmd.ExecuteNonQuery();

                }
            }
        }


    }


}