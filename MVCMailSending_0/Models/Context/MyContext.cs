﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCMailSending_0.Models.Context
{
    public class MyContext : DbContext
    {
        public MyContext():base("MyConnection")
        {

        }
    }
}