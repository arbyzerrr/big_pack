   M S B A M L   `   `   `  ????B  >BigPack, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:BigPackBigPack  5      !    BigPack.SupplierAddEditPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:BigPack     5        N? Title$  SupplierAddEditPage??5	      .??5      ?  ? ColumnDefinitions 5   
   ?? 5      $	??200 ?6   ?? 5      $??* ?6    ? RowDefinitions 5   
   ?? 5      $??* ?6   ?? 5      $??* ?6   ?? 5      $??* ?6   ?? 5      $??* ?6   ?? 5      $??* ?6   ?? 5      $??* ?6   .+?5   
   ?? $??Наименование??6   $??Center=?6(   $??Center=?6C   6b   ?? 5   
   $??Тип??6   $??Center=?6   $??Center=?6:   $??1??6W   6f   ?? 5   
   $??ИНН??6   $??Center=?6   $??Center=?6:   $??2??6W   6f   ?? 5   
   $%??Рейтинг качества??6   $??Center=?6,   $??Center=?6G   $??3??6d   6s   ?? 5   
   $(??"Дата начала работы??6   $??Center=?6.   $??Center=?6I   $??4??6f   6u   ?? 5   
   $??1??60   $	??500??6@   $
??Left=?6L   $??30??6g   $??10,0,0,0q?6s    ?? 	MaxLength$	 100??6?   ??6   ?? *Наименование+6?   ?? 5   
   -   5         ??Name$ ComboCountries??5   ?   $??1??60   $??1??6@   $	??290??6M   $
??Left=?6Y   $??30??6t    ?? DisplayMemberPath$ Тип??6?   $??10,0,0,0q?6?    ?? SelectedItem 6   ?? *Тип+6?   ?? 5   
   $??1??6'   $??2??67   $	??232??6D   $
??Left=?6P   $??30??6k   $??10,0,0,0q?6w   ??6   ?? *ИНН+6?   ?? 5    
   $??1??64   $??3??6D   $	??232??6Q   $
??Left=?6]   $??30??6x   $??10,0,0,0q?6?   ??6   ?? *!Рейтинг_качества+6?   (  "System.Windows.Controls.DatePicker  5!   
   -   5          Name$ DPickerSupllier??5!         IsDropDownOpen . 	   SelectedDateFormat$	 Short=?6i   $??1??6?   $
??Left=?6?   $??4??6?   $??Center=?6?   $??35??6?   $	??445??6?   $??10,0,0,0q?6?   
   Text
 6.   ?? *$"Дата_начала_работы+6?   ?? 5"   
   -   5         ??Name$ BtnSave??5"      $??1??6"   $??5??62   $??Сохранить??6U   6k   5#      5$      