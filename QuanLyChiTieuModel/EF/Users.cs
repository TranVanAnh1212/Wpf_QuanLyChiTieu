//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyChiTieuModel.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Users
    {
        public int u_id { get; set; }
        public Nullable<System.DateTime> u_birth { get; set; }
        public string u_Avatar_URL { get; set; }
        public string u_Address { get; set; }
        public int AccID { get; set; }
    
        public virtual Accounts Accounts { get; set; }
    }
}
