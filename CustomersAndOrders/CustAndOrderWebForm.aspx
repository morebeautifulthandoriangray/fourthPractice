<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustAndOrderWebForm.aspx.cs" Inherits="CustomersAndOrders.CustAndOrderWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="Customers" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="Customers_SelectedIndexChanged">
            </asp:GridView>
            <br />
            <asp:GridView ID="Orders" runat="server">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
