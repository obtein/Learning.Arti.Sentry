using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentry.MVVM.Model.BoardModel.ErrorModel.Types.ChannelError
{
     class NoCommunication
    {
        public bool Value { get; set; }
        public NoCommunication(bool input)
        {
            Value = input;
        }
    }
}
