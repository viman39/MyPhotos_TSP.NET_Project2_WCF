//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyPhotosService
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tag
    {
        public int id { get; set; }
        public string tag { get; set; }
        public int idFile { get; set; }
    
        public virtual File File { get; set; }
    }
}