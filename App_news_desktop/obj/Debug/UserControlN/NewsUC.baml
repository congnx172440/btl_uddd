   M S B A M L   `   `   `  ����K  GApp_news_desktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:App_news_desktop.UserControlNApp_news_desktop.UserControlN  5      *    $App_news_desktop.UserControlN.NewsUC   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      =local+clr-namespace:App_news_desktop.UserControlN     5      _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  5	      _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
      -   5        $��ucNews��5       
  NewsVM  � DataContext#  [  5        MaterialDesignBody#���  5      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5      $
��Auto��5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      6   .+�5   
   � $��0��6   .+�5      � $��Stretch=�6   $��Stretch=�61   
������  � 	Resources 5       �� 
TargetType �� Property �� Value��%�   '��       �� 5      " ��6   .�5      ��  � ��$ 2 4 2 4q�63   6E   �� 5       � ��
 ��ح�6K   5       5!       � ColumnDefinitions 5#      �� 5$      6*   �� 5%      6*   �� 5&      6*   .+�5(      � $��0��6   .+�5)      �� 	 � ToolTip$	 Thêm��6@   $��2��6O   $��2,4,2,4q�6c   ��6   �� *AddNewsCommand+.��5*      �  5+      �� 5,   "   62   �� 5-   "   62   .+�5/      � $��0��6#   .+�50   "   �� $��Thêm��6,   $��Center=�68   6W   51      � 52      $��1��6#   .+�53   "   '  !MaterialDesignThemes.Wpf.PackIcon  $��Center=�6:   $��24��6W   $��24��6b   
   Kind$
 PlusCircleOutline=�6o   54      55      56      57      � 59      $��1��6   .+�5:      �� $	 Sửa��6A   $��2��6O   $��2,4,2,4q�6c   ��6   �� *EditNewsCommand+.��5;      �  5<      �� 5=   "   62   �� 5>   "   62   .+�5@      � $��0��6#   .+�5A   "   �� $��Sửa��6,   $��Center=�67   6V   5B      � 5C      $��1��6#   .+�5D   "     $��Center=�6:   $��24��6W   $��24��6b   $
 Pencil=�6o   5E      5F      5G      5H      � 5J      $��2��6   .+�5K      �� $
	 Xóa��6   $��2��6,   $��2,4,2,4q�6@   .��5L      �  5M      �� 5N   "   62   �� 5O   "   62   .+�5Q      � $��0��6#   .+�5R   "   �� $
��Xóa��6,   $��Center=�67   6V   5S      � 5T      $��1��6#   .+�5U   "     $��Center=�6:   $��24��6W   $��24��6b   $
 DeleteOutline=�6o   5V      5W      5X      5Y      5[      5\      #  MaterialDesignThemes.Wpf.Card  5^   
   $��1��6   $��5q�6+   $��Stretch=�66   .��5_      �  5`      �� 5a      $
��Auto �6$   64   �� 5b      $
��Auto �6$   64   �� 5c      6&   .+�5f      � $��0��6   $��5q�6$    5g      �� 5h      $
��Auto �6+   6:   �� 5i      $
��Auto �6+   6:   �� 5j      $
��Auto �6+   6:   .+�5m      � $��0��6   .+�5n      (  "System.Windows.Controls.DatePicker  )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Ngày bắt đầu��6%   $	��150��6V    ( $MaterialDesignFloatingHintDatePicker#��[ 6b   $��15q�6�   5o      � 5p      $��1��6   .+�5q        $��Center=�6%   $
��Left=�6@   $	��150��6[   $ Ngày kết thúc��6g   #��[ 6�   $��15q�6�   5r      � 5s      $��2��6   .+�5t      ��   MaterialDesignRaisedButton#��[ 6!   $	��150��5u   -   $��Lọc��5v   -   $/	 )Resource name: MaterialDesignRaisedButton��5w   -   $��15q�6a   6o   5x      5y      � 5{      $��1��6   .+�5|      �� 6"   5}      � 5~      $��2��6   .+�5      �� ��6   �� *List+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=� �� SelectedItem 6n   �� *SelectedItem+$ TwoWay=���5�      �� 5�      " ��6$   .�5�   "   ��  � ��$ Stretch=�6O   5�       �� View 5�      �� 5�      .P�5�   "   ��  �� Width$
 Auto��61   $��Id��6>    �� DisplayMemberBinding 6J   �� *Id+6p   �� 5�   "   $
 Auto��61   $��Tiêu đề��6>    6O   �� *DisplayName+6~   �� 5�   "   $
 Auto��61   $��
Loại Tin��6>    6P   �� *LoaiTin.DisplayName+6�   �� 5�   "   $
 Auto��61   $��Người đăng��6>    6R   �� *Users.DisplayName+6�   �� 5�   "   $
 Auto��61   $��Ngày Đăng��6>    6Q   �� *
NgayDang+6}   �� 5�   "   $
 Auto��61   $��Link chi tiết��6>    6U   �� *LinkCT+6   �� 5�   "   $
 Auto��61   $��Ảnh��6>    �� CellTemplate 5�   &   �� 5�   *   .R�5�   .   �� $��myRectangle��6Q   $	��100��68   $	��100��6E   ��5�   2   �� 5�   6   imgn�� �� ImageSource 6O   �� *imgn+5�   /   5�   +   5�   #   5�      5�      5�      5�      5�      5�      5�      