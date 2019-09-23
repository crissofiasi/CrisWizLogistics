<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CrisWizLogistics._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <div class="featured">
        <div class="content-wrapper">
            <ul class="tab-menu">
                <li id="tab1" class="tab-selected"><a runat="server" href="~/" onfocus="tab1.style.backgroundColor = '#a4d4e6';">Operatii</a></li>
                <li id="tab2"><a runat="server" href="~/About" onfocus="tab2.style.backgroundColor = '#a4d4e6';">Info</a></li>
                <li id="tab3"><a runat="server" href="~/Contact" onfocus="tab3.style.backgroundColor = '#a4d4e6';">Contact</a></li>
            </ul>
        </div>
    </div>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">                                 
    <ul class="main-menu">
        <li>
            <a href="" class="button" id="button1" onblur="RemoveFocus(button1, button1.children['btnLeft1'], button1.children['btnRight1'], btnText1)" onfocus="SetFocus(button1, button1.children['btnLeft1'], button1.children['btnRight1'], btnText1);return false;" onclick="window.location.href='ProdOrder1';return false;">
                <img src="Images/button_right_off.png" class="button-right" id="btnRight1" />
                <img src="Images/button1_left_off.png" class="button-left" id="btnLeft1" />
                <span id="btnText1">Raportare productie</span>
            </a>            
        </li>
        <li>
            <a href="" class="button" id="button2" onblur="RemoveFocus(button2, button2.children['btnLeft2'], button2.children['btnRight2'], btnText2)" onfocus="SetFocus(button2, button2.children['btnLeft2'], button2.children['btnRight2'], btnText2);return false;" onclick="window.location.href='Receiving1';return false;">  
                <img src="Images/button_right_off.png" class="button-right" id="btnRight2" />
                <img src="Images/button2_left_off.png" class="button-left" id="btnLeft2" />
                <span id="btnText2">Receptie marfa</span>
            </a>            
        </li>
       <!-- 
        <li>
            <a href="" class="button" id="button3" onblur="RemoveFocus(button3, button3.children['btnLeft3'], button3.children['btnRight3'], btnText3)" onfocus="SetFocus(button3, button3.children['btnLeft3'], button3.children['btnRight3'], btnText3);return false;" onclick="return false">
                <img src="Images/button_right_off.png" class="button-right" id="btnRight3" />
                <img src="Images/button3_left_off.png" class="button-left" id="btnLeft3" />
                <span id="btnText3">Transfer intre depozite</span>
            </a>      
        </li>
        <li>
            <a href="" class="button" id="button4" onblur="RemoveFocus(button4, button4.children['btnLeft4'], button4.children['btnRight4'], btnText4)" onfocus="SetFocus(button4, button4.children['btnLeft4'], button4.children['btnRight4'], btnText4);return false;" onclick="return false">
                <img src="Images/button_right_off.png" class="button-right" id="btnRight4" />
                <img src="Images/button4_left_off.png" class="button-left" id="btnLeft4" />
                <span id="btnText4">Inventar</span>
            </a>      
        </li>
        -->
        <li>
            <a href="" class="button" id="button5" onblur="RemoveFocus(button5, button5.children['btnLeft5'], button5.children['btnRight5'], btnText5)" onfocus="SetFocus(button5, button5.children['btnLeft5'], button5.children['btnRight5'], btnText5);return false;" onclick="window.location.href='Delivery1';return false;">
                <img src="Images/button_right_off.png" class="button-right" id="btnRight5" />
                <img src="Images/button5_left_off.png" class="button-left" id="btnLeft5" />
                <span id="btnText5">Preg livrare fasonat </span>
            </a>      
        </li>        
    
            <li>
            <a href="" class="button" id="button7" onblur="RemoveFocus(button5, button5.children['btnLeft5'], button5.children['btnRight5'], btnText5)" onfocus="SetFocus(button5, button5.children['btnLeft5'], button5.children['btnRight5'], btnText5);return false;" onclick="window.location.href='LivBrut1';return false;">
                <img src="Images/button_right_off.png" class="button-right" id="btnRight5_1" />
                <img src="Images/button5_left_off.png" class="button-left" id="btnLeft5_1" />
                <span id="btnText5_1">Preg livrare brut </span>
            </a>      
        </li>        
            
        <li>
            <a href="" class="button" id="button6" onblur="RemoveFocus(button6, button6.children['btnLeft6'], button6.children['btnRight6'], btnText6)" onfocus="SetFocus(button6, button6.children['btnLeft6'], button6.children['btnRight6'], btnText6);return false;" onclick="window.location.href='Consumption';return false;">
                <img src="Images/button_right_off.png" class="button-right" id="btnRight6" />
                <img src="Images/button6_left_off.png" class="button-left" id="btnLeft6" />
                <span id="btnText6">Raportare consumuri</span>
            </a>      
        </li>        
    </ul>
</asp:Content>