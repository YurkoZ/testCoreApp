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
        public int LocalKnowledgePercentage
        {
            get
            {
                return (int)((this.LocalKnowledge/5)*100);
            }
        }
        public double ProcessExpertise { get; set; }
        public int ProcessExpertisePercentage
        {
            get
            {
                return (int)((this.ProcessExpertise / 5) * 100);
            }
        }
        public double Responsiveness { get; set; }
        public int ResponsivenessPercentage
        {
            get
            {
                return (int)((this.Responsiveness / 5) * 100);
            }
        }
        public double NegotiationSkills { get; set; }
        public int NegotiationSkillsPercentage
        {
            get
            {
                return (int)((this.NegotiationSkills / 5) * 100);
            }
        }
    }
}
