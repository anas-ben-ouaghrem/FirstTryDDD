﻿using FirstTryDDD.Core.AggregateModels.BookAggregate;
using FirstTryDDD.SharedKernel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTryDDD.Core.AggregateModels.AuthorAggregate
{
    public class Author : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int? Age { get; set; }

        //*** other relationships

        public ICollection<Book> Books { get; set; }
    }
}
