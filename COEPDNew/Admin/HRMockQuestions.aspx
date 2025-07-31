<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="HRMockQuestions.aspx.cs" Inherits="Admin_HRMockQuestions" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <script type="text/javascript">
           function alertmeSave() {
            Swal.fire(
                'Details successfully Added',
                '',
                'success'
            )
        }
        function alertmeUpdate() {
            Swal.fire(
                'Details successfully updated',
                '',
                'success'
            )
        }

        function alertmeDuplicate() {
            Swal.fire(
                'Details already exist',
                '',
                'warning'
            )
        }
     </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <!-- Row Start -->
    <div class="row">
        <div class="col-sm-8 col-xs-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        <asp:Label ID="lblTitle" runat="server" />
                    </div>
                </div>
                <div class="widget-body">
                    <div class="form-horizontal no-margin">
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                               Area <sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-5">
                                <asp:TextBox ID="txtQuestionName" Required="" runat="server" />
                            </div>
                        </div>
                       <%-- <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Answer 
                            </label>
                            <div class="col-sm-5">
                                <asp:TextBox ID="txtAnswer" runat="server" />

                            </div>
                        </div>
                           <div class="form-group">
                            <label class="col-sm-3 control-label">
                              Remarks<span style="color: red">*</span>
                            </label>
                            <div class="col-sm-5">
                                <asp:DropDownList ID="ddlRemarks" runat="server" required="">
                                    <asp:ListItem Text="Good" Value="1"></asp:ListItem>
                                    <asp:ListItem Text="VeryGood" Value="2"></asp:ListItem>
                                    <asp:ListItem Text="Satisfied" Value="3"></asp:ListItem>
                                    <asp:ListItem Text="NotApplicable" Value="4"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                              <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Rating<span style="color: red">*</span>
                            </label>
                            <div class="col-sm-5">
                                <asp:DropDownList ID="ddlRating" runat="server" required="">
                                    <asp:ListItem Text="1" Value="1"></asp:ListItem>
                                    <asp:ListItem Text="2" Value="2"></asp:ListItem>
                                    <asp:ListItem Text="3" Value="3"></asp:ListItem>
                                    <asp:ListItem Text="4" Value="4"></asp:ListItem>
                                    <asp:ListItem Text="5" Value="5"></asp:ListItem>
                                    <asp:ListItem Text="6" Value="6"></asp:ListItem>
                                    <asp:ListItem Text="7" Value="7"></asp:ListItem>
                                    <asp:ListItem Text="8" Value="8"></asp:ListItem>
                                    <asp:ListItem Text="9" Value="9"></asp:ListItem>
                                    <asp:ListItem Text="10" Value="10"></asp:ListItem>
                                 </asp:DropDownList>
                            </div>
                        </div>
                      --%>
                        <div class="form-group">
                            <div class="col-sm-offset-3 col-sm-10">
                                <asp:Button ID="btnSubmit" runat="server" SkinID="btnGreen" Text="Submit" OnClick="btnSubmit_Click" />
                                <asp:Button ID="btnCancel" runat="server" Text="Back To List" UseSubmitBehavior="false" OnClick="btnCancel_Click" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

