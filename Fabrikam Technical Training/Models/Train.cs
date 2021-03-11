using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fabrikam_Technical_Training.Models
{
    public class Train
    {
        public int Id { get; set; }
        public string TrainingRecommendation { get; set; }
        public string HostedBy { get; set; }

        public Train()
        {

        }
    }
}
