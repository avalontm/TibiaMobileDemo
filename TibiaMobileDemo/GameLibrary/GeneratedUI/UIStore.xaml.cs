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
    public partial class UIStore : UserControl {
        
        private Grid e_0;
        
        private Border e_1;
        
        private Grid e_2;
        
        private ImageButton e_3;
        
        private Image e_4;
        
        private TextBlock e_5;
        
        private Grid e_6;
        
        private Grid e_7;
        
        private ScrollViewer e_8;
        
        private ItemsControl e_9;
        
        public UIStore() {
            Style style = UserControlStyle.CreateUserControlStyle();
            style.TargetType = this.GetType();
            this.Style = style;
            this.InitializeComponent();
        }
        
        private void InitializeComponent() {
            // e_0 element
            this.e_0 = new Grid();
            this.Content = this.e_0;
            this.e_0.Name = "e_0";
            this.e_0.Background = new SolidColorBrush(new ColorW(37, 37, 37, 255));
            RowDefinition row_e_0_0 = new RowDefinition();
            row_e_0_0.Height = new GridLength(0.15F, GridUnitType.Star);
            this.e_0.RowDefinitions.Add(row_e_0_0);
            RowDefinition row_e_0_1 = new RowDefinition();
            row_e_0_1.Height = new GridLength(1F, GridUnitType.Star);
            this.e_0.RowDefinitions.Add(row_e_0_1);
            RowDefinition row_e_0_2 = new RowDefinition();
            row_e_0_2.Height = new GridLength(1F, GridUnitType.Auto);
            this.e_0.RowDefinitions.Add(row_e_0_2);
            // e_1 element
            this.e_1 = new Border();
            this.e_0.Children.Add(this.e_1);
            this.e_1.Name = "e_1";
            this.e_1.Margin = new Thickness(0F, 0F, 0F, 0F);
            this.e_1.HorizontalAlignment = HorizontalAlignment.Stretch;
            this.e_1.VerticalAlignment = VerticalAlignment.Stretch;
            this.e_1.Background = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            this.e_1.Padding = new Thickness(0F, 0F, 0F, 0F);
            Grid.SetRow(this.e_1, 0);
            // e_2 element
            this.e_2 = new Grid();
            this.e_1.Child = this.e_2;
            this.e_2.Name = "e_2";
            this.e_2.Margin = new Thickness(2F, 2F, 2F, 2F);
            ColumnDefinition col_e_2_0 = new ColumnDefinition();
            col_e_2_0.Width = new GridLength(1F, GridUnitType.Auto);
            this.e_2.ColumnDefinitions.Add(col_e_2_0);
            ColumnDefinition col_e_2_1 = new ColumnDefinition();
            col_e_2_1.Width = new GridLength(1F, GridUnitType.Star);
            this.e_2.ColumnDefinitions.Add(col_e_2_1);
            ColumnDefinition col_e_2_2 = new ColumnDefinition();
            col_e_2_2.Width = new GridLength(1F, GridUnitType.Auto);
            this.e_2.ColumnDefinitions.Add(col_e_2_2);
            // e_3 element
            this.e_3 = new ImageButton();
            this.e_2.Children.Add(this.e_3);
            this.e_3.Name = "e_3";
            this.e_3.Margin = new Thickness(5F, 0F, 5F, 0F);
            this.e_3.HorizontalAlignment = HorizontalAlignment.Stretch;
            this.e_3.VerticalAlignment = VerticalAlignment.Stretch;
            this.e_3.Background = new SolidColorBrush(new ColorW(255, 255, 255, 0));
            Binding binding_e_3_Command = new Binding("BackCommand");
            this.e_3.SetBinding(ImageButton.CommandProperty, binding_e_3_Command);
            // e_4 element
            this.e_4 = new Image();
            this.e_3.Content = this.e_4;
            this.e_4.Name = "e_4";
            BitmapImage e_4_bm = new BitmapImage();
            e_4_bm.TextureAsset = "Images/ic_back";
            this.e_4.Source = e_4_bm;
            this.e_4.Stretch = Stretch.Uniform;
            // e_5 element
            this.e_5 = new TextBlock();
            this.e_2.Children.Add(this.e_5);
            this.e_5.Name = "e_5";
            this.e_5.Margin = new Thickness(5F, 5F, 5F, 5F);
            this.e_5.HorizontalAlignment = HorizontalAlignment.Center;
            this.e_5.VerticalAlignment = VerticalAlignment.Center;
            this.e_5.Foreground = new SolidColorBrush(new ColorW(255, 255, 255, 255));
            this.e_5.Text = "Tienda";
            this.e_5.FontSize = 32F;
            this.e_5.FontStyle = FontStyle.Bold;
            Grid.SetColumn(this.e_5, 0);
            Grid.SetColumnSpan(this.e_5, 3);
            // e_6 element
            this.e_6 = new Grid();
            this.e_2.Children.Add(this.e_6);
            this.e_6.Name = "e_6";
            this.e_6.Margin = new Thickness(5F, 0F, 5F, 0F);
            ColumnDefinition col_e_6_0 = new ColumnDefinition();
            col_e_6_0.Width = new GridLength(1F, GridUnitType.Auto);
            this.e_6.ColumnDefinitions.Add(col_e_6_0);
            ColumnDefinition col_e_6_1 = new ColumnDefinition();
            col_e_6_1.Width = new GridLength(1F, GridUnitType.Auto);
            this.e_6.ColumnDefinitions.Add(col_e_6_1);
            Grid.SetColumn(this.e_6, 2);
            // e_7 element
            this.e_7 = new Grid();
            this.e_0.Children.Add(this.e_7);
            this.e_7.Name = "e_7";
            Grid.SetRow(this.e_7, 1);
            // e_8 element
            this.e_8 = new ScrollViewer();
            this.e_7.Children.Add(this.e_8);
            this.e_8.Name = "e_8";
            // e_9 element
            this.e_9 = new ItemsControl();
            this.e_8.Content = this.e_9;
            this.e_9.Name = "e_9";
            Func<UIElement, UIElement> e_9_iptFunc = e_9_iptMethod;
            ControlTemplate e_9_ipt = new ControlTemplate(e_9_iptFunc);
            this.e_9.ItemsPanel = e_9_ipt;
            Func<UIElement, UIElement> e_9_dtFunc = e_9_dtMethod;
            this.e_9.ItemTemplate = new DataTemplate(e_9_dtFunc);
            Binding binding_e_9_ItemsSource = new Binding("Items");
            this.e_9.SetBinding(ItemsControl.ItemsSourceProperty, binding_e_9_ItemsSource);
            ImageManager.Instance.AddImage("Images/ic_back");
            FontManager.Instance.AddFont("Segoe UI", 32F, FontStyle.Bold, "Segoe_UI_24_Bold");
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Bold, "Segoe_UI_9_Bold");
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
            e_11.Height = 200F;
            e_11.Width = 200F;
            e_11.Margin = new Thickness(5F, 5F, 5F, 5F);
            e_11.Background = new SolidColorBrush(new ColorW(69, 69, 69, 255));
            e_11.BorderBrush = new SolidColorBrush(new ColorW(69, 69, 69, 255));
            e_11.BorderThickness = new Thickness(1F, 1F, 1F, 1F);
            // e_12 element
            Grid e_12 = new Grid();
            e_11.Child = e_12;
            e_12.Name = "e_12";
            RowDefinition row_e_12_0 = new RowDefinition();
            row_e_12_0.Height = new GridLength(1F, GridUnitType.Auto);
            e_12.RowDefinitions.Add(row_e_12_0);
            RowDefinition row_e_12_1 = new RowDefinition();
            row_e_12_1.Height = new GridLength(1F, GridUnitType.Star);
            e_12.RowDefinitions.Add(row_e_12_1);
            RowDefinition row_e_12_2 = new RowDefinition();
            row_e_12_2.Height = new GridLength(1F, GridUnitType.Auto);
            e_12.RowDefinitions.Add(row_e_12_2);
            // e_13 element
            TextBlock e_13 = new TextBlock();
            e_12.Children.Add(e_13);
            e_13.Name = "e_13";
            e_13.Margin = new Thickness(5F, 5F, 5F, 5F);
            e_13.HorizontalAlignment = HorizontalAlignment.Center;
            e_13.VerticalAlignment = VerticalAlignment.Center;
            e_13.TextAlignment = TextAlignment.Center;
            e_13.FontStyle = FontStyle.Bold;
            Grid.SetRow(e_13, 0);
            Binding binding_e_13_Text = new Binding("name");
            e_13.SetBinding(TextBlock.TextProperty, binding_e_13_Text);
            // e_14 element
            ImageButton e_14 = new ImageButton();
            e_12.Children.Add(e_14);
            e_14.Name = "e_14";
            e_14.Margin = new Thickness(5F, 5F, 5F, 5F);
            e_14.HorizontalAlignment = HorizontalAlignment.Stretch;
            e_14.VerticalAlignment = VerticalAlignment.Stretch;
            Grid.SetRow(e_14, 1);
            Binding binding_e_14_Command = new Binding("command");
            e_14.SetBinding(ImageButton.CommandProperty, binding_e_14_Command);
            Binding binding_e_14_CommandParameter = new Binding();
            e_14.SetBinding(ImageButton.CommandParameterProperty, binding_e_14_CommandParameter);
            // e_15 element
            Image e_15 = new Image();
            e_14.Content = e_15;
            e_15.Name = "e_15";
            e_15.Height = 64F;
            e_15.Width = 64F;
            e_15.HorizontalAlignment = HorizontalAlignment.Stretch;
            e_15.VerticalAlignment = VerticalAlignment.Stretch;
            e_15.Stretch = Stretch.Fill;
            Binding binding_e_15_Source = new Binding("image");
            e_15.SetBinding(Image.SourceProperty, binding_e_15_Source);
            // e_16 element
            TextBlock e_16 = new TextBlock();
            e_12.Children.Add(e_16);
            e_16.Name = "e_16";
            e_16.Margin = new Thickness(5F, 5F, 5F, 5F);
            e_16.HorizontalAlignment = HorizontalAlignment.Center;
            e_16.VerticalAlignment = VerticalAlignment.Center;
            e_16.TextAlignment = TextAlignment.Center;
            e_16.FontStyle = FontStyle.Bold;
            Grid.SetRow(e_16, 2);
            Binding binding_e_16_Text = new Binding("price");
            binding_e_16_Text.StringFormat = "{0:C}";
            e_16.SetBinding(TextBlock.TextProperty, binding_e_16_Text);
            return e_11;
        }
    }
}
