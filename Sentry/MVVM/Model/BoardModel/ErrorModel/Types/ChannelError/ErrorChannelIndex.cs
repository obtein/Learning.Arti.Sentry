using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentry.MVVM.Model.BoardModel.ErrorModel.Types.ChannelError
{
     class ErrorChannelIndex
    {
        public int Value { get; set; }
        public ErrorChannelIndex(int input)
        {
            Value = input;
        }
    }
}
