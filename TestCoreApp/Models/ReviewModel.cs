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
        public double Average
        {
            get {
                if(this.Skills != null)
                {
                    return Math.Round(((this.Skills.LocalKnowledge + this.Skills.NegotiationSkills + this.Skills.ProcessExpertise + this.Skills.Responsiveness) / 4), 
                        1, MidpointRounding.AwayFromZero);
                } return 0;
            }
        }
        public string Text { get; set; }
    }
}
