<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="HelloWebForm.Calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 317px; width: 1054px">
    <form id="form1" runat="server">
        <div>
            Calculator<br />
            <br />
            <br />
            Number 1
            <input id="Text1" type="number"/><br />
            <br />
            Number 2
            <input id="Text2" type="number"/><br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Result" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
