   M S B A M L   `   `   `  ????J  FShippingCompany, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ShippingCompanyShippingCompany  5   	        ShippingCompany.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:ShippingCompany     5   	     ? Title$+  %Судоходная компания??5   	   $	??450??6%   $
??1000??62   .??5	      ?  ? ColumnDefinitions 5   
   ?? 5      $	??200 ?6   ?? 5      $??* ?6   ??5   
   ?? 5       ?? Color$ Azure??6    ?? Opacity$	 0.2Q?6,   .+?5   
   ?? $+??%Судоходная компания??6   $??16(?6/   $
??Left=?5      $??2q?63    ? 5   
   -   5        $??FrmMain??5      $??1??5        ? NavigationUIVisibility$ Hidden=?5      ?? 5   
   
???   ?$??1q?6%   $??0??69   ??5      ?? 5      .??5       ?  ? Color$ #2A2A72??6#    ? Offset$	 0.5Q?63   ? 5!      $ #00cdac??6#   $	 1.0Q?63   5"      5$      ?? 5&   
   $??0??6    ?? Orientation$ Vertical=?6%   .+?5'      ?? $??./Source/logoicon.png??6   $	??100??5(      5)      ?? 5+   
   $??0??6   $??Center=?6%   .+?5,      &   System.Windows.Controls.Calendar  -   5          Name$ 	calendar1??5,      	   FirstDayOfWeek$	 Monday=?6.   
   BlackoutDates
 5.      /  )System.Windows.Controls.CalendarDateRange  5/         Start$ 	10/5/2013??6,   
   End$ 	10/8/2013??6>   6Q   51      52      ?? 54      $??0??6   $ Vertical=?6)   $??Bottom=?6@   .+?55      ?? -   5        $??
TxtTimeNow??56         
TxtBlkTime#??[  57      $
??Time??58      ?? 5:      -   5        $??TxtDataTime??5=      $
??Data??5;        
TxtBlkDate#??[ 5<      5=      5>      5@      5B      