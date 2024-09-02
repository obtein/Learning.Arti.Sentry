using Sentry.MVVM.Model.CommunicationModel;
using Sentry.MVVM.Model.WorkerModel;

namespace Sentry.MVVM.Model.ApplicationShellModel
{
    /// <summary>
    /// Controls the bussiness logic of the application
    /// </summary>
     class ApplicationShell
    {
        public Communication CommunicationModel { get; set; }

        public WorkerWrapper Workers { get; set; }

        public ApplicationShell (string communicationType)
        {

        }
    }
}
