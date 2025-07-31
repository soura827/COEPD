<%@ Page Title="" Language="C#" MasterPageFile="Participant.master" AutoEventWireup="true" CodeFile="IdeaPost.aspx.cs" Inherits="IdeaPost" %>
<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <%--<script type="text/javascript">
    //$(function () {
    //    //Normal Configuration
    //    $("[id*=txtDescription]").MaxLength({ MaxLength: 10 });
 
        //Specifying the Character Count control explicitly
        //$("[id*=TextBox2]").MaxLength(
        //{
        //    MaxLength: 15,
        //    CharacterCountControl: $('#counter')
        //});
 
        //Disable Character Count
        //$("[id*=TextBox3]").MaxLength(
        //{
        //    MaxLength: 20,
        //    DisplayCharacterCount: false
        //});
    });
</script>--%>
   
    
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
                        <asp:Label ID="lblTitle" runat="server"></asp:Label>
                    </div>
                </div>
                <div class="widget-body">
                    <div class="form-horizontal no-margin">
                         <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Subject
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtSubject" runat="server" Required=""></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Description
                            </label>
                            <div class="col-sm-10">
                                <%--<asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine" Width="300" Height="100"></asp:TextBox>--%>

                                <CKEditor:CKEditorControl ID="txtDescription" runat="server" Height="200">
                                </CKEditor:CKEditorControl>
                                <asp:RegularExpressionValidator Display = "Dynamic" ControlToValidate = "txtDescription" ID="RegularExpressionValidator3" ValidationExpression = "^[\s\S]{5,1000}$" runat="server" ErrorMessage="please enter Maximum 1000 Characters." CssClass="valid1"></asp:RegularExpressionValidator>

                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-sm-offset-2 col-sm-10">
                                <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Save" />
                                <asp:Button ID="btnCancel" runat="server" Text="Back to List" UseSubmitBehavior="false"
                                    OnClick="btnCancel_Click" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    </asp:Content>