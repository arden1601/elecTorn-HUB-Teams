   M S B A M L   `   `   `  ����O  KelecTornHub_WPFBased, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:elecTornHub_WPFBased.ExtraselecTornHub_WPFBased.Extras  5      1    +elecTornHub_WPFBased.Components.PostContent   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      AlocalExtras)clr-namespace:elecTornHub_WPFBased.Extras     5      $
��Auto��5      $
��Auto��6   $��0,0,0,10q�5      .��5      �� +   %elecTornHub_WPFBased.Extras.Variables    ColorOffWhite#��Z  6   .+�5   
   � $��Center=�5      $
��Auto��5      $
��Auto��5      $��10q�5       � RowDefinitions 5      �� 5      $��* �6    �� 5      $��* �6    �� 5      $��* �6    .+�5      � $��0��6   $��Stretch=�6    $��0,0,0,5q�6>    � ColumnDefinitions 5      �� 5      $��* �6'   �� 5      $��* �6'   .+�5      �� $��0��5      $��Center=�5      $
��Left=�5        �� Orientation$ 
Horizontal=�5!      .+�5#      �� $��	Penulis: ��5$         
FontSizeMD#��Z 6&      PrimaryFont#��Z 5%         ColorDarkGray#��Z 5&      $��Regular"�6=   $
��Wrap=�5'       �� TextAlignment$ Justify=�60   �� 5(      -   5         ��Name$ PostContent_Poster��5)      #��Z 5*   6   	   SecondaryFontBold#��Z	 5+      #��Z 5,      $
��Bold"�6=   $
��Wrap=�5-      $ Justify=�60   ��5*      �� *Post_AuthorName+5-   0   5.      �� 5/      $��1��50      $ 
Horizontal=�51      $��Center=�52      $��Right=�53      .+�55      �� -   5        $ PostContent_Date��56      $��Center=�57      $
��Left=�58      $��0,0,10,0q�59      #��Z 5:   4   #��Z	 5;      #��Z 5<      $��DemiBold"�6=   $
��Wrap=�5=      $ Justify=�60   ��5:      �� *Post_PostDate+5=   0   �� 5>      -   5        
 ��Name$"
 PostContent_TopButton_Border��5?      $��Bottom=�5@       �� CornerRadius$ 4��5A      
������    ColorAccentOrange#��Z 5C      ._�5E      �� -   5         ��Name$ PostContent_TopButton��5F      $
��Left=�5G      $��Center=�5H      $��Lapor��5I         NoHoverButtonStyle#��[  5J         
FontSizeSM#��Z 5K      #��Z	 5L         ColorAbsoluteWhite#��Z 5M      
������ $��0q�5O      
������  � Cursor$
 Hand��5Q      $��4q�5R   !   5T      �� 5U      -   5        $)
 #PostContent_TopButton_Border_Delete��5V      $��8,0,0,0q�5W      $��Bottom=�5X      $ 4��5Y      
������ #��Z 5[      ._�5]      �� -   5        $" PostContent_TopButton_Delete��5^      $
��Left=�5_      $��Center=�5`      $��Delete��5a      #��[  5b      #��Z 5c      #��Z	 5d      #��Z 5e      
������ $��0q�5g      
������ $
 Hand��5i      $��4q�5j   !   5l      5m      5n      �� 5q      -   5         ��Name$ PostContent_ReportSection��5r      $
��Auto��5s      $��	0,10,0,40q�6   $
��Auto��5t   !   $ Vertical=�5u   !   $��Bottom=�5v   !   $��Stretch=�5w      $��1��5x      .+�5{      �� -   5        $ PostContent_ReportTitle��5|      $
��Auto��5}      $��0��5~      $��Laporan:��5      #��Z 6%   $
��Left=�5�      #��Z	 5�      #��Z 5�      $
��Bold"�6A   $
��Wrap=�5�      $ Justify=�60   � 5�      $
��Auto��6   $��Stretch=�6%   $��Right=�6A      ScreenWidth#��Z 5�       5�      �� 5�      $
��Auto �6+   �� 5�      $��* �6+   .+�5�      �� $��0��5�      $��Center=�5�      $ 3��5�      #��Z 5�      $��1q�5�   -   #��Z 5�   -   $
��Left=�5�      ._�5�      �� $
��Auto=�6'   $��Disabled=�6J   $��40��5�      $
��Auto��5�      $	��Top=�5�   +   $
��Left=�5�   #   $��6q�5�   +   .��5�      �� -	   5        $ PostContent_ReportText��5�   !   $����Posting ini mengandung ujaran kebencian, sehingga perlu di-takedown. Posting ini mengandung ujaran kebencian, sehingga perlu di-takedown. Posting ini mengandung ujaran kebencian, sehingga perlu di-takedown.��5�      $ Justify=�5�      #��Z 5�      #��Z	 5�      #��Z 5�      #��Z 5�      $
��Wrap=�5�      $
��Auto��5�         ScrollHeight#��Z 5�   !   5�      5�      �� 5�      -
   5        $ PostContent_ReportButtons��5�   !   $ 
