   M S B A M L   `   `   `  ����O  KelecTornHub_WPFBased, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:elecTornHub_WPFBased.ExtraselecTornHub_WPFBased.Extras  5      0    *elecTornHub_WPFBased.Components.ChoiceCard   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      AlocalExtras)clr-namespace:elecTornHub_WPFBased.Extras     5      $
��Auto��5      $
��Auto��6   .��5
      �� $��Center=�6   $��Center=�5      +   %elecTornHub_WPFBased.Extras.Variables    ColorAbsoluteWhite#��Z  5       �� CornerRadius$ 15��5      $��1q�5      $��0q�5      ��5      �� *ActualHeight+ �� RelativeSource ��  �� AncestorType" >���5      �� *ActualWidth+ �� " >� J� Effect 5   
   3  -System.Windows.Media.Effects.DropShadowEffect  5         Color$ Black��6      	Direction$	 270Q�5         ShadowDepth$ 3Q�5         
BlurRadius$ 7Q�5      	   Opacity$		 0.5Q�5      ._�5   
   �� .+�5      � -   5        
 �Name$
 Card_ProductMode��5      $��Center=�5      $
��Auto��5      $
��Auto��5       $��10q�5!       � ColumnDefinitions 5#      �� 5$      $��1* �6'   �� 5%      $��3* �6'   .+�5'      � -   5        $
 ProductCard_Image��5'      $��0��62   .+�5)      �� $	��100��5*      $	��100��5+      ��5,      �� *ProductCard_ImgSrc+5.      � 50      $��1��6   $
��10,0q�6'   $��Stretch=�65    � RowDefinitions 51      �� 52      $��2* �6(   �� 53      $��* �6(   .+�55      �� $��0��56      .+�58      �� -   5         ��Name$ ProductCard_Name��59         
FontSizeLG#��Z 5:   7   $
��Wrap=�5;       �� TextAlignment$ Justify=�60      PrimaryFont#��Z 5<         ColorDarkGray#��Z 5=      $
��Bold"�6=   ��5:      �� *ProductCard_Name+5=   =   �� 5>      -   5        $ ProductCard_Price��5?         
FontSizeMD#��Z 5@   8      SecondaryFontBold#��Z 5A      #��Z 5B      $��DemiBold"�6=   $
��Wrap=�5C      $ Justify=�60   ��5@      �� *ProductCard_Price+5C   0   5D      �� 5E      $��1��5F      .+�5H      �� $
��Left=�5I      $��Bottom=�5J      $ 10��5K      
������ $��0, 10q�5M      #��Z 5N      ._�5P      �� -   5         ��Name$ ProductCard_Button��5Q      $
��Left=�5R      $��Center=�5S         NoHoverButtonStyle#��[  5T         
FontSizeSM#��Z 5U      #��Z 5V      #��Z  5W      
������ $��0q�5Y      
������ $
��15,2q�5[      $��20��5\       � Cursor$
 Hand��5]      5_      5`      5a      5b      � 5d      -   5        $
 Card_PostMode��5f      $��Center=�5d      $
��Left=�5e      $
��Auto��5g      $
��Auto��5h      $
 Hand��5j      $��10q�5k       5m      �� 5n      $��9* �6$   �� 5o      $
��191* �6$    5q      �� 5r      $��2* �6'   �� 5s      $��3* �6'   .+�5w      �� $	��200��5y      $	��140��6"   $��0��5z      $��2��6%   ��5x      �� *Post_ImgSrc+5z   %   �� 5~      $��1��5      $��	10,0,10,0q�5�      $��2��6(   .+�5�      �� -   5        $ 	News_Name��5�      #��Z 5�      $
��Wrap=�5�      $ Justify=�60   #��Z 5�      #��Z 5�      $
��Bold"�6=   ��5�      �� *
Post_Title+5�   =   �� 5�      $��0,10,0,0q�5�         SecondaryFont#��Z 5�      #��Z 5�      $��Medium"�6=   $
��Wrap=�5�      $ Justify=�60   ��5�      �� *Post_ContentBrief+5�   0   5�      5�      5�      5�      5�      