<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="RequestFAQs.aspx.cs" Inherits="Admin_RequestFAQs" %>

<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .ui-widget-content .ui-icon {
            /*background-image: url("../App_Themes/admin//images/ui-icons_222222_256x240.png")*/
            /*background-image:url("../App_Themes/admin/img/ui-icons_444444_256x240.png")*/
            background-image: url("../App_Themes/admin/img/ui-icons_3d80b3_256x240.png") !important;
        }

        .ui-widget-header .ui-icon {
            /*background-image: url("../App_Themes/admin/img/ui-icons_444444_256x240.png")*/
            background-image: url("../App_Themes/admin/img/ui-icons_3d80b3_256x240.png") !important;
        }
    </style>
    <script type="text/javascript" src="../App_Themes/admin/js/jquery.js"></script>
    <a href="../Participant/ReferFriend.aspx">../Participant/ReferFriend.aspx</a>
    <script type="text/javascript" src="../App_Themes/admin/js/jquery-ui-v1.10.3.js"></script>
    <script type="text/javascript">
        $(document).ready(function ($) {
            $("input[id$=txtInterviewDate]").datepicker({
                changeMonth: true,
                changeYear: true,
                dateFormat: 'dd/mm/yy',
                maxDate: "0"
            });
        });
        function alertmeSave() {
            Swal.fire(
                'FAQs Sent Successfully',
                '',
                'success'
            )
        }
        function alertmeUpdate() {
            Swal.fire(
                'FAQs Sent Successfully',
                '',
                'success'
            )
        }

        function alertmeDuplicate() {
            Swal.fire(
                'Request FAQs already exist',
                '',
                'warning'
            )
        }
        function alertmeMentorUpdate() {
            Swal.fire(
                'FAQs Request sent to Mentors Successfully',
                '',
                'success'
            )
        }
        function alertmeResumeSubMission() {
            Swal.fire(
                'RequestFAQs Already exist',
                '',
                'warning'
            )
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" runat="Server">
    <uc1:FormMessage ID="FormMessage" runat="server" />
    <uc2:ErrorMessage ID="ErrorMessage" runat="server" Visible="false" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!-- Row Start -->
    <div class="row">
        <div class="col-sm-8 col-xs-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        <asp:Label ID="lblTitle" runat="server"></asp:Label>
                    </div>
                </div>
                <div class="widget-body">
                    <div class="form-horizontal no-margin">
                        <div class="form-group" id="divParticipant" runat="server">
                            <label class="col-sm-2 control-label">
                                participant Name 
                            </label>
                            <div class="col-sm-6">
                                <asp:Label runat="server" ID="lblParticipant">

                                </asp:Label>
                                <%-- <asp:HiddenField runat="server" ID="hdnParticipantId" />--%>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Company Name<sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-6">
                                <asp:TextBox runat="server" ID="txtCompanyName" Required=""></asp:TextBox>
                            </div>
                        </div>



                
                            <asp:HiddenField runat="server" ID="hdnRSId" />
    




                        <div class="form-group" id="divAttachments" runat="server">
                            <label class="col-sm-2 control-label">
                                Attachments
                            </label>
                            <div class="col-sm-9">
                                <h5>
                                    <asp:HyperLink ID="hplSentFile" runat="server" CssClass="btn btn-success btn-sm" Target="_blank" Visible="true">View Proof of Interview</asp:HyperLink>
                                </h5>
                            </div>
                        </div>




                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Pariticipant Inputs
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtParticipantInputs" runat="server" required="" TextMode="MultiLine"></asp:TextBox>
                            </div>
                        </div>
                        <div id="divGrid" runat="server">
                            <div class="form-group">

                                <div class="col-lg-4 col-md-4">

                                    <asp:TextBox runat="server" ID="txtcompany" MaxLength="500" placeholder="Company Name" OnTextChanged="txtcompany_TextChanged" AutoPostBack="true"></asp:TextBox>
                                </div>
                                <div class="col-lg-4 col-md-4">
                                    <asp:TextBox runat="server" ID="txtSkilSet" MaxLength="500" placeholder="Skill Set" OnTextChanged="txtcompany_TextChanged" AutoPostBack="true"></asp:TextBox>
                                </div>

                                <%-- <div class="col-lg-2 col-md-2">
                                    <asp:TextBox runat="server" ID="txtRevised" MaxLength="500" placeholder="revised" OnTextChanged="txtcompany_TextChanged" AutoPostBack="true"></asp:TextBox>
                                </div>--%>
                                <div class="col-md-4 col-lg-4">
                                    <asp:DropDownList ID="ddlSource" runat="server" AutoPostBack="true" OnTextChanged="txtcompany_TextChanged">
                                        <asp:ListItem Text="Employee" Value="False"></asp:ListItem>
                                        <asp:ListItem Text="Participant" Value="True"></asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                            </div>


                            <div class="form-group">
                                <div class="table-responsive">
                                    <div class="col-lg-12 col-sm-12 col-md-12" style="overflow-y: scroll; max-height: 500px;">
                                        <asp:GridView ID="gv" runat="server" AutoGenerateColumns="false" HeaderStyle-HorizontalAlign="Center" AllowPaging="true" AllowSorting="true" OnRowCommand="gv_RowCommand" OnPageIndexChanging="gv_PageIndexChanging" ShowHeaderWhenEmpty="true" EmptyDataText="No Records Found!" OnPreRender="gv_PreRender" PageSize="50">
                                            <Columns>
                                                <asp:BoundField HeaderText="S.No" DataField="SNo" />
                                                <asp:BoundField HeaderText="Company Name" DataField="CompanyName" />
                                                <asp:BoundField HeaderText="Experience" DataField="Experience" />
                                                <asp:BoundField HeaderText="Skilll Set" DataField="SkilSet" />
                                                <asp:BoundField HeaderText="Interview Round" DataField="InterviewStatus" />
                                                <asp:TemplateField HeaderText="Source">
                                                    <ItemTemplate>
                                                        <%# (Boolean.Parse(Eval("IsSourceParticipant").ToString()) ? "Participant" : "Employee" )%>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Action" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="100px">
                                                    <ItemTemplate>
                                                        <asp:LinkButton ID="lnkEdit" runat="server" Text="Assign" CommandName="cmdAssign"
                                                            CommandArgument='<%#Eval("FAQsId")%>'></asp:LinkButton>
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
                        </div>
                        <div class="form-group" id="divCKEditor" runat="server" visible="false">
                            <div class="form-group">
                                <label class="col-sm-2 control-label">
                                    FAQs
                                </label>
                                <div class="col-sm-10">
                                    <CKEditor:CKEditorControl runat="server" ID="txtFAQs" Required="" length="100">
                                    </CKEditor:CKEditorControl>
                                </div>
                            </div>
                        </div>





          <%--         <div class="form-group">
                            <label class="col-sm-2 control-label">
                                <asp:Label ID="lblIsRevised" runat="server" Text="Is Revised & Approved" Visible="true"></asp:Label>
                            </label>
                            <div class="col-sm-3">
                                <asp:CheckBox ID="chkIsReviesed" runat="server" Visible="true" />
                            </div>
                        </div>--%>




                        <div class="form-group">
                            <div class="col-sm-offset-2 col-sm-10">

                                <asp:Button ID="btnRequestToMentor" runat="server" Text="Request To Mentor" SkinID="btnGreen" OnClick="btnRequestToMentor_Click" CausesValidation="false" />



                                    <asp:Button ID="btnCancel" runat="server" Text="Back to list" UseSubmitBehavior="false"
                                    OnClick="btnCancel_Click" CausesValidation="false" />



                            </div>
                        </div>

                    </div>
                </div>
            </div>

        </div>
    </div>
</asp:Content>

