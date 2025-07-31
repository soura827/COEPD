using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
public partial class Admin_InventorySearch : System.Web.UI.Page
{

    CurrentUser CurrentUser = new CurrentUser();
    protected void Page_PreInit(object sender, EventArgs e)
    {
        Page.Theme = "admin";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            BindInventoryType();
            BindInventoryClassification();
            BindInventoryStatus();
            BindData();
        }
    }

    protected void BindInventoryType()
    {
        clsInventoryType obj = new clsInventoryType();
        ddlInventoryType.DataSource = obj.LoadAll(obj);
        ddlInventoryType.DataTextField = "InventoryType";
        ddlInventoryType.DataValueField = "InventoryTypeId";
        ddlInventoryType.DataBind();
        ddlInventoryType.Items.Insert(0, new ListItem("-- Select Inventory Type  --", "0"));
    }
    protected void BindInventoryClassification()
    {
        clsInventoryClassification obj = new clsInventoryClassification();
        ddlInventoryClassification.DataSource = obj.LoadAll(obj);
        ddlInventoryClassification.DataTextField = "InventoryClassification";
        ddlInventoryClassification.DataValueField = "InventoryClassificationId";
        ddlInventoryClassification.DataBind();
        ddlInventoryClassification.Items.Insert(0, new ListItem("-- Select Classification --", "0"));
    }
    protected void BindInventoryStatus()
    {
        clsInventoryStatus obj = new clsInventoryStatus();
        ddlInventoryStatus.DataSource = obj.LoadAll(obj);
        ddlInventoryStatus.DataTextField = "InventoryStatus";
        ddlInventoryStatus.DataValueField = "InventoryStatusId";
        ddlInventoryStatus.DataBind();
        ddlInventoryStatus.Items.Insert(0, new ListItem("-- Select Inventory Status --", "0"));
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("Inventory.aspx");
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        BindData();
        txtSearch.Text = "";
    } 
    protected void BindData()
    {
        //if(CurrentUser.CurrentUserId !=2817)
        //{
            clsInventory obj1 = new clsInventory();
            obj1.keywords = txtSearch.Text;
            //obj1.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
            obj1.InventoryTypeId = Convert.ToInt16(ddlInventoryType.SelectedValue);
            obj1.InventoryClassificationId = Convert.ToInt16(ddlInventoryClassification.SelectedValue);
            obj1.InventoryStatusId = Convert.ToInt16(ddlInventoryStatus.SelectedValue);
            List<clsInventory> objList1 = obj1.LoadAll(obj1);
            if (objList1 != null)
            {
                for (int i = 0; i < objList1.Count; i++)
                {
                    if (objList1[i].NoOfItems <= objList1[i].OrderAlert)
                    {
                        objList1[i].Color = "Red";

                        //#region "Send Email"

                        //string strMessage = string.Empty;

                        //strMessage = "Hi ,<br /><br /><br />";
                        //strMessage = strMessage + "Inventory Stock Alert !!!<br /><br />";
                        //strMessage = strMessage + "Please find the below Inventory Reached Low Level.<br />";
                        //strMessage = strMessage + "Item Name : " + obj.InventoryName + "<br />";
                        //strMessage = strMessage + "No Of Items Left " + obj.NoOfItems + "<br /><br /><br />";
                        //string strSubject = "Inventory Stock Alert !!!";

                        //Alerts.SendMail("jogarao.coepd@gmail.com", strSubject, strMessage);
                        ////Alerts.SendMail("dhileep.coepd@gmail.com", strSubject, strMessage);
                        //#endregion
                    }
                }
            }
            gv.DataSource = objList1;
            gv.DataBind();

       // }
        //else 
        //{
        //    clsInventory obj = new clsInventory();
        //    obj.keywords = txtSearch.Text;
        //    //obj.CreatedBy = Convert.ToInt32(CurrentUser.CurrentUserId);
        //    obj.InventoryTypeId = Convert.ToInt16(ddlInventoryType.SelectedValue);
        //    obj.InventoryClassificationId = Convert.ToInt16(ddlInventoryClassification.SelectedValue);
        //    obj.InventoryStatusId = Convert.ToInt16(ddlInventoryStatus.SelectedValue);
        //    List<clsInventory> objList = obj.LoadAll(obj);
        //    if (objList != null)
        //    {
        //        for (int i = 0; i < objList.Count; i++)
        //        {
        //            if (objList[i].NoOfItems <= objList[i].OrderAlert)
        //            {
        //                objList[i].Color = "Red";

        //                //#region "Send Email"

        //                //string strMessage = string.Empty;

        //                //strMessage = "Hi ,<br /><br /><br />";
        //                //strMessage = strMessage + "Inventory Stock Alert !!!<br /><br />";
        //                //strMessage = strMessage + "Please find the below Inventory Reached Low Level.<br />";
        //                //strMessage = strMessage + "Item Name : " + obj.InventoryName + "<br />";
        //                //strMessage = strMessage + "No Of Items Left " + obj.NoOfItems + "<br /><br /><br />";
        //                //string strSubject = "Inventory Stock Alert !!!";

        //                //Alerts.SendMail("jogarao.coepd@gmail.com", strSubject, strMessage);
        //                ////Alerts.SendMail("dhileep.coepd@gmail.com", strSubject, strMessage);



        //                //#endregion

        //            }

        //        }
        //    }


        //    gv.DataSource = objList;
        //    gv.DataBind();
        //}
    }
    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "cmdEdit")
        {
            Response.Redirect("Inventory.aspx?ItemId=" + e.CommandArgument);
        }
        else if (e.CommandName == "cmdDelete")
        {
            clsInventory Item = new clsInventory();
            int ItemId = Convert.ToInt16(e.CommandArgument);
            Item.Remove(ItemId);
            BindData();
            ErrorMessage.Text = "Inventory successfully removed";
            ErrorMessage.Visible = true;
        }
    }
    protected void gv_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gv.PageIndex = e.NewPageIndex;
        BindData();
    }
    protected void ddlInventoryType_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }
    protected void ddlInventoryClassification_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }
    protected void ddlInventoryStatus_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }
}