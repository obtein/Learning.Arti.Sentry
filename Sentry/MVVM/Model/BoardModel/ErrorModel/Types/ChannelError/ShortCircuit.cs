using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentry.MVVM.Model.BoardModel.ErrorModel.Types.ChannelError
{
     class ShortCircuit
    {
        public bool Value { get; set; }
        public ShortCircuit(bool input)
        {
            Value = input;
        }
    }
}
