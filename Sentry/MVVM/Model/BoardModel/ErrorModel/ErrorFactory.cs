using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sentry.MVVM.Model.BoardModel.ErrorModel.Types.ChannelError;

namespace Sentry.MVVM.Model.BoardModel.ErrorModel
{
    static class ErrorFactory
    {
        public static ErrorWrapper CreateError(int cardIndex, int channelIndex)
        {
            return new ErrorWrapper(cardIndex,channelIndex);
        }
    }
}
