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
    
    public partial class Object
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Object()
        {
            this.Department_Object = new HashSet<Department_Object>();
            this.Object_Document = new HashSet<Object_Document>();
            this.Object_Object = new HashSet<Object_Object>();
            this.Object_Object1 = new HashSet<Object_Object>();
            this.Station_Object = new HashSet<Station_Object>();
        }
    
        public int Object_Id { get; set; }
        public Nullable<int> Object_Library_Id { get; set; }
        public Nullable<int> Place_Id { get; set; }
        public Nullable<int> Amount { get; set; }
        public Nullable<int> Variaton_Id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Department_Object> Department_Object { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Object_Document> Object_Document { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Object_Object> Object_Object { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Object_Object> Object_Object1 { get; set; }
        public virtual Object_Library Object_Library { get; set; }
        public virtual Place Place { get; set; }
        public virtual Variation Variation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Station_Object> Station_Object { get; set; }
    }
}