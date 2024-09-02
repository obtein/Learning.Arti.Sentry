using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sentry.MVVM.Model.WorkerModel.InspectorModel;
using Sentry.MVVM.Model.WorkerModel.ReaderModel;
using Sentry.MVVM.Model.WorkerModel.UpdaterModel;
using Sentry.MVVM.Model.WorkerModel.WriterModel;

namespace Sentry.MVVM.Model.WorkerModel
{
     class WorkerWrapper : IWorkerWrapper
    {
        public ReaderWorker? GetReaderWorker { get; set; }
        public UpdaterWorker? GetUpdaterWorker { get; set; }
        public WriterWorker? GetWriterWorker { get; set; }
        public InspectorWorker? GetInspectorWorker { get; set; }

        public void RunWorker ()
        {
            throw new NotImplementedException();
        }
    }
}
