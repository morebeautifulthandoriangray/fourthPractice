<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExampleWebForm.aspx.cs" Inherits="CustomersAndOrders.ExampleWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="EnterValue" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="ClickButton" runat="server" OnClick="ClickButton_Click" Text="Click me!!!" />
            <br />
            <asp:Label ID="Result" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
