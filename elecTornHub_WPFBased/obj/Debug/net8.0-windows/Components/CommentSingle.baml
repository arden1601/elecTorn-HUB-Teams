   M S B A M L   `   `   `  ����O  KelecTornHub_WPFBased, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:elecTornHub_WPFBased.ExtraselecTornHub_WPFBased.Extras  5      3    -elecTornHub_WPFBased.Components.CommentSingle   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      AlocalExtras)clr-namespace:elecTornHub_WPFBased.Extras     5      $
��Auto��5      $
��Auto��6   $��0,10,0,0q�5      .��5      �� $��Center=�6   $��Center=�5      $
��Auto��5      +   %elecTornHub_WPFBased.Extras.Variables    CommentWidth#��Z  5         ColorAbsoluteWhite#��Z 5       �� CornerRadius$ 8��5      $��1q�5      $��0q�5       J� Effect 5   
   3  -System.Windows.Media.Effects.DropShadowEffect  5         Color$ Black��6      	Direction$	 270Q�5         ShadowDepth$ 1Q�5         
BlurRadius$ 3Q�5         Opacity$	 0.5Q�5      ._�5   
   �� .+�5      � $��Center=�5      $
��Auto��5      $
��Auto��5       $��10q�5!      	 � RowDefinitions	 5#      �� 5$      $��* �6$   �� 5%      $��* �6$   .+�5(      � $��0��6   $��Stretch=�6$   $��0,0,0,5q�6B   
 � ColumnDefinitions
 5)      �� 5*      $��* �6+   �� 5+      $��* �6+   .+�5-      �� $��0��5.       �� Orientation$ 
Horizontal=�5/      $��Center=�50      .+�52      �� -   5         ��Name$ Comment_ButtonBorder��53      $
��Left=�54      $��Bottom=�55      $ 4��56      
������    ColorAccentOrange#��Z 58      $��0,0,10,0q�59      ._�5;      �� -   5         ��Name$ Comment_Button��5<   !   $
��Left=�5=      $��Center=�5>      $��Hapus��5?         NoHoverButtonStyle#��[  5@         
FontSizeSM#��Z 5A         SecondaryFontBold#��Z 5B      #��Z 5C      
������ $��0q�5E      
������  � Cursor$
 Hand��5G      $��4q�5H   !   5J      �� 5K      -   5         ��Name$ Comment_Title��5L      $��Center=�5M      $
��Left=�5N         
FontSizeMD#��Z 5O   >   #��Z 5P         ColorDarkGray#��Z 5Q      $��DemiBold"�6=   $
��Wrap=�5R       �� TextAlignment$ Justify=�60   ��5O      �� *Poster.Username+5R   0   5S      �� 5T      $��1��5U      $��Center=�5V      $��Right=�5W      #��Z 5X   3   #��Z 5Y      #��Z 5Z      $��DemiBold"�6=   $
��Wrap=�5[      $ Justify=�60   ��5X      �� *
PostDate+5[   0   5\      �� 5^      $��1��5_      #��Z 5a      $
��Wrap=�5b      $ Justify=�60      PrimaryFont#��Z 5c      #��Z 5d      $
��Bold"�6=   ��5`      �� *	Content+5d   =   5e      5f      5g      5h      