﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Project_Management_System.Models
{
    public enum BugPriority
    {
        None,
        Low,
        Medium,
        High,
    }
    public enum BugStatus
    {
        None = 0,
        Unconfirmed,
        Confirmed,
        InProgress,
        Resolved,
        Closed
    }
    public class Bug
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; } = string.Empty;
        public BugStatus Status { get; set; } = BugStatus.None;
        public BugPriority Priority { get; set; } = BugPriority.None;
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public DateTime UpdatedOn { get; set; } = DateTime.Now;
    }
}