﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories_Do_An.DBcontext_vs_Entities
{
    [Table("Contract")]
    public class Contract
    {
        [Key, Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ContractId { get; set; }
        [ForeignKey("Order")]
        public int? OrderId { get; set; }
        public virtual Order order { get; set; }
        public string? ContractFileLink {  get; set; }
        [ForeignKey("Cusustomer")]
        public int? CustomerId { get; set; }
        public virtual Customer customer { get; set; }
        public int? DeliveryId { get; set; }
        [ForeignKey("Role")]
        public int? RoleId { get; set; }
        public virtual Role role { get; set; }
        [ForeignKey("ContractType")]
        public int? ContractTypeId { get; set; }
        public virtual ContractType contractType { get; set; }
        public bool? Status { get; set; }
    }
}
