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
    public sealed class DialogGameWindow : ResourceDictionary {
        
        private static DialogGameWindow singleton = new DialogGameWindow();
        
        public DialogGameWindow() {
            this.InitializeResources();
        }
        
        public static DialogGameWindow Instance {
            get {
                return singleton;
            }
        }
        
        private void InitializeResources() {
            // Resource - [DialogGameWindowTemplate] ControlTemplate
            Func<UIElement, UIElement> r_0_ctFunc = r_0_ctMethod;
            ControlTemplate r_0_ct = new ControlTemplate(r_0_ctFunc);
            this.Add("DialogGameWindowTemplate", r_0_ct);
            FontManager.Instance.AddFont("Segoe UI", 24F, FontStyle.Regular, "Segoe_UI_18_Regular");
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
            row_e_2_0.Height = new GridLength(1F, GridUnitType.Auto);
            e_2.RowDefinitions.Add(row_e_2_0);
            RowDefinition row_e_2_1 = new RowDefinition();
            row_e_2_1.Height = new GridLength(7F, GridUnitType.Star);
            e_2.RowDefinitions.Add(row_e_2_1);
            RowDefinition row_e_2_2 = new RowDefinition();
            row_e_2_2.Height = new GridLength(3F, GridUnitType.Star);
            e_2.RowDefinitions.Add(row_e_2_2);
            // PART_WindowTitleBorder element
            Border PART_WindowTitleBorder = new Border();
            e_2.Children.Add(PART_WindowTitleBorder);
            PART_WindowTitleBorder.Name = "PART_WindowTitleBorder";
            PART_WindowTitleBorder.Margin = new Thickness(0F, 0F, 0F, 0F);
            PART_WindowTitleBorder.Background = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            PART_WindowTitleBorder.Padding = new Thickness(0F, 0F, 0F, 0F);
            Grid.SetRow(PART_WindowTitleBorder, 0);
            // e_3 element
            TextBlock e_3 = new TextBlock();
            PART_WindowTitleBorder.Child = e_3;
            e_3.Name = "e_3";
            e_3.Margin = new Thickness(5F, 5F, 5F, 5F);
            e_3.HorizontalAlignment = HorizontalAlignment.Center;
            e_3.VerticalAlignment = VerticalAlignment.Center;
            e_3.Foreground = new SolidColorBrush(new ColorW(255, 255, 255, 255));
            e_3.Text = "MENU";
            e_3.FontSize = 24F;
            // e_4 element
            Grid e_4 = new Grid();
            e_2.Children.Add(e_4);
            e_4.Name = "e_4";
            RowDefinition row_e_4_0 = new RowDefinition();
            row_e_4_0.Height = new GridLength(1F, GridUnitType.Star);
            e_4.RowDefinitions.Add(row_e_4_0);
            RowDefinition row_e_4_1 = new RowDefinition();
            row_e_4_1.Height = new GridLength(1F, GridUnitType.Star);
            e_4.RowDefinitions.Add(row_e_4_1);
            RowDefinition row_e_4_2 = new RowDefinition();
            row_e_4_2.Height = new GridLength(1F, GridUnitType.Star);
            e_4.RowDefinitions.Add(row_e_4_2);
            Grid.SetRow(e_4, 1);
            // e_5 element
            Button e_5 = new Button();
            e_4.Children.Add(e_5);
            e_5.Name = "e_5";
            e_5.Margin = new Thickness(5F, 5F, 5F, 5F);
            e_5.HorizontalAlignment = HorizontalAlignment.Stretch;
            e_5.VerticalAlignment = VerticalAlignment.Stretch;
            e_5.BorderBrush = new SolidColorBrush(new ColorW(128, 96, 55, 255));
            e_5.BorderThickness = new Thickness(5F, 5F, 5F, 5F);
            e_5.FontSize = 32F;
            e_5.Content = "Video";
            Grid.SetRow(e_5, 0);
            Binding binding_e_5_Command = new Binding("Menu1_Command");
            e_5.SetBinding(Button.CommandProperty, binding_e_5_Command);
            // e_6 element
            Button e_6 = new Button();
            e_4.Children.Add(e_6);
            e_6.Name = "e_6";
            e_6.Margin = new Thickness(5F, 5F, 5F, 5F);
            e_6.HorizontalAlignment = HorizontalAlignment.Stretch;
            e_6.VerticalAlignment = VerticalAlignment.Stretch;
            e_6.BorderBrush = new SolidColorBrush(new ColorW(128, 96, 55, 255));
            e_6.BorderThickness = new Thickness(5F, 5F, 5F, 5F);
            e_6.FontSize = 32F;
            e_6.Content = "Sonido";
            Grid.SetRow(e_6, 1);
            Binding binding_e_6_Command = new Binding("Menu2_Command");
            e_6.SetBinding(Button.CommandProperty, binding_e_6_Command);
            // e_7 element
            Button e_7 = new Button();
            e_4.Children.Add(e_7);
            e_7.Name = "e_7";
            e_7.Margin = new Thickness(5F, 5F, 5F, 5F);
            e_7.HorizontalAlignment = HorizontalAlignment.Stretch;
            e_7.VerticalAlignment = VerticalAlignment.Stretch;
            e_7.BorderBrush = new SolidColorBrush(new ColorW(128, 96, 55, 255));
            e_7.BorderThickness = new Thickness(5F, 5F, 5F, 5F);
            e_7.FontSize = 32F;
            e_7.Content = "Creditos";
            Grid.SetRow(e_7, 2);
            Binding binding_e_7_Command = new Binding("Menu3_Command");
            e_7.SetBinding(Button.CommandProperty, binding_e_7_Command);
            // e_8 element
            Grid e_8 = new Grid();
            e_2.Children.Add(e_8);
            e_8.Name = "e_8";
            Grid.SetRow(e_8, 2);
            // e_9 element
            Button e_9 = new Button();
            e_8.Children.Add(e_9);
            e_9.Name = "e_9";
            e_9.Margin = new Thickness(5F, 5F, 5F, 5F);
            e_9.HorizontalAlignment = HorizontalAlignment.Stretch;
            e_9.VerticalAlignment = VerticalAlignment.Stretch;
            e_9.BorderBrush = new SolidColorBrush(new ColorW(128, 96, 55, 255));
            e_9.BorderThickness = new Thickness(5F, 5F, 5F, 5F);
            e_9.Foreground = new SolidColorBrush(new ColorW(255, 255, 255, 255));
            e_9.FontSize = 32F;
            e_9.Content = "Desconectarme";
            Binding binding_e_9_Command = new Binding("Logout_Command");
            e_9.SetBinding(Button.CommandProperty, binding_e_9_Command);
            return e_0;
        }
    }
}
