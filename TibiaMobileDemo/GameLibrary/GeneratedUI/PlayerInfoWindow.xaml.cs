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
    public sealed class PlayerInfoWindow : ResourceDictionary {
        
        private static PlayerInfoWindow singleton = new PlayerInfoWindow();
        
        public PlayerInfoWindow() {
            this.InitializeResources();
        }
        
        public static PlayerInfoWindow Instance {
            get {
                return singleton;
            }
        }
        
        private void InitializeResources() {
            // Resource - [PlayerInfoWindowTemplate] ControlTemplate
            Func<UIElement, UIElement> r_0_ctFunc = r_0_ctMethod;
            ControlTemplate r_0_ct = new ControlTemplate(r_0_ctFunc);
            this.Add("PlayerInfoWindowTemplate", r_0_ct);
            ImageManager.Instance.AddImage("Images/ic_close");
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Bold, "Segoe_UI_9_Bold");
        }
        
        private static System.Collections.ObjectModel.ObservableCollection<object> Get_e_8_Items() {
            System.Collections.ObjectModel.ObservableCollection<object> items = new System.Collections.ObjectModel.ObservableCollection<object>();
            // e_9 element
            TabItem e_9 = new TabItem();
            e_9.Name = "e_9";
            e_9.Width = 200F;
            e_9.Margin = new Thickness(5F, 0F, 5F, 0F);
            e_9.Header = "Perfil";
            // e_10 element
            Grid e_10 = new Grid();
            e_9.Content = e_10;
            e_10.Name = "e_10";
            RowDefinition row_e_10_0 = new RowDefinition();
            row_e_10_0.Height = new GridLength(1F, GridUnitType.Auto);
            e_10.RowDefinitions.Add(row_e_10_0);
            RowDefinition row_e_10_1 = new RowDefinition();
            row_e_10_1.Height = new GridLength(1F, GridUnitType.Star);
            e_10.RowDefinitions.Add(row_e_10_1);
            RowDefinition row_e_10_2 = new RowDefinition();
            row_e_10_2.Height = new GridLength(1F, GridUnitType.Auto);
            e_10.RowDefinitions.Add(row_e_10_2);
            // e_11 element
            Grid e_11 = new Grid();
            e_10.Children.Add(e_11);
            e_11.Name = "e_11";
            e_11.Margin = new Thickness(5F, 5F, 5F, 5F);
            ColumnDefinition col_e_11_0 = new ColumnDefinition();
            col_e_11_0.Width = new GridLength(3F, GridUnitType.Star);
            e_11.ColumnDefinitions.Add(col_e_11_0);
            ColumnDefinition col_e_11_1 = new ColumnDefinition();
            col_e_11_1.Width = new GridLength(7F, GridUnitType.Star);
            e_11.ColumnDefinitions.Add(col_e_11_1);
            ColumnDefinition col_e_11_2 = new ColumnDefinition();
            col_e_11_2.Width = new GridLength(3F, GridUnitType.Star);
            e_11.ColumnDefinitions.Add(col_e_11_2);
            Grid.SetRow(e_11, 0);
            // e_12 element
            Grid e_12 = new Grid();
            e_11.Children.Add(e_12);
            e_12.Name = "e_12";
            Grid.SetColumn(e_12, 0);
            // e_13 element
            Button e_13 = new Button();
            e_12.Children.Add(e_13);
            e_13.Name = "e_13";
            e_13.Margin = new Thickness(2F, 0F, 5F, 0F);
            e_13.HorizontalAlignment = HorizontalAlignment.Stretch;
            e_13.VerticalAlignment = VerticalAlignment.Stretch;
            e_13.Content = "Anterior";
            Binding binding_e_13_Command = new Binding("OutfitBackCommand");
            e_13.SetBinding(Button.CommandProperty, binding_e_13_Command);
            // e_14 element
            Grid e_14 = new Grid();
            e_11.Children.Add(e_14);
            e_14.Name = "e_14";
            e_14.HorizontalAlignment = HorizontalAlignment.Center;
            e_14.VerticalAlignment = VerticalAlignment.Center;
            Grid.SetColumn(e_14, 1);
            // e_15 element
            Image e_15 = new Image();
            e_14.Children.Add(e_15);
            e_15.Name = "e_15";
            e_15.Height = 100F;
            e_15.Width = 100F;
            e_15.Margin = new Thickness(5F, 5F, 5F, 5F);
            e_15.HorizontalAlignment = HorizontalAlignment.Stretch;
            e_15.VerticalAlignment = VerticalAlignment.Stretch;
            e_15.Stretch = Stretch.Fill;
            Binding binding_e_15_Source = new Binding("Outfit");
            e_15.SetBinding(Image.SourceProperty, binding_e_15_Source);
            // e_16 element
            Grid e_16 = new Grid();
            e_11.Children.Add(e_16);
            e_16.Name = "e_16";
            Grid.SetColumn(e_16, 2);
            // e_17 element
            Button e_17 = new Button();
            e_16.Children.Add(e_17);
            e_17.Name = "e_17";
            e_17.Margin = new Thickness(5F, 0F, 2F, 0F);
            e_17.HorizontalAlignment = HorizontalAlignment.Stretch;
            e_17.VerticalAlignment = VerticalAlignment.Stretch;
            e_17.Content = "Siguiente";
            Grid.SetColumn(e_17, 1);
            Binding binding_e_17_Command = new Binding("OutfitNextCommand");
            e_17.SetBinding(Button.CommandProperty, binding_e_17_Command);
            // e_18 element
            Grid e_18 = new Grid();
            e_10.Children.Add(e_18);
            e_18.Name = "e_18";
            e_18.Margin = new Thickness(0F, 10F, 0F, 0F);
            ColumnDefinition col_e_18_0 = new ColumnDefinition();
            col_e_18_0.Width = new GridLength(4F, GridUnitType.Star);
            e_18.ColumnDefinitions.Add(col_e_18_0);
            ColumnDefinition col_e_18_1 = new ColumnDefinition();
            col_e_18_1.Width = new GridLength(6F, GridUnitType.Star);
            e_18.ColumnDefinitions.Add(col_e_18_1);
            Grid.SetRow(e_18, 1);
            // e_19 element
            Grid e_19 = new Grid();
            e_18.Children.Add(e_19);
            e_19.Name = "e_19";
            RowDefinition row_e_19_0 = new RowDefinition();
            row_e_19_0.Height = new GridLength(1F, GridUnitType.Auto);
            e_19.RowDefinitions.Add(row_e_19_0);
            RowDefinition row_e_19_1 = new RowDefinition();
            row_e_19_1.Height = new GridLength(1F, GridUnitType.Auto);
            e_19.RowDefinitions.Add(row_e_19_1);
            RowDefinition row_e_19_2 = new RowDefinition();
            row_e_19_2.Height = new GridLength(1F, GridUnitType.Auto);
            e_19.RowDefinitions.Add(row_e_19_2);
            RowDefinition row_e_19_3 = new RowDefinition();
            row_e_19_3.Height = new GridLength(1F, GridUnitType.Auto);
            e_19.RowDefinitions.Add(row_e_19_3);
            Grid.SetColumn(e_19, 0);
            // e_20 element
            Grid e_20 = new Grid();
            e_19.Children.Add(e_20);
            e_20.Name = "e_20";
            e_20.Margin = new Thickness(5F, 2F, 5F, 2F);
            e_20.HorizontalAlignment = HorizontalAlignment.Center;
            Grid.SetRow(e_20, 0);
            // e_21 element
            TextBlock e_21 = new TextBlock();
            e_20.Children.Add(e_21);
            e_21.Name = "e_21";
            e_21.HorizontalAlignment = HorizontalAlignment.Left;
            e_21.VerticalAlignment = VerticalAlignment.Center;
            Binding binding_e_21_Text = new Binding("Name");
            e_21.SetBinding(TextBlock.TextProperty, binding_e_21_Text);
            // e_22 element
            Grid e_22 = new Grid();
            e_19.Children.Add(e_22);
            e_22.Name = "e_22";
            e_22.Margin = new Thickness(5F, 2F, 5F, 2F);
            ColumnDefinition col_e_22_0 = new ColumnDefinition();
            col_e_22_0.Width = new GridLength(1F, GridUnitType.Star);
            e_22.ColumnDefinitions.Add(col_e_22_0);
            ColumnDefinition col_e_22_1 = new ColumnDefinition();
            col_e_22_1.Width = new GridLength(1F, GridUnitType.Star);
            e_22.ColumnDefinitions.Add(col_e_22_1);
            Grid.SetRow(e_22, 1);
            // e_23 element
            TextBlock e_23 = new TextBlock();
            e_22.Children.Add(e_23);
            e_23.Name = "e_23";
            e_23.HorizontalAlignment = HorizontalAlignment.Left;
            e_23.VerticalAlignment = VerticalAlignment.Center;
            e_23.Text = "Level";
            Grid.SetColumn(e_23, 0);
            // e_24 element
            TextBlock e_24 = new TextBlock();
            e_22.Children.Add(e_24);
            e_24.Name = "e_24";
            e_24.HorizontalAlignment = HorizontalAlignment.Right;
            e_24.VerticalAlignment = VerticalAlignment.Center;
            Grid.SetColumn(e_24, 1);
            Binding binding_e_24_Text = new Binding("Level");
            e_24.SetBinding(TextBlock.TextProperty, binding_e_24_Text);
            // e_25 element
            Grid e_25 = new Grid();
            e_19.Children.Add(e_25);
            e_25.Name = "e_25";
            e_25.Margin = new Thickness(5F, 2F, 5F, 2F);
            Grid.SetRow(e_25, 2);
            // e_26 element
            Border e_26 = new Border();
            e_25.Children.Add(e_26);
            e_26.Name = "e_26";
            e_26.Margin = new Thickness(2F, 2F, 2F, 2F);
            e_26.HorizontalAlignment = HorizontalAlignment.Stretch;
            e_26.VerticalAlignment = VerticalAlignment.Stretch;
            e_26.Background = new SolidColorBrush(new ColorW(255, 255, 255, 0));
            e_26.BorderBrush = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            e_26.BorderThickness = new Thickness(2F, 2F, 2F, 2F);
            e_26.Padding = new Thickness(0F, 0F, 0F, 0F);
            // e_27 element
            ProgressBar e_27 = new ProgressBar();
            e_26.Child = e_27;
            e_27.Name = "e_27";
            e_27.Height = 5F;
            e_27.Margin = new Thickness(0F, 0F, 0F, 0F);
            e_27.HorizontalAlignment = HorizontalAlignment.Stretch;
            e_27.VerticalAlignment = VerticalAlignment.Stretch;
            e_27.Opacity = 1F;
            e_27.Background = new SolidColorBrush(new ColorW(255, 255, 255, 0));
            e_27.Foreground = new SolidColorBrush(new ColorW(255, 0, 0, 255));
            Grid.SetRow(e_27, 0);
            Binding binding_e_27_Maximum = new Binding("Max_Experience");
            binding_e_27_Maximum.FallbackValue = "100";
            e_27.SetBinding(ProgressBar.MaximumProperty, binding_e_27_Maximum);
            Binding binding_e_27_Value = new Binding("Experience_Current");
            binding_e_27_Value.FallbackValue = "50";
            e_27.SetBinding(ProgressBar.ValueProperty, binding_e_27_Value);
            // e_28 element
            Grid e_28 = new Grid();
            e_19.Children.Add(e_28);
            e_28.Name = "e_28";
            e_28.Margin = new Thickness(5F, 2F, 5F, 2F);
            ColumnDefinition col_e_28_0 = new ColumnDefinition();
            col_e_28_0.Width = new GridLength(1F, GridUnitType.Star);
            e_28.ColumnDefinitions.Add(col_e_28_0);
            ColumnDefinition col_e_28_1 = new ColumnDefinition();
            col_e_28_1.Width = new GridLength(1F, GridUnitType.Star);
            e_28.ColumnDefinitions.Add(col_e_28_1);
            Grid.SetRow(e_28, 3);
            // e_29 element
            TextBlock e_29 = new TextBlock();
            e_28.Children.Add(e_29);
            e_29.Name = "e_29";
            e_29.HorizontalAlignment = HorizontalAlignment.Left;
            e_29.VerticalAlignment = VerticalAlignment.Center;
            e_29.Text = "Exp";
            Grid.SetColumn(e_29, 0);
            // e_30 element
            TextBlock e_30 = new TextBlock();
            e_28.Children.Add(e_30);
            e_30.Name = "e_30";
            e_30.HorizontalAlignment = HorizontalAlignment.Right;
            e_30.VerticalAlignment = VerticalAlignment.Center;
            Grid.SetColumn(e_30, 1);
            Binding binding_e_30_Text = new Binding("Experience");
            e_30.SetBinding(TextBlock.TextProperty, binding_e_30_Text);
            // e_31 element
            Grid e_31 = new Grid();
            e_18.Children.Add(e_31);
            e_31.Name = "e_31";
            ColumnDefinition col_e_31_0 = new ColumnDefinition();
            col_e_31_0.Width = new GridLength(3F, GridUnitType.Star);
            e_31.ColumnDefinitions.Add(col_e_31_0);
            ColumnDefinition col_e_31_1 = new ColumnDefinition();
            col_e_31_1.Width = new GridLength(7F, GridUnitType.Star);
            e_31.ColumnDefinitions.Add(col_e_31_1);
            Grid.SetColumn(e_31, 1);
            // e_32 element
            Grid e_32 = new Grid();
            e_31.Children.Add(e_32);
            e_32.Name = "e_32";
            RowDefinition row_e_32_0 = new RowDefinition();
            row_e_32_0.Height = new GridLength(1F, GridUnitType.Star);
            e_32.RowDefinitions.Add(row_e_32_0);
            RowDefinition row_e_32_1 = new RowDefinition();
            row_e_32_1.Height = new GridLength(1F, GridUnitType.Star);
            e_32.RowDefinitions.Add(row_e_32_1);
            RowDefinition row_e_32_2 = new RowDefinition();
            row_e_32_2.Height = new GridLength(1F, GridUnitType.Star);
            e_32.RowDefinitions.Add(row_e_32_2);
            RowDefinition row_e_32_3 = new RowDefinition();
            row_e_32_3.Height = new GridLength(1F, GridUnitType.Star);
            e_32.RowDefinitions.Add(row_e_32_3);
            Grid.SetColumn(e_32, 0);
            // e_33 element
            ToggleButton e_33 = new ToggleButton();
            e_32.Children.Add(e_33);
            e_33.Name = "e_33";
            e_33.Margin = new Thickness(2F, 2F, 2F, 2F);
            e_33.HorizontalAlignment = HorizontalAlignment.Stretch;
            e_33.VerticalAlignment = VerticalAlignment.Stretch;
            e_33.Background = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            e_33.Foreground = new SolidColorBrush(new ColorW(255, 255, 255, 255));
            e_33.FontStyle = FontStyle.Bold;
            e_33.Content = "Head";
            Grid.SetRow(e_33, 0);
            Binding binding_e_33_Command = new Binding("HeadCommand");
            e_33.SetBinding(ToggleButton.CommandProperty, binding_e_33_Command);
            Binding binding_e_33_IsChecked = new Binding("HeadChecked");
            e_33.SetBinding(ToggleButton.IsCheckedProperty, binding_e_33_IsChecked);
            // e_34 element
            ToggleButton e_34 = new ToggleButton();
            e_32.Children.Add(e_34);
            e_34.Name = "e_34";
            e_34.Margin = new Thickness(2F, 2F, 2F, 2F);
            e_34.HorizontalAlignment = HorizontalAlignment.Stretch;
            e_34.VerticalAlignment = VerticalAlignment.Stretch;
            e_34.Background = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            e_34.Foreground = new SolidColorBrush(new ColorW(255, 255, 255, 255));
            e_34.FontStyle = FontStyle.Bold;
            e_34.Content = "Body";
            Grid.SetRow(e_34, 1);
            Binding binding_e_34_Command = new Binding("BodyCommand");
            e_34.SetBinding(ToggleButton.CommandProperty, binding_e_34_Command);
            Binding binding_e_34_IsChecked = new Binding("BodyChecked");
            e_34.SetBinding(ToggleButton.IsCheckedProperty, binding_e_34_IsChecked);
            // e_35 element
            ToggleButton e_35 = new ToggleButton();
            e_32.Children.Add(e_35);
            e_35.Name = "e_35";
            e_35.Margin = new Thickness(2F, 2F, 2F, 2F);
            e_35.HorizontalAlignment = HorizontalAlignment.Stretch;
            e_35.VerticalAlignment = VerticalAlignment.Stretch;
            e_35.Background = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            e_35.Foreground = new SolidColorBrush(new ColorW(255, 255, 255, 255));
            e_35.FontStyle = FontStyle.Bold;
            e_35.Content = "Legs";
            Grid.SetRow(e_35, 2);
            Binding binding_e_35_Command = new Binding("LegsCommand");
            e_35.SetBinding(ToggleButton.CommandProperty, binding_e_35_Command);
            Binding binding_e_35_IsChecked = new Binding("LegsChecked");
            e_35.SetBinding(ToggleButton.IsCheckedProperty, binding_e_35_IsChecked);
            // e_36 element
            ToggleButton e_36 = new ToggleButton();
            e_32.Children.Add(e_36);
            e_36.Name = "e_36";
            e_36.Margin = new Thickness(2F, 2F, 2F, 2F);
            e_36.HorizontalAlignment = HorizontalAlignment.Stretch;
            e_36.VerticalAlignment = VerticalAlignment.Stretch;
            e_36.Background = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            e_36.Foreground = new SolidColorBrush(new ColorW(255, 255, 255, 255));
            e_36.FontStyle = FontStyle.Bold;
            e_36.Content = "Feets";
            Grid.SetRow(e_36, 3);
            Binding binding_e_36_Command = new Binding("FeetsCommand");
            e_36.SetBinding(ToggleButton.CommandProperty, binding_e_36_Command);
            Binding binding_e_36_IsChecked = new Binding("FeetsChecked");
            e_36.SetBinding(ToggleButton.IsCheckedProperty, binding_e_36_IsChecked);
            // e_37 element
            Grid e_37 = new Grid();
            e_31.Children.Add(e_37);
            e_37.Name = "e_37";
            Grid.SetColumn(e_37, 1);
            // e_38 element
            ScrollViewer e_38 = new ScrollViewer();
            e_37.Children.Add(e_38);
            e_38.Name = "e_38";
            // e_39 element
            ItemsControl e_39 = new ItemsControl();
            e_38.Content = e_39;
            e_39.Name = "e_39";
            Func<UIElement, UIElement> e_39_iptFunc = e_39_iptMethod;
            ControlTemplate e_39_ipt = new ControlTemplate(e_39_iptFunc);
            e_39.ItemsPanel = e_39_ipt;
            Func<UIElement, UIElement> e_39_dtFunc = e_39_dtMethod;
            e_39.ItemTemplate = new DataTemplate(e_39_dtFunc);
            Binding binding_e_39_ItemsSource = new Binding("LstColors");
            e_39.SetBinding(ItemsControl.ItemsSourceProperty, binding_e_39_ItemsSource);
            // e_43 element
            Grid e_43 = new Grid();
            e_10.Children.Add(e_43);
            e_43.Name = "e_43";
            Grid.SetRow(e_43, 2);
            // e_44 element
            Button e_44 = new Button();
            e_43.Children.Add(e_44);
            e_44.Name = "e_44";
            e_44.HorizontalAlignment = HorizontalAlignment.Stretch;
            e_44.VerticalAlignment = VerticalAlignment.Stretch;
            e_44.Content = "Aplicar Cambio";
            Binding binding_e_44_Command = new Binding("ApplyChange");
            e_44.SetBinding(Button.CommandProperty, binding_e_44_Command);
            items.Add(e_9);
            // e_45 element
            TabItem e_45 = new TabItem();
            e_45.Name = "e_45";
            e_45.Width = 200F;
            e_45.Margin = new Thickness(5F, 0F, 5F, 0F);
            e_45.Header = "Habilidades";
            // e_46 element
            Grid e_46 = new Grid();
            e_45.Content = e_46;
            e_46.Name = "e_46";
            items.Add(e_45);
            // e_47 element
            TabItem e_47 = new TabItem();
            e_47.Name = "e_47";
            e_47.Width = 200F;
            e_47.Margin = new Thickness(5F, 0F, 5F, 0F);
            e_47.Header = "Misiones";
            // e_48 element
            Grid e_48 = new Grid();
            e_47.Content = e_48;
            e_48.Name = "e_48";
            items.Add(e_47);
            return items;
        }
        
        private static UIElement e_39_iptMethod(UIElement parent) {
            // e_40 element
            WrapPanel e_40 = new WrapPanel();
            e_40.Parent = parent;
            e_40.Name = "e_40";
            e_40.IsItemsHost = true;
            e_40.Orientation = Orientation.Horizontal;
            return e_40;
        }
        
        private static UIElement e_39_dtMethod(UIElement parent) {
            // e_41 element
            Border e_41 = new Border();
            e_41.Parent = parent;
            e_41.Name = "e_41";
            e_41.Height = 32F;
            e_41.Width = 32F;
            e_41.Margin = new Thickness(5F, 5F, 5F, 5F);
            e_41.BorderThickness = new Thickness(1F, 1F, 1F, 1F);
            e_41.Padding = new Thickness(0F, 0F, 0F, 0F);
            Binding binding_e_41_BorderBrush = new Binding("select_color");
            e_41.SetBinding(Border.BorderBrushProperty, binding_e_41_BorderBrush);
            // e_42 element
            ImageButton e_42 = new ImageButton();
            e_41.Child = e_42;
            e_42.Name = "e_42";
            e_42.Margin = new Thickness(0F, 0F, 0F, 0F);
            e_42.HorizontalAlignment = HorizontalAlignment.Stretch;
            e_42.VerticalAlignment = VerticalAlignment.Stretch;
            Binding binding_e_42_Background = new Binding("color");
            e_42.SetBinding(ImageButton.BackgroundProperty, binding_e_42_Background);
            Binding binding_e_42_Command = new Binding("command");
            e_42.SetBinding(ImageButton.CommandProperty, binding_e_42_Command);
            Binding binding_e_42_CommandParameter = new Binding();
            e_42.SetBinding(ImageButton.CommandParameterProperty, binding_e_42_CommandParameter);
            return e_41;
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
            e_4.Text = "PERFIL";
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
            TabControl e_8 = new TabControl();
            e_7.Children.Add(e_8);
            e_8.Name = "e_8";
            e_8.ItemsSource = Get_e_8_Items();
            return e_0;
        }
    }
}
