   M S B A M L   `   `   `  ���� F  BM120Projekt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:M120Projekt.ResorceDictionarysM120Projekt.ResorceDictionarys  \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   buttonStyle  �� 
TargetType �� Property �� Value �� 
TargetType A�Name J� Effect3   -System.Windows.Media.Effects.DropShadowEffect    Color    
BlurRadius ��Name	 �� Triggers
 P� Property P� Value �� 
TargetName N� EnterActions �� 
TargetName �� TargetProperty g� Duration	 W� To N� ExitActions-  'System.Windows.Input.KeyboardNavigation �� Padding �� Color �� Opacity'  !System.Windows.VisualStateManager   VisualStateGroups%  System.Windows.VisualStateGroup   States   System.Windows.VisualState   
Storyboard8  2System.Windows.Media.Animation.EasingColorKeyFrame �� KeyTime �� Value ��Name  	tableLine�� D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     6local,clr-namespace:M120Projekt.ResorceDictionarys  %�  &	        '�� T    '�� �    &	 �    �� "  ��.���  �@J�SnapsToDevicePixels . ��  �@�OverridesDefaultStyle . ��  � ��$ 23����  � ��$ 75����  � �� �� " ��.R�� .+�A� $ ellipse��
���   �$��3��#��z��$��50��$��50��    $ Black��$ 60Q��� $
 icon��$��Center=�$��Center=�#��z��$��15(�
�������	 P� 
 �@J�IsMouseOver . . ��� $ ellipse�� � ��$ 60���� $ ellipse�� � ��$ 60�� �� .���� .��W� $ ellipse��$ Height�$ 0:0:0.1D�$ 55X�W� $ ellipse��$ Width�$ 0:0:0.1D�$ 55X�W� $
 icon��$ FontSize�$ 0:0:0.1D�$ 17X� �� .���� .��W� $ ellipse��$ Height�$ 0:0:0.1D�$ 50X�W� $ ellipse��$ Width�$ 0:0:0.1D�$ 50X�W� $
 icon��$ FontSize�$ 0:0:0.1D�$ 15X�P� 
 � �� .  �� .���� .��W� $ ellipse��$ StrokeThickness�$ 0:0:0.2D�$ 2X� �� .���� .��W� $ ellipse��$ StrokeThickness�$ 0:0:0.2D�$ 3X�P� 
 � {� .  . ���  �@J�Opacity$	 0.3Q�P� 
 � {� . . ���  �@J�Opacity$ 1Q��� "  ��.���  �@J�SnapsToDevicePixels . ��  �@�OverridesDefaultStyle . ��  �@ TabNavigation$
 None=���  �@�FocusVisualStyle Z� ��  � ��$	 120����  � ��$ 20����  �@J�	AllowDrop . ��  � ��
 ���@���  � ��$ 13(���  � ��$
 Left=���  � ��$ Center=���  � ��
 �   ���  � �� �� " ��.R��� $��Border��$ 6q�$��0 0 0 2q�#��z������ $ White��$	 0.5Q�   CommonStates��.   
Normal��  Disabled��. �� .���� $ Border��$0 *(Panel.Background).(SolidColorBrush.Color)�.g�  $ 0��$
 Gray��  ReadOnly��. �� .���� $ Border��$E ?(Panel.Background).                     (SolidColorBrush.Color)�.g�  $ 0��$ DarkGray��  	MouseOver��._��� $ PART_ContentHost��$��0q��� "  ��.���  � ��$ 13(���  � ��$
 Left=���  � ��$ Center=��� "  ��.���  � ��$ Bottom=���  � ��$ 0 0 0 1q���  � ��
 �������  �@J�Opacity$	 0.7Q