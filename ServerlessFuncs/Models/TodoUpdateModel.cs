using System;
using System.Collections.Generic;
using System.Text;

namespace ServerlessFuncs.Models
{
    public class TodoUpdateModel
    {
        public string TaskDescription { get; set; }
        public bool IsCompleted { get; set; }
    }
}
