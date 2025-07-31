//This codebehind Page is used Display Employee Features in GridView based on selected module
using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class FeatureAccessSearch : System.Web.UI.Page
{
    CurrentUser CurrentUser = new CurrentUser();

    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    //When Page Loading Bind all Employes,Modules, Available Features and Asigned Features.
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindEmployee();
            BindModule();
            BindData();
          //BindgvAssigned();
        }
    }
    //Bind all Employees in to Dropdown.
    protected void BindEmployee()
    {       
        clsEmployee obj = new clsEmployee();
        if (txtEmployee.Text != "")
            obj.keywords = txtEmployee.Text;
        ddlEmployee.DataSource = obj.LoadAll(obj);                
        ddlEmployee.DataTextField = "Employee";
        ddlEmployee.DataValueField = "EmployeeId";        
        ddlEmployee.DataBind();
        ddlEmployee.Items.Insert(0, new ListItem("-- All --", "0"));        
    }
    //Bind Employee  Modules in to Dropdown.
    protected void BindModule()
    {
        clsModule obj = new clsModule();
        ddModule.DataSource = obj.LoadAll(obj);
        ddModule.DataTextField = "Module";
        ddModule.DataValueField = "ModuleId";
        ddModule.DataBind();      
    }
    //When selecting Employee in dropdown this event will fire and that perticular employee Features Dispalay in grid views.
    protected void ddlEmployee_SelectedIndexChanged(object sender, EventArgs e)
    {
        ErrorMessage.Visible = false;
        if (ddlEmployee.SelectedIndex > 0)
        {
            BindgvAssigned();
        }
        BindData();       
    }
   //This Method is  used to returns List of feature of a perticular Module which are  not assigned to given Employee.
    protected void BindData()
    {
        clsFeature obj = new clsFeature();
        obj.ModuleId = Convert.ToInt16(ddModule.SelectedValue);
        obj.EmployeeId = Convert.ToInt32(ddlEmployee.SelectedValue);
        gv.DataSource = obj.LoadAllAvilable(obj);
        gv.DataBind();
    }
    //This Method is used to Load All assigned Features to Employees in Gridview.
    protected void BindgvAssigned()
    {
        clsFeatureAccess obj = new clsFeatureAccess();
        obj.ModuleId = Convert.ToInt16(ddModule.SelectedValue);
        obj.EmployeeId = Convert.ToInt16(ddlEmployee.SelectedValue);
        gvAssign.DataSource = obj.LoadAll(obj);
        gvAssign.DataBind();
    }
    //This event will fire when selecting the Employee Module and Display assigned features in GridView.
    protected void ddModule_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
        if (ddlEmployee.SelectedIndex > 0)
        {
            BindgvAssigned();
        }
    }
    //This RowCommand will fire when assigning the feature.
    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if(e.CommandName== "cmdAdd")
        {
            if (ddlEmployee.SelectedIndex > 0)
            {
                clsFeatureAccess objfature = new clsFeatureAccess();
                objfature.EmployeeId = Convert.ToInt32(ddlEmployee.SelectedValue);
                objfature.FeatureId = Convert.ToInt32(e.CommandArgument);
                objfature.CreatedBy = CurrentUser.CurrentUserId;
                objfature.AddUpdate(objfature);
                BindgvAssigned();
                BindData();
            }
            else
            {
                ErrorMessage.Visible = true;
                ErrorMessage.Text = "Select Employee First";               
            }
        }
    }
    //This RowCommand will fire when un-assigning the feature.
    protected void gvAssign_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdRemove")
        {
            if (ddlEmployee.SelectedIndex > 0)
            {
                clsFeatureAccess objfeature = new clsFeatureAccess();
                objfeature.Remove(Convert.ToInt32(e.CommandArgument));
                BindgvAssigned();
                BindData();
            }
            else
            {
                ErrorMessage.Visible = true;
                ErrorMessage.Text = "Select Employee First";
            }
        }
    }
    protected void btnEmployeeFeatureSendMail_Click(object sender, EventArgs e)
    {
        Response.Redirect("UserSearch.aspx");
    }

    protected void btnEmployeeFeatuesAll_Click(object sender, EventArgs e)
    {
        Response.Redirect("EmployeeFeaturesAll.aspx");
    }

    protected void txtEmployee_TextChanged(object sender, EventArgs e)
    {
        BindEmployee();
    }
}