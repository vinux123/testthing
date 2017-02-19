<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StudentMaster.aspx.cs" Inherits="StudentMaster"
    EnableEventValidation="true" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Student Master List</title>
</head>
<script type="text/javascript">
    $(function ($) {
        
    });
</script>
<body>
    <link href="Assets/css/bootstrap.css" rel="stylesheet" type="text/css" />
    <form id="form1" runat="server">
    <div>
        <h2>
            General Register - Student Data
        </h2>
        <br />
        <div class="form-text">
            <asp:Label Text="Register No" ID="lblRegistration" class="col-sm-2 col-form-label"
                runat="server"></asp:Label>
            <div class="col-sm-2">
                <asp:TextBox ID="txtRegNo" class="form-control text-primary" placeholder="Enter Register No" runat="server"></asp:TextBox>
            </div>
            <asp:Label Text="Name" ID="lblName" class="col-sm-2 col-form-label" runat="server"></asp:Label>
            <div class="col-sm-2">
                <asp:TextBox ID="txtName" class="form-control text-primary" placeholder="Name" runat="server"></asp:TextBox>
            </div>
        </div>
        
        <div class="form-text" style="width:100%">
            <asp:Button ID="btnSearch" class="btn btn-primary" Text="Filter" runat="server" OnClick="btnSearch_Click" />
            <asp:Button ID="btnExport" class="btn btn-primary" Text="Export to Excel" runat="server" OnClick="btnExport_Click" />
        </div>
        <br />
        <div class="form-text" style="width:100%">
            <asp:GridView ID="grid1" runat="server" Width="90%" CellPadding="0" ForeColor="Black"
                AutoGenerateColumns="False" PageSize="200" AllowPaging="True" CellSpacing="1"
                OnSelectedIndexChanged="grid1_SelectedIndexChanged" onrowcommand="grid1_RowCommand" 
                style="width:100%;overflow:auto" HorizontalAlign="Left">
                <PagerStyle BackColor="white" HorizontalAlign="Right" />
           
                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" Font-Size="11px"
                    Font-Names="Verdana,Arial,Helvetica,sans-serif" />
                <Columns>
                    <asp:TemplateField HeaderText="Reg No" HeaderStyle-Width="10%">
                        <ItemTemplate>
                            <%#Eval("stud_regno")%></ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Student First Name" HeaderStyle-Width="10%">
                        <ItemTemplate>
                            <%#Eval("stud_fname")%></ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Student Last Name" HeaderStyle-Width="10%">
                        <ItemTemplate>
                            <%#Eval("stud_lname")%></ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Student Status" HeaderStyle-Width="10%">
                        <ItemTemplate>
                            <%#Eval("stud_status")%></ItemTemplate>
                    </asp:TemplateField>
                    
                    <asp:TemplateField HeaderStyle-Width="70%">
                        <ItemTemplate>
                            <asp:Button ID="AddButton" runat="server" CommandName="Show" CommandArgument='<%# Eval("stud_regno") %>'
                                Text="Show" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <EmptyDataTemplate>
                    <span style="color: #cc0000">No Data Found</span>
                </EmptyDataTemplate>
                <EmptyDataRowStyle HorizontalAlign="Center" CssClass="Warning" />
            </asp:GridView>
        </div>
    </div>
    </form>
</body>
</html>
