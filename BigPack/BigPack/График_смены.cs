//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BigPack
{
    using System;
    using System.Collections.Generic;
    
    public partial class График_смены
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public График_смены()
        {
            this.Производство = new HashSet<Производство>();
            this.Сотрудник = new HashSet<Сотрудник>();
        }
    
        public int ID { get; set; }
        public Nullable<int> ID_мастера { get; set; }
        public Nullable<int> ID_цеха { get; set; }
    
        public virtual Мастер_смены Мастер_смены { get; set; }
        public virtual Цех Цех { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Производство> Производство { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Сотрудник> Сотрудник { get; set; }
    }
}
