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
    public partial class UIGame : UserControl {
        
        private Grid e_0;
        
        private Grid e_1;
        
        private Grid e_2;
        
        private Grid e_3;
        
        private Grid e_4;
        
        private Border e_5;
        
        private Grid e_6;
        
        private Grid e_7;
        
        private TabControl e_8;
        
        private Grid e_17;
        
        private TextBox e_18;
        
        private Grid e_19;
        
        private Grid e_20;
        
        private Border e_21;
        
        private Grid e_22;
        
        private Border e_23;
        
        private Grid e_24;
        
        private Grid e_25;
        
        private Border e_26;
        
        private Image e_27;
        
        private Border e_28;
        
        private Image e_29;
        
        private Border e_30;
        
        private Image e_31;
        
        private Grid e_32;
        
        private Border e_33;
        
        private Image e_34;
        
        private Border e_35;
        
        private Image e_36;
        
        private Border e_37;
        
        private Image e_38;
        
        private Grid e_39;
        
        private Border e_40;
        
        private Image e_41;
        
        private Border e_42;
        
        private Image e_43;
        
        private Border e_44;
        
        private Image e_45;
        
        private Grid e_46;
        
        private Border e_47;
        
        private Grid e_48;
        
        private TextBlock e_49;
        
        private TextBlock e_50;
        
        private Border e_51;
        
        private Image e_52;
        
        private Border e_53;
        
        private Grid e_54;
        
        private TextBlock e_55;
        
        private TextBlock e_56;
        
        private Grid e_57;
        
        public UIGame() {
            Style style = UserControlStyle.CreateUserControlStyle();
            style.TargetType = this.GetType();
            this.Style = style;
            this.InitializeComponent();
        }
        
        private void InitializeComponent() {
            InitializeElementResources(this);
            // e_0 element
            this.e_0 = new Grid();
            this.Content = this.e_0;
            this.e_0.Name = "e_0";
            RowDefinition row_e_0_0 = new RowDefinition();
            row_e_0_0.Height = new GridLength(20F, GridUnitType.Pixel);
            this.e_0.RowDefinitions.Add(row_e_0_0);
            RowDefinition row_e_0_1 = new RowDefinition();
            row_e_0_1.Height = new GridLength(1F, GridUnitType.Star);
            this.e_0.RowDefinitions.Add(row_e_0_1);
            // e_1 element
            this.e_1 = new Grid();
            this.e_0.Children.Add(this.e_1);
            this.e_1.Name = "e_1";
            Grid.SetRow(this.e_1, 0);
            this.e_1.SetResourceReference(Grid.BackgroundProperty, "Background");
            // e_2 element
            this.e_2 = new Grid();
            this.e_0.Children.Add(this.e_2);
            this.e_2.Name = "e_2";
            ColumnDefinition col_e_2_0 = new ColumnDefinition();
            col_e_2_0.Width = new GridLength(10F, GridUnitType.Pixel);
            this.e_2.ColumnDefinitions.Add(col_e_2_0);
            ColumnDefinition col_e_2_1 = new ColumnDefinition();
            col_e_2_1.Width = new GridLength(1F, GridUnitType.Star);
            this.e_2.ColumnDefinitions.Add(col_e_2_1);
            ColumnDefinition col_e_2_2 = new ColumnDefinition();
            col_e_2_2.Width = new GridLength(250F, GridUnitType.Pixel);
            this.e_2.ColumnDefinitions.Add(col_e_2_2);
            Grid.SetRow(this.e_2, 1);
            // e_3 element
            this.e_3 = new Grid();
            this.e_2.Children.Add(this.e_3);
            this.e_3.Name = "e_3";
            Grid.SetColumn(this.e_3, 0);
            this.e_3.SetResourceReference(Grid.BackgroundProperty, "Background");
            // e_4 element
            this.e_4 = new Grid();
            this.e_2.Children.Add(this.e_4);
            this.e_4.Name = "e_4";
            RowDefinition row_e_4_0 = new RowDefinition();
            row_e_4_0.Height = new GridLength(1F, GridUnitType.Star);
            this.e_4.RowDefinitions.Add(row_e_4_0);
            RowDefinition row_e_4_1 = new RowDefinition();
            row_e_4_1.Height = new GridLength(200F, GridUnitType.Pixel);
            this.e_4.RowDefinitions.Add(row_e_4_1);
            Grid.SetColumn(this.e_4, 1);
            // e_5 element
            this.e_5 = new Border();
            this.e_4.Children.Add(this.e_5);
            this.e_5.Name = "e_5";
            this.e_5.BorderBrush = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            this.e_5.BorderThickness = new Thickness(1F, 1F, 1F, 1F);
            Grid.SetRow(this.e_5, 0);
            // e_6 element
            this.e_6 = new Grid();
            this.e_4.Children.Add(this.e_6);
            this.e_6.Name = "e_6";
            RowDefinition row_e_6_0 = new RowDefinition();
            row_e_6_0.Height = new GridLength(1F, GridUnitType.Star);
            this.e_6.RowDefinitions.Add(row_e_6_0);
            RowDefinition row_e_6_1 = new RowDefinition();
            row_e_6_1.Height = new GridLength(1F, GridUnitType.Auto);
            this.e_6.RowDefinitions.Add(row_e_6_1);
            Grid.SetRow(this.e_6, 1);
            this.e_6.SetResourceReference(Grid.BackgroundProperty, "Background");
            // e_7 element
            this.e_7 = new Grid();
            this.e_6.Children.Add(this.e_7);
            this.e_7.Name = "e_7";
            Grid.SetRow(this.e_7, 0);
            // e_8 element
            this.e_8 = new TabControl();
            this.e_7.Children.Add(this.e_8);
            this.e_8.Name = "e_8";
            this.e_8.HorizontalContentAlignment = HorizontalAlignment.Stretch;
            this.e_8.ItemsSource = Get_e_8_Items();
            this.e_8.SetResourceReference(TabControl.BackgroundProperty, "Background");
            // e_17 element
            this.e_17 = new Grid();
            this.e_6.Children.Add(this.e_17);
            this.e_17.Name = "e_17";
            Grid.SetRow(this.e_17, 1);
            // e_18 element
            this.e_18 = new TextBox();
            this.e_17.Children.Add(this.e_18);
            this.e_18.Name = "e_18";
            this.e_18.FontSize = 12F;
            this.e_18.FontStyle = FontStyle.Bold;
            Binding binding_e_18_Text = new Binding("general");
            this.e_18.SetBinding(TextBox.TextProperty, binding_e_18_Text);
            // e_19 element
            this.e_19 = new Grid();
            this.e_2.Children.Add(this.e_19);
            this.e_19.Name = "e_19";
            RowDefinition row_e_19_0 = new RowDefinition();
            row_e_19_0.Height = new GridLength(1F, GridUnitType.Auto);
            this.e_19.RowDefinitions.Add(row_e_19_0);
            RowDefinition row_e_19_1 = new RowDefinition();
            row_e_19_1.Height = new GridLength(1F, GridUnitType.Auto);
            this.e_19.RowDefinitions.Add(row_e_19_1);
            RowDefinition row_e_19_2 = new RowDefinition();
            row_e_19_2.Height = new GridLength(1F, GridUnitType.Star);
            this.e_19.RowDefinitions.Add(row_e_19_2);
            Grid.SetColumn(this.e_19, 2);
            this.e_19.SetResourceReference(Grid.BackgroundProperty, "Background");
            // e_20 element
            this.e_20 = new Grid();
            this.e_19.Children.Add(this.e_20);
            this.e_20.Name = "e_20";
            ColumnDefinition col_e_20_0 = new ColumnDefinition();
            col_e_20_0.Width = new GridLength(1F, GridUnitType.Star);
            this.e_20.ColumnDefinitions.Add(col_e_20_0);
            ColumnDefinition col_e_20_1 = new ColumnDefinition();
            col_e_20_1.Width = new GridLength(80F, GridUnitType.Pixel);
            this.e_20.ColumnDefinitions.Add(col_e_20_1);
            Grid.SetRow(this.e_20, 0);
            // e_21 element
            this.e_21 = new Border();
            this.e_20.Children.Add(this.e_21);
            this.e_21.Name = "e_21";
            this.e_21.Height = 150F;
            this.e_21.Margin = new Thickness(5F, 5F, 5F, 5F);
            this.e_21.Background = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            // e_22 element
            this.e_22 = new Grid();
            this.e_20.Children.Add(this.e_22);
            this.e_22.Name = "e_22";
            Grid.SetColumn(this.e_22, 1);
            // e_23 element
            this.e_23 = new Border();
            this.e_22.Children.Add(this.e_23);
            this.e_23.Name = "e_23";
            this.e_23.Margin = new Thickness(5F, 5F, 5F, 5F);
            // e_24 element
            this.e_24 = new Grid();
            this.e_19.Children.Add(this.e_24);
            this.e_24.Name = "e_24";
            this.e_24.Margin = new Thickness(5F, 5F, 5F, 5F);
            this.e_24.HorizontalAlignment = HorizontalAlignment.Center;
            RowDefinition row_e_24_0 = new RowDefinition();
            row_e_24_0.Height = new GridLength(64F, GridUnitType.Pixel);
            this.e_24.RowDefinitions.Add(row_e_24_0);
            RowDefinition row_e_24_1 = new RowDefinition();
            row_e_24_1.Height = new GridLength(64F, GridUnitType.Pixel);
            this.e_24.RowDefinitions.Add(row_e_24_1);
            RowDefinition row_e_24_2 = new RowDefinition();
            row_e_24_2.Height = new GridLength(64F, GridUnitType.Pixel);
            this.e_24.RowDefinitions.Add(row_e_24_2);
            RowDefinition row_e_24_3 = new RowDefinition();
            row_e_24_3.Height = new GridLength(64F, GridUnitType.Pixel);
            this.e_24.RowDefinitions.Add(row_e_24_3);
            Grid.SetRow(this.e_24, 1);
            // e_25 element
            this.e_25 = new Grid();
            this.e_24.Children.Add(this.e_25);
            this.e_25.Name = "e_25";
            ColumnDefinition col_e_25_0 = new ColumnDefinition();
            col_e_25_0.Width = new GridLength(64F, GridUnitType.Pixel);
            this.e_25.ColumnDefinitions.Add(col_e_25_0);
            ColumnDefinition col_e_25_1 = new ColumnDefinition();
            col_e_25_1.Width = new GridLength(64F, GridUnitType.Pixel);
            this.e_25.ColumnDefinitions.Add(col_e_25_1);
            ColumnDefinition col_e_25_2 = new ColumnDefinition();
            col_e_25_2.Width = new GridLength(64F, GridUnitType.Pixel);
            this.e_25.ColumnDefinitions.Add(col_e_25_2);
            Grid.SetRow(this.e_25, 0);
            // e_26 element
            this.e_26 = new Border();
            this.e_25.Children.Add(this.e_26);
            this.e_26.Name = "e_26";
            this.e_26.Margin = new Thickness(2F, 2F, 2F, 2F);
            this.e_26.Background = new SolidColorBrush(new ColorW(40, 40, 41, 255));
            this.e_26.BorderBrush = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            this.e_26.BorderThickness = new Thickness(1F, 1F, 1F, 1F);
            Grid.SetColumn(this.e_26, 0);
            // e_27 element
            this.e_27 = new Image();
            this.e_26.Child = this.e_27;
            this.e_27.Name = "e_27";
            BitmapImage e_27_bm = new BitmapImage();
            e_27_bm.TextureAsset = "ui/NoAmulet";
            this.e_27.Source = e_27_bm;
            this.e_27.Stretch = Stretch.Fill;
            // e_28 element
            this.e_28 = new Border();
            this.e_25.Children.Add(this.e_28);
            this.e_28.Name = "e_28";
            this.e_28.Margin = new Thickness(2F, 2F, 2F, 2F);
            this.e_28.Background = new SolidColorBrush(new ColorW(40, 40, 41, 255));
            this.e_28.BorderBrush = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            this.e_28.BorderThickness = new Thickness(1F, 1F, 1F, 1F);
            Grid.SetColumn(this.e_28, 1);
            // e_29 element
            this.e_29 = new Image();
            this.e_28.Child = this.e_29;
            this.e_29.Name = "e_29";
            BitmapImage e_29_bm = new BitmapImage();
            e_29_bm.TextureAsset = "ui/NoHelmet";
            this.e_29.Source = e_29_bm;
            this.e_29.Stretch = Stretch.Fill;
            // e_30 element
            this.e_30 = new Border();
            this.e_25.Children.Add(this.e_30);
            this.e_30.Name = "e_30";
            this.e_30.Margin = new Thickness(2F, 2F, 2F, 2F);
            this.e_30.Background = new SolidColorBrush(new ColorW(40, 40, 41, 255));
            this.e_30.BorderBrush = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            this.e_30.BorderThickness = new Thickness(1F, 1F, 1F, 1F);
            Grid.SetColumn(this.e_30, 2);
            // e_31 element
            this.e_31 = new Image();
            this.e_30.Child = this.e_31;
            this.e_31.Name = "e_31";
            BitmapImage e_31_bm = new BitmapImage();
            e_31_bm.TextureAsset = "ui/bp";
            this.e_31.Source = e_31_bm;
            this.e_31.Stretch = Stretch.Fill;
            // e_32 element
            this.e_32 = new Grid();
            this.e_24.Children.Add(this.e_32);
            this.e_32.Name = "e_32";
            ColumnDefinition col_e_32_0 = new ColumnDefinition();
            col_e_32_0.Width = new GridLength(64F, GridUnitType.Pixel);
            this.e_32.ColumnDefinitions.Add(col_e_32_0);
            ColumnDefinition col_e_32_1 = new ColumnDefinition();
            col_e_32_1.Width = new GridLength(64F, GridUnitType.Pixel);
            this.e_32.ColumnDefinitions.Add(col_e_32_1);
            ColumnDefinition col_e_32_2 = new ColumnDefinition();
            col_e_32_2.Width = new GridLength(64F, GridUnitType.Pixel);
            this.e_32.ColumnDefinitions.Add(col_e_32_2);
            Grid.SetRow(this.e_32, 1);
            // e_33 element
            this.e_33 = new Border();
            this.e_32.Children.Add(this.e_33);
            this.e_33.Name = "e_33";
            this.e_33.Margin = new Thickness(2F, 2F, 2F, 2F);
            this.e_33.Background = new SolidColorBrush(new ColorW(40, 40, 41, 255));
            this.e_33.BorderBrush = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            this.e_33.BorderThickness = new Thickness(1F, 1F, 1F, 1F);
            Grid.SetColumn(this.e_33, 0);
            // e_34 element
            this.e_34 = new Image();
            this.e_33.Child = this.e_34;
            this.e_34.Name = "e_34";
            BitmapImage e_34_bm = new BitmapImage();
            e_34_bm.TextureAsset = "ui/NoWeapon";
            this.e_34.Source = e_34_bm;
            this.e_34.Stretch = Stretch.Fill;
            // e_35 element
            this.e_35 = new Border();
            this.e_32.Children.Add(this.e_35);
            this.e_35.Name = "e_35";
            this.e_35.Margin = new Thickness(2F, 2F, 2F, 2F);
            this.e_35.Background = new SolidColorBrush(new ColorW(40, 40, 41, 255));
            this.e_35.BorderBrush = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            this.e_35.BorderThickness = new Thickness(1F, 1F, 1F, 1F);
            Grid.SetColumn(this.e_35, 1);
            // e_36 element
            this.e_36 = new Image();
            this.e_35.Child = this.e_36;
            this.e_36.Name = "e_36";
            BitmapImage e_36_bm = new BitmapImage();
            e_36_bm.TextureAsset = "ui/NoArmor";
            this.e_36.Source = e_36_bm;
            this.e_36.Stretch = Stretch.Fill;
            // e_37 element
            this.e_37 = new Border();
            this.e_32.Children.Add(this.e_37);
            this.e_37.Name = "e_37";
            this.e_37.Margin = new Thickness(2F, 2F, 2F, 2F);
            this.e_37.Background = new SolidColorBrush(new ColorW(40, 40, 41, 255));
            this.e_37.BorderBrush = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            this.e_37.BorderThickness = new Thickness(1F, 1F, 1F, 1F);
            Grid.SetColumn(this.e_37, 2);
            // e_38 element
            this.e_38 = new Image();
            this.e_37.Child = this.e_38;
            this.e_38.Name = "e_38";
            BitmapImage e_38_bm = new BitmapImage();
            e_38_bm.TextureAsset = "ui/NoShield";
            this.e_38.Source = e_38_bm;
            this.e_38.Stretch = Stretch.Fill;
            // e_39 element
            this.e_39 = new Grid();
            this.e_24.Children.Add(this.e_39);
            this.e_39.Name = "e_39";
            ColumnDefinition col_e_39_0 = new ColumnDefinition();
            col_e_39_0.Width = new GridLength(64F, GridUnitType.Pixel);
            this.e_39.ColumnDefinitions.Add(col_e_39_0);
            ColumnDefinition col_e_39_1 = new ColumnDefinition();
            col_e_39_1.Width = new GridLength(64F, GridUnitType.Pixel);
            this.e_39.ColumnDefinitions.Add(col_e_39_1);
            ColumnDefinition col_e_39_2 = new ColumnDefinition();
            col_e_39_2.Width = new GridLength(64F, GridUnitType.Pixel);
            this.e_39.ColumnDefinitions.Add(col_e_39_2);
            Grid.SetRow(this.e_39, 2);
            // e_40 element
            this.e_40 = new Border();
            this.e_39.Children.Add(this.e_40);
            this.e_40.Name = "e_40";
            this.e_40.Margin = new Thickness(2F, 2F, 2F, 2F);
            this.e_40.Background = new SolidColorBrush(new ColorW(40, 40, 41, 255));
            this.e_40.BorderBrush = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            this.e_40.BorderThickness = new Thickness(1F, 1F, 1F, 1F);
            Grid.SetColumn(this.e_40, 0);
            // e_41 element
            this.e_41 = new Image();
            this.e_40.Child = this.e_41;
            this.e_41.Name = "e_41";
            BitmapImage e_41_bm = new BitmapImage();
            e_41_bm.TextureAsset = "ui/NoRing";
            this.e_41.Source = e_41_bm;
            this.e_41.Stretch = Stretch.Fill;
            // e_42 element
            this.e_42 = new Border();
            this.e_39.Children.Add(this.e_42);
            this.e_42.Name = "e_42";
            this.e_42.Margin = new Thickness(2F, 2F, 2F, 2F);
            this.e_42.Background = new SolidColorBrush(new ColorW(40, 40, 41, 255));
            this.e_42.BorderBrush = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            this.e_42.BorderThickness = new Thickness(1F, 1F, 1F, 1F);
            Grid.SetColumn(this.e_42, 1);
            // e_43 element
            this.e_43 = new Image();
            this.e_42.Child = this.e_43;
            this.e_43.Name = "e_43";
            BitmapImage e_43_bm = new BitmapImage();
            e_43_bm.TextureAsset = "ui/NoLegs";
            this.e_43.Source = e_43_bm;
            this.e_43.Stretch = Stretch.Fill;
            // e_44 element
            this.e_44 = new Border();
            this.e_39.Children.Add(this.e_44);
            this.e_44.Name = "e_44";
            this.e_44.Margin = new Thickness(2F, 2F, 2F, 2F);
            this.e_44.Background = new SolidColorBrush(new ColorW(40, 40, 41, 255));
            this.e_44.BorderBrush = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            this.e_44.BorderThickness = new Thickness(1F, 1F, 1F, 1F);
            Grid.SetColumn(this.e_44, 2);
            // e_45 element
            this.e_45 = new Image();
            this.e_44.Child = this.e_45;
            this.e_45.Name = "e_45";
            BitmapImage e_45_bm = new BitmapImage();
            e_45_bm.TextureAsset = "ui/NoBelt";
            this.e_45.Source = e_45_bm;
            this.e_45.Stretch = Stretch.Fill;
            // e_46 element
            this.e_46 = new Grid();
            this.e_24.Children.Add(this.e_46);
            this.e_46.Name = "e_46";
            ColumnDefinition col_e_46_0 = new ColumnDefinition();
            col_e_46_0.Width = new GridLength(64F, GridUnitType.Pixel);
            this.e_46.ColumnDefinitions.Add(col_e_46_0);
            ColumnDefinition col_e_46_1 = new ColumnDefinition();
            col_e_46_1.Width = new GridLength(64F, GridUnitType.Pixel);
            this.e_46.ColumnDefinitions.Add(col_e_46_1);
            ColumnDefinition col_e_46_2 = new ColumnDefinition();
            col_e_46_2.Width = new GridLength(64F, GridUnitType.Pixel);
            this.e_46.ColumnDefinitions.Add(col_e_46_2);
            Grid.SetRow(this.e_46, 3);
            // e_47 element
            this.e_47 = new Border();
            this.e_46.Children.Add(this.e_47);
            this.e_47.Name = "e_47";
            this.e_47.Margin = new Thickness(2F, 2F, 2F, 2F);
            this.e_47.Background = new SolidColorBrush(new ColorW(40, 40, 41, 255));
            this.e_47.BorderBrush = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            this.e_47.BorderThickness = new Thickness(1F, 1F, 1F, 1F);
            Grid.SetColumn(this.e_47, 0);
            // e_48 element
            this.e_48 = new Grid();
            this.e_47.Child = this.e_48;
            this.e_48.Name = "e_48";
            RowDefinition row_e_48_0 = new RowDefinition();
            row_e_48_0.Height = new GridLength(1F, GridUnitType.Star);
            this.e_48.RowDefinitions.Add(row_e_48_0);
            RowDefinition row_e_48_1 = new RowDefinition();
            row_e_48_1.Height = new GridLength(1F, GridUnitType.Star);
            this.e_48.RowDefinitions.Add(row_e_48_1);
            // e_49 element
            this.e_49 = new TextBlock();
            this.e_48.Children.Add(this.e_49);
            this.e_49.Name = "e_49";
            this.e_49.HorizontalAlignment = HorizontalAlignment.Center;
            this.e_49.VerticalAlignment = VerticalAlignment.Center;
            this.e_49.Foreground = new SolidColorBrush(new ColorW(169, 169, 154, 255));
            this.e_49.Text = "Soul:";
            this.e_49.FontSize = 14F;
            this.e_49.FontStyle = FontStyle.Bold;
            Grid.SetRow(this.e_49, 0);
            // e_50 element
            this.e_50 = new TextBlock();
            this.e_48.Children.Add(this.e_50);
            this.e_50.Name = "e_50";
            this.e_50.HorizontalAlignment = HorizontalAlignment.Center;
            this.e_50.VerticalAlignment = VerticalAlignment.Center;
            this.e_50.Foreground = new SolidColorBrush(new ColorW(169, 169, 154, 255));
            this.e_50.Text = "100";
            this.e_50.FontSize = 14F;
            this.e_50.FontStyle = FontStyle.Bold;
            Grid.SetRow(this.e_50, 1);
            // e_51 element
            this.e_51 = new Border();
            this.e_46.Children.Add(this.e_51);
            this.e_51.Name = "e_51";
            this.e_51.Margin = new Thickness(2F, 2F, 2F, 2F);
            this.e_51.Background = new SolidColorBrush(new ColorW(40, 40, 41, 255));
            this.e_51.BorderBrush = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            this.e_51.BorderThickness = new Thickness(1F, 1F, 1F, 1F);
            Grid.SetColumn(this.e_51, 1);
            // e_52 element
            this.e_52 = new Image();
            this.e_51.Child = this.e_52;
            this.e_52.Name = "e_52";
            BitmapImage e_52_bm = new BitmapImage();
            e_52_bm.TextureAsset = "ui/NoBoots";
            this.e_52.Source = e_52_bm;
            this.e_52.Stretch = Stretch.Fill;
            // e_53 element
            this.e_53 = new Border();
            this.e_46.Children.Add(this.e_53);
            this.e_53.Name = "e_53";
            this.e_53.Margin = new Thickness(2F, 2F, 2F, 2F);
            this.e_53.Background = new SolidColorBrush(new ColorW(40, 40, 41, 255));
            this.e_53.BorderBrush = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            this.e_53.BorderThickness = new Thickness(1F, 1F, 1F, 1F);
            Grid.SetColumn(this.e_53, 2);
            // e_54 element
            this.e_54 = new Grid();
            this.e_53.Child = this.e_54;
            this.e_54.Name = "e_54";
            RowDefinition row_e_54_0 = new RowDefinition();
            row_e_54_0.Height = new GridLength(1F, GridUnitType.Star);
            this.e_54.RowDefinitions.Add(row_e_54_0);
            RowDefinition row_e_54_1 = new RowDefinition();
            row_e_54_1.Height = new GridLength(1F, GridUnitType.Star);
            this.e_54.RowDefinitions.Add(row_e_54_1);
            // e_55 element
            this.e_55 = new TextBlock();
            this.e_54.Children.Add(this.e_55);
            this.e_55.Name = "e_55";
            this.e_55.HorizontalAlignment = HorizontalAlignment.Center;
            this.e_55.VerticalAlignment = VerticalAlignment.Center;
            this.e_55.Foreground = new SolidColorBrush(new ColorW(169, 169, 154, 255));
            this.e_55.Text = "Cap:";
            this.e_55.FontSize = 14F;
            this.e_55.FontStyle = FontStyle.Bold;
            Grid.SetRow(this.e_55, 0);
            // e_56 element
            this.e_56 = new TextBlock();
            this.e_54.Children.Add(this.e_56);
            this.e_56.Name = "e_56";
            this.e_56.HorizontalAlignment = HorizontalAlignment.Center;
            this.e_56.VerticalAlignment = VerticalAlignment.Center;
            this.e_56.Foreground = new SolidColorBrush(new ColorW(169, 169, 154, 255));
            this.e_56.Text = "800";
            this.e_56.FontSize = 14F;
            this.e_56.FontStyle = FontStyle.Bold;
            Grid.SetRow(this.e_56, 1);
            // e_57 element
            this.e_57 = new Grid();
            this.e_19.Children.Add(this.e_57);
            this.e_57.Name = "e_57";
            Grid.SetRow(this.e_57, 2);
            ImageManager.Instance.AddImage("ui/NoAmulet");
            ImageManager.Instance.AddImage("ui/NoHelmet");
            ImageManager.Instance.AddImage("ui/bp");
            ImageManager.Instance.AddImage("ui/NoWeapon");
            ImageManager.Instance.AddImage("ui/NoArmor");
            ImageManager.Instance.AddImage("ui/NoShield");
            ImageManager.Instance.AddImage("ui/NoRing");
            ImageManager.Instance.AddImage("ui/NoLegs");
            ImageManager.Instance.AddImage("ui/NoBelt");
            ImageManager.Instance.AddImage("ui/NoBoots");
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Bold, "Segoe_UI_9_Bold");
            FontManager.Instance.AddFont("Segoe UI", 14F, FontStyle.Bold, "Segoe_UI_10.5_Bold");
        }
        
        private static void InitializeElementResources(UIElement elem) {
            elem.Resources.MergedDictionaries.Add(Dictionary.Instance);
        }
        
        private static System.Collections.ObjectModel.ObservableCollection<object> Get_e_8_Items() {
            System.Collections.ObjectModel.ObservableCollection<object> items = new System.Collections.ObjectModel.ObservableCollection<object>();
            // e_9 element
            TabItem e_9 = new TabItem();
            e_9.Name = "e_9";
            e_9.Header = "General";
            e_9.SetResourceReference(TabItem.BackgroundProperty, "Background");
            // e_10 element
            ScrollViewer e_10 = new ScrollViewer();
            e_9.Content = e_10;
            e_10.Name = "e_10";
            e_10.HorizontalScrollBarVisibility = ScrollBarVisibility.Disabled;
            e_10.VerticalScrollBarVisibility = ScrollBarVisibility.Visible;
            // e_11 element
            ItemsControl e_11 = new ItemsControl();
            e_10.Content = e_11;
            e_11.Name = "e_11";
            Func<UIElement, UIElement> e_11_dtFunc = e_11_dtMethod;
            e_11.ItemTemplate = new DataTemplate(e_11_dtFunc);
            Binding binding_e_11_ItemsSource = new Binding("generalChannel");
            e_11.SetBinding(ItemsControl.ItemsSourceProperty, binding_e_11_ItemsSource);
            items.Add(e_9);
            // e_16 element
            TabItem e_16 = new TabItem();
            e_16.Name = "e_16";
            e_16.Header = "Game Log";
            e_16.SetResourceReference(TabItem.BackgroundProperty, "Background");
            items.Add(e_16);
            return items;
        }
        
        private static UIElement e_11_dtMethod(UIElement parent) {
            // e_12 element
            Grid e_12 = new Grid();
            e_12.Parent = parent;
            e_12.Name = "e_12";
            ColumnDefinition col_e_12_0 = new ColumnDefinition();
            col_e_12_0.Width = new GridLength(1F, GridUnitType.Auto);
            e_12.ColumnDefinitions.Add(col_e_12_0);
            ColumnDefinition col_e_12_1 = new ColumnDefinition();
            col_e_12_1.Width = new GridLength(1F, GridUnitType.Auto);
            e_12.ColumnDefinitions.Add(col_e_12_1);
            ColumnDefinition col_e_12_2 = new ColumnDefinition();
            col_e_12_2.Width = new GridLength(1F, GridUnitType.Auto);
            e_12.ColumnDefinitions.Add(col_e_12_2);
            // e_13 element
            TextBlock e_13 = new TextBlock();
            e_12.Children.Add(e_13);
            e_13.Name = "e_13";
            e_13.Foreground = new SolidColorBrush(new ColorW(229, 228, 75, 255));
            e_13.FontSize = 12F;
            e_13.FontStyle = FontStyle.Bold;
            Grid.SetColumn(e_13, 0);
            Binding binding_e_13_Text = new Binding("date");
            binding_e_13_Text.StringFormat = "{0:hh:mm:ss} ";
            e_13.SetBinding(TextBlock.TextProperty, binding_e_13_Text);
            // e_14 element
            TextBlock e_14 = new TextBlock();
            e_12.Children.Add(e_14);
            e_14.Name = "e_14";
            e_14.Foreground = new SolidColorBrush(new ColorW(229, 228, 75, 255));
            e_14.FontSize = 12F;
            e_14.FontStyle = FontStyle.Bold;
            Grid.SetColumn(e_14, 1);
            Binding binding_e_14_Text = new Binding("name");
            binding_e_14_Text.StringFormat = "{0}: ";
            e_14.SetBinding(TextBlock.TextProperty, binding_e_14_Text);
            // e_15 element
            TextBlock e_15 = new TextBlock();
            e_12.Children.Add(e_15);
            e_15.Name = "e_15";
            e_15.Foreground = new SolidColorBrush(new ColorW(229, 228, 75, 255));
            e_15.FontSize = 12F;
            e_15.FontStyle = FontStyle.Bold;
            Grid.SetColumn(e_15, 2);
            Binding binding_e_15_Text = new Binding("message");
            e_15.SetBinding(TextBlock.TextProperty, binding_e_15_Text);
            return e_12;
        }
    }
}
