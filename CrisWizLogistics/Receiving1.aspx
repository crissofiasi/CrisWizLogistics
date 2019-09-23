<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Receiving1.aspx.cs" Inherits="CrisWizLogistics.Receiving1" %>


<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <div class="featured">
        <div class="content-wrapper">
            <ul class="tab-menu">
                <li id="tab1"><a runat="server" href="~/" onfocus="tab1.style.backgroundColor = '#a4d4e6';">Operatii</a></li>
                <li id="tab2" class="tab-selected"><a runat="server" href="~/Receiving1" onfocus="tab2.style.backgroundColor = '#a4d4e6';">Receptie marfa</a></li>                
            </ul>
        </div>
    </div>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">      
    <asp:GridView runat="server" ID="SupplyOrdersView" DataKeyNames="SupplyOrderID" AutoGenerateColumns="false" ShowHeaderWhenEmpty="true" EmptyDataText="Nici o comanda" EmptyDataRowStyle-HorizontalAlign="Center"
        OnSelectedIndexChanged="SupplyOrdersView_SelectedIndexChanged">
        <Columns>
            <asp:ButtonField Text="Select" ButtonType="Button" ControlStyle-CssClass="button tool" CommandName="Select" />
            <asp:BoundField DataField="DocInfo" HeaderText="Nr.CA Data" ItemStyle-Width="0" />
            <asp:BoundField DataField="SupplierName" HeaderText="Furnizor" />
        </Columns>
    </asp:GridView>                                
</asp:Content>