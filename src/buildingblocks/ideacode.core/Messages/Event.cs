using ideacode.core.Helpers;
using MediatR;

namespace ideacode.core.Messages
{
    public abstract class Event : Message, INotification
    {
        public DateTime Timestamp { get; private set; }

        protected Event()
        {
            Timestamp = DataHoraDeBrasilia.Get();
        }
    }
}