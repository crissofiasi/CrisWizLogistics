<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LivBrut2.aspx.cs" Inherits="CrisWizLogistics.LivBrut2" %>
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

    
    <p class="Literals">
        <asp:Literal ID="AENo" runat="server" ></asp:Literal>
    </p>
    <p class="Literals">    
        <asp:Literal ID="AECust" runat="server"  ></asp:Literal>
    </p>
    <p class="Literals">
        <asp:Literal ID="AEDate" runat="server" ></asp:Literal>
     </p>
    
  <fieldset>
     <ol>
       <li>
                <asp:Label ID="lotetich" runat="server" AssociatedControlID="Lot" Visible="True" >Lot Material</asp:Label>
                <asp:TextBox runat="server" CssClass="textbox" ID="Lot" ReadOnly="false" Visible="true" Width="124px" AutoPostBack="false" />
                <asp:Button ID="CautaLot" runat="server" Text="Cauta" OnClick="CautaLot_Click"/>
       </li>
         <li>
         <asp:Panel ID="AddProdus" runat="server"  Visible="false">
             <p class="Literals">
                <asp:Literal ID="Produs" runat="server" ></asp:Literal>
             </p>
             <asp:Label ID="eticCant" runat="server" AssociatedControlID="CantLot" >Cantitate</asp:Label>
             <asp:TextBox runat="server" CssClass="textbox" ID="CantLot" ReadOnly="false" Visible="true" Width="138px" />
              <asp:Button ID="AddCant" runat="server" Text="Add" OnClick="AddCant_Click" />      
         </asp:Panel>
</li>
         <li>
      <asp:GridView ID="GridAE" runat="server" AutoGenerateColumns="false" ShowHeaderWhenEmpty="true" EmptyDataText="Nici un articol" EmptyDataRowStyle-HorizontalAlign="Center" Visible="true" OnSelectedIndexChanged="GridAE_SelectedIndexChanged" >
          <Columns>
              <asp:BoundField DataField="partdes" HeaderText="Denumire" />
              <asp:BoundField DataField="QUANT" HeaderText="Cant." />
              <asp:ButtonField Text="Select" ButtonType="Button" ControlStyle-CssClass="button tool" CommandName="Select" ControlStyle-Width="45px" />
           </Columns>
      </asp:GridView>
         </li>
       <li>
           <asp:Button ID="Back" runat="server" Text="Intoarcere" OnClick="Back_Click" />
           &nbsp;&nbsp;&nbsp;&nbsp;
           <asp:Button ID="FinalAE" runat="server" Text="Finalizare AE" Width="93px" OnClick="FinalAE_Click"  />
       </li>
    </ol>
      

</fieldset>

</asp:Content>
