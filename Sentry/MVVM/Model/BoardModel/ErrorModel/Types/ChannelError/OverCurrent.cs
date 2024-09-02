using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentry.MVVM.Model.BoardModel.ErrorModel.Types.ChannelError
{
     class OverCurrent
    {
        public bool Value { get; set; }
        public OverCurrent(bool input)
        {
            Value = input;
        }
    }
}
