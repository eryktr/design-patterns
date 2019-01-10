using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Builder
{
    abstract class ReportBuilder
    {
        readonly Report _report = new Report();
        protected string _header;
        protected string _content;

        protected string Author { get; set; }
        protected DateTime Date { get; set; }
        protected string Topic { get; set; }
        protected string Content { get; set; }
      
        protected bool IncludeAuthor { get; set; }
        protected bool IncludeDate { get; set; }
        protected bool IncludeTopic { get; set; }

        protected ReportBuilder(string content) => Content = content;

        public abstract void BuildAuthor();
        public abstract void BuildContent();
        public abstract void BuildDate();
        public abstract void BuildTopic();

        public Report BuildReport()
        {
            if (IncludeAuthor) BuildAuthor();
            if (IncludeDate) BuildDate();
            if (IncludeTopic) BuildTopic();
            BuildContent();

            _report.Header = _header;
            _report.Content = _content;
            return _report;
        }

        public void SetAuthor(string author)
        {
            Author = author;
            IncludeAuthor = true;
        }

        public void SetTopic(string topic)
        {
            Topic = topic;
            IncludeTopic = true;
        }

        public void SetDate(DateTime date)
        {
            Date = date;
            IncludeDate = true;
        }
    }
}