<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StatusChange.aspx.cs" Inherits="StatusChange" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>User Registration</title>
    <script type="text/javascript">
        function validate() {
            var inVal = $("#txtRegNo").val();
            if (inVal.length == 0) {
                alert("Please Enter Reg No");
                $("#txtRegNo").focus();
                return false;
            }
        }

        function validate1() {
            var inVal = $("#txtRegNo").val();
            if (inVal.length == 0) {
                alert("Please Enter Reg No to get Current Status");
                $("#txtRegNo").focus();
                return false;
            }

            var inVal1 = $("#txtcstatus").val();
            var inVal2 = $("#txtnstatus").val();

            if (inVal1.length == 0) {
                alert("Blank Current Status");
                $("#txtcstatus").focus();
                return false;
            }

            if (inVal2.length == 0) {
                alert("New Status Cannot be Blank");
                $("#txtcstatus").focus();
                return false;
            }

            if ($("#txtcstatus").val() = $("#txtnstatus").val()) {
                alert("New Status Should not be Same as Current Status");
                $("#txtnstatus").focus();
                return false;
            }
        }
    </script>
</head>
<link href="Assets/css/bootstrap.css" rel="stylesheet" type="text/css" />
<script src="Assets/js/bootstrap.js" type="text/javascript"></script>
<script src="Assets/js/bootstrap.min.js" type="text/javascript"></script>
<script type="text/javascript" src="Assets/js/jquery-1.11.3.min.js"></script>
<script type="text/javascript" src="Assets/js/bootstrap-datepicker.min.js"></script>
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/css/bootstrap.min.css">
<link href="Assets/css/bootstrap-select.css" rel="stylesheet" type="text/css" />
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/js/bootstrap.min.js"></script>
<script src="Assets/js/bootstrap-select.js" type="text/javascript"></script>
<body>
    <script src="Assets/js/bootstrap.js" type="text/javascript"></script>
    <div class="container">
        <form id="form1" runat="server">
        <h1>
            Status Change</h1>
        <br />
        <div class="form-group row">
            <asp:Label Text="Stuent Reg No" ID="lblRegno" class="col-sm-2 col-form-label" runat="server"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="txtRegNo" class="form-control" placeholder="Registration Number" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="form-group row">
            <asp:Label Text="Current Status" ID="lblCStatus" class="col-sm-2 col-form-label"
                runat="server"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="txtcstatus" class="form-control" placeholder="Current Status" runat="server"></asp:TextBox>
            </div>
        </div>
        
        <div class="form-group row">
            <asp:Label Text="New Status" ID="lblnstatus" class="col-sm-2 col-form-label" runat="server"></asp:Label>
            <div class="col-sm-10">
                 <asp:TextBox ID="txtnstatus" class="form-control" placeholder="New Status" runat="server"></asp:TextBox>
             </div>
        </div>

      
        <div class="form-group row">
            <div class="offset-sm-2 col-sm-10">
                <asp:Button ID="btnSearch" class="btn btn-primary" Text="Search" runat="server" OnClick="btnSearch_Click" OnClientClick ="return validate();" />
                <asp:Button ID="btnSubmit" class="btn btn-primary" Text="Submit" runat="server" OnClick="btnSubmit_Click" OnClientClick ="return validate1();"  />
            </div>
        </div>
        </form>
    </div>
 </body>
</html>
