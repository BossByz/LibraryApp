   M S B A M L   `   `   `  ����B  >POE_APP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:POE_APPPOE_APP  5          POE_APP.MainWindow   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullB
converters1http://materialdesigninxaml.net/winfx/xaml/themes  5      :d2http://schemas.microsoft.com/expression/blend/2008  5      a ]GongSolutions.WPF.DragDrop, Version=2.0.0.0, Culture=neutral, PublicKeyToken=91f1945125b7a587ddurn:gong-wpf-dragdrop  5      !localclr-namespace:POE_APP  5      FmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5
        � Title$  
MainWindow��5      $	��800��5      $	��450��5       � AllowsTransparency . 
������    MaterialDesignFont#���   5       � 
ResizeMode$ NoResize=�5      $��13(�5      $��Regular"�5        MaterialDesignBody#���  5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5       � WindowStartupLocation$ CenterScreen=�5       � WindowStyle$
 None=�5      .��5      �  � ShowGridLines .   � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5       $��1* �6   .+�5#   
   �� -   5        $��0��5$      $��2��5%      $��0��5&      $��3��5'      $	��800��5(      $	��450��5)      $
��Left=�5*      $	��Top=�5+        MaterialDesignPaper#���  5,      	 J� Opacity$	 1Q�5.      
 �� RadiusX$
 10��5/       �� RadiusY$ 10��50      '  !MaterialDesignThemes.Wpf.PackIcon  52   
   $��2��53      $��0��54      $��48��55      $��62��56      $��8,8,0,0q�57      $
��Left=�58      $	��Top=�59      
�������   Kind$
 Book=�5;      �� 5=   
   -   5        $��BtnBookReplace��5>      $��1��5?      $��0��5@      $	��210��5A      $	��290��5B      $��Right=�5C      $��Center=�5D      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��5E      ���#4285F4$��0q�5G       $  MaterialDesignFlatAccentBgButton#��[ 5I      .��5J      � $	��210��5K      $	��290��5L      $��Center=�5M      $��Center=�5N      .+�5O      �� $	��180��5P      $��20q�5Q      $��Center=�5R      $��Bottom=�5S      
�������$��REPLACING BOOKS��5U       �� TextAlignment$ Center=�5V        5W      $	��100��5X      $	��100��5Y      $��Center=�5Z      $��Center=�5[      
�������$ FileReplace=�5]      5^      5_      �� 5a   
   -   5        $��BtnIdentifyingAreas��5b      $��1��5c      $��1��5d      $	��210��5e      $	��290��5f      $��Center=�5g      $��Center=�5h      $ 10��5i      ���#DB4437$��0q�5k      #��[ 5m      .��5n      � $	��210��5o      $	��290��5p      $��Center=�5q      $��Center=�5r      .+�5s      �� $	��180��5t      $��20q�5u      $��Center=�5v      $��Bottom=�5w      
�������$��IDENTIFYING AREAS��5y      $ Center=�5z        5{      $	��100��5|      $	��100��5}      $��Center=�5~      $��Center=�5      
�������$ Magnify=�5�      5�      5�      �� 5�   
   -   5        $��BtnCallNumbers��5�      $��1��5�      $��2��5�      $	��210��5�      $	��290��5�      $
��Left=�5�      $��Center=�5�      $ 10��5�      ���#F4B400$��0q�5�      #��[ 5�      .��5�      � $	��210��5�      $	��290��5�      $��Center=�5�      $��Center=�5�      .+�5�      �� $	��180��5�      $��20q�5�      $��Center=�5�      $��Bottom=�5�      
�������$��FINDING CALL NUMBERS��5�      $ Center=�5�        5�      $	��100��5�      $	��100��5�      $��Center=�5�      $��Center=�5�      
�������$ FileFind=�5�      5�      5�      �� 5�   
   $
��Auto��5�      $��55,378,535,45q�5�      $��Center=�5�      $��START��5�       " MaterialDesignRaisedDarkButton#��[ 5�      �� 5�   
   $
��Auto��5�      $��285,378,305,45q�5�      $��Center=�5�      $��COMING SOON��5�      {�.  $	 1Q�5�      #��[ 5�      �� 5�   
   $
��Auto��5�      $��517,378,73,45q�5�      $��Center=�5�      $��COMING SOON��5�      {�.  $	 1Q�5�      #��[ 5�      �� 5�   
   -   5         ��Name$ BtnMinimize��5�      $��2��5�      $��2��5�      $��48��5�      $��48��5�      $��158,8,60.667,0q�5�      $��Center=�5�      $	��Top=�5�      $��0q�5�       & "MaterialDesignIconForegroundButton#���  5�      .��5�        $ WindowMinimize=�6&   5�      �� 5�   
   -   5        $ BtnClose��5�      $��2��5�      $��0,8,8,0q�5�      $��Right=�5�      $	��Top=�5�      $��0q�5�      #���  5�      .��5�        $ Close=�6"   5�      '  !MaterialDesignThemes.Wpf.PopupBox  5�   
   $��2��5�      $��2��5�      $��48��5�      $��48��5�      $��	0,8,103,0q�5�      $��Right=�5�      $	��Top=�5�      $��Center=�5�      $��Right=�5�         PlacementMode$ BottomAndAlignRightEdges=�5�         	StaysOpen .     PopupContent. 5�      �� .+�5�      �� $��10q�5�      $��Center=�5�       �� Orientation$ 
Horizontal=�5�      .+�5�      �� $��0,0,10,0q�6    $��Light��62   d� 5�      -   5         d�Name$ DarkModeToggleButton��5�   #    d� 	IsChecked 6A   �� *IsDark+ �� Mode$ TwoWay=��� 5�      $��10,0,0,0q�6    $
��Dark��62   5�      �� 5�      $��Center=�6   $��Colour��69   �� 5�      -   5        $��	CmbColour��5�      $��10q�5�      $��Center=�5�      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
DEEPPURPLE��5�       �� SelectedValue 5�      �� *Color+$ TwoWay=��� 5�      �� 5�      $��Center=�5�      $��Show Tutorials��5�       5�      �� *ShowTutorials+$ TwoWay=��� 5�      �� 5�      -	   5        $��BtnResetAchievements��5�      $��Reset Achievements��5�      �� 5      -
   5        $��BtnResetAll��5     $��Reset All Settings��5     �� 5     -   5        $��BtnQuit��5     $
��Quit��5     5	     5
     )  #MaterialDesignThemes.Wpf.DialogHost  5  
   -   5        $��ComingSoonDialog��5     $��0��5     $��3��5        CloseOnClickAway .    DialogTheme$ Inherit=�5        DialogContent 5     � 5     $��20q�5     
������  .   � RowDefinitions 5     �� 5     $��2* �6(   �� 5     $��2* �6(   �� 5     $��1* �6(   .+�5     �� -   5        $��BtnOk��5     $��2��5      $��0��5!     $��3��5"     $	��150��5#     $��OK��5%       MaterialDesignFlatButton#��[ 5&     �� 5(     -   5        $��TxtTutorial��5)     $��1��5*     $��0��5+     $��3��5,     $��0,0,0,30q�5-     $ Center=�5.     42This feature will be avaliable in a future release50     �� 52     -   5        $��TxtTutorialHeader��53     $��0��54     $��0��55     $��3��56     $��	0,10,0,30q�57     $��20(�58     $��Italic$�59     $
��Bold"�5:     $ Center=�5;     Coming Soon5=     5?     5A       5C  
   -   5        $��StartUpDialog��5D     $��0��5E     $��3��5F      . $ Inherit=�5H      5I     � 5J     $��20q�5K     
������  .   5O     �� 5P     $��2* �6(   �� 5Q     $��2* �6(   �� 5R     $��1* �6(   .+�5U     �� -   5        $��BtnOkStartup��5V     $��2��5W     $��0��5X     $��3��5Y     $	��150��5Z     $��GET STARTED��5\     #��[ 5]     �� 5_     -   5        $��TxtTutorialStartUp��5`     $��1��5a     $��0��5b     $��3��5c     $��0,0,0,30q�5d     $ Center=�5e     Welcome to the library app!�� 5f  5   DBWith this amazing app, you can learn more about how libraries work�� 5g  \   �� 6j   20To get started, click one of the following items�� 5h  J   �� 6X   \ZYou can also adjust your preferences (theme, colour, toggle tutorials, resetting progress)�� 5i  t   JHby clicking the button in the top right of this window (3 vertical dots)5j  c   �� 5l     -   5        $��TxtTutorialHeaderStartUp��5m     $��0��5n     $��0��5o     $��3��5p     $��	0,10,0,30q�5q     $��20(�5r     $��Italic$�5s     $
��Bold"�5t     $ Center=�5u     
Welcome!5w     5y     5{     5}     5     