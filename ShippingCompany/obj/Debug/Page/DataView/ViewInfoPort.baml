   M S B A M L   `   `   `  ????J  FShippingCompany, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:ShippingCompany.Page.DataViewShippingCompany.Page.DataView  5      0    *ShippingCompany.Page.DataView.ViewInfoPort   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      =local+clr-namespace:ShippingCompany.Page.DataView     5        N? Title$  ViewInfoPort??5	      .??5      ?  ? RowDefinitions 5   
   ?? 5      $??50 ?6   ?? 5      $??* ?6   ?? 5      $??50 ?6   .+?5   
   &   System.Windows.Controls.DataGrid  -   5        $??GridList??5         AutoGenerateColumns .     
IsReadOnly . $??1??5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 ИД??6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 61   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   ?? *PortId+  5      $) #Наименование порта??6%   $ * 6A    6K   ?? *
NamePort+4  .System.Windows.Controls.DataGridTemplateColumn  5      $ Действие??6)   $ * 5   )      CellTemplate 5      ?? 5      .R?5      ? .+?5   "   ?? 	 ?? Orientation$	 Vertical=?6-   .+?5   &   ?? $??	BtnDelete??5!   )   -   5         
  BtnAll#??[  5    )   $??Удалить??5#   )   5$   #   5%      5&      5(      5*      ?? 5+   
   $	 
Horizontal=?6   $??0??6.   .+?5,      ?? -   5        $??BtnBack??5,   m   $??
Назад??6   $	??200??6%   #??[  61   $??Right=?6Q   6|   5-      ?? 5.   
   $??3??6   $	 
Horizontal=?6"   .+?5/      ?? -   5        $??	BtnCreate??5/   t   $??Добавить порт??6   $	??200??6-   #??[  69   $
??Left=?6Y   6?   50      ?? 51   
   $??3??6   $	 
Horizontal=?6"   $??Right=?6;   .+?52      ?? $??Введите Id??6   $??0q?6+   .??53      ?? -   5        $??	TxbIdPort??53      $	??100??6+   54      ?? 55      -   5        
 ??Name$
 	BtnSearch??55   %   $??
Найти??6   $??Right=?68   #??[  6l   $	??100??6?   $
??3,10q?6?   56      57      58      