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
    public sealed class LootDictionary : ResourceDictionary {
        
        private static LootDictionary singleton = new LootDictionary();
        
        public LootDictionary() {
            this.InitializeResources();
        }
        
        public static LootDictionary Instance {
            get {
                return singleton;
            }
        }
        
        private void InitializeResources() {
            // Resource - [LootWindowTemplate] ControlTemplate
            Func<UIElement, UIElement> r_0_ctFunc = r_0_ctMethod;
            ControlTemplate r_0_ct = new ControlTemplate(r_0_ctFunc);
            this.Add("LootWindowTemplate", r_0_ct);
            ImageManager.Instance.AddImage("Images/ic_close");
            FontManager.Instance.AddFont("Segoe UI", 24F, FontStyle.Bold, "Segoe_UI_18_Bold");
        }
        
        private static UIElement e_9_iptMethod(UIElement parent) {
            // e_10 element
            WrapPanel e_10 = new WrapPanel();
            e_10.Parent = parent;
            e_10.Name = "e_10";
            e_10.IsItemsHost = true;
            e_10.Orientation = Orientation.Horizontal;
            return e_10;
        }
        
        private static UIElement e_9_dtMethod(UIElement parent) {
            // e_11 element
            Border e_11 = new Border();
            e_11.Parent = parent;
            e_11.Name = "e_11";
            e_11.Height = 100F;
            e_11.Width = 100F;
            e_11.Margin = new Thickness(5F, 5F, 5F, 5F);
            e_11.Background = new SolidColorBrush(new ColorW(69, 69, 69, 255));
            e_11.BorderThickness = new Thickness(3F, 3F, 3F, 3F);
            e_11.Padding = new Thickness(0F, 0F, 0F, 0F);
            Binding binding_e_11_BorderBrush = new Binding("select_color");
            e_11.SetBinding(Border.BorderBrushProperty, binding_e_11_BorderBrush);
            // e_12 element
            Grid e_12 = new Grid();
            e_11.Child = e_12;
            e_12.Name = "e_12";
            // e_13 element
            ImageButton e_13 = new ImageButton();
            e_12.Children.Add(e_13);
            e_13.Name = "e_13";
            e_13.Margin = new Thickness(0F, 0F, 0F, 0F);
            e_13.HorizontalAlignment = HorizontalAlignment.Stretch;
            e_13.VerticalAlignment = VerticalAlignment.Stretch;
            e_13.Padding = new Thickness(0F, 0F, 0F, 0F);
            Binding binding_e_13_Command = new Binding("command");
            e_13.SetBinding(ImageButton.CommandProperty, binding_e_13_Command);
            Binding binding_e_13_CommandParameter = new Binding();
            e_13.SetBinding(ImageButton.CommandParameterProperty, binding_e_13_CommandParameter);
            // e_14 element
            Grid e_14 = new Grid();
            e_13.Content = e_14;
            e_14.Name = "e_14";
            // e_15 element
            Image e_15 = new Image();
            e_14.Children.Add(e_15);
            e_15.Name = "e_15";
            e_15.Margin = new Thickness(10F, 10F, 10F, 10F);
            e_15.HorizontalAlignment = HorizontalAlignment.Stretch;
            e_15.VerticalAlignment = VerticalAlignment.Stretch;
            e_15.Stretch = Stretch.Fill;
            Binding binding_e_15_Source = new Binding("image");
            e_15.SetBinding(Image.SourceProperty, binding_e_15_Source);
            // e_16 element
            TextBlock e_16 = new TextBlock();
            e_14.Children.Add(e_16);
            e_16.Name = "e_16";
            e_16.Margin = new Thickness(0F, 0F, 5F, 5F);
            e_16.HorizontalAlignment = HorizontalAlignment.Right;
            e_16.VerticalAlignment = VerticalAlignment.Bottom;
            e_16.TextAlignment = TextAlignment.Center;
            e_16.FontSize = 24F;
            e_16.FontStyle = FontStyle.Bold;
            Binding binding_e_16_Text = new Binding("count");
            e_16.SetBinding(TextBlock.TextProperty, binding_e_16_Text);
            return e_11;
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
            row_e_2_1.Height = new GridLength(1F, GridUnitType.Star);
            e_2.RowDefinitions.Add(row_e_2_1);
            RowDefinition row_e_2_2 = new RowDefinition();
            row_e_2_2.Height = new GridLength(1F, GridUnitType.Auto);
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
            Grid e_3 = new Grid();
            PART_WindowTitleBorder.Child = e_3;
            e_3.Name = "e_3";
            ColumnDefinition col_e_3_0 = new ColumnDefinition();
            col_e_3_0.Width = new GridLength(1F, GridUnitType.Auto);
            e_3.ColumnDefinitions.Add(col_e_3_0);
            ColumnDefinition col_e_3_1 = new ColumnDefinition();
            col_e_3_1.Width = new GridLength(1F, GridUnitType.Star);
            e_3.ColumnDefinitions.Add(col_e_3_1);
            ColumnDefinition col_e_3_2 = new ColumnDefinition();
            col_e_3_2.Width = new GridLength(1F, GridUnitType.Auto);
            e_3.ColumnDefinitions.Add(col_e_3_2);
            // e_4 element
            TextBlock e_4 = new TextBlock();
            e_3.Children.Add(e_4);
            e_4.Name = "e_4";
            e_4.Margin = new Thickness(5F, 5F, 5F, 5F);
            e_4.HorizontalAlignment = HorizontalAlignment.Center;
            e_4.VerticalAlignment = VerticalAlignment.Center;
            e_4.Foreground = new SolidColorBrush(new ColorW(255, 255, 255, 255));
            e_4.Text = "LOOT";
            Grid.SetColumn(e_4, 0);
            Grid.SetColumnSpan(e_4, 3);
            // e_5 element
            ImageButton e_5 = new ImageButton();
            e_3.Children.Add(e_5);
            e_5.Name = "e_5";
            e_5.Width = 48F;
            e_5.HorizontalAlignment = HorizontalAlignment.Center;
            e_5.VerticalAlignment = VerticalAlignment.Stretch;
            e_5.Background = new SolidColorBrush(new ColorW(255, 255, 255, 0));
            Grid.SetColumn(e_5, 2);
            Binding binding_e_5_Command = new Binding("HideCommand");
            e_5.SetBinding(ImageButton.CommandProperty, binding_e_5_Command);
            // e_6 element
            Image e_6 = new Image();
            e_5.Content = e_6;
            e_6.Name = "e_6";
            e_6.Width = 48F;
            e_6.HorizontalAlignment = HorizontalAlignment.Stretch;
            e_6.VerticalAlignment = VerticalAlignment.Stretch;
            BitmapImage e_6_bm = new BitmapImage();
            e_6_bm.TextureAsset = "Images/ic_close";
            e_6.Source = e_6_bm;
            // e_7 element
            Grid e_7 = new Grid();
            e_2.Children.Add(e_7);
            e_7.Name = "e_7";
            Grid.SetRow(e_7, 1);
            // e_8 element
            ScrollViewer e_8 = new ScrollViewer();
            e_7.Children.Add(e_8);
            e_8.Name = "e_8";
            // e_9 element
            ItemsControl e_9 = new ItemsControl();
            e_8.Content = e_9;
            e_9.Name = "e_9";
            Func<UIElement, UIElement> e_9_iptFunc = e_9_iptMethod;
            ControlTemplate e_9_ipt = new ControlTemplate(e_9_iptFunc);
            e_9.ItemsPanel = e_9_ipt;
            Func<UIElement, UIElement> e_9_dtFunc = e_9_dtMethod;
            e_9.ItemTemplate = new DataTemplate(e_9_dtFunc);
            DragDrop.SetIsDragSource(e_9, true);
            DragDrop.SetIsDropTarget(e_9, true);
            Binding binding_e_9_ItemsSource = new Binding("Items");
            e_9.SetBinding(ItemsControl.ItemsSourceProperty, binding_e_9_ItemsSource);
            return e_0;
        }
    }
}
