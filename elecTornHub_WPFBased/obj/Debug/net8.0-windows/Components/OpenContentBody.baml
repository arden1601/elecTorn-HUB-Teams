   M S B A M L   `   `   `  ����O  KelecTornHub_WPFBased, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:elecTornHub_WPFBased.ExtraselecTornHub_WPFBased.Extras  5      Q-clr-namespace:elecTornHub_WPFBased.ComponentselecTornHub_WPFBased.Components  5      5    /elecTornHub_WPFBased.Components.OpenContentBody   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      AlocalExtras)clr-namespace:elecTornHub_WPFBased.Extras     5      IlocalComponents-clr-namespace:elecTornHub_WPFBased.Components     5      +   %elecTornHub_WPFBased.Extras.Variables    OpenContentHeight#��Z  5	         OpenContentWidth#��Z 5
      .��5      �� -   5         ��Name$" OpenContentBody_BorderParent��5   	   $��Center=�5   	      ColorOffWhite#��Z 5   	   $��Center=�5   	    �� CornerRadius$ 15��5   	   $��1q�5   	      ColorDarkGray#��Z 5   	   $
��Auto��5   	   ._�5   
   �� $
��Auto��6   $
��Auto��6#   .+�5      � -   5         �Name$! OpenContentBody_ModeProduct��5      $��Center=�5      $
��Auto��5      $
��Auto��5      $��
0,10,20,10q�5       � ColumnDefinitions 5      �� 5       $��2* �6'   �� 5!      $��3* �6'   .+�5#      �� $��0��6   $��20q�6-   .+�5$      �� -   5         ��Name$ OpenContentBody_Picture��5%      	   MaxImageContent#��Z	 5'      ��5&      �� *ProductCard_ImgSrc+5'      5)      �� 5*      $��1��5+      $��1��6%   $	��320��62   .+�5,      �� -   5        
 ��Name$
 OpenContentBody_Title��5.      $��Stretch=�5-         
FontSizeLG#��Z 50         SecondaryFontBold#��Z 51      #��Z 52      $��DemiBold"�53      $
��Wrap=�54       �� TextAlignment$ Justify=�55      ��5/      �� *ProductCard_Name+55      �� 58      -   5        $% OpenContentBody_EditTitleBorder��5>      $��Stretch=�59      $��Center=�5:      $ 8��5;      $��2q�5<      #��Z 5=      ._�5@      �� -   5         ��Name$ OpenContentBody_EditTitle��5D      $��Stretch=�5A      $��Center=�5C      #��Z 5E      #��Z 5F      #��Z 5G      $��DemiBold"�5H      $��0q�5I      
������ $	��6,5q�5K      ��5B      �� *ProductCard_Name+5K      5N      �� 5P      -   5        $
 OpenContentBody_Seller��5Q         
FontSizeSM#��Z 5S         PrimaryFont#��Z 5T      #��Z 5U      $��DemiBold"�5V      $
��Wrap=�5W      $ Justify=�5X      ��5R      �� * ProductCard_SellerName_Selling+5X      �� 5Z      -   5        $  OpenContentBody_DescBorder��5a      $��Stretch=�5[      $��Center=�5\      $
��0,10q�5]       �� Padding$ 0,0,1,0q�5^      $��0q�5_      #��Z 5`      ._�5c      �� $��Stretch=�5d      $
��Auto=�5e      $��Disabled=�5f      $��0,0,5,0q�5g         ScrollHeight#��Z 5h         ScrollWidth#��Z 5i      .��5k      �� -	   5        $
 OpenContentBody_Desc��5o   !   $��Stretch=�5l   !   $	��Top=�5n   !      
FontSizeMD#��Z 5p   !   #��Z 5q   !   #��Z 5r   !   $��DemiBold"�5s   !   $
��Wrap=�5t   !   $ Justify=�5u   !   
������ ��5m   !   �� *ProductCard_Description+5v   !   5x      5y      �� 5{      -
   5        $$ OpenContentBody_EditDescBorder��5�      $��Stretch=�5|      $��Center=�5}      $
��0,10q�5~      $ 0,0,1,0q�5      $ 8��5�      $��2q�5�      #��Z 5�      ._�5�      �� $��Stretch=�5�      $
��Auto=�5�      $��Disabled=�5�      #��Z 5�      #��Z 5�      $��6,5,6,5q�5�      $��0,0,5,0q�5�      .��5�      �� -   5        $ OpenContentBody_EditDesc��5�   !   $��Stretch=�5�   !   $	��Top=�5�   !   #��Z 5�   !   #��Z 5�   !   #��Z 5�   !   $��DemiBold"�5�   !    �� TextWrapping$
 Wrap=�5�   !    �� TextAlignment$ Justify=�5�   !   $��0q�5�   !   
