<%@ Page Title="" Language="C#" MasterPageFile="~/Participant/Participant.master" AutoEventWireup="true" CodeFile="ReferFriendSearch.aspx.cs" Inherits="Participant_ReferFriendSearch" %>

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
                        Refer friend 
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">
                        <div class="col-lg-10 col-md-3">
                        </div>
                        <div class="col-lg-1 col-md-1">
                            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" SkinID="addnew" CausesValidation="false" />
                        </div>
                    </div>
                    <div class="row">
                        &nbsp;
                    </div>
                    <div>
                        <asp:Label ID="PageNumberHeader" runat="server"></asp:Label>
                    </div>
                    <div class="row">
                        <div class="table-responsive">
                            <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False"
                                Width="100%" PageSize="50" HeaderStyle-HorizontalAlign="Center" AllowPaging="true" AllowSorting="true" EmptyDataText="No Records Found!" ShowHeaderWhenEmpty="true" OnRowDataBound="gv_RowDataBound" OnPreRender="gv_PreRender" OnPageIndexChanging="gv_PageIndexChanging">
                                <Columns>
                                    <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                    <asp:BoundField HeaderText="Referral Name" DataField="ReferralName" ItemStyle-Width="150px" />
                                    <asp:BoundField HeaderText="Referral Contact" DataField="ReferralContact" ItemStyle-Width="150px" />
                                    <asp:BoundField HeaderText="Referral Email" DataField="ReferralEmail" ItemStyle-Width="150px" />
                                    <asp:BoundField HeaderText="Referral Location Preference" DataField="Location" ItemStyle-Width="150px" />
                                    <asp:BoundField HeaderText="Domain" DataField="Domain" ItemStyle-Width="150px" />
                                    <asp:BoundField HeaderText="PlanningToJoinTheCourse" DataField="PlanningToJoinTheCourse" ItemStyle-Width="150px" />
                                    <asp:BoundField HeaderText="ReferralAvailableTimeSchedule" DataField="ReferralAvailableTimeSchedule" ItemStyle-Width="150px" DataFormatString="{0: dd MMM yyyy hh:mm tt}" />

                                    <asp:TemplateField HeaderText="Is Referral Bonus Intrest">
                                        <ItemTemplate>
                                            <%# (Boolean.Parse(Eval("IsReferralBonus").ToString()) ? "Intrested" : "Not Intrested" )%>
                                        </ItemTemplate>
                                    </asp:TemplateField>

                                    <asp:BoundField HeaderText="ParticipantUPIID" DataField="ParticipantUPIID" ItemStyle-Width="150px" />
                                    <asp:BoundField HeaderText="Created By" DataField="Participant" ItemStyle-Width="150px" />
                                    <asp:BoundField HeaderText="CreatedOn" DataField="CreatedOn" ItemStyle-Width="150px" DataFormatString="{0: dd MMM yyyy hh:mm tt}" />


                                    <asp:TemplateField HeaderText="Proof Payment Path">
                                        <ItemTemplate>
                                            <asp:HiddenField ID="hdnAadharFrontFile" runat="server" Value='<%#Eval("ProofPaymentPath") %>' />
                                            <asp:HyperLink NavigateUrl='<%#"~/UserDocs/ReferFriend/"+ Eval("ProofPaymentPath") %>' runat="server"
                                                ID="hplAadharFrontFile" Target="_blank" CssClass="btn btn-warning btn-xs">View</asp:HyperLink>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField HeaderText="Refer Amount" DataField="ReferAmount" ItemStyle-Width="150px" />
                                    <asp:TemplateField HeaderText=" Status" ItemStyle-HorizontalAlign="Center">
                                        <ItemTemplate>
                                            <asp:Label ID="lblstatus" runat="server" Text='<%# Bind("LeadCategoryId") %>'></asp:Label>
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















</asp:Content>

