   M S B A M L   `   `   `  ����O  KelecTornHub_WPFBased, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:elecTornHub_WPFBased.ExtraselecTornHub_WPFBased.Extras  5      2    ,elecTornHub_WPFBased.Components.ConfirmPopup   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      AlocalExtras)clr-namespace:elecTornHub_WPFBased.Extras     5      ��5      �� *ActualHeight+  �� RelativeSource  ��  �� AncestorType" ���5      �� *ActualWidth+  �� " �.��5
      �� $��Center=�6   $��Center=�5      +   %elecTornHub_WPFBased.Extras.Variables   ColorAbsoluteWhite#��Z 5       �� CornerRadius$ 15��5      $��1q�5      $��0q�5      ��5      �� *ActualHeight+  �� " >���5      �� *ActualWidth+  �� " >� J� Effect 5   
   3  -System.Windows.Media.Effects.DropShadowEffect  5         Color$ Black��6      	Direction$	 270Q�5         ShadowDepth$ 3Q�5         
BlurRadius$ 7Q�5      	   Opacity$		 0.5Q�5      ._�5   
   � $��Stretch=�6   $��Center=�6-   $
��25,0q�6H   .+�5      �� $��Stretch=�6   $��Center=�67   ��5      �� *ActualWidth+  �� " �.+�5!      �� -   5        
 ��Name$
 ConfirmPopup_Title��5#      $��Center=�5!      $��Center=�5"       �� TextAlignment$ Center=�5%         
FontSizeLG#��Z 5&         ColorDarkGray#��Z 5'         SecondaryFontBold#��Z 5(      $
��Bold"�5)      $
��Wrap=�5*      ��5$      �� *Title+  ��  UserControl �� FallbackValue$ Default Title����5+      �� *ActualWidth+  �� " ��� 5.      $
��0,20q�5/      .+�52      �� $
��Left=�6    $��Center=�53      $	��0,5q�54      $ Justify=�55      $
��Wrap=�56      ��57      �� *ActualWidth+  �� " ���� 59         
FontSizeSM#��Z 5;      #��Z 5<         SecondaryFont#��Z 5=      �5:      �� *	Message_0+  ��  UserControl$  ��5=       �� 5?      #��Z 5A      #��Z 5B      #��Z 5C      $
��Bold"�5D      �5@      �� *	Message_1+  ��  UserControl$  ��5D       �� 5F      #��Z 5H      #��Z 5I      #��Z 5J      �5G      �� *	Message_2+  ��  UserControl$  ��5J       �� 5L      #��Z 5N      #��Z 5O      #��Z 5P      $
��Bold"�5Q      �5M      �� *	Message_3+  ��  UserControl$  ��5Q       �� 5S      #��Z 5U      #��Z 5V      #��Z 5W      �5T      �� *	Message_4+  ��  UserControl$  ��5W       �� 5Y      #��Z 5[      #��Z 5\      #��Z 5]      $
��Bold"�5^      �5Z      �� *	Message_5+  ��  UserControl$  ��5^       �� 5`      #��Z 5b      #��Z 5c      #��Z 5d      �5a      �� *	Message_6+  ��  UserControl$  ��5d       �� 5f      #��Z 5h      #��Z 5i      #��Z 5j      $
��Bold"�5k      �5g      �� *	Message_7+  ��  UserControl$  ��5k      5n      �� 5q      -   5         ��Name$! ConfirmPopup_InputContainer��5q   Z   $��Stretch=�6!   $��Center=�6?   .+�5r      �� $��Stretch=�6!   $��Center=�5s   !   $ 8��5t   !   $��2q�5u   !      ColorLightGray#��Z 5v   !   ._�5w      �� -   5         ��Name$ ConfirmPopup_Input��5y   %   $��Stretch=�5w   &   $��Center=�5x   %   #��Z 5z   %   #��Z 5{   %   #��Z 5|   %   $��0q�5}   %   
������ $	��6,5q�5   %   5�      5�      5�      �� 5�      -   5        $) #ConfirmPopup_OnYesNoButtonContainer��5�      $��Stretch=�5�      $��Center=�5�       �� Orientation$ 
Horizontal=�5�      ��5�      �� *ActualWidth+  �� " �.+�5�      �� $��Stretch=�6   $��Center=�5�      $ 10��5�      $��2q�5�      
������ $	��0,6q�5�         ButtonWidth#��Z 5�         ColorAccentOrange#��Z 5�      ._�5�      �� -   5         ��Name$ ConfirmPopup_OnNoButton��5�      $��Stretch=�5�   !   $��Batalkan��5�      $��Center=�5�         NoHoverButtonStyle#��[  5�      #��Z 5�         PrimaryFont#��Z 5�      #��Z 5�      
������ $��0q�5�      
������ $	��0,6q�5�       � Cursor$
 Hand��5�      5�      �� 5�      $��Stretch=�6   $��Center=�5�      $ 10��5�      $��2q�5�      
������ $	��0,6q�5�         
ColorGreen#��Z 5�      #��Z 5�      ._�5�      �� -   5        $ ConfirmPopup_OnYesButton��5�   %   $��Stretch=�5�   %   $��	Lanjutkan��5�   %   $��Center=�5�   %   #��[  5�   %   #��Z 5�   %   #��Z 5�   %   #��Z 5�   %   
������ $��0q�5�   %   
������ $	��0,6q�5�   %   $
 Hand��5�   %   5�      5�      �� 5�      $��Stretch=�6   $��Center=�5�      $ 10��5�      $��2q�5�      
������ $	��0,6q�5�      #��Z 5�      #��Z 5�      ._�5�      �� -   5        $" ConfirmPopup_OnYesOnlyButton��5�   %   $��Stretch=�5�   %   $��	Lanjutkan��5�   %   $��Center=�5�   %   #��[  5�   %   #��Z 5�   %   #��Z 5�   %   #��Z 5�   %   
������ $��0q�5�   %   
������ $	��0,6q�5�   %   $
 Hand��5�   %   5�      5�      5�      5�      5�      