������ ��5�   !   �� *ProductCard_Description+5�   !   5�      5�      � 5�      $��Bottom=�5�      $
��Auto��5�      $
��Auto��5�       5�      �� 5�      $
��Auto �6/   �� 5�      $��* �6/   .+�5�      �� $��0��6%   .+�5�      �� -   5        $
 OpenContentBody_Price��5�   !   $��0��5�   !   #��Z 5�   !   #��Z 5�   !   #��Z 5�   !   $��DemiBold"�5�   !   $
��Wrap=�5�   !   $ Justify=�5�   !   ��5�   !   �� *ProductCard_Price+5�   !   �� 5�      -   5         ��Name$% OpenContentBody_EditPriceBorder��5�   !    �� Orientation$ 
Horizontal=�5�   !   $��Center=�5�   !   .+�5�   "   �� $��0��5�   %   $��Center=�5�   %   $
��Rp. ��5�   %   #��Z 5�   %   #��Z 5�   %   #��Z 5�   %   $��DemiBold"�5�   %   $
��Wrap=�5�   %   $ Justify=�5�   %   �� 5�   "   $��Stretch=�5�   %   $��Center=�5�   %   $ 8��5�   %   $��2q�5�   %   #��Z 5�   %   ._�5�   &   �� -   5        $ OpenContentBody_EditPrice��5�   )   $��Stretch=�5�   )   $��Center=�5�   )   #��Z 5�   )   #��Z 5�   )   #��Z 5�   )   $��DemiBold"�5�   )   $
 Wrap=�5�   )   $ Justify=�5�   )   $��0q�5�   )   
������ $��2q�5�   )   ��5�   )   �� *ProductCard_PriceOriginal+5�   )   5�   #   �� 5�   "   $��0��5�   %   $��Center=�5�   %   $��,-��5�   %   $��5,0,0,0q�5�   %   #��Z 5�   %   #��Z 5�   %   #��Z 5�   %   $��DemiBold"�5�   %   $
��Wrap=�5�   %   $ Justify=�5�   %   5�      �� 5�      -   5        $
 OpenContentBody_Stock��5�   !   #��Z 5�   !   #��Z 5�   !   #��Z 5�   !   $��DemiBold"�5�   !   $
��Wrap=�5�   !   $ Justify=�5�   !   ��5�   !   �� *ProductCard_QuantityLeft+5�   !   �� 5�      $ 
Horizontal=�5�   !   $��0, 10q�5�   !   $��Center=�5�   !   $
��Auto��5�   !   .+�5�   "   �� -   5        $, &OpenContentBody_CounterButtonContainer��5�   -   $��0, 0, 10, 0q�6]   5�   #   �� 5�   "   -   5        $ OpenContentBody_Button1��5�   %   $ 3��5�   %   
������ $��0, 0, 10, 0q�5   %      
ColorGreen#��Z 5  %   ._�5  &   �� -   5         ��Name$$ OpenContentBody_Button1_Button��5  )   $
��Beli��5  )      NoHoverButtonStyle#��[  5  )   #��Z 5  )   #��Z 5  )      ColorAbsoluteWhite#��Z 5	  )   
������ $��0q�5  )   
������ $
��15,5q�5  )   $��20��5  )    � Cursor$
 Hand��5  )   5  #   �� 5  "   -   5        $ OpenContentBody_Button2��5  %   $ 3��5  %   
������ $��0, 0, 10, 0q�5  %   #��Z 5  %   ._�5  &   �� -   5        $$ OpenContentBody_Button2_Button��5  )   $��Hubungi��5  )   #��[  5  )   #��Z 5  )   #��Z 5  )   #��Z 5  )   
������ $��0q�5!  )   
������ $
��15,5q�5#  )   $��20��5$  )   $
 Hand��5%  )   5'  #   �� 5(  "   -   5        $ OpenContentBody_Button3��5)  %   $ 3��5*  %   
������ $��0, 0, 10, 0q�5,  %      ColorAccentOrange#��Z 5-  %   ._�5/  &   �� -   5        $$ OpenContentBody_Button3_Button��50  )   $��Lapor��51  )   #��[  52  )   #��Z 53  )   #��Z 54  )   #��Z 55  )   
������ $��0q�57  )   
������ $
��15,5q�59  )   $��20��5:  )   $
 Hand��5;  )   5=  #   5>     5?     �� 5@     -   5        $ OpenContentBody_ReportTab��5F     $��1��5A     $
