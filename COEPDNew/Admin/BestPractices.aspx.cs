using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class BestPractices : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();
    clsBestPractices Item;
    int ItemId = 0;
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemId = Convert.ToInt16(Request.QueryString["ItemId"]);
        Item = new clsBestPractices();        
        if (!IsPostBack)
        {
           // BindData();
            if (ItemId > 0)
            {              
                if (Item != null)
                {
                    lblTitle.Text = "Edit BestPractices";
                    Item = Item.Load(ItemId);
                    if(Item !=null)
                    {
                        txtStream.Text = Item.Stream;
                        txtPractices.Text = Item.Practices;
                        txtStream.Enabled = false;
                    }                           
                }
            }
            else
            {
                lblTitle.Text = "Add BestPractices";               
            }
           
        }
    }
    //public void BindData()
    //{
    //    clsDesignation obj = new clsDesignation();

    //    txtStream.DataSource = obj.LoadAll(obj);    
    //    ddlStream.DataTextField = "Designation";
    //    ddlStream.DataValueField = "DesignationId";
    //    ddlStream.DataBind();
    //    ddlStream.Items.Insert(0, new ListItem("--Select--","0"));
    //}

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (txtStream.Text == "")
        {
            //Response.Write("<script></script>");
        }
        else
        {
            if (ItemId > 0)
            {
                Item.BestPracticesId = Convert.ToInt16(ItemId);
            }
            Item.Stream = txtStream.Text;
            Item.Practices = txtPractices.Text;
            Item.CreatedBy = CurrentUser.CurrentEmployeeId;
            Item.AddUpdate(Item);
            if (ItemId > 0)
            {
                FormMessage.Text = "Best Practices successfully updated";
                FormMessage.Visible = true;
                btnSubmit.Enabled = false;
            }
            else
            {
                FormMessage.Text = "Best Practices successfully created";
                FormMessage.Visible = true;
                btnSubmit.Enabled = false;
                txtStream.Text = "";
                txtPractices.Text = " ";
            }
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("BestPracticesSearch.aspx");
    }
    private void txtStream_Leave(object sender, System.EventArgs e)
    {
        Response.Write("<script>alert('Please enter the Stream')</script>");
    }
}