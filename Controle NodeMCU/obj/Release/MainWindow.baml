   M S B A M L   `   `   `  ���� K  GControle NodeMCU, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Controle_NodeMCUControle_NodeMCU  !    Controle_NodeMCU.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     0localclr-namespace:Controle_NodeMCU     -     � Title$  André Lima - IoT 1.0��$��417.78��$	��525�� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ CanMinimize=�.���  � RowDefinitions �� $��64 ��� $��64 ��� $��64 ��� $��64 ��� $��64 ��� $��64 � � ColumnDefinitions �� $
��133* ��� $	��48* ��� $
��103* ��� $
��132* ��� $
��101* �.+��� -    ��Name$ txtHost��$
��Left=�$��23��$��10,4,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��113��$��1���� -    ��Name$ lHost��$
��Host��$
��Left=�$��	10,27,0,0q�$	��Top=�$��1���� -   $ txtUser��$
��Left=�$��23��$��10,4,0,0q�$
 Wrap=�$	��Top=�$	��113��$��2���� -   $ 
lHost_Copy��$��Usuário��$
��Left=�$��	10,27,0,0q�$	��Top=�$��2���� -   $ txtPassword��$
��Left=�$��23��$��10,4,0,0q�$
 Wrap=�$	��Top=�$	��113��$��3���� -   $ lHost_Copy1��$��Senha��$
��Left=�$��	10,27,0,0q�$	��Top=�$��3���� -   $ txtPort��$
��Left=�$��23��$��10,4,0,0q�$
 Wrap=�$	��Top=�$	��113��$��4���� -	   $ lHost_Copy2��$��Porta��$
��Left=�$��	10,27,0,0q�$	��Top=�$��4��	� -
    	�Name$ radioButton��$	��LED��$��2��$
��Left=�$��	10,10,0,0q�$��2��$	��Top=�	 d� 	IsChecked$
	 TrueY��� -   
 ��Name$
 bSwitch��$��Ligar��$��3��$
��Left=�$��	28,30,0,0q�$��1��$	��Top=�$��76�� � Cursor$ Arrow���� -    ��Name$ image��$��3��$
��Left=�$	��108��$��	28,10,0,0q�$��2��$��2��$	��Top=�$��76��$��Imagens/desligada.jpg��$
��Fill=��� -   $
 	bConectar��$��Conectar��$
��Left=�$��	29,22,0,0q�$	��Top=�$��75���� -   $ 	txtTopico��$
��Left=�$��23��$��10,5,0,0q�$
 Wrap=�$	��Top=�$	��113��$��5���� -   $ lHost_Copy3��$��Tópico��$
��Left=�$��	10,29,0,0q�$	��Top=�$��5���� -   $
 bMudarTopico��$��Atualizar Tópico��$
��Left=�$��0,8,0,0q�$��5��$	��Top=�$��90��$��2��$��1��