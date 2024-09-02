using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sentry.MVVM.Model.CommunicationModel.Types;

namespace Sentry.MVVM.Model.CommunicationModel
{
     class Communication
    {
        public ICommunicationModel GetCommunication ( string communicationType)
        {
            ICommunicationModel communicationModel;
            switch ( communicationType )
            {
                case "Serial":
                    communicationModel = new SerialCommunication();
                    return communicationModel;
                case "Ethernet":
                    communicationModel = new EthernetCommunication();
                    return communicationModel;
                default:
                    return communicationModel = new SerialCommunication();
            }
        }
    }
}
