<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Delivery2.aspx.cs" Inherits="CrisWizLogistics.Delivery2" %>
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
                <asp:Label runat="server" AssociatedControlID="ItemName">Denumire articol</asp:Label>
                <asp:TextBox runat="server" CssClass="textbox readonly" ID="ItemName" ReadOnly="true" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="DocQty">Cantitate comanda</asp:Label>
                <asp:TextBox runat="server" CssClass="textbox readonly" ID="DocQty" ReadOnly="true" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="DeliverQty">Total de livrat</asp:Label>
                <asp:TextBox runat="server" CssClass="textbox readonly" ID="DeliverQty" ReadOnly="true" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="BatchNo">Lot articol</asp:Label>
                <asp:TextBox runat="server" CssClass="textbox" ID="BatchNo" />
                <p><asp:RequiredFieldValidator runat="server" ControlToValidate="BatchNo" ValidationGroup="Batch" CssClass="field-validation-error" ErrorMessage="Camp obligatoriu." Display="Dynamic" /></p>                
            </li> 
            <li>
                <asp:Button runat="server" CssClass="button tool" ID="Add" Text="Adaugare" ValidationGroup="Batch" OnClick="AddBatch_Click" />
                <asp:Button runat="server" CssClass="button tool" Text="Stergere" OnClick="DelBatch_Click" />
                <asp:GridView runat="server" ID="BatchView" AutoGenerateColumns="false" ShowHeaderWhenEmpty="true" EmptyDataText="Nici un lot" EmptyDataRowStyle-HorizontalAlign="Center">
                    <Columns>
                        <asp:BoundField DataField="BatchNo" HeaderText="Lot" />                        
                    </Columns>
                </asp:GridView>
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="DocBatchQty">Cantitate loturi comanda</asp:Label>
                <asp:TextBox runat="server" CssClass="textbox readonly" ID="DocBatchQty" ReadOnly="true" />
                <p><asp:RequiredFieldValidator runat="server" ControlToValidate="DocBatchQty" ValidationGroup="Weighed" CssClass="field-validation-error" ErrorMessage="Nici un lot adaugat!" Display="Dynamic" /></p>
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="WeighedQty">Cantitate cantarita</asp:Label>
                <asp:TextBox runat="server" CssClass="textbox" ID="WeighedQty" />
                <p><asp:RequiredFieldValidator runat="server" ControlToValidate="WeighedQty" ValidationGroup="Weighed" CssClass="field-validation-error" ErrorMessage="Camp obligatoriu." Display="Dynamic" /></p>
                <p><asp:RegularExpressionValidator runat="server" ControlToValidate="WeighedQty" ValidationGroup="Weighed" CssClass="field-validation-error" ErrorMessage="Campul este numeric!" ValidationExpression="\d*\.?\d+" Display="Dynamic" /></p>
            </li>
        </ol>
        <asp:Button runat="server" CssClass="button" Text="Intoarcere" OnClick="Prev_Click" />
        <asp:Button runat="server" CssClass="button" ID="Save" Text="Salvare" ValidationGroup="Weighed" OnClick="Save_Click" />
    </fieldset>                                     
</asp:Content>
