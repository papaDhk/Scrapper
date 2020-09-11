﻿using Domain.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Response : Entity<Response>
    {
        public List<Review> Reviews { get; set; } = new List<Review>();

        public ResponseStatusEnum ResponseStatus { get; set; } = ResponseStatusEnum.Failure;

        public string Message { get; set; }

        public DateTime Date { get; set; }

        protected override bool EqualsCore(Response obj)
        {
            throw new NotImplementedException();
        }

        protected override int GetHashCodeCore()
        {
            throw new NotImplementedException();
        }
    }
}
