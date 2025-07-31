<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ccavResponseHandler.aspx.cs" Inherits="ccavResponseHandler" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Coepd Participant Payment Response</title>
    <link href="css/bootstrap.css" rel="stylesheet" />
    <link href="css/custom.css" rel="stylesheet" />
</head>
<body>
     <form id="form1" runat="server">
          <div class="row">
            <nav class="navbar navbar-default navbar-static-top">
              <div class="container">
                <center><img src="img/logo.jpeg" height="120px" width="250px" class="logo-img"/></center>
                </div>
            </nav>
              <div class=" header">
                  <div class="col-md-offset-3 col-md-6" style="text-align:center">
                       CC Avenue - Payment Summary
                  </div>
              </div>
        </div>
    <div class="col-xs-12 col-sm-offset-4 col-sm-6 col-md-offset-4 col-md-6 col-lg-offset-4 col-lg-6">
        <table class="table table-bordered" style="width:400px;text-align:center;margin-top:10px;">
            <tbody>
              <tr>
                <td> <asp:Label runat="server" ID="OrderID" Text =""></asp:Label> </td>
                <td><asp:Label runat="server" ID="OrderIDValue" Text =""></asp:Label></td>
              </tr>
               <tr>
                <td><asp:Label runat="server" ID="TransactionId" Text =""></asp:Label></td>
                <td><asp:Label runat="server" ID="TransactionValue" Text =""></asp:Label></td>
              </tr>
                <tr>
                <td><asp:Label runat="server" ID="bank_ref_no" Text =""></asp:Label></td>
                <td><asp:Label runat="server" ID="bank_ref_Value" Text =""></asp:Label></td>
              </tr>
                <tr>
                <td><asp:Label runat="server" ID="OrderStatus" Text =""></asp:Label></td>
                <td><asp:Label runat="server" ID="OrderStatusValue" Text =""></asp:Label></td>
              </tr>
               <%--<tr>
                <td><asp:Label runat="server" ID="Failuremessage" Text =""></asp:Label></td>
                <td><asp:Label runat="server" ID="FailuremessageValue" Text =""></asp:Label></td>
              </tr>
              <tr>
                <td><asp:Label runat="server" ID="Paymentmode" Text =""></asp:Label></td>
                <td><asp:Label runat="server" ID="PaymentmodeValue" Text =""></asp:Label></td>
              </tr>
              <tr>
                <td><asp:Label runat="server" ID="CardName" Text =""></asp:Label></td>
                <td><asp:Label runat="server" ID="CardNameValue" Text =""></asp:Label></td>
              </tr>
              <tr>
                <td><asp:Label runat="server" ID="status_code" Text =""></asp:Label></td>
                <td><asp:Label runat="server" ID="status_codeValue" Text =""></asp:Label></td>
              </tr>
              <tr>
                <td><asp:Label runat="server" ID="status_message" Text =""></asp:Label></td>
                <td><asp:Label runat="server" ID="status_messageValue" Text =""></asp:Label></td>
              </tr>
              <tr>
                <td><asp:Label runat="server" ID="currency" Text =""></asp:Label></td>
                <td><asp:Label runat="server" ID="currencyValue" Text =""></asp:Label></td>
              </tr>
              <tr>
                <td><asp:Label runat="server" ID="amount" Text =""></asp:Label></td>
                <td><asp:Label runat="server" ID="amountValue" Text =""></asp:Label></td>
              </tr>
              <tr>
                <td><asp:Label runat="server" ID="billing_name" Text =""></asp:Label></td>
                <td><asp:Label runat="server" ID="billing_nameValue" Text =""></asp:Label></td>
              </tr>
              <tr>
                <td><asp:Label runat="server" ID="billing_address" Text =""></asp:Label></td>
                <td><asp:Label runat="server" ID="billing_addressValue" Text =""></asp:Label></td>
              </tr>
              <tr>
                <td><asp:Label runat="server" ID="billing_city" Text =""></asp:Label></td>
                <td><asp:Label runat="server" ID="billing_cityValue" Text =""></asp:Label></td>
              </tr>
              <tr>
                <td><asp:Label runat="server" ID="billing_state" Text =""></asp:Label></td>
                <td><asp:Label runat="server" ID="billing_stateValue" Text =""></asp:Label></td>
              </tr>
              <tr>
                <td><asp:Label runat="server" ID="billing_zip" Text =""></asp:Label></td>
                <td><asp:Label runat="server" ID="billing_zipValue" Text =""></asp:Label></td>
              </tr>
              <tr>
                <td><asp:Label runat="server" ID="billing_country" Text =""></asp:Label></td>
                <td><asp:Label runat="server" ID="billing_countryValue" Text =""></asp:Label></td>
              </tr>
              <tr>
                <td><asp:Label runat="server" ID="billing_tel" Text =""></asp:Label></td>
                <td><asp:Label runat="server" ID="billing_telValue" Text =""></asp:Label></td>
              </tr>
              <tr>
                <td><asp:Label runat="server" ID="billing_email" Text =""></asp:Label></td>
                <td><asp:Label runat="server" ID="billing_emailValue" Text =""></asp:Label></td>
              </tr>
              <tr>
                <td><asp:Label runat="server" ID="delivery_name" Text =""></asp:Label></td>
                <td><asp:Label runat="server" ID="delivery_nameValue" Text =""></asp:Label></td>
              </tr>
              <tr>
                <td><asp:Label runat="server" ID="delivery_address" Text =""></asp:Label></td>
                <td><asp:Label runat="server" ID="delivery_addressValue" Text =""></asp:Label></td>
              </tr>
              <tr>
                <td><asp:Label runat="server" ID="delivery_city" Text =""></asp:Label></td>
                <td><asp:Label runat="server" ID="delivery_cityValue" Text =""></asp:Label></td>
              </tr>
               <tr>
                <td><asp:Label runat="server" ID="delivery_state" Text =""></asp:Label></td>
                <td><asp:Label runat="server" ID="delivery_stateValue" Text =""></asp:Label></td>
              </tr>
               <tr>
                <td><asp:Label runat="server" ID="delivery_zip" Text =""></asp:Label></td>
                <td><asp:Label runat="server" ID="delivery_zipValue" Text =""></asp:Label></td>
              </tr>
               <tr>
                <td><asp:Label runat="server" ID="delivery_country" Text =""></asp:Label></td>
                <td><asp:Label runat="server" ID="delivery_countryValue" Text =""></asp:Label></td>
              </tr>
               <tr>
                <td><asp:Label runat="server" ID="delivery_tel" Text =""></asp:Label></td>
                <td><asp:Label runat="server" ID="delivery_telValue" Text =""></asp:Label></td>
              </tr>
               <tr>
                <td><asp:Label runat="server" ID="merchant_param1" Text =""></asp:Label></td>
                <td><asp:Label runat="server" ID="merchant_param1Value" Text =""></asp:Label></td>
              </tr>
              <tr>
                <td><asp:Label runat="server" ID="merchant_param2" Text =""></asp:Label></td>
                <td><asp:Label runat="server" ID="merchant_param2Value" Text =""></asp:Label></td>
              </tr>
               <tr>
                <td><asp:Label runat="server" ID="merchant_param3" Text =""></asp:Label></td>
                <td><asp:Label runat="server" ID="merchant_param3Value" Text =""></asp:Label></td>
              </tr>
               <tr>
                <td><asp:Label runat="server" ID="merchant_param4" Text =""></asp:Label></td>
                <td><asp:Label runat="server" ID="merchant_param4Value" Text =""></asp:Label></td>
              </tr>
               <tr>
                <td><asp:Label runat="server" ID="merchant_param5" Text =""></asp:Label></td>
                <td><asp:Label runat="server" ID="merchant_param5Value" Text =""></asp:Label></td>
              </tr>
               <tr>
                <td><asp:Label runat="server" ID="vault" Text =""></asp:Label></td>
                <td><asp:Label runat="server" ID="vaultValue" Text =""></asp:Label></td>
              </tr>
               <tr>
                <td><asp:Label runat="server" ID="offer_type" Text =""></asp:Label></td>
                <td><asp:Label runat="server" ID="offer_typeValue" Text =""></asp:Label></td>
              </tr>
               <tr>
                <td><asp:Label runat="server" ID="offer_code" Text =""></asp:Label></td>
                <td><asp:Label runat="server" ID="offer_codeValue" Text =""></asp:Label></td>
              </tr>
               <tr>
                <td><asp:Label runat="server" ID="discount_value" Text =""></asp:Label></td>
                <td><asp:Label runat="server" ID="discount_valueValue" Text =""></asp:Label></td>
              </tr>
               <tr>
                <td><asp:Label runat="server" ID="cci_value" Text =""></asp:Label></td>
                <td><asp:Label runat="server" ID="cci_valueValue" Text =""></asp:Label></td>
              </tr>
              <tr>
                <td><asp:Label runat="server" ID="mer_amount" Text =""></asp:Label></td>
                <td><asp:Label runat="server" ID="mer_amountValue" Text =""></asp:Label></td>
              </tr>
               <tr>
                <td><asp:Label runat="server" ID="retry" Text =""></asp:Label></td>
                <td><asp:Label runat="server" ID="retryValue" Text =""></asp:Label></td>
              </tr>
               <tr>
                <td><asp:Label runat="server" ID="response_code" Text =""></asp:Label></td>
                <td><asp:Label runat="server" ID="response_Value" Text =""></asp:Label></td>
              </tr>
               <tr>
                <td><asp:Label runat="server" ID="billing_notes" Text =""></asp:Label></td>
                <td><asp:Label runat="server" ID="billing_notesValue" Text =""></asp:Label></td>
              </tr>
              <tr>
                <td><asp:Label runat="server" ID="trans_date" Text =""></asp:Label></td>
                <td><asp:Label runat="server" ID="trans_dateValue" Text =""></asp:Label></td>
              </tr>
               <tr>
                <td><asp:Label runat="server" ID="bin_country" Text =""></asp:Label></td>
                <td><asp:Label runat="server" ID="bin_countryValue" Text =""></asp:Label></td>
              </tr>--%>
            </tbody>
        </table>
    </div>
      <div class="col-xs-12 col-sm-offset-3 col-sm-6 col-md-offset-3 col-md-6 col-lg-offset-3 col-lg-6">
         <center><a href="http://coepd.com/"><button type="button"  style="background-color:#2F5095;border-color:#2F5095;color:#fff">Return to coepd.com</button></a></center> 
      </div>
    </form>
</body>
</html>