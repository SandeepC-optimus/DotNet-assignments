<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Normal.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            color: #FFFFCC;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center; background-color: #3399FF">
    
        <h1 class="style1">
            Hello Kindly upload the document:</h1>
        <br />
        <br />
        <br style="background-color: #66CCFF" />
        <br />
        <br />
        <br />
        <asp:FileUpload ID="FileUpload1" runat="server" style="text-align: center" />
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Upload" />
        <br />
    
    </div>
    </form>
</body>
</html>
