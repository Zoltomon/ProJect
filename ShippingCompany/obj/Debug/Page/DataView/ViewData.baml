   M S B A M L   `   `   `  ????J  FShippingCompany, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:ShippingCompany.PageShippingCompany.Page  5      #    ShippingCompany.Page.ViewData   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:ShippingCompany.Page     5        N? Title$.  (Информация о клиентах??5	      .??5      ?  ? RowDefinitions 5   
   ?? 5      $??50 ?6   ?? 5      $??* ?6   ?? 5      $??50 ?6   .+?5   
   &   System.Windows.Controls.DataGrid  -   5        $??GridList??5         AutoGenerateColumns .     
IsReadOnly . $??1??5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 ИД??6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 61   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   ?? *IdUser+  5      $ 
Логин??6%   $ * 64    6>   ?? *	LoginUser+  5      $ Роль??6%   $ * 63    6>   ?? *
RoleUser+  5      $ Имя??6%   $ * 62    6<   ?? *
UserName+  5      $ Фамилия??6%   $ * 66    6@   ?? *SurnameUser+  5      $ Отчество??6%   $ * 67    6A   ?? *
UserPatr+  5      $ Телефон??6%   $ * 66    6@   ?? *UserTelephone+4  .System.Windows.Controls.DataGridTemplateColumn  5      $ Действие??6)   $ * 5   )      CellTemplate 5       ?? 5!      .R?5"      ? .+?5#   "   ?? 	 ?? Orientation$	 Vertical=?6-   .+?5$   &   ?? $??
BtnAddUser??5&      -   5         
  BtnAll#??[  5%      $	??100??5(   )   $ ??Редактировать??5)      5*   #   5+      5,      5.      50      ?? 51   
   $	 
Horizontal=?6   $??0??6.   .+?52      ?? -   5        $??	BtnReload??52   T   $??Обновить??6   #??[  6(   $	??200??6H   6e   ?? 53      -   5        $??BtnBack??53   m   $??
Назад??6   #??[  6%   $	??200??6E   $??Right=?6Q   6|   54      ?? 55   
   $??3??6   $	 
Horizontal=?6"   .+?56      ?? -   5        $??	BtnCreate??56   |   $/??)Добавить пользователя??6   #??[  65   $	??200??6U   $
??Left=?6a   6?   58      ?? 59   
   $??3??6   $	 
Horizontal=?6"   $??Right=?6;   .+?5:      ?? $??Введите Id??6   $??0q?6+   .??5;      ?? -   5        $??	TxbIdUser??5;      $	??100??6+   5<      ?? 5=      -   5        
 ??Name$
 	BtnSearch??5=   %   $??
Найти??6   $??Right=?68   #??[  6l   $	??100??6?   $
??3,10q?6?   5>      5?      5@      