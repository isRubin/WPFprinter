   M S B A M L   `   `   `  ����J  FOshriPrinterWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:OshriPrinterWPFOshriPrinterWPF  5      (    "OshriPrinterWPF.PrinterUserControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:OshriPrinterWPF     5      $��1q�5   8   
���   �.��5	      �   � RowDefinitions  5
   
   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   � $��0��6   .+�5      �� $��images/printer.jpg��6   5      � 5   
   $��1��6   .+�5      �� -   5        $��printerNameLabel��5      $��1��5      $��printer Name��5      $��Center=�5      $��Center=�6-   
����iA�$��16(�6_   6�   5      � 5   
   $��2��6    � ColumnDefinitions 5      �� 5      $
��auto �6#   �� 5      $��* �6#     5       �� 5!      $
��auto �6    �� 5"      $
��auto �6    .+�5%      �� -   5        $��inkLabel��5%   1   $��0��6   $��0��6!   $
��Ink:��6A   
��� ���6P   �� 5&      -   5        $��
pagesLabel��5&   1   $��1��6   $��0��6!   $��Pages:��6C   
���  ��6T   � 5(      -   5        $��inkCountProgressBar��5(   :   $��0��6   $��1��6*    � Value$ 23Q�6U   �� 5)      -   5        $��pageCountSlider��5)   :   $��1��6   $��1��6*   $	 200Q�6U    � Maximum$	 400Q�6a   5+      5,      5-      