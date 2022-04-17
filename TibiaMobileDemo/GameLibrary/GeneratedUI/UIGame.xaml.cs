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
        
        private Grid e_5;
        
        private Grid e_6;
        
        private Grid e_7;
        
        private TabControl e_8;
        
        private Grid e_17;
        
        private TextBox e_18;
        
        private Grid e_19;
        
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
            this.e_5 = new Grid();
            this.e_4.Children.Add(this.e_5);
            this.e_5.Name = "e_5";
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
            Grid.SetColumn(this.e_19, 2);
            this.e_19.SetResourceReference(Grid.BackgroundProperty, "Background");
            FontManager.Instance.AddFont("Segoe UI", 12F, FontStyle.Bold, "Segoe_UI_9_Bold");
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
