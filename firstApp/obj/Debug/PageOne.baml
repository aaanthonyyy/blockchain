   M S B A M L   `   `   `  ����C  ?firstApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:firstAppfirstApp  5          firstApp.PageOne   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:firstApp     5        N� Title$  PageOne��5	      .��5      � 
������� � ColumnDefinitions 5      �� 5      $��* �6    � RowDefinitions 5      �� 5      �� 5      $
��Auto �6   .+�5      �� $��Step 1��6   $��Center=�6   $��35(�69   $��Black"�6G   $��30q�5      $	��Top=�6   � 5      ��. $
��Auto=�5       5      �� 5      $��* �6    5!      �� 5"      $	��100 �6   �� 5#      $	��11* �6   �� 5$      $	��14* �6   .+�5'      �� -   5         ��Name$ 	InputData��5'      $��1��6"   $W��QThe first step converts each character to binary,
and a 1 is appended to the end.��5(   	    �� TextAlignment$ Center=�5)   	   ���	#FFE6E6E6���	#FF19384D �� Padding$ 20q�5,   	   $��Center=�5-   	   $	��Top=�5.   	   $��18(�5/   	   � 52      -   5         �Name$ StepOne��52      $��Center=�53      $��Center=�6#   $��0��54      $��2��6   .+�56      �� $
��Auto=�6   $��20q�66   .��57      �� -   5        $ 
Conversion��57      $��0��59   	   $��1��5:   	   
���   �$��20(�5;      $��Center=�5<   	   $��Center=�5=   	   $ Center=�5>   	   $
��Bold"�5?   	   $
��Wrap=�6   ��58   	   �� 5?      5@      5A      5B      � 5D      $��30 30 30 30q�6	   $��1��6    5E      �� 5F      $
��127* �6   �� 5G      $
��auto �6   �� 5H      $	��32* �6   �� 5I      $
��auto �6   �� 5J      $
��127* �6   .+�5M      �� -   5         ��Name$
 Back��5O      $
��Back��5M      $��1��5N      $��Bottom=�5P      $	��128��5Q      $��28(�5R      $��Champagne & Limousines)�6   
������� � Cursor$
 Hand��5T      ���	#FF234F6E���	#FF1F445F5U   4   �� 5X      -   5        $
 Next��5Y      $
��Next��5X      $��3��5Z      $��Center=�5[      $��Bottom=�5\      $	��128��5]      $��28(�5^      $��Champagne & Limousines)�6   &   System.Windows.Media.TextOptions	   TextHintingMode$	 Animated=�5_      
�������$
 Hand��5a      ���	#FF234F6E$��1q�5c      ���	#FF1F445F5d      5f      � 5h      -   5        
 �Name$
 NavBar��5h   	   $��5��6   $	��Top=�6$   ���	#FFB2B2B2 5i      �� 5j      $��* �6   �� 5k      $��* �6   �� 5l      $��* �6   �� 5m      $��* �6   �� 5n      $��* �6   .+�5q      �� $��1��6   ���#1630426    5r      5s      5t      