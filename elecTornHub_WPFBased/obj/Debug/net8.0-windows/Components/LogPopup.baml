   M S B A M L   `   `   `  ����O  KelecTornHub_WPFBased, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:elecTornHub_WPFBased.ExtraselecTornHub_WPFBased.Extras  5      .    (elecTornHub_WPFBased.Components.LogPopup   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      AlocalExtras)clr-namespace:elecTornHub_WPFBased.Extras     5      ��5      �� *ActualHeight+  �� RelativeSource  ��  �� AncestorType" ���5      �� *ActualWidth+  �� " �.��5
      �� $��Center=�6   $��Center=�5      +   %elecTornHub_WPFBased.Extras.Variables   ColorAbsoluteWhite#��Z 5       �� CornerRadius$ 15��5      $��1q�5      $��0q�5      ��5      �� *ActualHeight+  �� " >���5      �� *ActualWidth+  �� " >� J� Effect 5   
   3  -System.Windows.Media.Effects.DropShadowEffect  5         Color$ Black��6      	Direction$	 270Q�5         ShadowDepth$ 3Q�5         
BlurRadius$ 7Q�5      	   Opacity$		 0.5Q�5      ._�5   
   � $��Stretch=�6   $��Center=�6-   $
��25,0q�6H   .+�5      �� $��Stretch=�6   $��Center=�67   .+�5       �� $��Center=�6   $��Center=�5!      $��NoWrap=�5"      $	��0,6q�5#      �� 5%      $
�elec��6   
   
FontSizeXL#��Z
 5&         ColorDarkGray#��Z 5'         PrimaryFont#��Z 5(       �� 5)      $
�Torn��6   #��Z
 5*         ColorAccentOrange#��Z 5+      #��Z 5,       �� 5-      $
�Hub ��6   #��Z
 5.      #��Z 5/      #��Z 50       �� 51      -   5         ��Name$ LogPopup_LoginText��52      #��Z
 53      #��Z 54         SecondaryFontBold#��Z 55      56      �� 58      $��Stretch=�6   $��Center=�6;   $	��0,6q�6V   .+�5:      �� $��Stretch=�6!   $��Center=�6?   .+�5;      �� $
��Left=�6$   $��Center=�5<   $   $��Username��5=   $      
FontSizeSM#��Z 5>   $   #��Z 5?   $   #��Z 5@   $   �� 5A      $��Stretch=�6!   $��Center=�5B   !   $ 8��5C   !   $��2q�5D   !      ColorLightGray#��Z 5E   !   ._�5F      �� -   5         ��Name$ LogPopup_UsernameValue��5H   &   $��Stretch=�5F   &   $��Center=�5G   &   #��Z 5I   &      SecondaryFont#��Z 5J   &   #��Z 5K   &   $��0q�5L   &   
������ $	��6,5q�5N   &   64   5O      5P      �� 5S      $��Stretch=�6!   $��Center=�6?   .+�5T      �� $
��Left=�6$   $��Center=�5U   $   $��Password��5V   $   #��Z 5W   $   #��Z 5X   $   #��Z 5Y   $   �� 5Z      $��Stretch=�6!   $��Center=�5[   !   $ 8��5\   !   $��2q�5]   !   #��Z 5^   !   ._�5_      G� -   5         G�Name$ LogPopup_PasswordValue��5a   &   $��Stretch=�5_   *   $��Center=�5`   &   #��Z 5b   &   #��Z 5c   &   #��Z 5d   &   $��0q�5e   &   
������ $	��6,5q�5g   &   5h      5i      5j      �� 5l      $��Stretch=�6   $��Center=�6;   .+�5n      �� $��Stretch=�6   $��Center=�5o      $ 10��5p      $��2q�5q      
������ $	��0,6q�5s      #��Z 5t      ._�5v      �� -   5         ��Name$ LogPopup_LogButtonText��5x      $��Stretch=�5v   !   $��Center=�5w         NoHoverButtonStyle#��[  5y      #��Z 5z      #��Z 5{      #��Z 5|      
������ $��0q�5~      
������ $	��0,6q�5�       � Cursor$
 Hand��5�      5�      �� 5�      -   5        $ LogPopup_RedirectButton��5�      $��Center=�5�      $��Center=�5�      $��0q�5�      
������ 
������ $
 Hand��5�      #��[  5�      .��5�      �� -   5         ��Name$ LogPopup_Redirect��5�      $��Center=�5�   $   $��Center=�5�      #��Z 5�      #��Z 5�      #��Z 5�      ��5�   "   |� }� 5�   &    }� Location$ 	Underline=�65   5�   #   5�      5�      5�      5�      5�      5�      5�      