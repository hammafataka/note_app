using System;
using System.Collections.Generic;
using System.Text;

namespace note_app.models
{
    public class Note
    {
        public string fileName { get; set; }
        public string text { get; set; }
        public DateTime date { get; set; }
    }
}
