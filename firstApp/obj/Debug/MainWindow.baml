   M S B A M L   `   `   `  ����C  ?firstApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:firstAppfirstApp  5   	       firstApp.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:firstApp     5   	   -   5          � Title$  SHA-256 Encryption��5   	    � 
ResizeMode$ CanResizeWithGrip=�5	       � Icon$ /resources/Unlock.ico��5
      $	��450��5      $	��950��6   $	��450��5      $	��850��6   .��5      � 
������� � ColumnDefinitions 5      �� 5      $	��300 �6   �� 5      $��* �6    � RowDefinitions 5      �� 5      $
��Auto �6   �� 5      $
��120* �6   �� 5      $
��158* �6   �� 5      $
��auto �6   .+�5       � -   5          �Name$ tutorialScreens��5   
   $��1��6#   $��0��5      $��3��6     � NavigationUIVisibility$ Hidden=�6%   5      �� 5#      $��0��6   $��1��5$      $��4��5%      ���	#FF234F6E$��1��5&      �� 5(      $��0��6   $��0��5)      ���	#FF163042$��1��5*      �� 5,      $$��resources/binary_imageview.png��6
   $��1��5-      $��4��5.      $��Bottom=�5/      $	��200��50      $
��None=�51      $��1��6   �� 5=      -   5         ��Name$ TutorialText��5=      $��0��6$   $��2��65   ���	#7F163042$O��ITo view a tutorial of each step of the conversion process click Tutorial.��5?      ���	#BFFFFFFF$��Roboto Light)�5A      $��18(�5B      $��WrapWithOverflow=�5C       �� 
LineHeight$ 30��5D      $��
30 0 30 30q�6   	 �� TextAlignment$	 Center=�5E      $	��Top=�5F      
 �� Padding$
 20q�5G      �� 5J      -   5         ��Name$
 Home��5J      $��0��6   $��1��6)   ���	#00DDDDDD
�������$��24(�5L      $
��Bold"�6    � Cursor$
 Hand��6&   ���	#00707070.��5N      �� $��1��6    �� Orientation$ 
Horizontal=�6$   $��Center=�6=   .+�5O      �� $��/resources/home.png��6   $��20��6)   $��5q�68   $
 Hand��6C   �� 5P      $��SHA 256��6   5Q      5R      �� 5T      -   5        $ MainText��5T      $��0��6    $��1��5U      $f��`To obtain a 64 character hash, enter any string of characters less than 55 characters in length.��5V      ���	#BFFFFFFF$��Roboto Light)�5X      $��18(�5Y      $��WrapWithOverflow=�5Z      $ 30��5[      $	 Center=�6   $	��Top=�5\      $
 30q�5^      5a      5b      