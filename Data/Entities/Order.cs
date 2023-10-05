﻿using Data.Enums;

namespace Data.Entities
{
    public class Order
    {
        public string Id { get; set; }
        public int Total { get; set; }
        public string Note { get; set; }
        public string TableId { get; set; }
        public DateTime CreatedAt { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public Table Table { get; set; }
    }
}