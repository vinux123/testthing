<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserRegistration.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User Registration</title>
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
            User Registration</h1>
        <br />
        <div class="form-group row">
            <asp:Label Text="User ID" ID="lbluid" class="col-sm-2 col-form-label" runat="server"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="txtuserid" class="form-control" placeholder="User ID" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="form-group row">
            <asp:Label Text="Username" ID="lblusername" class="col-sm-2 col-form-label"
                runat="server"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="txtusername" class="form-control" placeholder="Enter Username" runat="server"></asp:TextBox>
            </div>
        </div>
        
        <div class="form-group row">
            <asp:Label Text="Password" ID="lblpassword" class="col-sm-2 col-form-label" runat="server"></asp:Label>
            <div class="col-sm-10">
                 <asp:TextBox ID="txtpassword" class="form-control" placeholder="Password" runat="server" TextMode="Password"></asp:TextBox>
             </div>
        </div>

        <%--<div class="form-group row">--%>
        <div class="dropdown">
            <asp:Label Text="Role" ID="lblrole" class="col-sm-2 col-form-label"
                runat="server"></asp:Label>
            <%--<div class="col-sm-10">--%>
            <div class="dropdown">
                <asp:DropDownList ID="txtrole" runat="server">
                <asp:ListItem Text="Admin" Value="Admin"></asp:ListItem>
                <asp:ListItem Text="Staff" Value="Staff"></asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>
        
        <div class="form-group row">
            <div class="offset-sm-2 col-sm-10">
                <asp:Button ID="btnSubmit" class="btn btn-primary" Text="Submit" runat="server" OnClick="btnSubmit_Click" />
            </div>
        </div>
        </form>
    </div>
 </body>
</html>

