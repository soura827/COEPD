<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="AdminMentroing.aspx.cs" Inherits="Admin_IndividualMentoring" %>
<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script language="javascript" type="text/javascript">



        function alertmeSave() {
            Swal.fire(
                'KPI Details Successfully Added',
                '',
                'success'
            )
        }
        function alertmeUpdate() {
            Swal.fire(
                ' Updated KPI Details Successfully',
                '',
                'success'
            )
        }

        function alertmeDuplicate() {
            Swal.fire(
                'KPI Details already exist',
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
    <div class="row">
        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        Monthly Mentor KPIS
                    </div>
                </div>


                <div class="widget-body">
                    <div class="form-horizontal no-margin">
                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Select Location
                        <asp:Label runat="server" ID="LocationStar" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                            </label>
                            <div class="col-sm-5">
                                <asp:DropDownList ID="ddlLocation" runat="server" required="" AutoPostBack="true" OnSelectedIndexChanged="ddlLocation_SelectedIndexChanged1"></asp:DropDownList>
                            </div>
                        </div>

                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Select Branch
                                <asp:Label runat="server" ID="BranchStar" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                            </label>
                            <div class="col-sm-5">
                                <asp:DropDownList ID="ddlBranch" runat="server" required=""></asp:DropDownList>
                            </div>
                        </div>


                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Select KPIS
                        <asp:Label runat="server" ID="Label5" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                            </label>
                            <div class="col-sm-5">
                                <asp:DropDownList ID="ddlKpis" runat="server" required="" AutoPostBack="true"></asp:DropDownList>
                            </div>
                        </div>


                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                Select  Teams
                        <asp:Label runat="server" ID="Label1" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                            </label>
                            <div class="col-sm-5">
                                <asp:DropDownList ID="ddlDesignations" runat="server" required="" AutoPostBack="true" OnSelectedIndexChanged="ddlDesignations_SelectedIndexChanged"></asp:DropDownList>
                            </div>
                        </div>

                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                EmployeeNames
                        <asp:Label runat="server" ID="Label2" ForeColor="Red" Text="*" Font-Bold="true" Font-Size="X-Large"></asp:Label>
                            </label>
                            <div class="col-sm-5">
                                <asp:DropDownList ID="ddlMentroingnames" runat="server" required="" AutoPostBack="true"></asp:DropDownList>
                            </div>
                        </div>

                        <div class="form-group">
                            <label class="col-sm-2 control-label">
                                KPI Targets<sup class="sup">*</sup>
                            </label>
                            <div class="col-sm-5">
                                <asp:TextBox ID="txtTargets" runat="server" MaxLength="100" AutoPostBack="true" Required=""></asp:TextBox>
                            </div>
                        </div>

                        <div class="col-sm-offset-2 col-sm-10">
                            <asp:Button ID="btnSubmit" runat="server" Text="Save" OnClick="btnSubmit_Click"
                                UseSubmitBehavior="false"
                                OnClientClick="this.disabled='true'; this.value='Please Wait...';" />
                            <asp:Button ID="btnCancel" runat="server" Text="Back To List" UseSubmitBehavior="false" CausesValidation="false" OnClick="btnCancel_Click" />

                        </div>
                    </div>
                </div>

            </div>

        </div>
    </div>

</asp:Content>

