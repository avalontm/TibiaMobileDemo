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
    public partial class UIRegister : UserControl {
        
        private Grid e_0;
        
        private Border e_1;
        
        private Grid e_2;
        
        private ImageButton e_3;
        
        private Image e_4;
        
        private TextBlock e_5;
        
        private Border e_6;
        
        private Grid e_7;
        
        private Grid e_8;
        
        private TextBlock e_9;
        
        private TextBox e_10;
        
        private Grid e_11;
        
        private TextBlock e_12;
        
        private PasswordBox e_13;
        
        private Grid e_14;
        
        private TextBlock e_15;
        
        private PasswordBox e_16;
        
        private Button e_17;
        
        public UIRegister() {
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
            this.e_1.Height = 64F;
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
            this.e_5.Text = "Crear cuenta";
            this.e_5.FontSize = 32F;
            this.e_5.FontStyle = FontStyle.Bold;
            Grid.SetColumn(this.e_5, 0);
            Grid.SetColumnSpan(this.e_5, 3);
            // e_6 element
            this.e_6 = new Border();
            this.e_0.Children.Add(this.e_6);
            this.e_6.Name = "e_6";
            this.e_6.Width = 450F;
            this.e_6.Margin = new Thickness(5F, 5F, 5F, 5F);
            this.e_6.HorizontalAlignment = HorizontalAlignment.Center;
            this.e_6.VerticalAlignment = VerticalAlignment.Center;
            this.e_6.Background = new SolidColorBrush(new ColorW(33, 33, 33, 255));
            this.e_6.BorderBrush = new SolidColorBrush(new ColorW(69, 69, 69, 255));
            this.e_6.BorderThickness = new Thickness(3F, 3F, 3F, 3F);
            this.e_6.Padding = new Thickness(5F, 5F, 5F, 5F);
            Grid.SetRow(this.e_6, 1);
            // e_7 element
            this.e_7 = new Grid();
            this.e_6.Child = this.e_7;
            this.e_7.Name = "e_7";
            RowDefinition row_e_7_0 = new RowDefinition();
            row_e_7_0.Height = new GridLength(1F, GridUnitType.Auto);
            this.e_7.RowDefinitions.Add(row_e_7_0);
            RowDefinition row_e_7_1 = new RowDefinition();
            row_e_7_1.Height = new GridLength(1F, GridUnitType.Auto);
            this.e_7.RowDefinitions.Add(row_e_7_1);
            RowDefinition row_e_7_2 = new RowDefinition();
            row_e_7_2.Height = new GridLength(1F, GridUnitType.Auto);
            this.e_7.RowDefinitions.Add(row_e_7_2);
            RowDefinition row_e_7_3 = new RowDefinition();
            row_e_7_3.Height = new GridLength(1F, GridUnitType.Auto);
            this.e_7.RowDefinitions.Add(row_e_7_3);
            // e_8 element
            this.e_8 = new Grid();
            this.e_7.Children.Add(this.e_8);
            this.e_8.Name = "e_8";
            this.e_8.Margin = new Thickness(5F, 5F, 5F, 5F);
            RowDefinition row_e_8_0 = new RowDefinition();
            row_e_8_0.Height = new GridLength(1F, GridUnitType.Auto);
            this.e_8.RowDefinitions.Add(row_e_8_0);
            RowDefinition row_e_8_1 = new RowDefinition();
            row_e_8_1.Height = new GridLength(1F, GridUnitType.Auto);
            this.e_8.RowDefinitions.Add(row_e_8_1);
            Grid.SetRow(this.e_8, 0);
            // e_9 element
            this.e_9 = new TextBlock();
            this.e_8.Children.Add(this.e_9);
            this.e_9.Name = "e_9";
            this.e_9.HorizontalAlignment = HorizontalAlignment.Left;
            this.e_9.VerticalAlignment = VerticalAlignment.Center;
            this.e_9.Foreground = new SolidColorBrush(new ColorW(255, 255, 255, 255));
            this.e_9.Text = "Nombre de la cuenta";
            this.e_9.FontSize = 24F;
            Grid.SetRow(this.e_9, 0);
            // e_10 element
            this.e_10 = new TextBox();
            this.e_8.Children.Add(this.e_10);
            this.e_10.Name = "e_10";
            this.e_10.Margin = new Thickness(5F, 5F, 5F, 5F);
            this.e_10.HorizontalAlignment = HorizontalAlignment.Stretch;
            this.e_10.VerticalAlignment = VerticalAlignment.Center;
            this.e_10.FontSize = 32F;
            Grid.SetRow(this.e_10, 1);
            Binding binding_e_10_Text = new Binding("Account");
            this.e_10.SetBinding(TextBox.TextProperty, binding_e_10_Text);
            // e_11 element
            this.e_11 = new Grid();
            this.e_7.Children.Add(this.e_11);
            this.e_11.Name = "e_11";
            this.e_11.Margin = new Thickness(5F, 5F, 5F, 5F);
            RowDefinition row_e_11_0 = new RowDefinition();
            row_e_11_0.Height = new GridLength(1F, GridUnitType.Auto);
            this.e_11.RowDefinitions.Add(row_e_11_0);
            RowDefinition row_e_11_1 = new RowDefinition();
            row_e_11_1.Height = new GridLength(1F, GridUnitType.Auto);
            this.e_11.RowDefinitions.Add(row_e_11_1);
            Grid.SetRow(this.e_11, 1);
            // e_12 element
            this.e_12 = new TextBlock();
            this.e_11.Children.Add(this.e_12);
            this.e_12.Name = "e_12";
            this.e_12.HorizontalAlignment = HorizontalAlignment.Left;
            this.e_12.VerticalAlignment = VerticalAlignment.Center;
            this.e_12.Foreground = new SolidColorBrush(new ColorW(255, 255, 255, 255));
            this.e_12.Text = "Contraseña";
            this.e_12.FontSize = 24F;
            Grid.SetRow(this.e_12, 0);
            // e_13 element
            this.e_13 = new PasswordBox();
            this.e_11.Children.Add(this.e_13);
            this.e_13.Name = "e_13";
            this.e_13.Margin = new Thickness(5F, 5F, 5F, 5F);
            this.e_13.HorizontalAlignment = HorizontalAlignment.Stretch;
            this.e_13.VerticalAlignment = VerticalAlignment.Center;
            this.e_13.FontSize = 32F;
            Grid.SetRow(this.e_13, 1);
            Binding binding_e_13_Password = new Binding("Password");
            this.e_13.SetBinding(PasswordBox.PasswordProperty, binding_e_13_Password);
            // e_14 element
            this.e_14 = new Grid();
            this.e_7.Children.Add(this.e_14);
            this.e_14.Name = "e_14";
            this.e_14.Margin = new Thickness(5F, 5F, 5F, 5F);
            RowDefinition row_e_14_0 = new RowDefinition();
            row_e_14_0.Height = new GridLength(1F, GridUnitType.Auto);
            this.e_14.RowDefinitions.Add(row_e_14_0);
            RowDefinition row_e_14_1 = new RowDefinition();
            row_e_14_1.Height = new GridLength(1F, GridUnitType.Auto);
            this.e_14.RowDefinitions.Add(row_e_14_1);
            Grid.SetRow(this.e_14, 2);
            // e_15 element
            this.e_15 = new TextBlock();
            this.e_14.Children.Add(this.e_15);
            this.e_15.Name = "e_15";
            this.e_15.HorizontalAlignment = HorizontalAlignment.Left;
            this.e_15.VerticalAlignment = VerticalAlignment.Center;
            this.e_15.Foreground = new SolidColorBrush(new ColorW(255, 255, 255, 255));
            this.e_15.Text = "Repetir Contraseña";
            this.e_15.FontSize = 24F;
            Grid.SetRow(this.e_15, 0);
            // e_16 element
            this.e_16 = new PasswordBox();
            this.e_14.Children.Add(this.e_16);
            this.e_16.Name = "e_16";
            this.e_16.Margin = new Thickness(5F, 5F, 5F, 5F);
            this.e_16.HorizontalAlignment = HorizontalAlignment.Stretch;
            this.e_16.VerticalAlignment = VerticalAlignment.Center;
            this.e_16.FontSize = 32F;
            Grid.SetRow(this.e_16, 1);
            Binding binding_e_16_Password = new Binding("PasswordRepeat");
            this.e_16.SetBinding(PasswordBox.PasswordProperty, binding_e_16_Password);
            // e_17 element
            this.e_17 = new Button();
            this.e_7.Children.Add(this.e_17);
            this.e_17.Name = "e_17";
            this.e_17.Height = 60F;
            this.e_17.Margin = new Thickness(5F, 5F, 5F, 5F);
            this.e_17.HorizontalAlignment = HorizontalAlignment.Stretch;
            this.e_17.VerticalAlignment = VerticalAlignment.Center;
            this.e_17.Background = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            this.e_17.Foreground = new SolidColorBrush(new ColorW(255, 255, 255, 255));
            this.e_17.HorizontalContentAlignment = HorizontalAlignment.Center;
            this.e_17.FontSize = 32F;
            this.e_17.Content = "Crear Cuenta";
            Grid.SetRow(this.e_17, 3);
            Binding binding_e_17_Command = new Binding("RegisterCommand");
            this.e_17.SetBinding(Button.CommandProperty, binding_e_17_Command);
            ImageManager.Instance.AddImage("Images/ic_back");
            FontManager.Instance.AddFont("Segoe UI", 32F, FontStyle.Bold, "Segoe_UI_24_Bold");
            FontManager.Instance.AddFont("Segoe UI", 24F, FontStyle.Regular, "Segoe_UI_18_Regular");
            FontManager.Instance.AddFont("Segoe UI", 32F, FontStyle.Regular, "Segoe_UI_24_Regular");
        }
    }
}
