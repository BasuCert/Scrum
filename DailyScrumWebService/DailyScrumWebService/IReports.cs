using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DailyScrumWebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IReports" in both code and config file together.
    [ServiceContract]
    public interface IReports
    {
        [OperationContract]
        ModelViews.ViewReport[] Get(string Username, int count = 10, int skip = 0);

        [OperationContract]
        void Submit(string Title, string Description, DateTime Submit, int ProjectId, string Username);
    }
}
