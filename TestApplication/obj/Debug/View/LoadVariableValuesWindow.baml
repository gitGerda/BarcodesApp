   M S B A M L   `   `   `  ����  BarcodesAPP,    &NiceLabel.SDK.LoadVariableValuesWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	      SecondaryWindowStyle#��[  5   	     � WindowStartupLocation$  CenterOwner=�5   	   .��5   
   � $��5q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5	      $��* �6   �� 5
      $
��Auto �6   .+�5   
   � $��0��6   $	��0 5q�5       � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $
��Auto �6#   �� 5      $��* �6#   �� 5      $
��Auto �6#   .+�5      �� $��
Load from:��6   $��0��5      $��0 0 8 0q�5      	� 5      $��Value pairs��6   $��1��5       	� 	GroupName$ LoadTypeGroup��5       d� 	IsChecked 5      �� *IsFromValuePairs+	� 5      $	��XML��6   $��2��5      $ LoadTypeGroup��5      �� 5      $��Update Values��6   $��2��5       $��Right=�5!      ��5"      �� *UpdateVariableValuesCommand+5#      �� 5%   
   $��1��6    �� TextWrapping$
 Wrap=�5&       �� AcceptsReturn . " �� VerticalScrollBarVisibility$
 Auto=�5(      ��5)      �� *VariableValues+�� 5+   
   $��2��6   $��5q�5,      $��Ignore missing variables��5-       5.      �� *IgnoreMissingVariables+50      51      