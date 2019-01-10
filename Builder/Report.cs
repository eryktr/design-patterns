using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class Report
    {
        public string Header { get; set; }
        public string Content { get; set; }

        public override string ToString()
        {
            return $"{Header}\n{Content}";
        }
    }
}
