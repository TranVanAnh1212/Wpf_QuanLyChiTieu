﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class QuanLiChiTieu_V2Entities : DbContext
    {
        public QuanLiChiTieu_V2Entities()
            : base("name=QuanLiChiTieu_V2Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Accounts> Accounts { get; set; }
        public virtual DbSet<ExpenseCategories> ExpenseCategories { get; set; }
        public virtual DbSet<Fml_ExpenseInfo> Fml_ExpenseInfo { get; set; }
        public virtual DbSet<Fml_Expenses> Fml_Expenses { get; set; }
        public virtual DbSet<Images> Images { get; set; }
        public virtual DbSet<Psn_ExpenseInfo> Psn_ExpenseInfo { get; set; }
        public virtual DbSet<Psn_Expenses> Psn_Expenses { get; set; }
        public virtual DbSet<RevenueCategories> RevenueCategories { get; set; }
        public virtual DbSet<RevenueInfo> RevenueInfo { get; set; }
        public virtual DbSet<Revenues> Revenues { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Videos> Videos { get; set; }
    
        public virtual ObjectResult<USP_LOGIN_Result> USP_LOGIN(string accName, string accPassword)
        {
            var accNameParameter = accName != null ?
                new ObjectParameter("accName", accName) :
                new ObjectParameter("accName", typeof(string));
    
            var accPasswordParameter = accPassword != null ?
                new ObjectParameter("accPassword", accPassword) :
                new ObjectParameter("accPassword", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_LOGIN_Result>("USP_LOGIN", accNameParameter, accPasswordParameter);
        }
    
        public virtual int USP_UpdateAccount(string accID, string accDisplayName, string accNewPassword, string accPasswordConfirm)
        {
            var accIDParameter = accID != null ?
                new ObjectParameter("AccID", accID) :
                new ObjectParameter("AccID", typeof(string));
    
            var accDisplayNameParameter = accDisplayName != null ?
                new ObjectParameter("AccDisplayName", accDisplayName) :
                new ObjectParameter("AccDisplayName", typeof(string));
    
            var accNewPasswordParameter = accNewPassword != null ?
                new ObjectParameter("AccNewPassword", accNewPassword) :
                new ObjectParameter("AccNewPassword", typeof(string));
    
            var accPasswordConfirmParameter = accPasswordConfirm != null ?
                new ObjectParameter("AccPasswordConfirm", accPasswordConfirm) :
                new ObjectParameter("AccPasswordConfirm", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_UpdateAccount", accIDParameter, accDisplayNameParameter, accNewPasswordParameter, accPasswordConfirmParameter);
        }
    }
}
