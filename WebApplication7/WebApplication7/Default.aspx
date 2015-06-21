<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication7.Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <table style="width: 100%; height: 282px;">
        <tr>
            <td>Brand</td>
            <td>    
    <asp:DropDownList ID="Brand" runat="server" AutoPostBack="True" OnSelectedIndexChanged="BrandChanged" >
    </asp:DropDownList>
    
            </td>
        </tr>
        <tr>
            <td>Type</td>
            <td>
    
    <asp:DropDownList ID="Type" runat="server" >
    </asp:DropDownList>

            </td>
        </tr>
        <tr>
            <td>Relyability</td>
            <td>

    <asp:DropDownList ID="Relayability" runat="server" >
    </asp:DropDownList>
    
            </td>
        </tr>
        <tr>
            <td>Costs</td>
            <td>
    
    <asp:DropDownList ID="RunningCosts" runat="server" >
    </asp:DropDownList>
    
            </td>
        </tr>
        <tr>
            <td>Performance</td>
            <td>
    
    <asp:DropDownList ID="Performance" runat="server" >
    </asp:DropDownList>
    
            </td>
        </tr>
        <tr>
            <td>Comfort</td>
            <td>
    
    <asp:DropDownList ID="Comfort" runat="server" >
    </asp:DropDownList>

            </td>
        </tr>
        <tr>
            <td>Garage</td>
            <td>

    <asp:DropDownList ID="Garage" runat="server" >
    </asp:DropDownList>

            </td>
        </tr>
        <tr>
            <td>Year of manufacture</td>
            <td>

     <asp:DropDownList ID="ManufactureYear" runat="server" >
    </asp:DropDownList>

            </td>
        </tr>
        <tr>
            <td>Year of purcase</td>
            <td>

    <asp:DropDownList ID="BoughtYear" runat="server" >
    </asp:DropDownList>

            </td>
        </tr>
        <tr>
            <td>Distance when bought</td>
            <td>

    <asp:DropDownList ID="KmsWhenBought" runat="server" >
    </asp:DropDownList>
    
            </td>
        </tr>
        <tr>
            <td>Driven distance</td>
            <td>
    
    <asp:DropDownList ID="DrivenKms" runat="server" >
    </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
    <asp:Button ID="Button1" runat="server" Text="Submit review" OnClick="Button1_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
