   M S B A M L   `   `   `  ����K  GSlotsMachine.wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:SlotsMachine.wpfSlotsMachine.wpf  5   	   !    SlotsMachine.wpf.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:SlotsMachine.wpf     5   	   -   5          � Title$  
MainWindow��5   	   $	��450��6   $	��471��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��203* �6   6,   �� 5      $
��206* �6   6,   �� 5      $	��25* �6   6+   .+�5   
   �� $��2��6   $��0,17,0,0q�6!   � 5   
   $��30,10,29,66q�6   .+�5      �� -   5         ��Name$ imgSlot1��5      $	��100��6&   $	��100��63   $
��Left=�6?   $	��Top=�6Z   $��	23,15,0,0q�6r   �� 5      -   5        $ imgSlot2��5      $	��100��6&   $	��100��63   $
��Left=�6?   $	��Top=�6Z   $��	10,15,0,0q�6r   �� 5      -   5        $ imgSlot3��5      $	��100��6&   $	��100��63   $	��Top=�6?   $
��Left=�6W   $��	10,15,0,0q�6r   5      �� 5   
   $��1��6   .+�5      �� -   5         ��Name$ btnSpin��5      $��Spin!��6&   $��0,45,0,0q�66   $	��225��6H   6T   5      �� 5   
   -   5         ��Name$ txbScore��5      $
��Left=�6&   $��
53,166,0,0q�6A   $
��Wrap=�6U   $�� ��6i   $	��Top=�6q   �� 5   
   -   5        $ txbTotalScore��5      $
��Left=�6+   $��369,174,0,0q�6F   $
��Wrap=�6[   $�� ��6o   $	��Top=�6w   �� 5   
   $��Score:��6   $
��Left=�6!   $��
34,140,0,0q�6<   $	��Top=�6P   �� 5   
   $��Totale score��6   $
��Left=�6'   $��369,140,0,0q�6B   $	��Top=�6W   5      5      