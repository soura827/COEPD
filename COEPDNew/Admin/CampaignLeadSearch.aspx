<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="CampaignLeadSearch.aspx.cs" Inherits="Admin_CampaignLeadSearch" %>
<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        table caption{
            background-color : #2D2341;
            color : white;
            font-size : 16pt;
            text-align : center;
        }
         .ui-widget-content .ui-icon {
    /*background-image: url("../App_Themes/admin//images/ui-icons_222222_256x240.png")*/ 
    /*background-image:url("../App_Themes/admin/img/ui-icons_444444_256x240.png")*/
     background-image:url("../App_Themes/admin/img/ui-icons_3d80b3_256x240.png")      
            !important;}
    .ui-widget-header .ui-icon {
    /*background-image: url("../App_Themes/admin/img/ui-icons_444444_256x240.png")*/ 
    background-image:url("../App_Themes/admin/img/ui-icons_3d80b3_256x240.png")  
        !important;}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" Runat="Server">
     <uc1:FormMessage ID="FormMessage" runat="server" Visible="false" />
    <uc2:ErrorMessage ID="ErrorMessage" runat="server" Visible="false" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <!-- Row Start -->
   <%-- <asp:ScriptManager ID="scriptmanager" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel" runat="server">
    <ContentTemplate>--%>
    <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                          Campaign Leads
                    </div>
                </div>
                
                <div class="widget-body">
                    <div class="row">
                        <div class="col-lg-2 col-md-2">
                            <asp:TextBox runat="server" ID="txtTitle" MaxLength="100" placeholder="Offer Title" AutoPostBack="true" OnTextChanged="txtTitle_TextChanged" ></asp:TextBox>
                        </div>
                        <div class="col-lg-2 col-md-2">
                            <asp:TextBox runat="server" ID="txtLocation" MaxLength="100" placeholder="Location" AutoPostBack="true" OnTextChanged="txtLocation_TextChanged" ></asp:TextBox>
                        </div>
                          <div class="col-lg-2 col-md-2">
                             <asp:TextBox ID="txtFromDate" runat="server" CssClass="form-control" Placeholder="From Date" OnTextChanged="txtFromDate_TextChanged" AutoPostBack="true"></asp:TextBox>
                        </div>
                            <div class="col-lg-2 col-md-2">
                            <asp:TextBox ID="txtToDate" runat="server" CssClass="form-control" Placeholder="To Date" OnTextChanged="txtToDate_TextChanged" AutoPostBack="true"></asp:TextBox>
                        </div>
                        <%--<div class="col-lg-2  col-md-2">
                            <asp:Button ID="btnAdd" runat="server"  SkinID="addnew" AutoPostBack="True" CausesValidation="false" OnClick="btnAdd_Click"/>
                        </div>--%>
                    </div>
                    <div class="row">
                        &nbsp;
                    </div>
                    <div>
                        <asp:Label ID="PageNumberHeader" runat="server"></asp:Label>
                    </div>
                      <div class="row"> 
                          <asp:GridView ID="gv" runat="server" AutoGenerateColumns="false" PageSize="20" HeaderStyle-HorizontalAlign="Center" Width="100%" AllowPaging="true" AllowSorting="true" OnPageIndexChanging="gv_PageIndexChanging" ShowHeaderWhenEmpty="true" EmptyDataText="No Records Found!" OnPreRender="gv_PreRender">
                              <Columns>                                  
                                  <asp:BoundField HeaderText="S.No" DataField="SNo" />
                                  <asp:BoundField HeaderText="Campaign Owner" DataField="FullName" />
                                  <asp:BoundField HeaderText="Campaign Id" DataField="Offer" />
                                  <asp:BoundField HeaderText="Campaign Title" DataField="Title" />
                                  <asp:BoundField HeaderText="Lead Name" DataField="Name" />
                                  <asp:BoundField HeaderText="Lead Email" DataField="EmailId" />
                                  <asp:BoundField HeaderText="Lead Mobile" DataField="MobileNo" />
                                  <asp:BoundField HeaderText="Lead Location" DataField="Location" />
                                  <asp:BoundField HeaderText="Lead Specific Enquiry" DataField="SpecificEnquiry" />
                                   <asp:BoundField HeaderText=" Lead Created On" DataField="CreatedOn" DataFormatString="{0: dd MMM yyyy hh:mm tt}" />
                              </Columns>
                          </asp:GridView>
                          <div>
                              <asp:Label ID="PageNumberFooter" runat="server"></asp:Label>
                          </div>
                      </div>
                    </div>  
                </div>
            </div>
        </div>
    <%-- </ContentTemplate>
    </asp:UpdatePanel>--%>
    <!-- Row End -->
     <script type="text/javascript" src="../App_Themes/admin/js/jquery.js"></script>
    <script type="text/javascript" src="../App_Themes/admin/js/jquery-ui-v1.10.3.js"></script>

    <script type="text/javascript">
        $(document).ready(function ($) {

            $("input[id$=txtFromDate]").datepicker({
                value: new Date().toDateString(),
                changeMonth: true,
                changeYear: true,
                changeprevious: true,
                dateFormat: 'dd/mm/yy',
                maxDate: "0",
            });

            $("input[id$=txtToDate]").datepicker({
                changeMonth: true,
                changeYear: true,
                dateFormat: 'dd/mm/yy',
                maxDate: "0"
            });
        });
    </script>
</asp:Content>

