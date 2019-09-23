<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LivBrut3.aspx.cs" Inherits="CrisWizLogistics.LivBrut3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="FeaturedContent" runat="server">
    <div class="featured">
        <div class="content-wrapper">
            <ul class="tab-menu">
                <li id="tab1"><a runat="server" href="~/" onfocus="tab1.style.backgroundColor = '#a4d4e6';">Operatii</a></li>
                <li id="tab2" class="tab-selected"><a runat="server" href="~/Delivery1" onfocus="tab2.style.backgroundColor = '#a4d4e6';">Pregatire livrare brut</a></li>                
            </ul>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
    <p class="validation-summary-errors">
        <asp:Literal runat="server" ID="FailureText"  />
    </p>
    <p class="validation-summary-valid">
        <asp:Literal runat="server" ID="SuccessText" />
    </p>

    <asp:Literal ID="Literal1" runat="server"></asp:Literal>
    <asp:Literal ID="Literal2" runat="server"></asp:Literal>
    <asp:Literal ID="Literal3" runat="server"></asp:Literal>
    <asp:Literal ID="Literal4" runat="server"></asp:Literal>
    <asp:GridView ID="GridProd" runat="server" AutoGenerateColumns="false" ShowHeaderWhenEmpty="true" EmptyDataText="Nici un articol" EmptyDataRowStyle-HorizontalAlign="Center" Visible="true" OnSelectedIndexChanged="GridProd_SelectedIndexChanged" >
          <Columns>
              <asp:BoundField DataField="ln" HeaderText=" " />
              <asp:BoundField DataField="SerialName" HeaderText="Lot" />
              <asp:BoundField DataField="PartDes" HeaderText="Articol" />
              <asp:BoundField DataField="QUANT" HeaderText="Cant." />
              <asp:ButtonField Text="Sterge" ButtonType="Button" ControlStyle-CssClass="button tool" CommandName="Select" ControlStyle-Width="60px" />
           </Columns>
      </asp:GridView>
    <p>
        <asp:Button ID="intoarcere" runat="server" Text="Intoarcere" OnClick="intoarcere_Click" Width="364px" />
    </p>



</asp:Content>