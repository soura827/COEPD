<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="PlacementHRMock.aspx.cs" Inherits="Admin_PlacementHRMock" %>

<%@ Register Src="~/Controls/FormMessage.ascx" TagPrefix="uc1" TagName="FormMessage" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagPrefix="uc2" TagName="ErrorMessage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpLeft" runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <uc1:FormMessage runat="server" ID="FormMessage" />
    <uc2:ErrorMessage runat="server" ID="ErrorMessage" />
    <script type="text/javascript">  

        $(document).ready(function () {
            CalculateTotal();
            $('.items').change(function () { CalculateTotal(); });
        });
        function CalculateTotal() {
            var val = 0;
            $('.items').each(function () {
                val = val + parseFloat($(this).find('option:selected').val());
            });
            $('#LabelTotal').text(val);
            val = 0;
        }
    </script>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <!-- Row Start -->


    <div class="row">
        <div class="col-sm-12 col-xs-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        <asp:Label ID="lblTitle" Text="Conduct HR Mock" runat="server"></asp:Label>
                    </div>
                </div>
                <div class="widget-body">
                    <div class="form-horizontal no-margin">
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Participant
                            </label>
                            <div class="col-sm-9">
                                :
                                <asp:Label runat="server" ID="lblParticipantName" Font-Bold="true" Font-Size="Small"></asp:Label>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Qualification
                            </label>
                            <div class="row">
                                <div class="col-md-3 col-lg-3">
                                    <asp:TextBox runat="server" ID="txtQulaifcation" MaxLength="500" placeholder="Qualification" AutoPostBack="true" />
                                </div>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                BA Experience
                            </label>
                            <div class="col-sm-9">
                                :
                                <asp:Label runat="server" ID="lblBAExp" Font-Bold="true" Font-Size="Small"></asp:Label>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Tentative Interview date 
                            </label>
                            <div class="col-sm-9">
                                :
                                <asp:Label runat="server" ID="lblDate" Font-Bold="true" Font-Size="Small"></asp:Label>
                            </div>

                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Training
                            </label>
                            <div class="col-sm-9">
                                : Nurturing
                               <asp:Label runat="server" ID="Label1" Font-Bold="true" Font-Size="Small"></asp:Label>
                            </div>

                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Location
                            </label>
                            <div class="col-sm-9">
                                :
                                <asp:Label runat="server" ID="lbllocation" Font-Bold="true" Font-Size="Small"></asp:Label>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Interviewer Name
                            </label>
                            <div class="col-sm-9">
                                :
                                <asp:Label runat="server" ID="lblInterviewer" Font-Bold="true" Font-Size="Small"></asp:Label>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Interview Duration
                            </label>
                            <div class="col-sm-9">
                                : 30mins
                               <asp:Label runat="server" ID="Label2" Font-Bold="true" Font-Size="Small"></asp:Label>
                            </div>

                        </div>
                        <div class="form-group">
                            <label class="col-sm-3 control-label">
                                Interview Mode
                            </label>
                            <div class="col-sm-9">
                                : Telephonic
                               <asp:Label runat="server" ID="Label3" Font-Bold="true" Font-Size="Small"></asp:Label>
                            </div>

                        </div>


                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- Row End -->

    <div class="row">

        <div class="col-lg-12 col-md-12">
            <div class="widget">
                <div class="widget-header">
                    <div class="title">
                        HRMock FeedBack Form
                    </div>
                </div>
                <div class="widget-body">


                    <div class="row">
                        &nbsp;
                    </div>
                    <div>
                        <asp:Label ID="PageNumberHeader" runat="server"></asp:Label>
                    </div>
                    <div class="row">
                        <div class="table-responsive">

                            <div id="div1" runat="server" visable="true">


                                <contenttemplate>
                                    <div class="table-responsive">

                                        <asp:GridView ID="gvCustomers" runat="server" AutoGenerateColumns="false" OnRowDataBound="OnRowDataBound" DataKeyNames="ConductHRMcokFeedBackFormId" PageSize="100" HeaderStyle-HorizontalAlign="Center" Width="100%" AllowPaging="true" AllowSorting="true">
                                            <Columns>
                                                <%--  <asp:BoundField HeaderText="S.No" DataField="SNo" ItemStyle-Width="15px"  />--%>
                                                <asp:TemplateField>
                                                    <HeaderTemplate>
                                                        <asp:CheckBox ID="chkAll" runat="server" AutoPostBack="true" OnCheckedChanged="OnCheckedChanged" ItemStyle-Width="50px" />
                                                    </HeaderTemplate>
                                                    <ItemTemplate>
                                                        <asp:CheckBox runat="server" ItemStyle-Width="20px" AutoPostBack="true" OnCheckedChanged="OnCheckedChanged" />
                                                    </ItemTemplate>
                                                    <ItemStyle Width="50px"></ItemStyle>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Question Name" ItemStyle-Width="200">
                                                    <ItemTemplate>
                                                        <asp:Label runat="server" Text='<%# Eval("QuestionName") %>'></asp:Label>
                                                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Eval("QuestionName") %>' Visible="false"></asp:TextBox>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Rating" ItemStyle-Width="50px">
                                                    <ItemTemplate>

                                                        
                                                        <asp:DropDownList ID="ddlRating" runat="server" AutoPostBack="false" OnSelectedIndexChanged="ddlRating_SelectedIndexChanged">





                                                            <asp:ListItem Value="0"></asp:ListItem>
                                                            <asp:ListItem Value="1"></asp:ListItem>
                                                            <asp:ListItem Value="2"></asp:ListItem>
                                                            <asp:ListItem Value="3"></asp:ListItem>
                                                            <asp:ListItem Value="4"></asp:ListItem>
                                                            <asp:ListItem Value="5"></asp:ListItem>
                                                            <asp:ListItem Value="6"></asp:ListItem>
                                                            <asp:ListItem Value="7"></asp:ListItem>
                                                            <asp:ListItem Value="8"></asp:ListItem>
                                                            <asp:ListItem Value="9"></asp:ListItem>
                                                            <asp:ListItem Value="10"></asp:ListItem>



                                                        </asp:DropDownList>
                                                    </ItemTemplate>

                                                    <ItemStyle Width="120px"></ItemStyle>
                                                </asp:TemplateField>




                                            </Columns>
                                        </asp:GridView>
                                    </div>
                                    <br />
                                   
                                    <br />



                                    <div class="row">
                                        &nbsp;
                                     &nbsp;
                                    </div>
                                    <div class="row">
                                        <div class="form-group" id="divMarks" runat="server">
                                            <label class="col-sm-3 control-label">
                                                Score<sup class="sup">*</sup>
                                            </label>
                                            <div class="col-sm-6">
                                                <asp:TextBox ID="txtScore" runat="server" ValidateRequestMode="Enabled" Required=""></asp:TextBox>
                                            </div>
                                        </div>
                                    </div>
                                    <br />
                                    <div class="row">
                                        <div class="form-group">
                                            <label class="col-sm-3 control-label">
                                                Mentor Inputs<sup class="sup">*</sup>
                                            </label>
                                            <div class="col-sm-6">
                                                <asp:TextBox ID="txtMentorInputs" runat="server" required="" TextMode="MultiLine"></asp:TextBox>
                                                <asp:HiddenField runat="server" ID="hdnAttendedOn" />
                                            </div>
                                        </div>
                                    </div>

                                    <br />
                                    <div class="row">
                                        <div class="form-group">
                                            <label class="col-sm-3 control-label">
                                                Update Status <sup class="sup">*</sup>
                                            </label>
                                            <div class="col-sm-6">
                                                <asp:DropDownList ID="ddlIsHRMockApproved" runat="server" required="">
                                                    <asp:ListItem Text="-- Select Pending / Approved --" Value=""></asp:ListItem>
                                                    <asp:ListItem Text="Pending" Value="False"></asp:ListItem>
                                                    <asp:ListItem Text="Approved" Value="True"></asp:ListItem>
                                                </asp:DropDownList>
                                            </div>
                                        </div>

                                    </div>
                                    <br />

                                    <h5>Remarks :
                                        <asp:Label ID="lblRemarks" runat="server" ClientIDMode="Static"></asp:Label>
                                    </h5>

                                    <br />


                                    <div class="row">
                                        <div class="form-group" runat="server">
                                            <div class="col-sm-offset-1 col-sm-3">
                                               <asp:Button ID="btnUpdate" runat="server" Text="Submit" OnClick="Update" Visible="false" />
                                                <asp:Button ID="btnCancel" runat="server" SkinID="delete" CssClass="btn btn-warning btn-md" Text="Back to list" UseSubmitBehavior="false" CausesValidation="false"
                                                    OnClick="btnCancel_Click" />
                                            </div>
                                        </div>
                                    </div>
                                     <div class="row">
                                      &nbsp;
                                         </div>
                                </contenttemplate>
                            </div>
                        </div>
                        <div class="row">
                            &nbsp;
                        </div>
                    </div>
                </div>
            </div>
        </div>


    </div>
</asp:Content>




