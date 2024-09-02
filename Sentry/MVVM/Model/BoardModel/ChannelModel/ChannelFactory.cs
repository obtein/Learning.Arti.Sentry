using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentry.MVVM.Model.BoardModel.ChannelModel
{
    static class ChannelFactory
    {
        public static ChannelWrapper CreateChannel (int cardIndex, int channelIndex)
        {
            return new ChannelWrapper (cardIndex, channelIndex);
        }
    }
}
