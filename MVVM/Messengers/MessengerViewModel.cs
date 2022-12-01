using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using MauiApp1.MVVM.Messengers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.MVVM.Messengers
{
    public partial class MessengerViewModel : ObservableObject
    {
        [ObservableProperty]
        private string name;

        public MessengerUser User { get; } = new MessengerUser();

        public MessengerViewModel()
        {
            Name = "My Name is TestName";
            WeakReferenceMessenger.Default.Register<ChangeNameMessage>(this, (r, m) =>
            {
                Receive(m);
            });
        }

        [RelayCommand]
        private void Register()
        {
            if (StrongReferenceMessenger.Default.IsRegistered<ChangeNameMessage>(this)) return;

            StrongReferenceMessenger.Default.Register<ChangeNameMessage>(this, (r, m) =>
            {
                ReceiveStrong(m);
            });
        }

        [RelayCommand]
        private void Unregister() 
        {
            StrongReferenceMessenger.Default.Unregister<ChangeNameMessage>(this);
        }

        [RelayCommand]
        private void ChangeName() => Name = $"{DateTime.Now} Chnage New Name";

        void Receive(ChangeNameMessage message)
        {
            Name = $"{DateTime.Now} new Name = {message.Name}";
        }

        void ReceiveStrong(ChangeNameMessage message)
        {
            Name = $"{DateTime.Now} (Strong) new Name = {message.Name}";
        }

    }
}

public class User
{
    public string Name { get; set; }
}

public partial class MessengerUser : ObservableObject
{
    private readonly User user;

    public MessengerUser()
    {
        user ??= new User()
        {
            Name = "My User Name is TestName"
        };
    }

    public string Name
    {
        get => user.Name;
        set => SetProperty(user.Name, value, user, (u, n) => u.Name = n);
    }

    [RelayCommand]
    private void ChangeName()
    {
        Name = $"{DateTime.Now} Change User Name";
        WeakReferenceMessenger.Default.Send(new ChangeNameMessage(Name));
    }

    [RelayCommand]
    private void StrongChangeName()
    {
        Name = $"{DateTime.Now} Strong Change User Name";
        StrongReferenceMessenger.Default.Send(new ChangeNameMessage(Name));
    }

}
