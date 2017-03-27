<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SchoolSetup.aspx.cs" Inherits="SchoolSetup" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>School Setup</title>
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
            School Setup</h1>
        <br />
        <div class="form-group row">
            <asp:Label Text="Organization Name" ID="lblorg" class="col-sm-2 col-form-label" runat="server"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="txtorg" class="form-control" placeholder="Organization Name" runat="server" MaxLength="80"></asp:TextBox>
            </div>
        </div>
        <div class="form-group row">
            <asp:Label Text="School Name" ID="lblschool" class="col-sm-2 col-form-label"
                runat="server"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="txtschool" class="form-control" placeholder="School Name" runat="server" MaxLength="80"></asp:TextBox>
            </div>
        </div>
        
        <div class="form-group row">
            <asp:Label Text="Address Line" ID="lbladdress" class="col-sm-2 col-form-label" runat="server"></asp:Label>
            <div class="col-sm-10">
                 <asp:TextBox ID="txtaddress" class="form-control" placeholder="Address Line" runat="server" MaxLength="80"></asp:TextBox>
             </div>
        </div>

        <div class="form-group row">
            <asp:Label Text="Email & Phone No" ID="lblemail" class="col-sm-2 col-form-label" runat="server"></asp:Label>
            <div class="col-sm-10">
                 <asp:TextBox ID="txtemailphn" class="form-control" placeholder="Email & Phone No" runat="server" MaxLength="80"></asp:TextBox>
             </div>
        </div>
        
        <div class="form-group row">
            <asp:Label Text="Index & Udise No" ID="lblindex" class="col-sm-2 col-form-label" runat="server"></asp:Label>
            <div class="col-sm-10">
                 <asp:TextBox ID="txtIndexUdise" class="form-control" placeholder="Index & Udise Number" runat="server" MaxLength="80"></asp:TextBox>
             </div>
        </div>

        <div class="form-group row">
            <asp:Label Text="Registration No" ID="lblRegistration" class="col-sm-2 col-form-label" runat="server"></asp:Label>
            <div class="col-sm-10">
                 <asp:TextBox ID="txtregistration" class="form-control" placeholder="School Registration" runat="server" MaxLength="80"></asp:TextBox>
             </div>
        </div>

        <div class="form-group row">
            <div class="col-sm-10">
                <asp:FileUpload ID="ImageUpload" runat="server" />
                <asp:Button ID="btnUpload" class="btn btn-primary" Text="Upload" runat="server" OnClick="btnUpload_Click" />
            </div>
        </div>
        

        <div class="form-group row">
            <div class="offset-sm-2 col-sm-10">
                <asp:Button ID="btnEdit" class="btn btn-primary" Text="Edit" runat="server" OnClick="btnEdit_Click" />
            </div>
            <div class="offset-sm-2 col-sm-10">
                <asp:Button ID="btnSubmit" class="btn btn-primary" Text="Submit" runat="server" OnClick="btnSubmit_Click" />
            </div>
        </div>
        </form>
    </div>
 </body>
</html>
