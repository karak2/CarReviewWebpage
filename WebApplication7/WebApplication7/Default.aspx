<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication7.Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Rate your car, current or former...</h1>
    Selectable numbers between 1-10: The higher the better.
    <table style="width: 100%">
        <tr>
            <td>Brand</td>
            <td>Type</td>
        </tr>
        <tr>
            <td>
                <asp:DropDownList ID="Brand" runat="server" AutoPostBack="True" OnSelectedIndexChanged="BrandChanged" />
                <asp:TextBox ID="CustomBrand" runat="server" Visible="False"></asp:TextBox>
                <br />
                <asp:CheckBox ID="IsCustomBrand" runat="server" OnCheckedChanged="IsCustomBrand_OnCheckedChanged" AutoPostBack="True" />
                other
            </td>
            <td>
                <asp:DropDownList ID="Type" runat="server" />
                <asp:TextBox ID="CustomType" runat="server" Visible="False"></asp:TextBox>
                <br />
                <asp:CheckBox ID="IsCustomType" runat="server" OnCheckedChanged="IsCustomType_OnCheckedChanged" AutoPostBack="True" />
                other
            </td>
        </tr>
        <tr>
            <td>Year of manufacture</td>
            <td>Year of purcase</td>
        </tr>
        <tr>
            <td>
                <asp:DropDownList ID="ManufactureYear" runat="server">
                </asp:DropDownList>
            </td>
            <td>
                <asp:DropDownList ID="BoughtYear" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Distance when bought</td>
            <td>Driven distance</td>
        </tr>
        <tr>
            <td>

                <asp:DropDownList ID="KmsWhenBought" runat="server">
                </asp:DropDownList>

            </td>
            <td>

                <asp:DropDownList ID="DrivenKms" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Relyability (<a href="#" data-toggle="tooltip" title="Represent the ability of the wheicle to function under regular conditions">?</a>)</td>
            <td>Costs (<a href="#" data-toggle="tooltip" title="Operating costs are the expenses which are related to the operation of the vehicle. It is the regular, usual and customary recurring costs. This does not include the capital cost of constructing or purchasing the vehicle.">?</a>)</td>
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
            <td>Performance (<a href="#" data-toggle="tooltip" title="Speed, acceleration, breaks, ...">?</a>)</td>
            <td>Comfort (<a href="#" data-toggle="tooltip" title="Seats, extras, ...">?</a>)</td>
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
            <td>Garage (<a href="#" data-toggle="tooltip" title="Quality, speed, relyability of the garage's service">?</a>)</td>
            <td>Submit rating</td>
        </tr>
        <tr>
            <td>

                <asp:DropDownList ID="Garage" runat="server">
                </asp:DropDownList>

            </td>
            <td>
                <asp:ImageButton ID="SubmitButton" runat="server" ImageUrl="~/Content/arrow.png" Height="50px" Width="50px" OnClick="Button1_Click" AlternateText="Submit Review" />
            </td>
        </tr>
    </table>

    <script>
        $(document).ready(function () {
            $('[data-toggle="tooltip"]').tooltip();
        });
    </script>

</asp:Content>
