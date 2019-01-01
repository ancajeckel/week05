﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarStoreApp.Interfaces;

namespace CarStoreApp.Models
{
    public class Producer : IProducer
    {
        public string Name { get; set; }

        public string Address { get; set; }
    }
}
