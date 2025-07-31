<%@ Page Title="" Language="C#" MasterPageFile="~/Participant/Participant.master" AutoEventWireup="true" CodeFile="PlacementInductionSearch.aspx.cs" Inherits="Participant_PlacementInductionSearch" %>

<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
     <uc1:FormMessage ID="FormMessage" runat="server" Visible="false" />
    <uc2:ErrorMessage ID="ErrorMessage" runat="server" Visible="false" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        BA Job market  Induction
                    </div>
                </div>
                <div class="widget-body">
                    <div class="col-lg-2  col-md-2">

                    </div>
                    <div class="col-lg-2  col-md-2">

                    </div>
                    <div class="col-lg-2  col-md-2">

                    </div>
                    <div class="col-lg-2  col-md-2">

                    </div>
                    <div class="col-md-2 col-lg-2">
                            <asp:DropDownList ID="ddlStatus" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlStatus_SelectedIndexChanged">
                                <asp:ListItem Text="HR Mock Pending/Evaluated" Value="False"></asp:ListItem>
                                <asp:ListItem Text="HR Mock Approved" Value="True"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                     <div class="col-lg-2  col-md-2">
                            <asp:Button ID="btnAdd" runat="server"  SkinID="addnew" AutoPostBack="True" CausesValidation="false" OnClick="btnAdd_Click"/>
                        </div>
                    <br />
                    
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
                                    <asp:BoundField HeaderText="Name" DataField="Participant" ItemStyle-Width="150px" />
                                    <asp:BoundField HeaderText="Mobile" DataField="Mobile" ItemStyle-Width="150px" />
                                    <asp:BoundField HeaderText="Email" DataField="Email" ItemStyle-Width="150px" />
                                    <asp:BoundField HeaderText="ReferenceNo" DataField="ReferenceNo" ItemStyle-Width="100px" />
                                    <asp:BoundField HeaderText="Location" DataField="Location" ItemStyle-Width="100px" />
                                    <asp:BoundField HeaderText="Batch Date" DataField="StartDate" ItemStyle-Width="50px" DataFormatString="{0: dd MMM yyyy}" />
                                    <asp:BoundField HeaderText="Trainer" DataField="Employee" ItemStyle-Width="100px" />
                                    <asp:BoundField HeaderText="Profile Owner" DataField="ProfileOwner" ItemStyle-Width="100px" />
                               
                                    <asp:BoundField HeaderText="Score" DataField="Score" ItemStyle-Width="100px" />
                                      <asp:TemplateField HeaderText="Status" ItemStyle-Width="100px">
                                        <ItemTemplate>
                                            <%# (Boolean.Parse(Eval("IsHRMockApproved").ToString()) ? "HR Mock Approved" : "HR Mock Pending" )%>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField HeaderText="Placement Induction Attended On" DataField="AttendedOn" ItemStyle-Width="150px" DataFormatString="{0: dd MMM yyyy}" />
                                    <asp:BoundField HeaderText="HRMockInputs" DataField="HRMockInputs" ItemStyle-Width="100px" />
                                    <asp:TemplateField HeaderText="PlacementInductionAttendance" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="100px">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lnkEdit" runat="server" SkinID="Green" Text="View" CommandName="cmdEdit"
                                                CommandArgument='<%#Eval("PlacementInductionId")%>'></asp:LinkButton>
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
    <!-- Row End -->
</asp:Content>

