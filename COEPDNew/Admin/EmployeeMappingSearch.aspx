<%@ Page Title="" Language="C#" MasterPageFile="Admin.master" AutoEventWireup="true"
    CodeFile="EmployeeMappingSearch.aspx.cs" Inherits="EmployeeMappingSearch" %>

<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    
    <script language="javascript" type="text/javascript">
        function alertmeSelectReportingmanager() {
            Swal.fire(
                'Please Select ReportingManager',
                'in Dropdownlist',
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
    <!-- Row Start -->
    <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        Employee Mapping ( Assigning Employees to ReportingManager)
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">
                        &nbsp;
                    </div>
                    <div class="row">
                        <div class="col-lg-5 col-md-5">
                            <h4 class="text-center">UnAssigned Employees</h4>
                        </div>
                        <div class="col-lg-1 col-md-1">
                        </div>
                        <div class="col-lg-5 col-md-5">
                            <h4 class="text-center">Reporting Manager</h4>
                        </div>
                    </div>
                    <div class="row">
                        &nbsp;
                    </div>
                    <div class="row">
                        <div class="col-lg-1 col-md-1">
                             <h5>Search UnAssigned Employee </h5>
                        </div>
                        <div class="col-lg-3 col-md-3">
                            <asp:TextBox ID="txtSearchEmployee" runat="server" AutoPostBack="true" OnTextChanged="txtSearchEmployee_TextChanged"></asp:TextBox>
                        </div>
                        <div class="col-lg-3 col-md-3">
                        </div>
                        <div class="col-lg-2 col-md-2">
                            <h5>Reporting Manager</h5>
                        </div>
                        <div class="col-lg-3 col-md-3">
                            <asp:DropDownList runat="server" ID="ddlemployee" required="" AutoPostBack="true" OnSelectedIndexChanged="ddlemployee_SelectedIndexChanged"></asp:DropDownList>
                        </div>
                    </div>
                    <div class="row">
                        &nbsp;
                    </div>
                    <div class="row">
                        <div class="col-lg-6 col-md-6">
                            <div class="table-responsive">





                                <asp:GridView ID="gvUser" runat="server" OnRowCommand="gvUser_RowCommand" AutoGenerateColumns="False">
                                    <Columns>
                                        <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                        <asp:BoundField HeaderText="Name" DataField="Employee" />
                                        <asp:TemplateField HeaderText="Add to Location" ItemStyle-HorizontalAlign="Center"
                                            ItemStyle-Width="150px">
                                            <ItemTemplate>
                                                <asp:LinkButton ID="lnkSend" runat="server" Text="Add to Employee >>" CommandName="cmdAdd"
                                                    CssClass="btn btn-primary" CommandArgument='<%#Eval("EmployeeId")%>'></asp:LinkButton>
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
                        <div class="col-lg-6 col-md-6">


                            <div class="table-responsive">
                                <asp:GridView ID="gv" runat="server" AutoGenerateColumns="false" OnRowCommand="gv_RowCommand">
                                    <Columns>
                                        <asp:BoundField HeaderText="SNo" DataField="SNo" />
                                        <asp:BoundField HeaderText="Name" DataField="Employee" />
                                        <asp:TemplateField HeaderText="Add to Location" ItemStyle-HorizontalAlign="Center"
                                            ItemStyle-Width="150px">
                                            <ItemTemplate>
                                                <asp:LinkButton ID="lnkSend" runat="server" Text="Remove Employee >>" CommandName="cmdRemove"
                                                    CssClass="btn btn-danger" CommandArgument='<%#Eval("EmployeeMappedId")%>'></asp:LinkButton>
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
    </div>
    <!-- Row End -->
</asp:Content>
