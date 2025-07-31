<%@ Page Title="" Language="C#" MasterPageFile="~/Participant/Participant.master" AutoEventWireup="true" CodeFile="ParticipantPlacementAssistanceDataSheetSearch.aspx.cs" Inherits="Participant_ParticipantPlacementAssistanceDataSheetSearch" %>

<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <uc1:FormMessage ID="FormMessage" runat="server" Visible="false" />
    <uc2:ErrorMessage ID="ErrorMessage" runat="server" Visible="false" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        Participant BA Job market  Assistance Data Sheet
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
                        <asp:DropDownList ID="ddlStatus" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlStatus_SelectedIndexChanged">
                            <asp:ListItem Text="Data Sheet Pending" Value="False"></asp:ListItem>
                            <asp:ListItem Text="Data Sheet Approved" Value="True"></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="col-lg-2  col-md-2">
                    </div>
                    <div class="col-lg-2  col-md-2">
                        <asp:Button ID="btnAdd" runat="server" SkinID="addnew" AutoPostBack="True" CausesValidation="false" OnClick="btnAdd_Click" />
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
                                    <asp:BoundField HeaderText="FullName" DataField="FullName" ItemStyle-Width="150px" />


                                    <asp:BoundField HeaderText="Total Experience" DataField="TotalExperiencess" ItemStyle-Width="150px" />
                                    <asp:BoundField HeaderText="Relevant experiance" DataField="RelevantExperiencess" ItemStyle-Width="150px" />


                                    <asp:TemplateField HeaderText="Photo">
                                        <ItemTemplate>
                                            <asp:HiddenField ID="hdnPassportSizePhotoFile" runat="server" Value='<%#Eval("PassportSizePhotoImagePath") %>' />
                                            <asp:HyperLink NavigateUrl='<%#"~/UserDocs/PlacementsDataSheet/"+ Eval("PassportSizePhotoImagePath") %>' runat="server"
                                                ID="hplPassportSizePhotoFile" Target="_blank" CssClass="btn btn-success btn-xs">View</asp:HyperLink>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Aadhar Front">
                                        <ItemTemplate>
                                            <asp:HiddenField ID="hdnAadharFrontFile" runat="server" Value='<%#Eval("AadharCardFrontImagePath") %>' />
                                            <asp:HyperLink NavigateUrl='<%#"~/UserDocs/PlacementsDataSheet/"+ Eval("AadharCardFrontImagePath") %>' runat="server"
                                                ID="hplAadharFrontFile" Target="_blank" CssClass="btn btn-warning btn-xs">View</asp:HyperLink>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Aadhar Back">
                                        <ItemTemplate>
                                            <asp:HiddenField ID="hdnAadharBackFile" runat="server" Value='<%#Eval("AadharCardBackImagePath") %>' />
                                            <asp:HyperLink NavigateUrl='<%#"~/UserDocs/PlacementsDataSheet/"+ Eval("AadharCardBackImagePath") %>' runat="server"
                                                ID="hplAadharBackFile" Target="_blank" CssClass="btn btn-success btn-xs">View</asp:HyperLink>
                                        </ItemTemplate>
                                    </asp:TemplateField>



                                    <asp:TemplateField HeaderText="Salary Slip">
                                        <ItemTemplate>
                                            <asp:HiddenField ID="hdnSalarySlipFile" runat="server" Value='<%#Eval("SalarySlipImagePath") %>' />
                                            <asp:HyperLink NavigateUrl='<%#"~/UserDocs/PlacementsDataSheet/"+ Eval("SalarySlipImagePath") %>' runat="server"
                                                ID="hplSalarySlipFile" Target="_blank" CssClass="btn btn-warning btn-xs">View</asp:HyperLink>
                                        </ItemTemplate>
                                    </asp:TemplateField>



                                    
                                    <asp:TemplateField HeaderText="Service Form">
                                        <ItemTemplate>
                                            <asp:HiddenField ID="hdnServiceFormFile" runat="server" Value='<%#Eval("ServiceFormImagePath") %>' />
                                            <asp:HyperLink NavigateUrl='<%#"~/UserDocs/PlacementsDataSheet/"+ Eval("ServiceFormImagePath") %>' runat="server"
                                                ID="hplServiceFormFile" Target="_blank" CssClass="btn btn-warning btn-xs">View</asp:HyperLink>
                                        </ItemTemplate>
                                    </asp:TemplateField>





                                    <asp:BoundField HeaderText="Profile Owner" DataField="ProfileOwnerName" />
                                    <asp:TemplateField HeaderText="Status">
                                        <ItemTemplate>
                                            <%# (Boolean.Parse(Eval("IsDataSheetApproved").ToString()) ? "Approved" : "Pending" )%>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Action" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="100px">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lnkEdit" runat="server" SkinID="Orange" Text="View Data Sheet" CommandName="cmdEdit"
                                                CommandArgument='<%#Eval("ParticipantPlacementAssistanceDataSheetId")%>'></asp:LinkButton>
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

