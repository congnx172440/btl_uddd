   M S B A M L   `   `   `  ����K  GApp_news_desktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:App_news_desktopApp_news_desktop  5   	   M+clr-namespace:App_news_desktop.UserControlNApp_news_desktop.UserControlN  5   	   !    App_news_desktop.DetailNews   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:App_news_desktop     5   	   :uc+clr-namespace:App_news_desktop.UserControlN     5   	   _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  5	   	   _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
   	   -   5          �Name$  detailnewsWindow��5   	      MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � 
ResizeMode$ NoResize=�5   	    � WindowStyle$
 None=�5   	   $	��720��5   	   $
��1080��5   	    � WindowStartupLocation$ CenterScreen=�5   	     
MainNewsVM � DataContext# [ 5   	    � Title$ Đọc Tin Tức��5   	   *  $Microsoft.Xaml.Behaviors.Interaction   Triggers 5      +  %Microsoft.Xaml.Behaviors.EventTrigger  5   
   	   	EventName$	 Loaded��6   *  $Microsoft.Xaml.Behaviors.TriggerBase
   Actions.
 5      2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction     Command 6$   �� *LoadedWindowCommand+5      .��5!      �  � RowDefinitions 5"   
   �� 5#      $
��Auto �6   6,   �� 5$      $
��Auto �6   6,   �� 5%      $
��Auto �6   6,   .+�5(   
   � $��0��6   .+�5)      0   *App_news_desktop.UserControlN.ControlBarUC  0   *App_news_desktop.UserControlN.ControlBarUC   Loaded$ ControlBarUC_Loaded��6R   
 � Tag 6   �� *Title+ �� ElementName$ detailnewsWindow��6q   5*      � 5,   
   $��1��6    � ColumnDefinitions 5-      �� 5.      $
��.40* �6#   62   �� 5/      $
��.60* �6#   62   .+�52      � $��0��6   .+�54      #  MaterialDesignThemes.Wpf.Card  $
��Auto��6&   $��10 10 10 10q�64   .��55      �  56      �� 57      $
��Auto �6,   �� 58      $
��Auto �6,   �� 59      $
��Auto �6,   .+�5;      � $��0��6   .+�5<      �� $	��180��5>      $��UniformToFill=�5?      $
��Left=�5@      ��5=      �� *imgn+5@      5A      �� 5C      $��1��6%   $��8 16 8 0q�62   .+�5D      �� $
��Bold"�6(   $��15(�6:   ��5E   (   �� *SelectedUser.DisplayName+�� 5G      $
��Wrap=�6(   $
��Thin"�6<   $��Italic$�6N   $��12(�6a   $��0 5 0 0q�6o   ��5H   (   �� *SelectedUser.ViTri+�� 5J      $	��0 8q�5K   !   $
��Bold"�5L   !   $
��Wrap=�5M   !   $
��Left=�5N   !   $��Center=�5O   !   $��13(�5P   !   ��5Q   !   �� *DisplayName+5R      �� 5T      $
��Left=�6%   $��2��6@    �� Orientation$ 
Horizontal=�6M   $��8q�6f   .+�5U      ��   MaterialDesignToolButton#��[ 5V   !   $��30��5W   !   $��2 0 2 0q�5X   !   {�.  +	  %MaterialDesignThemes.Wpf.RippleAssist 	  
IsCentered . .��5[   "   '
  !MaterialDesignThemes.Wpf.PackIcon
   
  Kind 6:   �� *DisplayIcon+5\      �� 5]      $��Center=�6(   $��Center=�6C   $
��Bold"�6`   $��14(�6r   ��5^   (   �� *
NgayDang+5`      5a      5b      5d      � 5e      $��1��6   .+�5f        $	��320��6&   $��10 10 10 10q�63   .��5g      �� -   5        $��MyScrollViewer��5g   #   ��. .��5h      �� $��Medium"�6    $��Italic$�64   $��12(�6G   $��0 5 0 0q�6U   ��5i   (   �� *	Content+5k      5l      5m      5o      � 5q   
   $��2��6    5r      �� 5s      $
��.40* �6#   62   �� 5t      $
��.60* �6#   62   .+�5w      � $��0��6    5x      �� 5y      6&   �� 5z      6&   .+�5}      � $��0��6   .+�5~        $	��150��6*   $��2��67   $��10 15 15 10q�6D   .��5      � .+�5�      �� $��5q�6d   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Nhập bình luận...��6o    % !MaterialDesignFloatingHintTextBox#��[ 6�   ��6&   �� *	Comment+ �� UpdateSourceTrigger$ PropertyChanged=�6�   5�      5�      5�      � 5�      $��1��6   .+�5�      �� $��60��6E   $��Xác nhận��6Q   $��25q�6d   $
��Auto��6p   ��6   �� *ThemBinhLuanCommand+6   5�      5�      � 5�      $��1��6   .+�5�      �� $	��640��6   .+�5�        $��10 10 10 10q�6&   .��5�      9� $��Center=�6   $��Tham khảo thêm tại��6<   .��5�      �� �� 5�      -   5        ��5�   )   �� *LinkCT+.�6t   .�5�   "   �� $
��Bold"�6,   $��Italic$�6>   $��15(�6Q   $��20 5 0 0q�6_   $��Center=�5�   (   $
��Left=�6C   ��5�   (   �� *LinkCT+5�      5�      5�      5�      �� 5�      ��6   �� *	LBinhLuan+ �� Mode$ TwoWay=�$ PropertyChanged=���5�      �� 5�      .R�5�   "   � .+�5�   &   �� $	��Top=�5�   '   $��Visible=�5�   '   $��Visible=�5�   '   ��. .��5�      � $��Center=�6#   $��5q�6@   $
��Auto��6K    5�   "   �� 5�   &   �� 5�   &   �� 5�   &   .+�5�   "   �� $��60��6)   $��60��64   
�������$	��0.6q�6T   ��5�   &   �� 5�   *    �� ImageSource 65   �� *
Users.imgn+5�   #   �� 5�   "   $��1��6-   .+�5�   &   �� $��CharacterEllipsis=�5�   L    J� Opacity$	 0.6Q�6m   $��11(�6{   $
��10 0q�6�   ��6)   �� *Users.DisplayName+6�   �� 5�   &   $	��500��60   $
��Wrap=�6<   $
��10 0q�5�   I   ��60   �� *	Content+6I   5�   #   5�      5�      5�   #   5�      5�      5�      5�      5�      5�      5�      