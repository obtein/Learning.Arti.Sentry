using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sentry.MVVM.Model.BoardModel.ErrorModel.Types.ChannelError;

namespace Sentry.MVVM.Model.BoardModel.ErrorModel
{
     class ErrorWrapper
    {
        public ErrorCardIndex GetErrorCardIndex;
        public ErrorChannelIndex GetErrorChannelIndex;
        public OverCurrent GetChannelOverCurrent;
        public ShortCircuit GetChannelShortCircuit;
        public VoltageError GetChannelVoltageError;
        public NoCommunication GetChannelNoCommunication;
        public ErrorDate GetErrorDate;
        public ErrorMessage GetErrorMessage;

        public ErrorWrapper(int cardIndex, int channelIndex)
        {
            GetErrorCardIndex = new ErrorCardIndex(cardIndex);
            GetErrorChannelIndex = new ErrorChannelIndex(channelIndex);
            GetChannelOverCurrent = new OverCurrent(false);
            GetChannelShortCircuit = new ShortCircuit(false);
            GetChannelVoltageError = new VoltageError(false);
            GetChannelNoCommunication = new NoCommunication(false);
            GetErrorDate = new ErrorDate(DateTime.Now);
            GetErrorMessage = new ErrorMessage("System Init");
        }
    }
}
