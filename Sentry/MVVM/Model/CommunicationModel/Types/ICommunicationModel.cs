using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentry.MVVM.Model.CommunicationModel.Types
{
    interface ICommunicationModel
    {
        public void Create ();
        public void Start ();
        public void Stop ();
        public void Read ();
        public void Write ();
    }
}
