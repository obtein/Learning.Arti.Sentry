using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentry.MVVM.Model.BoardModel.ErrorModel.Types.ChannelError
{
     class ErrorCardIndex
    {
        public int Value { get; set; }
        public ErrorCardIndex(int input)
        {
            Value = input;
        }
    }
}
