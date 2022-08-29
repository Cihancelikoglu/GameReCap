using GameReCap.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameReCap
{
    public class Member : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalityId { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