Horizontal=�6D   $��1��6]   $��Right=�6m   $	��Top=�6�   .+�5�      �� $ 3��5�      
������ $��0, 0, 10, 0q�5�      $��30��5�      #��Z 5�      ._�5�      �� -   5        $$ PostContent_RejectReportButton��5�      $��Tolak Laporan��5�      #��[  5�      #��Z 5�      #��Z	 5�      #��Z 5�      
������ $��0q�5�      
������ $
��15,5q�5�      $
 Hand��5�      5�      �� 5�      $ 3��5�      
������ $��0, 0, 10, 0q�5�      #��Z 5�      $��30��5�      ._�5�      �� -   5        $  PostContent_TakedownButton��5�      $��Takedown��5�      #��[  5�      #��Z 5�      #��Z	 5�      #��Z 5�      
������ $��0q�5�      
������ $
��15,5q�5�      $
 Hand��5�      5�      �� 5�      $ 3��5�      
������ $��
0, 0, 0, 0q�5�      #��Z 5�      $��30��5�      ._�5�      �� -   5        $ PostContent_BanButton��5�      $��Ban User��5�      #��[  5�      #��Z 5�      #��Z	 5�      #��Z 5�      
������ $��0q�5�      
������ $
��15,5q�5�      $
 Hand��5�      5�      5�      5�      5�      �� 5�      $��2��5�      .+�5�      �� .+�5�      �� $��Center=�6!   .+�5�      �� -   5        $ PostContent_Title��5�      $��Center=�5�      #��Z 5�      $
��Wrap=�5�      $ Justify=�60   #��Z	 5�      #��Z 5�      $
��Bold"�6=   ��5�      �� *
Post_Title+5�   =   �� 5�      $��Center=�5�   	   $��Center=�5   !   $ 8��5  	   $��2q�5  	   #��Z 5  	   ._�5     �� -   5         ��Name$ PostContent_EditTitle��5  !   $��Center=�5     $��Center=�5	  &   #��Z 5      �� TextWrapping$
 Wrap=�5      �� TextAlignment$ Justify=�60   #��Z	 5     #��Z 5     $
��Bold"�6=   $��0q�5     
������ $	��6,5q�5     ��5
  6   �� *
Post_Title+5     5     �� 5     -   5        $ PostContent_LogEdit��5  %   $ 
Horizontal=�6B   $��Center=�6[   .+�5     �� $��Center=�5  !   $��terakhir disunting: ��5     #��Z 5     $
��Wrap=�5     $ Justify=�60   #��Z 5     #��Z 5     $
��Bold"�6=   �� 5     -   5        $ PostContent_LastEdit��5  !   $��Center=�5  !   #��Z 5      $
��Wrap=�5!     $ Justify=�60   #��Z 5"     #��Z 5#     $
��Bold"�6=   ��5     �� *Post_LastEdit+5#  =   5$     �� 5%     -   5         ��Name$ PostContent_Image��5&        MaxImageHeight#��Z 5(        MaxImageWidth#��Z 5)     $
��Auto��5*     $
��Auto��5+     $
��0,10q�5,     ��5'     �� *Post_ImgSrc+5,     5-     �� 5.     -   5        $ PostContent_Description��5/     $��0,20,0,0q�50     #��Z 52     $
��Wrap=�53     $ Justify=�60   #��Z 54     #��Z 55     $
��Bold"�6=   ��51     �� *Post_Content+55  =   �� 56     $��Center=�57  	   $��Center=�58  !   $ 8��59  	   $��2q�5:  	   #��Z 5;  	   ._�5>     �� -   5        $! PostContent_EditDescription��5?  !   $��Center=�5@     $��Center=�5A  &   #��Z 5C     $
 Wrap=�5D     $ Justify=�60   #��Z 5E     #��Z 5F     $
��Bold"�6=   $��0q�5G     
������ $	��6,5q�5I     ��5B  J   �� *Post_Content+5I     5J     5K     5L     5M     5N     5O     