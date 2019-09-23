<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Receiving3.aspx.cs" Inherits="CrisWizLogistics.Receiving3" %>

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
    <asp:GridView runat="server" ID="SupplyOrderLinesView" DataKeyNames="SupplyOrderLineID" AutoGenerateColumns="false" ShowHeaderWhenEmpty="true" EmptyDataText="Nici un articol" EmptyDataRowStyle-HorizontalAlign="Center"
        OnSelectedIndexChanged="SupplyOrderLinesView_SelectedIndexChanged">
        <Columns>
            <asp:ButtonField Text="Select" ButtonType="Button" ControlStyle-CssClass="button tool" CommandName="Select" />
            <asp:BoundField DataField="ItemName" HeaderText="Denumire" />
            <asp:BoundField DataField="Quantity" HeaderText="Cant." />
            <asp:BoundField DataField="MeasureUnit" HeaderText="U.M." />
        </Columns>
    </asp:GridView>
    <asp:Button runat="server" CssClass="button" Text="Intoarcere" OnClick="Prev_Click" />    
</asp:Content>