��Auto��5B     $��20,0,0,0q�5C        ScreenHeight#��Z 5D     $ Vertical=�5E     $��Bottom=�5G     .+�5I     �� -   5        $%
 OpenContentBody_ReportTab_Title��5J  !   $��Laporan:��5K  !   #��Z 5L  !   $��Right=�5M  !   #��Z 5N  !   #��Z 5O  !   $
��Bold"�5P  !   $
��Wrap=�5Q  !   $ Justify=�5R  !   �� 5T     $ 3��5U  !   #��Z 5V  !   $��1q�5W  !   #��Z 5X  !   $��Right=�5Y  !   $��Bottom=�5Z  !   ._�5\  "   �� -   5         ��Name$  OpenContentBody_ReportDesc��5a  %   $
��Auto=�5]  %   $��Disabled=�5^  %       ScrollHeightBigger#��Z  5_  %   !   ScreenWidth#��Z! 5`  %   $��Bottom=�5b  %   $��2,4,4,4q�5c  %   .��5e  &   �� -   5        $# OpenContentBody_ReportMessage��5f  )   $��Center=�5g  )   $��Center=�5h  )   $����Barang ini memiliki harga tidak masuk akal karena tampaknya terlalu menguntungkan penjual. Saya iri karena saya tidak bisa seperti ini.��5i  )   $ Justify=�5j  )   #��Z 5k  )   #��Z 5l  )   #��Z 5m  )   #��Z 5n  )   $
 Wrap=�5o  )   $��0q�5p  )   $
��Auto��5q  )   5s  #   5t     5u     5v     5w     5x     �� 5z     -   5        $ OpenContentBody_ModePost��5{     $ Vertical=�5|     $��Center=�5}     $��Center=�5~     #��Z 5     .+�5�     �� $��10q�5�     $��Center=�5�     $��Center=�5�     $��Visible=�5�     $��Disabled=�5�     "   ScrollHeightSmaller#��Z" 5�     .��5�     �� $ Vertical=�6!   .+�5�     � -   5        $ OpenContentBody_PostBody��5�     5�     �� 5�     -   5        $" OpenContentBody_CommentGroup��5�     $ Vertical=�5�     .+�5�     � $
��Auto��5�  !    5�  "   �� 5�  &   $
��Auto �67   �� 5�  &   $��* �67   .+�5�  "   �� $��Center=�5�  %   $��Center=�5�  %   $ 
Horizontal=�5�  %   .+�5�  &   �� $��Komentar��5�  )   $��Stretch=�5�  )   $
��Auto��5�  )   $��Center=�5�  )   #��Z 5�  )   #   SecondaryFont#��Z# 5�  )   #��Z 5�  )   
������ $ �� Padding$
$ 6, 8q�5�  )   $
��Wrap=�5�  )   $ Justify=�5�  )   �� 5�  &   $��Stretch=�5�  )   $��Center=�5�  )   $ 4��5�  )   $��2q�5�  )   $��10, 0q�5�  )   #��Z 5�  )   #��Z 5�  )   %   InputCommentWidth#��Z% 5�  )   & J� Effect& 5�  *   3  -System.Windows.Media.Effects.DropShadowEffect  5�  .   '   Color$' Black��5�  1   (   	Direction$	( 270Q�5�  1   )   ShadowDepth$) 1Q�5�  1   *   
BlurRadius$* 3Q�5�  1   +   Opacity$	+ 0.5Q�5�  1   ._�5�  *   �� -   5        $ OpenContentBody_Comment��5�  -   $��Stretch=�5�  -   $	��Top=�5�  -   #��Z 5�  -   #��Z# 5�  -   #��Z 5�  -   $��0q�5�  -   
������ $
��6, 8q�5�  -   $
 Wrap=�5�  -   $ Justify=�5�  -   5�  '   �� 5�  &   $��Stretch=�5�  )   $��Center=�5�  )   $ 4��5�  )   $
��0, 5q�5�  )   $ 10, 8q�5�  )   $��0q�5�  )   #��Z 5�  )   & 5�  *     5�  .   $' Black��5�  1   $	( 270Q�5�  1   $) 1Q�5�  1   $* 3Q�5�  1   $	+ 0.5Q�5�  1   ._�5�  *   �� -   5        $! OpenContentBody_SendComment��5�  -   #��[  5�  -   $��Kirim��5�  -   $
 Hand��5�  -   $��0q�5�  -   
������ 
������ #��Z 5�  -   #��Z 5�  -   #��Z 5�  -   5�  '   5�  #   5�     �� 5�     -    5        $! OpenContentBody_CommentGrid��5�  !   $ Vertical=�5�  !   5�     5�     5�     5�     5�     5�     5      5     