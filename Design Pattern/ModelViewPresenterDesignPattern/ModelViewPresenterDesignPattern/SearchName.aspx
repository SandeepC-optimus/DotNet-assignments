<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchName.aspx.cs" Inherits="ModelViewPresenterDesignPattern._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1
        {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <asp:Panel ID="Panel1" runat="server" Height="202px" 
            style="background-color: #FF9999">
            <div>
                <br />
            </div>
            <asp:Label ID="lblName" runat="server" Text="Name"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <br style="background-color: #FFFFCC" />
            <asp:Button ID="btnSearch" runat="server" onclick="btnSearch_Click" 
        Text="Search" />
            <br />
        </asp:Panel>
        <br />
        <br />
    
    </div>
    <br />
    &nbsp;<asp:GridView ID="GridView1" runat="server" Width="1211px">
    </asp:GridView>
    </form>
</body>
</html>
