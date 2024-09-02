using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentry.MVVM.Model.BoardModel.ErrorModel.Types.ChannelError
{
     class ErrorMessage
    {
        public List<string> Value { get; set; }
        public ErrorMessage(string input)
        {
            Value = new List<string>();
            Value.Add(input);
        }
        public void AddEntry (string input)
        {
            Value.Add(input);
        }
    }
}
