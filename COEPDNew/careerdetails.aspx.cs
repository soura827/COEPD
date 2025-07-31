//This code behind page is used to fill the details of aspirant.
using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using BusinessLayer;
public partial class CareerDetails : System.Web.UI.Page
{
    public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();
    CurrentUser CurrentUser = new CurrentUser();
    int ItemId = 0;
    clsCareer Item = new clsCareer();

    protected void Page_Load(object sender, EventArgs e)
    {
        //When out side employee click on particular designation in Career.aspx that particular id (accept only integer value) bind to ItemId.
        //ItemId = Convert.ToInt32(Request.QueryString["Id"]);

        if (!String.IsNullOrEmpty(Request.QueryString["Id"]))
        {
            int value;
            bool isNumeric = int.TryParse(Request.QueryString["Id"], out value);
            if (isNumeric)
            {
                ItemId = Convert.ToInt32(Request.QueryString["Id"]);
            }
        }
        if (!IsPostBack)
        {
            BindDateOfBirth();
            if (ItemId > 0)
            {
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    lblPost.Text = Item.JobTitle;
                    hdnPost.Value = Item.JobTitle;
                }
                else
                {
                    Response.Redirect("careers.aspx");
                }
            }
            else
            {
                Response.Redirect("careers.aspx");
            }
        }
    }
    //This Even will fire when click on the button.The data will saved to  tblCareerReply.
    
    protected void BindDateOfBirth()
    {
        for(int i=1;i<=31;i++)
        {
            ddlDay.Items.Add(i.ToString());
        }
        for (int i = 1; i <= 12; i++)
        {
            ddlMonth.Items.Add(i.ToString());
        }
        for (int i = 1960; i <= 2016; i++)
        {
            ddlYear.Items.Add(i.ToString());
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        clsCareerReply obj = new clsCareerReply();
        obj.AppliedFor = hdnPost.Value;
        obj.Name = txtName.Text;
        obj.FatherName = txtFName.Text;
        int Day = Convert.ToInt16(ddlDay.SelectedItem.Value);
        int Month = Convert.ToInt16(ddlMonth.SelectedItem.Value);
        int Year = Convert.ToInt16(ddlYear.SelectedItem.Value);
        DateTime dt = new DateTime(Year, Month, Day);
        obj.DateOfBirth = dt;
        obj.TotalExp = txtTotalExp.Text;
        obj.RelavantExperience = txtRelevantExp.Text;
        obj.Skills = txtSkills.Text;
        obj.Strengths = txtStrengths.Text;
        obj.CurrentDesignation = txtDesignation.Text;
        obj.CompanyAddress = txtCompanyAdd.Text;
        obj.PresentCTC = txtPresentCTC.Text;
        obj.ExpectedCTC = txtExpectedCTC.Text;
        obj.NoticePeriod = txtNotice.Text;
        obj.ReasonForChange = txtReasonForChange.Text;
        obj.ResidentialAddress = txtAddress.Text;
        if (flUpload.HasFile)
        {
            clsFileUpload upload = new clsFileUpload();
            string file = upload.UploadDoc(flUpload);
            obj.ImagePath = file;
        }

        obj.AddUpdate(obj);

        txtName.Text = "";
        txtFName.Text = "";
        ddlDay.ClearSelection();
        ddlMonth.ClearSelection();
        ddlYear.ClearSelection();
        txtTotalExp.Text = "";
        txtRelevantExp.Text = "";
        txtSkills.Text = "";
        txtStrengths.Text = "";
        txtDesignation.Text = "";
        txtCompanyAdd.Text = "";
        txtPresentCTC.Text = "";
        txtExpectedCTC.Text = "";
        txtNotice.Text = "";
        txtReasonForChange.Text = "";
        txtAddress.Text = "";
        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#myModal').modal();", true);
        //System.Threading.Thread.Sleep(5000);
        //Response.Redirect("careers.aspx");
    }

    protected void txtReasonForChange_TextChanged(object sender, EventArgs e)
    {
        SqlConnection objConn = new SqlConnection(Constr);
        objConn.Open();
        string str = "select COUNT(*) from tblCareerReply where ReasonForChange='" + txtReasonForChange.Text + "'";
        SqlCommand objCmd = new SqlCommand(str, objConn);
        int Count = Convert.ToInt16(objCmd.ExecuteScalar());
        if (Count > 0)
        {
            divEmail.Visible = true;
            lblEmail.Visible = true;
            lblEmail.ForeColor = System.Drawing.Color.Red;
            txtReasonForChange.ToolTip = txtReasonForChange.Text;
            lblEmail.Text = "Your Resume is already existed on this Email. Once we find suitable profile to your resume our HR will contact you.";
            txtReasonForChange.Text = "";
        }
        else
        {
            divEmail.Visible = false;
            lblEmail.Visible = false;
        }
        objConn.Close();
    }
    protected void txtAddress_TextChanged(object sender, EventArgs e)
    {
        SqlConnection objConn = new SqlConnection(Constr);
        objConn.Open();
        string str = "select count(*) from tblCareerReply where ResidentialAddress='" + txtAddress.Text + "'";
        SqlCommand cmd = new SqlCommand(str, objConn);
        int count = Convert.ToInt16(cmd.ExecuteScalar());
        if(count>0)
        {
            divMobile.Visible = true;
            lbMobile.Visible = true;
            lbMobile.ForeColor = System.Drawing.Color.Red;
            txtAddress.ToolTip = txtAddress.Text;
            lbMobile.Text = "Your Resume is already existed on this Mobile No. Once we find suitable profile to your resume our HR will contact you.";
            txtAddress.Text = "";
        }
        else
        {
            divMobile.Visible = false;
            lbMobile.Visible = false;
        }
        objConn.Close();
        }
    }