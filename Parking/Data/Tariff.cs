﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Parking.Data
{
    public class Tariff
    {
        public Tariff()
        {
            Keys = new List<Key>();
        }
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }

        public ICollection<Key> Keys { get; set; }
    }
}
