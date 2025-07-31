<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="ResumeSubmissionSearch.aspx.cs" Inherits="Admin_ResumeSubmissionSearch" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" runat="Server">
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
                            <asp:TextBox runat="server" ID="txtParticipant" MaxLength="500" placeholder="Participant-Name,Email,Mobile,ReferenceID" AutoPostBack="true" OnTextChanged="txtCompany_TextChanged"></asp:TextBox>
                        </div>
                        <div class="col-md-2 col-lg-2">
                            <asp:TextBox runat="server" ID="txtCompany" MaxLength="500" placeholder="Company Name" AutoPostBack="true" OnTextChanged="txtCompany_TextChanged"></asp:TextBox>
                        </div>


                        <div class="col-md-2 col-lg-2">
                            <asp:TextBox runat="server" ID="txtInterviewStatus" MaxLength="500" placeholder="Search By Interview Status" AutoPostBack="true" OnTextChanged="txtCompany_TextChanged"></asp:TextBox>
                        </div>

                        <div class="col-md-2 col-lg-2">
                            <asp:TextBox runat="server" ID="txtCreatedBy" MaxLength="500" placeholder="Search By Associotes" AutoPostBack="true" OnTextChanged="txtCreatedBy_TextChanged"></asp:TextBox>
                        </div>




                        <div class="col-md-2 col-lg-2">
                            <asp:DropDownList ID="ddlAppliedThrough" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlAppliedThrough_SelectedIndexChanged">
                                <asp:ListItem Text="--Select Applied Through--" Value=""></asp:ListItem>
                                <asp:ListItem Text="Through Job Portal(Naukari, Monster etc.,)" Value="1"></asp:ListItem>
                                <asp:ListItem Text="Reference" Value="2"></asp:ListItem>
                                <asp:ListItem Text="COEPD Portal" Value="3"></asp:ListItem>
                                <asp:ListItem Text="COEPD Job-Market" Value="4"></asp:ListItem>
                            </asp:DropDownList>
                        </div>






                        <div class="col-lg-1 col-md-1">
                            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" SkinID="addnew" CausesValidation="false" />
                        </div>
                        <div class="col-lg-2 col-md-2">
                            <asp:Button ID="btnDownload" runat="server" Text="Download" OnClick="btnDownload_Click" UseSubmitBehavior="false" />
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

                            <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False" Width="100%" PageSize="50" HeaderStyle-HorizontalAlign="Center" AllowPaging="true" AllowSorting="true" OnRowCommand="gv_RowCommand" OnPageIndexChanging="gv_PageIndexChanging" ShowHeaderWhenEmpty="true" EmptyDataText="No Records Found!" OnPreRender="gv_PreRender">
                                <Columns>

                                    <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                    <asp:BoundField HeaderText="Participant" DataField="Participant" ItemStyle-Width="150px" />
                                    <asp:BoundField HeaderText="Email" DataField="Email" />
                                    <asp:BoundField HeaderText="Mobile" DataField="Mobile" />
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
                                    <asp:BoundField HeaderText="Remarks" DataField="Remarks" />


                                    <asp:BoundField HeaderText="Interview Round1 On" DataField="InterviewRound1On" DataFormatString="{0: dd MMM yyyy hh:mm tt}" />
                                    <asp:BoundField HeaderText="Interview Round2 On" DataField="InterviewRound2On" DataFormatString="{0: dd MMM yyyy hh:mm tt}" />
                                    <asp:BoundField HeaderText="Interview Round3 On" DataField="InterviewRound3On" DataFormatString="{0: dd MMM yyyy hh:mm tt}" />
                                    <asp:BoundField HeaderText="Offer Released On" DataField="OfferReleasedOn" DataFormatString="{0: dd MMM yyyy hh:mm tt}" />
                                    <asp:BoundField HeaderText="Offer Accepted On" DataField="OfferAcceptedOn" DataFormatString="{0: dd MMM yyyy hh:mm tt}" />
                                    <asp:BoundField HeaderText="Designation" DataField="Designation" />

                                    <asp:BoundField HeaderText="Package Offered" DataField="PackageOffered" />
                                    <asp:BoundField HeaderText="Date of Joining" DataField="DateofJoining" DataFormatString="{0: dd MMM yyyy}" />
                                    <asp:BoundField HeaderText="Associates" DataField="Fullname" />
                                    <asp:TemplateField HeaderText="Action" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="150px">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lnkEdit" runat="server" SkinID="Green" Text="Edit" CommandName="cmdEdit"
                                                CommandArgument='<%#Eval("ResumeSubmissionId")%>'></asp:LinkButton>
                                            <%--<asp:LinkButton ID="lnkDelete" runat="server" SkinID="delete" CommandName="cmdDelete"
                                            CommandArgument='<%#Eval("ResumeSubmissionId")%>' OnClientClick="return confirm('Are you sure you want to delete this Submission');"></asp:LinkButton>--%>
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

