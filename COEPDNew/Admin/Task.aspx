<%@ Page Title="" Language="C#" MasterPageFile="Admin.master" AutoEventWireup="true"
    CodeFile="Task.aspx.cs" Inherits="Task" %>

<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" runat="Server">
    <uc1:FormMessage ID="FormMessage" runat="server" Visible="false" />
    <uc2:ErrorMessage ID="ErrorMessage" runat="server" Visible="false" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!-- Row Start -->
    <div class="row">
        <div class="col-lg-8 col-md-12">
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
                                Task Name
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtTask" MaxLength="500" runat="server" Required=""></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Priority
                            </label>
                            <div class="col-sm-10">
                                <asp:DropDownList ID="ddlPriority" runat="server" Required="">
                                    <asp:ListItem Text="-- Select Priority --" Value=""></asp:ListItem>
                                    <asp:ListItem Text="High" Value="1"></asp:ListItem>
                                    <asp:ListItem Text="Medium" Value="2"></asp:ListItem>
                                    <asp:ListItem Text="Low" Value="3"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Assigned To
                            </label>
                            <div class="col-sm-10">
                                <asp:DropDownList ID="ddlEmp" runat="server" Required="">
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Description
                            </label>
                            <div class="col-sm-10">
                                <CKEditor:CKEditorControl ID="txtDescription" runat="server" Height="200" Toolbar="Basic">
                                </CKEditor:CKEditorControl>
                            </div>
                        </div>





                         <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Attachments
                            </label>
                            <div class="col-sm-9">
                                <h5>:
                                <asp:HyperLink ID="hplPhotoFile" runat="server" CssClass="btn btn-success btn-sm" Target="_blank">View Photo</asp:HyperLink>

                                </h5>
                            </div>
                        </div>








                        &nbsp;

                        <div class="form-group" id="fileUpload" runat="server">
                            <label class="col-sm-2 control-label">
                                Upload File<small>(Up to 10 MB)</small>
                            </label>
                            <div class="col-sm-9">
                                <asp:FileUpload ID="flUpload" runat="server" />
                            </div>
                        </div>













                        <div class="form-group">
                            <div class="col-sm-offset-2 col-sm-10">
                                <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Save" />
                                <asp:Button ID="btnCancel" runat="server" Text="Back to list" UseSubmitBehavior="false"
                                    OnClick="btnCancel_Click" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="col-lg-4 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        Description
                    </div>
                </div>
                <div class="widget-body" style="height: 300px; overflow-y: scroll">
                    <div class="viewport">
                        <div class="overview">
                            <ul class="chats">
                                <asp:Repeater ID="rp" runat="server" OnItemDataBound="rp_ItemDataBound">
                                    <ItemTemplate>
                                        <asp:HiddenField ID="hdnInserted" runat="server" Value='<%# Eval("InsertedBy")%>' />
                                        <asp:Panel ID="pnlIn" runat="server" Visible="false">
                                            <li class="in">
                                                <img class="avatar" alt="" src="../img/profile.png" />
                                                <div class="message">
                                                    <span class="arrow"></span><a href="#" class="name">
                                                        <%# Eval("AssignedEmployee")%>
                                                    </a><span class="date-time">at
                                                        <%# Eval("CreatedOn", "{0:MMM dd, yyyy HH:mm}")%>
                                                    </span><span class="body">
                                                        <%# Eval("Description") %></span>
                                                </div>
                                            </li>
                                        </asp:Panel>
                                        <asp:Panel ID="PnlOut" runat="server" Visible="false">
                                            <li class="out">
                                                <img class="avatar" alt="" src="../img/profile.png">
                                                <div class="message">
                                                    <span class="arrow"></span><a href="#" class="name">
                                                        <%# Eval("Employee")%>
                                                    </a><span class="date-time">at
                                                        <%# Eval("CreatedOn", "{0:MMM dd, yyyy HH:mm}")%>
                                                    </span><span class="body">
                                                        <%# Eval("Description") %>
                                                    </span>
                                                </div>
                                            </li>
                                        </asp:Panel>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
            <div class="widget" id="divMenterinputs" runat="server">
                <div class="form-horizontal no-margin">
                    <div class="widget-header">
                        <div class="title">
                            Inputs
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-sm-12">
                            <asp:TextBox ID="txtChat" runat="server" TextMode="MultiLine" Height="120px"
                                placeholder="Enter Details">
                            </asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-sm-offset-3 col-sm-9">
                            <asp:Button ID="btnSend" runat="server" Text="Send Description" UseSubmitBehavior="false"
                                OnClick="btnSend_Click" />
                        </div>
                    </div>
                </div>
            </div>



        </div>




    </div>
    <!-- Row End -->

    <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
    <script type="text/javascript">
        jQuery(document).ready(function () {

            $("[id*=btnSend]").click(function () {


                var mesg = $("[id*=txtChat]").val();

                if (mesg.length == 0) {
                    alert('Please Enter Mentor Inputs');
                    $("[id*=txtChat]").focus();
                    //return false;
                }


            });
        });
    </script>
</asp:Content>
