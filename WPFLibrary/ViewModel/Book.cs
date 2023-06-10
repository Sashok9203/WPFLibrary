using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFLibrary.VM
{
    internal class Book
    {
        public string Author { get; init; }
        public string Title { get; init; }
        public string Description { get; init; }
        public string Publisher { get; init; }
        public DateTime Date { get; init; }
        public string DateString => Date.ToString("MMMM  d,  yyyy", new CultureInfo("en-GB")); 
        public Book(string author, string title, string descr, string publish, DateTime date)
        {
            Author = author;
            Title = title;
            Description = descr;
            Publisher = publish;
            Date = date;
        }
    }
}
