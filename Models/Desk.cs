using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResturantUsingMvcEtLts.Models
{
    public class Desk
    {
        public Desk(int id, int number, int size, bool isFree, int numberOfSeet)
        {
            Id = id;
            Number = number;
            Size = size;
            IsFree = isFree;
            NumberOfSeet = numberOfSeet;
        }

        public int Id { get; set; }
        public int Number { get; set; }
        public int Size { get; set; }
        public bool IsFree { get; set; }
        public int NumberOfSeet { get; set; }
    }
}