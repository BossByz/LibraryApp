   M S B A M L   `   `   `  ����B  >POE_APP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:POE_APPPOE_APP  5          POE_APP.Achievements   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:POE_APP     5      V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5        � Title$  BookReplace��5	      $	��800��5
      $	��450��5       � AllowsTransparency . 
������  � 
ResizeMode$ NoResize=�5      $��13(�5      $��Regular"�5         MaterialDesignBody#���   5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5       � WindowStartupLocation$ CenterScreen=�5       � WindowStyle$
 None=�5      .��5      � .+�5   
   �� -   5        $	��800��5      $	��450��5      $
��Left=�5      $	��Top=�5        MaterialDesignPaper#���  5       J� Opacity$ 1Q�5       �� RadiusX$ 10��5       	 �� RadiusY$	 10��5!      �� 5#   
   -   5        
 ��Name$
 BtnClose��5$      $��0,8,8,0q�5%      $��Right=�5&      $	��Top=�5'      $��0q�5(       & "MaterialDesignIconForegroundButton#���  5*      .��5+      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�6&   5,      �� 5.   
   -   5        $
 BtnMinimize��5/      $��48��50      $��48��51      $��0,8,60.667,0q�52      $��Right=�53      $	��Top=�54      $��0q�55      #���  57      .��58        $ WindowMinimize=�6&   59      �� 5;   
   -   5        $
 BtnBack��5<      $��8q�5=      $
��Left=�5>      $	��Top=�5?      $��0q�5@      #���  5B      .��5C        $ 	ArrowLeft=�6&   5D      �� 5F   
   -   5        $��LstBooks��5G      $	��780��5H      $	��329��5I      $��	10,61,0,0q�5J      $
��Left=�5K      $	��Top=�5L      �� 5N   
   -   5        $��TxtCompletedCount��5O      $��8q�5P      $��Center=�5Q      $��Bottom=�5R      #���   5S      �� 5U   
   -   5        $
 BtnStats��5V      $��8q�5W      $��Right=�5X      $��Bottom=�5Y      $��0q�5Z      #���  5\      $y�Hidden=�5]      .��5^        $ Graph=�6&   5_      5a      5b      