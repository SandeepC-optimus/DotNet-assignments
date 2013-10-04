<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Assignment_29_XPATH_and_XSLT._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #TextArea1
        {
            height: 142px;
            width: 347px;
            margin-top: 0px;
        }
    </style>
</head>
<body style="text-align: center; background-color: #FFCC99">
    <p>
        Welcome To the Implementation of XPATH and XSLT:<br />
    </p>
    <p>
        Select the Option Below:</p>
    <p>
        &nbsp;</p>
    <form id="form1" runat="server">
    <p>
        <asp:TextBox ID="TextBox1" runat="server" Height="181px" Width="546px"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <div>
    
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            Text="Load Complete XML" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
            Text="Display Name, Age and Address" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" onclick="Button3_Click" 
            Text="Display XML after appending Childrens" />
    
    </div>
    </form>
</body>
</html>
