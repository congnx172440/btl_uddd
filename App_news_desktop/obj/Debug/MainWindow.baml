   M S B A M L   `   `   `  ����K  GApp_news_desktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:App_news_desktopApp_news_desktop  5   	   M+clr-namespace:App_news_desktop.UserControlNApp_news_desktop.UserControlN  5   	   !    App_news_desktop.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:App_news_desktop     5   	   :uc+clr-namespace:App_news_desktop.UserControlN     5   	   _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  5
   	   _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5        $��
mainWindow��5   	    
  MainVM  � DataContext#  [  5	   	     MaterialDesignBody#���  5   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � 
ResizeMode$ NoResize=�5   	    � WindowStyle$
 None=�5   	    � WindowStartupLocation$ CenterScreen=�5   	   $
��1080��5   	   $	��720��5   	    � Title$: 4Tin Tức - Viện ĐTVT - Nhóm Công Kiền Nghĩa��5   	   *  $Microsoft.Xaml.Behaviors.Interaction   Triggers 5      +  %Microsoft.Xaml.Behaviors.EventTrigger  5   
      	EventName$ Loaded��6   *  $Microsoft.Xaml.Behaviors.TriggerBase	   Actions.	 5      2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction  
   Command
 6$   �� *LoadedWindowCommand+5      .��5      �  � RowDefinitions 5    
   �� 5!      $
��Auto �6   6,   �� 5"      6   .+�5&   
   � $��0��6   .+�5'      0   *App_news_desktop.UserControlN.ControlBarUC  0   *App_news_desktop.UserControlN.ControlBarUC   Loaded$ ControlBarUC_Loaded��6L   
 � Tag 6   �� *Title+ �� ElementName$ 
mainWindow��6k   5(      � 5-   
   $��1��6   .+�5.      � ���	#FFDEDEDE 50      �� 51      $
��Auto �6$   64   �� 52      $
��.96* �6$   64   .+�54      � $��0��6   $��2��6$   $��65��68   .+�55      � -   5         �Name$ GridMain��55      $��Right=�6-   $��Bottom=�6I   $
��Auto��6e   � 56      $��65��6   $	��Top=�6'   ���	#FF5C99D6 J� RenderTransformOrigin$ 0.384,0.214&�6V    � ColumnDefinitions 57      �� 58      $��0* �6/   �� 59      $	��60* �6/   �� 5:      $	��40* �6/    J� Effect 5<      3  -System.Windows.Media.Effects.DropShadowEffect  5=         
BlurRadius$ 1Q�6/      ShadowDepth$ 1Q�6>      Color$ 	#FFACACAC��6N   .+�5?      ��  �� Orientation$ 
Horizontal=�6%   $
��Left=�6>   $��2��6Y   $��	150,0,0,0q�6i   $	��450��6|   .+�5@      �� $
��Left=�6J   $��Center=�6e   $��16(�6�   ��6(   ��  �� Path$ DisplayName�6�   '	  !MaterialDesignThemes.Wpf.PopupBox	  5A      $
��Left=�66    	  PlacementMode$ BottomAndAlignRightEdges=�6Q    	  	StaysOpen .  $��10q�6�    	  PopupContent. 5B   "   �� $	��150��6-   .+�5C   &   �� $��Cài đặt��6T   ��6-   �� *EditAccountCommand+y�6f   �� $ DisplayCaiDat��� 5D   &   �� 5E   &   $��Đăng nhập��6O   ��6.   �� *LoginCommand+y�6c   �� $ DisplayLogin��� 5F   &   �� 5G   &   $��Đăng xuất��6P   ��6.   �� *LogoutCommand+y�6d   �� $ DisplayLogout��� 5H   &   �� 5I   &   $��
Đăng ký��6S   ��6-   �� *AddAccountCommand+y�6e   �� $ DisplayDangKy�5J   #   5K      5L      �� 5M      $
��Left=�6$   $��Center=�6?   $��22(�6Z   $��27��6h   $	��252��6t   $��1��6�   $��	352,0,0,0q�6�   %#Viện Điện Tử - Viễn Thông6�   5N      5O      � 5Q      $��1��6    5R      �� 5S      $
��.11* �6+   6:   �� 5T      $
��.89* �6+   6:   .+�5V      � -   5        $ GridMenu��5V   )   $
��Auto��6   $��0��6;   $
��Left=�6L   ���	#FF31577E.+�5X      �� $	��150��6%   $	��Top=�61   .+�5Z      �� -   5         ��Name$ ListViewMenu��5Z   '   ���	#FF5C99D6$��Disabled=�6T   .@�5[   "   �� -   5         ��Name$ 	ItemMains��5[   /   $
��Auto��6B   .��5\   &   �� $ 
Horizontal=�61   .+�5]   *   '
  !MaterialDesignThemes.Wpf.PackIcon
   
  Kind$ ViewDashboard=�6B   $��25��6W   $��25��6c   $��10q�6n   �� 5^   *   $��Trang chủ��64   $��Center=�6E   $
��3 10q�6`   5_   '   5`   #   �� 5a   "   -   5        $ ItemNews��5a   /   $
��Auto��6A   y�6O   �� $ DisplayTinTuc�.��5b   &   �� $ 
Horizontal=�61   .+�5c   *   
  $ NewspaperVariantMultiple=�6B   $��25��6b   $��25��6n   $��10q�6y   �� 5d   *   $��	Tin Tức��64   $��Center=�6C   $
��3 10q�6^   5e   '   5f   #   �� 5g   "   -   5        $ ItemAccounts��5g   /   $
��Auto��6E   y�6S   �� $ DisplayTaiKhoan�.��5h   &   �� $ 
Horizontal=�61   .+�5i   *   
  $ 
AccountCog=�6B   $��25��6T   $��25��6`   $��10q�6k   �� 5j   *   $��Tài Khoản��64   $��Center=�6E   $
��3 10q�6a   5k   '   5l   #   5n      5o      5p      � 5q      -   5        $��	uccontrol��5q      $��1��6,   $��0 1 0 1q�6<   5s      5t      5u      5v      5w      5x      