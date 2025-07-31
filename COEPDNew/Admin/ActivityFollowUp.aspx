<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="ActivityFollowUp.aspx.cs" Inherits="Admin_ActivityFollowUp" %>
<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
        <script src="../js/jquery-1.3.2.min.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(function() {
            var $txt = $('input[id$=FilterText]');
            var $ddl = $('select[id$=ddlActivityCategory]');
            var $items = $('select[id$=ddlActivityCategory] option'); 
            $txt.keyup(function() { searchDdl($txt.val());
            });
            function searchDdl(item) {
                $ddl.empty();
                var exp = new RegExp(item, "i");
                var arr = $.grep($items, function (n) {
                                                        return exp.test($(n).text());
                                                      }
                                );
 
                if (arr.length > 0) {
                    $.each(arr, function() {
                                                $ddl.append(this);
                                                $ddl.get(0).selectedIndex = 0;
                                            }
                           );
                }
                else {

                    $ddl.append("<option>No Items Found</option>");
                }
            }
        });
    </script>
    <link rel="stylesheet" type="text/css" href="https://ajax.googleapis.com/ajax/libs/jqueryui/1.8.23/themes/south-street/jquery-ui.css" />
    <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
    <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jqueryui/1.8.23/jquery-ui.min.js"></script>
  <script type="text/javascript" src="../App_Themes/admin/js/jquery-ui-v1.10.3.js"></script>
    <script type="text/javascript">
        $(document).ready(function ($) {
            $("[id*=txtFollowupdate]").datepicker({
                dateFormat: 'dd/mm/yy',
            });
        });
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
                        Activity FollowUp
                    </div>
                </div>
                <div class="widget-body">
                    <div class="form-horizontal no-margin">
                        <div class="form-group">
                            <label class="col-sm-1 control-label">
                                Activity Category
                            </label>
                            <div class="col-sm-3">
                                <asp:DropDownList ID="ddlActivityCategory" runat="server" OnSelectedIndexChanged="ddlActivityCategory_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                            </div>
                             <label class="col-sm-1 control-label" style="text-align: left"> Filter By Category  </label>                             
                             <div class="col-sm-3">
                                 <asp:TextBox ID="FilterText" runat="server" Placeholder="Filter By Category" ToolTip="Enter Text Here"></asp:TextBox>
                             </div>
                            </div>
                        <div class="form-group">
                            <label class="col-sm-1 control-label">
                                Activity SubCategory
                            </label>
                            <div class="col-sm-3">
                                <asp:DropDownList ID="ddlActivitySubCategory" runat="server" OnSelectedIndexChanged="ddlActivitySubCategory_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                            </div>
                            <label class="col-sm-1 control-label">
                                Activity 
                            </label>
                            <div class="col-sm-3">
                                <asp:DropDownList ID="ddlActivity" runat="server"></asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-1 control-label">
                                Date To WorkOn</label>

                            <div class="col-sm-3">
                                <asp:TextBox ID="txtFollowupdate" runat="server" autocomplete="off"></asp:TextBox>
                            </div>
                            <label class="col-sm-1 control-label">
                                Description
                            </label>
                            <div class="col-sm-3">
                                <asp:TextBox ID="txtfollowupdescription" runat="server" TextMode="MultiLine"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-lg-6 col-md-6">
                            <asp:TextBox runat="server" ID="txtEmployee" MaxLength="500" placeholder="Search By Employee" AutoPostBack="true" OnTextChanged="txtEmployee_TextChanged"></asp:TextBox>
                        </div>
                        <div class="col-lg-6 col-md-6">
                            <asp:TextBox runat="server" ID="txtParticipant" MaxLength="500" placeholder="Search By Participant" AutoPostBack="true" OnTextChanged="txtParticipant_TextChanged"></asp:TextBox>
                        </div>
                    </div>
                    <br />
                    <br />
                    <div class="row">
                        <div class="col-lg-5 col-sm-5 col-md-5" style="overflow-y: scroll; max-height: 200px;">
                            <div class="table-responsive">
                                <asp:GridView ID="gvemployee" runat="server" AutoGenerateColumns="false">
                                    <Columns>
                                        <asp:TemplateField HeaderText="Action" ItemStyle-HorizontalAlign="Center">
                                            <ItemTemplate>
                                                <asp:CheckBox ID="CheckBox2" runat="server" />
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:BoundField DataField="SNo" HeaderText="SNo" ItemStyle-Width="50px" ItemStyle-HorizontalAlign="Center" />
                                        <asp:TemplateField HeaderText="EmpoyeeId" ItemStyle-HorizontalAlign="Center">
                                            <ItemTemplate>
                                                <asp:Label ID="lblEmployee" runat="server" Text='<%# Bind("EmployeeId") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Employee Name" ItemStyle-HorizontalAlign="Center">
                                            <ItemTemplate>
                                                <asp:Label ID="lblEmployees" runat="server" Text='<%# Bind("Employee") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>

                                        <asp:TemplateField HeaderText="Designation" ItemStyle-HorizontalAlign="Center">
                                            <ItemTemplate>
                                                <asp:Label ID="lblDesignation" runat="server" Text='<%# Bind("Designation") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Email Id" ItemStyle-HorizontalAlign="Center">
                                            <ItemTemplate>
                                                <asp:Label ID="lblEmail" runat="server" Text='<%# Bind("OfficeEmail") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Address" ItemStyle-HorizontalAlign="Center">
                                            <ItemTemplate>
                                                <asp:Label ID="lblAddress" runat="server" Text='<%# Bind("Address") %>'></asp:Label>
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
                        <div class="col-lg-1 col-sm-1 col-md-1"></div>
                        <div class="col-lg-5 col-sm-5 col-md-5" style="overflow-y: scroll; max-height: 200px;">
                            <div class="table-responsive">
                                <asp:GridView ID="gvPartiicipant" runat="server" AutoGenerateColumns="false">
                                    <Columns>
                                        <asp:TemplateField HeaderText="Action" ItemStyle-HorizontalAlign="Center">
                                            <ItemTemplate>
                                                <asp:CheckBox ID="CheckBox3" runat="server" />
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:BoundField DataField="SNo" HeaderText="SNo" ItemStyle-Width="50px" ItemStyle-HorizontalAlign="Center" />
                                        <asp:TemplateField HeaderText="Participant" ItemStyle-HorizontalAlign="Center" Visible="false">
                                            <ItemTemplate>
                                                <asp:Label ID="lbParticipantId" runat="server" Text='<%# Bind("ParticipantId") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="ReferenceNo" ItemStyle-HorizontalAlign="Center">
                                            <ItemTemplate>
                                                <asp:Label ID="lbReferenceNo" runat="server" Text='<%# Bind("ReferenceNo") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Participant Name" ItemStyle-HorizontalAlign="Center">
                                            <ItemTemplate>
                                                <asp:Label ID="lbParticipant" runat="server" Text='<%# Bind("Participant") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Location" ItemStyle-HorizontalAlign="Center">
                                            <ItemTemplate>
                                                <asp:Label ID="lblLocation" runat="server" Text='<%# Bind("Location") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Trainer" ItemStyle-HorizontalAlign="Center">
                                            <ItemTemplate>
                                                <asp:Label ID="lblEmployee" runat="server" Text='<%# Bind("Employee") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Email Id" ItemStyle-HorizontalAlign="Center">
                                            <ItemTemplate>
                                                <asp:Label ID="lblEmail" runat="server" Text='<%# Bind("Email") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Mobile Number" ItemStyle-HorizontalAlign="Center">
                                            <ItemTemplate>
                                                <asp:Label ID="lblMobile" runat="server" Text='<%# Bind("Mobile") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="BatchId" ItemStyle-HorizontalAlign="Center">
                                            <ItemTemplate>
                                                <asp:Label ID="lblBatchId" runat="server" Text='<%# Bind("BatchId") %>'></asp:Label>
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
                    <br />
                            <div class="form-group">
                         <div class="col-lg-6 col-md-6">
                             <asp:TextBox runat="server" ID="txtLead" MaxLength="500" placeholder="Search By Lead" OnTextChanged="txtLead_TextChanged" AutoPostBack="true" ></asp:TextBox>
                          </div>
                            <div class="col-lg-6 col-md-6">
                                <asp:TextBox runat="server" ID="txtVendor" MaxLength="500" placeholder="Search By Vendors" OnTextChanged="txtVendor_TextChanged" AutoPostBack="true" ></asp:TextBox>
                            </div>
                        </div>
                    <div class="row">
                            <div class="col-lg-5 col-sm-5 col-md-5" style="overflow-y: scroll; max-height: 200px;">
                                <div class="table-responsive">
                                    <asp:GridView ID="gvLead" runat="server" AutoGenerateColumns="false">
                                        <Columns>
                                            <asp:TemplateField HeaderText="Action" ItemStyle-HorizontalAlign="Center">
                                                <ItemTemplate>
                                                    <asp:CheckBox ID="CheckBox4" runat="server" />
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:BoundField DataField="SNo" HeaderText="SNo" ItemStyle-Width="50px" ItemStyle-HorizontalAlign="Center" />
                                            <asp:TemplateField HeaderText="Lead Id" ItemStyle-HorizontalAlign="Center">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblLeadId" runat="server" Text='<%# Bind("LeadId") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Aspirant Name" ItemStyle-HorizontalAlign="Center">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblLead" runat="server" Text='<%# Bind("Lead") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Location" ItemStyle-HorizontalAlign="Center">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblLocation" runat="server" Text='<%# Bind("Location") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Course" ItemStyle-HorizontalAlign="Center">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblCourse" runat="server" Text='<%# Bind("Course") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Batch Type" ItemStyle-HorizontalAlign="Center">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblBatchType" runat="server" Text='<%# Bind("BatchType") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Primary Mobile" ItemStyle-HorizontalAlign="Center">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblPrimaryMobile" runat="server" Text='<%# Bind("PrimaryMobile") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="User" ItemStyle-HorizontalAlign="Center">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblUser" runat="server" Text='<%# Bind("Username") %>'></asp:Label>
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
                            <div class="col-lg-1 col-sm-1 col-md-1"></div>
                            <div class="col-lg-5 col-sm-5 col-md-5" style="overflow-y: scroll; max-height: 200px;">
                                <div class="table-responsive">
                                    <asp:GridView ID="gvVendor" runat="server" AutoGenerateColumns="false">
                                        <Columns>
                                            <asp:TemplateField HeaderText="Action" ItemStyle-HorizontalAlign="Center">
                                                <ItemTemplate>
                                                    <asp:CheckBox ID="CheckBox5" runat="server" />
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:BoundField DataField="SNo" HeaderText="SNo" ItemStyle-Width="50px" ItemStyle-HorizontalAlign="Center" />
                                            <asp:TemplateField HeaderText="Vendor Id" ItemStyle-HorizontalAlign="Center">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblVendorId" runat="server" Text='<%# Bind("VendorId") %>'></asp:Label>
                                                </ItemTemplate>
                                                </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Vendor Name" ItemStyle-HorizontalAlign="Center">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblVendor" runat="server" Text='<%# Bind("Vendor") %>'></asp:Label>
                                                </ItemTemplate>
                                                </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Location" ItemStyle-HorizontalAlign="Center">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblLocation" runat="server" Text='<%# Bind("Location") %>'></asp:Label>
                                                </ItemTemplate>
                                                </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Vendor Category" ItemStyle-HorizontalAlign="Center">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblVendorCategory" runat="server" Text='<%# Bind("VendorCategory") %>'></asp:Label>
                                                </ItemTemplate>
                                                </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Vendor Office Address" ItemStyle-HorizontalAlign="Center">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblVendorOfficeAddress" runat="server" Text='<%# Bind("LocationOffice") %>'></asp:Label>
                                                </ItemTemplate>
                                                </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Contact Name" ItemStyle-HorizontalAlign="Center">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblContactName" runat="server" Text='<%# Bind("ContactName") %>'></asp:Label>
                                                </ItemTemplate>
                                                </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Mobile" ItemStyle-HorizontalAlign="Center">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblMobile" runat="server" Text='<%# Bind("Mobile") %>'></asp:Label>
                                                </ItemTemplate>
                                                </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Created By" ItemStyle-HorizontalAlign="Center">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblCreatedBy" runat="server" Text='<%# Bind("Fullname") %>'></asp:Label>
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
                            <br />
                    <%-- <div class="form-group">
                        <label class="col-sm-2 control-label">
                                ActivityInteractions
                            </label>
                            <div class="col-sm-5" style="overflow-y:scroll; max-height:150px; ">
                                <asp:TextBox ID="txtActivityInputs" runat="server" AutoPostBack="true" Enabled="false" TextMode="MultiLine"></asp:TextBox>
                            </div>
                    </div>--%>
                    <div class="form-horizontal no-margin">
                        <div class="form-group">
                            <div class="col-sm-offset-4 col-sm-10">
                                <asp:Button ID="btnSubmit" runat="server" Text="Create Followup" OnClick="btnSubmit_Click" />
                                <asp:Button ID="btnreset" runat="server" UseSubmitBehavior="false" Text="Reset" OnClick="btnreset_Click" />
                                <asp:Button ID="btnInteractions" runat="server" UseSubmitBehavior="false" Text="Go to Interactions" OnClick="btnInteractions_Click" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>