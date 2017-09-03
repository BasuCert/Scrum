using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DailyScrumWebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Reports" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Reports.svc or Reports.svc.cs at the Solution Explorer and start debugging.
    public class Reports : IReports
    {
        Models.Model1 db = new Models.Model1();
        public void Submit(string Title, string Description, DateTime Submit, int ProjectId, string Username)
        {
            db.Reports.Add(
                new Models.Report
                {
                    Title = Title,
                    Description = Description,
                    Submit = Submit,
                    ProjectId = ProjectId,
                    Username = Username
                }
            );
            db.SaveChanges();
        }
        public ModelViews.ViewReport GetSingle(string Username, int ReportID)
        {
            return db.Reports.Where(x => x.Id == ReportID).Select(x =>
             new ModelViews.ViewReport
             {
                 Id = x.Id,
                 Description = x.Description,
                 Submit = x.Submit,
                 Username = x.Username,
                 Title = x.Title,
                 ProjectId = x.ProjectId

             }
            ).FirstOrDefault();
        }
        public ModelViews.ViewReport[] Get(string Username, int count = 10, int skip = 0)
        {
            var current_user = db.Users.Where(c => c.Username == Username).FirstOrDefault();

            var flat = (

                from report in db.Reports

                join project in db.Projects
                on report.ProjectId equals project.Id


                join user in db.Users
                on report.Username equals user.Username

                select new { report, project, user }


                );




            if (current_user.IsScrumMaster)
            {
                var query = flat
                .Where(x => x.user.Username == current_user.Username || x.project.Id == current_user.RelatedProjectId)
                .Select(y => new ModelViews.ViewReport { Id = y.report.Id, Description = y.report.Description, Submit = y.report.Submit, Username = y.report.Username, Title = y.report.Title, ProjectId = y.report.ProjectId })
                .OrderByDescending(x => x.Submit)
                .Skip(skip)
                .Take(count)
                .ToList()
                .ToArray();
                return query;
            }
            else
            {
                var query = flat
                .Where(x => x.user.Username == current_user.Username)
                .Select(y => new ModelViews.ViewReport { Id = y.report.Id, Description = y.report.Description, Submit = y.report.Submit, Username = y.report.Username, Title = y.report.Title, ProjectId = y.report.ProjectId })
                .OrderByDescending(x => x.Submit)
                .Skip(skip)
                .Take(count)
                .ToList()
                .ToArray();
                return query;
            }
        }
    }
}
