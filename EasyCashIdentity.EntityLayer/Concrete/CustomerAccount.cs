﻿using EasyCashIdentity.CoreLayer.EasyCashIdentity.EntityLayer.Abstract;

namespace EasyCashIdentity.EntityLayer.Concrete
{
    public class CustomerAccount : IEntity
    {
        public int Id { get; set; }
        public string CustomerAccountNumber { get; set; }
        public string CustomerAccountCurrency { get; set; }
        public decimal CustomerAccountBalance { get; set; }
        public string BankBranch { get; set; }
        public bool Status { get; set; }

        #region Table relationship
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        #endregion
    }
}