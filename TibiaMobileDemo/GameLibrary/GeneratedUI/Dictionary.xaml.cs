// -----------------------------------------------------------
//  
//  This file was generated, please do not modify.
//  
// -----------------------------------------------------------
namespace EmptyKeys.UserInterface.Generated {
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.ObjectModel;
    using EmptyKeys.UserInterface;
    using EmptyKeys.UserInterface.Charts;
    using EmptyKeys.UserInterface.Data;
    using EmptyKeys.UserInterface.Controls;
    using EmptyKeys.UserInterface.Controls.Primitives;
    using EmptyKeys.UserInterface.Input;
    using EmptyKeys.UserInterface.Interactions.Core;
    using EmptyKeys.UserInterface.Interactivity;
    using EmptyKeys.UserInterface.Media;
    using EmptyKeys.UserInterface.Media.Effects;
    using EmptyKeys.UserInterface.Media.Animation;
    using EmptyKeys.UserInterface.Media.Imaging;
    using EmptyKeys.UserInterface.Shapes;
    using EmptyKeys.UserInterface.Renderers;
    using EmptyKeys.UserInterface.Themes;
    
    
    [GeneratedCodeAttribute("Empty Keys UI Generator", "3.3.0.0")]
    public sealed class Dictionary : ResourceDictionary {
        
        private static Dictionary singleton = new Dictionary();
        
        public Dictionary() {
            this.InitializeResources();
        }
        
        public static Dictionary Instance {
            get {
                return singleton;
            }
        }
        
