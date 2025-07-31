<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="Service.aspx.cs" Inherits="Admin_Service" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <script type="text/javascript">
        function alertmeSave() {
            Swal.fire(
                      'Service Added Successfully',
                      '',
                      'success'
                    )
        }
        function alertmeUpdate() {
            Swal.fire(
                      'Service Updated Successfully',
                      '',
                      'success'
                    )
        }

        function alertmeDuplicate() {
            Swal.fire(
                      'Service already exist',
                      '',
                      'warning'
                    )
        }
     </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <asp:ScriptManager ID="ScriptManager2" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <!-- Row Start -->
            <div class="Row">
                <div class="col-lg-12 col-md-12">
                    <div class="widget">
                        <div class="widget-header">
                            <div class="title">
                                <asp:Label runat="server" ID="lblTitle"></asp:Label>
                            </div>
                        </div>
                        <div class="widget-body">
                            <div class="form-horizontal no-margin">
                                <div class="form-group">
                                    <label class="col-sm-2 control-label">
                                        Service Name:<sup class="sup">*</sup>
                                    </label>
                                    <div class="col-sm-5">
                                        <asp:TextBox ID="txtServiceName" runat="server" Required="" AutoPostBack="true" OnTextChanged="txtServiceName_TextChanged"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="col-sm-2 control-label">
                                        Fee:<sup class="sup">*</sup>
                                    </label>
                                    <div class="col-sm-5">
                                        <asp:TextBox ID="txtFees" runat="server" TextMode="Number" required="" ></asp:TextBox>
                                    </div>
                                </div>
                                 <div class="form-group">
                                    <label class="col-sm-2 control-label">
                                        Description:
                                    </label>
                                    <div class="col-sm-5">
                                     <%--   <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>--%>
                                        <asp:TextBox ID="txtDes" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <div class="col-sm-offset-2 col-sm-10">
                                        <asp:Button runat="server"  ID="btnSave" Text="Save" OnClick="btnSave_Click" />
                                        <asp:Button runat="server" ID="btnBack" Text="Back To List" OnClick="btnBack_Click" UseSubmitBehavior="false" />
                                    </div>
                                </div>

                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
    <!-- Row End -->
</asp:Content>

