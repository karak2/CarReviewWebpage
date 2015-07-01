<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication7.Default" uiculture="auto" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   
    <h1><% Response.Write(I18N_ReviewForm_Welcome); %></h1>
    <% Response.Write(I18N_DescriptionOfTheDecimalRatingValues); %>
    <table style="width: 100%">
        <tr>
            <td>
                <% Response.Write(I18N_BrandLabel); %>
            </td>
            <td>
                <% Response.Write(I18N_TypeLabel); %>
            </td>
        </tr>
        <tr>
            <td>
                <asp:DropDownList ID="Brand" runat="server" AutoPostBack="True" OnSelectedIndexChanged="BrandChanged" />
                <asp:TextBox ID="CustomBrand" runat="server" Visible="False"></asp:TextBox>
                <br />
                <asp:CheckBox ID="IsCustomBrand" runat="server" OnCheckedChanged="IsCustomBrand_OnCheckedChanged" AutoPostBack="True" />
                <% Response.Write(I18N_OtherLabel); %>
            </td>
            <td>
                <asp:DropDownList ID="Type" runat="server" />
                <asp:TextBox ID="CustomType" runat="server" Visible="False"></asp:TextBox>
                <br />
                <asp:CheckBox ID="IsCustomType" runat="server" OnCheckedChanged="IsCustomType_OnCheckedChanged" AutoPostBack="True" />
                <% Response.Write(I18N_OtherLabel); %>
            </td>
        </tr>
        <tr>
            <td>
                <% Response.Write(I18N_YearOfManufacture); %>
            </td>
            <td>
                <% Response.Write(I18N_YearOfPurchase); %>
            </td>
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
            <td>
                <% Response.Write(I18N_DistanceWhenBought); %>
            </td>
            <td>
                <% Response.Write(I18N_DrivenDistance); %>
            </td>
            
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
            <td>
                <% Response.Write(I18N_Reliability); %>
                (<a href="#" data-toggle="tooltip" title="<% Response.Write(I18N_RelyabilityDefinition); %>">?</a>)
            </td>
            <td>
                <% Response.Write(I18N_Costs); %>
                (<a href="#" data-toggle="tooltip" title="<% Response.Write(I18N_CostsDefinition); %>">?</a>)
            </td>
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
            <td>
                <% Response.Write(I18N_Performance); %>
                (<a href="#" data-toggle="tooltip" title="<% Response.Write(I18N_PerformanceDefinition); %>">?</a>)
            </td>
            <td>
                <% Response.Write(I18N_Comfort); %>
                (<a href="#" data-toggle="tooltip" title="<% Response.Write(I18N_ComfortDefinition); %>">?</a>)
            </td>
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
            <td>
                
                <% Response.Write(I18N_Garage); %>
                (<a href="#" data-toggle="tooltip" title="<% Response.Write(I18N_GarageDefinition); %>">?</a>)
            </td>
            <td>
                <% Response.Write(I18N_SubmitRating); %>
            </td>
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
