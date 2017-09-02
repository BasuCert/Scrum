using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DailyScrumWebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Projects" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Projects.svc or Projects.svc.cs at the Solution Explorer and start debugging.
    public class Projects : IProjects
    {
        Models.Model1 db = new Models.Model1();
        public ModelViews.ViewProject[] Get()
        {
            var query = db.Projects
                .Select(x => new ModelViews.ViewProject { Id = x.Id, Name = x.Name })
                .ToList()
                .ToArray();
            return query;
        }
    }
}
