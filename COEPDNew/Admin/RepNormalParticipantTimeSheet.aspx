<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="RepNormalParticipantTimeSheet.aspx.cs" Inherits="Admin_RepNormalParticipantTimeSheet"EnableEventValidation="false"  %>

<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <script type="text/javascript" src="../App_Themes/admin/js/jquery.js"></script>
    <script type="text/javascript" src="../App_Themes/admin/js/jquery-ui-v1.10.3.js"></script>
    <script type="text/javascript">
        $(document).ready(function ($) {
            $("input[id$=txtFromDate]").datepicker({
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
    <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        Participant Login Report
                    </div>
                </div>
                <div class="widget-body">
                    <%--<div class="row">
                        <div class="col-md-1">
                            <h5>Batch</h5>
                        </div>
                        <div class="col-md-8">
                            <asp:DropDownList ID="ddlBatch" runat="server" required="required" AutoPostBack="true"
                                OnSelectedIndexChanged="ddlBatch_SelectedIndexChanged">
                            </asp:DropDownList>
                        </div>
                        <div class="col-md-2">
                            <h5>Participant</h5>
                        </div>
                    </div>--%>
                    <div class="row">
                        &nbsp;
                    </div>
                    <div class="row">
                        <div class="col-md-2">
                            <asp:TextBox runat="server" ID="txtParticipant" Placeholder="Participant Name, Email, Mobile, Reference Number" AutoPostBack="true" OnTextChanged="txtParticipant_TextChanged"></asp:TextBox>

                        </div>
                        <div class="col-md-1">
                            <h5>From</h5>
                        </div>
                        <div class="col-md-2">
                            <asp:TextBox ID="txtFromDate" runat="server" Placeholder="From Date" AutoPostBack="true" OnTextChanged="txtFromDate_TextChanged"></asp:TextBox>
                        </div>
                        <div class="col-md-1">
                            <h5>To</h5>
                        </div>
                        <div class="col-md-2">
                            <asp:TextBox ID="txtToDate" runat="server" Placeholder="To Date" AutoPostBack="true" OnTextChanged="txtToDate_TextChanged"></asp:TextBox>
                        </div>
                        <div class="col-lg-2 col-md-2">
                                <asp:Button ID="btnDownload" runat="server" Text="Download" OnClick="btnDownload_Click" UseSubmitBehavior="false" />
                        </div>
                        <div class="col-md-4">
                        </div>
                        <div class="col-md-1">
                        </div>
                    </div>
                    <div class="row">
                        &nbsp;
                    </div>
                    <div class="row">
                        <div class="table-responsive">
                        <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False" HeaderStyle-HorizontalAlign="Center">
                            <HeaderStyle Wrap="true" />
                            <Columns>
                                <asp:TemplateField HeaderText="SNo">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("SNo") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("SNo") %>'></asp:Label>
                                    </ItemTemplate>
                                    <ItemStyle Width="50px" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Participant Name">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("Participant") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label4" runat="server" Text='<%# Bind("Participant") %>'></asp:Label>
                                    </ItemTemplate>
                                    <HeaderStyle HorizontalAlign="Center" />
                                    <ItemStyle Width="200px" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="BatchDate">
                                    <ItemStyle Width="90px"  />
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("InternBatchDate") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("InternBatchDate", "{0:dd MMM yyyy}") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Location">
                                    <HeaderTemplate><center>Location</center></HeaderTemplate>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBox5" runat="server" Text='<%# Bind("Location") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label5" runat="server" Text='<%# Bind("Location") %>'></asp:Label>
                                    </ItemTemplate>
                                    <ItemStyle Width="100px" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Trainer">
                                    <HeaderTemplate><center>Trainer</center></HeaderTemplate>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBox6" runat="server" Text='<%# Bind("Employee") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label6" runat="server" Text='<%# Bind("Employee") %>'></asp:Label>
                                    </ItemTemplate>
                                    <ItemStyle Width="100px" />
                                </asp:TemplateField>
                                <asp:BoundField HeaderText="ReferenceNo" ItemStyle-Width="20px" DataField="ReferenceNo"  >
                                <ItemStyle Width="20px"></ItemStyle>
                                </asp:BoundField>
                                <asp:TemplateField HeaderText="Date" ItemStyle-Width="85px" >
                                   <HeaderTemplate> <center>Date</center> </HeaderTemplate>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("Date") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("Date", "{0:dd MMM yyyy}") %>'></asp:Label>
                                    </ItemTemplate>

                                <ItemStyle Width="85px"></ItemStyle>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Start Time" ItemStyle-Width="70px">                              
                                    <ItemTemplate>
                                        <%# Eval("StartTime", "{0:hh:mm}") %>  <%# Eval("StartTimeAmPm") %>
                                    </ItemTemplate>

                                <ItemStyle Width="70px"></ItemStyle>
                                </asp:TemplateField>                           
                                <asp:TemplateField HeaderText="End Time" ItemStyle-Width="70px" >
                                    <ItemTemplate>
                                        <%# Eval("EndTime", "{0:hh:mm}") %> <%# Eval("EndTimeAmPm") %>
                                    </ItemTemplate>

                                   <ItemStyle Width="70px"></ItemStyle>
                                </asp:TemplateField>                          
                                <asp:TemplateField HeaderText="Description" ItemStyle-HorizontalAlign="Center">
                                    <HeaderTemplate><center>Description</center></HeaderTemplate>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBox7" runat="server" Text='<%# Bind("Note") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label7" runat="server" Text='<%# Bind("Note") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                 <asp:TemplateField HeaderText="LoginIp:" ItemStyle-HorizontalAlign="Center">
                                    <HeaderTemplate><center>Login IP</center></HeaderTemplate>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBox8" runat="server" Text='<%# Bind("LoginIPAddress") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label8" runat="server" Text='<%# Bind("LoginIPAddress") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="LogOutIp:" ItemStyle-HorizontalAlign="Center">
                                    <HeaderTemplate><center>LogOut IP</center></HeaderTemplate>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBox9" runat="server" Text='<%# Bind("LogoutIPAddress") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label9" runat="server" Text='<%# Bind("LogoutIPAddress") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                            <EmptyDataTemplate>
                                <center>
                                    No Records Found
                                </center>
                            </EmptyDataTemplate>

<HeaderStyle HorizontalAlign="Center"></HeaderStyle>
                        </asp:GridView>
                            </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Row End -->
</asp:Content>

