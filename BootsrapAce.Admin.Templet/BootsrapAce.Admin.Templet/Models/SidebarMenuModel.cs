﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BootsrapAce.Admin.Templet.Models
{
    public class SidebarMenuModel
    {
        public SidebarMenuModel()
        {
            this.ChildMenuList = new List<SidebarMenuModel>();
        }

        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string Code { get; set; }
        public string LinkUrl { get; set; }
        public string Area { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }

        public List<SidebarMenuModel> ChildMenuList { get; set; }
    }
}