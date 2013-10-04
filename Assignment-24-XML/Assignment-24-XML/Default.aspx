<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="Assignment_24_XML._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        &nbsp;</h2>
    <p>
        <asp:Button ID="Button5" runat="server" onclick="Button5_Click" 
            Text="Add XML" />
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Button ID="Button1" runat="server" Text="Add Node" 
            onclick="Button1_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="First Child" 
            onclick="Button2_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" Text="Insert Before" 
            onclick="Button3_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button4" runat="server" Text="Remove Node" 
            onclick="Button4_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button6" runat="server" Text="Child Node" 
            onclick="Button6_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button7" runat="server" Text="Total Nodes" 
            onclick="Button7_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button8" runat="server" Text="Replace Child" 
            onclick="Button8_Click" />
    </p>
    <p>
        &nbsp;</p>
    <p>
        <strong>First child:&nbsp; </strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p>
        Child Node:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
    <p>
        Total Nodes:&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button9" runat="server" onclick="Button9_Click" 
            Text="Click here to open XML document" />
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="Label1" runat="server" Text=" "></asp:Label>
    </p>
</asp:Content>
