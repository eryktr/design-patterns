using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Builder
{
    class XMLReportBuilder : ReportBuilder
    {
        public XMLReportBuilder(string content) : base(content) { }
        public override void BuildAuthor()
        {
            _header += $"<author>{Author}</author>\n";
        }

        public override void BuildContent()
        {
            _content += $"<content>{Content}</content>\n";
        }

        public override void BuildDate()
        {
            _header += $"<date>{Date}</date>\n";
        }

        public override void BuildTopic()
        {
            _header += $"<topic>{Topic}</topic>\n";
        }
    }
}
