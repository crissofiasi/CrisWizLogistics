<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DeliveryBrut2.aspx.cs" Inherits="CrisWizLogistics.DeliveryBrut2" %>
<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
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
        <asp:Literal runat="server" ID="FailureText" />
    </p>
    <p class="validation-summary-valid">
        <asp:Literal runat="server" ID="SuccessText" />
    </p>
    <fieldset>        
        <ol>
            <li>                
                <asp:Label runat="server" AssociatedControlID="AECode">Dispozitie de livrare (AE)</asp:Label>
                <asp:TextBox runat="server" CssClass="textbox" ID="AECode" AutoPostBack="True" CausesValidation="True"   />                
                <p><asp:RequiredFieldValidator runat="server" ControlToValidate="AECode" CssClass="field-validation-error" ErrorMessage="Camp obligatoriu." Display="Dynamic" /></p>
            </li>       
           <li>
                 <%--<asp:Label runat="server" AssociatedControlID="CustomerName">Denumire client</asp:Label>--%>
                <asp:TextBox runat="server" CssClass="textbox readonly" ID="CustomerName" ReadOnly="true" Visible="True" />
            </li>
            <li>
                <%--<asp:Label runat="server" AssociatedControlID="DocDate">Data document</asp:Label>--%>
                <asp:TextBox runat="server" CssClass="textbox readonly" ID="DocDate" ReadOnly="true" />
            </li>
      
            <li>
                <asp:Label ID="lotetich" runat="server" AssociatedControlID="Lot" Visible="False" >Lot Material</asp:Label>
                <asp:TextBox runat="server" CssClass="textbox" ID="Lot" ReadOnly="false" Visible="false"  AutoPostBack="true" />
            </li>
           
            <li>
                <%--<asp:TextBox runat="server" CssClass="textbox" ID="serialcode" ReadOnly="false" Visible="true"  />
                <asp:TextBox runat="server" CssClass="textbox" ID="partdescode" ReadOnly="false" Visible="true"  />
                --%>
               <%-- <asp:Label ID="serial" runat="server" AssociatedControlID="cantLot" Visible="false"></asp:Label>--%>
                <asp:Label ID="partdes" runat="server" AssociatedControlID="cantLot" Visible="false"></asp:Label>
                <asp:Label ID="cantetic" runat="server" AssociatedControlID="cantLot" Visible="false">Cantitate</asp:Label>
                <asp:TextBox runat="server" CssClass="textbox" ID="cantLot" ReadOnly="false" Visible="false"  />
                
            </li>
            <li>
                 <asp:Button runat="server" CssClass="button" Text="Salvare" ID="savelot" OnClick="saveclick" Width="110px"  Visible="false"/>
            </li>
             
        </ol>

        </fieldset>


</asp:Content>
