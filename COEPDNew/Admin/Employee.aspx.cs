
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using BusinessLayer;
public partial class Employee : System.Web.UI.Page
{
    public string Constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString.ToString();
    CurrentUser CurrentUser = new CurrentUser();
    clsEmployee Item;
    int ItemId = 0;
    // string Itemc;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsEmployee();
        if (!IsPostBack)
        {
            BindLocation();
            BindBranch();
            BindDesignation();
            BindDepartment();
            if (ItemId > 0)
            {
                lblTitle.Text = "Edit Employee";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                    txtEmployee.Text = Item.Employee;
                    txtCode.Text = Item.Code;
                    ddlLocation.SelectedValue = Item.LocationId.ToString();
                    BindBranch();
                    ddlBranch.SelectedValue = Item.BranchId.ToString();
                    ddlDesignation.SelectedValue = Item.DesignationId.ToString();
                    //if (CurrentUser.CurrentRoleId == Convert.ToInt16(clsUtility.Role.Admin.GetHashCode()))
                    //{
                    //    ddlDesignation.Enabled = true;
                    //}
                    //else
                    //{
                    //    ddlDesignation.Enabled = false;
                    //}

                    ddlDepartment.SelectedValue = Item.DepartmentId.ToString();
                    txtEmail.Text = Item.Email;
                    txtOfficeEmail.Text = Item.OfficeEmail;
                    txtMobile.Text = Item.Mobile;
                    txtCUGMobile.Text = Item.CUGMobile;
                    txtPhone.Text = Item.Phone;
                    txtSummary.Text = Item.Summary;
                    txtRemarks.Text = Item.Remarks;
                    txtSalary.Text = Item.Salary.ToString();
                    txtAddress.Text = Item.Address;
                    txtCity.Text = Item.City;
                    txtState.Text = Item.State;
                    txtZipCode.Text = Item.Zip;
                    txtEmergencyContact.Text = Item.EmergencyContact;
                    txtEmergencyPhone.Text = Item.EmergencyPhone;
                    txtPhonePay.Text = Item.PhonePayNumber;
                    txtGooglePay.Text = Item.GooglePayNumber;
                    txtPaytm.Text = Item.PaytmNumber;
                    txtAccountHolderName.Text = Item.AccountHolderName;
                    txtAccountNumber.Text = Item.BankAccountNumber;
                    txtIFSCCode.Text = Item.IFSCCode;
                    txtBranchName.Text = Item.BranchName;
                    txtBankName.Text = Item.BankName;
                    txtRoles.Text = Item.Roles;
                    if (Item.IsLeadPermit == true)
                        chkIsLeadPermit.Checked = true;
                    else
                        chkIsLeadPermit.Checked = false;
                    if (Item.IsActive == true)
                        chkIsActive.Checked = true;
                    else
                        chkIsActive.Checked = false;



                    if (Item.NurturePermit == true)
                        chkNurturePermit.Checked = true;
                    else
                        chkNurturePermit.Checked = false;





                    if (Item.IsTrainer == true)
                        chkIsTrainer.Checked = true;
                    else
                        chkIsTrainer.Checked = false;

                    if (Item.IsProcess == true)
                        chkIsProcess.Checked = true;
                    else
                        chkIsProcess.Checked = false;

                    if (Item.IsMentor == true)
                        chkIsMentor.Checked = true;
                    else
                        chkIsMentor.Checked = false;

                    if (Item.IsDiscounter == true)
                        chkIsDiscounter.Checked = true;
                    else
                        chkIsDiscounter.Checked = false;

                    if (Item.IsReportingManager == true)
                        chkIsReportingManager.Checked = true;
                    else
                        chkIsReportingManager.Checked = false;

                    if (Item.IsAssociate == true)
                        chkIsAssociate.Checked = true;
                    else
                        chkIsAssociate.Checked = false;


                    if (Item.IsVerticalHead == true)
                        chkIsVerticalHead.Checked = true;
                    else
                        chkIsVerticalHead.Checked = false;







                    DateTime dtVoucherDate = Convert.ToDateTime(Item.JoinDate);
                    txtDay.Text = dtVoucherDate.Day.ToString();
                    txtMonth.Text = dtVoucherDate.Month.ToString();
                    txtYear.Text = dtVoucherDate.Year.ToString();
                }
            }
            else
            {
                lblTitle.Text = "Add New Employee";
                chkIsActive.Checked = true;
                DateTime dt;
                dt = DateTime.UtcNow.AddHours(5).AddMinutes(30);
                txtDay.Text = dt.Day.ToString();
                txtMonth.Text = dt.Month.ToString();
                txtYear.Text = dt.Year.ToString();
            }
        }
    }
    protected void BindBranch()
    {
        //clsBranch obj = new clsBranch();
        //ddlBranch.DataSource = obj.LoadAll(obj);
        //ddlBranch.DataTextField = "Branch";
        //ddlBranch.DataValueField = "BranchId";
        //ddlBranch.DataBind();
        //ddlBranch.Items.Insert(0, new ListItem("-- Select Branch --", "0"));
        ddlBranch.Items.Clear();
        if (ddlLocation.SelectedValue != "")
        {
            clsBranch obj = new clsBranch();
            obj.LocationId = Convert.ToInt32(ddlLocation.SelectedValue);
            ddlBranch.DataSource = obj.LoadAll(obj);
            ddlBranch.DataTextField = "Branch";
            ddlBranch.DataValueField = "BranchId";
            ddlBranch.DataBind();
            ddlBranch.Items.Insert(0, new ListItem("--Select Branch--", ""));
        }
    }
    protected void BindLocation()
    {
        clsLocation obj = new clsLocation();
        ddlLocation.DataSource = obj.LoadAll(obj);
        ddlLocation.DataTextField = "Location";
        ddlLocation.DataValueField = "LocationId";
        ddlLocation.DataBind();
        ddlLocation.Items.Insert(0, new ListItem("--Select Location--", ""));
    }
    protected void BindDesignation()
    {
        clsDesignation obj = new clsDesignation();
        ddlDesignation.DataSource = obj.LoadAll(obj);
        ddlDesignation.DataTextField = "Designation";
        ddlDesignation.DataValueField = "DesignationId";
        ddlDesignation.DataBind();
        ddlDesignation.Items.Insert(0, new ListItem("-- Select Designation --", "0"));
    }
    protected void BindDepartment()
    {
        clsDepartment obj = new clsDepartment();
        ddlDepartment.DataSource = obj.LoadAll(obj);
        ddlDepartment.DataTextField = "Department";
        ddlDepartment.DataValueField = "DepartmentId";
        ddlDepartment.DataBind();
        ddlDepartment.Items.Insert(0, new ListItem("-- Select Department --", "0"));
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            Item.EmployeeId = Convert.ToInt16(ItemId);
        }
        Item.Employee = Convert.ToString(txtEmployee.Text);
        Item.Code = Convert.ToString(txtCode.Text);
        Item.LocationId = Convert.ToInt16(ddlLocation.SelectedValue);
        Item.BranchId = Convert.ToInt16(ddlBranch.SelectedValue);
        Item.DesignationId = Convert.ToInt16(ddlDesignation.SelectedValue);
        Item.DepartmentId = Convert.ToInt32(ddlDepartment.SelectedValue);
        Item.Email = Convert.ToString(txtEmail.Text);
        Item.OfficeEmail = txtOfficeEmail.Text;
        Item.CUGMobile = txtCUGMobile.Text;
        Item.Mobile = Convert.ToString(txtMobile.Text);
        Item.Phone = Convert.ToString(txtPhone.Text);
        Item.Summary = Convert.ToString(txtSummary.Text);
        Item.Remarks = Convert.ToString(txtRemarks.Text);
        if (txtSalary.Text.Length > 0)
        {
            Item.Salary = Convert.ToDecimal(txtSalary.Text);
        }
        else
        {
            Item.Salary = Convert.ToDecimal(0);
        }
        Item.Address = Convert.ToString(txtAddress.Text);
        Item.City = Convert.ToString(txtCity.Text);
        Item.State = Convert.ToString(txtState.Text);
        Item.Zip = Convert.ToString(txtZipCode.Text);
        if (txtDay.Text.Length > 0 && txtMonth.Text.Length > 0 && txtYear.Text.Length > 0)
        {
            int day = Convert.ToInt16(txtDay.Text);
            int month = Convert.ToInt16(txtMonth.Text);
            int year = Convert.ToInt16(txtYear.Text);
            DateTime dt = new DateTime(year, month, day);
            Item.JoinDate = dt;
        }
        Item.EmergencyContact = Convert.ToString(txtEmergencyContact.Text);
        Item.EmergencyPhone = Convert.ToString(txtEmergencyPhone.Text);
        Item.PhonePayNumber = Convert.ToString(txtPhonePay.Text);
        Item.GooglePayNumber = Convert.ToString(txtGooglePay.Text);
        Item.PaytmNumber = Convert.ToString(txtPaytm.Text);
        Item.AccountHolderName = Convert.ToString(txtAccountHolderName.Text);
        Item.BankAccountNumber = Convert.ToString(txtAccountNumber.Text);
        Item.IFSCCode = Convert.ToString(txtIFSCCode.Text);
        Item.BankName = Convert.ToString(txtBankName.Text);
        Item.BranchName = Convert.ToString(txtBranchName.Text);
        Item.CreatedBy = CurrentUser.CurrentUserId;


        if (chkIsLeadPermit.Checked == true)
            Item.IsLeadPermit = true;
        else
            Item.IsLeadPermit = false;







        if (chkIsTrainer.Checked == true)
            Item.IsTrainer = true;
        else
            Item.IsTrainer = false;


        if (chkIsProcess.Checked == true)
            Item.IsProcess = true;
        else
            Item.IsProcess = false;


        if (chkIsMentor.Checked == true)
            Item.IsMentor = true;
        else
            Item.IsMentor = false;


        if (chkIsDiscounter.Checked == true)
            Item.IsDiscounter = true;
        else
            Item.IsDiscounter = false;


        if (chkIsReportingManager.Checked == true)
            Item.IsReportingManager = true;
        else
            Item.IsReportingManager = false;
        if (chkIsActive.Checked == true)
            Item.IsActive = true;
        else
            Item.IsActive = false;



        if (chkNurturePermit.Checked == true)
            Item.NurturePermit = true;
        else
            Item.NurturePermit = false;



        if (chkIsAssociate.Checked == true)
            Item.IsAssociate = true;
        else
            Item.IsAssociate = false;


        if (chkIsVerticalHead.Checked == true)
            Item.IsVerticalHead = true;
        else
            Item.IsVerticalHead = false;



        if (BankAccountFileUpload.HasFile)
        {
            clsFileUpload upload = new clsFileUpload();
            string Filepath = upload.EmployeeUploadDoc(BankAccountFileUpload);
            Item.PassbookFilePath = Filepath;
        }
        if (PanCardFileUpload.HasFile)
        {
            clsFileUpload upload = new clsFileUpload();
            string Filepath = upload.EmployeeUploadDoc(PanCardFileUpload);
            Item.PancardFilePath = Filepath;
        }
        if (AadharFrontFileUpload.HasFile)
        {
            clsFileUpload upload = new clsFileUpload();
            string Filepath = upload.EmployeeUploadDoc(AadharFrontFileUpload);
            Item.AadharFrontFilePath = Filepath;
        }
        if (AadharBackFileUpload.HasFile)
        {
            clsFileUpload upload = new clsFileUpload();
            string Filepath = upload.EmployeeUploadDoc(AadharBackFileUpload);
            Item.AadharBackFilePath = Filepath;
        }
        if (ResumeFileUpload.HasFile)
        {
            clsFileUpload upload = new clsFileUpload();
            //string Filepath = upload.UploadDoc(ResumeFileUpload);
            string Filepath = upload.EmployeeUploadDoc(ResumeFileUpload);
            Item.ResumePath = Filepath;
        }
        Item.Roles = txtRoles.Text;
        Item.AddUpdate(Item);
        Response.Redirect("FeatureAccessSearch.aspx");
    }
    protected void btnAddNew_Click(object sender, EventArgs e)
    {
        Response.Redirect("Employee.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("EmployeeSearch.aspx");
    }

    protected void txtCode_TextChanged(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(Constr);
        con.Open();
        string str = "select COUNT(*)from tblEmployee where Code ='" + txtCode.Text + "'";
        SqlCommand com = new SqlCommand(str, con);
        int count = Convert.ToInt32(com.ExecuteScalar());
        if (count > 0)
        {
            divcode.Visible = true;
            lblcode.Visible = true;
            lblcode.ForeColor = System.Drawing.Color.Red;
            txtCode.ToolTip = txtCode.Text;
            lblcode.Text = "Someone already has that code";
            txtCode.Text = "";
        }
        else
        {
            divcode.Visible = false;
            lblcode.Visible = false;
        }
        con.Close();
    }
    protected void ddlLocation_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlLocation.SelectedValue != null)
        {
            BindBranch();
        }
    }
}