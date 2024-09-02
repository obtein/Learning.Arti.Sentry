using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sentry.MVVM.Model.BoardModel.ChannelModel.Properties;

namespace Sentry.MVVM.Model.BoardModel.ChannelModel
{
     class ChannelWrapper
    {
        public ChannelCardIndex GetChannelCardIndex;
        public ChannelIndex GetChannelIndex;
        public ChannelIsOpen GetChannelIsOpen;
        public ChannelCurrent GetChannelCurrent;

        public ChannelWrapper (int cardIndex, int channelIndex)
        {
            GetChannelCardIndex = new ChannelCardIndex (cardIndex);
            GetChannelIndex = new ChannelIndex (channelIndex);
            GetChannelIsOpen = new ChannelIsOpen();
            GetChannelCurrent = new ChannelCurrent ();
        }

    }
}
