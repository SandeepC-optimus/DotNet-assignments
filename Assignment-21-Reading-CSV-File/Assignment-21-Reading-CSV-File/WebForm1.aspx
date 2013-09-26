<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Assignment_21_Reading_CSV_File.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 101px; text-align: center; background-color: #FFCC66">
    
        <br />
        <br />
        Hello Welcome to reading csv file upload Program:</div>
    <div style="border: thick outset #C0C0C0; height: 348px; color: #FFFFFF; text-align: center; background-color: #003366">
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:FileUpload ID="FileUpload1" runat="server" BackColor="#3399FF" 
            Height="66px" Width="246px" />
        <asp:Button ID="Button1" runat="server" BackColor="#FFCC66" Height="38px" 
            onclick="Button1_Click" Text="Upload" Width="152px" />
        <br />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Height="33px" onclick="Button2_Click" 
            Text="Save Students to DB" Width="213px" />
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Height="43px" Text="Status" Width="714px"></asp:Label>
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
