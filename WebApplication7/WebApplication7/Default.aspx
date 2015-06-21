<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication7.Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Rate your car, current or former...</h1>
    <table style="width: 100%">
        <tr>
            <td>Brand</td>
            <td>Type</td>
        </tr>
        <tr>
            <td>
                <asp:DropDownList ID="Brand" runat="server" AutoPostBack="True" OnSelectedIndexChanged="BrandChanged"/>
                <asp:TextBox ID="CustomBrand" runat="server" Visible="False"></asp:TextBox>
                <br/>
                <asp:CheckBox ID="IsCustomBrand" runat="server" OnCheckedChanged="IsCustomBrand_OnCheckedChanged" AutoPostBack="True" /> other
            </td>
              <td>
                  <asp:DropDownList ID="Type" runat="server"/>
                 <asp:TextBox ID="CustomType" runat="server" Visible="False"></asp:TextBox>
                 <br/>
                 <asp:CheckBox ID="IsCustomType" runat="server" OnCheckedChanged="IsCustomType_OnCheckedChanged" AutoPostBack="True" /> other
            </td>
        </tr>
        <tr>
            <td>Relyability</td>
            <td>Costs</td>
        </tr>
        <tr>
            <td>

                <asp:DropDownList ID="Relayability" runat="server">
                </asp:DropDownList>
            </td>
            <td>
                <asp:DropDownList ID="RunningCosts" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Performance</td>
            <td>Comfort</td>
        </tr>
        <tr>
            <td>
                <asp:DropDownList ID="Performance" runat="server">
                </asp:DropDownList>
            </td>
            <td>

                <asp:DropDownList ID="Comfort" runat="server">
                </asp:DropDownList>

            </td>
        </tr>
        <tr>
            <td>Garage</td>
            <td>Year of manufacture</td>
        </tr>
        <tr>
            <td>

                <asp:DropDownList ID="Garage" runat="server">
                </asp:DropDownList>

            </td>
            <td>

                <asp:DropDownList ID="ManufactureYear" runat="server">
                </asp:DropDownList>

            </td>
        </tr>
        <tr>
            <td>Year of purcase</td>
            <td>Distance when bought</td>
        </tr>
        <tr>
            <td>

                <asp:DropDownList ID="BoughtYear" runat="server">
                </asp:DropDownList>

            </td>
            <td>

                <asp:DropDownList ID="KmsWhenBought" runat="server">
                </asp:DropDownList>

            </td>
        </tr>
        <tr>
            <td>Driven distance</td>
            <td>Submit review</td>
        </tr>
        <tr>
            <td>

                <asp:DropDownList ID="DrivenKms" runat="server">
                </asp:DropDownList>
            </td>
            <td>
                <asp:ImageButton ID="SubmitButton" runat="server" ImageUrl="~/Content/arrow.png" Height="50px" Width="50px" OnClick="Button1_Click" AlternateText="Submit Review" />        
            </td>
        </tr>
    </table>
</asp:Content>
