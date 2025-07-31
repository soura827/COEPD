<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="Session.aspx.cs" Inherits="Admin_Session" %>

<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

    <script language="javascript" type="text/javascript">



        function alertmeSave() {
            Swal.fire(
                'Session Details Successfully Added',
                '',
                'success'
            )
        }
        function alertmeUpdate() {
            Swal.fire(
                ' Updated Session  Details Successfully',
                '',
                'success'
            )
        }

        function alertmeDuplicate() {
            Swal.fire(
                'Participant Fee Details already exist',
                '',
                'warning'
            )
        }
    </script>
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
                        <asp:Label ID="lblTitle" runat="server"></asp:Label>
                    </div>
                </div>
                <div class="widget-body">
                    <div class="form-horizontal no-margin">
                        <div class="form-group">



                            <label class="col-sm-2 control-label">
                                Choose Session:
                              
                            </label>

                            <div class="col-sm-5">
                                <asp:DropDownList ID="ddlSession" runat="server" required="" AutoPostBack="true" OnSelectedIndexChanged="ddlSession_SelectedIndexChanged">
                                </asp:DropDownList>
                            </div>

                        </div>

                        <div id="divAwareness" runat="server" visible="false">

                            <div class="form-group">
                                <label class="col-sm-2 control-label">
                                    Enter Session Name
                                </label>
                                <div class="col-sm-5">
                                    <asp:TextBox ID="txtAwarenessSessionName" runat="server"></asp:TextBox>
                                </div>

                            </div>

                        </div>

                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Date
                            </label>
                            <div class="col-sm-5">
                                <asp:TextBox ID="txtDate" runat="server" TextMode="Date"></asp:TextBox>
                            </div>
                        </div>



                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Start Time
                            </label>
                            <div class="col-sm-2">
                                <asp:TextBox ID="txtStarttime" runat="server" TextMode="Time"></asp:TextBox>
                            </div>

                            <label class="col-sm-1 control-label">
                                End Time
                            </label>

                            <div class="col-sm-2">
                                <asp:TextBox ID="txtEndtime" runat="server" TextMode="Time"></asp:TextBox>
                            </div>
                        </div>




                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Search Session Trainer
                            </label>
                            <div class="col-sm-2">
                                <asp:TextBox ID="txtSessionTrainer" runat="server" OnTextChanged="txtSessionTrainer_TextChanged" AutoPostBack="true" required="" ></asp:TextBox>
                            </div>

                            <label class="col-sm-1 control-label">
                                Select Session Trainer
                            </label>
                            <div class="col-sm-2">
                                <asp:DropDownList ID="ddlSessionTrainer" runat="server" required=""></asp:DropDownList>
                            </div>
                        </div>
















                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Zoom meeting ID
                            </label>
                            <div class="col-sm-5">
                                <asp:TextBox ID="txtZoomMeetingId" runat="server"></asp:TextBox>
                            </div>
                        </div>


                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Password
                            </label>
                            <div class="col-sm-5">
                                <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                            </div>
                        </div>


                        <div class="form-group">
                            <div class="col-sm-offset-2 col-sm-10">
                                <asp:Button ID="btnSubmit" runat="server" Text="Save" OnClick="btnSubmit_Click" />
                                <asp:Button ID="btnCancel" runat="server" Text="Back to list" UseSubmitBehavior="false" OnClick="btnCancel_Click" />

                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

