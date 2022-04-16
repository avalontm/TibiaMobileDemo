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
    public sealed class DialogMessage : ResourceDictionary {
        
        private static DialogMessage singleton = new DialogMessage();
        
        public DialogMessage() {
            this.InitializeResources();
        }
        
        public static DialogMessage Instance {
            get {
                return singleton;
            }
        }
        
        private void InitializeResources() {
            // Resource - [DialogWindowTemplate] ControlTemplate
            Func<UIElement, UIElement> r_0_ctFunc = r_0_ctMethod;
            ControlTemplate r_0_ct = new ControlTemplate(r_0_ctFunc);
            this.Add("DialogWindowTemplate", r_0_ct);
            // Resource - [System.Windows.Controls.ListBoxItem] Style
            Style r_1_s = new Style(typeof(ListBoxItem));
            Setter r_1_s_S_0 = new Setter(ListBoxItem.BackgroundProperty, new SolidColorBrush(new ColorW(255, 255, 255, 0)));
            r_1_s.Setters.Add(r_1_s_S_0);
            Setter r_1_s_S_1 = new Setter(ListBoxItem.FocusableProperty, true);
            r_1_s.Setters.Add(r_1_s_S_1);
            Setter r_1_s_S_2 = new Setter(ListBoxItem.BorderThicknessProperty, new Thickness(0F));
            r_1_s.Setters.Add(r_1_s_S_2);
            Func<UIElement, UIElement> r_1_s_S_3_ctFunc = r_1_s_S_3_ctMethod;
            ControlTemplate r_1_s_S_3_ct = new ControlTemplate(typeof(ListBoxItem), r_1_s_S_3_ctFunc);
            Setter r_1_s_S_3 = new Setter(ListBoxItem.TemplateProperty, r_1_s_S_3_ct);
            r_1_s.Setters.Add(r_1_s_S_3);
            this.Add(typeof(ListBoxItem), r_1_s);
            FontManager.Instance.AddFont("Segoe UI", 32F, FontStyle.Regular, "Segoe_UI_24_Regular");
        }
        
        private static UIElement r_0_ctMethod(UIElement parent) {
            // e_0 element
            Grid e_0 = new Grid();
            e_0.Parent = parent;
            e_0.Name = "e_0";
            e_0.Background = new SolidColorBrush(new ColorW(2, 5, 14, 255));
            // e_1 element
            Border e_1 = new Border();
            e_0.Children.Add(e_1);
            e_1.Name = "e_1";
            e_1.Margin = new Thickness(5F, 5F, 5F, 5F);
            e_1.HorizontalAlignment = HorizontalAlignment.Stretch;
            e_1.VerticalAlignment = VerticalAlignment.Stretch;
            e_1.BorderBrush = new SolidColorBrush(new ColorW(128, 96, 55, 255));
            e_1.BorderThickness = new Thickness(5F, 5F, 5F, 5F);
            // e_2 element
            Grid e_2 = new Grid();
            e_1.Child = e_2;
            e_2.Name = "e_2";
            RowDefinition row_e_2_0 = new RowDefinition();
            row_e_2_0.Height = new GridLength(20F, GridUnitType.Pixel);
            e_2.RowDefinitions.Add(row_e_2_0);
            RowDefinition row_e_2_1 = new RowDefinition();
            row_e_2_1.Height = new GridLength(1F, GridUnitType.Star);
            e_2.RowDefinitions.Add(row_e_2_1);
            RowDefinition row_e_2_2 = new RowDefinition();
            row_e_2_2.Height = new GridLength(1F, GridUnitType.Auto);
            e_2.RowDefinitions.Add(row_e_2_2);
            // PART_WindowTitleBorder element
            Border PART_WindowTitleBorder = new Border();
            e_2.Children.Add(PART_WindowTitleBorder);
            PART_WindowTitleBorder.Name = "PART_WindowTitleBorder";
            PART_WindowTitleBorder.Background = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            // e_3 element
            Grid e_3 = new Grid();
            e_2.Children.Add(e_3);
            e_3.Name = "e_3";
            Grid.SetRow(e_3, 1);
            // e_4 element
            ScrollViewer e_4 = new ScrollViewer();
            e_3.Children.Add(e_4);
            e_4.Name = "e_4";
            e_4.HorizontalAlignment = HorizontalAlignment.Center;
            e_4.VerticalAlignment = VerticalAlignment.Center;
            e_4.HorizontalScrollBarVisibility = ScrollBarVisibility.Disabled;
            e_4.VerticalScrollBarVisibility = ScrollBarVisibility.Auto;
            // e_5 element
            Grid e_5 = new Grid();
            e_4.Content = e_5;
            e_5.Name = "e_5";
            // e_6 element
            TextBlock e_6 = new TextBlock();
            e_5.Children.Add(e_6);
            e_6.Name = "e_6";
            e_6.Margin = new Thickness(5F, 5F, 5F, 5F);
            e_6.HorizontalAlignment = HorizontalAlignment.Center;
            e_6.VerticalAlignment = VerticalAlignment.Center;
            e_6.Foreground = new SolidColorBrush(new ColorW(255, 255, 255, 255));
            e_6.TextWrapping = TextWrapping.Wrap;
            e_6.FontSize = 32F;
            Binding binding_e_6_Text = new Binding("Message");
            e_6.SetBinding(TextBlock.TextProperty, binding_e_6_Text);
            // e_7 element
            Grid e_7 = new Grid();
            e_2.Children.Add(e_7);
            e_7.Name = "e_7";
            Grid.SetRow(e_7, 2);
            // e_8 element
            Button e_8 = new Button();
            e_7.Children.Add(e_8);
            e_8.Name = "e_8";
            e_8.Height = 60F;
            e_8.Width = 350F;
            e_8.Margin = new Thickness(5F, 5F, 5F, 5F);
            e_8.HorizontalAlignment = HorizontalAlignment.Center;
            e_8.VerticalAlignment = VerticalAlignment.Center;
            e_8.Background = new SolidColorBrush(new ColorW(75, 56, 26, 255));
            e_8.BorderBrush = new SolidColorBrush(new ColorW(128, 96, 55, 255));
            e_8.BorderThickness = new Thickness(5F, 5F, 5F, 5F);
            e_8.Foreground = new SolidColorBrush(new ColorW(255, 255, 255, 255));
            e_8.Content = "OK";
            Binding binding_e_8_Visibility = new Binding("CloseVisible");
            e_8.SetBinding(Button.VisibilityProperty, binding_e_8_Visibility);
            Binding binding_e_8_Command = new Binding("HideCommand");
            e_8.SetBinding(Button.CommandProperty, binding_e_8_Command);
            return e_0;
        }
        
        private static UIElement r_1_s_S_3_ctMethod(UIElement parent) {
            // e_9 element
            Border e_9 = new Border();
            e_9.Parent = parent;
            e_9.Name = "e_9";
            Binding binding_e_9_Background = new Binding("Background");
            binding_e_9_Background.Source = parent;
            e_9.SetBinding(Border.BackgroundProperty, binding_e_9_Background);
            Binding binding_e_9_BorderThickness = new Binding("BorderThickness");
            binding_e_9_BorderThickness.Source = parent;
            e_9.SetBinding(Border.BorderThicknessProperty, binding_e_9_BorderThickness);
            Binding binding_e_9_BorderBrush = new Binding("BorderBrush");
            binding_e_9_BorderBrush.Source = parent;
            e_9.SetBinding(Border.BorderBrushProperty, binding_e_9_BorderBrush);
            // e_10 element
            ContentPresenter e_10 = new ContentPresenter();
            e_9.Child = e_10;
            e_10.Name = "e_10";
            Binding binding_e_10_Content = new Binding("Content");
            binding_e_10_Content.Source = parent;
            e_10.SetBinding(ContentPresenter.ContentProperty, binding_e_10_Content);
            return e_9;
        }
    }
}
