   M S B A M L   `   `   `  ????J  FShippingCompany, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:ShippingCompany.Page.DataViewShippingCompany.Page.DataView  5      0    *ShippingCompany.Page.DataView.ViewInfoShip   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      =local+clr-namespace:ShippingCompany.Page.DataView     5        N? Title$  ViewInfoShip??5	      .??5      ?  ? RowDefinitions 5   
   ?? 5      $??50 ?6   ?? 5      $??* ?6   ?? 5      $??50 ?6   .+?5   
   &   System.Windows.Controls.DataGrid  -   5        $??GridList??5         AutoGenerateColumns .     
IsReadOnly . $??1??5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 ИД??6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 61   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   ?? *ShipId+  5      $- 'Наименование корабля??6%   $ * 6C    6M   ?? *
NameShip+  5      $ Тип корабля??6%   $ * 6:    6D   ?? *
TypeShip+  5      $. (Кол-во места в корабле??6%   $ * 6E    6O   ?? *
PlaceCount+4  .System.Windows.Controls.DataGridTemplateColumn  5      $ Действие??6)   $ * 5   )      CellTemplate 5      ?? 5      .R?5      ? .+?5    "   ?? 	 ?? Orientation$	 Vertical=?6-   .+?5!   &   ?? $??	BtnDelete??5#   )   -   5         
  BtnAll#??[  5"   )   $??Удалить??5%   )   5&   #   5'      5(      5*      5,      ?? 5-   
   $	 
Horizontal=?6   $??0??6.   .+?5.      ?? -   5        $??BtnBack??5.   M   $??
Назад??6   $	??200??6%   $??Right=?61   #??[  6r   5/      ?? 50   
   $??3??6   $	 
Horizontal=?6"   .+?51      ?? -   5        $??	BtnCreate??51   W   $%??Добавить корабль??6   $	??200??60   $
??Left=?6<   #??[  6?   52      ?? 53   
   $??3??6   $	 
Horizontal=?6"   $??Right=?6;   .+?54      ?? $??Введите Id??6   $??0q?6+   .??55      ?? -   5        $??	TxbIdUser??55      $	??100??6+   56      ?? 57      -   5        
 ??Name$
 	BtnSearch??57   %   $??
Найти??6   $??Right=?68   #??[  6l   $	??100??6?   $
??3,10q?6?   58      59      5:      