using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class ParticipantDocShare : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsInternDocument Item;
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsInternDocument();
        
        if (!IsPostBack)
        {
            BindDocument();
            if (ItemId > 0)
            {
                lblTitle.Text = "Participant Document";
                Item = Item.Load(ItemId);
                if (Item != null)
                {
                }
            }
            else
            {
                lblTitle.Text = "Add Intern Document";
            }
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (ItemId > 0)
        {
            Item.ParticipantDocumentId = Convert.ToInt16(ItemId);
        }
        Item.ParticipantId =Convert.ToInt32(ddlParticipant.SelectedValue) ;
        Item.ParticipantDocument = Convert.ToString(ddlDocument.SelectedItem);
        Item.EmployeeDocumentId = Convert.ToInt32(ddlDocument.SelectedValue);
        
        Item.CreatedBy = CurrentUser.CurrentUserId;
        Item.AddUpdate(Item);
        Response.Redirect("ParticipantDocShareSearch.aspx");
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        ddlParticipant.Items.Clear();
        BindParticipant();
    }

    protected void BindParticipant()
    {
        clsParticipant obj = new clsParticipant();
        obj.keywords = txtSearch.Text;
        ddlParticipant.DataSource = obj.LoadAll(obj);
        ddlParticipant.DataTextField = "Participant";
        ddlParticipant.DataValueField = "ParticipantId";
        ddlParticipant.DataBind();
        ddlParticipant.Items.Insert(0, new ListItem("-- Select Participant -- ", ""));
    }

    protected void BindDocument()
    {
        clsEmployeeDocument obj = new clsEmployeeDocument();
        obj.EmployeeId = CurrentUser.CurrentEmployeeId;

        ddlDocument.DataSource = obj.LoadAll(obj);
        ddlDocument.DataTextField = "EmployeeDocument";
        ddlDocument.DataValueField = "EmployeeDocumentId";
        ddlDocument.DataBind();
        ddlDocument.Items.Insert(0, new ListItem("-- Select Document --", ""));


    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("ParticipantDocShareSearch.aspx");
    }
}