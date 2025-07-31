<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="InstallmentFollowUp.aspx.cs" Inherits="Admin_InstallmentFollowUp" EnableEventValidation="false" %>

<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
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
                /*   maxDate: "1",*/
            });

            $("input[id$=txtToDate]").datepicker({
                dateFormat: 'dd/mm/yy',
                changeMonth: true,
                changeYear: true,
                /* maxDate: 1*/
            });
        });
    </script>
    <style type="text/css">
        table caption {
            background-color: #5D7B9D;
            color: White;
            font-size: 16px;
            text-align: center;
        }

        .ui-widget-content .ui-icon {
            background-image: url("../App_Themes/admin/img/ui-icons_3d80b3_256x240.png") !important;
        }

        .ui-widget-header .ui-icon {
            background-image: url("../App_Themes/admin/img/ui-icons_3d80b3_256x240.png") !important;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!-- Row Start -->
    <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        Participant Installments FollowUp 
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">
                        <div class="col-lg-2 col-md-2">
                            <asp:TextBox runat="server" ID="txtLead" placeholder="Search By Lead" OnTextChanged="txtLead_TextChanged" AutoPostBack="true"></asp:TextBox>
                        </div>
                        <div class="col-lg-2 col-md-2">
                            <asp:TextBox ID="txtFromDate" runat="server" CssClass="form-control" Placeholder="From Date" OnTextChanged="txtFromDate_TextChanged" AutoPostBack="true"></asp:TextBox>
                        </div>
                        <div class="col-lg-2 col-md-2">
                            <asp:TextBox ID="txtToDate" runat="server" CssClass="form-control" Placeholder="To Date" OnTextChanged="txtToDate_TextChanged" AutoPostBack="true"></asp:TextBox>
                        </div>

                        <div class="col-lg-2 col-md-2">
                            <asp:TextBox ID="txtmobile" runat="server" CssClass="form-control" Placeholder="Search by Mobile" OnTextChanged="txtmobile_TextChanged" AutoPostBack="true"></asp:TextBox>
                        </div>


                        <div class="col-lg-2 col-md-2">
                            <asp:TextBox ID="txtServiceOwner" runat="server" CssClass="form-control" Placeholder="Search by Service Owner" OnTextChanged="txtServiceOwner_TextChanged" AutoPostBack="true"></asp:TextBox>
                        </div>

                        <div class="col-lg-2 col-md-2">
                            <asp:TextBox ID="txtInstallments" runat="server" CssClass="form-control" Placeholder="Search by installments" OnTextChanged="txtInstallments_TextChanged" AutoPostBack="true"></asp:TextBox>
                        </div>

                         <div class="col-lg-2 col-md-2">
                                <asp:Button ID="btnDownload" runat="server" Text="Download" OnClick="btnDownload_Click"  UseSubmitBehavior="false" />
                        </div>
                  <div class="col-sm-2">
                                <asp:DropDownList ID="ddlInstallments" runat="server" required="" OnSelectedIndexChanged="ddlInstallments_SelectedIndexChanged" AutoPostBack="true">
                                    <asp:ListItem Value="0">SELECT Installments</asp:ListItem>
                                    <asp:ListItem Value="InstallMent-1">InstallMent-1</asp:ListItem>
                                    <asp:ListItem Value="InstallMent-2">InstallMent-2</asp:ListItem>
                                    <asp:ListItem Value="InstallMent-3">InstallMent-3</asp:ListItem>
                                    <asp:ListItem Value="InstallMent-4">InstallMent-4</asp:ListItem>
                                    <asp:ListItem Value="InstallMent">InstallMent</asp:ListItem>

                                </asp:DropDownList>
                            </div>
                    </div>
                    <div class="row">
                        &nbsp;
                    </div>
                    <div class="row">
                        &nbsp;
                    </div>


                    <div class="row">
                        <div class="table-responsive">
                            <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False" Width="100%" PageSize="100" HeaderStyle-HorizontalAlign="Center" AllowPaging="true" AllowSorting="true" ShowHeaderWhenEmpty="true" EmptyDataText="No Records Found!" OnPreRender="gv_PreRender" OnRowCommand="gv_RowCommand" OnRowDataBound="gv_RowDataBound">
                                <Columns>
                                    <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                    <asp:BoundField HeaderText="Lead" DataField="Lead" ItemStyle-Width="150px" />
                                    <asp:BoundField HeaderText="Batch Date" DataField="StartDate" DataFormatString="{0: dd MMM yyyy}" />
                                    <asp:BoundField HeaderText="Installment Date" DataField="InstallmentDate" DataFormatString="{0: dd MMM yyyy}" />
                                    <asp:BoundField HeaderText="Agreed Amount " DataField="AgreedFee" />
                                    <asp:BoundField HeaderText="Paying Amount " DataField="Amount" />
                                    <asp:BoundField HeaderText="Due Amount" DataField="Due" />
                                    <asp:BoundField HeaderText="InstallMents" DataField="Installments" />
                                    <asp:BoundField HeaderText="Mobile" DataField="Mobile" ItemStyle-Width="150px" />
                                    <%-- <asp:BoundField HeaderText="Service Owner" DataField="ServiceOwner" />--%>
                                    <asp:BoundField HeaderText="Created On" DataField="CreatedOn" DataFormatString="{0: dd MMM yyyy}" />
                                    <asp:BoundField HeaderText="Service Owner" DataField="Fullname" />

                                    <asp:TemplateField HeaderText="InstallmentStatus">
                                        <ItemTemplate>
                                            <%# (Boolean.Parse(Eval("IsInstallmentStatus").ToString()) ? "Paid" : "NotPaid" )%>
                                        </ItemTemplate>
                                    </asp:TemplateField>





                                    <asp:TemplateField HeaderText="InstallmentEditStatus" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="100px">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lnkEdit" runat="server" SkinID="Edit" CommandName="cmdEdit"
                                                CommandArgument='<%#Eval("FeeInstallmentId")%>'></asp:LinkButton>


                                            <asp:LinkButton ID="lnkDelete" runat="server" SkinID="delete" CommandName="cmdDelete"
                                                CommandArgument='<%#Eval("FeeInstallmentId")%>' Visible="false" OnClientClick="return confirm('Are you sure you want to delete this Record?');"></asp:LinkButton>


                                        </ItemTemplate>
                                    </asp:TemplateField>










                                    <asp:TemplateField HeaderText="Action" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="50px">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lnkStatus" runat="server" Text="Enter Payment Details" SkinID="view" CommandName="cmdStatus"
                                                CommandArgument='<%#Eval("FeeInstallmentId")%>'></asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>


                                </Columns>
                                <EmptyDataTemplate>
                                    <center>
                                        No Records Found
                                    </center>
                                </EmptyDataTemplate>
                            </asp:GridView>

                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

