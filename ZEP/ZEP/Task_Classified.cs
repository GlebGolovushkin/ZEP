//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZEP
{
    using System;
    using System.Collections.Generic;
    
    public partial class Task_Classified
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Task_Classified()
        {
            this.Model_Object_Task = new HashSet<Model_Object_Task>();
        }
    
        public int ID { get; set; }
        public int Task { get; set; }
        public Nullable<int> Task_Code_1 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Model_Object_Task> Model_Object_Task { get; set; }
        public virtual Task Task1 { get; set; }
        public virtual Task_Classificator Task_Classificator { get; set; }
    }
}