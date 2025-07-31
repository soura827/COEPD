<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="ParticipantPlacementAssistanceDataSheetSearchAdmin.aspx.cs" Inherits="Admin_ParticipantPlacementAssistanceDataSheetSearchAdmin" EnableEventValidation="false" %>

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
                        Participant BA Job market  Assistance Data Sheet
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">



                        <div class="col-md-2 col-lg-2">
                            <asp:TextBox runat="server" ID="txtParticipate" MaxLength="500" placeholder="Participate-Name,Email,Mobile,ID" AutoPostBack="true" OnTextChanged="txtParticipate_TextChanged"></asp:TextBox>
                        </div>

                        <div class="col-md-2 col-lg-2">
                            <asp:TextBox runat="server" ID="txtProfileOwner" MaxLength="100" Placeholder="Profile Owner-Name,Email,Mobile" AutoPostBack="true" OnTextChanged="Unnamed_TextChanged"></asp:TextBox>
                        </div>


                        <div class="col-md-2 col-lg-2">
                            <asp:TextBox runat="server" ID="txtTotalExperience" MaxLength="500" placeholder="Total Experience in Years " AutoPostBack="true" TextMode="Number" OnTextChanged="txtTotalExperience_TextChanged"></asp:TextBox>
                        </div>

                        <div class="col-md-2 col-lg-2">
                            <asp:TextBox runat="server" ID="txtRelevantExperiance" MaxLength="500" placeholder="Relevant Experiance in Years" AutoPostBack="true" TextMode="Number" OnTextChanged="txtRelevantExperiance_TextChanged"></asp:TextBox>
                        </div>



                        <div class="col-md-2 col-lg-2">
                            <asp:TextBox runat="server" ID="txtJobExperienceDomain" MaxLength="500" placeholder="JobExperienceDomain" AutoPostBack="true" OnTextChanged="txtJobExperienceDomain_TextChanged"></asp:TextBox>
                        </div>


                        <div class="col-md-2 col-lg-2">
                            <asp:TextBox runat="server" ID="txtLocation" MaxLength="500" placeholder="Location" AutoPostBack="true" OnTextChanged="txtLocation_TextChanged"></asp:TextBox>
                        </div>

                    </div>
                    <div class="row">
                        &nbsp;
                    </div>


                    <div class="row">
                        <div class="col-md-2 col-lg-2">
                            <asp:DropDownList ID="ddlStatus" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlStatus_SelectedIndexChanged">
                                <asp:ListItem Text="Data Sheet Pending" Value="False"></asp:ListItem>
                                <asp:ListItem Text="Data Sheet Approved" Value="True"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                      <div class="row">
                            <div class="col-lg-2 col-md-2">
                                <label class="control-label">
                                    subscription  Valid
                                </label>
                                <asp:RadioButton runat="server" ID="rbActive"  Checked="true" AutoPostBack="true" OnCheckedChanged="rbActive_CheckedChanged" GroupName="radio" />
                            </div>
                            <div class="col-lg-3 col-md-3">
                                <label class="control-label">
                                    subscription In Valid
                                </label>
                                <asp:RadioButton runat="server" ID="rbDeleted"   AutoPostBack="true" GroupName="radio" OnCheckedChanged="rbDeleted_CheckedChanged" />
                            </div>
                        </div>    
                     
                        <div class="col-lg-2 col-md-2">
                            <asp:Button ID="btnDownload" runat="server" Text="Download" OnClick="btnDownload_Click" UseSubmitBehavior="false" />
                        </div>
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
                            <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False" Width="100%" PageSize="100" HeaderStyle-HorizontalAlign="Center" AllowPaging="true" AllowSorting="true" OnRowCommand="gv_RowCommand" OnRowDataBound="gv_RowDataBound" OnPageIndexChanging="gv_PageIndexChanging" ShowHeaderWhenEmpty="true" EmptyDataText="No Records Found!" OnPreRender="gv_PreRender">
                                <Columns>



                                    <asp:BoundField HeaderText="SNo" DataField="SNo" ItemStyle-Width="50px" />
                                    <asp:BoundField HeaderText="Name" DataField="FullName" ItemStyle-Width="150px" />


                                    <asp:BoundField HeaderText="Total Experience" DataField="TotalExperiencess" />

                                    <asp:BoundField HeaderText="Relevant experiance" DataField="RelevantExperiencess" />
                                    <asp:BoundField HeaderText="Current CTC" DataField="CurrentCTC" />
                                    <asp:BoundField HeaderText="Expected CTC" DataField="ExpectedCTC" />






                                    <asp:BoundField HeaderText="Job Experience Domain" DataField="JobExperienceDomain" ItemStyle-Width="200px" />
                                    <asp:BoundField HeaderText="Job Expected Domain" DataField="JobExpectedDomain" ItemStyle-Width="200px" />

                                    <asp:BoundField HeaderText="Email ID" DataField="Email" ItemStyle-Width="200px" />
                                    <asp:BoundField HeaderText="Mobile" DataField="ActiveMobile" ItemStyle-Width="200px" />
                                    <asp:BoundField HeaderText="Preferred Locations" DataField="PreferredLocations" ItemStyle-Width="200px" />
                                     <asp:BoundField HeaderText="SubscriptionExpiredOn" DataField="SubscriptionExpiredOn" ItemStyle-Width="200px" />


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















                                    <asp:TemplateField HeaderText="Status">
                                        <ItemTemplate>
                                            <%# (Boolean.Parse(Eval("IsDataSheetApproved").ToString()) ? "Approved" : "Pending" )%>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField HeaderText="Profile Owner" DataField="ProfileOwnerName" />
                                    <asp:TemplateField HeaderText="Assign profile Owner" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="150px">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lnkAssignProfileOwner" runat="server" Text="Assign Profile Owner" CommandName="cmdProfileOwner"
                                                CommandArgument='<%#Eval("ParticipantId")%>' Visible='<%#(Boolean.Parse(Eval("IsProfileOwnerAssigned").ToString()) ? false:true) %>'></asp:LinkButton>
                                            <asp:LinkButton ID="lnkChangeProfileOwner" runat="server" SkinID="Orange" Text="Change Profile Owner" CommandName="cmdChangeProfileOwner"
                                                CommandArgument='<%#Eval("ParticipantId") %>' Visible='<%#(Boolean.Parse(Eval("IsProfileOwnerAssigned").ToString()) ? true:false) %>'></asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Action" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="100px">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lnkEdit" runat="server" SkinID="edit" CommandName="cmdEdit"
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

