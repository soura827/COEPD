using System;
using System.IO;
using System.Web;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace BusinessLayer
{
    public class clsFileUpload
    {
        HtmlInputFile _objFileField;
        public HtmlInputFile FileField
        {
            get { return _objFileField; }
            set { _objFileField = value; }
        }

        public string UploadImage(System.Web.UI.WebControls.FileUpload fl)
        {
            string sGuid;
            string strFileName;
            string strFileName1;
            string strFileName2;
            string FileExt;
            string strFilePath;
            string ServerPath = HttpContext.Current.Server.MapPath("~/UserImages/");
            strFilePath = fl.PostedFile.FileName;
            FileExt = System.IO.Path.GetExtension(strFilePath);
            sGuid = Convert.ToString(Guid.NewGuid());
            sGuid = sGuid.Replace("-", "");
            strFileName = sGuid + FileExt;
            strFileName1 = ServerPath + sGuid + FileExt;
            fl.PostedFile.SaveAs(strFileName1);

            strFileName2 = ServerPath + "thumb_" + sGuid + FileExt;
            System.Drawing.Image g = System.Drawing.Image.FromFile(strFileName1);
            System.Drawing.Bitmap SmalImg = new System.Drawing.Bitmap(g, 160, 120);
            SmalImg.Save(strFileName2, g.RawFormat);
            return strFileName;
        }

        public string UploadDoc(System.Web.UI.WebControls.FileUpload fl)
        {
            string sGuid;
            string strFileName;
            string strFileName1;
            string FileExt;
            string strFilePath;
            string ServerPath = HttpContext.Current.Server.MapPath("~/UserDocs/");
            strFilePath = fl.PostedFile.FileName;
            FileExt = System.IO.Path.GetExtension(strFilePath);
            sGuid = Convert.ToString(Guid.NewGuid());
            sGuid = sGuid.Replace("-", "");
            strFileName = sGuid + FileExt;
            strFileName1 = ServerPath + sGuid + FileExt;
            fl.PostedFile.SaveAs(strFileName1);

            return strFileName;
        }
        public string CareerReplyUploadDoc(System.Web.UI.WebControls.FileUpload fl)
        {
            string sGuid;
            string strFileName;
            string strFileName1;
            string FileExt;
            string strFilePath;
            string ServerPath = HttpContext.Current.Server.MapPath("~/UserDocs/CareerReply/");
            strFilePath = fl.PostedFile.FileName;
            FileExt = System.IO.Path.GetExtension(strFilePath);
            sGuid = Convert.ToString(Guid.NewGuid());
            sGuid = sGuid.Replace("-", "");
            strFileName = sGuid + FileExt;
            strFileName1 = ServerPath + sGuid + FileExt;
            fl.PostedFile.SaveAs(strFileName1);

            return strFileName;
        }
        public string ConferenceHallUploadDoc(System.Web.UI.WebControls.FileUpload fl)
        {
            string sGuid;
            string strFileName;
            string strFileName1;
            string FileExt;
            string strFilePath;
            string ServerPath = HttpContext.Current.Server.MapPath("~/UserDocs/ConferenceHall/");
            strFilePath = fl.PostedFile.FileName;
            FileExt = System.IO.Path.GetExtension(strFilePath);
            sGuid = Convert.ToString(Guid.NewGuid());
            sGuid = sGuid.Replace("-", "");
            strFileName = sGuid + FileExt;
            strFileName1 = ServerPath + sGuid + FileExt;
            fl.PostedFile.SaveAs(strFileName1);

            return strFileName;
        }
        public string CorporateUploadDoc(System.Web.UI.WebControls.FileUpload fl)
        {
            string sGuid;
            string strFileName;
            string strFileName1;
            string strFileName2;
            string FileExt;
            string strFilePath;
            string ServerPath = HttpContext.Current.Server.MapPath("~/UserDocs/Corporate/");
            strFilePath = fl.PostedFile.FileName;
            FileExt = System.IO.Path.GetExtension(strFilePath);
            sGuid = Convert.ToString(Guid.NewGuid());
            sGuid = sGuid.Replace("-", "");
            strFileName = sGuid + FileExt;
            strFileName1 = ServerPath + sGuid + FileExt;
            fl.PostedFile.SaveAs(strFileName1);

            strFileName2 = ServerPath + "thumb_" + sGuid + FileExt;
            System.Drawing.Image g = System.Drawing.Image.FromFile(strFileName1);
            System.Drawing.Bitmap SmalImg = new System.Drawing.Bitmap(g, 160, 120);
            SmalImg.Save(strFileName2, g.RawFormat);
            return strFileName;
        }
        public string COEPDClientsDoc(System.Web.UI.WebControls.FileUpload fl)
        {
            string sGuid;
            string strFileName;
            string strFileName1;
            string strFileName2;
            string FileExt;
            string strFilePath;
            string ServerPath = HttpContext.Current.Server.MapPath("~/UserDocs/COEPDClients/");
            strFilePath = fl.PostedFile.FileName;
            FileExt = System.IO.Path.GetExtension(strFilePath);
            sGuid = Convert.ToString(Guid.NewGuid());
            sGuid = sGuid.Replace("-", "");
            strFileName = sGuid + FileExt;
            strFileName1 = ServerPath + sGuid + FileExt;
            fl.PostedFile.SaveAs(strFileName1);

            strFileName2 = ServerPath + "thumb_" + sGuid + FileExt;
            System.Drawing.Image g = System.Drawing.Image.FromFile(strFileName1);
            System.Drawing.Bitmap SmalImg = new System.Drawing.Bitmap(g, 160, 120);
            SmalImg.Save(strFileName2, g.RawFormat);
            return strFileName;
        }
        public string PlacementReviewsDoc(System.Web.UI.WebControls.FileUpload fl)
        {
            string sGuid;
            string strFileName;
            string strFileName1;
            string strFileName2;
            string FileExt;
            string strFilePath;
            string ServerPath = HttpContext.Current.Server.MapPath("~/UserDocs/PlacementReviews/");
            strFilePath = fl.PostedFile.FileName;
            FileExt = System.IO.Path.GetExtension(strFilePath);
            sGuid = Convert.ToString(Guid.NewGuid());
            sGuid = sGuid.Replace("-", "");
            strFileName = sGuid + FileExt;
            strFileName1 = ServerPath + sGuid + FileExt;
            fl.PostedFile.SaveAs(strFileName1);

            strFileName2 = ServerPath + "thumb_" + sGuid + FileExt;
            System.Drawing.Image g = System.Drawing.Image.FromFile(strFileName1);
            System.Drawing.Bitmap SmalImg = new System.Drawing.Bitmap(g, 160, 120);
            SmalImg.Save(strFileName2, g.RawFormat);
            return strFileName;
        }
        public string SuccessStoriesDoc(System.Web.UI.WebControls.FileUpload fl)
        {
            string sGuid;
            string strFileName;
            string strFileName1;
            string strFileName2;
            string FileExt;
            string strFilePath;
            string ServerPath = HttpContext.Current.Server.MapPath("~/UserDocs/SuccessStories/");
            strFilePath = fl.PostedFile.FileName;
            FileExt = System.IO.Path.GetExtension(strFilePath);
            sGuid = Convert.ToString(Guid.NewGuid());
            sGuid = sGuid.Replace("-", "");
            strFileName = sGuid + FileExt;
            strFileName1 = ServerPath + sGuid + FileExt;
            fl.PostedFile.SaveAs(strFileName1);

            strFileName2 = ServerPath + "thumb_" + sGuid + FileExt;
            System.Drawing.Image g = System.Drawing.Image.FromFile(strFileName1);
            System.Drawing.Bitmap SmalImg = new System.Drawing.Bitmap(g, 160, 120);
            SmalImg.Save(strFileName2, g.RawFormat);
            return strFileName;
        }
        public string TrainerProfile(System.Web.UI.WebControls.FileUpload fl)
        {
            string sGuid;
            string strFileName;
            string strFileName1;
            string strFileName2;
            string FileExt;
            string strFilePath;
            string ServerPath = HttpContext.Current.Server.MapPath("~/UserDocs/TrainerProfile/");
            strFilePath = fl.PostedFile.FileName;
            FileExt = System.IO.Path.GetExtension(strFilePath);
            sGuid = Convert.ToString(Guid.NewGuid());
            sGuid = sGuid.Replace("-", "");
            strFileName = sGuid + FileExt;
            strFileName1 = ServerPath + sGuid + FileExt;
            fl.PostedFile.SaveAs(strFileName1);

            strFileName2 = ServerPath + "thumb_" + sGuid + FileExt;
            System.Drawing.Image g = System.Drawing.Image.FromFile(strFileName1);
            System.Drawing.Bitmap SmalImg = new System.Drawing.Bitmap(g, 160, 120);
            SmalImg.Save(strFileName2, g.RawFormat);
            return strFileName;
        }

        public string DocumentUploadDoc(System.Web.UI.WebControls.FileUpload fl)
        {
            string sGuid;
            string strFileName;
            string strFileName1;
            string FileExt;
            string strFilePath;
            string ServerPath = HttpContext.Current.Server.MapPath("~/UserDocs/Document/");
            strFilePath = fl.PostedFile.FileName;
            FileExt = System.IO.Path.GetExtension(strFilePath);
            sGuid = Convert.ToString(Guid.NewGuid());
            sGuid = sGuid.Replace("-", "");
            strFileName = sGuid + FileExt;
            strFileName1 = ServerPath + sGuid + FileExt;
            fl.PostedFile.SaveAs(strFileName1);

            return strFileName;
        }

        public string DownloadUploadDoc(System.Web.UI.WebControls.FileUpload fl)
        {
            string sGuid;
            string strFileName;
            string strFileName1;
            string FileExt;
            string strFilePath;
            string ServerPath = HttpContext.Current.Server.MapPath("~/UserDocs/Download/");
            strFilePath = fl.PostedFile.FileName;
            FileExt = System.IO.Path.GetExtension(strFilePath);
            sGuid = Convert.ToString(Guid.NewGuid());
            sGuid = sGuid.Replace("-", "");
            strFileName = sGuid + FileExt;
            strFileName1 = ServerPath + sGuid + FileExt;
            fl.PostedFile.SaveAs(strFileName1);

            return strFileName;
        }
        public string EmployeeDocumentUploadDoc(System.Web.UI.WebControls.FileUpload fl)
        {
            //string sGuid;
            //string strFileName;
            //string strFileName1;
            //string FileExt;
            //string strFilePath;
            //string ServerPath = HttpContext.Current.Server.MapPath("~/UserDocs/EmployeeDocument/");
            //strFilePath = fl.PostedFile.FileName;
            //FileExt = System.IO.Path.GetExtension(strFilePath);
            //sGuid = Convert.ToString(Guid.NewGuid());
            //sGuid = sGuid.Replace("-", "");
            //strFileName = sGuid + FileExt;
            //strFileName1 = ServerPath + sGuid + FileExt;
            //fl.PostedFile.SaveAs(strFileName1);

            //return strFileName;

                string sGuid;
                string strFileName;
                string strFileName1;
                string FileExt;
                string strFilePath;
                string sample;
                string ServerPath = HttpContext.Current.Server.MapPath("~/UserDocs/EmployeeDocument/");
                strFilePath = fl.PostedFile.FileName;
                strFilePath = strFilePath.ToLower();
                strFilePath = strFilePath.Replace("_", "");
                FileExt = System.IO.Path.GetExtension(strFilePath);
                strFilePath = strFilePath.Replace(".", "");
                strFilePath = strFilePath.Replace("pdf", "");
                strFilePath = strFilePath.Replace("doc", "");
                strFilePath = strFilePath.Replace("xlx", "");
                sGuid = strFilePath.Replace("-", "");


                sample = Convert.ToString(Guid.NewGuid());
                sample = sample.Replace("-", "");

                strFileName = sGuid + sample + FileExt;
                strFileName1 = ServerPath + sGuid + sample + FileExt;
                fl.PostedFile.SaveAs(strFileName1);
                return strFileName;
            
        }
        public string NurtureBlogUploadDoc(System.Web.UI.WebControls.FileUpload fl)
        {
            string sGuid;
            string strFileName;
            string strFileName1;
            string FileExt;
            string strFilePath;
            string ServerPath = HttpContext.Current.Server.MapPath("~/UserDocs/NurtureBlog/");
            strFilePath = fl.PostedFile.FileName;
            FileExt = System.IO.Path.GetExtension(strFilePath);
            sGuid = Convert.ToString(Guid.NewGuid());
            sGuid = sGuid.Replace("-", "");
            strFileName = sGuid + FileExt;
            strFileName1 = ServerPath + sGuid + FileExt;
            fl.PostedFile.SaveAs(strFileName1);

            return strFileName;
        }

        public string NurtureDetailUploadDoc(System.Web.UI.WebControls.FileUpload fl)
        {
            string sGuid;
            string strFileName;
            string strFileName1;
            string FileExt;
            string strFilePath;
            string ServerPath = HttpContext.Current.Server.MapPath("~/UserDocs/NurtureDetail/");
            strFilePath = fl.PostedFile.FileName;
            FileExt = System.IO.Path.GetExtension(strFilePath);
            sGuid = Convert.ToString(Guid.NewGuid());
            sGuid = sGuid.Replace("-", "");
            strFileName = sGuid + FileExt;
            strFileName1 = ServerPath + sGuid + FileExt;
            fl.PostedFile.SaveAs(strFileName1);

            return strFileName;
        }
        public string NurtureDocumentationUploadDoc(System.Web.UI.WebControls.FileUpload fl)
        {
            string sGuid;
            string strFileName;
            string strFileName1;
            string FileExt;
            string strFilePath;
            string ServerPath = HttpContext.Current.Server.MapPath("~/UserDocs/NurtureDocumentation/");
            strFilePath = fl.PostedFile.FileName;
            FileExt = System.IO.Path.GetExtension(strFilePath);
            sGuid = Convert.ToString(Guid.NewGuid());
            sGuid = sGuid.Replace("-", "");
            strFileName = sGuid + FileExt;
            strFileName1 = ServerPath + sGuid + FileExt;
            fl.PostedFile.SaveAs(strFileName1);

            return strFileName;
        }
        public string NurtureExamUploadDoc(System.Web.UI.WebControls.FileUpload fl)
        {
            string sGuid;
            string strFileName;
            string strFileName1;
            string FileExt;
            string strFilePath;
            string ServerPath = HttpContext.Current.Server.MapPath("~/UserDocs/NurtureExam/");
            strFilePath = fl.PostedFile.FileName;
            FileExt = System.IO.Path.GetExtension(strFilePath);
            sGuid = Convert.ToString(Guid.NewGuid());
            sGuid = sGuid.Replace("-", "");
            strFileName = sGuid + FileExt;
            strFileName1 = ServerPath + sGuid + FileExt;
            fl.PostedFile.SaveAs(strFileName1);

            return strFileName;
        }

        public string NurtureProjectUploadDoc(System.Web.UI.WebControls.FileUpload fl)
        {
            string sGuid;
            string strFileName;
            string strFileName1;
            string FileExt;
            string strFilePath;
            string ServerPath = HttpContext.Current.Server.MapPath("~/UserDocs/NurtureProject/");
            strFilePath = fl.PostedFile.FileName;
            FileExt = System.IO.Path.GetExtension(strFilePath);
            sGuid = Convert.ToString(Guid.NewGuid());
            sGuid = sGuid.Replace("-", "");
            strFileName = sGuid + FileExt;
            strFileName1 = ServerPath + sGuid + FileExt;
            fl.PostedFile.SaveAs(strFileName1);

            return strFileName;
        }
        public string NurtureResumeUploadDoc(System.Web.UI.WebControls.FileUpload fl)
        {
            string sGuid;
            string strFileName;
            string strFileName1;
            string FileExt;
            string strFilePath;
            string ServerPath = HttpContext.Current.Server.MapPath("~/UserDocs/NurtureResume/");
            strFilePath = fl.PostedFile.FileName;
            FileExt = System.IO.Path.GetExtension(strFilePath);
            sGuid = Convert.ToString(Guid.NewGuid());
            sGuid = sGuid.Replace("-", "");
            strFileName = sGuid + FileExt;
            strFileName1 = ServerPath + sGuid + FileExt;
            fl.PostedFile.SaveAs(strFileName1);

            return strFileName;
        }
        public string NurtureToolUploadDoc(System.Web.UI.WebControls.FileUpload fl)
        {
            string sGuid;
            string strFileName;
            string strFileName1;
            string FileExt;
            string strFilePath;
            string ServerPath = HttpContext.Current.Server.MapPath("~/UserDocs/NurtureTool/");
            strFilePath = fl.PostedFile.FileName;
            FileExt = System.IO.Path.GetExtension(strFilePath);
            sGuid = Convert.ToString(Guid.NewGuid());
            sGuid = sGuid.Replace("-", "");
            strFileName = sGuid + FileExt;
            strFileName1 = ServerPath + sGuid + FileExt;
            fl.PostedFile.SaveAs(strFileName1);

            return strFileName;
        }
        public string NurtureUMLUploadDoc(System.Web.UI.WebControls.FileUpload fl)
        {
            string sGuid;
            string strFileName;
            string strFileName1;
            string FileExt;
            string strFilePath;
            string ServerPath = HttpContext.Current.Server.MapPath("~/UserDocs/NurtureUML/");
            strFilePath = fl.PostedFile.FileName;
            FileExt = System.IO.Path.GetExtension(strFilePath);
            sGuid = Convert.ToString(Guid.NewGuid());
            sGuid = sGuid.Replace("-", "");
            strFileName = sGuid + FileExt;
            strFileName1 = ServerPath + sGuid + FileExt;
            fl.PostedFile.SaveAs(strFileName1);

            return strFileName;
        }

        public string ResumePreparationUploadDoc(System.Web.UI.WebControls.FileUpload fl)
        {
            string sGuid;
            string strFileName;
            string strFileName1;
            string FileExt;
            string strFilePath;
            string ServerPath = HttpContext.Current.Server.MapPath("~/UserDocs/ResumePreparation/");
            strFilePath = fl.PostedFile.FileName;
            FileExt = System.IO.Path.GetExtension(strFilePath);
            sGuid = Convert.ToString(Guid.NewGuid());
            sGuid = sGuid.Replace("-", "");
            strFileName = sGuid + FileExt;
            strFileName1 = ServerPath + sGuid + FileExt;
            fl.PostedFile.SaveAs(strFileName1);

            return strFileName;
        }
        public string SampleQuestionsUploadDoc(System.Web.UI.WebControls.FileUpload fl)
        {
            string sGuid;
            string strFileName;
            string strFileName1;
            string FileExt;
            string strFilePath;
            string ServerPath = HttpContext.Current.Server.MapPath("~/UserDocs/SampleQuestions/");
            strFilePath = fl.PostedFile.FileName;
            FileExt = System.IO.Path.GetExtension(strFilePath);
            sGuid = Convert.ToString(Guid.NewGuid());
            sGuid = sGuid.Replace("-", "");
            strFileName = sGuid + FileExt;
            strFileName1 = ServerPath + sGuid + FileExt;
            fl.PostedFile.SaveAs(strFileName1);

            return strFileName;
        }
        public string SampleResumeUploadDoc(System.Web.UI.WebControls.FileUpload fl)
        {
            string sGuid;
            string strFileName;
            string strFileName1;
            string FileExt;
            string strFilePath;
            string ServerPath = HttpContext.Current.Server.MapPath("~/UserDocs/SampleResume/");
            strFilePath = fl.PostedFile.FileName;
            FileExt = System.IO.Path.GetExtension(strFilePath);
            sGuid = Convert.ToString(Guid.NewGuid());
            sGuid = sGuid.Replace("-", "");
            strFileName = sGuid + FileExt;
            strFileName1 = ServerPath + sGuid + FileExt;
            fl.PostedFile.SaveAs(strFileName1);

            return strFileName;
        }
        public string EmployeeUploadDoc(System.Web.UI.WebControls.FileUpload fl)
        {
            string sGuid;
            string strFileName;
            string strFileName1;
            string FileExt;
            string strFilePath;
            string ServerPath = HttpContext.Current.Server.MapPath("~/UserDocs/Employee/");
            strFilePath = fl.PostedFile.FileName;
            FileExt = System.IO.Path.GetExtension(strFilePath);
            sGuid = Convert.ToString(Guid.NewGuid());
            sGuid = sGuid.Replace("-", "");
            strFileName = sGuid + FileExt;
            strFileName1 = ServerPath + sGuid + FileExt;
            fl.PostedFile.SaveAs(strFileName1);

            return strFileName;
        }
        public string ParticipantUploadDoc(System.Web.UI.WebControls.FileUpload fl)
        {
            string sGuid;
            string strFileName;
            string strFileName1;
            string FileExt;
            string strFilePath;
            string ServerPath = HttpContext.Current.Server.MapPath("~/UserDocs/Participant/");
            strFilePath = fl.PostedFile.FileName;
            FileExt = System.IO.Path.GetExtension(strFilePath);
            sGuid = Convert.ToString(Guid.NewGuid());
            sGuid = sGuid.Replace("-", "");
            strFileName = sGuid + FileExt;
            strFileName1 = ServerPath + sGuid + FileExt;
            fl.PostedFile.SaveAs(strFileName1);

            return strFileName;
        }
        public string NurtureForumUploadDoc(System.Web.UI.WebControls.FileUpload fl)
        {
            string sGuid;
            string strFileName;
            string strFileName1;
            string FileExt;
            string strFilePath;
            string ServerPath = HttpContext.Current.Server.MapPath("~/UserDocs/NurtureForum/");
            strFilePath = fl.PostedFile.FileName;
            FileExt = System.IO.Path.GetExtension(strFilePath);
            sGuid = Convert.ToString(Guid.NewGuid());
            sGuid = sGuid.Replace("-", "");
            strFileName = sGuid + FileExt;
            strFileName1 = ServerPath + sGuid + FileExt;
            fl.PostedFile.SaveAs(strFileName1);

            return strFileName;
        }
        public string NurtureMockInterviewUploadDoc(System.Web.UI.WebControls.FileUpload fl)
        {
            string sGuid;
            string strFileName;
            string strFileName1;
            string FileExt;
            string strFilePath;
            string ServerPath = HttpContext.Current.Server.MapPath("~/UserDocs/NurtureMockInterview/");
            strFilePath = fl.PostedFile.FileName;
            FileExt = System.IO.Path.GetExtension(strFilePath);
            sGuid = Convert.ToString(Guid.NewGuid());
            sGuid = sGuid.Replace("-", "");
            strFileName = sGuid + FileExt;
            strFileName1 = ServerPath + sGuid + FileExt;
            fl.PostedFile.SaveAs(strFileName1);

            return strFileName;
        }
        public string UploadPopUpImages(System.Web.UI.WebControls.FileUpload fl)
        {
            string sGuid = "COEPDPopUpImage";
            string strFileName;
            string strFileName1;
            string FileExt = ".png";
            string strFilePath;
            string ServerPath = HttpContext.Current.Server.MapPath("~/UserDocs/PopUpImages/");
            strFilePath = fl.PostedFile.FileName;
            // FileExt = System.IO.Path.GetExtension(strFilePath);
            //sGuid = Convert.ToString(Guid.NewGuid());
            // sGuid = sGuid.Replace("-", "");
            strFileName = sGuid + FileExt;
            strFileName1 = ServerPath + sGuid + FileExt;
            fl.PostedFile.SaveAs(strFileName1);

            return strFileName;
        }
        public string GalleryUploadFile(System.Web.UI.WebControls.FileUpload fl)
        {
            string sGuid;
            string strFileName;
            string strFileName1;
            string strFileName2;
            string FileExt;
            string strFilePath;
            string ServerPath = HttpContext.Current.Server.MapPath("~/UserDocs/Gallery/");
            strFilePath = fl.PostedFile.FileName;
            FileExt = System.IO.Path.GetExtension(strFilePath);
            sGuid = Convert.ToString(Guid.NewGuid());
            sGuid = sGuid.Replace("-", "");
            strFileName = sGuid + FileExt;
            strFileName1 = ServerPath + sGuid + FileExt;
            fl.PostedFile.SaveAs(strFileName1);
            strFileName2 = ServerPath + "thumb_" + sGuid + FileExt;
            System.Drawing.Image g = System.Drawing.Image.FromFile(strFileName1);
            System.Drawing.Bitmap SmalImg = new System.Drawing.Bitmap(g, 160, 120);
            SmalImg.Save(strFileName2, g.RawFormat);
            return strFileName;
        }

        public string CampainDocsUploadFile(System.Web.UI.WebControls.FileUpload fl)
        {
            string sGuid;
            string strFileName;
            string strFileName1;
            string FileExt;
            string strFilePath;
            string ServerPath = HttpContext.Current.Server.MapPath("~/UserDocs/CampaignDocs/");
            strFilePath = fl.PostedFile.FileName;
            FileExt = System.IO.Path.GetExtension(strFilePath);
            sGuid = Convert.ToString(Guid.NewGuid());
            sGuid = sGuid.Replace("-", "");
            strFileName = sGuid + FileExt;
            strFileName1 = ServerPath + sGuid + FileExt;
            fl.PostedFile.SaveAs(strFileName1);
            return strFileName;
        }

        public string NurturingProcessUploadDoc(System.Web.UI.WebControls.FileUpload fl)
        {
            string sGuid;
            string strFileName;
            string strFileName1;
            string FileExt;
            string strFilePath;
            string ServerPath = HttpContext.Current.Server.MapPath("~/UserDocs/NurturingProcess/");
            strFilePath = fl.PostedFile.FileName;
            FileExt = System.IO.Path.GetExtension(strFilePath);
            sGuid = Convert.ToString(Guid.NewGuid());
            sGuid = sGuid.Replace("-", "");
            strFileName = sGuid + FileExt;
            strFileName1 = ServerPath + sGuid + FileExt;
            fl.PostedFile.SaveAs(strFileName1);

            return strFileName;
        }
        public string HrProcessUploadDoc(System.Web.UI.WebControls.FileUpload fl)
        {
            string sGuid;
            string strFileName;
            string strFileName1;
            string FileExt;
            string strFilePath;
            string ServerPath = HttpContext.Current.Server.MapPath("~/UserDocs/HrProcess/");
            strFilePath = fl.PostedFile.FileName;
            FileExt = System.IO.Path.GetExtension(strFilePath);
            sGuid = Convert.ToString(Guid.NewGuid());
            sGuid = sGuid.Replace("-", "");
            strFileName = sGuid + FileExt;
            strFileName1 = ServerPath + sGuid + FileExt;
            fl.PostedFile.SaveAs(strFileName1);

            return strFileName;
        }
        public string DataSheetUploadDoc(System.Web.UI.WebControls.FileUpload fl)
        {
            string sGuid;
            string strFileName;
            string strFileName1;
            string FileExt;
            string strFilePath;
            string ServerPath = HttpContext.Current.Server.MapPath("~/UserDocs/PlacementsDataSheet/");
            strFilePath = fl.PostedFile.FileName;
            FileExt = System.IO.Path.GetExtension(strFilePath);
            sGuid = Convert.ToString(Guid.NewGuid());
            sGuid = sGuid.Replace("-", "");
            strFileName = sGuid + FileExt;
            strFileName1 = ServerPath + sGuid + FileExt;
            fl.PostedFile.SaveAs(strFileName1);

            return strFileName;
        }
        public string ConductHRMockUploadDoc(FileUpload f1)
        {
            string sGuid;
            string strFileName;
            string strFileName1;
            string FileExt;
            string strFilePath;
            string ServerPath = HttpContext.Current.Server.MapPath("~/UserDocs/PlacementHRMockFeedback/");
            strFilePath = f1.PostedFile.FileName;
            FileExt = Path.GetExtension(strFilePath);
            sGuid = Convert.ToString(Guid.NewGuid());
            sGuid = sGuid.Replace("-", "");
            strFileName = sGuid + FileExt;
            strFileName1 = ServerPath + sGuid + FileExt;
            f1.PostedFile.SaveAs(strFileName1);

            return strFileName;
        }
        public string PlacementFAQs(FileUpload f1)
        {
            string sGuid;
            string strFileName;
            string strFileName1;
            string FileExt;
            string strFilePath;
            string ServerPath = HttpContext.Current.Server.MapPath("~/UserDocs/PlacementFAQs/");
            strFilePath = f1.PostedFile.FileName;
            FileExt = Path.GetExtension(strFilePath);
            sGuid = Convert.ToString(Guid.NewGuid());
            sGuid = sGuid.Replace("-", "");
            strFileName = sGuid + FileExt;
            strFileName1 = ServerPath + sGuid + FileExt;
            f1.PostedFile.SaveAs(strFileName1);

            return strFileName;
        }
        public string InterviewSupport(FileUpload f1)
        {
            string sGuid;
            string strFileName;
            string strFileName1;
            string FileExt;
            string strFilePath;
            string ServerPath = HttpContext.Current.Server.MapPath("~/UserDocs/InterviewSupport/");
            strFilePath = f1.PostedFile.FileName;
            FileExt = Path.GetExtension(strFilePath);
            sGuid = Convert.ToString(Guid.NewGuid());
            sGuid = sGuid.Replace("-", "");
            strFileName = sGuid + FileExt;
            strFileName1 = ServerPath + sGuid + FileExt;
            f1.PostedFile.SaveAs(strFileName1);

            return strFileName;
        }
        public string GoogleReview(FileUpload f1)
        {
            string sGuid;
            string strFileName;
            string strFileName1;
            string FileExt;
            string strFilePath;
            string ServerPath = HttpContext.Current.Server.MapPath("~/UserDocs/GoogleReview/");
            strFilePath = f1.PostedFile.FileName;
            FileExt = Path.GetExtension(strFilePath);
            sGuid = Convert.ToString(Guid.NewGuid());
            sGuid = sGuid.Replace("-", "");
            strFileName = sGuid + FileExt;
            strFileName1 = ServerPath + sGuid + FileExt;
            f1.PostedFile.SaveAs(strFileName1);

            return strFileName;
        }
        public string OnJobSupportCaseStudy(FileUpload f1)
        {
            string sGuid;
            string strFileName;
            string strFileName1;
            string FileExt;
            string strFilePath;
            string ServerPath = HttpContext.Current.Server.MapPath("~/UserDocs/OnJobSupport/");
            strFilePath = f1.PostedFile.FileName;
            FileExt = Path.GetExtension(strFilePath);
            sGuid = Convert.ToString(Guid.NewGuid());
            sGuid = sGuid.Replace("-", "");
            strFileName = sGuid + FileExt;
            strFileName1 = ServerPath + sGuid + FileExt;
            f1.PostedFile.SaveAs(strFileName1);

            return strFileName;
        }

        public string NurturingServiceRequestFileUpload(FileUpload f1)
        {
            string sGuid;
            string strFileName;
            string strFileName1;
            string FileExt;
            string strFilePath;
            string ServerPath = HttpContext.Current.Server.MapPath("~/UserDocs/NurturingServiceRequests/");
            strFilePath = f1.PostedFile.FileName;
            FileExt = Path.GetExtension(strFilePath);
            sGuid = Convert.ToString(Guid.NewGuid());
            sGuid = sGuid.Replace("-", "");
            strFileName = sGuid + FileExt;
            strFileName1 = ServerPath + sGuid + FileExt;
            f1.PostedFile.SaveAs(strFileName1);

            return strFileName;
        }
        public string HrServiceRequestFileUpload(FileUpload f1)
        {
            string sGuid;
            string strFileName;
            string strFileName1;
            string FileExt;
            string strFilePath;
            string ServerPath = HttpContext.Current.Server.MapPath("~/UserDocs/HrServiceRequests/");
            strFilePath = f1.PostedFile.FileName;
            FileExt = Path.GetExtension(strFilePath);
            sGuid = Convert.ToString(Guid.NewGuid());
            sGuid = sGuid.Replace("-", "");
            strFileName = sGuid + FileExt;
            strFileName1 = ServerPath + sGuid + FileExt;
            f1.PostedFile.SaveAs(strFileName1);

            return strFileName;
        }

        public string NurturingEscalationFileUpload(FileUpload f1)
        {
            string sGuid;
            string strFileName;
            string strFileName1;
            string FileExt;
            string strFilePath;
            string ServerPath = HttpContext.Current.Server.MapPath("~/UserDocs/NurturingEscalations/");
            strFilePath = f1.PostedFile.FileName;
            FileExt = Path.GetExtension(strFilePath);
            sGuid = Convert.ToString(Guid.NewGuid());
            sGuid = sGuid.Replace("-", "");
            strFileName = sGuid + FileExt;
            strFileName1 = ServerPath + sGuid + FileExt;
            f1.PostedFile.SaveAs(strFileName1);

            return strFileName;
        }

        public string PlacementServiceRequestFileUpload(FileUpload f1)
        {
            string sGuid;
            string strFileName;
            string strFileName1;
            string FileExt;
            string strFilePath;
            string ServerPath = HttpContext.Current.Server.MapPath("~/UserDocs/PlacementServiceRequests/");
            strFilePath = f1.PostedFile.FileName;
            FileExt = Path.GetExtension(strFilePath);
            sGuid = Convert.ToString(Guid.NewGuid());
            sGuid = sGuid.Replace("-", "");
            strFileName = sGuid + FileExt;
            strFileName1 = ServerPath + sGuid + FileExt;
            f1.PostedFile.SaveAs(strFileName1);

            return strFileName;
        }

        public string PlacementEscalationFileUpload(FileUpload f1)
        {
            string sGuid;
            string strFileName;
            string strFileName1;
            string FileExt;
            string strFilePath;
            string ServerPath = HttpContext.Current.Server.MapPath("~/UserDocs/PlacementEscalations/");
            strFilePath = f1.PostedFile.FileName;
            FileExt = Path.GetExtension(strFilePath);
            sGuid = Convert.ToString(Guid.NewGuid());
            sGuid = sGuid.Replace("-", "");
            strFileName = sGuid + FileExt;
            strFileName1 = ServerPath + sGuid + FileExt;
            f1.PostedFile.SaveAs(strFileName1);

            return strFileName;
        }

        public string NurturingTask(FileUpload f1)
        {
            string sGuid;
            string strFileName;
            string strFileName1;
            string FileExt;
            string strFilePath;
            string ServerPath = HttpContext.Current.Server.MapPath("~/UserDocs/NurturingTask/");
            strFilePath = f1.PostedFile.FileName;
            FileExt = Path.GetExtension(strFilePath);
            sGuid = Convert.ToString(Guid.NewGuid());
            sGuid = sGuid.Replace("-", "");
            strFileName = sGuid + FileExt;
            strFileName1 = ServerPath + sGuid + FileExt;
            f1.PostedFile.SaveAs(strFileName1);

            return strFileName;
        }

        public string AssignNurturingTask(FileUpload f1)
        {
            string sGuid;
            string strFileName;
            string strFileName1;
            string FileExt;
            string strFilePath;
            string ServerPath = HttpContext.Current.Server.MapPath("~/UserDocs/AssignNurturingTask/");
            strFilePath = f1.PostedFile.FileName;
            FileExt = Path.GetExtension(strFilePath);
            sGuid = Convert.ToString(Guid.NewGuid());
            sGuid = sGuid.Replace("-", "");
            strFileName = sGuid + FileExt;
            strFileName1 = ServerPath + sGuid + FileExt;
            f1.PostedFile.SaveAs(strFileName1);

            return strFileName;
        }
        public string ReferFriendPaymentPath(FileUpload f1)
        {
            string sGuid;
            string strFileName;
            string strFileName1;
            string FileExt;
            string strFilePath;
            string ServerPath = HttpContext.Current.Server.MapPath("~/UserDocs/ReferFriend/");
            strFilePath = f1.PostedFile.FileName;
            FileExt = Path.GetExtension(strFilePath);
            sGuid = Convert.ToString(Guid.NewGuid());
            sGuid = sGuid.Replace("-", "");
            strFileName = sGuid + FileExt;
            strFileName1 = ServerPath + sGuid + FileExt;
            f1.PostedFile.SaveAs(strFileName1);

            return strFileName;
        }
        public string TaskFileUpload(System.Web.UI.WebControls.FileUpload fl)
        {
            string sGuid;
            string strFileName;
            string strFileName1;
            string FileExt;
            string strFilePath;
            string ServerPath = HttpContext.Current.Server.MapPath("~/UserDocs/FileUpload/");
            strFilePath = fl.PostedFile.FileName;
            FileExt = System.IO.Path.GetExtension(strFilePath);
            sGuid = Convert.ToString(Guid.NewGuid());
            sGuid = sGuid.Replace("-", "");
            strFileName = sGuid + FileExt;
            strFileName1 = ServerPath + sGuid + FileExt;
            fl.PostedFile.SaveAs(strFileName1);

            return strFileName;
        }

    }
}
