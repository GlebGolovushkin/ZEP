//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZepProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class Object_Library
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Object_Library()
        {
            this.Object = new HashSet<Object>();
            this.Object_Library1 = new HashSet<Object_Library>();
            this.Variation_Object = new HashSet<Variation_Object>();
        }
    
        public int Object_Library_Id { get; set; }
        public string Object_Library_Name { get; set; }
        public string Object_KKS { get; set; }
        public Nullable<int> Parent_Object_Id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Object> Object { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Object_Library> Object_Library1 { get; set; }
        public virtual Object_Library Object_Library2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Variation_Object> Variation_Object { get; set; }
    }
}
