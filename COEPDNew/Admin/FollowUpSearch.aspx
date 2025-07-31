<%@ Page Title="" Language="C#" MasterPageFile="Admin.master" AutoEventWireup="true"
    CodeFile="FollowUpSearch.aspx.cs" Inherits="FollowUpSearch" %>

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
                maxDate: "0",
            });

            $("input[id$=txtToDate]").datepicker({
                dateFormat: 'dd/mm/yy',
                changeMonth: true,
                changeYear: true,
                maxDate: 0
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
                        FollowUp List
                    </div>
                </div>
                <div class="widget-body">

                    <div class="row">
                        <div class="col-lg-2 col-md-2">
                            <asp:DropDownList ID="ddlCourse" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlCourse_SelectedIndexChanged">
                            </asp:DropDownList>
                        </div>
                        <div class="col-lg-2 col-md-2">
                            <asp:DropDownList ID="ddlBatchType" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlBatchType_SelectedIndexChanged">
                            </asp:DropDownList>
                        </div>
                        <div class="col-lg-2 col-md-2">
                            <asp:DropDownList ID="ddlLocation" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlLocation_SelectedIndexChanged">
                            </asp:DropDownList>
                                 <asp:DropDownList ID="ddlRasikaLocation" runat="server" AutoPostBack="true" Visible="false" OnSelectedIndexChanged="ddlRasikaLocation_SelectedIndexChanged">
                                <asp:ListItem Value="3" Selected="True" >Pune </asp:ListItem>
                                <asp:ListItem Value="4">Mumbai </asp:ListItem>
                                <asp:ListItem Value="7">Bangalore</asp:ListItem>
                                <asp:ListItem Value="8">Delhi - NCR</asp:ListItem>
                            </asp:DropDownList>

                        </div>
                        <div class="col-lg-2 col-md-2">
                            <asp:TextBox runat="server" ID="txtSearch" placeholder="Search"></asp:TextBox>
                        </div>
                        <div class="col-lg-2 col-md-2">
                            <asp:TextBox runat="server" ID="txtAspirantName" placeholder="Search By Aspirant Name"></asp:TextBox>
                        </div>

                        <div class="col-lg-2 col-md-2">
                            <asp:TextBox runat="server" ID="txtPrimaryMobile" placeholder="Search By PrimaryMobile"></asp:TextBox>
                        </div>

                    </div>

                    <div class="row">
                        <div class="col-lg-9 col-md-9">
                            &nbsp;
                        </div>
                    </div>


                    <div class="row">
                        <div class="col-lg-2 col-md-2">
                            <asp:TextBox runat="server" ID="txtPrimaryEmail" placeholder="Search By PrimaryEmail"></asp:TextBox>
                        </div>


                        <div class="col-lg-2 col-md-2">
                            <asp:TextBox runat="server" ID="txtFromDate" placeholder="Search By FromDate" ></asp:TextBox>
                        </div>

                        <div class="col-lg-2 col-md-2">
                            <asp:TextBox runat="server" ID="txtToDate" placeholder="Search By Todate" ></asp:TextBox>
                        </div>




                        <div class="col-lg-3 col-md-3">
                            <asp:Button ID="btnSearch" runat="server" Text="Find" OnClick="btnSearch_Click" />
                        </div>
                    </div>





                    <div class="row">
                        &nbsp;
                    </div>
                    <div class="row">
                        <div class="table-responsive">
                            <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False" OnRowCommand="gv_RowCommand"
                                Width="100%">
                                <Columns>
                                    <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                    <asp:BoundField HeaderText="Course" DataField="Course" />
                                    <asp:BoundField HeaderText="BatchType" DataField="BatchType" />
                                    <asp:BoundField HeaderText="Location" DataField="Location" />
                                    <asp:BoundField HeaderText="Aspirant Name" DataField="Lead" />
                                    <asp:BoundField HeaderText="Mobile" DataField="PrimaryMobile" />
                                    <asp:BoundField HeaderText="Email" DataField="PrimaryEmail" />
                                    <asp:BoundField HeaderText="User" DataField="Username" />
                                    <asp:BoundField HeaderText="Date" DataField="CreatedOn" DataFormatString="{0:dd MMM yyyy}" />
                                    <asp:TemplateField HeaderText="Review" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center"
                                        ItemStyle-Width="50px">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lnkEdit" runat="server" Text="Review" CommandName="cmdEdit" CommandArgument='<%#Eval("LeadId")%>'></asp:LinkButton>
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
    <!-- Row End -->
</asp:Content>
