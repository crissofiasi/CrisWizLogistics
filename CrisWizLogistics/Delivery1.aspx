<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Delivery1.aspx.cs" Inherits="CrisWizLogistics.Delivery1" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <div class="featured">
        <div class="content-wrapper">
            <ul class="tab-menu">
                <li id="tab1"><a runat="server" href="~/" onfocus="tab1.style.backgroundColor = '#a4d4e6';">Operatii</a></li>
                <li id="tab2" class="tab-selected"><a runat="server" href="~/Delivery1" onfocus="tab2.style.backgroundColor = '#a4d4e6';">Pregatire livrare</a></li>                
            </ul>
        </div>
    </div>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">      
    <p class="validation-summary-errors">
        <asp:Literal runat="server" ID="FailureText" />
    </p>
    <p class="validation-summary-valid">
        <asp:Literal runat="server" ID="SuccessText" />
    </p>
    <fieldset>        
        <ol>
            <li>                
                <asp:Label runat="server" AssociatedControlID="SaleOrderCode">Comanda vanzare</asp:Label>
                <asp:TextBox runat="server" CssClass="textbox" ID="SaleOrderCode" />                
                <p><asp:RequiredFieldValidator runat="server" ControlToValidate="SaleOrderCode" CssClass="field-validation-error" ErrorMessage="Camp obligatoriu." Display="Dynamic" /></p>
            </li>       
            <li>
                <asp:Label runat="server" AssociatedControlID="DocDate">Data document</asp:Label>
                <asp:TextBox runat="server" CssClass="textbox readonly" ID="DocDate" ReadOnly="true" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="CustomerName">Denumire client</asp:Label>
                <asp:TextBox runat="server" CssClass="textbox readonly" ID="CustomerName" ReadOnly="true" />
            </li>
            <li>
                <asp:GridView runat="server" ID="SaleOrderLinesView" DataKeyNames="ItemCode" AutoGenerateColumns="false" ShowHeaderWhenEmpty="true" EmptyDataText="Nici un articol" EmptyDataRowStyle-HorizontalAlign="Center"
                    OnSelectedIndexChanged="SaleOrderLinesView_SelectedIndexChanged">
                    <Columns>
                        <asp:ButtonField Text="Select" ButtonType="Button" ControlStyle-CssClass="button tool" CommandName="Select" />
                        <asp:BoundField DataField="ItemName" HeaderText="Denumire" />
                        <asp:BoundField DataField="Quantity" HeaderText="Cant." />
                        <asp:BoundField DataField="DeliverQuantity" HeaderText="Total" />
                    </Columns>
                </asp:GridView>
            </li>    
        </ol>
        <asp:Button runat="server" CssClass="button" Text="Cautare" OnClick="Find_Click" />
        <asp:Button runat="server" CssClass="button" ID="Finish" Text="Finalizare livrare" Visible="false" OnClick="Finish_Click" />
    </fieldset>                                     
</asp:Content>
