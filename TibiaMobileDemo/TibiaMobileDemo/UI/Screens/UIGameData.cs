using EmptyKeys.UserInterface.Mvvm;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TibiaMobileDemo.Models;

namespace TibiaMobileDemo.UI.Screens
{
    public class UIGameData : ViewModelBase
    {
        public static UIGameData Instance { private set; get; }

        ObservableCollection<WindowViewModel> windows;
        public ObservableCollection<WindowViewModel> Windows
        {
            get { return windows; }
            set { SetProperty(ref windows, value); }
        }

        ObservableCollection<ChatChannel> _generalChannel;
        public ObservableCollection<ChatChannel> generalChannel
        {
            get { return _generalChannel; }
            set { SetProperty(ref _generalChannel, value); }
        }

        string _general;
        public string general
        {
            get { return _general; }
            set { SetProperty(ref _general, value); }
        }

        public UIGameData()
        {
            Instance = this;

            Windows = new ObservableCollection<WindowViewModel>();
            generalChannel = new ObservableCollection<ChatChannel>();

            generalChannel.Add(new ChatChannel() { date = DateTime.Now, name = "player", message = "Hola mundo!", color = Color.Yellow });
        }
    }
}
