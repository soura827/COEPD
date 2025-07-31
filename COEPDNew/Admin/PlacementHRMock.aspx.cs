
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Schema;
using BusinessLayer;
using System.Data;
using System.Activities.Expressions;
using System.Drawing;
using System.Configuration;
using System.Diagnostics.Contracts;
using System.IdentityModel.Protocols.WSTrust;
using System.Runtime.ConstrainedExecution;

public partial class Admin_PlacementHRMock : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    int itemId = 0;
    clsParticipant Item;
    clsPlacementInduction item;
    int ItemId = 0;
    private int TotalScore = 0;
    string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
    SqlConnection con;
    SqlDataAdapter adapt;
    DataTable dt;
    double Score, total, per;

    string nm, Remarks;


    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        itemId = Convert.ToInt32(Request.QueryString["itemId"]);
        item = new clsPlacementInduction();
        Item = new clsParticipant();
        if (!this.IsPostBack)
        {
            this.BindGrid();
            if (itemId > 0)
            {
                if (!IsPostBack)
                {
                    this.BindGrid();




                    item = item.Load(itemId);
                    if (item != null)
                    {



                        ItemId = item.ParticipantId;
                        if (ItemId > 0)
                        {

                            Item = Item.Load(ItemId);
                            if (Item != null)
                            {
                                lblParticipantName.Text = Item.Participant;
                                lblDate.Text = DateTime.Now.ToString();
                                txtQulaifcation.Text = Convert.ToString(item.Qualification);
                                txtScore.Text = Convert.ToString(item.Score);
                                txtMentorInputs.Text = item.HRMockInputs;
                                lblBAExp.Text = item.TotalExperience + "  " + "Years";
                                lblInterviewer.Text = item.Employee;
                                lbllocation.Text = item.Location;

                            }
                        }
                    }
                    if (item.HRMockFeebackImagePath != "")
                    {
                        //hplHRMockFeedbackFile.Visible = true;
                        //hplHRMockFeedbackFile.NavigateUrl = "~/UserDocs/PlacementHRMockFeedback/" + item.HRMockFeebackImagePath;
                    }
                    else
                        // hplHRMockFeedbackFile.Visible = false;
                        txtScore.Text = Convert.ToString(item.Score);
                    txtMentorInputs.Text = item.HRMockInputs;
                    ddlIsHRMockApproved.SelectedValue = Convert.ToString(item.IsHRMockApproved);
                    hdnAttendedOn.Value = item.AttendedOn.ToString("dd/MM/yyyy");
                    if (Convert.ToBoolean(ddlIsHRMockApproved.SelectedValue) == true)
                    {
                        btnUpdate.Enabled = false;
                        //flHRMockFeedbackUpload.Visible = false;
                        //lblUploadFeedback.Visible = false;
                        //lblSize.Visible = false;
                        txtScore.Enabled = false;
                        
                    }
                }
            }





            else
            {
                Response.Redirect("PlacementInductionSearch.aspx");
            }
        }




    }

    private void BindGrid()
    {
        string constr = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        using (SqlConnection con = new SqlConnection(constr))
        {
            using (SqlCommand cmd = new SqlCommand("select CHMF.ConductHRMcokFeedBackFormId,HRM.QuestionName, CHMF.Rating FROM tblConductHRMcokFeedBackForm CHMF JOIN dbCoepd.dbo.tblHRMockQuestions as HRM ON(CHMF.HRMockQuestionId=HRM.HRMockQuestionId) WHERE CHMF.PlacementInductionId =@PlacementInductionId ORDER BY CHMF.PlacementInductionId  DESC;"))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter())
                {

                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    cmd.Parameters.Clear();

                    cmd.Parameters.Add("@PlacementInductionId", SqlDbType.Int).Value = itemId;



                    clsHRMockFeedBack HRM = new clsHRMockFeedBack();
                    DataSet objDset = new DataSet();
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);

                        HRM.PlacementInductionId = itemId;
                        gvCustomers.DataSource = dt;
                        gvCustomers.DataBind();


                    }
                }
            }
        }
    }
    private DataTable ExecuteQuery(SqlCommand cmd, string action)
    {
        string conString = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        using (SqlConnection con = new SqlConnection(conString))
        {
            clsHRMockFeedBack HRM = new clsHRMockFeedBack();
            cmd.Connection = con;
            switch (action)
            {
                case "SELECT":
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        sda.SelectCommand = cmd;
                        cmd.Parameters.Add("@PlacementInductionId", SqlDbType.Int).Value = itemId;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            HRM.PlacementInductionId = itemId;
                            return dt;
                        }
                    }
                case "UPDATE":
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    break;
            }
            return null;
        }
    }



    protected void Update(object sender, EventArgs e)
    {
        foreach (GridViewRow row in gvCustomers.Rows)
        {
            if (row.RowType == DataControlRowType.DataRow)
            {
                bool isChecked = row.Cells[0].Controls.OfType<CheckBox>().FirstOrDefault().Checked;
                if (isChecked)
                {
                    SqlCommand cmd = new SqlCommand("UPDATE tblConductHRMcokFeedBackForm SET Rating = @Rating WHERE ConductHRMcokFeedBackFormId = @ConductHRMcokFeedBackFormId");
                    cmd.Parameters.AddWithValue("@Rating", row.Cells[2].Controls.OfType<DropDownList>().FirstOrDefault().SelectedItem.Value);
                    cmd.Parameters.AddWithValue("@ConductHRMcokFeedBackFormId", gvCustomers.DataKeys[row.RowIndex].Value);
                    this.ExecuteQuery(cmd, "SELECT");
                }


                // this.BindGrid();

            }


        }
        if (itemId > 0)
            item.PlacementInductionId = itemId;
        item.Score = Convert.ToDecimal(txtScore.Text);
        item.HRMockInputs = txtMentorInputs.Text;
        item.Qualification = txtQulaifcation.Text;
        item.IsHRMockApproved = Convert.ToBoolean(ddlIsHRMockApproved.SelectedValue);
        if (hdnAttendedOn.Value != "")
        {
            DateTime Date = DateTime.ParseExact(hdnAttendedOn.Value, "dd/MM/yyyy", null);
            item.AttendedOn = Convert.ToDateTime(Date);
        }
        item.CreatedBy = CurrentUser.CurrentUserId;
        item.AddUpdate(item);

        //Response.Redirect("HrProcess.aspx");


    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("PlacementInductionSearch.aspx");
    }

    //protected void btnSubmit_Click(object sender, EventArgs e)
    //{

    //    Response.Redirect("PlacementInductionSearch.aspx");

    //}


    protected void OnRowEditing(object sender, GridViewEditEventArgs e)
    {
        gvCustomers.EditIndex = e.NewEditIndex;
        this.BindGrid();
    }

    protected void OnRowCancelingEdit(object sender, EventArgs e)
    {

    }

    protected void OnRowUpdating(object sender, GridViewUpdateEventArgs e)
    {


    }
    protected void OnRowDataBound(object sender, GridViewRowEventArgs e)
    {

        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ConnectionString);
            DropDownList ddlDropDownList = (DropDownList)e.Row.FindControl("ddlRating");
            if (ddlDropDownList != null)
            {
                SqlDataAdapter da = new SqlDataAdapter("select distinct(Rating) from tblRemarks", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    ddlDropDownList.DataSource = dt;
                    ddlDropDownList.DataTextField = "Rating";
                    ddlDropDownList.DataValueField = "Rating";
                    ddlDropDownList.DataBind();
                    //ddlDropDownList.Items.Insert(0, "--Select--");

                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Source Not Available');", true);
                }
            }



        }
    }
    protected void OnCheckedChanged(object sender, EventArgs e)
    {
        bool isUpdateVisible = false;
        CheckBox chk = (sender as CheckBox);
        if (chk.ID == "chkAll")
        {
            foreach (GridViewRow row in gvCustomers.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    row.Cells[0].Controls.OfType<CheckBox>().FirstOrDefault().Checked = chk.Checked;
                }
            }
        }
        CheckBox chkAll = (gvCustomers.HeaderRow.FindControl("chkAll") as CheckBox);
        chkAll.Checked = true;
        foreach (GridViewRow row in gvCustomers.Rows)
        {
            if (row.RowType == DataControlRowType.DataRow)
            {
                bool isChecked = row.Cells[0].Controls.OfType<CheckBox>().FirstOrDefault().Checked;
                for (int i = 1; i < row.Cells.Count; i++)
                {

                    if (row.Cells[i].Controls.OfType<DropDownList>().ToList().Count > 0)
                    {
                        row.Cells[i].Controls.OfType<DropDownList>().FirstOrDefault().Visible = isChecked;
                    }

                    if (isChecked && !isUpdateVisible)
                    {
                        isUpdateVisible = true;
                    }
                    if (!isChecked)
                    {
                        chkAll.Checked = false;
                    }
                }
            }
        }
        btnUpdate.Visible = isUpdateVisible;
    }

    protected void ddlRating_SelectedIndexChanged(object sender, EventArgs e)
    {
        Int16 sumFactor = 0;
        foreach (GridViewRow row in gvCustomers.Rows)
        {
            DropDownList ddlRating = (row.FindControl("ddlRating") as DropDownList);
            if (null != ddlRating.SelectedItem)
                sumFactor += Convert.ToInt16(ddlRating.SelectedValue);
        }

        total = Convert.ToInt32(sumFactor);
        per = total / 28;
        if (per <= 5)
            lblRemarks.Text = "Bad";
        else if (per >= 5 && per <= 6)
            lblRemarks.Text = "Average";
        else if (per >= 6 && per <= 7)
            lblRemarks.Text = "Good";
        else if (per >= 8 && per <= 100)
            lblRemarks.Text = "Excellent";
        txtScore.Text = Convert.ToString(Convert.ToInt16(per));



        //txtScore.Text = (from GridViewRow rows in gvCustomers.Rows
        //                 where row.Cells[2].Text.ToString() != string.Empty
        //                 select Convert.ToInt32(row.Cells[2].Text)).Sum().ToString();

    }
}






