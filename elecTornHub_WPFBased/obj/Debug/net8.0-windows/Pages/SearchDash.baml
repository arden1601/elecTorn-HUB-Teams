   M S B A M L   `   `   `  ����O  KelecTornHub_WPFBased, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:elecTornHub_WPFBased.ExtraselecTornHub_WPFBased.Extras  5   	   Q-clr-namespace:elecTornHub_WPFBased.ComponentselecTornHub_WPFBased.Components  5   	   +    %elecTornHub_WPFBased.Pages.SearchDash   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   AlocalExtras)clr-namespace:elecTornHub_WPFBased.Extras     5   	   IlocalComponents-clr-namespace:elecTornHub_WPFBased.Components     5   	     � Title$  	Buy Stuff��5	   	   +   %elecTornHub_WPFBased.Extras.Variables   ScreenHeight#��Z 5
   	      ScreenWidth#��Z 5   	    � WindowStartupLocation$ CenterScreen=�5   	    � 
ResizeMode$ NoResize=�5   	    � WindowStyle$ SingleBorderWindow=�5   	    � Icon$ ../Resources/logo.ico��5   	    � 	Resources 5         NoHoverButtonStyle �� 
TargetType	 �� Property
 �� Value �� 
TargetType��%u  &	        �� 5   
   " ��6+   .�5      �� 	 � ��#
 Z�6+   �� 5      	 � ��#
 Z�6,   �� 5      	 � ��

 �   �6+   �� 5      	 � ��
 5      �� 5      " ��6&   .R�5      �� #��z��6!   #��z��5   !   $��1q�5   !   ._�5      �� $��Center=�6/   $��Center=�5   /   #��z��5   /   5      5       5"      5#      5$      .��5&      �    ColorOffWhite#��Z 6   .+�5(   
   �� $��Center=�6   $��Center=�5)         ContentHeight#��Z 5*         ContentWidth#��Z 5+         ColorAbsoluteWhite#��Z 5,       �� CornerRadius$ 15��5-      $��1q�5.      $��0q�5/       J� Effect 51      3  -System.Windows.Media.Effects.DropShadowEffect  52         Color$ Black��6#      	Direction$	 270Q�53   #      ShadowDepth$ 3Q�54   #      
BlurRadius$ 7Q�55   #      Opacity$	 0.5Q�56   #   ._�59      �  � RowDefinitions 5:      �� 5;      $
��Auto �6$   �� 5=      $��* �6$   �� 5?      $
��Auto �6$   .+�5D      � -   5         �Name$ NavbarControl��5D      $��0��5E   .   $��50��5F   .   �� 5J      $��20,10,20,20q�6   $
��Auto=�5K      $��Disabled=�5L      $��1��5M      .��5N      0   *elecTornHub_WPFBased.Components.CustomGrid  -   5          Name$ 	CardGrids��5N   1   5P      5Q      �� 5T      -   5         ��Name$ SearchDash_AddButton��5T      $��2��5U      $��Right=�5V      $��Bottom=�5W      $��	0,0,20,20q�5X      $��40��5Y      $��40��5Z      $ 25��5[         ColorDarkGray#��Z 5\      ._�5]      �� -   5         ��Name$! SearchDash_AddButton_Button��5]      #��[  5^      $��0q�5_      
������ 
������  � Cursor$
 Hand��5b      .��5c      �� $��Center=�6$   $��Center=�5d   $      
FontSizeXL#��Z 5e   $   #��Z 5f   $   $
��Bold"�5g   $    �� Padding$ 0,0,0,6q�5h   $   +69   5i      5j      5l      5m      5n      5o      