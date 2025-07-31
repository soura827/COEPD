<%@ Page Title="" Language="C#" MasterPageFile="~/Participant/Participant.master" AutoEventWireup="true" CodeFile="ResumeSubmissionSearch.aspx.cs" Inherits="Participant_ResumeSubmissionSearch" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!-- Row Start -->
    <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        Resume Submissions
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">

                        <div class="col-md-2 col-lg-2">
                            <asp:TextBox runat="server" ID="txtCompany" MaxLength="500" placeholder="Company Name" AutoPostBack="true" OnTextChanged="txtCompany_TextChanged"></asp:TextBox>
                        </div>
                        <div class="col-md-2 col-lg-2">
                            <asp:TextBox runat="server" ID="txtInterviewStatus" MaxLength="500" placeholder="Search By Interview Status" AutoPostBack="true" OnTextChanged="txtCompany_TextChanged"></asp:TextBox>
                        </div>
                         
                        <div>
                            <div class="col-lg-3 col-md-3">
                                <asp:Button runat="server" ID="btnAdd" Text="Add New" OnClick="btnAdd_Click" />
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        &nbsp;
                    </div>
                    <div class="row">
                        &nbsp;
                    </div>
                    <div>
                        <asp:Label ID="PageNumberHeader" runat="server"></asp:Label>
                    </div>
                    <div class="row">
                        <div class="table-responsive">
                            <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False" Width="100%" PageSize="10" HeaderStyle-HorizontalAlign="Center" AllowPaging="true" AllowSorting="true" OnRowCommand="gv_RowCommand" OnPageIndexChanging="gv_PageIndexChanging" ShowHeaderWhenEmpty="true" EmptyDataText="No Records Found!" OnPreRender="gv_PreRender">
                                <Columns>

                                    <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                    <asp:BoundField HeaderText="Participant" DataField="Participant" ItemStyle-Width="150px" />
                                    <asp:BoundField HeaderText="Location" DataField="ParticipantLocation" />
                                    <asp:BoundField HeaderText="Trainer" DataField="Trainer" />
                                    <asp:BoundField HeaderText="Profile Owner" DataField="ProfileOwner" />
                                    <asp:BoundField HeaderText="Batch Date" DataField="StartDate" DataFormatString="{0: dd MMM yyyy}" />
                                    <asp:BoundField HeaderText="Company Name" DataField="CompanyName" />
                                    <asp:BoundField HeaderText="Applied Through" DataField="AppliedThrough" />
                                    <asp:BoundField HeaderText="Interview Status" DataField="InterviewStatus" />
                                    <asp:BoundField HeaderText="Job Location" DataField="Location" />
                                    <%--<asp:BoundField HeaderText="Job Description" DataField="JobDescription" />--%>
                                    <asp:BoundField HeaderText="Experience" DataField="Experience" />
                                    <asp:BoundField HeaderText="Domain" DataField="Domain" />
                                    <asp:BoundField HeaderText="Applied On" DataField="AppliedOn" DataFormatString="{0: dd MMM yyyy}" />

                                     <asp:BoundField HeaderText="Initial Discussion RoundOn" DataField="InitialDiscussionRound" />
                                      <asp:BoundField HeaderText="Selected/Rejected" DataField="SelectedorRejected" />
                                    
                                     <asp:BoundField HeaderText="Interview Round1 On" DataField="InterviewRound1On" DataFormatString="{0: dd MMM yyyy hh:mm tt}" />
                                     <asp:BoundField HeaderText="Interview Round2 On" DataField="InterviewRound2On" DataFormatString="{0: dd MMM yyyy hh:mm tt}" />
                                     <asp:BoundField HeaderText="Interview Round3 On" DataField="InterviewRound3On" DataFormatString="{0: dd MMM yyyy hh:mm tt}" />
                                     <asp:BoundField HeaderText="Offer Released On" DataField="OfferReleasedOn" DataFormatString="{0: dd MMM yyyy hh:mm tt}" />
                                     <asp:BoundField HeaderText="Offer Accepted On" DataField="OfferAcceptedOn" DataFormatString="{0: dd MMM yyyy hh:mm tt}" />
                                    <asp:BoundField HeaderText="Designation" DataField="Designation" />
                                    <asp:BoundField HeaderText="Package Offered" DataField="PackageOffered" />
                                    <asp:BoundField HeaderText="Date of Joining" DataField="DateofJoining" DataFormatString="{0: dd MMM yyyy}" />
                                      <asp:BoundField HeaderText="Remarks" DataField="Remarks" />
                                    <%-- <asp:TemplateField HeaderText="Applied Through">
                                        <ItemTemplate>
                                            <%# (bool.Parse(Eval("AppliedThroughId").ToString())? "Through job portal" : "Reference") %>
                                        </ItemTemplate>
                                    </asp:TemplateField>--%>
                                    










                                    <asp:TemplateField HeaderText="Interview Status" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="150px">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lnkEdit" runat="server" SkinID="Green" Text="Update" CommandName="cmdEdit"
                                                CommandArgument='<%#Eval("ResumeSubmissionId")%>'></asp:LinkButton>
                                            <br /> 
                                            <br />
                                          <%--  <asp:LinkButton ID="lnkDelete" runat="server" SkinID="delete" CommandName="cmdDelete"
                                            CommandArgument='<%#Eval("ResumeSubmissionId")%>' OnClientClick="return confirm('Are you sure you want to delete this Submission');"></asp:LinkButton>--%>
                                        </ItemTemplate>
                                    </asp:TemplateField>






                                    <asp:TemplateField HeaderText="FAQs" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="150px">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lnkRequestFAQs" runat="server" SkinID="Green" Text="Request" CommandName="cmdRequestFAQs"
                                                CommandArgument='<%#Eval("ResumeSubmissionId")%>' Visible='<%# (Boolean.Parse(Eval("IsOfferAccepted").ToString())? false:true) %>'></asp:LinkButton>
                                            <br />
                                            <br />
                                            <asp:LinkButton ID="lnkViewFAQs" runat="server" SkinID="Orange" Text="View" CommandName="cmdViewFAQs"
                                                CommandArgument='<%#Eval("ResumeSubmissionId")%>' Visible='<%# (Boolean.Parse(Eval("IsOfferAccepted").ToString())? false:true) %>'></asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>








                                     <asp:TemplateField HeaderText="Interview Support" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="150px">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lnkInterviewSupport" runat="server" SkinID="Green" Text="Request" CommandName="cmdInterviewSupport"
                                                CommandArgument='<%#Eval("ResumeSubmissionId")%>' Visible='<%# (Boolean.Parse(Eval("IsOfferAccepted").ToString())? false:true) %>'></asp:LinkButton>
                                            <br />
                                            <br />
                                             <asp:LinkButton ID="lnkViewInterviewSupport" runat="server" SkinID="Orange" Text="View" CommandName="cmdViewInterviewSupport"
                                                CommandArgument='<%#Eval("ResumeSubmissionId")%>' Visible='<%# (Boolean.Parse(Eval("IsOfferAccepted").ToString())? false:true) %>'></asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Add Your Interview Questions" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="150px">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lnkAddInterviewExperiance" runat="server" SkinID="Green" Text="Add" CommandName="cmdAddInterviewExperiance"
                                                CommandArgument='<%#Eval("ResumeSubmissionId")%>' Visible='<%# (Boolean.Parse(Eval("IsOfferAccepted").ToString())? false:true) %>'></asp:LinkButton>
                                            <br />
                                            <br />
                                             <asp:LinkButton ID="lnkViewInterviewExperiance" runat="server" SkinID="Orange" Text="View" CommandName="cmdViewInterviewExperiance"
                                                CommandArgument='<%#Eval("ResumeSubmissionId")%>' Visible='<%# (Boolean.Parse(Eval("IsOfferAccepted").ToString())? false:true) %>'></asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="On Job Support" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="150px">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lnkRequestOnJobSupport" runat="server" SkinID="Green" Text="Request" CommandName="cmdRequestOnJobSupport"
                                                CommandArgument='<%#Eval("ResumeSubmissionId")%>' Visible='<%# (Boolean.Parse(Eval("IsOfferAccepted").ToString())? true:false) %>'></asp:LinkButton>
                                            <br />
                                            <br />
                                             <asp:LinkButton ID="lnkViewOnJobSupport" runat="server" SkinID="Orange" Text="View" CommandName="cmdViewOnJobSupport"
                                                CommandArgument='<%#Eval("ResumeSubmissionId")%>' Visible='<%# (Boolean.Parse(Eval("IsOfferAccepted").ToString())? true:false) %>'></asp:LinkButton>
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

