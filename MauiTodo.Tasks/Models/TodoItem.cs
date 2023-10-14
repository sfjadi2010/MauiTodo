﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTodo.Tasks.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string Todo { get; set; }
        public string Description { get; set; }
        public bool Done { get; set; }
    }
}
