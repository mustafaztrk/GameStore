using GameStore.Abstract;
using GameStore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore
{
    public class Gamer:IEntity
    {
        public Gamer()
        {
            Games = new List<Game>();
        }
        public int Id { get; set; }
        public long NationalityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        public string Nick { get; set; }
        public decimal Balance { get; set; }

        public List<Game> Games;


    }
}
