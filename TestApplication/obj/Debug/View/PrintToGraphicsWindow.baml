   M S B A M L   `   `   `  ����  BarcodesAPP)    #NiceLabel.SDK.PrintToGraphicsWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	      SecondaryWindowStyle#��[  5   	     � WindowStartupLocation$  CenterOwner=�5   	   .��5   
   � $��5q�6    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5	      $
��Auto �6    �� 5
      $��* �6    .+�5      ]� $��0��6   .+�5      �� $��Graphics location: ��6   $
��Left=�5      	� 5      $��File system��6   $
��Left=�5       d� 	IsChecked 5      �� *PrintToFiles+5      	� 5      $��	In memory��6   $
��Left=�5      �� 5      $��Generate graphics��6   $��Right=�5      $��Right=�5      ��5      �� *GenerateGraphicsCommand+5      � 5      $��1��6   $	��0 5q�5      {�5      �� *PrintToFiles+ � ColumnDefinitions 5      �� 5      $
��Auto �6'   �� 5       $��* �6'   �� 5!      $
��Auto �6'   .+�5#      �� $��Output folder:��6   $��0��5$      $��0 0 8 0q�5%      �� 5&       �� 
IsReadOnly . $��23��5(      $��1��5)      ��5&      �� *DestinationFolder+5)      �� 5*      $	��...��6   $��30��5+      $��2��5-      ��5,      �� *BrowseForOutputFolderCommand+5-      5.      �� 50      $��2��6    � DataContext 51      �� *PrintToGraphicsResult+.@�52      �� $��
Front side��6   .��53      �� $
��Auto=�6#   $
��Auto=�54      .��55      �� .+�56      �� ��6+   �� *
FrontSides+��57   "   �� 58   &   .R�59   *   �� $��1q�61   
���   �._�5;   .   �� ��64   �� 5<   +   5=   '   5?      5@      5A      5B      �� 5C      $��	Back side��6   .��5D      �� $
��Auto=�6#   $
��Auto=�5E      .��5F      �� .+�5G      �� ��6+   �� *	BackSides+��5H   "   �� 5I   &   .R�5J   *   �� $��1q�61   
���   �._�5L   .   �� ��64   �� 5M   +   5N   '   5P      5Q      5R      5S      5T      5U      5V      