   M S B A M L   `   `   `  ����K  GApp_news_desktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:App_news_desktop.UserControlNApp_news_desktop.UserControlN  5      -    'App_news_desktop.UserControlN.AccountUC   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      =local+clr-namespace:App_news_desktop.UserControlN     5      _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  5	      _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
      -   5        $��	ucAccount��5         	AccountVM  � DataContext#  [  5        MaterialDesignBody#���  5      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5      $
��Auto��5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      6   .+�5   
   � $��0��6   .+�5      � $��Stretch=�6   $��Stretch=�61   
������  � 	Resources 5       �� 
TargetType �� Property �� Value��%�   '��       �� 5      " ��6   .�5      ��  � ��$ 2 4 2 4q�63   6E   �� 5        � ��
 ��ح�6K   5!      5"       � ColumnDefinitions 5$      �� 5%      6*   �� 5&      6*   �� 5'      6*   .+�5)      � $��0��6   .+�5*      �� 	 � ToolTip$	 Thêm��6A   $��2��6P   $��2,4,2,4q�6d   ��6   �� *AddUserCommand+.��5+      �  5,      �� 5-   "   62   �� 5.   "   62   .+�50      � $��0��6#   .+�51   "   �� $��Thêm��6,   $��Center=�68   6W   52      � 53      $��1��6#   .+�54   "   '  !MaterialDesignThemes.Wpf.PackIcon  $��Center=�6:   $��24��6W   $��24��6b   
   Kind$
 PlusCircleOutline=�6o   55      56      57      58      � 5:      $��1��6   .+�5;      �� $	 Sửa��6A   $��2��6P   $��2,4,2,4q�6d   ��6   �� *EditUserCommand+.��5<      �  5=      �� 5>   "   62   �� 5?   "   62   .+�5A      � $��0��6#   .+�5B   "   �� $��Sửa��6,   $��Center=�67   6V   5C      � 5D      $��1��6#   .+�5E   "     $��Center=�6:   $��24��6W   $��24��6b   $
 Pencil=�6o   5F      5G      5H      5I      � 5K      $��2��6   .+�5L      �� $
	 Xóa��6   $��2��6,   $��2,4,2,4q�6@   .��5M      �  5N      �� 5O   "   62   �� 5P   "   62   .+�5R      � $��0��6#   .+�5S   "   �� $
��Xóa��6,   $��Center=�67   6V   5T      � 5U      $��1��6#   .+�5V   "     $��Center=�6:   $��24��6W   $��24��6b   $
 DeleteOutline=�6o   5W      5X      5Y      5Z      5\      5]      #  MaterialDesignThemes.Wpf.Card  5_   
   $��1��6   $��5q�6+   $��Stretch=�66   .��5`      �  5a      �� 5b      $
��Auto �6$   64   �� 5c      6&   .+�5f      � $��0��6   .+�5g      �� 6"   5h      � 5i      $��1��6   .+�5j      �� ��6   �� *List+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=� �� SelectedItem 6n   �� *SelectedItem+$ TwoWay=���5k      �� 5l      " ��6$   .�5m   "   ��  � ��$ Stretch=�6O   5n       �� View 5p      �� 5q      .P�5r   "   ��  �� Width$
 Auto��61   $��Id��6>    �� DisplayMemberBinding 6J   �� *Id+6p   �� 5s   "   $
 Auto��61   $
��Tên��6>    6K   �� *DisplayName+6z   �� 5t   "   $
 Auto��61   $��Tên đăng nhập��6>    6U   �� *
UserName+6�   �� 5u   "   $
 Auto��61   $��Quyền��6>    6M   �� *Quyen.DisplayName+6�   �� 5v   "   $
 Auto��61   $��	Vị trí��6>    6N   �� *ViTri+6w   �� 5w   "   $
 Auto��61   $��Ảnh��6>    �� CellTemplate 5x   &   �� 5y   *   .R�5z   .   �� $��myRectangle��6Q   $	��100��68   $	��100��6E   ��5{   2   �� 5|   6   imgn�� �� ImageSource 6O   �� *imgn+5~   /   5   +   5�   #   5�      5�      5�      5�      5�      5�      5�      