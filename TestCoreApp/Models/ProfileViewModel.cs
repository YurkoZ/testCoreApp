using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestCoreApp.Models
{
    public class ProfileViewModel
    {
        public ProfileViewModel() { }
        public ProfileViewModel(bool test)
        {
            if(test)
            {
                this.FirstName = "Melissa";
                this.LastName = "Crosby";

                this.Skills = new SkillsModel(test);
            }
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public SkillsModel Skills { get; set; }
    }
}