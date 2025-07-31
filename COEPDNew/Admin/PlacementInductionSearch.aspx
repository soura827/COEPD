<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="PlacementInductionSearch.aspx.cs" Inherits="Admin_PlacementInductionSearch" %>

<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        /*table caption{
            background-color : #2D2341;
            color : white;
            font-size : 16pt;
            text-align : center;
        }*/
        .ui-widget-content .ui-icon {
            /*background-image: url("../App_Themes/admin//images/ui-icons_222222_256x240.png")*/
            /*background-image:url("../App_Themes/admin/img/ui-icons_444444_256x240.png")*/
            background-image: url("../App_Themes/admin/img/ui-icons_3d80b3_256x240.png") !important;
        }

        .ui-widget-header .ui-icon {
            /*background-image: url("../App_Themes/admin/img/ui-icons_444444_256x240.png")*/
            background-image: url("../App_Themes/admin/img/ui-icons_3d80b3_256x240.png") !important;
        }
    </style>

    <script type="text/javascript">
        function alertmeSave() {
            Swal.fire(
                'Induction Added Successfully',
                '',
                'success'
            )
        }
        function alertmeUpdate() {
            Swal.fire(
                'Induction Updated Successfully',
                '',
                'success'
            )
        }

        function alertmeDuplicate() {
            Swal.fire(
                'Induction already exist',
                '',
                'warning'
            )
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" runat="Server">
    <uc1:FormMessage ID="FormMessage" runat="server" Visible="false" />
    <uc2:ErrorMessage ID="ErrorMessage" runat="server" Visible="false" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row">
        <asp:ScriptManager ID="ScriptManager1" 
                               runat="server" />
           
        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                       BA Job market  Induction
                    </div>
                </div>
                <div class="widget-body">
                    
                    <div class="col-lg-2 col-md-2">
                        <asp:TextBox runat="server" ID="txtSearch" MaxLength="500" placeholder="Search by Name, Email, Mobile, Ref.NO" OnTextChanged="txtSearch_TextChanged" AutoPostBack="true"></asp:TextBox>
                    </div>
                    <div class="col-md-2 col-lg-2">
                            <asp:TextBox runat="server" ID="txtLocation" MaxLength="500" placeholder="Location" AutoPostBack="true" OnTextChanged="txtLocation_TextChanged"></asp:TextBox>
                        </div>
                      <div class="col-md-2 col-lg-2">
                            <asp:TextBox runat="server" ID="txtTrainer" MaxLength="500" placeholder="Trainer" AutoPostBack="true" OnTextChanged="txtTrainer_TextChanged"></asp:TextBox>
                        </div>
                     <div class="col-md-2 col-lg-2">
                            <asp:DropDownList ID="ddlStatus" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlStatus_SelectedIndexChanged">
                                <asp:ListItem Text="HR Mock Pending/Evaluated" Value="False"></asp:ListItem>
                                <asp:ListItem Text="HR Mock Approved" Value="True"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    <div class="col-lg-2 col-md-2">
                        <asp:TextBox ID="txtFromDate" runat="server" CssClass="form-control" Placeholder="Attended From Date" OnTextChanged="txtFromDate_TextChanged" AutoPostBack="true"></asp:TextBox>
                    </div>
                    <div class="col-lg-2 col-md-2">
                        <asp:TextBox ID="txtToDate" runat="server" CssClass="form-control" Placeholder="Attended To Date" OnTextChanged="txtToDate_TextChanged" AutoPostBack="true"></asp:TextBox>
                    </div>
                    <br />
                    &nbsp;
                    <br />
                    <%-- <div class="col-lg-1 col-md-1">
                            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" SkinID="addnew" CausesValidation="false" />
                        </div>--%>
                    

                    <div class="row">
                        &nbsp;
                    </div>
                    <div>
                        <asp:Label ID="PageNumberHeader" runat="server"></asp:Label>
                    </div>
                    <div class="row">
                        <div class="table-responsive">
                            <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False" Width="100%" PageSize="50" HeaderStyle-HorizontalAlign="Center" AllowPaging="true" AllowSorting="true" OnRowCommand="gv_RowCommand" OnRowDataBound="gv_RowDataBound" OnPageIndexChanging="gv_PageIndexChanging" ShowHeaderWhenEmpty="true" EmptyDataText="No Records Found!" OnPreRender="gv_PreRender">
                                <Columns>

                                    <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                    <asp:BoundField HeaderText="Name" DataField="Participant" ItemStyle-Width="100px" />
                                    <asp:BoundField HeaderText="Mobile" DataField="Mobile" ItemStyle-Width="100px" />
                                    <asp:BoundField HeaderText="Email" DataField="Email" ItemStyle-Width="100px" />
                                    <asp:BoundField HeaderText="ReferenceNo" DataField="ReferenceNo" ItemStyle-Width="100px" />
                                    <asp:BoundField HeaderText="Assoicate" DataField="Employee" ItemStyle-Width="100px" />

                                    <asp:BoundField HeaderText="Location" DataField="Location" ItemStyle-Width="100px" />
                                    <asp:BoundField HeaderText="Batch Date" DataField="StartDate" ItemStyle-Width="50px" DataFormatString="{0: dd MMM yyyy}" />
                                    <asp:BoundField HeaderText="Trainer" DataField="Employee" ItemStyle-Width="100px" />
                                    <asp:BoundField HeaderText="Profile Owner" DataField="ProfileOwner" ItemStyle-Width="100px" />
                                     <asp:TemplateField HeaderText="HR Mock Feedback" ItemStyle-Width="100px">
                                        <ItemTemplate>
                                            <asp:HiddenField ID="hdnReplyFile" runat="server" Value='<%#Eval("HRMockFeebackImagePath") %>' />
                                            <asp:HyperLink NavigateUrl='<%#"~/UserDocs/PlacementHRMockFeedback/"+ Eval("HRMockFeebackImagePath") %>' runat="server"
                                                ID="hplReplyFile" Target="_blank" CssClass="btn btn-warning btn-xs">View Feedback</asp:HyperLink>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField HeaderText="Score" DataField="Score" ItemStyle-Width="100px" />
                                      <asp:TemplateField HeaderText="Status" ItemStyle-Width="100px">
                                        <ItemTemplate>
                                            <%# (Boolean.Parse(Eval("IsHRMockApproved").ToString()) ? "HR Mock Approved" : "HR Mock Pending" )%>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField HeaderText="Placement Induction Attended On" DataField="AttendedOn" ItemStyle-Width="50px" DataFormatString="{0: dd MMM yyyy}" />
                                    <asp:BoundField HeaderText="Subscription Expired On" DataField="SubscriptionExpiredOn" ItemStyle-Width="50px" DataFormatString="{0: dd MMM yyyy}" />
                                    <asp:TemplateField HeaderText="HR Mock" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="100px">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lnkEdit" runat="server" SkinID="Green" Text="Conduct HR Mock" CommandName="cmdEdit"
                                                CommandArgument='<%#Eval("PlacementInductionId")%>' Visible='<%# (Boolean.Parse(Eval("IsHRMockApproved").ToString())? false:true) %>'></asp:LinkButton>
                                            <%--<div>&nbsp;</div>--%>
                                            <%--<br />
                                            <br />--%>
                                            <asp:LinkButton ID="lnkView" runat="server" SkinID="Orange" Text="View" CommandName="cmdEdit"
                                                CommandArgument='<%#Eval("PlacementInductionId")%>' Visible='<%# (Boolean.Parse(Eval("IsHRMockApproved").ToString())? true:false) %>' ></asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                                <EmptyDataTemplate>
                                    <center>
                                        No Records Found
                                    </center>
                                </EmptyDataTemplate>
                            </asp:GridView>
                            <div>
                                <asp:Label ID="PageNumberFooter" runat="server"></asp:Label>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
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
    <!-- Row End -->
</asp:Content>

