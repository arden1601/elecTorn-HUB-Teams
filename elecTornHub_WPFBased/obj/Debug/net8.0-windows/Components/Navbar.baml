   M S B A M L   `   `   `  ����O  KelecTornHub_WPFBased, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:elecTornHub_WPFBased.ExtraselecTornHub_WPFBased.Extras  5      ,    &elecTornHub_WPFBased.Components.Navbar   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      AlocalExtras)clr-namespace:elecTornHub_WPFBased.Extras     5      +   %elecTornHub_WPFBased.Extras.Variables    ScreenWidth#��Z  5      .��5	      � $��Stretch=�6   $	��Top=�6)   $	��7,0q�6A   ��5
      �� *ActualWidth+ �� RelativeSource ��  �� AncestorType" ��.+�5   
   �� $
��Left=�6   $��Center=�60    �� Orientation$ 
Horizontal=�5      ��5      �� *ActualWidth+ �� " ���5      �� *ActualHeight+ �� " �.+�5      �� $��Stretch=�6   $��Center=�5       �� CornerRadius$ 10��5      $��2q�5      
������ $��5, 10q�5         ColorAccentOrange#��Z 5      ._�5      �� -   5         ��Name$ Navbar_Logout��5'      $��Stretch=�5      $��Center=�5      $��Logout��5         NoHoverButtonStyle#��[  5         
FontSizeSM#��Z 5         SecondaryFontBold#��Z 5      	   ColorAbsoluteWhite#��Z	 5       
������ $��0q�5"      
������ $
��15,2q�5$      $��30��5%      
 � Cursor$

 Hand��5&      5'      5)      �� 5,      $ 
Horizontal=�6   $��10q�5-      .+�5/      �� $
��Left=�6   $��Center=�50      $��Search��51      #��Z 52         ColorDarkGray#��Z 53      #��Z 54      �� 55      $��Stretch=�6   $��Center=�56      $ 8��57      $��2q�58      $
��10,0q�59         ColorLightGray#��Z 5:      ._�5;      �� -   5         ��Name$ Navbar_Search��5=   "   $��Stretch=�5;   "   $��Center=�5<   "   #��Z 5>   "      SecondaryFont#��Z 5?   "   #��Z 5@   "   $��0q�5A   "   
������ $	��6,5q�5C   "   $	��460��5D   "   5E      5F      �� 5I      -   5         ��Name$ Navbar_UserNav��5J      $ 
Horizontal=�5I      $
��5, 0q�62   .+�5L      �� -   5         ��Name$ Navbar_UserNavBeliBorder��5T      $��Stretch=�5L      $��Center=�5M      $ 
8, 0, 0, 8��5N      $��0, 10q�5O       �� Padding$
 0, 4q�5P      $��2,2,0,2q�5Q      #��Z	 5R      #��Z 5S      ._�5V      �� -   5        $ Navbar_UserNavBeli��5]      #��[  5V      $
��Beli��5W      $	��100��5X      $

 Hand��5Y      $��0q�5Z      
������ 
������    PrimaryFont#��Z 5^      #��Z 5_      #��Z 5`      5b      �� 5c      -   5        $ Navbar_UserNavJualBorder��5j      $��Stretch=�5c      $��Center=�5d   	   $��0, 10q�5e   	   $
 0, 4q�5f   	   $��2q�5g   	   #��Z	 5h   	   #��Z 5i   	   ._�5l      �� -   5        $ Navbar_UserNavJual��5s      #��[  5l      $
��Jual��5m      $	��100��5n      $

 Hand��5o      $��0q�5p      
������ 
������ #��Z 5t      #��Z 5u      #��Z 5v      5x      �� 5y      -   5        $ Navbar_UserNavPostBorder��5�      $��Stretch=�5y      $��Center=�5z   	   $ 
0, 8, 8, 0��5{   	   $��0, 10q�5|   	   $
 0, 4q�5}   	   $��0,2,2,2q�5~   	   #��Z	 5   	   #��Z 5�   	   ._�5�      �� -	   5        $ Navbar_UserNavPost��5�      #��[  5�      $
��Post��5�      $	��100��5�      $

 Hand��5�      $��0q�5�      
������ 
������ #��Z 5�      #��Z 5�      #��Z 5�      5�      5�      �� 5�      -
   5        $ Navbar_AdminNav��5�      $ 
Horizontal=�5�      $
��5, 0q�62   .+�5�      �� -   5        $ Navbar_AdminNavItemBorder��5�      $��Stretch=�5�      $��Center=�5�   	   $ 
8, 0, 0, 8��5�   	   $��0, 10q�5�   	   $
 0, 4q�5�   	   $��2q�5�   	   #��Z	 5�   	   #��Z 5�   	   ._�5�      �� -   5        $ Navbar_AdminNavItem��5�      #��[  5�      $
��Item��5�      $	��100��5�      $

 Hand��5�      $��0q�5�      
������ 
������ #��Z 5�      #��Z 5�      #��Z 5�      5�      �� 5�      -   5        $ Navbar_AdminNavPostBorder��5�      $��Stretch=�5�      $��Center=�5�   	   $ 
0, 8, 8, 0��5�   	   $��0, 10q�5�   	   $
 0, 4q�5�   	   $��2q�5�   	   #��Z	 5�   	   #��Z 5�   	   ._�5�      �� -   5        $ Navbar_AdminNavPost��5�      #��[  5�      $
��Post��5�      $	��100��5�      $

 Hand��5�      $��0q�5�      
������ 
������ #��Z 5�      #��Z 5�      #��Z 5�      5�      5�      5�      5�      5�      