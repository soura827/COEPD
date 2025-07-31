using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Admin_ActivityFollowUp : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    int ItemId = 0;
    protected void Page_PreInit(object sender,EventArgs e)
    {
        Page.Theme = "Admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId=Convert.ToInt32(Request.QueryString["ItemId"]);
        if(!IsPostBack)
        {

            BindActivityCategory();
            clsActivityInstance item = new clsActivityInstance();
            if (ItemId > 0)
            {
                item = item.Load(ItemId);
               int ActivityCategoryId = Convert.ToInt32(item.ActivityCategoryId);
                Session["ActivityCategoryId"] = ActivityCategoryId;
                int ActivitySubCategoryId = Convert.ToInt32(item.ActivitySubCategoryId);
                Session["ActivitySubCategoryId"] = ActivitySubCategoryId;
               int ActivityId  = Convert.ToInt32(item.ActivityId);
                Session["ActivityId"] = ActivityId;
            }
            else
            {
              
            }
                //if(Session["ActivityInteractionId"]!=null)
                //{
                //    int ActivityInteractionId = Convert.ToInt32(Session["ActivityInteractionId"]);
                //    clsActivityInteractions item1 = new clsActivityInteractions();
                //    //item1 = item1.Load(ActivityInteractionId);
                //    //if (item1.ActivityCategory != "")
                //    //{
                //    //    lblActivityCategory.Text = Convert.ToString(item1.ActivityCategory);
                //    //}
                //    //if (item1.ActivitySubcategory != "")
                //    //{
                //    //    lblActivitySubActivityCategory.Text = Convert.ToString(item1.ActivitySubcategory);
                //    //}
                //    //if (item1.Activity != "")
                //    //{
                //    //    lblActivity.Text = Convert.ToString(item1.Activity);
                //    //}
                //}
            }
    }
    protected void BindActivityCategory()
    {
        clsActivityCategory obj = new clsActivityCategory();
        ddlActivityCategory.DataSource = obj.LoadAll(obj);
        ddlActivityCategory.DataValueField = "ActivityCategoryId";
        ddlActivityCategory.DataTextField = "ActivityCategory";
        ddlActivityCategory.DataBind();
        ddlActivityCategory.Items.Insert(0, new ListItem("Select Activity Category", ""));
    }
    protected void BindActivitySubCategory()
    {
        clsActivitySubCategory obj = new clsActivitySubCategory();
        obj.ActivityCategoryId = Convert.ToInt32(ddlActivityCategory.SelectedValue);
        ddlActivitySubCategory.DataSource = obj.LoadAll(obj);
        ddlActivitySubCategory.DataValueField = "ActivitySubCategoryId";
        ddlActivitySubCategory.DataTextField = "ActivitySubCategory";
        ddlActivitySubCategory.DataBind();
        ddlActivitySubCategory.Items.Insert(0, new ListItem("Select Activity SubCategory", ""));
    }
    protected void BindActivity()
    {
        clsActivity obj = new clsActivity();
        obj.ActivityCategoryId = Convert.ToInt32(ddlActivityCategory.SelectedValue);
        obj.ActivitySubCategoryId = Convert.ToInt32(ddlActivitySubCategory.SelectedValue);
        ddlActivity.DataSource = obj.LoadAll(obj);
        ddlActivity.DataValueField = "ActivityId";
        ddlActivity.DataTextField = "Activity";
        ddlActivity.DataBind();
        ddlActivity.Items.Insert(0, new ListItem("Select Activtiy", ""));
    }
    //protected void BindActivityInteractions()
    //{
    //    clsActivityInteractions obj = new clsActivityInteractions();
    //    txtActivityInputs.Datasource
    //}
    protected void BindEmployee()
    {
       
        clsEmployee obj = new clsEmployee();
        string authors = txtEmployee.Text;
        string[] authorsList = authors.Split(',');
        string value1 = null;
        string value2 = null;
        string value3 = null;
        string value4 = null;
        string value5 = null;
        for (int count = 0; count <= authorsList.Length - 1; count++)
        {
            if (count == 0)
            {
                value1 = Convert.ToString(authorsList.GetValue(0).ToString());
            }
            else if (count == 1)
            {
                value2 = Convert.ToString(authorsList.GetValue(1).ToString());
            }
            else if (count == 2)
            {
                value3 = Convert.ToString(authorsList.GetValue(2).ToString());
            }
            else if (count == 3)
            {
                value4 = Convert.ToString(authorsList.GetValue(3).ToString());
            }
            else if (count == 4)
            {
                value5 = Convert.ToString(authorsList.GetValue(4).ToString());
            }
        }
        obj.Keywords1 = value1;
        obj.Keywords2 = value2;
        obj.Keywords3 = value3;
        obj.Keywords4 = value4;
        obj.Keywords5 = value5;
        gvemployee.DataSource = obj.LoadAllMultiple(obj);
        gvemployee.DataBind();

    }
    protected void BindParticipant()

    {
        clsParticipant obj = new clsParticipant();
        string authors = txtParticipant.Text;
        string[] authorsList = authors.Split(',');
        string value1 = null;
        string value2 = null;
        string value3 = null;
        string value4 = null;
        string value5 = null;
        for (int count = 0; count <= authorsList.Length - 1; count++)
        {
            if (count == 0)
            {
                value1 = Convert.ToString(authorsList.GetValue(0).ToString());
            }
            else if (count == 1)
            {
                value2 = Convert.ToString(authorsList.GetValue(1).ToString());
            }
            else if (count == 2)
            {
                value3 = Convert.ToString(authorsList.GetValue(2).ToString());
            }
            else if (count == 3)
            {
                value4 = Convert.ToString(authorsList.GetValue(3).ToString());
            }
            else if (count == 4)
            {
                value5 = Convert.ToString(authorsList.GetValue(4).ToString());
            }
        }
        obj.Keywords1 = value1;
        obj.Keywords2 = value2;
        obj.Keywords3 = value3;
        obj.Keywords4 = value4;
        obj.Keywords5 = value5;
        gvPartiicipant.DataSource = obj.LoadAllMultiple(obj);
        gvPartiicipant.DataBind();
    }
    protected void BindLead()
    {
        clsLead obj = new clsLead();
        string authors = txtLead.Text;
        string[] authorsList = authors.Split(',');
        string value1 = null;
        string value2 = null;
        string value3 = null;
        string value4 = null;
        string value5 = null;
        for (int count = 0; count <= authorsList.Length - 1; count++)
        {
            if (count == 0)
            {
                value1 = Convert.ToString(authorsList.GetValue(0).ToString());
            }
            else if (count == 1)
            {
                value2 = Convert.ToString(authorsList.GetValue(1).ToString());
            }
            else if (count == 2)
            {
                value3 = Convert.ToString(authorsList.GetValue(2).ToString());
            }
            else if (count == 3)
            {
                value4 = Convert.ToString(authorsList.GetValue(3).ToString());
            }
            else if (count == 4)
            {
                value5 = Convert.ToString(authorsList.GetValue(4).ToString());
            }
        }
        obj.Keywords1 = value1;
        obj.Keywords2 = value2;
        obj.Keywords3 = value3;
        obj.Keywords4 = value4;
        obj.Keywords5 = value5;
        gvLead.DataSource = obj.LoadAllMultiple(obj);
        gvLead.DataBind();
    }
    protected void BindVendor()
    {
        clsVendor obj = new clsVendor();
        string authors = txtVendor.Text;
        string[] authorsList = authors.Split(',');
        string value1 = null;
        string value2 = null;
        string value3 = null;
        string value4 = null;
        string value5 = null;
        for (int count = 0; count <= authorsList.Length - 1; count++)
        {
            if (count == 0)
            {
                value1 = Convert.ToString(authorsList.GetValue(0).ToString());
            }
            else if (count == 1)
            {
                value2 = Convert.ToString(authorsList.GetValue(1).ToString());
            }
            else if (count == 2)
            {
                value3 = Convert.ToString(authorsList.GetValue(2).ToString());
            }
            else if (count == 3)
            {
                value4 = Convert.ToString(authorsList.GetValue(3).ToString());
            }
            else if (count == 4)
            {
                value5 = Convert.ToString(authorsList.GetValue(4).ToString());
            }
        }
        obj.Keywords1 = value1;
        obj.Keywords2 = value2;
        obj.Keywords3 = value3;
        obj.Keywords4 = value4;
        obj.Keywords5 = value5;
        gvVendor.DataSource = obj.LoadAllMultiple(obj);
        gvVendor.DataBind();
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        clsActivityInstance Item = new clsActivityInstance();
        //if (ItemId > 0)
        //{
        //    Item.ActivityInstanceId = Convert.ToInt32(ItemId);
        //}
        //if (ddlActivityCategory.SelectedValue != "" && ddlActivitySubCategory.SelectedValue != "" && ddlActivity.SelectedValue != "")
        //{
            if (ddlActivityCategory.SelectedValue != "")
            {
                Item.ActivityCategoryId = Convert.ToInt32(ddlActivityCategory.SelectedValue);

            }
            else
            {
                Item.ActivityCategoryId = Convert.ToInt32(Session["ActivityCategoryId"]);
            }
            if (ddlActivitySubCategory.SelectedValue != "")
            {
                Item.ActivitySubCategoryId = Convert.ToInt32(ddlActivitySubCategory.SelectedValue);
            }
            else
            {
                Item.ActivitySubCategoryId = Convert.ToInt32(Session["ActivitySubCategoryId"]);
                //Item.ActivityCategoryId = Convert.ToInt32(Session["ActivityCategoryId"]);
            }
            if (ddlActivity.SelectedValue != "")
            {
                Item.ActivityId = Convert.ToInt32(ddlActivity.SelectedValue);
            }
            else
            {
                Item.ActivityId = Convert.ToInt32(Session["ActivityId"]);
            }
        
        int Sno = 0;
            foreach (GridViewRow row in gvemployee.Rows)
            {
                if ((row.FindControl("CheckBox2") as CheckBox).Checked)
                {
                    Label lbltext = (Label)row.FindControl("lblEmployees");
                    string Qids = lbltext.Text;
                    Sno = Sno + 1;
                }
            }
            Item.NoOfEmployeeId = Convert.ToInt32(Sno);

            int Sno1 = 0;
            foreach (GridViewRow row in gvPartiicipant.Rows)
            {
                if ((row.FindControl("CheckBox3") as CheckBox).Checked)
                {
                    Label lbltext = (Label)row.FindControl("lbParticipant");
                    string Qids = lbltext.Text;
                    Sno1 = Sno1 + 1;
                }
            }
            Item.NoOfParticipantId = Convert.ToInt32(Sno1);
            Item.CreatedBy = CurrentUser.CurrentUserId;
            string id = Guid.NewGuid().ToString();
            Item.UniqueId = Convert.ToString(id);
        Item.FollowUpId = Convert.ToInt32(Session["ActivityInstanceId"]);
        if (txtFollowupdate.Text != "")
        {
            DateTime Date = DateTime.ParseExact(txtFollowupdate.Text, "dd/MM/yyyy", null);
            Item.DateToWorkOn = Convert.ToDateTime(Date);
        }
        if (txtfollowupdescription.Text != "")
        {
            Item.Description = Convert.ToString(txtfollowupdescription.Text);
        }
        Item.Status = "New";
        Item.AddUpdate(Item);
        ddlActivityCategory.SelectedIndex = -1;
        ddlActivitySubCategory.SelectedIndex = -1;
        ddlActivity.SelectedIndex = -1;
        gvemployee.Visible = false;
        gvPartiicipant.Visible = false;
        gvLead.Visible = false;
        gvVendor.Visible = false;
        txtEmployee.Text = "";
        txtParticipant.Text = "";
        txtLead.Text = "";
        txtVendor.Text = "";
        FormMessage.Visible = false;
        txtFollowupdate.Text = "";
        txtfollowupdescription.Text = "";
        FormMessage.Text = "Followup Successfully Created";
        FormMessage.Visible = true;
        Item = Item.LoadUniqueId(Item.UniqueId);
            int ActivityInstanceId = Convert.ToInt32(Item.ActivityInstanceId);
            Session["ActivityInstanceId"] = ActivityInstanceId;
            foreach (GridViewRow row in gvemployee.Rows)
            {
                if ((row.FindControl("CheckBox2") as CheckBox).Checked)
                {
                    Label lbltext = (Label)row.FindControl("lblEmployee");
                    int Tids = Convert.ToInt32(lbltext.Text);
                    clsActivityInstanceGroup objUG = new clsActivityInstanceGroup();
                    objUG.ActivityInstanceId = ActivityInstanceId;
                    objUG.EmployeeId = Tids;
                    objUG.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
                    objUG.AddUpdate(objUG);
                }
            }
            int ActivityInstanceId1 = Convert.ToInt32(Item.ActivityInstanceId);
            foreach (GridViewRow row in gvPartiicipant.Rows)
            {
                if ((row.FindControl("CheckBox3") as CheckBox).Checked)
                {
                    Label lbltext = (Label)row.FindControl("lbParticipantId");
                    int Tids = Convert.ToInt32(lbltext.Text);
                    clsActivityInstanceGroup objUG = new clsActivityInstanceGroup();
                    objUG.ActivityInstanceId = ActivityInstanceId1;
                    objUG.ParticipantId = Tids;
                    objUG.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
                    objUG.AddUpdate(objUG);
                }
            }
        int ActivityInstanceId2 = Convert.ToInt32(Item.ActivityInstanceId);
        foreach (GridViewRow row in gvLead.Rows)
        {
            if ((row.FindControl("CheckBox4") as CheckBox).Checked)
            {
                Label lbltext = (Label)row.FindControl("lblLeadId");
                int Tids = Convert.ToInt32(lbltext.Text);
                clsActivityInstanceGroup objUG = new clsActivityInstanceGroup();
                objUG.ActivityInstanceId = ActivityInstanceId;
                objUG.LeadId = Tids;
                objUG.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
                objUG.AddUpdate(objUG);
            }
        }
        int ActivityInstanceId3 = Convert.ToInt32(Item.ActivityInstanceId);

        foreach (GridViewRow row in gvVendor.Rows)
        {
            if ((row.FindControl("CheckBox5") as CheckBox).Checked)
            {
                Label lbltext = (Label)row.FindControl("lblVendorId");
                int Tids = Convert.ToInt32(lbltext.Text);
                clsActivityInstanceGroup objUG = new clsActivityInstanceGroup();
                objUG.ActivityInstanceId = ActivityInstanceId;
                objUG.VendorId = Tids;
                objUG.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
                objUG.AddUpdate(objUG);
            }
        }
        //ddlActivityCategory.SelectedIndex = -1;
        //ddlActivitySubCategory.SelectedIndex = -1;
        //ddlActivity.SelectedIndex = -1;
        //txtEmployee.Text = "";
        //     int ActivityInteractionId = Convert.ToInt32(Session["ActivityInteractionId"]);
        //    clsActivityInteractions item1 =new clsActivityInteractions();
        //    item1 = item1.Load(ActivityInteractionId);
        //    string ActivityInteractions=Convert.ToString(item1.ActivityInteractionInputs);
        ////     lblActivityCategory.Text = Convert.ToString(item1.ActivityCategory);
        ////Session["ActivityCategory"] = Convert.ToString(lblActivityCategory.Text);
        ////     lblActivitySubActivityCategory.Text = Convert.ToString(item1.ActivitySubcategory);
        ////Session["ActivitySubCategory"] = Convert.ToString(lblActivitySubActivityCategory.Text);
        ////lblActivity.Text = Convert.ToString(item1.Activity);
        ////Session["Activity"] = Convert.ToString(lblActivity.Text);
        //Session["ActivityInteractionInputs"] = Convert.ToString(ActivityInteractions);
        //    //item1.ActivityInstanceId = Convert.ToInt32(Session["ActivityInstanceId"]);
        //    //item1 = item1.LoadActivityInstanceId(ActivityInstanceId);
        //    //string ActivityInteractioninputs = Convert.ToString(item1.ActivityInteractionInputs);
        //    //Session["ActivityInteractionInputs"] = ActivityInteractioninputs;
        //clsActivityInteractions obj = new clsActivityInteractions();
        //    obj.ActivityInstanceId = Convert.ToInt32(Session["ActivityInstanceId"]);
        //    obj.ActivityInteractionInputs = Convert.ToString(Session["ActivityInteractionInputs"]);


        //    obj.CreatedBy = CurrentUser.CurrentUserId;
        //    obj.AddUpdate(obj);




        // }

        //else
        //{
        //    ErrorMessage.Text = "Please Create FollowUp based on above fields";
        //    ErrorMessage.Visible = true;
        //}

        // }
        //else
        //{
        //    ErrorMessage.Text = "Please Create FollowUp based on above fields";
        //    ErrorMessage.Visible = true;
        //}
    }
    protected void btnreset_Click(object sender, EventArgs e)
    {
        //ddlActivityCategory.SelectedIndex = -1;
        //ddlActivitySubCategory.SelectedIndex = -1;
        //ddlActivity.SelectedIndex = -1;
        //gvemployee.Visible = false;
        //gvPartiicipant.Visible = false;
        //gvLead.Visible = false;
        //gvVendor.Visible = false;
        //txtFollowupdate.Text = "";
        //txtfollowupdescription.Text = "";
        //txtEmployee.Text = "";
        //txtParticipant.Text = "";
        //txtLead.Text = "";
        //txtVendor.Text = "";
        //FormMessage.Visible = false;
        //ErrorMessage.Visible = false;
        ddlActivityCategory.SelectedValue = "";
        ddlActivitySubCategory.SelectedValue = "";
        ddlActivity.SelectedValue = "";
        gvemployee.Visible = false;
        gvPartiicipant.Visible = false;
        gvLead.Visible = false;
        gvVendor.Visible = false;
        txtEmployee.Text = "";
        txtParticipant.Text = "";
        txtLead.Text = "";
        txtVendor.Text = "";
        FormMessage.Visible = false;
    }
    protected void ddlActivityCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindActivitySubCategory();
        ErrorMessage.Visible = false;
    }
    protected void ddlActivitySubCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindActivity();
    }
    protected void txtEmployee_TextChanged(object sender, EventArgs e)
    {
        BindEmployee();
    }
    protected void txtParticipant_TextChanged(object sender, EventArgs e)
    {
        BindParticipant();
    }

    protected void btnInteractions_Click(object sender, EventArgs e)
    {
        Response.Redirect("ActivityTasks.aspx");
    }

    protected void txtLead_TextChanged(object sender, EventArgs e)
    {
        BindLead();
    }

    protected void txtVendor_TextChanged(object sender, EventArgs e)
    {
        BindVendor();
    }
}