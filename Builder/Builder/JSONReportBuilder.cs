using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Builder
{
    class JSONReportBuilder : ReportBuilder
    {
        public JSONReportBuilder(string content) : base(content)
        {
        }

        public override void BuildAuthor()
        {
            _header += $"{{\n";
            _header += $"    'author': '{Author}',\n";
        }

        public override void BuildContent()
        {
            if (!IncludeTopic && !IncludeAuthor && !IncludeDate) _header += $"{{\n";
            _content += $"    'content': '{Content}'\n";
            _content += "}";
        }

        public override void BuildDate()
        {
            if (!IncludeAuthor) _header += $"{{\n";
            _header += $"    'date': '{Date}',\n";
        }

        public override void BuildTopic()
        {
            if (!IncludeDate) _header += $"{{\n";
            _header += $"    'topic': '{Topic}',\n";
        }
    }
}
