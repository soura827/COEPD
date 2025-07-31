<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="ParticipantFeePayment.aspx.cs" Inherits="Admin_ParticipantFeePayment" %>

<%@ Register Src="~/Controls/FormMessage.ascx" TagName="FormMessage" TagPrefix="uc1" %>
<%@ Register Src="~/Controls/ErrorMessage.ascx" TagName="ErrorMessage" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script language="javascript" type="text/javascript">
        function myselection(rbtnid) {
            var rbtn = document.getElementById(rbtnid);
            var rbtnlist = document.getElementsByTagName("input");
            for (i = 0; i < rbtnlist.length; i++) {
                if (rbtnlist[i].text == "radio" && rbtnlist[i].id != rbtn.id) {
                    rbtnlist[i].checked = false;

                }
            }
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
                        <asp:Label ID="lblTitle" runat="server">Participant Fee Payment</asp:Label>
                    </div>
                </div>
                <div class="widget-body">
                    <div class="row">
















                        <div class="col-lg-12 col-md-12">
                            <div class="form-horizontal no-margin">



                                <div class="form-group">
                                    <label class="col-sm-2 control-label">
                                        Lead:
                                    </label>
                                    <div class="col-sm-10 col-lg-2"> 
                                        <asp:TextBox ID="txtSearch" runat="server" AutoPostBack="true" OnTextChanged="txtSearch_TextChanged"></asp:TextBox>
                                    </div>
                                    <label class="col-sm-2 control-label">
                                        Location:
                                    </label>
                                    <div class="col-sm-10 col-lg-2">
                                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                                    </div>
                                    <label class="col-sm-2 control-label">
                                        Agreed Amount:
                                    </label>
                                    <div class="col-sm-10 col-lg-2">
                                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                                    </div>
                                </div>




                                <div class="form-group">
                                    <label class="col-sm-2 control-label">
                                        Select Lead:
                                    </label>
                                    <div class="col-sm-10 col-lg-2">
                                        <asp:DropDownList ID="ddlParticipant" runat="server" OnSelectedIndexChanged="ddlParticipant_SelectedIndexChanged"></asp:DropDownList>
                                    </div>
                                    <label class="col-sm-2 control-label">
                                        Services Taken:
                                    </label>
                                    <div class="col-sm-10 col-lg-2">
                                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                                    </div>
                                    <label class="col-sm-2 control-label">
                                        Previously Paid Amount:
                                    </label>
                                    <div class="col-sm-10 col-lg-2">
                                        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                                    </div>
                                </div>






                                <div class="form-group">
                                    <label class="col-sm-2 control-label">
                                        Mobile Number:
                                    </label>
                                    <div class="col-sm-10 col-lg-2">
                                        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                                    </div>
                                    <label class="col-sm-2 control-label">
                                        Service Owner:
                                    </label>
                                    <div class="col-sm-10 col-lg-2">
                                        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                                    </div>
                                    <label class="col-sm-2 control-label">
                                        Due Amount:
                                    </label>
                                    <div class="col-sm-10 col-lg-2">
                                        <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                                    </div>
                                </div>








                            </div>
                        </div>
























                        <div class="col-lg-12 col-md-12">


                            <div class="form-horizontal no-margin">




                                <div class="form-group">
                                    <div class="col-sm-7 col-lg-7 text-center yellow-bg">
                                        Installments 
                                    </div>


                                    <div class="col-sm-5 col-lg-5 text-center warning-bg ">
                                        Previous Payments
                                    </div>

                                </div>


































                                <div class="form-group">


                                    <%--                                             <label class="col-sm-2  pull-left">
                                                    Type
                                                </label>--%>
                                    <div class="col-sm-2 col-lg-2 text-center">
                                        Installment Date
                                    </div>

                                    <div class="col-sm-2 col-lg-2 text-center">
                                        Installment Amount
                                    </div>
                                    <div class="col-sm-2 col-lg-2 text-center">
                                        Due Amount
                                    </div>
                                    <div class="col-sm-1 col-lg-1 text-center">
                                        Status
                                    </div>

                                    <div class="col-sm-1 col-lg-1 text-center">
                                        Receipt No
                                    </div>

                                    <div class="col-sm-2 col-lg-2 text-center">
                                        Receipt Amount
                                    </div>
                                    <div class="col-sm-2 col-lg-2 text-center">
                                        Receipt date
                                    </div>

                                </div>


                                <div class="form-group">
                                    <div class="col-sm-2 col-lg-2">
                                        <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-sm-2 col-lg-2">
                                        <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-sm-2 col-lg-2">
                                        <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-sm-1 col-lg-1">
                                        <asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-sm-1 col-lg-1">
                                        <asp:TextBox ID="TextBox14" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-sm-2 col-lg-2">
                                        <asp:TextBox ID="TextBox15" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-sm-2 col-lg-2">
                                        <asp:TextBox ID="TextBox16" runat="server"></asp:TextBox>
                                    </div>
                                </div>



                                <div class="form-group">
                                    <div class="col-sm-2 col-lg-2">
                                        <asp:TextBox ID="TextBox17" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-sm-2 col-lg-2">
                                        <asp:TextBox ID="TextBox18" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-sm-2 col-lg-2">
                                        <asp:TextBox ID="TextBox19" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-sm-1 col-lg-1">
                                        <asp:TextBox ID="TextBox20" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-sm-1 col-lg-1">
                                        <asp:TextBox ID="TextBox21" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-sm-2 col-lg-2">
                                        <asp:TextBox ID="TextBox22" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-sm-2 col-lg-2">
                                        <asp:TextBox ID="TextBox23" runat="server"></asp:TextBox>
                                    </div>
                                </div>



                                <div class="form-group">
                                    <div class="col-sm-2 col-lg-2">
                                        <asp:TextBox ID="TextBox24" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-sm-2 col-lg-2">
                                        <asp:TextBox ID="TextBox25" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-sm-2 col-lg-2">
                                        <asp:TextBox ID="TextBox26" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-sm-1 col-lg-1">
                                        <asp:TextBox ID="TextBox27" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-sm-1 col-lg-1">
                                        <asp:TextBox ID="TextBox28" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-sm-2 col-lg-2">
                                        <asp:TextBox ID="TextBox29" runat="server"></asp:TextBox>
                                    </div>
                                    <div class="col-sm-2 col-lg-2">
                                        <asp:TextBox ID="TextBox30" runat="server"></asp:TextBox>
                                    </div>
                                </div>




                            </div>
                        </div>






                        <div class="col-lg-12 col-md-12 ">
                            <div class="form-group">


                                
                                <div class="form-group">
                                    <div class="col-sm-12 col-lg-12 text-center yellow-bg">
                                    .
                                    </div>
                                </div>









                                <div class="col-lg-1 col-md-1">
                                    <div class="form-horizontal no-margin">
                                        <div class="form-group">

                                            <label class="col-sm-1  pull-left">
                                                GST
                                            </label>

                                        </div>
                                    </div>
                                </div>

                                <div class="col-lg-7 col-md-7 ">
                                    <div class="form-horizontal no-margin">
                                        <div class="row">







                                            <div class="form-group">
                                                <label class="col-sm-2  pull-left">
                                                    Type
                                                </label>
                                                <div class="col-sm-5 col-lg-5">
                                                    <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
                                                </div>

                                                <label class="col-sm-2 control-label">
                                                    Address
                                                </label>
                                                <div class="col-sm-3">
                                                    <asp:TextBox ID="txtDescription" runat="server" MaxLength="500" TextMode="MultiLine"></asp:TextBox>
                                                </div>
                                            </div>







                                            <div class="form-group">
                                                <label class="col-sm-2  pull-left">
                                                    Company Name
                                                </label>

                                                <div class="col-sm-5 col-lg-5">
                                                    <asp:TextBox ID="TextBox31" runat="server"></asp:TextBox>
                                                </div>
                                            </div>


                                            <div class="form-group">
                                                <label class="col-sm-2  pull-left">
                                                    GST Number
                                                </label>
                                                <div class="col-sm-5 col-lg-5">
                                                    <asp:TextBox ID="TextBox32" runat="server"></asp:TextBox>
                                                </div>
                                            </div>


                                        </div>

                                    </div>
                                </div>
                            </div>
                        </div>







                        <div class="col-lg-12 col-md-12 ">
                            <div class="form-group">



                                                     <div class="form-group">
                                    <div class="col-sm-12 col-lg-12 text-center yellow-bg ">
                                    .
                                    </div>
                                </div>







                                <div class="col-lg-1 col-md-1">
                                    <div class="form-horizontal no-margin">
                                        <div class="form-group">


                                            <label class="col-sm-1  pull-left">
                                                Payment
                                            </label>



                                        </div>
                                    </div>
                                </div>

                                <div class="col-lg-11 col-md-11 ">
                                    <div class="form-horizontal no-margin">



                                        <div class="form-group">



                                            <label class="col-sm-2  pull-left">
                                                Amount Paying
                                            </label>





                                            <div class="col-sm-2 col-lg-2">
                                                <asp:TextBox ID="TextBox41" runat="server"></asp:TextBox>
                                            </div>

                                            <label class="col-sm-1  pull-left">
                                                Payment date
                                            </label>

                                            <div class="col-sm-2 col-lg-2">
                                                <asp:TextBox ID="TextBox33" runat="server"></asp:TextBox>
                                            </div>






                                            <label class="col-sm-1  pull-left">
                                                Account Name
                                            </label>
                                            <div class="col-sm-3 col-lg-3">
                                                <asp:TextBox ID="TextBox34" runat="server"></asp:TextBox>
                                            </div>
                                        </div>






                                        <div class="form-group">

                                            <label class="col-sm-2  pull-left">
                                                Fee Amount
                                            </label>

                                            <div class="col-sm-2 col-lg-2">
                                                <asp:TextBox ID="TextBox43" runat="server"></asp:TextBox>

                                            </div>





                                            <label class="col-sm-1  pull-left">
                                                Input Company
                                            </label>

                                            <div class="col-sm-2 col-lg-2">
                                                <asp:DropDownList ID="DropDownList3" runat="server"></asp:DropDownList>
                                            </div>








                                            <label class="col-sm-1  pull-left">
                                                Account Number
                                            </label>
                                            <div class="col-sm-3 col-lg-3">
                                                <asp:TextBox ID="TextBox36" runat="server"></asp:TextBox>
                                            </div>
                                        </div>





                                        <div class="form-group">

                                            <label class="col-sm-2  pull-left">
                                                GST
                                            </label>
                                            <div class="col-sm-2 col-lg-2">
                                                <asp:TextBox ID="TextBox35" runat="server"></asp:TextBox>
                                            </div>




                                            <div class="col-sm-1 col-lg-1">
                                                Payment Gateway
                                            </div>
                                            <div class="col-sm-2 col-lg-2">
                                                <asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList>
                                            </div>
                                            <div class="col-sm-1 col-lg-1">
                                                Bank Name
                                            </div>
                                            <div class="col-sm-3 col-lg-3">
                                                <asp:TextBox ID="TextBox38" runat="server"></asp:TextBox>
                                            </div>
                                        </div>








                                        <div class="form-group">
                                            <div class="col-sm-2 col-lg-2">
                                                Pending Amountg
                                            </div>
                                            <div class="col-sm-2 col-lg-2">
                                                <asp:TextBox ID="TextBox42" runat="server"></asp:TextBox>
                                            </div>

                                            <div class="col-sm-1 col-lg-1">
                                                Reference/Cheque No
                                            </div>
                                            <div class="col-sm-2 col-lg-2">
                                                <asp:TextBox ID="TextBox39" runat="server"></asp:TextBox>
                                            </div>
                                            <div class="col-sm-1 col-lg-1">
                                                Bank Branch
                                            </div>
                                            <div class="col-sm-3 col-lg-3">
                                                <asp:TextBox ID="TextBox40" runat="server"></asp:TextBox>
                                            </div>
                                        </div>









                                    </div>
                                </div>
                            </div>
                        </div>


                        <div class="form-group">
                            <div class="col-sm-offset-3 col-sm-9">
                                <asp:Button ID="btnSubmit" runat="server" Text="Restructure Installments" />
                                <asp:Button ID="btnRegister" runat="server" Text="Submit Payment confirmation"
                                    EnableTheming="false" CssClass="btn btn-warning" UseSubmitBehavior="false" />
                            </div>
                        </div>





                    </div>
                </div>
            </div>
        </div>

    </div>









































































    <!-- Row End -->
</asp:Content>

