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
    
    public partial class Department_Object
    {
        public Nullable<int> Department_Id { get; set; }
        public Nullable<int> Object_Id { get; set; }
        public int Department_Object_Id { get; set; }
    
        public virtual Department Department { get; set; }
        public virtual Object Object { get; set; }
    }
}