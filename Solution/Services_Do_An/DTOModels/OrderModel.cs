﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Repositories_Do_An.DBcontext_vs_Entities
{

    public class OrderModel
    {
        public int OrderId { get; set; }
        public string? orderName { get; set; }
        public int CustomerId { get; set; }
        //public int StaffIdId { get; set; }
        public int? OVIId { get; set; }
        public DateOnly? OrderedDate { get; set; }
        public DateOnly? ArrivedDate { get; set; }
        public Double? TotalAmount { get; set; }
        public int? PostionComeId { get; set; }
        public int? PostionGoId { get; set; }
        //public string paymentMethod { get; set; } = "Tài xế và khách hàng tự làm việc với nhau";
        public int? BussinessId { get; set; }
        public bool? Status { get; set; }
    }
}
