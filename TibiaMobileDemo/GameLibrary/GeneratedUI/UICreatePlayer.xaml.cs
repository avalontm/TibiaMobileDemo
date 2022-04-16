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
    public partial class UICreatePlayer : UserControl {
        
        private Grid e_0;
        
        private Border e_1;
        
        private Grid e_2;
        
        private ImageButton e_3;
        
        private Image e_4;
        
        private TextBlock e_5;
        
        private Grid e_6;
        
        private Border e_7;
        
        private Grid e_8;
        
        private Grid e_9;
        
        private TextBlock e_10;
        
        private Border e_11;
        
        private TextBox e_12;
        
        private Grid e_13;
        
        private TextBlock e_14;
        
        private Grid e_15;
        
        private CheckBox e_16;
        
        private CheckBox e_17;
        
        private Button e_18;
        
        private Border e_19;
        
        private Grid e_20;
        
        private Grid e_21;
        
        private Image e_22;
        
        private ToggleButton e_23;
        
        private ToggleButton e_24;
        
        private ToggleButton e_25;
        
        private ToggleButton e_26;
        
        private Grid e_27;
        
        private ScrollViewer e_28;
        
        private ItemsControl e_29;
        
        public UICreatePlayer() {
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
            this.e_1.VerticalAlignment = VerticalAlignment.Center;
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
            this.e_4.HorizontalAlignment = HorizontalAlignment.Stretch;
            this.e_4.VerticalAlignment = VerticalAlignment.Stretch;
            BitmapImage e_4_bm = new BitmapImage();
            e_4_bm.TextureAsset = "Images/ic_back";
            this.e_4.Source = e_4_bm;
            // e_5 element
            this.e_5 = new TextBlock();
            this.e_2.Children.Add(this.e_5);
            this.e_5.Name = "e_5";
            this.e_5.Margin = new Thickness(5F, 5F, 5F, 5F);
            this.e_5.HorizontalAlignment = HorizontalAlignment.Center;
            this.e_5.VerticalAlignment = VerticalAlignment.Center;
            this.e_5.Foreground = new SolidColorBrush(new ColorW(255, 255, 255, 255));
            this.e_5.Text = "Crear personaje";
            this.e_5.FontSize = 32F;
            this.e_5.FontStyle = FontStyle.Bold;
            Grid.SetColumn(this.e_5, 0);
            Grid.SetColumnSpan(this.e_5, 3);
            // e_6 element
            this.e_6 = new Grid();
            this.e_0.Children.Add(this.e_6);
            this.e_6.Name = "e_6";
            ColumnDefinition col_e_6_0 = new ColumnDefinition();
            col_e_6_0.Width = new GridLength(4F, GridUnitType.Star);
            this.e_6.ColumnDefinitions.Add(col_e_6_0);
            ColumnDefinition col_e_6_1 = new ColumnDefinition();
            col_e_6_1.Width = new GridLength(6F, GridUnitType.Star);
            this.e_6.ColumnDefinitions.Add(col_e_6_1);
            Grid.SetRow(this.e_6, 1);
            // e_7 element
            this.e_7 = new Border();
            this.e_6.Children.Add(this.e_7);
            this.e_7.Name = "e_7";
            this.e_7.Margin = new Thickness(5F, 5F, 5F, 5F);
            this.e_7.Background = new SolidColorBrush(new ColorW(33, 33, 33, 255));
            this.e_7.BorderBrush = new SolidColorBrush(new ColorW(69, 69, 69, 255));
            this.e_7.BorderThickness = new Thickness(3F, 3F, 3F, 3F);
            this.e_7.Padding = new Thickness(5F, 5F, 5F, 5F);
            Grid.SetColumn(this.e_7, 0);
            // e_8 element
            this.e_8 = new Grid();
            this.e_7.Child = this.e_8;
            this.e_8.Name = "e_8";
            RowDefinition row_e_8_0 = new RowDefinition();
            row_e_8_0.Height = new GridLength(1F, GridUnitType.Auto);
            this.e_8.RowDefinitions.Add(row_e_8_0);
            RowDefinition row_e_8_1 = new RowDefinition();
            row_e_8_1.Height = new GridLength(1F, GridUnitType.Auto);
            this.e_8.RowDefinitions.Add(row_e_8_1);
            RowDefinition row_e_8_2 = new RowDefinition();
            row_e_8_2.Height = new GridLength(1F, GridUnitType.Star);
            this.e_8.RowDefinitions.Add(row_e_8_2);
            RowDefinition row_e_8_3 = new RowDefinition();
            row_e_8_3.Height = new GridLength(1F, GridUnitType.Auto);
            this.e_8.RowDefinitions.Add(row_e_8_3);
            // e_9 element
            this.e_9 = new Grid();
            this.e_8.Children.Add(this.e_9);
            this.e_9.Name = "e_9";
            this.e_9.Margin = new Thickness(5F, 5F, 5F, 5F);
            RowDefinition row_e_9_0 = new RowDefinition();
            row_e_9_0.Height = new GridLength(1F, GridUnitType.Auto);
            this.e_9.RowDefinitions.Add(row_e_9_0);
            RowDefinition row_e_9_1 = new RowDefinition();
            row_e_9_1.Height = new GridLength(1F, GridUnitType.Auto);
            this.e_9.RowDefinitions.Add(row_e_9_1);
            Grid.SetRow(this.e_9, 0);
            // e_10 element
            this.e_10 = new TextBlock();
            this.e_9.Children.Add(this.e_10);
            this.e_10.Name = "e_10";
            this.e_10.HorizontalAlignment = HorizontalAlignment.Left;
            this.e_10.VerticalAlignment = VerticalAlignment.Center;
            this.e_10.Text = "Nombre";
            this.e_10.FontSize = 24F;
            Grid.SetRow(this.e_10, 0);
            // e_11 element
            this.e_11 = new Border();
            this.e_9.Children.Add(this.e_11);
            this.e_11.Name = "e_11";
            this.e_11.Margin = new Thickness(5F, 5F, 5F, 5F);
            this.e_11.Background = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            this.e_11.BorderBrush = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            this.e_11.BorderThickness = new Thickness(3F, 3F, 3F, 3F);
            this.e_11.Padding = new Thickness(0F, 0F, 0F, 0F);
            Grid.SetRow(this.e_11, 1);
            // e_12 element
            this.e_12 = new TextBox();
            this.e_11.Child = this.e_12;
            this.e_12.Name = "e_12";
            this.e_12.HorizontalAlignment = HorizontalAlignment.Stretch;
            this.e_12.VerticalAlignment = VerticalAlignment.Center;
            this.e_12.FontSize = 32F;
            Binding binding_e_12_Text = new Binding("Name");
            this.e_12.SetBinding(TextBox.TextProperty, binding_e_12_Text);
            // e_13 element
            this.e_13 = new Grid();
            this.e_8.Children.Add(this.e_13);
            this.e_13.Name = "e_13";
            this.e_13.Margin = new Thickness(5F, 5F, 5F, 5F);
            RowDefinition row_e_13_0 = new RowDefinition();
            row_e_13_0.Height = new GridLength(1F, GridUnitType.Auto);
            this.e_13.RowDefinitions.Add(row_e_13_0);
            RowDefinition row_e_13_1 = new RowDefinition();
            row_e_13_1.Height = new GridLength(1F, GridUnitType.Auto);
            this.e_13.RowDefinitions.Add(row_e_13_1);
            Grid.SetRow(this.e_13, 1);
            // e_14 element
            this.e_14 = new TextBlock();
            this.e_13.Children.Add(this.e_14);
            this.e_14.Name = "e_14";
            this.e_14.HorizontalAlignment = HorizontalAlignment.Left;
            this.e_14.VerticalAlignment = VerticalAlignment.Center;
            this.e_14.Text = "Genero";
            this.e_14.FontSize = 24F;
            Grid.SetRow(this.e_14, 0);
            // e_15 element
            this.e_15 = new Grid();
            this.e_13.Children.Add(this.e_15);
            this.e_15.Name = "e_15";
            this.e_15.Margin = new Thickness(5F, 10F, 5F, 10F);
            ColumnDefinition col_e_15_0 = new ColumnDefinition();
            col_e_15_0.Width = new GridLength(1F, GridUnitType.Star);
            this.e_15.ColumnDefinitions.Add(col_e_15_0);
            ColumnDefinition col_e_15_1 = new ColumnDefinition();
            col_e_15_1.Width = new GridLength(1F, GridUnitType.Star);
            this.e_15.ColumnDefinitions.Add(col_e_15_1);
            Grid.SetRow(this.e_15, 1);
            // e_16 element
            this.e_16 = new CheckBox();
            this.e_15.Children.Add(this.e_16);
            this.e_16.Name = "e_16";
            this.e_16.HorizontalAlignment = HorizontalAlignment.Center;
            this.e_16.VerticalAlignment = VerticalAlignment.Center;
            this.e_16.FontSize = 24F;
            this.e_16.Content = "Mujer";
            Grid.SetColumn(this.e_16, 0);
            Binding binding_e_16_Command = new Binding("Female_Command");
            this.e_16.SetBinding(CheckBox.CommandProperty, binding_e_16_Command);
            Binding binding_e_16_IsChecked = new Binding("Female_Check");
            this.e_16.SetBinding(CheckBox.IsCheckedProperty, binding_e_16_IsChecked);
            // e_17 element
            this.e_17 = new CheckBox();
            this.e_15.Children.Add(this.e_17);
            this.e_17.Name = "e_17";
            this.e_17.HorizontalAlignment = HorizontalAlignment.Center;
            this.e_17.VerticalAlignment = VerticalAlignment.Center;
            this.e_17.FontSize = 24F;
            this.e_17.Content = "Hombre";
            Grid.SetColumn(this.e_17, 1);
            Binding binding_e_17_Command = new Binding("Male_Command");
            this.e_17.SetBinding(CheckBox.CommandProperty, binding_e_17_Command);
            Binding binding_e_17_IsChecked = new Binding("Male_Check");
            this.e_17.SetBinding(CheckBox.IsCheckedProperty, binding_e_17_IsChecked);
            // e_18 element
            this.e_18 = new Button();
            this.e_8.Children.Add(this.e_18);
            this.e_18.Name = "e_18";
            this.e_18.Height = 60F;
            this.e_18.Margin = new Thickness(5F, 5F, 5F, 10F);
            this.e_18.HorizontalAlignment = HorizontalAlignment.Stretch;
            this.e_18.VerticalAlignment = VerticalAlignment.Center;
            this.e_18.Background = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            this.e_18.Foreground = new SolidColorBrush(new ColorW(255, 255, 255, 255));
            this.e_18.HorizontalContentAlignment = HorizontalAlignment.Center;
            this.e_18.FontSize = 32F;
            this.e_18.Content = "Crear Personaje";
            Grid.SetRow(this.e_18, 3);
            Binding binding_e_18_Command = new Binding("CreateCommand");
            this.e_18.SetBinding(Button.CommandProperty, binding_e_18_Command);
            // e_19 element
            this.e_19 = new Border();
            this.e_6.Children.Add(this.e_19);
            this.e_19.Name = "e_19";
            this.e_19.Margin = new Thickness(5F, 5F, 5F, 5F);
            this.e_19.Background = new SolidColorBrush(new ColorW(33, 33, 33, 255));
            this.e_19.BorderBrush = new SolidColorBrush(new ColorW(69, 69, 69, 255));
            this.e_19.BorderThickness = new Thickness(3F, 3F, 3F, 3F);
            this.e_19.Padding = new Thickness(5F, 5F, 5F, 5F);
            Grid.SetColumn(this.e_19, 1);
            // e_20 element
            this.e_20 = new Grid();
            this.e_19.Child = this.e_20;
            this.e_20.Name = "e_20";
            ColumnDefinition col_e_20_0 = new ColumnDefinition();
            col_e_20_0.Width = new GridLength(120F, GridUnitType.Pixel);
            this.e_20.ColumnDefinitions.Add(col_e_20_0);
            ColumnDefinition col_e_20_1 = new ColumnDefinition();
            col_e_20_1.Width = new GridLength(1F, GridUnitType.Star);
            this.e_20.ColumnDefinitions.Add(col_e_20_1);
            // e_21 element
            this.e_21 = new Grid();
            this.e_20.Children.Add(this.e_21);
            this.e_21.Name = "e_21";
            RowDefinition row_e_21_0 = new RowDefinition();
            row_e_21_0.Height = new GridLength(1F, GridUnitType.Auto);
            this.e_21.RowDefinitions.Add(row_e_21_0);
            RowDefinition row_e_21_1 = new RowDefinition();
            row_e_21_1.Height = new GridLength(20F, GridUnitType.Pixel);
            this.e_21.RowDefinitions.Add(row_e_21_1);
            RowDefinition row_e_21_2 = new RowDefinition();
            row_e_21_2.Height = new GridLength(1F, GridUnitType.Star);
            this.e_21.RowDefinitions.Add(row_e_21_2);
            RowDefinition row_e_21_3 = new RowDefinition();
            row_e_21_3.Height = new GridLength(1F, GridUnitType.Star);
            this.e_21.RowDefinitions.Add(row_e_21_3);
            RowDefinition row_e_21_4 = new RowDefinition();
            row_e_21_4.Height = new GridLength(1F, GridUnitType.Star);
            this.e_21.RowDefinitions.Add(row_e_21_4);
            RowDefinition row_e_21_5 = new RowDefinition();
            row_e_21_5.Height = new GridLength(1F, GridUnitType.Star);
            this.e_21.RowDefinitions.Add(row_e_21_5);
            RowDefinition row_e_21_6 = new RowDefinition();
            row_e_21_6.Height = new GridLength(1F, GridUnitType.Auto);
            this.e_21.RowDefinitions.Add(row_e_21_6);
            Grid.SetColumn(this.e_21, 0);
            // e_22 element
            this.e_22 = new Image();
            this.e_21.Children.Add(this.e_22);
            this.e_22.Name = "e_22";
            this.e_22.Height = 100F;
            this.e_22.Width = 100F;
            this.e_22.Margin = new Thickness(2F, 10F, 0F, 0F);
            this.e_22.HorizontalAlignment = HorizontalAlignment.Stretch;
            this.e_22.VerticalAlignment = VerticalAlignment.Stretch;
            this.e_22.Stretch = Stretch.Fill;
            Grid.SetRow(this.e_22, 0);
            Binding binding_e_22_Source = new Binding("Outfit");
            this.e_22.SetBinding(Image.SourceProperty, binding_e_22_Source);
            // e_23 element
            this.e_23 = new ToggleButton();
            this.e_21.Children.Add(this.e_23);
            this.e_23.Name = "e_23";
            this.e_23.Margin = new Thickness(2F, 2F, 2F, 2F);
            this.e_23.Background = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            this.e_23.Foreground = new SolidColorBrush(new ColorW(255, 255, 255, 255));
            this.e_23.FontStyle = FontStyle.Bold;
            this.e_23.Content = "Head";
            Grid.SetRow(this.e_23, 2);
            Binding binding_e_23_Command = new Binding("HeadCommand");
            this.e_23.SetBinding(ToggleButton.CommandProperty, binding_e_23_Command);
            Binding binding_e_23_IsChecked = new Binding("HeadChecked");
            this.e_23.SetBinding(ToggleButton.IsCheckedProperty, binding_e_23_IsChecked);
            // e_24 element
            this.e_24 = new ToggleButton();
            this.e_21.Children.Add(this.e_24);
            this.e_24.Name = "e_24";
            this.e_24.Margin = new Thickness(2F, 2F, 2F, 2F);
            this.e_24.Background = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            this.e_24.Foreground = new SolidColorBrush(new ColorW(255, 255, 255, 255));
            this.e_24.FontStyle = FontStyle.Bold;
            this.e_24.Content = "Body";
            Grid.SetRow(this.e_24, 3);
            Binding binding_e_24_Command = new Binding("BodyCommand");
            this.e_24.SetBinding(ToggleButton.CommandProperty, binding_e_24_Command);
            Binding binding_e_24_IsChecked = new Binding("BodyChecked");
            this.e_24.SetBinding(ToggleButton.IsCheckedProperty, binding_e_24_IsChecked);
            // e_25 element
            this.e_25 = new ToggleButton();
            this.e_21.Children.Add(this.e_25);
            this.e_25.Name = "e_25";
            this.e_25.Margin = new Thickness(2F, 2F, 2F, 2F);
            this.e_25.Background = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            this.e_25.Foreground = new SolidColorBrush(new ColorW(255, 255, 255, 255));
            this.e_25.FontStyle = FontStyle.Bold;
            this.e_25.Content = "Legs";
            Grid.SetRow(this.e_25, 4);
            Binding binding_e_25_Command = new Binding("LegsCommand");
            this.e_25.SetBinding(ToggleButton.CommandProperty, binding_e_25_Command);
            Binding binding_e_25_IsChecked = new Binding("LegsChecked");
            this.e_25.SetBinding(ToggleButton.IsCheckedProperty, binding_e_25_IsChecked);
            // e_26 element
            this.e_26 = new ToggleButton();
            this.e_21.Children.Add(this.e_26);
            this.e_26.Name = "e_26";
            this.e_26.Margin = new Thickness(2F, 2F, 2F, 2F);
            this.e_26.Background = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            this.e_26.Foreground = new SolidColorBrush(new ColorW(255, 255, 255, 255));
            this.e_26.FontStyle = FontStyle.Bold;
            this.e_26.Content = "Feets";
            Grid.SetRow(this.e_26, 5);
            Binding binding_e_26_Command = new Binding("FeetsCommand");
            this.e_26.SetBinding(ToggleButton.CommandProperty, binding_e_26_Command);
            Binding binding_e_26_IsChecked = new Binding("FeetsChecked");
            this.e_26.SetBinding(ToggleButton.IsCheckedProperty, binding_e_26_IsChecked);
            // e_27 element
            this.e_27 = new Grid();
            this.e_20.Children.Add(this.e_27);
            this.e_27.Name = "e_27";
            Grid.SetColumn(this.e_27, 1);
            // e_28 element
            this.e_28 = new ScrollViewer();
            this.e_27.Children.Add(this.e_28);
            this.e_28.Name = "e_28";
            // e_29 element
            this.e_29 = new ItemsControl();
            this.e_28.Content = this.e_29;
            this.e_29.Name = "e_29";
            Func<UIElement, UIElement> e_29_iptFunc = e_29_iptMethod;
            ControlTemplate e_29_ipt = new ControlTemplate(e_29_iptFunc);
            this.e_29.ItemsPanel = e_29_ipt;
            Func<UIElement, UIElement> e_29_dtFunc = e_29_dtMethod;
            this.e_29.ItemTemplate = new DataTemplate(e_29_dtFunc);
            Binding binding_e_29_ItemsSource = new Binding("Items");
            this.e_29.SetBinding(ItemsControl.ItemsSourceProperty, binding_e_29_ItemsSource);
            ImageManager.Instance.AddImage("Images/ic_back");
            FontManager.Instance.AddFont("Segoe UI", 32F, FontStyle.Bold, "Segoe_UI_24_Bold");
            FontManager.Instance.AddFont("Segoe UI", 24F, FontStyle.Regular, "Segoe_UI_18_Regular");
            FontManager.Instance.AddFont("Segoe UI", 32F, FontStyle.Regular, "Segoe_UI_24_Regular");
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Bold, "Segoe_UI_9_Bold");
        }
        
        private static UIElement e_29_iptMethod(UIElement parent) {
            // e_30 element
            WrapPanel e_30 = new WrapPanel();
            e_30.Parent = parent;
            e_30.Name = "e_30";
            e_30.IsItemsHost = true;
            e_30.Orientation = Orientation.Horizontal;
            return e_30;
        }
        
        private static UIElement e_29_dtMethod(UIElement parent) {
            // e_31 element
            Border e_31 = new Border();
            e_31.Parent = parent;
            e_31.Name = "e_31";
            e_31.Height = 32F;
            e_31.Width = 32F;
            e_31.Margin = new Thickness(5F, 5F, 5F, 5F);
            e_31.BorderThickness = new Thickness(1F, 1F, 1F, 1F);
            e_31.Padding = new Thickness(1F, 1F, 1F, 1F);
            Binding binding_e_31_BorderBrush = new Binding("select_color");
            e_31.SetBinding(Border.BorderBrushProperty, binding_e_31_BorderBrush);
            // e_32 element
            ImageButton e_32 = new ImageButton();
            e_31.Child = e_32;
            e_32.Name = "e_32";
            e_32.Margin = new Thickness(0F, 0F, 0F, 0F);
            e_32.HorizontalAlignment = HorizontalAlignment.Stretch;
            e_32.VerticalAlignment = VerticalAlignment.Stretch;
            Binding binding_e_32_Background = new Binding("color");
            e_32.SetBinding(ImageButton.BackgroundProperty, binding_e_32_Background);
            Binding binding_e_32_Command = new Binding("command");
            e_32.SetBinding(ImageButton.CommandProperty, binding_e_32_Command);
            Binding binding_e_32_CommandParameter = new Binding();
            e_32.SetBinding(ImageButton.CommandParameterProperty, binding_e_32_CommandParameter);
            return e_31;
        }
    }
}
