   M S B A M L   `   `   `  ����G  CKolokvijum19, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Kolokvijum19Kolokvijum19  5   	       Kolokvijum19.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Kolokvijum19     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	         prikaziFirme �� Orientation  prikaziPoPopustu��%�  &	        &	 �     �� 5
   
   .R�5      �� $ 
Horizontal=�6   .+�5      �� ��6   �� *Naziv+�� 5      $	�� - ��6   �� 5      $��Italic$�6   ��6/   �� *	Sediste+5      5      �� 5   
   .R�5      �� $ 
Horizontal=�6   .+�5      �� ��6   �� *
PacijentID+�� 5      $��, ��6   �� 5      ��6   �� *Naziv+�� 5      $��, ��6   �� 5      $
��Bold"�6   ��6.   �� *Popust+5      5      5      .��5      � .+�5   
   o� $��0,0,676.6,396q�6   .@�5      m� -   5        $��RadSaPacijentima��5      $��Rad sa pacijentima��6/   .@�5      m� -   5        $��	UnosNovog��5      $��
Unos novog��6,   6@   5      5       �� 5!   
   $
��Left=�6   $��	11,63,0,0q�6/   $
��Wrap=�6B   $��Izaberi firme��6V   $	��Top=�6k   �� 5"   
   -   5         ��Name$ cmbFirme��5"      #��[  6%   $
��Left=�6R   $��
115,64,0,0q�6m   $	��Top=�6�   $	��120��6�   6�   &   System.Windows.Controls.DataGrid  5#   
   -   5        $��grid1��5#         AutoGenerateColumns .  $
��Left=�6<   $	��171��6W   $��
11,119,0,0q�6d   $	��Top=�6x   $	��384��6�    � ContextMenu 5$      �� 5%      .@�5&      m� -   5        $��Unesi novi popust��5&      6:   m� 5'      -   5        $��	meniBrisi��5'   9   $��Obrisi pacijenta��6   
 � Tag 6J   ��  �� ElementName$ grid1�� �� Path$ SelectedItem.Sifra�5(      	   Columns	 5*      0  *System.Windows.Controls.DataGridTextColumn  5+      ,  &System.Windows.Controls.DataGridColumn
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 100 6=      Header$	 Ime��6I   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *Ime+6I     5,      $	
 110 6A   $ Prezime��6M    6%   �� *	Prezime+6M     5-      $	
 200 6E   $ Datum izmene��6Q    6%   �� *DatumIzmene+6Q      RowDetailsTemplate 5/      �� 50      .R�51      �� $��0q�6   
������� �� Padding$ 10q�6M   ._�52      �  � ColumnDefinitions 53      �� 54   "   $	��100 �63   �� 55   "   $	��100 �63    � RowDefinitions 57      �� 58   "   $
��Auto �60   �� 59   "   $
��Auto �60   �� 5:   "   $
��Auto �60   .+�5<      �� $��0��6(   $��0��65   $��Naziv paketa��6E   $��10,0,0,0q�6Y   $��Center=�6k   $
��Left=�6�   �� 5=       �� 
IsReadOnly . $��0��68   $��1��6E   $��1q�6U   $��35��6`   ��6o   �� $ Naziv� �� Mode$ OneWay=��� 5>      $��1��6(   $��0��65   $��Cena paketa��6E   $��10,0,0,0q�6X   $��Center=�6j   $
��Left=�6�   �� 5?       . $��1��68   $��1��6E   $��1q�6U   $��35��6`   ��6o   �� $
 Cena�$ OneWay=��� 5@      $��2��6(   $��0��65   $��Popust��6E   $��10,0,0,0q�6S   $��Center=�6e   $
��Left=�6�   �� 5A       . $��2��68   $��1��6E   $��1q�6U   $��35��6`   ��6o   �� $ Popust�$ OneWay=�5B      5C      5D      5F      �� 5G   
   $
��Left=�6   $��
15,297,0,0q�6/   $
��Wrap=�6C   $��Ukupno��6W   $	��Top=�6e   �� 5H   
   -   5        $��	txtUkupno��5H      $
��Left=�6#   $��23��6>   $��
68,296,0,0q�6J    �� TextWrapping$
 Wrap=�6^   $	��Top=�6r   $��49��6�   	� 5I   
   -   5        $��rbMax��5I      $��Maksimalni popust��6#   $
��Left=�6?   $��
50,344,0,0q�6Z   $	��Top=�6n   6�   	� 5J   
   -	   5        $��rbMin��5J      $��Minimalni popust��6#   $
��Left=�6>   $��
50,378,0,0q�6Y   $	��Top=�6m   6�   �� 5K   
   -
   5        $��	lbPopusti��5K      #��[ 6#   $
��Left=�6T   $��84��6o   $��193,326,0,0q�6{   $	��Top=�6�   $	��183��6�   �� 5L   
   -   5        $��gbPopust��5L      $��Novi popust��6#   $
��Left=�68   $	��147��6S   $��483,119,0,0q�6`   $	��Top=�6u   $	��223��6�   .��5M      � .+�5N      �� $
��Left=�6   $��2,22,0,0q�67   $
��Wrap=�6I   $��Sifra pacijenta��6]   $	��Top=�6t   �� 5O      -   5        $��txtSifraPacijenta��5O      $
��Left=�63   $��23��6N   $��	81,21,0,0q�6Z   $
 Wrap=�6m   $	��Top=�6�   $	��120��6�   �� 5P      $
��Left=�6   $��2,65,0,0q�67   $
��Wrap=�6I   $��Novi popust��6]   $	��Top=�6p   �� 5Q      -   5        $��txtNoviPopust��5Q      $
��Left=�6/   $��23��6J   $��	81,65,0,0q�6V   $
 Wrap=�6i   $	��Top=�6}   $	��120��6�   �� 5R      -   5        $��	btnIzmeni��5R      $��Izmeni��6*   $
��Left=�6;   $��	57,99,0,0q�6V   $	��Top=�6i   $��75��6�   6�   5S      5T      5U      5V      