   M S B A M L   `   `   `  ????J  FShippingCompany, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:ShippingCompany.Page.DataViewShippingCompany.Page.DataView  5      2    ,ShippingCompany.Page.DataView.DataViewCruise   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      =local+clr-namespace:ShippingCompany.Page.DataView     5        N? Title$  DataViewCruise??5	      .??5      ?  ? RowDefinitions 5   
   ?? 5      $??50 ?6   ?? 5      $??* ?6   ?? 5      $??50 ?6   .+?5   
   &   System.Windows.Controls.DataGrid  -   5        $??GridListCruise??5         AutoGenerateColumns .     
IsReadOnly . $??1??5      
???????   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 ИД??6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 61   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   ?? *
IdCruise+  5      $ Путь??6%   $ * 63    6>   ?? *
NameCruise+  5      $ Цена??6%   $ * 63    6=   ?? *PriceCruise+  5      $ Тип корабля??6%   $ * 6:    6E   ?? *
ShipName+4  .System.Windows.Controls.DataGridTemplateColumn  5      $ Действие??6)   $ * 5   )      CellTemplate 5      ?? 5      .R?5       ? .+?5!   "   ?? 	 ?? Orientation$	 Vertical=?6-   .+?5"   &   ?? $??	BtnDelete??5$   )   -   5         
  BtnAll#??[  5#   )   $??Удалить??5&   )   5'   #   5(      5)      5+      5-      ?? 5.   
   $	 
Horizontal=?6   .+?5/      ?? -   5        $??BtnBack??5/   m   $??
Назад??6   #??[  6%   $	??200??6E   $??Right=?6Q   6|   50      ?? 51   
   $	 
Horizontal=?6   $??2??6.   .+?52      ?? -   5        $??BtnCreateCruise??52   u   $!??Добавить круиз??6   #??[  6.   $	??200??6N   $
??Left=?6Z   6?   ?? 53      -   5        $??BtnAll??53   Y   $??Выделить все??6   #??[  6-   $	??200??6M   6g   ?? 54      -   5        $??	BtnNotAll??54   \   $#??Снять выделение??6   #??[  60   $	??200??6P   6m   55      ?? 56   
   $??3??6   $	 
Horizontal=?6"   $??Right=?6;   .+?57      ?? $??Введите Id??6   $??0q?6+   .??58      ?? -   5        $??TxbIdCruise??58      $	??100??6-   59      ?? 5:      -   5        
 ??Name$
 	BtnSearch??5:   %   $??
Найти??6   $??Right=?68   #??[  6l   $	??100??6?   $
??3,10q?6?   5;      5<      5=      