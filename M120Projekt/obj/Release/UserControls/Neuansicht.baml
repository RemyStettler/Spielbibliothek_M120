   M S B A M L   `   `   `  ���� F  BM120Projekt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:M120Projekt.UserControlsM120Projekt.UserControls  )    #M120Projekt.UserControls.Neuansicht   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     8local&clr-namespace:M120Projekt.UserControls     =toolkit)http://schemas.xceed.com/wpf/xaml/toolkit       � 	Resources   �� MergedDictionaries �� Source��  �� $% /ResourceDictionarys/Style.xaml?�%    .��� .+�� $��1��$��Center=�$��100 0q�$	��400�� � ColumnDefinitions �� $��2* ��� $��4* � � RowDefinitions �� $��1* ��� $��1* ��� $��1* ��� $��1* ��� $��1* ��� $��1* ��� $��1* ��� $��2* �.+��� $��0��$��0��$��Name:��$
��Left=�$��Center=��� -    ��Name$ txtName��$��0��$��1��$	��200��$	��300�� �� 	MaxLength$ 30���� $��0��$��2��   	tableLine#��[  �� $��1��$��0��$��
Publisher:��$
��Left=�$��Center=��� -   $ txtPublisher��$��1��$��1��$	��200��$	��300��$ 30���� $��1��$��2��#��[  �� $��2��$��0��$��Erscheinungsdatum:��$
��Left=�$��Center=�(  "System.Windows.Controls.DatePicker  -     Name$ dateErscheinung��$��2��$��1��$
��Left=�$��Center=��� $��2��$��2��#��[  �� $��3��$��0��$��Mindestalter:��$
��Left=�$��Center=��� -   $ txtMindestalter��$��3��$��1��$	��200��$ 2���� $��3��$��2��#��[  �� $��4��$��0��$��Preis:��$
��Left=�$��Center=��� -   $ txtPreis��$��4��$��1��$	��200��$	��300��$ 30���� $��4��$��2��#��[  �� $��5��$��0��$��Steam:��$
��Left=�$��Center=��� -    ��Name$ 
checkSteam��$��5��$��1��$��Ja��$
��Left=�$��Center=��� $��5��$��2��#��[  �� $��6��$��0��$��
Bewertung:��$
��Left=�$��Center=��� -   $ txtBewertung��$��6��$��1��$	��200��$ 1���� $��6��$��2��#��[  � $��5q�$��7��$��2��.+��� -   	 ��Name$	 btnNeu��
��� � �  buttonStyle#��[ $	��✔��$
��Left=�$��70���� -	   $	 btnAbbrechen��
���  ��#��[ $	��✖��$��Right=�$��70���� -
   $	 	btnLeeren��
�������#��[ $��Felder Leeren��$��Center=�$��80��