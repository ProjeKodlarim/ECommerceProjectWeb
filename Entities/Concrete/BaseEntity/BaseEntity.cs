﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.BaseEntity
{
    public class BaseEntity : IEntity
    {
        public int Id { get; set; }
    }
}