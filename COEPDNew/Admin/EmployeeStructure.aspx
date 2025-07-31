<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="EmployeeStructure.aspx.cs" Inherits="Admin_EmployeeStructure" %>

<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
        <script type="text/javascript" src="../App_Themes/admin/js/jquery.js"></script>
    <script type="text/javascript" src="../App_Themes/admin/js/jquery-ui-v1.10.3.js"></script>
    <script type="text/javascript">
        function alertmeSelection() {
            Swal.fire(
                'Please Select the Reporting Manager',
                'In the ReportingManager dropdown List',
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
                        Employee Mapping
                    </div>
                </div>
                <div class="widget-body">

                    <div class="row">
                        &nbsp;
                    </div>
                    <div class="row">
                        <div class="col-lg-5 col-md-5">
                            <h4 class="text-center">Designation</h4>
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
                        <div class="col-lg-2 col-md-2">
                            <h5>UnAssigned Employees</h5>
                        </div>
                        <div class="col-lg-3 col-md-3">
                            <asp:DropDownList ID="ddlDesignation" AutoPostBack="true" OnSelectedIndexChanged="ddlDesignation_SelectedIndexChanged" runat="server"></asp:DropDownList>
                        </div>
                        <div class="col-lg-1 col-md-1">
                        </div>



                        <div class="col-lg-2 col-md-2">
                            <h5>Reporting Manager</h5>
                        </div>
                        <div class="col-lg-3 col-md-3">
                            <asp:DropDownList runat="server" ID="ddlemployee" required="" AutoPostBack="true" OnSelectedIndexChanged="ddlemployee_SelectedIndexChanged"></asp:DropDownList>
                        </div>
                        <div class="col-lg-1 col-md-1">
                        </div>




                    </div>
                    <div class="row">

                        <div class="col-lg-3 col-md-3">
                            <div class="form-group">
                                <label class="col-sm-5 control-label">
                                    IsAssigned
                                </label>
                                <div class="col-sm-7">
                                    <asp:RadioButton runat="server" ID="rbAssigned" OnCheckedChanged="rbAssigned_CheckedChanged" AutoPostBack="true" GroupName="radio" />
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-3 col-md-3">
                            <div class="form-group">
                                <label class="col-sm-5 control-label">
                                    IsUnassigned
                                </label>
                                <div class="col-sm-7">
                                    <asp:RadioButton runat="server" ID="rbUnAssigned" AutoPostBack="true"  OnCheckedChanged="rbUnAssigned_CheckedChanged" GroupName="radio" />
                                </div>
                            </div>
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
                                                    CssClass="btn btn-danger" CommandArgument='<%#Eval("EmployeeId")%>'></asp:LinkButton>
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

