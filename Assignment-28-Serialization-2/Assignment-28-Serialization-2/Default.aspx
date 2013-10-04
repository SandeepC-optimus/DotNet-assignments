<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Assignment_28_Serialization_2._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
    <div>
        <div>
            <div style="margin-left: 1px; margin-top: 0px; height: 325px; text-align: center; background-color: #FF6666;">
                <br />
                <asp:Button ID="BinSer" runat="server" CssClass="style1" onclick="btn1_Click" 
                    Text="Binary Serialization" Width="189px" />
                <br />
                <br />
                <asp:Button ID="BinDeser" runat="server" CssClass="style1" onclick="btn2_Click" 
                    Text="Binary Deserialization" Width="189px" />
                <br />
                <br />
                <asp:Button ID="XMLSer" runat="server" CssClass="style1" onclick="XMLSer_Click" 
                    Text="XML Serialization" Width="189px" />
                <br />
                <br />
                <asp:Button ID="XMLDeser" runat="server" CssClass="style1" 
                    onclick="XMLDeserialization_Click" Text="XML Deserialization" Width="189px" />
                <br />
                <br />
                <asp:Button ID="SoapSer" runat="server" CssClass="style1" 
                    onclick="SoapSerialization_Click" Text="SOAP Serialization" Width="189px" />
                <br />
                <br />
                <asp:Button ID="SoapDeser" runat="server" CssClass="style1" 
                    onclick="SoapDeSerialization_Click" Text="SOAP Deserialization" Width="189px" />
                <br />
            </div>
        </div>
    </div>
    </form>
</body>
</html>
