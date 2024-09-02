using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentry.MVVM.Model.BoardModel.CardModel
{
    static class CardFactory
    {
        public static CardWrapper CreateCard (int cardIndex)
        {
            return new CardWrapper(cardIndex);
        }
    }
}
