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
    public partial class UIManager : UserControl {
        
        private Grid e_0;
        
        private Border e_1;
        
        private Grid e_2;
        
        private ImageButton e_3;
        
        private Image e_4;
        
        private TextBlock e_5;
        
        private Grid e_6;
        
        private ImageButton e_7;
        
        private Image e_8;
        
        private ImageButton e_9;
        
        private Image e_10;
        
        private Grid e_11;
        
        private Grid e_12;
        
        private ListBox e_13;
        
        public UIManager() {
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
            this.e_5.Text = "Mi cuenta";
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
            this.e_7 = new ImageButton();
            this.e_6.Children.Add(this.e_7);
            this.e_7.Name = "e_7";
            this.e_7.Margin = new Thickness(5F, 0F, 5F, 0F);
            this.e_7.HorizontalAlignment = HorizontalAlignment.Stretch;
            this.e_7.VerticalAlignment = VerticalAlignment.Stretch;
            this.e_7.Background = new SolidColorBrush(new ColorW(255, 255, 255, 0));
            Grid.SetColumn(this.e_7, 0);
            Binding binding_e_7_Command = new Binding("StoreCommand");
            this.e_7.SetBinding(ImageButton.CommandProperty, binding_e_7_Command);
            // e_8 element
            this.e_8 = new Image();
            this.e_7.Content = this.e_8;
            this.e_8.Name = "e_8";
            BitmapImage e_8_bm = new BitmapImage();
            e_8_bm.TextureAsset = "ui/ic_shop";
            this.e_8.Source = e_8_bm;
            this.e_8.Stretch = Stretch.Uniform;
            // e_9 element
            this.e_9 = new ImageButton();
            this.e_6.Children.Add(this.e_9);
            this.e_9.Name = "e_9";
            this.e_9.Margin = new Thickness(5F, 0F, 5F, 0F);
            this.e_9.HorizontalAlignment = HorizontalAlignment.Stretch;
            this.e_9.VerticalAlignment = VerticalAlignment.Stretch;
            this.e_9.Background = new SolidColorBrush(new ColorW(255, 255, 255, 0));
            Grid.SetColumn(this.e_9, 1);
            Binding binding_e_9_Command = new Binding("CreateCommand");
            this.e_9.SetBinding(ImageButton.CommandProperty, binding_e_9_Command);
            // e_10 element
            this.e_10 = new Image();
            this.e_9.Content = this.e_10;
            this.e_10.Name = "e_10";
            BitmapImage e_10_bm = new BitmapImage();
            e_10_bm.TextureAsset = "Images/ic_add";
            this.e_10.Source = e_10_bm;
            this.e_10.Stretch = Stretch.Uniform;
            // e_11 element
            this.e_11 = new Grid();
            this.e_0.Children.Add(this.e_11);
            this.e_11.Name = "e_11";
            this.e_11.Margin = new Thickness(5F, 5F, 5F, 5F);
            RowDefinition row_e_11_0 = new RowDefinition();
            row_e_11_0.Height = new GridLength(1F, GridUnitType.Auto);
            this.e_11.RowDefinitions.Add(row_e_11_0);
            RowDefinition row_e_11_1 = new RowDefinition();
            row_e_11_1.Height = new GridLength(1F, GridUnitType.Star);
            this.e_11.RowDefinitions.Add(row_e_11_1);
            RowDefinition row_e_11_2 = new RowDefinition();
            row_e_11_2.Height = new GridLength(1F, GridUnitType.Auto);
            this.e_11.RowDefinitions.Add(row_e_11_2);
            Grid.SetRow(this.e_11, 1);
            // e_12 element
            this.e_12 = new Grid();
            this.e_11.Children.Add(this.e_12);
            this.e_12.Name = "e_12";
            Grid.SetRow(this.e_12, 0);
            // e_13 element
            this.e_13 = new ListBox();
            this.e_11.Children.Add(this.e_13);
            this.e_13.Name = "e_13";
            Func<UIElement, UIElement> e_13_dtFunc = e_13_dtMethod;
            this.e_13.ItemTemplate = new DataTemplate(e_13_dtFunc);
            this.e_13.SelectionMode = SelectionMode.Single;
            Grid.SetRow(this.e_13, 1);
            Binding binding_e_13_ItemsSource = new Binding("Players");
            this.e_13.SetBinding(ListBox.ItemsSourceProperty, binding_e_13_ItemsSource);
            ImageManager.Instance.AddImage("Images/ic_back");
            ImageManager.Instance.AddImage("ui/ic_shop");
            ImageManager.Instance.AddImage("Images/ic_add");
            ImageManager.Instance.AddImage("ui/iu_bt");
            FontManager.Instance.AddFont("Segoe UI", 32F, FontStyle.Bold, "Segoe_UI_24_Bold");
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Bold, "Segoe_UI_9_Bold");
        }
        
        private static UIElement e_13_dtMethod(UIElement parent) {
            // e_14 element
            Border e_14 = new Border();
            e_14.Parent = parent;
            e_14.Name = "e_14";
            e_14.Margin = new Thickness(5F, 5F, 5F, 5F);
            e_14.BorderBrush = new SolidColorBrush(new ColorW(93, 93, 94, 255));
            e_14.BorderThickness = new Thickness(1F, 1F, 1F, 1F);
            // e_15 element
            Grid e_15 = new Grid();
            e_14.Child = e_15;
            e_15.Name = "e_15";
            ColumnDefinition col_e_15_0 = new ColumnDefinition();
            col_e_15_0.Width = new GridLength(1F, GridUnitType.Auto);
            e_15.ColumnDefinitions.Add(col_e_15_0);
            ColumnDefinition col_e_15_1 = new ColumnDefinition();
            col_e_15_1.Width = new GridLength(1F, GridUnitType.Star);
            e_15.ColumnDefinitions.Add(col_e_15_1);
            ColumnDefinition col_e_15_2 = new ColumnDefinition();
            col_e_15_2.Width = new GridLength(1F, GridUnitType.Auto);
            e_15.ColumnDefinitions.Add(col_e_15_2);
            ColumnDefinition col_e_15_3 = new ColumnDefinition();
            col_e_15_3.Width = new GridLength(1F, GridUnitType.Auto);
            e_15.ColumnDefinitions.Add(col_e_15_3);
            // e_16 element
            Image e_16 = new Image();
            e_15.Children.Add(e_16);
            e_16.Name = "e_16";
            e_16.Height = 100F;
            e_16.Width = 100F;
            e_16.HorizontalAlignment = HorizontalAlignment.Center;
            e_16.VerticalAlignment = VerticalAlignment.Center;
            e_16.Stretch = Stretch.Fill;
            Grid.SetColumn(e_16, 0);
            Binding binding_e_16_Source = new Binding("image");
            e_16.SetBinding(Image.SourceProperty, binding_e_16_Source);
            // e_17 element
            Grid e_17 = new Grid();
            e_15.Children.Add(e_17);
            e_17.Name = "e_17";
            e_17.Margin = new Thickness(5F, 5F, 5F, 5F);
            RowDefinition row_e_17_0 = new RowDefinition();
            row_e_17_0.Height = new GridLength(1F, GridUnitType.Auto);
            e_17.RowDefinitions.Add(row_e_17_0);
            RowDefinition row_e_17_1 = new RowDefinition();
            row_e_17_1.Height = new GridLength(1F, GridUnitType.Auto);
            e_17.RowDefinitions.Add(row_e_17_1);
            RowDefinition row_e_17_2 = new RowDefinition();
            row_e_17_2.Height = new GridLength(1F, GridUnitType.Star);
            e_17.RowDefinitions.Add(row_e_17_2);
            Grid.SetColumn(e_17, 1);
            // e_18 element
            TextBlock e_18 = new TextBlock();
            e_17.Children.Add(e_18);
            e_18.Name = "e_18";
            e_18.Margin = new Thickness(2F, 2F, 2F, 2F);
            e_18.HorizontalAlignment = HorizontalAlignment.Left;
            e_18.TextAlignment = TextAlignment.Center;
            e_18.FontStyle = FontStyle.Bold;
            Grid.SetRow(e_18, 0);
            Binding binding_e_18_Text = new Binding("name");
            binding_e_18_Text.StringFormat = "Nombre: {0}";
            e_18.SetBinding(TextBlock.TextProperty, binding_e_18_Text);
            // e_19 element
            TextBlock e_19 = new TextBlock();
            e_17.Children.Add(e_19);
            e_19.Name = "e_19";
            e_19.Margin = new Thickness(2F, 2F, 2F, 2F);
            e_19.HorizontalAlignment = HorizontalAlignment.Left;
            e_19.TextAlignment = TextAlignment.Center;
            e_19.FontStyle = FontStyle.Bold;
            Grid.SetRow(e_19, 1);
            Binding binding_e_19_Text = new Binding("level");
            binding_e_19_Text.StringFormat = "Nivel: {0}";
            e_19.SetBinding(TextBlock.TextProperty, binding_e_19_Text);
            // e_20 element
            Grid e_20 = new Grid();
            e_17.Children.Add(e_20);
            e_20.Name = "e_20";
            Grid.SetRow(e_20, 2);
            // e_21 element
            ProgressBar e_21 = new ProgressBar();
            e_20.Children.Add(e_21);
            e_21.Name = "e_21";
            e_21.Margin = new Thickness(0F, 0F, 0F, 0F);
            e_21.HorizontalAlignment = HorizontalAlignment.Stretch;
            e_21.VerticalAlignment = VerticalAlignment.Stretch;
            e_21.Opacity = 1F;
            e_21.Background = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            e_21.Foreground = new SolidColorBrush(new ColorW(255, 255, 0, 255));
            Grid.SetRow(e_21, 0);
            Binding binding_e_21_Maximum = new Binding("experience_max");
            binding_e_21_Maximum.FallbackValue = "100";
            e_21.SetBinding(ProgressBar.MaximumProperty, binding_e_21_Maximum);
            Binding binding_e_21_Value = new Binding("experience");
            binding_e_21_Value.FallbackValue = "50";
            e_21.SetBinding(ProgressBar.ValueProperty, binding_e_21_Value);
            // e_22 element
            Grid e_22 = new Grid();
            e_20.Children.Add(e_22);
            e_22.Name = "e_22";
            e_22.HorizontalAlignment = HorizontalAlignment.Center;
            e_22.VerticalAlignment = VerticalAlignment.Center;
            ColumnDefinition col_e_22_0 = new ColumnDefinition();
            col_e_22_0.Width = new GridLength(1F, GridUnitType.Auto);
            e_22.ColumnDefinitions.Add(col_e_22_0);
            ColumnDefinition col_e_22_1 = new ColumnDefinition();
            col_e_22_1.Width = new GridLength(1F, GridUnitType.Auto);
            e_22.ColumnDefinitions.Add(col_e_22_1);
            ColumnDefinition col_e_22_2 = new ColumnDefinition();
            col_e_22_2.Width = new GridLength(1F, GridUnitType.Auto);
            e_22.ColumnDefinitions.Add(col_e_22_2);
            // e_23 element
            TextBlock e_23 = new TextBlock();
            e_22.Children.Add(e_23);
            e_23.Name = "e_23";
            e_23.Margin = new Thickness(2F, 2F, 2F, 2F);
            e_23.HorizontalAlignment = HorizontalAlignment.Left;
            e_23.TextAlignment = TextAlignment.Center;
            e_23.FontStyle = FontStyle.Bold;
            Grid.SetColumn(e_23, 0);
            Binding binding_e_23_Text = new Binding("experience");
            e_23.SetBinding(TextBlock.TextProperty, binding_e_23_Text);
            // e_24 element
            TextBlock e_24 = new TextBlock();
            e_22.Children.Add(e_24);
            e_24.Name = "e_24";
            e_24.Margin = new Thickness(2F, 2F, 2F, 2F);
            e_24.HorizontalAlignment = HorizontalAlignment.Left;
            e_24.Text = "/";
            e_24.TextAlignment = TextAlignment.Center;
            e_24.FontStyle = FontStyle.Bold;
            Grid.SetColumn(e_24, 1);
            // e_25 element
            TextBlock e_25 = new TextBlock();
            e_22.Children.Add(e_25);
            e_25.Name = "e_25";
            e_25.Margin = new Thickness(2F, 2F, 2F, 2F);
            e_25.HorizontalAlignment = HorizontalAlignment.Left;
            e_25.TextAlignment = TextAlignment.Center;
            e_25.FontStyle = FontStyle.Bold;
            Grid.SetColumn(e_25, 2);
            Binding binding_e_25_Text = new Binding("experience_max");
            e_25.SetBinding(TextBlock.TextProperty, binding_e_25_Text);
            // e_26 element
            Image e_26 = new Image();
            e_15.Children.Add(e_26);
            e_26.Name = "e_26";
            e_26.Height = 64F;
            e_26.Width = 64F;
            e_26.Margin = new Thickness(5F, 5F, 5F, 5F);
            e_26.HorizontalAlignment = HorizontalAlignment.Center;
            e_26.VerticalAlignment = VerticalAlignment.Center;
            BitmapImage e_26_bm = new BitmapImage();
            e_26_bm.TextureAsset = "ui/iu_bt";
            e_26.Source = e_26_bm;
            e_26.Stretch = Stretch.Uniform;
            Grid.SetColumn(e_26, 2);
            Binding binding_e_26_Visibility = new Binding("beta");
            e_26.SetBinding(Image.VisibilityProperty, binding_e_26_Visibility);
            // e_27 element
            Button e_27 = new Button();
            e_15.Children.Add(e_27);
            e_27.Name = "e_27";
            e_27.Width = 100F;
            e_27.Margin = new Thickness(2F, 2F, 2F, 2F);
            e_27.HorizontalAlignment = HorizontalAlignment.Stretch;
            e_27.VerticalAlignment = VerticalAlignment.Stretch;
            e_27.Content = "Entrar";
            Grid.SetColumn(e_27, 3);
            Binding binding_e_27_Command = new Binding("command");
            e_27.SetBinding(Button.CommandProperty, binding_e_27_Command);
            Binding binding_e_27_CommandParameter = new Binding("name");
            e_27.SetBinding(Button.CommandParameterProperty, binding_e_27_CommandParameter);
            return e_14;
        }
    }
}
