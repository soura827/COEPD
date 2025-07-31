<%@ Page Title="" Language="C#" MasterPageFile="Admin.master" AutoEventWireup="true"
    CodeFile="ParticipantSearch.aspx.cs" Inherits="ParticipantSearch" %>

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
     background-image:url("../App_Themes/admin/img/ui-icons_3d80b3_256x240.png")      
            !important;}
    .ui-widget-header .ui-icon {
    /*background-image: url("../App_Themes/admin/img/ui-icons_444444_256x240.png")*/ 
    background-image:url("../App_Themes/admin/img/ui-icons_3d80b3_256x240.png")  
        !important;}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" runat="Server">
    <uc1:FormMessage ID="FormMessage" runat="server" Visible="false" />
    <uc2:ErrorMessage ID="ErrorMessage" runat="server" Visible="false" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!-- Row Start -->
    <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        Participants
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">
                      <%--  <div class="col-lg-2 col-md-2">
                            <asp:DropDownList ID="ddlCourse" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlCourse_SelectedIndexChanged">
                            </asp:DropDownList>
                        </div>
                        <div class="col-lg-2 col-md-2">
                            <asp:DropDownList ID="ddlBatchType" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlBatchType_SelectedIndexChanged">
                            </asp:DropDownList>
                        </div>--%>
                        <div class="col-lg-2 col-md-2">
                             <asp:TextBox ID="txtFromDate" runat="server" CssClass="form-control" Placeholder="Batch From Date" OnTextChanged="txtFromDate_TextChanged" AutoPostBack="true"></asp:TextBox>
                        </div>
                            <div class="col-lg-2 col-md-2">
                            <asp:TextBox ID="txtToDate" runat="server" CssClass="form-control" Placeholder="Batch To Date" OnTextChanged="txtToDate_TextChanged" AutoPostBack="true"></asp:TextBox>
                        </div>
                         <div class="col-lg-3 col-md-3">
                            <asp:TextBox runat="server" ID="txtSearch" MaxLength="500" placeholder="Search by Name, Email, Mobile, Ref.NO" OnTextChanged="txtSearch_TextChanged" AutoPostBack="true"></asp:TextBox>
                        </div>
                        <div class="col-lg-2 col-md-2">
                            <asp:DropDownList ID="ddlLocation" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlLocation_SelectedIndexChanged">
                            </asp:DropDownList>
                        </div>
                        <div class="col-lg-2 col-md-2">
                            <asp:DropDownList ID="ddlTrainer" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlTrainer_SelectedIndexChanged">
                            </asp:DropDownList>
                        </div>
                       
                        <%--<div class="col-lg-1 col-md-1">
                            <asp:Button ID="btnSearch" runat="server" Text="Find" OnClick="btnSearch_Click" />
                        </div>--%>
                        <div class="col-lg-1 col-md-1">
                            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" SkinID="addnew" CausesValidation="false" />
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
                        <asp:GridView ID="gv" runat="server" OnRowCommand="gv_RowCommand" OnPageIndexChanging="gv_PageIndexChanging" OnRowDataBound="gv_RowDataBound" AllowPaging="true" PageSize="10" AutoGenerateColumns="False" Width="100%" OnPreRender="gv_PreRender" Caption="">
                            <PagerSettings Mode="NumericFirstLast" FirstPageText="First" LastPageText="Last" />
                            <Columns>
                                <asp:TemplateField HeaderText="Action" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="150px">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lnkEdit" runat="server" SkinID="edit" CommandName="cmdEdit"
                                            CommandArgument='<%#Eval("ParticipantId")%>'></asp:LinkButton>
                                        <asp:LinkButton ID="lnkDelete" runat="server" SkinID="delete" CommandName="cmdDelete"
                                            Visible="false" CommandArgument='<%#Eval("ParticipantId")%>' OnClientClick="return confirm('Are you sure you want to delete this Record?');"></asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                <asp:BoundField HeaderText="BatchDate" DataField="StartDate" DataFormatString="{0:dd MMM yyyy}"
                                    ItemStyle-Width="100px" />
                                <asp:BoundField HeaderText="ReferenceNo" DataField="ReferenceNo" />
                                <asp:BoundField HeaderText="Participant" DataField="Participant" ItemStyle-Width="200px" />
                                <asp:BoundField HeaderText="Location" DataField="Location" ItemStyle-Width="50px" />
                                <asp:BoundField HeaderText="Trainer" DataField="Employee" ItemStyle-Width="50px" />
                                <asp:BoundField HeaderText="Domain" DataField="Domain" ItemStyle-Width="50px" />
                                 <asp:BoundField HeaderText="Years Of Experience" DataField="YearsOfExp" />
                                <asp:BoundField HeaderText="Months Of Experience" DataField="MonthsOfExp" />
                                <asp:BoundField HeaderText="Email" DataField="Email" />
                                <asp:TemplateField HeaderText="Certificate" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="50px">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lnkDownload" runat="server" Text="Download" CommandName="cmdDownload"
                                            Visible="false" CommandArgument='<%#Eval("CertificatePath")%>'></asp:LinkButton>
                                        <asp:HiddenField ID="hdnCertificatePath" runat="server" Value='<%#Eval("CertificatePath")%>' />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField HeaderText="Mobile" DataField="Mobile" ItemStyle-Width="50px" />
                                <asp:BoundField HeaderText="Subscription Expired On" DataField="SubscriptionExpiredOn" DataFormatString="{0:dd MMM yyyy}"
                                    ItemStyle-Width="100px" />
                                <asp:BoundField HeaderText="Last Slot On" DataField="LastSlotStartTime" DataFormatString="{0:dd MMM yyyy hh:mm tt}" ItemStyle-Width="300px" />
                                <asp:BoundField HeaderText="Password" DataField="Pwd" ItemStyle-Width="50px" />
                                
                                <asp:TemplateField HeaderText="Send Pwd" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="50px">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lnkSend" runat="server" Text="SendPwd" SkinID="Orange" CommandName="cmdSend"
                                            CommandArgument='<%#Eval("ParticipantId")%>'></asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                               <%-- <asp:TemplateField HeaderText="Assign Default Features" ItemStyle-HorizontalAlign ="Center">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lnkAssignDefaultFeatures" runat="server" Text="Assign Default Features" CommandName="cmdAssignDefaultFeatures"
                                            CommandArgument='<%#Eval("ParticipantId") %>'></asp:LinkButton>
                                     </ItemTemplate>
                                </asp:TemplateField>--%>
                            </Columns>
                            <PagerStyle HorizontalAlign="Center" VerticalAlign="Bottom" />
                            <EmptyDataTemplate>
                                <center>
                                    No Records Found
                                </center>
                            </EmptyDataTemplate>
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
    <!-- Row End -->
    <div class="box-theme">
        <div class="box-title">
            <div class="box-head">
            </div>
            <div class="box-button">
                <asp:Label ID="lblMessage" runat="server"></asp:Label>
            </div>
        </div>
        <div class="panel-body">
            <div class="row">
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
               
            });

            $("input[id$=txtToDate]").datepicker({
                changeMonth: true,
                changeYear: true,
                dateFormat: 'dd/mm/yy',
               
            });
        });
    </script>
</asp:Content>
