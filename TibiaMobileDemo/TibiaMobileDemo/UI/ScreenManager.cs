using System;
using System.Collections.Generic;
using System.Text;
using EmptyKeys.UserInterface;
using EmptyKeys.UserInterface.Controls;
using  EmptyKeys.UserInterface.Generated;
using EmptyKeys.UserInterface.Media;
using EmptyKeys.UserInterface.Media.Effects;
using TibiaMobileDemo.UI.Screens;

namespace TibiaMobileDemo.UI
{
    public static class ScreenManager
    {
        public static UIRoot Current;
        public static void Init()
        {
            Current = new UIMainRoot();

            Current.Content = new UIGame();
            Current.DataContext = new UIGameData();
         
            //Cargamos el Contenido
            FontManager.Instance.LoadFonts(GameMain.Instance.Content);
            ImageManager.Instance.LoadImages(GameMain.Instance.Content);
            SoundManager.Instance.LoadSounds(GameMain.Instance.Content);
            EffectManager.Instance.LoadEffects(GameMain.Instance.Content);
            SoundManager.Instance.LoadSounds(GameMain.Instance.Content);
        }
    }
}
