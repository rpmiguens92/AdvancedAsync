using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedAsync
{
   public class ProgressReportModel
    {

        public int PercentageComplete { get; set; } = 0; //starts with 0 progressBar

        public List<WebsiteDataModel> SitesDownloaded { get; set; } = new List<WebsiteDataModel>(); //list of websites added

    }
}
