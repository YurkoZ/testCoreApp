using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestCoreApp.Models
{
    public class SkillsModel
    {
        public SkillsModel() { }
        public SkillsModel(bool test)
        {
            if(test)
            {
                this.LocalKnowledge = 4.5;
                this.ProcessExpertise = 4.2;
                this.Responsiveness = 5;
                this.NegotiationSkills = 4.1;
            }
        }

        public double LocalKnowledge { get; set; }
        public double ProcessExpertise { get; set; }
        public double Responsiveness { get; set; }
        public double NegotiationSkills { get; set; }
    }
}
