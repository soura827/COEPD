<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="CampaignWebinarSearch.aspx.cs" Inherits="Admin_CampaignWebinarSearch" %>
<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" Runat="Server">
     <uc1:FormMessage ID="FormMessage" runat="server" Visible="false" />
    <uc2:ErrorMessage ID="ErrorMessage" runat="server" Visible="false" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


 <div class="col-md-12">
            <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        Campaign's
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">
                        <div class="col-lg-3 col-md-3">
                            <asp:TextBox runat="server" ID="txtSearch" MaxLength="500" placeholder="Search"></asp:TextBox>
                        </div>
                         <div class="col-lg-1 col-md-1">
                            <asp:Button ID="btnSearch" runat="server" Text="Find" OnClick="btnSearch_Click"/>
                        </div>
                         <div class="col-lg-3 col-md-3">
                            <div class="form-group">
                            <label class="col-sm-5 control-label">
                                Active
                            </label>
                            <div class="col-sm-7">
                                <asp:radiobutton runat="server" ID="rbActive" AutoPostBack="true" GroupName = "radio"/>
                            </div>
                        </div>
                        </div>
                        <div class="col-lg-3 col-md-3">
                           <div class="form-group">
                                <label class="col-sm-5 control-label">
                                    Deleted
                                </label>
                                <div class="col-sm-7">
                                    <asp:radiobutton runat="server" ID="rbDeleted" AutoPostBack="true" GroupName = "radio"/>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-1 col-md-1">
                            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" SkinID="addnew" CausesValidation="false"/>
                        </div>
                    </div>
                    <div class="row">
                        &nbsp;
                    </div>
                    <div class="row">
                        <div class="table-responsive">
                        <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False" OnRowCommand="gv_RowCommand"
                            Width="100%" OnRowDataBound="gv_RowDataBound">
                            <Columns>
                                <asp:TemplateField HeaderText="Action" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="150px">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lnkEdit" runat="server" SkinID="edit" CommandName="cmdEdit"
                                            CommandArgument='<%#Eval("Offer")%>'></asp:LinkButton>
                                        <asp:LinkButton ID="lnkDelete" runat="server" SkinID="delete" CommandName="cmdDelete"
                                            CommandArgument='<%#Eval("Offer")%>' OnClientClick="return confirm('Are you sure you want to delete?');"></asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField HeaderText="SNo" DataField="SNO" />
                                <asp:BoundField HeaderText="Campaign Id" DataField="Offer" />
                                <asp:BoundField HeaderText="Campaign Title" DataField="Title" />
                                <asp:BoundField HeaderText="URL" DataField="URL" />
                                <asp:TemplateField HeaderText="Campaign File">
                                        <ItemTemplate>
                                            <asp:HiddenField ID="hdnCampaignFile" runat="server" Value='<%#Eval("FilePath") %>' />
                                            <asp:HyperLink NavigateUrl='<%#"~/UserDocs/CampaignDocs/"+ Eval("FilePath") %>' runat="server"
                                                ID="hplCampaignFile" Target="_blank" CssClass="btn btn-warning btn-xs">View</asp:HyperLink>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                <asp:BoundField HeaderText="Start Date" DataField="StartDate" SortExpression="Latest" DataFormatString="{0:dd MMM yyyy}"/>
                                <asp:BoundField HeaderText="End Date" DataField="EndDate" DataFormatString="{0:dd MMM yyyy}" />
                                <asp:BoundField HeaderText="IsActive" DataField="IsActive" />
                                <asp:BoundField HeaderText="IsDeleted" DataField="IsDeleted" />
                                <asp:BoundField HeaderText="Created By" DataField="FullName" />
                                <asp:BoundField HeaderText="Created On" DataField="CreatedOn" DataFormatString="{0:dd MMM yyyy hh:mm tt}" />
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
</asp:Content>


