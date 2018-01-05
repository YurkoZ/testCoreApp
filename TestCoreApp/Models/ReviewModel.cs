using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestCoreApp.Models
{
    public class ReviewModel
    {
        public DateTime Date { get; set; }
        public string Author { get; set; }
        public string Home { get; set; }
        public SkillsModel Skills { get; set; }
        public string Text { get; set; }
    }
}
