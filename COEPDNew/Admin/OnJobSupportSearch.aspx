<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="OnJobSupportSearch.aspx.cs" Inherits="Admin_OnJobSupportSearch" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        On Job Support
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">
                        <div class="col-md-2 col-lg-2">
                            <asp:TextBox runat="server" ID="txtParticipant" MaxLength="250" placeholder="Participant-Name,Email,Mobile,Reference NO." AutoPostBack="true" OnTextChanged="txtParticipant_TextChanged"></asp:TextBox>
                        </div>
                        <div class="col-md-2 col-lg-2">
                            <asp:TextBox runat="server" ID="txtLocation" MaxLength="250" placeholder="Search By location" AutoPostBack="true" OnTextChanged="txtParticipant_TextChanged"></asp:TextBox>
                        </div>
                         <div class="col-md-2 col-lg-2">
                            <asp:TextBox runat="server" ID="txtProject" MaxLength="250" placeholder="Search by Project" AutoPostBack="true" OnTextChanged="txtParticipant_TextChanged"></asp:TextBox>
                        </div>
                        <div class="col-md-2 col-lg-2">
                            <asp:DropDownList ID="ddlStatus" runat="server" AutoPostBack="true" OnSelectedIndexChanged="txtParticipant_TextChanged">
                                <asp:ListItem Text="Pending" Value="False"></asp:ListItem>
                                <asp:ListItem Text="Sent" Value="True"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                       
                    </div>
                    <div>
                        <asp:Label ID="PageNumberHeader" runat="server"></asp:Label>
                    </div>

                    <div class="row">
                        <div class="table-responsive">
                            <asp:GridView ID="gv" runat="server" AutoGenerateColumns="false" Width="100%" PageSize="50" HeaderStyle-HorizontalAlign="Center" AllowPaging="true" AllowSorting="true" OnRowCommand="gv_RowCommand" OnPageIndexChanging="gv_PageIndexChanging" ShowHeaderWhenEmpty="true" EmptyDataText="No Records Found!" OnPreRender="gv_PreRender" OnRowDataBound="gv_RowDataBound">
                                <Columns>
                                    <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                    <asp:BoundField HeaderText="Name" DataField="Participant" ItemStyle-Width="150px" />
                                    <asp:BoundField HeaderText="Email" DataField="Email" />
                                    <asp:BoundField HeaderText="Mobile" DataField="Mobile"/>
                                    <asp:BoundField HeaderText="Location" DataField="Location" ItemStyle-Width="150px" />
                                    <asp:BoundField HeaderText="Profile Owner" DataField="ProfileOwner" />
                                    <asp:BoundField HeaderText="Batch" DataField="StartDate" DataFormatString="{0: dd MMM yyyy}"  />
                                    <asp:BoundField HeaderText="Trainer" DataField="Employee"  />
                                    <asp:BoundField HeaderText="Project" DataField="Project" ItemStyle-Width="150px" />
                                    <asp:BoundField HeaderText="Domain" DataField="Domain" ItemStyle-Width="150px" />
                                    <asp:BoundField HeaderText="Total Exp." DataField="TotalExperience" />
                                     <asp:BoundField HeaderText="Rel. Exp." DataField="RelevantExperience" />
                                     <asp:BoundField HeaderText="Experience Domain" DataField="JobExperienceDomain" />
                                     <asp:BoundField HeaderText="Expected Domain" DataField="JobExpectedDomain" />
                                    <asp:BoundField HeaderText="Company Name" DataField="CompanyName"  />
                                    <asp:BoundField HeaderText="Interview Status" DataField="InterviewStatus"  />
                                    <%--<asp:BoundField HeaderText="Notes" DataField="Notes" />--%>
                                    <%--<asp:BoundField HeaderText="GoogleReviewPath" DataField="GoogleReviewPath" />
                                    <asp:BoundField HeaderText="CaseStudyPath" DataField="CaseStudyPath" />--%>
                                    <%--<asp:BoundField HeaderText="IsApproved" DataField="IsApproved" />--%>
                                    <asp:TemplateField HeaderText="GoogleScreen Short">
                                        <ItemTemplate>
                                            <asp:HiddenField ID="hdnSendFile" runat="server" Value='<%#Eval("GoogleReviewPath") %>' />
                                            <asp:HyperLink NavigateUrl='<%#"~/UserDocs/GoogleReview/"+ Eval("GoogleReviewPath") %>' runat="server"
                                                ID="hplSendFile" Target="_blank" CssClass="btn btn-success btn-xs">View</asp:HyperLink>
                                        </ItemTemplate>
                                    </asp:TemplateField>

                                    <asp:TemplateField HeaderText="CaseStudy">
                                        <ItemTemplate>
                                            <asp:HiddenField ID="hdnReplyFile" runat="server" Value='<%#Eval("CaseStudyPath") %>' />
                                            <asp:HyperLink NavigateUrl='<%#"~/UserDocs/OnJobSupport/"+ Eval("CaseStudyPath") %>' runat="server"
                                                ID="hplReplyFile" Target="_blank" CssClass="btn btn-warning btn-xs">View</asp:HyperLink>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                     <asp:TemplateField HeaderText="Inputs">
                                        <ItemTemplate>
                                            <asp:HiddenField ID="hdnInputsReplyFile" runat="server" Value='<%#Eval("CaseStudyReplyPath") %>' />
                                            <asp:HyperLink NavigateUrl='<%#"~/UserDocs/OnJobSupport/"+ Eval("CaseStudyReplyPath") %>' runat="server"
                                                ID="hplInputsReplyFile" Target="_blank" CssClass="btn btn-success btn-xs">View</asp:HyperLink>
                                        </ItemTemplate>
                                    </asp:TemplateField>

                                    <asp:TemplateField HeaderText="Status">
                                        <ItemTemplate>
                                            <%# (Boolean.Parse(Eval("IsApproved").ToString()) ? "Sent" : "Pending" )%>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="On Job Support" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="150px">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lnkEdit" runat="server" SkinID="Green" Text="Send On Job Support" CommandName="cmdEdit"
                                                CommandArgument='<%#Eval("OnJobSupportId")%>' Visible='<%#(Boolean.Parse(Eval("IsApproved").ToString()) ? false:true) %>'></asp:LinkButton>

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
                        <div>
                            <asp:Label ID="PageNumberFooter" runat="server"></asp:Label>
                        </div>
                    </div>
                </div>
        </div>
    </div>
    </div>
</asp:Content>

