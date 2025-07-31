namespace BusinessLayer
{

    public class clsCertificate
    {
        DataAccessLayerHelper.clsCertificateData DBLayer;

        private int _ParticipantId;
        private string _CourseEndDate;
        private string _CertificateNumber;
        private string _CertificatePath;


        public string CertificateNumber { get => _CertificateNumber; set => _CertificateNumber = value; }
        public string CertificatePath { get => _CertificatePath; set => _CertificatePath = value; }

        public int ParticipantId { get => _ParticipantId; set => _ParticipantId = value; }
        public string CourseEndDate { get => _CourseEndDate; set => _CourseEndDate = value; }

        public clsCertificate()
        {
            DBLayer = new DataAccessLayerHelper.clsCertificateData();
        }
        public void AddUpdate(clsCertificate obj)
        {
            DBLayer.AddUpdate(obj);
        }


    }

}