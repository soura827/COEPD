<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="ActivityTaskInputsReport.aspx.cs" Inherits="Admin_ActivityTaskInputsReport" %>

<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
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
  <%--<asp:ScriptManager ID="scriptmanager" runat="server"></asp:ScriptManager>--%>
    <%--<asp:UpdatePanel ID="UpdatePanel" runat="server">--%>
  <%--  <ContentTemplate>--%>
    <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                          Activity Interaction Tasks
                    </div>
                </div>
                
                <div class="widget-body">
                    <div class="row">
                        <div class="form-group">
                         <div class="col-lg-3 col-md-3">
                            <asp:TextBox runat="server" ID="txtActivityCategory" MaxLength="500" placeholder="Search By Activity Category" OnTextChanged="txtActivityCategory_TextChanged" AutoPostBack="true" ></asp:TextBox>
                        </div>
                        <div class="col-lg-3 col-md-3">
                            <asp:TextBox runat="server" ID="txtActivitySubCategory" MaxLength="500" placeholder="Search By Activity Subcategory" OnTextChanged="txtActivitySubCategory_TextChanged" AutoPostBack="true" ></asp:TextBox>
                        </div>
                          <div class="col-lg-3 col-md-3">
                            <asp:TextBox runat="server" ID="txtActivity" MaxLength="500" placeholder="Search By Activity" OnTextChanged="txtActivity_TextChanged" AutoPostBack="true"></asp:TextBox>
                        </div>
                            <div class="col-lg-3 col-md-3">
                            <asp:TextBox runat="server" ID="txtInputsEnteredBy" MaxLength="500" placeholder="Search By Inputs Entered By" OnTextChanged="txtInputsEnteredBy_TextChanged" AutoPostBack="true"></asp:TextBox>
                        </div>
                            </div>
                        <br />
                        <br />
                        <div class="form-group">
                         <div class="col-lg-3 col-md-3">
                            <asp:TextBox runat="server" ID="txtInvolvedEmployees" placeholder="Search By Involved Employees" OnTextChanged="txtInvolvedEmployees_TextChanged" AutoPostBack="true" ></asp:TextBox>
                        </div>
                        <div class="col-lg-3 col-md-3">
                            <asp:TextBox runat="server" ID="txtInvolvedParticipants" placeholder="Search By Involved Participants" OnTextChanged="txtInvolvedParticipants_TextChanged" AutoPostBack="true" ></asp:TextBox>
                        </div>
                          <div class="col-lg-3 col-md-3">
                            <asp:TextBox runat="server" ID="txtInvolvedLeads" placeholder="Search By Involved Leads" OnTextChanged="txtInvolvedLeads_TextChanged" AutoPostBack="true"></asp:TextBox>
                        </div>
                            <div class="col-lg-3 col-md-3">
                            <asp:TextBox runat="server" ID="txtInvolvedVendors" placeholder="Search By Involved Vendors" OnTextChanged="txtInvolvedVendors_TextChanged" AutoPostBack="true"></asp:TextBox>
                        </div>
                            </div>
                        <br />
                        <br />
                        <%--<div class="form-group">
                        <div class="col-lg-4 col-md-4">
                            <asp:TextBox runat="server" ID="txtEmployee" MaxLength="500" placeholder="Search By Employee" OnTextChanged="txtEmployee_TextChanged" AutoPostBack="true" ></asp:TextBox>
                        </div>
                        <div class="col-lg-4 col-md-4">
                            <asp:TextBox runat="server" ID="txtParticipant" MaxLength="500" placeholder="Search By Participant" OnTextChanged="txtParticipant_TextChanged" AutoPostBack="true"></asp:TextBox>
                        </div>
                        <div class="col-lg-4 col-md-4">
                            <asp:TextBox runat="server" ID="txtLead" MaxLength="500" placeholder="Search By Lead" OnTextChanged="txtLead_TextChanged" AutoPostBack="true"></asp:TextBox>
                        </div>
                            </div>
                        <br />
                        <br />--%>
                        <div class="form-group">
                        <div class="col-lg-4 col-md-4">
                            <asp:TextBox runat="server" ID="txtBranch" MaxLength="100" placeholder="Search By Branch Name" OnTextChanged="txtBranch_TextChanged" AutoPostBack="true"></asp:TextBox>
                        </div>
                        <div class="col-lg-1 col-md-1">
                            <label>From Date:</label>
                        </div>
                        <div class="col-lg-3 col-md-3">
                            <asp:TextBox ID="txtFromDate" runat="server" CssClass="form-control" Placeholder="From Date" OnTextChanged="txtFromDate_TextChanged" AutoPostBack="true"></asp:TextBox>
                        </div>
                        <div class="col-lg-1 col-md-1">
                            <label>To Date: </label>
                        </div>
                        <div class="col-lg-3 col-md-3">
                            <asp:TextBox ID="txtToDate" runat="server" CssClass="form-control" Placeholder="To Date" OnTextChanged="txtToDate_TextChanged" AutoPostBack="true"></asp:TextBox>
                        </div>
                    </div>
                        </div>
                    <div class="row">
                        &nbsp;
                    </div>
                    <div>
                        <asp:Label ID="PageNumberHeader" runat="server"></asp:Label>
                    </div>
                      <div class="row"> 
                          <div class="table-responsive">
                          <asp:GridView ID="gv" runat="server" AutoGenerateColumns="false" PageSize="10" HeaderStyle-HorizontalAlign="Center" Width="100%" AllowPaging="true" AllowSorting="true" OnRowCommand="gv_RowCommand" OnPageIndexChanging="gv_PageIndexChanging" ShowHeaderWhenEmpty="true" EmptyDataText="No Records Found!" OnPreRender="gv_PreRender">
                              <Columns>
                                  
                                  <asp:BoundField HeaderText="S.No" DataField="SNo" />
                                  <asp:BoundField HeaderText="Created On" DataField="CreatedOn" DataFormatString="{0:dd MMM yyyy hh:mm tt}" />
                                  <asp:BoundField HeaderText="Task Inputs" DataField="ActivityInteractionInputs" />
                                  <asp:BoundField HeaderText="Target Date" DataField="DateToWorkOn" DataFormatString="{0:dd MMM yyyy}" />
                                  <asp:BoundField HeaderText="Status" DataField="Status" />
                                  <asp:BoundField HeaderText="Involved Employees" DataField="InvolvedEmployees" />
                                  <asp:BoundField HeaderText="Involved Participants" DataField="InvolvedParticipants" />
                                  <asp:BoundField HeaderText="Involved Leads" DataField="InvolvedLeads" />
                                  <asp:BoundField HeaderText="Involved Vendors" DataField="InvolvedVendros" />
                                  <asp:BoundField HeaderText="Inputs By" DataField="Fullname" />
                                  <asp:BoundField HeaderText="SStart Time" DataField="SystemStartTime" DataFormatString="{0: dd MMM yyyy hh:mm tt}" />
                                  <%--<asp:BoundField HeaderText="SEnd Time" DataField="SystemEndTime" />--%>
                                  <asp:BoundField HeaderText="SDur.(Min.)" DataField="SystemMinutes" />
                                  <asp:BoundField HeaderText="EStart Time" DataField="EnteredStartTime" DataFormatString="{0: dd MMM yyyy hh:mm tt}" />
                                  <%--<asp:BoundField HeaderText="EEnd Time" DataField="EnteredEndTime" />--%>
                                  <asp:BoundField HeaderText="EDur.(Min.)" DataField="EnteredMinutes" />
                                  <%--<asp:BoundField HeaderText="Branch Name" DataField="Branch" />
                                  <asp:BoundField HeaderText="Activity Category" DataField="ActivityCategory" />
                                  <asp:BoundField HeaderText="Activity Subcategory" DataField="ActivitySubCategory" />--%>
                                  <%--<asp:BoundField HeaderText="Activity" DataField="Activity" />--%>
                                  <%--<asp:BoundField HeaderText="No. of Employees" DataField="NoOfEmployeeId" />
                                   <asp:BoundField HeaderText="No. of Participants" DataField="NoOfParticipantId" />
                                    <asp:BoundField HeaderText="No. of Leads" DataField="NoOfLeads" />
                                  <asp:BoundField HeaderText="No. of Vendors" DataField="NoOfVendors" />--%>
                                   <%--<asp:TemplateField HeaderText="Action" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="150px">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lnkEdit" runat="server" SkinID="edit" CommandName="cmdEdit"
                                            CommandArgument='<%#Eval("ActivityId")%>'></asp:LinkButton>
                                        <asp:LinkButton ID="lnkDelete" runat="server" SkinID="delete" CommandName="cmdDelete"
                                            CommandArgument='<%#Eval("ActivityId")%>' OnClientClick="return confirm('Are you sure you want to delete this Activity?');"></asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>--%>
                              </Columns>
                          </asp:GridView>
                              </div>
                          <div>
                              <asp:Label ID="PageNumberFooter" runat="server"></asp:Label>
                          </div>
                      </div>
                    </div>
                </div>
            </div>
        </div>
<%--     </ContentTemplate>
    </asp:UpdatePanel>--%>
    <!-- Row End -->
    <script type="text/javascript" src="../App_Themes/admin/js/jquery.js"></script>
    <script type="text/javascript" src="../App_Themes/admin/js/jquery-ui-v1.10.3.js"></script>

    <script type="text/javascript">
        $(document).ready(function ($) {

            $("input[id$=txtFromDate]").datepicker({
                value: new Date().toDateString(),
                dateFormat: 'dd/mm/yy',
                changeMonth: true,
                changeYear: true,
                changeprevious: true,
                maxDate: "0",
            });

            $("input[id$=txtToDate]").datepicker({
                dateFormat: 'dd/mm/yy',
                changeMonth: true,
                changeYear: true,
                maxDate: "0"
            });
        });
    </script>
</asp:Content>

