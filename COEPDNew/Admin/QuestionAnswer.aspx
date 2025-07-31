<%@ Page Title="" Language="C#" MasterPageFile="Admin.master" AutoEventWireup="true"
    CodeFile="QuestionAnswer.aspx.cs" Inherits="QuestionAnswer" %>

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
                                Exam Category
                            </label>
                            <div class="col-sm-10">
                                <asp:DropDownList ID="ddlCategory" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlCategory_SelectedIndexChanged"
                                    Required="">
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Topic
                            </label>
                            <div class="col-sm-10">
                                <asp:DropDownList ID="ddlTopic" runat="server" Required="">
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Question
                            </label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtQuestion"  MaxLength="2000" runat="server" Required=""></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                                <label class="col-sm-2 control-label">
                                    Hint
                                </label>
                                <div class="col-sm-10">
                                    <asp:TextBox ID="txtDescription" MaxLength="2000" runat="server" Required=""></asp:TextBox>
                                </div>
                            </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Answer 1
                            </label>
                            <div class="col-sm-4">
                                <asp:TextBox ID="txtAnswer1" MaxLength="5000" runat="server" Required=""></asp:TextBox>
                            </div>
                            <div class="col-sm-1">
                                <strong>Marks</strong>
                            </div>
                            <div class="col-sm-5">
                                <asp:TextBox ID="txtMarks1" type="number" runat="server" Required=""></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Answer 2
                            </label>
                            <div class="col-sm-4">
                                <asp:TextBox ID="txtAnswer2" MaxLength="5000" runat="server" Required></asp:TextBox>
                            </div>
                            <div class="col-sm-1">
                                <strong>Marks</strong>
                            </div>
                            <div class="col-sm-5">
                                <asp:TextBox ID="txtMarks2" type="number" runat="server" Required></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Answer 3
                            </label>
                            <div class="col-sm-4">
                                <asp:TextBox ID="txtAnswer3" MaxLength="5000" runat="server"></asp:TextBox>
                            </div>
                            <div class="col-sm-1">
                                <strong>Marks</strong>
                            </div>
                            <div class="col-sm-5">
                                <asp:TextBox ID="txtMarks3" type="number" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Answer 4
                            </label>
                            <div class="col-sm-4">
                                <asp:TextBox ID="txtAnswer4" MaxLength="5000" runat="server"></asp:TextBox>
                            </div>
                            <div class="col-sm-1">
                                <strong>Marks</strong>
                            </div>
                            <div class="col-sm-5">
                                <asp:TextBox ID="txtMarks4" type="number" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-sm-offset-2 col-sm-10">
                                <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Save" />
                               
                                <asp:Button ID="btnCancel" runat="server" Text="Back to list" UseSubmitBehavior="false"
                                    OnClick="btnCancel_Click" CausesValidation="false" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Row End -->
</asp:Content>
