﻿using BackOfficeApi.Model.Entities.Person;

namespace BackOfficeApi.Model.Entities
{
    public class Department : BaseEntity
    {
        public Guid NaturalPersonId { get; set; }
        public virtual NaturalPerson NaturalPerson { get; set; }
    }
}
