<%@ Page Title="" Language="C#" MasterPageFile="Admin.master" AutoEventWireup="true"
    CodeFile="LeadSearch.aspx.cs" Inherits="LeadSearch" %>

<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
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
                        Lead List
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">
                        <div class="col-lg-3 col-md-3">
                            <asp:TextBox runat="server" MaxLength="500" ID="txtSearch" placeholder="Search"></asp:TextBox>
                        </div>
                        <div class="col-lg-1 col-md-1">
                            <asp:Button ID="btnSearch" runat="server" Text="Find" OnClick="btnSearch_Click" />
                        </div>
                        <div class="col-lg-1 col-md-1">
                            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" SkinID="addnew" CausesValidation="false" />
                        </div>
                    </div>
                    <div class="row">
                        &nbsp;
                    </div>



                    <div class="row">
                        <div class="col-lg-3 col-md-3">
                            <asp:DropDownList ID="ddlLocation" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlLocation_SelectedIndexChanged">
                            </asp:DropDownList>
                            <asp:DropDownList ID="ddlRasikaLocation" runat="server" AutoPostBack="true" Visible="false" OnSelectedIndexChanged="ddlRasikaLocation_SelectedIndexChanged">
                                <asp:ListItem Value="3" Selected="True">Pune </asp:ListItem>
                                <asp:ListItem Value="4">Mumbai </asp:ListItem>
                                <asp:ListItem Value="7">Bangalore</asp:ListItem>
                                <asp:ListItem Value="8">Delhi - NCR</asp:ListItem>
                            </asp:DropDownList>




                        </div>



                    </div>


                </div>
                <br />

                <div class="row">
                    &nbsp;
                </div>


                <asp:Label ID="PageNumberHeader" runat="server"></asp:Label>

                <div class="row">
                    <div class="table-responsive">
                        <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False" OnRowCommand="gv_RowCommand" Width="100%" AllowPaging="true" AllowSorting="true" OnPageIndexChanging="gv_PageIndexChanging" PageSize="100" ShowHeaderWhenEmpty="true" EmptyDataText="No Records Found!" OnPreRender="gv_PreRender">
                            <Columns>
                                <asp:TemplateField HeaderText="Action" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="150px">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lnkEdit" runat="server" SkinID="edit" CommandName="cmdEdit"
                                            CommandArgument='<%#Eval("LeadId")%>'></asp:LinkButton>
                                        <asp:LinkButton ID="lnkDelete" runat="server" SkinID="delete" CommandName="cmdDelete" Visible="false"
                                            CommandArgument='<%#Eval("LeadId")%>' OnClientClick="return confirm('Are you sure you want to delete this Record?');"></asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                <asp:BoundField HeaderText="LeadId" DataField="leadId" ItemStyle-Width="50px" />

                                <asp:BoundField HeaderText="Location" DataField="Location" />
                                <asp:BoundField HeaderText="Course" DataField="Course" />
                                <asp:BoundField HeaderText="BatchType" DataField="BatchType" />
                                <asp:BoundField HeaderText="Aspirant Name" DataField="Lead" />
                                <asp:BoundField HeaderText="PrimaryMobile" DataField="PrimaryMobile" />
                                <asp:BoundField HeaderText="User" DataField="Username" />
                                <asp:BoundField HeaderText="FromDate" DataField="CreatedOn" DataFormatString="{0:dd MMM yyyy}" />
                                <asp:BoundField HeaderText="ToDate" DataField="CreatedOn" DataFormatString="{0:dd MMM yyyy}" />

                                <asp:TemplateField HeaderText="Followup" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="50px">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lnkFollowup" runat="server" Text="Followup" SkinID="view" CommandName="cmdFollowup"
                                            CommandArgument='<%#Eval("LeadId")%>'></asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                        <asp:Label ID="PageNumberFooter" runat="server"></asp:Label>

                    </div>
                </div>




            </div>
        </div>
    </div>

    <!-- Row End -->
</asp:Content>
