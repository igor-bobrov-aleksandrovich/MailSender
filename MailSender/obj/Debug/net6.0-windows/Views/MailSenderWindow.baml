   M S B A M L   `   `   `  ����E  AMailSender, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:MailSender.ViewsMailSender.Views  5   	   '    !MailSender.Views.MailSenderWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   
   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:MailSender.Views     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  MailSenderWindow��5
   	   $	��600��6"   $	��800��6/   .��5      � ��5   
   �� 5       �� ImageSource$J D/Image/1671600562_kalix-club-p-oboi-minimalizm-belie-pinterest-2.jpg��6    � ColumnDefinitions 5   
   �� 5      $��25 �6   �� 5      $
��745* �6   �� 5      $	��25* �6    � RowDefinitions 5   
   �� 5      $��10 �6   �� 5      $	��35* �6   �� 5      $��10 �6   �� 5      $	��28* �6   �� 5      $��10 �6   �� 5      $	��29* �6   �� 5      $��10 �6   �� 5      $
��364* �6   �� 5      $��10 �6   �� 5      $	��40* �6   �� 5      $��10 �6   .+�5!   
   �� $��1��6   $��Center=�6"    �� TextWrapping$
 Wrap=�6?   $��Center=�6S   $��1��6n   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Тема��5"      ���	#FFCEBBBB.  (MaterialDesignThemes.Wpf.TextFieldAssist   UnderlineBrush �	#FF8D00D2$	��729��5%   Q   ��6   �� *
StrTheme+ �� UpdateSourceTrigger$ PropertyChanged=�6Q   �� 5&   
   $��1��6   $��Center=�6"   $
 Wrap=�6?   $��Center=�6S   $��5��6n   $ Кому��5'      ���	#FFCEBBBB �	#FF8D00D2$	��729��5*   N   ��6   �� *StrTo+$ PropertyChanged=�6N   �� 5+   
   -   5        $��1��5+      $��Отправить��6!   $��Center=�65   $��9��6R   $��Center=�6_   ���	#FFCEBBBB6�   �� 5,   
   $��1��6   $��Center=�6#   $��3��6@   $ От кого��5-       �	#FF8D00D2$	��729��5.   L   ���	#FFCEBBBB �� Text 5/      �� *	StrFrom+$ PropertyChanged=�6Q   �� 50   
   $��1��6   $��7��6&   $��2��63   $ Письмо��6G    �	#FF8D00D2	 �� AutoWordSelection$	 False��51   L   ��52      �� 53      . �55      /� .T�56      J� .*�6   .*�57      �� ���	#FFCEBBBB�61   �� *
StrMessage+$ PropertyChanged=�58      59      5:      5<      5=      