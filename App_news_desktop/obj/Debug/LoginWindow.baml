   M S B A M L   `   `   `  ����K  GApp_news_desktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:App_news_desktop.UserControlNApp_news_desktop.UserControlN  5   	   3clr-namespace:App_news_desktopApp_news_desktop  5   	   "    App_news_desktop.LoginWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :uc+clr-namespace:App_news_desktop.UserControlN     5   	   0localclr-namespace:App_news_desktop     5   	   _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	   _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  5   	   -   5        $��loginWindow��5   	      MaterialDesignBody#���   5
   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � 
ResizeMode$ NoResize=�5   	    � WindowStyle$
 None=�5   	     LoginVM � DataContext# [ 5   	    � WindowStartupLocation$ CenterScreen=�5   	    � Title$ Đăng nhập��5   	   $	��500��6   $	��350��6(   *  $Microsoft.Xaml.Behaviors.Interaction   Triggers 5      +  %Microsoft.Xaml.Behaviors.EventTrigger  5   
      	EventName$ Loaded��6   *  $Microsoft.Xaml.Behaviors.TriggerBase	   Actions.	 5      2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction  
   Command
 6$   �� *LoadedWindowCommand+5      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5       6   .+�5"   
   � $��0��6   .+�5#      0   *App_news_desktop.UserControlN.ControlBarUC  
 � Tag 6   �� *Title+ �� ElementName$ loginWindow��6O   5$      � 5%   
   $��1��6   .+�5&      �� $	��220��6   $	��Top=�6%   ��5(      �� 5)       �� EndPoint$ 0.5,1&�6*    �� 
StartPoint$ 0.5,0&�6;   .��5*      �  � Color$
 blue��6'   � 5+      $ 	#FF34268A��6'    � Offset$ 1Q�69   � 5,      $ 	#FF33288B��6'   $ 0.546Q�69   5-      5/      �� 51      $	��240��6   $��Bottom=�6&   $
��0,80q�6A    �� RadiusY$ 10��6O    �� RadiusX$ 10��6\   
������� J� Effect 52      3  -System.Windows.Media.Effects.DropShadowEffect  53         
BlurRadius$ 15Q�6'      	Direction$ 0Q�67      RenderingBias$ Quality=�6E      ShadowDepth$ 1Q�6]      Color$ 	#FFBBBBBB��6m   55      � 57      $��Bottom=�6   $��35,80q�6.   $	��240��6=   .+�58      �� $��ĐĂNG NHẬP��6   $��Center=�6,   $	��Top=�6I   $��5q�6a   
�������$��18(�6~   �� 59      $��Center=�6   $��15q�68   .+�5:      �� $
��0,10q�68   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ TÀI KHOẢN��6F    % !MaterialDesignFloatingHintTextBox#��[ 6q   $��Champagne & Limousines)�6�   $��18(�6�   ��6   �� *
UserName+6�   G� 5;      -   5         G�Name$ FloatingPasswordBox��5;   "   $
��0,10q�6?   $ MẬT KHẨU��6M    ) %MaterialDesignFloatingHintPasswordBox#��[ 6w   $��Champagne & Limousines)�6�   $��18(�6�    5<        5=      $ PasswordChanged��6-   .	 5>   "     
 68   �� *PasswordChangedCommand+   CommandParameter 5?   $   �� $ FloatingPasswordBox��5@      5B      5C      5D      �� 5F      $	��150��6q   $��Center=�6}   $��Bottom=�6�   $
��0,65q�6�   $��ĐĂNG NHẬP��6�   ��6   �� *CloseWindowCommand+��6<   �� $ loginWindow��6�   �� 5G      $��Quên mật khẩu?��6   $��Center=�6.   $��Bottom=�6K   $��30q�6f   
������� � Cursor$
 Hand��6�   �� 5H      $I��CC:\Users\cong\Desktop\btldd\App_news_desktop\Assets\logosethust.png��6   $	��125��6a   $	��100��6m   $	��Top=�6z   $��30q�6�   5I      5J      5K      