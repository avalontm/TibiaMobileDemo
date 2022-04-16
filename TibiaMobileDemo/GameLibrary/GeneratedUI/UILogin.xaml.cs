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
    public partial class UILogin : UserControl {
        
        private Grid e_0;
        
        private Border e_1;
        
        private Grid e_2;
        
        private TextBlock e_3;
        
        private Grid e_4;
        
        private ImageButton e_5;
        
        private Image e_6;
        
        private Image e_7;
        
        private Grid e_8;
        
        private Grid e_9;
        
        private TextBlock e_10;
        
        private Border e_11;
        
        private TextBox e_12;
        
        private Grid e_13;
        
        private TextBlock e_14;
        
        private Border e_15;
        
        private PasswordBox e_16;
        
        private Button e_17;
        
        private Grid e_18;
        
        private Button e_19;
        
        private Grid e_20;
        
        private Grid e_21;
        
        private Grid e_22;
        
        private TextBlock e_23;
        
        public UILogin() {
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
            this.e_3 = new TextBlock();
            this.e_2.Children.Add(this.e_3);
            this.e_3.Name = "e_3";
            this.e_3.Margin = new Thickness(5F, 5F, 5F, 5F);
            this.e_3.HorizontalAlignment = HorizontalAlignment.Center;
            this.e_3.VerticalAlignment = VerticalAlignment.Center;
            this.e_3.Foreground = new SolidColorBrush(new ColorW(255, 255, 255, 255));
            this.e_3.Text = "Iniciar Sesion";
            this.e_3.FontSize = 32F;
            this.e_3.FontStyle = FontStyle.Bold;
            Grid.SetColumn(this.e_3, 0);
            Grid.SetColumnSpan(this.e_3, 3);
            // e_4 element
            this.e_4 = new Grid();
            this.e_2.Children.Add(this.e_4);
            this.e_4.Name = "e_4";
            this.e_4.Margin = new Thickness(5F, 0F, 5F, 0F);
            Grid.SetColumn(this.e_4, 2);
            // e_5 element
            this.e_5 = new ImageButton();
            this.e_4.Children.Add(this.e_5);
            this.e_5.Name = "e_5";
            this.e_5.HorizontalAlignment = HorizontalAlignment.Stretch;
            this.e_5.VerticalAlignment = VerticalAlignment.Stretch;
            this.e_5.Background = new SolidColorBrush(new ColorW(255, 255, 255, 0));
            Binding binding_e_5_Command = new Binding("RegisterCommand");
            this.e_5.SetBinding(ImageButton.CommandProperty, binding_e_5_Command);
            // e_6 element
            this.e_6 = new Image();
            this.e_5.Content = this.e_6;
            this.e_6.Name = "e_6";
            this.e_6.HorizontalAlignment = HorizontalAlignment.Stretch;
            this.e_6.VerticalAlignment = VerticalAlignment.Stretch;
            BitmapImage e_6_bm = new BitmapImage();
            e_6_bm.TextureAsset = "Images/ic_plus";
            this.e_6.Source = e_6_bm;
            // e_7 element
            this.e_7 = new Image();
            this.e_0.Children.Add(this.e_7);
            this.e_7.Name = "e_7";
            this.e_7.HorizontalAlignment = HorizontalAlignment.Stretch;
            this.e_7.VerticalAlignment = VerticalAlignment.Stretch;
            DirectionalBlurEffect e_7_dbef = new DirectionalBlurEffect();
            e_7_dbef.Angle = 0F;
            e_7_dbef.BlurAmount = 0.0005F;
            this.e_7.Effect = e_7_dbef;
            BitmapImage e_7_bm = new BitmapImage();
            e_7_bm.TextureAsset = "Images/screen_bg";
            this.e_7.Source = e_7_bm;
            this.e_7.Stretch = Stretch.Fill;
            Grid.SetRow(this.e_7, 1);
            Grid.SetRowSpan(this.e_7, 2);
            // e_8 element
            this.e_8 = new Grid();
            this.e_0.Children.Add(this.e_8);
            this.e_8.Name = "e_8";
            this.e_8.Width = 450F;
            this.e_8.HorizontalAlignment = HorizontalAlignment.Center;
            this.e_8.VerticalAlignment = VerticalAlignment.Center;
            RowDefinition row_e_8_0 = new RowDefinition();
            row_e_8_0.Height = new GridLength(1F, GridUnitType.Auto);
            this.e_8.RowDefinitions.Add(row_e_8_0);
            RowDefinition row_e_8_1 = new RowDefinition();
            row_e_8_1.Height = new GridLength(1F, GridUnitType.Auto);
            this.e_8.RowDefinitions.Add(row_e_8_1);
            RowDefinition row_e_8_2 = new RowDefinition();
            row_e_8_2.Height = new GridLength(1F, GridUnitType.Auto);
            this.e_8.RowDefinitions.Add(row_e_8_2);
            Grid.SetRow(this.e_8, 1);
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
            this.e_10.Foreground = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            this.e_10.Text = "Cuenta";
            this.e_10.FontSize = 20F;
            this.e_10.FontStyle = FontStyle.Bold;
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
            this.e_12.FontStyle = FontStyle.Regular;
            Binding binding_e_12_Text = new Binding("Account");
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
            this.e_14.Foreground = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            this.e_14.Text = "Contraseña";
            this.e_14.FontSize = 20F;
            this.e_14.FontStyle = FontStyle.Bold;
            Grid.SetRow(this.e_14, 0);
            // e_15 element
            this.e_15 = new Border();
            this.e_13.Children.Add(this.e_15);
            this.e_15.Name = "e_15";
            this.e_15.Margin = new Thickness(5F, 5F, 5F, 5F);
            this.e_15.Background = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            this.e_15.BorderBrush = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            this.e_15.BorderThickness = new Thickness(3F, 3F, 3F, 3F);
            this.e_15.Padding = new Thickness(0F, 0F, 0F, 0F);
            Grid.SetRow(this.e_15, 1);
            // e_16 element
            this.e_16 = new PasswordBox();
            this.e_15.Child = this.e_16;
            this.e_16.Name = "e_16";
            this.e_16.HorizontalAlignment = HorizontalAlignment.Stretch;
            this.e_16.VerticalAlignment = VerticalAlignment.Center;
            this.e_16.FontSize = 32F;
            this.e_16.FontStyle = FontStyle.Regular;
            this.e_16.PasswordChar = '•';
            Binding binding_e_16_Password = new Binding("Password");
            this.e_16.SetBinding(PasswordBox.PasswordProperty, binding_e_16_Password);
            // e_17 element
            this.e_17 = new Button();
            this.e_8.Children.Add(this.e_17);
            this.e_17.Name = "e_17";
            this.e_17.Height = 80F;
            this.e_17.Margin = new Thickness(5F, 5F, 5F, 5F);
            this.e_17.HorizontalAlignment = HorizontalAlignment.Stretch;
            this.e_17.VerticalAlignment = VerticalAlignment.Center;
            this.e_17.Background = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            this.e_17.BorderBrush = new SolidColorBrush(new ColorW(255, 255, 255, 255));
            this.e_17.BorderThickness = new Thickness(2F, 2F, 2F, 2F);
            this.e_17.Foreground = new SolidColorBrush(new ColorW(255, 255, 255, 255));
            this.e_17.HorizontalContentAlignment = HorizontalAlignment.Center;
            this.e_17.FontSize = 28F;
            this.e_17.FontStyle = FontStyle.Bold;
            this.e_17.Content = "Conectarme";
            Grid.SetRow(this.e_17, 2);
            Binding binding_e_17_Command = new Binding("LoginCommand");
            this.e_17.SetBinding(Button.CommandProperty, binding_e_17_Command);
            // e_18 element
            this.e_18 = new Grid();
            this.e_0.Children.Add(this.e_18);
            this.e_18.Name = "e_18";
            ColumnDefinition col_e_18_0 = new ColumnDefinition();
            col_e_18_0.Width = new GridLength(1F, GridUnitType.Star);
            this.e_18.ColumnDefinitions.Add(col_e_18_0);
            ColumnDefinition col_e_18_1 = new ColumnDefinition();
            col_e_18_1.Width = new GridLength(1F, GridUnitType.Star);
            this.e_18.ColumnDefinitions.Add(col_e_18_1);
            Grid.SetRow(this.e_18, 2);
            // e_19 element
            this.e_19 = new Button();
            this.e_18.Children.Add(this.e_19);
            this.e_19.Name = "e_19";
            this.e_19.Height = 48F;
            this.e_19.Width = 200F;
            this.e_19.Margin = new Thickness(8F, 0F, 2F, 5F);
            this.e_19.HorizontalAlignment = HorizontalAlignment.Left;
            this.e_19.VerticalAlignment = VerticalAlignment.Center;
            this.e_19.Background = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            this.e_19.BorderBrush = new SolidColorBrush(new ColorW(255, 255, 255, 255));
            this.e_19.BorderThickness = new Thickness(2F, 2F, 2F, 2F);
            this.e_19.Foreground = new SolidColorBrush(new ColorW(255, 255, 255, 255));
            this.e_19.HorizontalContentAlignment = HorizontalAlignment.Center;
            this.e_19.FontSize = 28F;
            this.e_19.FontStyle = FontStyle.Bold;
            this.e_19.Content = "Sitio Oficial";
            Grid.SetColumn(this.e_19, 0);
            Binding binding_e_19_Command = new Binding("WebCommand");
            this.e_19.SetBinding(Button.CommandProperty, binding_e_19_Command);
            // e_20 element
            this.e_20 = new Grid();
            this.e_18.Children.Add(this.e_20);
            this.e_20.Name = "e_20";
            Grid.SetColumn(this.e_20, 1);
            // e_21 element
            this.e_21 = new Grid();
            this.e_20.Children.Add(this.e_21);
            this.e_21.Name = "e_21";
            this.e_21.Width = 200F;
            this.e_21.Margin = new Thickness(2F, 0F, 8F, 5F);
            this.e_21.HorizontalAlignment = HorizontalAlignment.Right;
            this.e_21.VerticalAlignment = VerticalAlignment.Stretch;
            this.e_21.Opacity = 0.5F;
            this.e_21.Background = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            // e_22 element
            this.e_22 = new Grid();
            this.e_20.Children.Add(this.e_22);
            this.e_22.Name = "e_22";
            this.e_22.Width = 200F;
            this.e_22.Margin = new Thickness(2F, 0F, 8F, 5F);
            this.e_22.HorizontalAlignment = HorizontalAlignment.Right;
            this.e_22.VerticalAlignment = VerticalAlignment.Stretch;
            // e_23 element
            this.e_23 = new TextBlock();
            this.e_22.Children.Add(this.e_23);
            this.e_23.Name = "e_23";
            this.e_23.HorizontalAlignment = HorizontalAlignment.Center;
            this.e_23.VerticalAlignment = VerticalAlignment.Center;
            this.e_23.FontSize = 32F;
            this.e_23.FontStyle = FontStyle.Bold;
            Binding binding_e_23_Text = new Binding("Version");
            this.e_23.SetBinding(TextBlock.TextProperty, binding_e_23_Text);
            ImageManager.Instance.AddImage("Images/ic_plus");
            ImageManager.Instance.AddImage("Images/screen_bg");
            FontManager.Instance.AddFont("Segoe UI", 32F, FontStyle.Bold, "Segoe_UI_24_Bold");
            FontManager.Instance.AddFont("Segoe UI", 20F, FontStyle.Bold, "Segoe_UI_15_Bold");
            FontManager.Instance.AddFont("Segoe UI", 32F, FontStyle.Regular, "Segoe_UI_24_Regular");
            FontManager.Instance.AddFont("Segoe UI", 28F, FontStyle.Bold, "Segoe_UI_21_Bold");
        }
    }
}
