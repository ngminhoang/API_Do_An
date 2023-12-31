﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories_Do_An.DBcontext_vs_Entities
{
    [Table("Invoice")]
    public class Invoice
    {
        [Key, Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InvoiceId { get; set; }
        [ForeignKey("Order")]
        public int? OrderId { get; set; }
        public virtual Order order { get; set; }
        public bool? Status { get; set; }
        [StringLength(250)]
        public string? Description { get; set; }
        public DateTime? Date {  get; set; }
    }
}
