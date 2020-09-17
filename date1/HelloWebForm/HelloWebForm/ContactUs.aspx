<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ContactUs.aspx.cs" Inherits="HelloWebForm.ContactUs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 271px;
            width: 1105px;
        }
        #Select1 {
            width: 196px;
            height: 62px;
            margin-top: 0px;
        }
        #Submit1 {
            height: 29px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width: 627px; height: 25px">
            Contac tUs<div style="width: 847px; height: 222px">
                Category&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="DropDownList1" runat="server" Height="135px" Width="129px">
                </asp:DropDownList>
                <br />
                <br />
                Description&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                <select id="Select1" multiple="multiple" name="D1">
                    <option></option>
                </select><br />
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" Text="Submit" />
            </div>
        </div>
    </form>
</body>
</html>
