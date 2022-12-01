using CommunityToolkit.Mvvm.Messaging.Messages;

namespace MauiApp1.MVVM.Messengers
{
    public class ChangeNameRequestMessage : RequestMessage<string>
    {
        public string Name { get; set; }

        public ChangeNameRequestMessage(string newName)
        {
            this.Name = newName;
        }
    }
}