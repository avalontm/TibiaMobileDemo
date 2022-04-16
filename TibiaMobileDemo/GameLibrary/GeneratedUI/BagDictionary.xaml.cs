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
    public sealed class BagDictionary : ResourceDictionary {
        
        private static BagDictionary singleton = new BagDictionary();
        
        public BagDictionary() {
            this.InitializeResources();
        }
        
        public static BagDictionary Instance {
            get {
                return singleton;
            }
        }
        
        private void InitializeResources() {
            // Resource - [PlayerBagWindowTemplate] ControlTemplate
            Func<UIElement, UIElement> r_0_ctFunc = r_0_ctMethod;
            ControlTemplate r_0_ct = new ControlTemplate(r_0_ctFunc);
            this.Add("PlayerBagWindowTemplate", r_0_ct);
            ImageManager.Instance.AddImage("Images/ic_close");
            FontManager.Instance.AddFont("Segoe UI", 24F, FontStyle.Bold, "Segoe_UI_18_Bold");
        }
        
        private static UIElement e_80_iptMethod(UIElement parent) {
            // e_81 element
            WrapPanel e_81 = new WrapPanel();
            e_81.Parent = parent;
            e_81.Name = "e_81";
            e_81.IsItemsHost = true;
            e_81.Orientation = Orientation.Horizontal;
            return e_81;
        }
        
        private static UIElement e_80_dtMethod(UIElement parent) {
            // e_82 element
            Border e_82 = new Border();
            e_82.Parent = parent;
            e_82.Name = "e_82";
            e_82.Height = 100F;
            e_82.Width = 100F;
            e_82.Margin = new Thickness(5F, 5F, 5F, 5F);
            e_82.Background = new SolidColorBrush(new ColorW(69, 69, 69, 255));
            e_82.BorderThickness = new Thickness(3F, 3F, 3F, 3F);
            e_82.Padding = new Thickness(0F, 0F, 0F, 0F);
            Binding binding_e_82_BorderBrush = new Binding("select_color");
            e_82.SetBinding(Border.BorderBrushProperty, binding_e_82_BorderBrush);
            // e_83 element
            Grid e_83 = new Grid();
            e_82.Child = e_83;
            e_83.Name = "e_83";
            // e_84 element
            ImageButton e_84 = new ImageButton();
            e_83.Children.Add(e_84);
            e_84.Name = "e_84";
            e_84.Margin = new Thickness(0F, 0F, 0F, 0F);
            e_84.HorizontalAlignment = HorizontalAlignment.Stretch;
            e_84.VerticalAlignment = VerticalAlignment.Stretch;
            e_84.Padding = new Thickness(0F, 0F, 0F, 0F);
            Binding binding_e_84_Command = new Binding("command");
            e_84.SetBinding(ImageButton.CommandProperty, binding_e_84_Command);
            Binding binding_e_84_CommandParameter = new Binding();
            e_84.SetBinding(ImageButton.CommandParameterProperty, binding_e_84_CommandParameter);
            // e_85 element
            Grid e_85 = new Grid();
            e_84.Content = e_85;
            e_85.Name = "e_85";
            // e_86 element
            Image e_86 = new Image();
            e_85.Children.Add(e_86);
            e_86.Name = "e_86";
            e_86.Margin = new Thickness(10F, 10F, 10F, 10F);
            e_86.HorizontalAlignment = HorizontalAlignment.Stretch;
            e_86.VerticalAlignment = VerticalAlignment.Stretch;
            e_86.Stretch = Stretch.Fill;
            Binding binding_e_86_Source = new Binding("image");
            e_86.SetBinding(Image.SourceProperty, binding_e_86_Source);
            // e_87 element
            TextBlock e_87 = new TextBlock();
            e_85.Children.Add(e_87);
            e_87.Name = "e_87";
            e_87.Margin = new Thickness(0F, 0F, 5F, 5F);
            e_87.HorizontalAlignment = HorizontalAlignment.Right;
            e_87.VerticalAlignment = VerticalAlignment.Bottom;
            e_87.TextAlignment = TextAlignment.Center;
            e_87.FontSize = 24F;
            e_87.FontStyle = FontStyle.Bold;
            Binding binding_e_87_Text = new Binding("count");
            e_87.SetBinding(TextBlock.TextProperty, binding_e_87_Text);
            return e_82;
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
            e_4.Text = "EQUIPO";
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
            ColumnDefinition col_e_7_0 = new ColumnDefinition();
            col_e_7_0.Width = new GridLength(35F, GridUnitType.Star);
            e_7.ColumnDefinitions.Add(col_e_7_0);
            ColumnDefinition col_e_7_1 = new ColumnDefinition();
            col_e_7_1.Width = new GridLength(65F, GridUnitType.Star);
            e_7.ColumnDefinitions.Add(col_e_7_1);
            Grid.SetRow(e_7, 1);
            // e_8 element
            Grid e_8 = new Grid();
            e_7.Children.Add(e_8);
            e_8.Name = "e_8";
            Grid.SetColumn(e_8, 0);
            // e_9 element
            Border e_9 = new Border();
            e_8.Children.Add(e_9);
            e_9.Name = "e_9";
            e_9.Margin = new Thickness(0F, 0F, 0F, 0F);
            e_9.HorizontalAlignment = HorizontalAlignment.Center;
            e_9.VerticalAlignment = VerticalAlignment.Center;
            e_9.Background = new SolidColorBrush(new ColorW(33, 33, 33, 255));
            e_9.BorderBrush = new SolidColorBrush(new ColorW(69, 69, 69, 255));
            e_9.BorderThickness = new Thickness(3F, 3F, 3F, 3F);
            e_9.Padding = new Thickness(5F, 5F, 5F, 5F);
            // e_10 element
            Grid e_10 = new Grid();
            e_9.Child = e_10;
            e_10.Name = "e_10";
            ColumnDefinition col_e_10_0 = new ColumnDefinition();
            col_e_10_0.Width = new GridLength(100F, GridUnitType.Pixel);
            e_10.ColumnDefinitions.Add(col_e_10_0);
            ColumnDefinition col_e_10_1 = new ColumnDefinition();
            col_e_10_1.Width = new GridLength(100F, GridUnitType.Pixel);
            e_10.ColumnDefinitions.Add(col_e_10_1);
            ColumnDefinition col_e_10_2 = new ColumnDefinition();
            col_e_10_2.Width = new GridLength(100F, GridUnitType.Pixel);
            e_10.ColumnDefinitions.Add(col_e_10_2);
            // e_11 element
            Grid e_11 = new Grid();
            e_10.Children.Add(e_11);
            e_11.Name = "e_11";
            e_11.Margin = new Thickness(5F, 50F, 2F, 0F);
            RowDefinition row_e_11_0 = new RowDefinition();
            row_e_11_0.Height = new GridLength(100F, GridUnitType.Pixel);
            e_11.RowDefinitions.Add(row_e_11_0);
            RowDefinition row_e_11_1 = new RowDefinition();
            row_e_11_1.Height = new GridLength(100F, GridUnitType.Pixel);
            e_11.RowDefinitions.Add(row_e_11_1);
            RowDefinition row_e_11_2 = new RowDefinition();
            row_e_11_2.Height = new GridLength(100F, GridUnitType.Pixel);
            e_11.RowDefinitions.Add(row_e_11_2);
            Grid.SetColumn(e_11, 0);
            // e_12 element
            Grid e_12 = new Grid();
            e_11.Children.Add(e_12);
            e_12.Name = "e_12";
            Grid.SetRow(e_12, 0);
            // e_13 element
            Border e_13 = new Border();
            e_12.Children.Add(e_13);
            e_13.Name = "e_13";
            e_13.Height = 80F;
            e_13.Width = 80F;
            e_13.Margin = new Thickness(5F, 5F, 5F, 5F);
            e_13.Background = new SolidColorBrush(new ColorW(48, 48, 48, 255));
            e_13.BorderThickness = new Thickness(3F, 3F, 3F, 3F);
            e_13.Padding = new Thickness(0F, 0F, 0F, 0F);
            Binding binding_e_13_BorderBrush = new Binding("slotNeacle_color");
            e_13.SetBinding(Border.BorderBrushProperty, binding_e_13_BorderBrush);
            // e_14 element
            Grid e_14 = new Grid();
            e_13.Child = e_14;
            e_14.Name = "e_14";
            // e_15 element
            ImageButton e_15 = new ImageButton();
            e_14.Children.Add(e_15);
            e_15.Name = "e_15";
            e_15.Margin = new Thickness(0F, 0F, 0F, 0F);
            e_15.HorizontalAlignment = HorizontalAlignment.Stretch;
            e_15.VerticalAlignment = VerticalAlignment.Stretch;
            e_15.Padding = new Thickness(0F, 0F, 0F, 0F);
            Binding binding_e_15_Command = new Binding("setSlotCommand");
            e_15.SetBinding(ImageButton.CommandProperty, binding_e_15_Command);
            Binding binding_e_15_CommandParameter = new Binding("setNeacle");
            e_15.SetBinding(ImageButton.CommandParameterProperty, binding_e_15_CommandParameter);
            // e_16 element
            Grid e_16 = new Grid();
            e_15.Content = e_16;
            e_16.Name = "e_16";
            // e_17 element
            Image e_17 = new Image();
            e_16.Children.Add(e_17);
            e_17.Name = "e_17";
            e_17.Margin = new Thickness(0F, 0F, 0F, 0F);
            e_17.HorizontalAlignment = HorizontalAlignment.Stretch;
            e_17.VerticalAlignment = VerticalAlignment.Stretch;
            e_17.Stretch = Stretch.Fill;
            Binding binding_e_17_Source = new Binding("setNeacle.image");
            e_17.SetBinding(Image.SourceProperty, binding_e_17_Source);
            // e_18 element
            Grid e_18 = new Grid();
            e_11.Children.Add(e_18);
            e_18.Name = "e_18";
            Grid.SetRow(e_18, 1);
            // e_19 element
            Border e_19 = new Border();
            e_18.Children.Add(e_19);
            e_19.Name = "e_19";
            e_19.Height = 80F;
            e_19.Width = 80F;
            e_19.Margin = new Thickness(5F, 5F, 5F, 5F);
            e_19.Background = new SolidColorBrush(new ColorW(48, 48, 48, 255));
            e_19.BorderThickness = new Thickness(3F, 3F, 3F, 3F);
            e_19.Padding = new Thickness(0F, 0F, 0F, 0F);
            Binding binding_e_19_BorderBrush = new Binding("slotWeapon_color");
            e_19.SetBinding(Border.BorderBrushProperty, binding_e_19_BorderBrush);
            // e_20 element
            Grid e_20 = new Grid();
            e_19.Child = e_20;
            e_20.Name = "e_20";
            // e_21 element
            ImageButton e_21 = new ImageButton();
            e_20.Children.Add(e_21);
            e_21.Name = "e_21";
            e_21.Margin = new Thickness(0F, 0F, 0F, 0F);
            e_21.HorizontalAlignment = HorizontalAlignment.Stretch;
            e_21.VerticalAlignment = VerticalAlignment.Stretch;
            e_21.Padding = new Thickness(0F, 0F, 0F, 0F);
            Binding binding_e_21_Command = new Binding("setSlotCommand");
            e_21.SetBinding(ImageButton.CommandProperty, binding_e_21_Command);
            Binding binding_e_21_CommandParameter = new Binding("setHandLeft");
            e_21.SetBinding(ImageButton.CommandParameterProperty, binding_e_21_CommandParameter);
            // e_22 element
            Grid e_22 = new Grid();
            e_21.Content = e_22;
            e_22.Name = "e_22";
            // e_23 element
            Image e_23 = new Image();
            e_22.Children.Add(e_23);
            e_23.Name = "e_23";
            e_23.Margin = new Thickness(0F, 0F, 0F, 0F);
            e_23.HorizontalAlignment = HorizontalAlignment.Stretch;
            e_23.VerticalAlignment = VerticalAlignment.Stretch;
            e_23.Stretch = Stretch.Fill;
            Binding binding_e_23_Source = new Binding("setHandLeft.image");
            e_23.SetBinding(Image.SourceProperty, binding_e_23_Source);
            // e_24 element
            Grid e_24 = new Grid();
            e_11.Children.Add(e_24);
            e_24.Name = "e_24";
            Grid.SetRow(e_24, 2);
            // e_25 element
            Border e_25 = new Border();
            e_24.Children.Add(e_25);
            e_25.Name = "e_25";
            e_25.Height = 80F;
            e_25.Width = 80F;
            e_25.Margin = new Thickness(5F, 5F, 5F, 5F);
            e_25.Background = new SolidColorBrush(new ColorW(48, 48, 48, 255));
            e_25.BorderThickness = new Thickness(3F, 3F, 3F, 3F);
            e_25.Padding = new Thickness(0F, 0F, 0F, 0F);
            Binding binding_e_25_BorderBrush = new Binding("slotRing_color");
            e_25.SetBinding(Border.BorderBrushProperty, binding_e_25_BorderBrush);
            // e_26 element
            Grid e_26 = new Grid();
            e_25.Child = e_26;
            e_26.Name = "e_26";
            // e_27 element
            ImageButton e_27 = new ImageButton();
            e_26.Children.Add(e_27);
            e_27.Name = "e_27";
            e_27.Margin = new Thickness(0F, 0F, 0F, 0F);
            e_27.HorizontalAlignment = HorizontalAlignment.Stretch;
            e_27.VerticalAlignment = VerticalAlignment.Stretch;
            e_27.Padding = new Thickness(0F, 0F, 0F, 0F);
            Binding binding_e_27_Command = new Binding("setSlotCommand");
            e_27.SetBinding(ImageButton.CommandProperty, binding_e_27_Command);
            Binding binding_e_27_CommandParameter = new Binding("setRing");
            e_27.SetBinding(ImageButton.CommandParameterProperty, binding_e_27_CommandParameter);
            // e_28 element
            Grid e_28 = new Grid();
            e_27.Content = e_28;
            e_28.Name = "e_28";
            // e_29 element
            Image e_29 = new Image();
            e_28.Children.Add(e_29);
            e_29.Name = "e_29";
            e_29.Margin = new Thickness(0F, 0F, 0F, 0F);
            e_29.HorizontalAlignment = HorizontalAlignment.Stretch;
            e_29.VerticalAlignment = VerticalAlignment.Stretch;
            e_29.Stretch = Stretch.Fill;
            Binding binding_e_29_Source = new Binding("setRing.image");
            e_29.SetBinding(Image.SourceProperty, binding_e_29_Source);
            // e_30 element
            Grid e_30 = new Grid();
            e_10.Children.Add(e_30);
            e_30.Name = "e_30";
            e_30.Margin = new Thickness(2F, 10F, 5F, 0F);
            RowDefinition row_e_30_0 = new RowDefinition();
            row_e_30_0.Height = new GridLength(100F, GridUnitType.Pixel);
            e_30.RowDefinitions.Add(row_e_30_0);
            RowDefinition row_e_30_1 = new RowDefinition();
            row_e_30_1.Height = new GridLength(100F, GridUnitType.Pixel);
            e_30.RowDefinitions.Add(row_e_30_1);
            RowDefinition row_e_30_2 = new RowDefinition();
            row_e_30_2.Height = new GridLength(100F, GridUnitType.Pixel);
            e_30.RowDefinitions.Add(row_e_30_2);
            RowDefinition row_e_30_3 = new RowDefinition();
            row_e_30_3.Height = new GridLength(100F, GridUnitType.Pixel);
            e_30.RowDefinitions.Add(row_e_30_3);
            Grid.SetColumn(e_30, 1);
            // e_31 element
            Grid e_31 = new Grid();
            e_30.Children.Add(e_31);
            e_31.Name = "e_31";
            Grid.SetRow(e_31, 0);
            // e_32 element
            Border e_32 = new Border();
            e_31.Children.Add(e_32);
            e_32.Name = "e_32";
            e_32.Height = 80F;
            e_32.Width = 80F;
            e_32.Margin = new Thickness(5F, 5F, 5F, 5F);
            e_32.Background = new SolidColorBrush(new ColorW(48, 48, 48, 255));
            e_32.BorderThickness = new Thickness(3F, 3F, 3F, 3F);
            e_32.Padding = new Thickness(0F, 0F, 0F, 0F);
            Binding binding_e_32_BorderBrush = new Binding("slotHead_color");
            e_32.SetBinding(Border.BorderBrushProperty, binding_e_32_BorderBrush);
            // e_33 element
            Grid e_33 = new Grid();
            e_32.Child = e_33;
            e_33.Name = "e_33";
            // e_34 element
            ImageButton e_34 = new ImageButton();
            e_33.Children.Add(e_34);
            e_34.Name = "e_34";
            e_34.Margin = new Thickness(0F, 0F, 0F, 0F);
            e_34.HorizontalAlignment = HorizontalAlignment.Stretch;
            e_34.VerticalAlignment = VerticalAlignment.Stretch;
            e_34.Padding = new Thickness(0F, 0F, 0F, 0F);
            Binding binding_e_34_Command = new Binding("setSlotCommand");
            e_34.SetBinding(ImageButton.CommandProperty, binding_e_34_Command);
            Binding binding_e_34_CommandParameter = new Binding("setHead");
            e_34.SetBinding(ImageButton.CommandParameterProperty, binding_e_34_CommandParameter);
            // e_35 element
            Grid e_35 = new Grid();
            e_34.Content = e_35;
            e_35.Name = "e_35";
            // e_36 element
            Image e_36 = new Image();
            e_35.Children.Add(e_36);
            e_36.Name = "e_36";
            e_36.Margin = new Thickness(0F, 0F, 0F, 0F);
            e_36.HorizontalAlignment = HorizontalAlignment.Stretch;
            e_36.VerticalAlignment = VerticalAlignment.Stretch;
            e_36.Stretch = Stretch.Fill;
            Binding binding_e_36_Source = new Binding("setHead.image");
            e_36.SetBinding(Image.SourceProperty, binding_e_36_Source);
            // e_37 element
            Grid e_37 = new Grid();
            e_30.Children.Add(e_37);
            e_37.Name = "e_37";
            Grid.SetRow(e_37, 1);
            // e_38 element
            Border e_38 = new Border();
            e_37.Children.Add(e_38);
            e_38.Name = "e_38";
            e_38.Height = 80F;
            e_38.Width = 80F;
            e_38.Margin = new Thickness(5F, 5F, 5F, 5F);
            e_38.Background = new SolidColorBrush(new ColorW(48, 48, 48, 255));
            e_38.BorderThickness = new Thickness(3F, 3F, 3F, 3F);
            e_38.Padding = new Thickness(0F, 0F, 0F, 0F);
            Binding binding_e_38_BorderBrush = new Binding("slotArmor_color");
            e_38.SetBinding(Border.BorderBrushProperty, binding_e_38_BorderBrush);
            // e_39 element
            Grid e_39 = new Grid();
            e_38.Child = e_39;
            e_39.Name = "e_39";
            // e_40 element
            ImageButton e_40 = new ImageButton();
            e_39.Children.Add(e_40);
            e_40.Name = "e_40";
            e_40.Margin = new Thickness(0F, 0F, 0F, 0F);
            e_40.HorizontalAlignment = HorizontalAlignment.Stretch;
            e_40.VerticalAlignment = VerticalAlignment.Stretch;
            e_40.Padding = new Thickness(0F, 0F, 0F, 0F);
            Binding binding_e_40_Command = new Binding("setSlotCommand");
            e_40.SetBinding(ImageButton.CommandProperty, binding_e_40_Command);
            Binding binding_e_40_CommandParameter = new Binding("setBody");
            e_40.SetBinding(ImageButton.CommandParameterProperty, binding_e_40_CommandParameter);
            // e_41 element
            Grid e_41 = new Grid();
            e_40.Content = e_41;
            e_41.Name = "e_41";
            // e_42 element
            Image e_42 = new Image();
            e_41.Children.Add(e_42);
            e_42.Name = "e_42";
            e_42.Margin = new Thickness(0F, 0F, 0F, 0F);
            e_42.HorizontalAlignment = HorizontalAlignment.Stretch;
            e_42.VerticalAlignment = VerticalAlignment.Stretch;
            e_42.Stretch = Stretch.Fill;
            Binding binding_e_42_Source = new Binding("setBody.image");
            e_42.SetBinding(Image.SourceProperty, binding_e_42_Source);
            // e_43 element
            Grid e_43 = new Grid();
            e_30.Children.Add(e_43);
            e_43.Name = "e_43";
            Grid.SetRow(e_43, 2);
            // e_44 element
            Border e_44 = new Border();
            e_43.Children.Add(e_44);
            e_44.Name = "e_44";
            e_44.Height = 80F;
            e_44.Width = 80F;
            e_44.Margin = new Thickness(5F, 5F, 5F, 5F);
            e_44.Background = new SolidColorBrush(new ColorW(48, 48, 48, 255));
            e_44.BorderThickness = new Thickness(3F, 3F, 3F, 3F);
            e_44.Padding = new Thickness(0F, 0F, 0F, 0F);
            Binding binding_e_44_BorderBrush = new Binding("slotLegs_color");
            e_44.SetBinding(Border.BorderBrushProperty, binding_e_44_BorderBrush);
            // e_45 element
            Grid e_45 = new Grid();
            e_44.Child = e_45;
            e_45.Name = "e_45";
            // e_46 element
            ImageButton e_46 = new ImageButton();
            e_45.Children.Add(e_46);
            e_46.Name = "e_46";
            e_46.Margin = new Thickness(0F, 0F, 0F, 0F);
            e_46.HorizontalAlignment = HorizontalAlignment.Stretch;
            e_46.VerticalAlignment = VerticalAlignment.Stretch;
            e_46.Padding = new Thickness(0F, 0F, 0F, 0F);
            Binding binding_e_46_Command = new Binding("setSlotCommand");
            e_46.SetBinding(ImageButton.CommandProperty, binding_e_46_Command);
            Binding binding_e_46_CommandParameter = new Binding("setLegs");
            e_46.SetBinding(ImageButton.CommandParameterProperty, binding_e_46_CommandParameter);
            // e_47 element
            Grid e_47 = new Grid();
            e_46.Content = e_47;
            e_47.Name = "e_47";
            // e_48 element
            Image e_48 = new Image();
            e_47.Children.Add(e_48);
            e_48.Name = "e_48";
            e_48.Margin = new Thickness(0F, 0F, 0F, 0F);
            e_48.HorizontalAlignment = HorizontalAlignment.Stretch;
            e_48.VerticalAlignment = VerticalAlignment.Stretch;
            e_48.Stretch = Stretch.Fill;
            Binding binding_e_48_Source = new Binding("setLegs.image");
            e_48.SetBinding(Image.SourceProperty, binding_e_48_Source);
            // e_49 element
            Grid e_49 = new Grid();
            e_30.Children.Add(e_49);
            e_49.Name = "e_49";
            Grid.SetRow(e_49, 3);
            // e_50 element
            Border e_50 = new Border();
            e_49.Children.Add(e_50);
            e_50.Name = "e_50";
            e_50.Height = 80F;
            e_50.Width = 80F;
            e_50.Margin = new Thickness(5F, 5F, 5F, 5F);
            e_50.Background = new SolidColorBrush(new ColorW(48, 48, 48, 255));
            e_50.BorderThickness = new Thickness(3F, 3F, 3F, 3F);
            e_50.Padding = new Thickness(0F, 0F, 0F, 0F);
            Binding binding_e_50_BorderBrush = new Binding("slotBoots_color");
            e_50.SetBinding(Border.BorderBrushProperty, binding_e_50_BorderBrush);
            // e_51 element
            Grid e_51 = new Grid();
            e_50.Child = e_51;
            e_51.Name = "e_51";
            // e_52 element
            ImageButton e_52 = new ImageButton();
            e_51.Children.Add(e_52);
            e_52.Name = "e_52";
            e_52.Margin = new Thickness(0F, 0F, 0F, 0F);
            e_52.HorizontalAlignment = HorizontalAlignment.Stretch;
            e_52.VerticalAlignment = VerticalAlignment.Stretch;
            e_52.Padding = new Thickness(0F, 0F, 0F, 0F);
            Binding binding_e_52_Command = new Binding("setSlotCommand");
            e_52.SetBinding(ImageButton.CommandProperty, binding_e_52_Command);
            Binding binding_e_52_CommandParameter = new Binding("setFeets");
            e_52.SetBinding(ImageButton.CommandParameterProperty, binding_e_52_CommandParameter);
            // e_53 element
            Grid e_53 = new Grid();
            e_52.Content = e_53;
            e_53.Name = "e_53";
            // e_54 element
            Image e_54 = new Image();
            e_53.Children.Add(e_54);
            e_54.Name = "e_54";
            e_54.Margin = new Thickness(0F, 0F, 0F, 0F);
            e_54.HorizontalAlignment = HorizontalAlignment.Stretch;
            e_54.VerticalAlignment = VerticalAlignment.Stretch;
            e_54.Stretch = Stretch.Fill;
            Binding binding_e_54_Source = new Binding("setFeets.image");
            e_54.SetBinding(Image.SourceProperty, binding_e_54_Source);
            // e_55 element
            Grid e_55 = new Grid();
            e_10.Children.Add(e_55);
            e_55.Name = "e_55";
            e_55.Margin = new Thickness(5F, 50F, 2F, 0F);
            RowDefinition row_e_55_0 = new RowDefinition();
            row_e_55_0.Height = new GridLength(100F, GridUnitType.Pixel);
            e_55.RowDefinitions.Add(row_e_55_0);
            RowDefinition row_e_55_1 = new RowDefinition();
            row_e_55_1.Height = new GridLength(100F, GridUnitType.Pixel);
            e_55.RowDefinitions.Add(row_e_55_1);
            RowDefinition row_e_55_2 = new RowDefinition();
            row_e_55_2.Height = new GridLength(100F, GridUnitType.Pixel);
            e_55.RowDefinitions.Add(row_e_55_2);
            Grid.SetColumn(e_55, 2);
            // e_56 element
            Grid e_56 = new Grid();
            e_55.Children.Add(e_56);
            e_56.Name = "e_56";
            Grid.SetRow(e_56, 0);
            // e_57 element
            Border e_57 = new Border();
            e_56.Children.Add(e_57);
            e_57.Name = "e_57";
            e_57.Height = 80F;
            e_57.Width = 80F;
            e_57.Margin = new Thickness(5F, 5F, 5F, 5F);
            e_57.Background = new SolidColorBrush(new ColorW(48, 48, 48, 255));
            e_57.BorderThickness = new Thickness(3F, 3F, 3F, 3F);
            e_57.Padding = new Thickness(0F, 0F, 0F, 0F);
            Binding binding_e_57_BorderBrush = new Binding("slotBag_color");
            e_57.SetBinding(Border.BorderBrushProperty, binding_e_57_BorderBrush);
            // e_58 element
            Grid e_58 = new Grid();
            e_57.Child = e_58;
            e_58.Name = "e_58";
            // e_59 element
            ImageButton e_59 = new ImageButton();
            e_58.Children.Add(e_59);
            e_59.Name = "e_59";
            e_59.Margin = new Thickness(0F, 0F, 0F, 0F);
            e_59.HorizontalAlignment = HorizontalAlignment.Stretch;
            e_59.VerticalAlignment = VerticalAlignment.Stretch;
            e_59.Padding = new Thickness(0F, 0F, 0F, 0F);
            Binding binding_e_59_Command = new Binding("setSlotCommand");
            e_59.SetBinding(ImageButton.CommandProperty, binding_e_59_Command);
            Binding binding_e_59_CommandParameter = new Binding("setBackpack");
            e_59.SetBinding(ImageButton.CommandParameterProperty, binding_e_59_CommandParameter);
            // e_60 element
            Grid e_60 = new Grid();
            e_59.Content = e_60;
            e_60.Name = "e_60";
            // e_61 element
            Image e_61 = new Image();
            e_60.Children.Add(e_61);
            e_61.Name = "e_61";
            e_61.Margin = new Thickness(0F, 0F, 0F, 0F);
            e_61.HorizontalAlignment = HorizontalAlignment.Stretch;
            e_61.VerticalAlignment = VerticalAlignment.Stretch;
            e_61.Stretch = Stretch.Fill;
            Binding binding_e_61_Source = new Binding("setBackpack.image");
            e_61.SetBinding(Image.SourceProperty, binding_e_61_Source);
            // e_62 element
            Grid e_62 = new Grid();
            e_55.Children.Add(e_62);
            e_62.Name = "e_62";
            Grid.SetRow(e_62, 1);
            // e_63 element
            Border e_63 = new Border();
            e_62.Children.Add(e_63);
            e_63.Name = "e_63";
            e_63.Height = 80F;
            e_63.Width = 80F;
            e_63.Margin = new Thickness(5F, 5F, 5F, 5F);
            e_63.Background = new SolidColorBrush(new ColorW(48, 48, 48, 255));
            e_63.BorderThickness = new Thickness(3F, 3F, 3F, 3F);
            e_63.Padding = new Thickness(0F, 0F, 0F, 0F);
            Binding binding_e_63_BorderBrush = new Binding("slotShield_color");
            e_63.SetBinding(Border.BorderBrushProperty, binding_e_63_BorderBrush);
            // e_64 element
            Grid e_64 = new Grid();
            e_63.Child = e_64;
            e_64.Name = "e_64";
            // e_65 element
            ImageButton e_65 = new ImageButton();
            e_64.Children.Add(e_65);
            e_65.Name = "e_65";
            e_65.Margin = new Thickness(0F, 0F, 0F, 0F);
            e_65.HorizontalAlignment = HorizontalAlignment.Stretch;
            e_65.VerticalAlignment = VerticalAlignment.Stretch;
            e_65.Padding = new Thickness(0F, 0F, 0F, 0F);
            Binding binding_e_65_Command = new Binding("setSlotCommand");
            e_65.SetBinding(ImageButton.CommandProperty, binding_e_65_Command);
            Binding binding_e_65_CommandParameter = new Binding("setHandRight");
            e_65.SetBinding(ImageButton.CommandParameterProperty, binding_e_65_CommandParameter);
            // e_66 element
            Grid e_66 = new Grid();
            e_65.Content = e_66;
            e_66.Name = "e_66";
            // e_67 element
            Image e_67 = new Image();
            e_66.Children.Add(e_67);
            e_67.Name = "e_67";
            e_67.Margin = new Thickness(0F, 0F, 0F, 0F);
            e_67.HorizontalAlignment = HorizontalAlignment.Stretch;
            e_67.VerticalAlignment = VerticalAlignment.Stretch;
            e_67.Stretch = Stretch.Fill;
            Binding binding_e_67_Source = new Binding("setHandRight.image");
            e_67.SetBinding(Image.SourceProperty, binding_e_67_Source);
            // e_68 element
            Grid e_68 = new Grid();
            e_55.Children.Add(e_68);
            e_68.Name = "e_68";
            Grid.SetRow(e_68, 2);
            // e_69 element
            Border e_69 = new Border();
            e_68.Children.Add(e_69);
            e_69.Name = "e_69";
            e_69.Height = 80F;
            e_69.Width = 80F;
            e_69.Margin = new Thickness(5F, 5F, 5F, 5F);
            e_69.Background = new SolidColorBrush(new ColorW(48, 48, 48, 255));
            e_69.BorderThickness = new Thickness(3F, 3F, 3F, 3F);
            e_69.Padding = new Thickness(0F, 0F, 0F, 0F);
            Binding binding_e_69_BorderBrush = new Binding("slotMisc_color");
            e_69.SetBinding(Border.BorderBrushProperty, binding_e_69_BorderBrush);
            // e_70 element
            Grid e_70 = new Grid();
            e_69.Child = e_70;
            e_70.Name = "e_70";
            // e_71 element
            ImageButton e_71 = new ImageButton();
            e_70.Children.Add(e_71);
            e_71.Name = "e_71";
            e_71.Margin = new Thickness(0F, 0F, 0F, 0F);
            e_71.HorizontalAlignment = HorizontalAlignment.Stretch;
            e_71.VerticalAlignment = VerticalAlignment.Stretch;
            e_71.Padding = new Thickness(0F, 0F, 0F, 0F);
            Binding binding_e_71_Command = new Binding("setSlotCommand");
            e_71.SetBinding(ImageButton.CommandProperty, binding_e_71_Command);
            Binding binding_e_71_CommandParameter = new Binding("setMisc");
            e_71.SetBinding(ImageButton.CommandParameterProperty, binding_e_71_CommandParameter);
            // e_72 element
            Grid e_72 = new Grid();
            e_71.Content = e_72;
            e_72.Name = "e_72";
            // e_73 element
            Image e_73 = new Image();
            e_72.Children.Add(e_73);
            e_73.Name = "e_73";
            e_73.Margin = new Thickness(0F, 0F, 0F, 0F);
            e_73.HorizontalAlignment = HorizontalAlignment.Stretch;
            e_73.VerticalAlignment = VerticalAlignment.Stretch;
            e_73.Stretch = Stretch.Fill;
            Binding binding_e_73_Source = new Binding("setMisc.image");
            e_73.SetBinding(Image.SourceProperty, binding_e_73_Source);
            // e_74 element
            TextBlock e_74 = new TextBlock();
            e_72.Children.Add(e_74);
            e_74.Name = "e_74";
            e_74.Margin = new Thickness(0F, 0F, 5F, 5F);
            e_74.HorizontalAlignment = HorizontalAlignment.Right;
            e_74.VerticalAlignment = VerticalAlignment.Bottom;
            e_74.TextAlignment = TextAlignment.Center;
            e_74.FontSize = 24F;
            e_74.FontStyle = FontStyle.Bold;
            Binding binding_e_74_Text = new Binding("setMisc.count");
            e_74.SetBinding(TextBlock.TextProperty, binding_e_74_Text);
            // e_75 element
            Grid e_75 = new Grid();
            e_7.Children.Add(e_75);
            e_75.Name = "e_75";
            Grid.SetColumn(e_75, 1);
            // e_76 element
            Border e_76 = new Border();
            e_75.Children.Add(e_76);
            e_76.Name = "e_76";
            e_76.Margin = new Thickness(0F, 0F, 0F, 0F);
            e_76.Background = new SolidColorBrush(new ColorW(33, 33, 33, 255));
            e_76.BorderBrush = new SolidColorBrush(new ColorW(69, 69, 69, 255));
            e_76.BorderThickness = new Thickness(3F, 3F, 3F, 3F);
            e_76.Padding = new Thickness(5F, 5F, 5F, 5F);
            // e_77 element
            Grid e_77 = new Grid();
            e_76.Child = e_77;
            e_77.Name = "e_77";
            RowDefinition row_e_77_0 = new RowDefinition();
            row_e_77_0.Height = new GridLength(1F, GridUnitType.Star);
            e_77.RowDefinitions.Add(row_e_77_0);
            RowDefinition row_e_77_1 = new RowDefinition();
            row_e_77_1.Height = new GridLength(50F, GridUnitType.Pixel);
            e_77.RowDefinitions.Add(row_e_77_1);
            // e_78 element
            Grid e_78 = new Grid();
            e_77.Children.Add(e_78);
            e_78.Name = "e_78";
            Grid.SetRow(e_78, 0);
            // e_79 element
            ScrollViewer e_79 = new ScrollViewer();
            e_78.Children.Add(e_79);
            e_79.Name = "e_79";
            // e_80 element
            ItemsControl e_80 = new ItemsControl();
            e_79.Content = e_80;
            e_80.Name = "e_80";
            Func<UIElement, UIElement> e_80_iptFunc = e_80_iptMethod;
            ControlTemplate e_80_ipt = new ControlTemplate(e_80_iptFunc);
            e_80.ItemsPanel = e_80_ipt;
            Func<UIElement, UIElement> e_80_dtFunc = e_80_dtMethod;
            e_80.ItemTemplate = new DataTemplate(e_80_dtFunc);
            DragDrop.SetIsDragSource(e_80, true);
            DragDrop.SetIsDropTarget(e_80, true);
            Binding binding_e_80_ItemsSource = new Binding("Items");
            e_80.SetBinding(ItemsControl.ItemsSourceProperty, binding_e_80_ItemsSource);
            // e_88 element
            Grid e_88 = new Grid();
            e_77.Children.Add(e_88);
            e_88.Name = "e_88";
            Grid.SetRow(e_88, 1);
            // e_89 element
            Border e_89 = new Border();
            e_88.Children.Add(e_89);
            e_89.Name = "e_89";
            e_89.Margin = new Thickness(5F, 5F, 5F, 5F);
            e_89.HorizontalAlignment = HorizontalAlignment.Stretch;
            e_89.VerticalAlignment = VerticalAlignment.Stretch;
            e_89.Background = new SolidColorBrush(new ColorW(69, 69, 69, 255));
            e_89.BorderBrush = new SolidColorBrush(new ColorW(69, 69, 69, 255));
            e_89.BorderThickness = new Thickness(1F, 1F, 1F, 1F);
            e_89.Padding = new Thickness(2F, 2F, 2F, 2F);
            // e_90 element
            Grid e_90 = new Grid();
            e_89.Child = e_90;
            e_90.Name = "e_90";
            ColumnDefinition col_e_90_0 = new ColumnDefinition();
            col_e_90_0.Width = new GridLength(1F, GridUnitType.Star);
            e_90.ColumnDefinitions.Add(col_e_90_0);
            ColumnDefinition col_e_90_1 = new ColumnDefinition();
            col_e_90_1.Width = new GridLength(1F, GridUnitType.Auto);
            e_90.ColumnDefinitions.Add(col_e_90_1);
            // e_91 element
            TextBlock e_91 = new TextBlock();
            e_90.Children.Add(e_91);
            e_91.Name = "e_91";
            e_91.Margin = new Thickness(5F, 0F, 5F, 0F);
            e_91.HorizontalAlignment = HorizontalAlignment.Stretch;
            e_91.VerticalAlignment = VerticalAlignment.Center;
            e_91.TextAlignment = TextAlignment.Left;
            e_91.FontSize = 24F;
            e_91.FontStyle = FontStyle.Bold;
            Grid.SetColumn(e_91, 0);
            Binding binding_e_91_Text = new Binding("ItemSelect.name");
            e_91.SetBinding(TextBlock.TextProperty, binding_e_91_Text);
            // e_92 element
            Button e_92 = new Button();
            e_90.Children.Add(e_92);
            e_92.Name = "e_92";
            e_92.MinWidth = 120F;
            e_92.Margin = new Thickness(5F, 0F, 5F, 0F);
            e_92.HorizontalAlignment = HorizontalAlignment.Stretch;
            e_92.VerticalAlignment = VerticalAlignment.Stretch;
            e_92.Background = new SolidColorBrush(new ColorW(0, 0, 0, 255));
            e_92.Foreground = new SolidColorBrush(new ColorW(255, 255, 255, 255));
            Grid.SetColumn(e_92, 1);
            Binding binding_e_92_Command = new Binding("Action_Command");
            e_92.SetBinding(Button.CommandProperty, binding_e_92_Command);
            Binding binding_e_92_Content = new Binding("Action_Title");
            e_92.SetBinding(Button.ContentProperty, binding_e_92_Content);
            return e_0;
        }
    }
}
