   M S B A M L   `   `   `  ????B  >BigPack, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:BigPackBigPack  5          BigPack.MasterPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:BigPack     5        N? Title$  
MasterPage??5	      .??5      ?  ? ColumnDefinitions 5   
   ?? 5      $	??200 ?6   ?? 5      $??* ?6    ? RowDefinitions 5   
   ?? 5      $??* ?6   ?? 5      $??* ?6   ?? 5      $??* ?6   .+?5   
   ?? $??ID_Цеха??6   $??Center=?6#   $??Center=?6>   6]   ?? 5   
   $??ID_Мастера??6   $??Center=?6&   $??Center=?6A   $??1??6^   6m   ?? 5   
   -   5         ??Name$ ComboMaster??5       ?? DisplayMemberPath$ Наименование??6E   $??1??6f   $??0??6v   $	??232??6?   $
??Left=?6?   $??30??6?   $??10,0,0,0q?6?    ?? SelectedItem 6(   ?? *Цех+6?   ?? 5   
   $??1??6.   $??1??6>   $	??232??6K   $
??Left=?6W   $??30??6r   $??10,0,0,0q?6~   ??6   ?? *ID_мастера+6~   ?? 5   
   -   5         ??Name$ BtnSave??5      $??1??6"   $??2??62   $??Сохранить??6U   6k   5      5      