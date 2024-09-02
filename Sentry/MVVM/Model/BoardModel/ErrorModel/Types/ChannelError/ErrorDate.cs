using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentry.MVVM.Model.BoardModel.ErrorModel.Types.ChannelError
{
     class ErrorDate
    {
        public DateTime Value { get; set; }
        public ErrorDate(DateTime input)
        {
            Value = input;
        }
    }
}
