﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using UUUMod517.Models;

namespace UUUMod517.DAL
{
    public class OperaContext :DbContext
    {
        public DbSet<Opera> Operas { get; set; }
    }
}