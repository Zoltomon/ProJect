   M S B A M L   `   `   `  ????J  FShippingCompany, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:ShippingCompany.PageShippingCompany.Page  5      %    ShippingCompany.Page.ClientUser   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:ShippingCompany.Page     5        N? Title$  
ClientUser??5	      .??5      ?  ? RowDefinitions 5   
   ?? 5      $??50 ?6   ?? 5      $??* ?6   ?? 5      $??50 ?6   .+?5   
   &   System.Windows.Controls.DataGrid  -   5        $??GridList??5         AutoGenerateColumns .     
IsReadOnly . $??1??5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 ИД??6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 61   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   ?? *
IdCruise+  5      $ Путь рейса??6%   $ * 69    6C   ?? *
NameCruise+  5      $ Цена??6%   $ * 63    6=   ?? *PriceCruise+  5      $! Время отплытия??6%   $ * 6=    6G   ?? *	TimeArr+  5      $! Время отплытия??6%   $ * 6=    6G   ?? *
ShipName+  5      $ Дней в пути??6%   $ * 6:    6D   ?? *
TimeTravel+4  .System.Windows.Controls.DataGridTemplateColumn  5      $ Действие??6)   $ * 5   )      CellTemplate 5      ?? 5       .R?5!      ? .+?5"   "   ?? 	 ?? Orientation$	 Vertical=?6-   .+?5#   &   ?? $??BtnBuy??5%   )   -   5         
  BtnAll#??[  5$   )   $??Купить??5'   )   5)   #   5*      5+      5-      5/      ?? 50   
   $	 
Horizontal=?6   .+?51      ?? -   5        $??BtnBack??51   E   $??
Назад??6   #??[  6%   $	??200??6j   52      ?? 53   
   $??3??6   $	 
Horizontal=?6"   $??Right=?6;   .+?54      ?? $0??*Введите название рейса??6   $??0q?67   .??55      ?? -   5        $??TxbNameCruise??55      $	??100??6/   56      ?? 57      -   5        
 ??Name$
 	BtnSearch??57   %   $??
Найти??6   $??Right=?68   #??[  6l   $	??100??6?   $
??3,10q?6?   58      ?? 59   
   $??3??6   $	 
Horizontal=?6"   $
??Left=?6;   .+?5:      ?? -   5        $??BtnVeryMoney??5:   R   $(??"Самый дорогой рейс??6   #??[  62   6f   5;      5<      5=      