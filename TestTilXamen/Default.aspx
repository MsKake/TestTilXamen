<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TestTilXamen.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Xamen</title>

</head>
<body onload="setTemperatureColor()">
    
    <form id="form1" runat="server">
        <div>
            <p>Temperatur:</p>
            <asp:Label ID="LabelAirTemp" runat="server" Text="Label"></asp:Label>
        </div>
        <br />

        <div>
            <p>Vindstyrke:</p>
            <asp:Label ID="LabelAirSpeed" runat="server" Text="Label"></asp:Label>
        </div>
        <br />

        <div>
            <p>Vindretning:</p>
            <asp:Label ID="LabelWindDirection" runat="server" Text="Label"></asp:Label>
        </div>
        <br />

        <div>
            <p>Oppgave 14:</p>
            <asp:Label ID="resultatLabel" runat="server" Text="Label"></asp:Label>
        </div>
        <br />



    </form>
</body>
</html>
