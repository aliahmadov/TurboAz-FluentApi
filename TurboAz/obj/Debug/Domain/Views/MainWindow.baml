   M S B A M L   `   `   `  ????B  >TurboAz, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:TurboAzTurboAz  5   	       TurboAz.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:TurboAz     5   	   _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  6-     ? Title$  
MainWindow??5   	   $	??600??6   $	??800??6)   .??5	      ?  ? RowDefinitions 5
   
   ?? 5      $??0.35* ?6   6-   ?? 5      $
??1.5* ?6   6,   ?? 5      $??* ?6   6)   .+?5   
   ?? .+?5      ?? $??10q?6   $??40(?6$   $??Comic Sans MS)?62   
??? E??$??DemiBold"?5   /   
Car Search6Q   5      ?? 5   
   $??1??6   $??Center=?6"   $??Center=?6=   .+?5      ?? 
???   ?$??1q?6)    ?? Padding$ 10q?6=   ._?5      ??  ?? Orientation$ 
Horizontal=?6   .+?5      ?? $??20(?6    $??5,0,10,0q?6.   Color6H   ?? 5      -   5        $??	colorCmbx??5      $	??100??60   ??6<   ?? *Colors+ ?? SelectedItem 5      ?? *SelectedColor+ ?? Mode$ TwoWay=? ?? UpdateSourceTrigger$ PropertyChanged=?5      ?? 5      $??20(?6    $??5,0,10,0q?6.   	BanType6I   ?? 5      -   5        $??banCmbx??5      $	??100??6.   ??6:   ?? *
BanTypes+ 5       ?? *SelectedBan+$ TwoWay=?$ PropertyChanged=?5"      ?? 5$      $??20(?6    $??5,0,10,0q?6.   Model6G   ?? 5%      -   5        $??	modelCmbx??5%      $	??100??60   ??6<   ?? *Models+ 5&      ?? *SelectedModel+$ TwoWay=?$ PropertyChanged=?5(      ?? 5*      $??20(?6    $??5,0,10,0q?6.   Energy Type6M   ?? 5+      -   5        $??
energyCmbx??5+      $	??100??61   ??6=   ?? *EnergyTypes+ 5,   !   ?? *SelectedEnergyType+$ TwoWay=?$ PropertyChanged=?5.      5/      50      ?? 52      $??0,20,0,0q?6   $ 
Horizontal=?6+   .+?53      ?? $??35,0,0,0q?6   
???   ?$??1q?6?   $ 5q?6S   ._?54      ?? $ 
Horizontal=?6!   .+?55      ?? $??20(?6$   $??5,0,10,0q?62   
Min.Year6N   ?? 56      $??55??6m   ??6"   ?? *	MinYear+$ TwoWay=?$ PropertyChanged=?6z   ?? 58      $??20(?6$   $??	10,0,10,0q?62   
Max.Year6O   ?? 59      $??55??6m   ??6"   ?? *	MaxYear+$ TwoWay=?$ PropertyChanged=?6z   5:      5;      ?? 5=      $??25,0,0,0q?6   
???   ?$??1q?6?   $ 5q?6S   ._?5>      ?? $ 
Horizontal=?6!   .+?5?      ?? $??20(?6$   $??5,0,10,0q?62   	Min.Price6O   ?? 5@      $??55??6n   ??6"   ?? *
MinPrice+$ TwoWay=?$ PropertyChanged=?6{   ?? 5B      $??20(?6$   $??	10,0,10,0q?62   	Max.Price6P   ?? 5C      $??55??6n   ??6"   ?? *
MaxPrice+$ TwoWay=?$ PropertyChanged=?6{   5D      5E      5F      ?? 5H      $??0,20,0,0q?6   $ 
Horizontal=?6+   $??Center=?6D   .+?5I      ?? $??25,0,0,0q?6   
???   ?$??1q?6?   $ 5q?6S   ._?5J      ?? $ 
Horizontal=?6!   .+?5K      ?? $??20(?6$   $??5,0,10,0q?62   Min.Distance6R   ?? 5L      $??55??6q   ??6"   ?? *MinDistance+$ TwoWay=?$ PropertyChanged=?6~   ?? 5N      $??20(?6$   $??	10,0,10,0q?62   Max.Distance6S   ?? 5O      $??55??6q   ??6"   ?? *MaxDistance+$ TwoWay=?$ PropertyChanged=?6~   5P      5Q      5R      ?? 5T      $??0,20,0,0q?6   $ 
Horizontal=?6,   $??Center=?6E   .+?5U      ?? 
???   ?$??1q?6-   ._?5V      ?? $ 
Horizontal=?6!   .+?5W      	? $??Center=?6?   $??20(?6?   $??5q?6?    d? 	IsChecked 6&   ?? *IsNew+$ TwoWay=?$ PropertyChanged=???6t   ?? *
NewCommand+.??6?   New6?   	? 5X      $??Center=?6t   $??20(?6?   $??5q?6?    6&   ?? *IsOld+$ TwoWay=?$ PropertyChanged=?.??6?   Old6?   5Y      5Z      5\      ?? 5]      $??10,20,10,10q?6   $??Center=?6.   $??Center=?6K   $ 
Horizontal=?5^      .+?5_      ?? $??	15,5,15,5q?6   
???????
??? E??$??20(?6W   $??DemiBold"?5`      ??6/   ?? *ShowCommand+.??6O   	Show Cars ? 	Resources 5b      	 ?? 
TargetType
 ?? Property ?? Value??%h   '??       ?? 5c      "	 ??6    .?5d      ?? 
 ?@??CornerRadius$ 10??6=   5f      5g      5h      5i      ?? 5k      $??	15,5,15,5q?6   
???????
??? E??$??20(?6W   $??DemiBold"?5l      $??10,0,0,0q?6P   ??6/   ?? *ClearCommand+.??6b   	Clear All 5n      ??%h   '??       ?? 5o      "	 ??6    .?5p      ?? 
 ?@??CornerRadius$ 10??6=   5r      5s      5t      5u      5v      5w      ?? 5z   
   $??2??6   .??5{      ? -   5        $??carWrapPanel??5{      $??Center=?6,   5}      5~      5      5?      