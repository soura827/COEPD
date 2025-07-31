<%@ Page Title="" Language="C#" MasterPageFile="Participant.master" AutoEventWireup="true"
    CodeFile="Job.aspx.cs" Inherits="Job" %>
<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script type="text/javascript">
        function SetTarget() {
            document.forms[0].target = "_blank";
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
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
                        <asp:Label ID="lblTitle" runat="server"></asp:Label>
                    </div>
                </div>
                <div class="widget-body">
                    <div class="form-horizontal no-margin">
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Job Title&nbsp;&nbsp;&nbsp;:
                            </label>
                            <div class="col-sm-10" style="padding-top: 7px">
                                <asp:Label ID="lblJobTitle" runat="server"></asp:Label>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Job Domain&nbsp;&nbsp;&nbsp;:
                            </label>
                            <div class="col-sm-10" style="padding-top: 7px">
                                <asp:Label ID="lblDomain" runat="server"></asp:Label>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Location&nbsp;&nbsp;&nbsp;:
                            </label>
                            <div class="col-sm-10" style="padding-top: 7px">
                                <asp:Label ID="lblLocation" runat="server"></asp:Label>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Company&nbsp;&nbsp;&nbsp;:
                            </label>
                            <div class="col-sm-10" style="padding-top: 7px">
                                <asp:Label ID="lblCompany" runat="server"></asp:Label>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Phone&nbsp;&nbsp;&nbsp;:
                            </label>
                            <div class="col-sm-10" style="padding-top: 7px">
                                <asp:Label ID="lblPhone" runat="server"></asp:Label>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Email&nbsp;&nbsp;&nbsp;:
                            </label>
                            <div class="col-sm-10" style="padding-top: 7px">
                                <asp:Label ID="lblEmail" runat="server"></asp:Label>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Years of Experience&nbsp;&nbsp;&nbsp;:
                            </label>
                            <div class="col-sm-10" style="padding-top: 7px">
                                <asp:Label ID="lblExperience" runat="server"></asp:Label>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Apply Here&nbsp;&nbsp;&nbsp;:
                            </label>
                            <div class="col-sm-10" style="padding-top: 7px">
                                <%--<asp:HyperLink ID="hpl" runat="server" Text="Click Here" Target="_blank" CssClass="btn btn-success btn-sm"></asp:HyperLink>--%>
                                <asp:Button ID="btnLink" runat="server" Text="Click Here" CssClass="btn btn-success btn-sm" OnClick="btnLink_Click" OnClientClick="SetTarget();" />
                                <asp:HiddenField ID="hdnWebLink" runat="server" />
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Description&nbsp;&nbsp;&nbsp;:
                            </label>
                            <div class="col-sm-10" style="padding-top: 7px">
                                <asp:Label ID="lblFullDescription" runat="server"></asp:Label>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-sm-offset-2 col-sm-10">
                                <asp:Button ID="btnCancel" runat="server" Text="Back to list" UseSubmitBehavior="false"
                                    OnClick="btnCancel_Click" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Row End -->
</asp:Content>