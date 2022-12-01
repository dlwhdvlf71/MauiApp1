namespace MauiApp1.MVVM.Messengers
{
    public class ChangeNameMessage
    {
        public string Name { get; set; }

        public ChangeNameMessage(string newName)
        {
            this.Name = newName;
        }
    }
}