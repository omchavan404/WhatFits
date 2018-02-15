﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace server.Models
{
    public partial class Permissions
    {
        public Permissions()
        {

        }
        public string Permission { get; set; }
       [ForeignKey("UserPermission")]
        public int PermissionID { get; set; }
    }
}