   M S B A M L   `   `   `  ????D  @FabricApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:FabricApp.Views.PagesFabricApp.Views.Pages  5      ;"clr-namespace:FabricApp.ViewModelsFabricApp.ViewModels  5      C&clr-namespace:FabricApp.Views.ElementsFabricApp.Views.Elements  5      %    FabricApp.Views.Pages.Workspace   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:FabricApp.Views.Pages     5      1vm"clr-namespace:FabricApp.ViewModels     5      5el&clr-namespace:FabricApp.Views.Elements     5        N? Title$  	Workspace??5       N? 
Background ?#242424 ? DataContext 5      -  'FabricApp.ViewModels.ViewModelWorkspace  5   
    ? 	Resources 5       ?? 
TargetType ?? Property ?? Value??%?  '??       'Q? ?     ?? 5   
   " ??5      .?5      ??  ? ??$ 30??5      ?? 5       ? ??$	 130??5      ?? 5       ? ??$ 0 5 0 0q?5      ?? 5       ? ??$ Center=?5       5!      ?? 5#   
   " Q?5$      .?5%      ??  ? ??$ Roboto)?5'      ?? 5(       ? ??$ 20(?5*      ?? 5+       ? ??
 ?????5-      ?? 5.       ? ??$ 0 5 0 0q?50      51      52      .??53      ?  ? ColumnDefinitions 54   
   ?? 55      $
??0.3* ?6   ?? 56      .+?59   
   ?? .+?5:      R? -   5         R?Name$
 Tree??5;      
?????? $??0q?5>      .@?5?      Q? $??Поставки??6   .@?5@      ?? $??
Ткани??6   $?? ??5A      ?? 5B      $??Фурнитура??6   $?? ??5C      5D      Q? 5F      $??Списание??6   .@?5G      ?? $??
Ткани??6   $?? ??5H      ?? 5I      $??Фурнитура??6   $?? ??5J      5K      Q? 5M      $"??Инвентаризация??6   .@?5N      ?? $??
Ткани??6   ??5O      ?? *commandShowCloths+?? 5P      $??Фурнитура??6   ??5Q      ?? *commandShowFurniture+5R      5S      5T      ?? 5V   
   $??1??5W      .+?5X      (   "FabricApp.Views.Elements.InputForm  	   Input	 5Y      ?? *
Elements+
 ?? UpdateSourceTrigger$
 PropertyChanged=? ?? Mode$ TwoWay=?   	ItemTitle 5Z      ?? *Title+   
ItemAmount 5[      ?? *Amount+   	ItemPrice 5\      ?? *Price+5]      5^      5_      