   M S B A M L   `   `   `  ���� D  @MCXTopics, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:MCXTopics	MCXTopics      MCXTopics.MainWindow   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     )localclr-namespace:MCXTopics       � Title$  
MainWindow��$	��550��$
��1000�� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=�����  �� ImageSource$ /purple.jpg��.���  � ColumnDefinitions �� $��10 ��� $	��200 ��� $��* ��� $	��200 ��� $��10 � � RowDefinitions �� $��10 ��� $��75 ��� $��70 ��� $��* ��� $��10 �.+��� -    ��Name$ Header��$��2��$��1��$
��Wrap=�$��Center=�$��39��$
��Auto��$��40(�$
��Bold"�
�������$��181,0,181,0q�$(��"Bahnschrift SemiBold SemiCondensed)�$��
MCS TOPICS������ �� $��1q� �� CornerRadius$ 20�����#98FBCD$��2��$��2��$	��Top=�$��0,18,0,0q�����  �� Color$ White��	 �� Opacity$		 0.5Q�._��� -   $��	SearchBox��
 �� TextWrapping$

 Wrap=�$��	Search...��
���OO/�$��25(�$��Center=�$
��Auto��$��37�����	#00000000$��9,0,9,0q� �� SelectionBrush �	#00000000���	#00000000 � Cursor$ IBeam���� $��1q�$ 15�����#98FBCD$��2��$��3��$��0,0,0,21q����� $ White��$		 0.5Q�._��� -   $��SearchResultsListBox��   ListBoxItemStyle#��[  $��9,35,9,9q�$��1��$��0q�
������ 
������ $
 Hand������ .R��� $ 15�� J� Opacity$ 1Q�$	��507��$��58������ $ 	#FF0B2D5C��$		 0.6Q�._��� $	��NaN��$��49��$��	10,4,10,4q���Z� .+��� $��16(�$
��Bold"�$��20��$	��386��$(��"Bahnschrift SemiBold SemiCondensed)�$��Center=����� *Code+ �� StringFormat$ 	Code: {0}������ $ 	#FFFFEDED��$	 1Q��� $��20(�$��26��$	��388�����	#FFE6DFDF$(��"Bahnschrift SemiBold SemiCondensed)����� *Topic+$ 
Topic: {0}���� -   $��RecommendTopics��#��[  $��10,70,10,41q�$��1��$��3��$��0q�
������ 
������  J� RenderTransformOrigin$ 0.5,0.5&�$
 Hand������ .R��� $ 15��$ 1Q�$	��162��$��45������ $ 	#FF0B2D5C��$		 0.6Q�._��� $��35��$��10,5,0,5q���Z� .+��� $��20(�$
��Bold"�$��33��$	��148��$(��"Bahnschrift SemiBold SemiCondensed)�$��Center=�$��Center=����� ���� $ 	#FFFFEDED��$	 1Q��� $��1q�$ 10�����#98FBCD$��3��$��3��$��17,0,10,103q����� $ White��$		 0.5Q�._��� -   $��FileUploads��$	��Top=�$��	-1,48,9,0q�$��1,1,1,1q�$	��217��$��2��
������ 
������ $
 Hand������ .R���  �� Orientation$ Vertical=�.+��� $��15(����� �� $��3��$��1q�$ 20��
�������$��
119,0,7,45q����	#FFF95757$ 0.5,0.5&�$��1��._��� -    ��Name$
 Exit��$
��EXIT��$��Center=�$��1��$��Center=�$��74��$��30��$��15(�$
��Bold"����	#00000000$
 Hand�����	#FFFBFBFB���	#00000000$(��"Bahnschrift SemiBold SemiCondensed)��� $��1��$��2��$��1q�$ 20��
�������$��15,18,23,15q�._��� -   $��UploadButton��$��UPLOAD��$��Center=�$��1��$��Center=�$	��162��$��40��$��15(�$
��Bold"����	#00000000$
 Hand�����	#FFFBFBFB���	#00000000$(��"Bahnschrift SemiBold SemiCondensed)��� $��3��$��2��$��1q�$ 20��
�������$��20,18,11,13q�._��� -   $��SearchButton��$��3��$��SEARCH��$��Center=�$��2��$��Center=�$	��150��$��39��
�������$
��Bold"�$��15(�$
 Hand��$(��"Bahnschrift SemiBold SemiCondensed)���Z� ��Z� �� -	   $��clearSearch��$��2��$��clear��$
��Left=�$��
502,27,0,0q�$��2��$	��Top=�$��15(����	#00000000$
��Bold"����	#00000000$��20��$��40��$
 Hand���� -
   $��ResultFound��$��2��$
��Left=�$��10,9,0,0q�$��3��$
��Wrap=�$��
RESULTS : ��$	��Top=�$��20(�$
��Bold"�$	��169��$(��"Bahnschrift SemiBold SemiCondensed)��� -   $��uploads��$��3��$
��Left=�$��	64,15,0,0q�$��3��$
��Wrap=�$��UPLOADS��$	��Top=�$��20(�$
��Bold"�$��80��$(��"Bahnschrift SemiBold SemiCondensed)��� $��3��$��3��$��1q�$ 20��
�������$��20,260,96,41q�._��� -   $ DeleteButton��$��3��$��DELETE��$��Center=�$��2��$��Center=�$��84��$��48��
�������$
��Bold"�$��15(�$
 Hand��$(��"Bahnschrift SemiBold SemiCondensed)���Z� ��Z� �� $��3��$��3��$��1q�$ 20��
�������$��109,260,7,41q�._��� -   $ Clear��$��3��$��CLEAR��$��Center=�$��2��$��Center=�$��84��$��48��
�������$
��Bold"�$��15(�$
 Hand��$(��"Bahnschrift SemiBold SemiCondensed)���Z� ��Z� �� $��2��$
��Left=�$	��102��$��94,0,0,0q�$��Center=�$	��124��$%��/image-removebg-preview (4).png��$��1�� J� OpacityMask �� $% /image-removebg-preview (4).png���� -   $ Header_Copy��$��1��$��3��$
��Wrap=�$	��Top=�$��39��$
��Auto��$��30(�$
��Bold"�
�������$��5,31,5,0q�$(��"Bahnschrift SemiBold SemiCondensed)�$��Code Categories������ 