   M S B A M L   `   `   `  ����B  >POE_APP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:POE_APPPOE_APP  5          POE_APP.BookReplaceTest   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      a ]GongSolutions.WPF.DragDrop, Version=2.0.0.0, Culture=neutral, PublicKeyToken=91f1945125b7a587ddurn:gong-wpf-dragdrop  5      !localclr-namespace:POE_APP  5      V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5	        � Title$  BookReplace��5
      $	��800��5      $	��670��5       � AllowsTransparency . 
������  � 
ResizeMode$ NoResize=�5      $��13(�5      $��Regular"�5         MaterialDesignBody#���   5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5       � WindowStartupLocation$ CenterScreen=�5       � WindowStyle$
 None=�5      .��5      � $��0,0,0,0q�6   .+�5   
   �� -   5        $	��800��5      $	��670��5      $
��Left=�5      $	��Top=�5        MaterialDesignPaper#���  5       J� Opacity$ 1Q�5        �� RadiusX$ 10��5!      	 �� RadiusY$	 10��5"      �� 5$   
   -   5        
 ��Name$
 BtnClose��5%      $��0,8,7,0q�5&      $��Right=�5'      $	��Top=�5(      $��0q�5)       & "MaterialDesignIconForegroundButton#���  5+      .��5,      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�6&   5-      �� 5/   
   -   5        $
 BtnMinimize��50      $��48��51      $��48��52      $��0,8,60.667,0q�53      $��Right=�54      $	��Top=�55      $��0q�56      #���  58      .��59        $ WindowMinimize=�6&   5:      �� 5<   
   -   5        $��	BtnHandIn��5=      $	��200��5>      $��8q�5?      $��Right=�5@      $��Bottom=�5A      $��FINISH ATTEMPT��5C        MaterialDesignFlatButton#���  5D      �� 5F   
   -   5        $��	BtnCancel��5G      $	��200��5H      $��8q�5I      $
��Left=�5J      $��Bottom=�5K      $��CANCEL ATTEMPT��5M      #���  5N      �� 5P   
   -   5        $��LstBooks��5Q      $	��780��5R      $	��564��5S      $��	10,61,0,0q�5T      $
��Left=�5U      $	��Top=�5V      $��Center=�5W      )  #GongSolutions.Wpf.DragDrop.DragDrop   IsDragSource .    IsDropTarget .    SelectDroppedItems .    DropHandler 5X      �� 5[      �� 5]   
   $��16q�5^      $��Center=�5_      $	��Top=�5`      $��20(�5a      $��Italic$�5b      $
��Bold"�5c      $��Replacing Books��5d      �� 5f   
   -   5        $��TxtTime��5g      $��8q�5h      $
��Left=�5i      $	��Top=�5j       �� TextAlignment$ Center=�5k      )  #MaterialDesignThemes.Wpf.DialogHost  5m   
   -   5        $��ResultDialog��5n         CloseOnClickAway .     DialogTheme$ Inherit=�5p         DialogContent 5q      � 5r      $��20q�5s      
������  � ShowGridLines .   � ColumnDefinitions 5w      �� 5x      $��1* �6+   �� 5y      $��1* �6+   �� 5z      $��1* �6+    � RowDefinitions 5}      �� 5~      $��2* �6(   �� 5      $��2* �6(   �� 5�      $��1* �6(   �� 5�      $��1* �6(   .+�5�      �� -	   5        $��BtnDone��5�      $��3��5�      $��0��5�      $	��150��5�      $
��DONE��5�      #��[ 5�      �� 5�      -
   5        $��BtnAchievements��5�      $��3��5�      $��2��5�      $	��150��5�      $��ACHIEVEMENTS��5�      #��[ 5�      �� 5�      -   5        $��txtResultDialogUser��5�      $��1��5�      $��0��5�      $��0,0,0,30q�5�      $ Right=�5�      �� 5�      -   5        $��txtResultCorrect��5�      $��1��5�      $��2��5�      $
 Left=�5�      �� 5�      -   5        $��txtResultScore��5�      $��2��5�      $��0��5�      $��3��5�      $��0,0,0,30q�5�      $ Center=�5�      �� 5�      -   5        $��txtResultDialogHeader��5�      $��0��5�      $��1��5�      $��	0,10,0,30q�5�      $��20(�5�      $��Italic$�5�      $
��Bold"�5�      $ Center=�5�      	Results5�      5�      5�      5�      5�      