<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Consumption.aspx.cs" Inherits="CrisWizLogistics.Consumption" %>


<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <div class="featured">
        <div class="content-wrapper">
            <ul class="tab-menu">
                <li id="tab1"><a runat="server" href="~/" onfocus="tab1.style.backgroundColor = '#a4d4e6';">Operatii</a></li>
                <li id="tab2" class="tab-selected"><a runat="server" href="~/Consumption" onfocus="tab2.style.backgroundColor = '#a4d4e6';">Raportare consumuri</a></li>                
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
                <asp:Label runat="server" AssociatedControlID="ProdOrderCode">Comanda productie</asp:Label>
                <asp:TextBox runat="server" CssClass="textbox" ID="ProdOrderCode" />                
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="Warehouse">Magazie</asp:Label>                
                <asp:DropDownList runat="server" ID="Warehouse" DataValueField="WarehouseID" DataTextField="Name"  />
                <p><asp:RequiredFieldValidator runat="server" ControlToValidate="Warehouse" CssClass="field-validation-error" ErrorMessage="Camp obligatoriu." InitialValue="0" Display="Dynamic" /></p>
            </li>  
            <li>
                <asp:Label runat="server" AssociatedControlID="Remarks">Detalii</asp:Label>
                <asp:TextBox runat="server" CssClass="textbox" ID="Remarks" MaxLength="24" />                
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="InternalBatchNo">Numar lot intern material</asp:Label>
                <asp:TextBox runat="server" CssClass="textbox" ID="InternalBatchNo" />
                <p><asp:RequiredFieldValidator runat="server" ControlToValidate="InternalBatchNo" CssClass="field-validation-error" ErrorMessage="Camp obligatoriu." Display="Dynamic" /></p>
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="MainQty">Consum UM stocare</asp:Label>
                <asp:TextBox runat="server" CssClass="textbox" ID="MainQty" />
                <p><asp:RegularExpressionValidator runat="server" ControlToValidate="MainQty" CssClass="field-validation-error" ErrorMessage="Campul este numeric!" ValidationExpression="\d*\.?\d+" Display="Dynamic" /></p>
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="SecondQty">Consum bucati</asp:Label>
                <asp:TextBox runat="server" CssClass="textbox" ID="SecondQty" />
                <p><asp:RegularExpressionValidator runat="server" ControlToValidate="SecondQty" CssClass="field-validation-error" ErrorMessage="Campul este numeric!" ValidationExpression="\d*\.?\d+" Display="Dynamic" /></p>
            </li>                      
        </ol>
        <asp:Button runat="server" CssClass="button" Text="Salvare" OnClick="Save_Click" Width="150px" />

        <asp:Button runat="server" CssClass="button" Text="Goleste Formularul" ValidationGroup="Order" OnClick="NewOrder_Click" Width="160px"/>     
    </fieldset>                                     
</asp:Content>
