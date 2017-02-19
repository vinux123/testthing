<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login"
    EnableEventValidation="true" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Student Master List</title>
</head>
<body>
    <link href="Assets/css/style.css" rel="stylesheet" type="text/css" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/normalize/5.0.0/normalize.min.css">
    <script src="Assets/js/index.js" type="text/javascript"></script>
      <script src="https://cdnjs.cloudflare.com/ajax/libs/prefixfree/1.0.7/prefixfree.min.js"></script>
    
    <form id="form1" runat="server">
    <div class="login">
       <h1>VPEMS - Student Master Login</h1>
        
            <asp:Label Text="User Name" ID="lblUserName"
                runat="server"></asp:Label>
            
                <asp:TextBox ID="txtUserName" placeholder="Enter UserName" runat="server"></asp:TextBox>
            
            <asp:Label Text="Password" ID="lblPassword"  runat="server"></asp:Label>
            
                <asp:TextBox ID="txtPassword" placeholder="Enter Password" runat="server" TextMode="Password"></asp:TextBox>
            
        
        
            <asp:Button ID="btnLogin" Text="Login" runat="server" OnClick="btnLogin_Click" />
        
        <asp:Label ID="lblErrorMessage" runat="server"></asp:Label>
        </div>
        </form>
    
</body>
</html>
