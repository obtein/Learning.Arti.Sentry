using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sentry.MVVM.Model.BoardModel.CardModel;
using Sentry.MVVM.Model.BoardModel.ChannelModel;
using Sentry.MVVM.Model.BoardModel.ErrorModel;

namespace Sentry.MVVM.Model.BoardModel
{
     class Board
    {
        static List<CardWrapper> CardList = new List<CardWrapper>();
        static List<ChannelWrapper> ChannelList = new List<ChannelWrapper>();
        static List<ErrorWrapper> ErrorList = new List<ErrorWrapper>();

        public Board (int cardCount, int chCount1, int chCount2, int chCount3 )
        {
            for ( int i = 1; i <= cardCount; i++ )
            {
                CardList.Add(CardFactory.CreateCard(i));
            }
            for ( int i = 1; i <= chCount1; i++ )
            {
                ChannelList.Add( ChannelFactory.CreateChannel( 1, i ) );
                ErrorList.Add(ErrorFactory.CreateError(1,i));
            }
            for ( int i = 1; i <= chCount2; i++ )
            {
                ChannelList.Add( ChannelFactory.CreateChannel( 2, i ) );
                ErrorList.Add(ErrorFactory.CreateError(2,i));
            }
            for ( int i = 1; i <= chCount3; i++ )
            {
                ChannelList.Add( ChannelFactory.CreateChannel( 3, i ) ) ;
                ErrorList.Add(ErrorFactory.CreateError (3,i));
            }
        }
    }
}
