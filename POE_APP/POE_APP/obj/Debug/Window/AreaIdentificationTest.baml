   M S B A M L   `   `   `  ����B  >POE_APP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:POE_APPPOE_APP  5      $    POE_APP.AreaIdentificationTest   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      a ]GongSolutions.WPF.DragDrop, Version=2.0.0.0, Culture=neutral, PublicKeyToken=91f1945125b7a587ddurn:gong-wpf-dragdrop  5      !localclr-namespace:POE_APP  5      V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5	        � Title$  BookReplace��5
      $	��800��5      $	��450��5       � AllowsTransparency . 
������  � 
ResizeMode$ NoResize=�5      $��13(�5      $��Regular"�5         MaterialDesignBody#���   5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5       � WindowStartupLocation$ CenterScreen=�5       � WindowStyle$
 None=�5      .��5      � .+�5   
   �� -   5        $	��800��5      $	��450��5      $
��Left=�5      $	��Top=�5        MaterialDesignPaper#���  5       J� Opacity$ 1Q�5        �� RadiusX$ 10��5!      	 �� RadiusY$	 10��5"      �� 5$   
   $��16q�5%      $��Center=�5&      $	��Top=�5'      $��20(�5(      $��Italic$�5)      $
��Bold"�5*      $��Identifying Areas��5+      �� 5-   
   -   5        
 ��Name$
 BtnClose��5.      $��0,8,7,0q�5/      $��Right=�50      $	��Top=�51      $��0q�52       & "MaterialDesignIconForegroundButton#���  54      .��55      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�6&   56      �� 58   
   -   5        $
 BtnMinimize��59      $��48��5:      $��48��5;      $��0,8,60.667,0q�5<      $��Right=�5=      $	��Top=�5>      $��0q�5?      #���  5A      .��5B        $ WindowMinimize=�6&   5C      �� 5E   
   -   5        $��	BtnHandIn��5F      $	��200��5G      $��8q�5H      $��Right=�5I      $��Bottom=�5J      $��FINISH ATTEMPT��5L        MaterialDesignFlatButton#���  5M      �� 5O   
   -   5        $��	BtnCancel��5P      $	��200��5Q      $��8q�5R      $
��Left=�5S      $��Bottom=�5T      $��CANCEL ATTEMPT��5V      #���  5W      �� 5Y   
   -   5        $��LstColumnLeft��5Z      $	��380��5[      $	��250��5\      $��
10,100,0,0q�5]      $
��Left=�5^      $	��Top=�5_      $��Center=�5`      �� 5b   
   -   5        $��LstColumnRight��5c      $	��380��5d      $	��250��5e      $��10,100,10,0q�5f      $��Right=�5g      $	��Top=�5h      $��Center=�5i      �� 5k   
   -   5        $��TxtTime��5l      $��8q�5m      $��Center=�5n      $	��Top=�5o       �� TextAlignment$ Center=�5p      )  #MaterialDesignThemes.Wpf.DialogHost  5r   
   -	   5        $��ResultDialog��5s         CloseOnClickAway .     DialogTheme$ Inherit=�5u         DialogContent 5v      � 5w      $��20q�5x      
������  � ShowGridLines .   � ColumnDefinitions 5|      �� 5}      $��1* �6+   �� 5~      $��1* �6+   �� 5      $��1* �6+    � RowDefinitions 5�      �� 5�      $��2* �6(   �� 5�      $��2* �6(   �� 5�      $��1* �6(   �� 5�      $��1* �6(   .+�5�      �� -
   5        $��BtnDone��5�      $��3��5�      $��0��5�      $	��150��5�      $
��DONE��5�      #��[ 5�      �� 5�      -   5        $��BtnAchievements��5�      $��3��5�      $��2��5�      $	��150��5�      $��ACHIEVEMENTS��5�      #��[ 5�      �� 5�      -   5        $��txtResultDialogUser��5�      $��1��5�      $��0��5�      $��0,0,0,30q�5�      $ Right=�5�      �� 5�      -   5        $��txtResultCorrect��5�      $��1��5�      $��2��5�      $
 Left=�5�      �� 5�      -   5        $��txtResultScore��5�      $��2��5�      $��0��5�      $��3��5�      $��0,0,0,30q�5�      $ Center=�5�      �� 5�      -   5        $��txtResultDialogHeader��5�      $��0��5�      $��1��5�      $��	0,10,0,30q�5�      $��20(�5�      $��Italic$�5�      $
��Bold"�5�      $ Center=�5�      	Results5�      5�      5�      5�      5�      