using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sentry.MVVM.Model.BoardModel.CardModel.Properties;

namespace Sentry.MVVM.Model.BoardModel.CardModel
{
     class CardWrapper
    {
        public CardIndex GetIndex;
        public CardIsOpen GetIsOpen;
        public CardVoltage GetVoltage;
        public CardTemperature GetTemperature;

        public CardWrapper(int cardIndex)
        {
            GetIndex = new CardIndex(cardIndex);
            GetIsOpen = new CardIsOpen();
            GetVoltage = new CardVoltage();
            GetTemperature = new CardTemperature();
        }
    }
}