        private void InitializeResources() {
            // Resource - [Background] SolidColorBrush
            this.Add("Background", new SolidColorBrush(new ColorW(74, 74, 74, 255)));
            // Resource - [System.Windows.Controls.Button] Style
            var r_1_s_bo = this[typeof(Button)];
            Style r_1_s = new Style(typeof(Button), r_1_s_bo as Style);
            Setter r_1_s_S_0 = new Setter(Button.BackgroundProperty, new SolidColorBrush(new ColorW(74, 74, 74, 255)));
            r_1_s.Setters.Add(r_1_s_S_0);
            Setter r_1_s_S_1 = new Setter(Button.WidthProperty, 200F);
            r_1_s.Setters.Add(r_1_s_S_1);
            Setter r_1_s_S_2 = new Setter(Button.MarginProperty, new Thickness(0F, 1F, 0F, 1F));
            r_1_s.Setters.Add(r_1_s_S_2);
            Setter r_1_s_S_3 = new Setter(Button.SnapsToDevicePixelsProperty, false);
            r_1_s.Setters.Add(r_1_s_S_3);
            EventTrigger r_1_s_ET_0 = new EventTrigger(Button.MouseEnterEvent);
            r_1_s.Triggers.Add(r_1_s_ET_0);
            BeginStoryboard r_1_s_ET_0_AC_0 = new BeginStoryboard();
            r_1_s_ET_0_AC_0.Name = "r_1_s_ET_0_AC_0";
            r_1_s_ET_0.AddAction(r_1_s_ET_0_AC_0);
            Storyboard r_1_s_ET_0_AC_0_SB = new Storyboard();
            r_1_s_ET_0_AC_0.Storyboard = r_1_s_ET_0_AC_0_SB;
            r_1_s_ET_0_AC_0_SB.Name = "r_1_s_ET_0_AC_0_SB";
            ThicknessAnimation r_1_s_ET_0_AC_0_SB_TL_0 = new ThicknessAnimation();
            r_1_s_ET_0_AC_0_SB_TL_0.Name = "r_1_s_ET_0_AC_0_SB_TL_0";
            r_1_s_ET_0_AC_0_SB_TL_0.Duration = new Duration(new TimeSpan(0, 0, 0, 0, 500));
            r_1_s_ET_0_AC_0_SB_TL_0.From = new Thickness(0F, 1F, 0F, 1F);
            r_1_s_ET_0_AC_0_SB_TL_0.To = new Thickness(0F, 5F, 0F, 5F);
            SineEase r_1_s_ET_0_AC_0_SB_TL_0_EA = new SineEase();
            r_1_s_ET_0_AC_0_SB_TL_0.EasingFunction = r_1_s_ET_0_AC_0_SB_TL_0_EA;
            Storyboard.SetTargetProperty(r_1_s_ET_0_AC_0_SB_TL_0, Button.MarginProperty);
            r_1_s_ET_0_AC_0_SB.Children.Add(r_1_s_ET_0_AC_0_SB_TL_0);
            FloatAnimation r_1_s_ET_0_AC_0_SB_TL_1 = new FloatAnimation();
            r_1_s_ET_0_AC_0_SB_TL_1.Name = "r_1_s_ET_0_AC_0_SB_TL_1";
            r_1_s_ET_0_AC_0_SB_TL_1.Duration = new Duration(new TimeSpan(0, 0, 0, 0, 500));
            r_1_s_ET_0_AC_0_SB_TL_1.To = 220F;
            SineEase r_1_s_ET_0_AC_0_SB_TL_1_EA = new SineEase();
            r_1_s_ET_0_AC_0_SB_TL_1.EasingFunction = r_1_s_ET_0_AC_0_SB_TL_1_EA;
            Storyboard.SetTargetProperty(r_1_s_ET_0_AC_0_SB_TL_1, Button.WidthProperty);
            r_1_s_ET_0_AC_0_SB.Children.Add(r_1_s_ET_0_AC_0_SB_TL_1);
            EventTrigger r_1_s_ET_1 = new EventTrigger(Button.MouseLeaveEvent);
            r_1_s.Triggers.Add(r_1_s_ET_1);
            BeginStoryboard r_1_s_ET_1_AC_0 = new BeginStoryboard();
            r_1_s_ET_1_AC_0.Name = "r_1_s_ET_1_AC_0";
            r_1_s_ET_1.AddAction(r_1_s_ET_1_AC_0);
            Storyboard r_1_s_ET_1_AC_0_SB = new Storyboard();
            r_1_s_ET_1_AC_0.Storyboard = r_1_s_ET_1_AC_0_SB;
            r_1_s_ET_1_AC_0_SB.Name = "r_1_s_ET_1_AC_0_SB";
            ThicknessAnimation r_1_s_ET_1_AC_0_SB_TL_0 = new ThicknessAnimation();
            r_1_s_ET_1_AC_0_SB_TL_0.Name = "r_1_s_ET_1_AC_0_SB_TL_0";
            r_1_s_ET_1_AC_0_SB_TL_0.Duration = new Duration(new TimeSpan(0, 0, 0, 0, 500));
            r_1_s_ET_1_AC_0_SB_TL_0.From = new Thickness(0F, 5F, 0F, 5F);
            r_1_s_ET_1_AC_0_SB_TL_0.To = new Thickness(0F, 1F, 0F, 1F);
            SineEase r_1_s_ET_1_AC_0_SB_TL_0_EA = new SineEase();
            r_1_s_ET_1_AC_0_SB_TL_0.EasingFunction = r_1_s_ET_1_AC_0_SB_TL_0_EA;
            Storyboard.SetTargetProperty(r_1_s_ET_1_AC_0_SB_TL_0, Button.MarginProperty);
            r_1_s_ET_1_AC_0_SB.Children.Add(r_1_s_ET_1_AC_0_SB_TL_0);
            FloatAnimation r_1_s_ET_1_AC_0_SB_TL_1 = new FloatAnimation();
            r_1_s_ET_1_AC_0_SB_TL_1.Name = "r_1_s_ET_1_AC_0_SB_TL_1";
            r_1_s_ET_1_AC_0_SB_TL_1.Duration = new Duration(new TimeSpan(0, 0, 0, 0, 500));
            r_1_s_ET_1_AC_0_SB_TL_1.To = 200F;
            SineEase r_1_s_ET_1_AC_0_SB_TL_1_EA = new SineEase();
            r_1_s_ET_1_AC_0_SB_TL_1.EasingFunction = r_1_s_ET_1_AC_0_SB_TL_1_EA;
            Storyboard.SetTargetProperty(r_1_s_ET_1_AC_0_SB_TL_1, Button.WidthProperty);
            r_1_s_ET_1_AC_0_SB.Children.Add(r_1_s_ET_1_AC_0_SB_TL_1);
            this.Add(typeof(Button), r_1_s);
            // Resource - [System.Windows.Controls.TabControl] Style
            var r_2_s_bo = this[typeof(TabControl)];
            Style r_2_s = new Style(typeof(TabControl), r_2_s_bo as Style);
            Setter r_2_s_S_0 = new Setter(TabControl.BackgroundProperty, new SolidColorBrush(new ColorW(74, 74, 74, 255)));
            r_2_s.Setters.Add(r_2_s_S_0);
            Setter r_2_s_S_1 = new Setter(TabControl.FocusableProperty, false);
            r_2_s.Setters.Add(r_2_s_S_1);
            this.Add(typeof(TabControl), r_2_s);
            // Resource - [System.Windows.Controls.TabItem] Style
            var r_3_s_bo = this[typeof(TabItem)];
            Style r_3_s = new Style(typeof(TabItem), r_3_s_bo as Style);
            Setter r_3_s_S_0 = new Setter(TabItem.BackgroundProperty, new SolidColorBrush(new ColorW(74, 74, 74, 255)));
            r_3_s.Setters.Add(r_3_s_S_0);
            Setter r_3_s_S_1 = new Setter(TabItem.ForegroundProperty, new SolidColorBrush(new ColorW(255, 255, 255, 255)));
            r_3_s.Setters.Add(r_3_s_S_1);
            Setter r_3_s_S_2 = new Setter(TabItem.FontStyleProperty, FontStyle.Bold);
            r_3_s.Setters.Add(r_3_s_S_2);
            Setter r_3_s_S_3 = new Setter(TabItem.FocusableProperty, false);
            r_3_s.Setters.Add(r_3_s_S_3);
            Setter r_3_s_S_4 = new Setter(TabItem.FontSizeProperty, 12F);
            r_3_s.Setters.Add(r_3_s_S_4);
            this.Add(typeof(TabItem), r_3_s);
        }
    }
}
