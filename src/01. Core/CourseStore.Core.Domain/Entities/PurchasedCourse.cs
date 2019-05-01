﻿using Newtonsoft.Json;
using System;

namespace CourseStore.Core.Domain.Entities
{
    public class PurchasedCourse : BaseEntity
    {
        public virtual long CourseId { get; set; }

        public virtual Course Course { get; set; }

        public virtual long CustomerId { get; set; }

        public virtual decimal Price { get; set; }

        public virtual DateTime PurchaseDate { get; set; }

        public virtual DateTime? ExpirationDate { get; set; }
    }
}
