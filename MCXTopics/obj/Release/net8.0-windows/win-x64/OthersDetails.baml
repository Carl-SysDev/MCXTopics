   M S B A M L   `   `   `  ���� D  @MCXTopics, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:MCXTopics	MCXTopics      MCXTopics.OthersDetails   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     )localclr-namespace:MCXTopics       � Title$  OthersDetails��$	��500��$	��800�� � WindowStartupLocation$ CenterScreen=�����  �� ImageSource$ /purple.jpg�� � 	Resources  �� 
TargetType �� Property �� Value �� Triggers P� Property	 P� Value��%�   '��       �� " ��.���  � ��
 ����  P�  �@J�IsMouseOver$
	 True��. ���  � ��
 ���� P�  �@J�	IsFocused$
	 True��. ���  � ��
 ���� .��� 
 � RowDefinitions
 �� $��10 ��� $��287.54 ��� $��162.46 ��� $��10 � � ColumnDefinitions �� $��10 ��� $
��Auto �.+��� $
��Left=�$��
49,107,0,0q�$��1��$
��Wrap=�$��TOPIC��$	��Top=�$	��126��$��27��$��15(�$
��Bold"�
�������$��1���� $��1q� �� CornerRadius$ 20�����#98FBCD$��44,134,1043,114q�$��1��$��1������  �� Color$ White�� �� Opacity$	 0.5Q�._��� -    ��Name$ TopicTextBlock��$
��Left=�$��1�� �� TextWrapping$
 Wrap=�$�� ��$��Center=�$	��296��$��20��$��9,0,0,0q� �� SelectionBrush �	#00000000$(��"Bahnschrift SemiBold SemiCondensed)� �� SelectionTextBrush �	#00000000 �� 
IsReadOnly$
 True��$��15(���Z� ��Z� �� $
��Left=�$��	48,32,0,0q�$��1��$
��Wrap=�$
��CODE��$	��Top=�$��60��$��32��$��15(�$
��Bold"�
�������$��1���� $��1q�$ 20�����#98FBCD$��44,59,1043,189q�$��1��$��1������ $ White��$	 0.5Q�._��� -   $ CodeTextBlock��$��Center=�$��1��$
 Wrap=�$�� ��$��Center=�$	��286��$��20�� �	#00000000$(��"Bahnschrift SemiBold SemiCondensed)� �	#00000000$
 True��$��15(���Z� ��Z� �� $
��Left=�$��
48,180,0,0q�$��1��$
��Wrap=�$��DESCRIPTIONS��$	��Top=�$	��126��$��32��$��15(�$
��Bold"�
�������$��1���� $��1q�$ 20�����#98FBCD$��44,212,1043,10q�$��1��$��1��$��2������ $ White��$	 0.5Q�._��� -   $ DescriptionTextBlock��$��Center=�$��1��$
 Wrap=�$�� ��$��Center=�$	��286��$	��208�� �	#00000000$(��"Bahnschrift SemiBold SemiCondensed)� �	#00000000$
 True��$��15(���Z� ��Z� �� $
��Left=�$��
381,27,0,0q�$��1��$
��Wrap=�$	��Top=�$	��126��$��32��$��15(�$
��Bold"�
�������$��1�� J� RenderTransformOrigin$ 0.496,0.829&�$��
HOW TO USE���� $��1q�$ 20�����#98FBCD$��381,59,706,125q�$��1��$��1������ $ White��$	 0.5Q�._��� -   $ HowToUseTextBlock��$��Center=�$��1��$
 Wrap=�$�� ��$��Center=�$	��286��$��91�� �	#00000000$(��"Bahnschrift SemiBold SemiCondensed)� �	#00000000$
 True��$��15(���Z� ��Z� �� $
��Left=�$��381,175,0,0q�$��1��$
��Wrap=�$	��Top=�$	��126��$��25��$��15(�$
��Bold"�
�������$��1��$ 0.496,0.829&�$��WHEN TO USE���� $��1q�$ 20�����#98FBCD$��381,200,706,146q�$��1��$��1��$��2������ $ White��$	 0.5Q�._��� -   $ WhenToUseTextBlock��$��Center=�$��1��$
 Wrap=�$�� ��$��Center=�$	��286��$��92�� �	#00000000$(��"Bahnschrift SemiBold SemiCondensed)� �	#00000000$
 True��$��15(���Z� ��Z� �� $
��Left=�$��
381,22,0,0q�$��2��$
��Wrap=�$	��Top=�$	��126��$��24��$��15(�$
��Bold"�
�������$��1��$ 0.496,0.829&�$��OTHERS���� $��1q�$ 20�����#98FBCD$��381,48,706,10q�$��1��$��2������ $ White��$	 0.5Q�._��� -   $ OthersTextBlock��$��Center=�$��1��$
 Wrap=�$�� ��$��Center=�$	��286��$��91�� �	#00000000$(��"Bahnschrift SemiBold SemiCondensed)�$
 True��$��15(���Z� ��Z� �� $��1��$��1q�$ 20��
�������$��685,5,631,253q����	#FFF95757$��2��._��� -    ��Name$
 Exit��$��CLOSE��$��Center=�$��1��$��Center=�$��74��$��40��$��15(�$
��Bold"����	#00000000 � Cursor$
 Hand�����	#FFFBFBFB���	#00000000