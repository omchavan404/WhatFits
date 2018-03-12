﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Whatfits.Models.Models;

namespace Whatfits.Models.Context.Core
{
    public class LoginContext : DbContext
    {
        public LoginContext() : base("WhatfitsDb")
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Credential> Credentials { get; set; }
        public DbSet<Salt> Salts { get; set; }
        public DbSet<Claim> Claims { get; set; }
        public DbSet<UserClaims> UserClaims { get; set; }
        public DbSet<SecurityQandA> SecurityQandA { get; set; }
        public DbSet<SecurityQuestion> SecurityQuestions { get; set; }
    }
}
