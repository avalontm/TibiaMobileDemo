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
        
        public UIGame() {
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
            RowDefinition row_e_0_0 = new RowDefinition();
            row_e_0_0.Height = new GridLength(50F, GridUnitType.Pixel);
            this.e_0.RowDefinitions.Add(row_e_0_0);
            RowDefinition row_e_0_1 = new RowDefinition();
            row_e_0_1.Height = new GridLength(1F, GridUnitType.Star);
            this.e_0.RowDefinitions.Add(row_e_0_1);
            // e_1 element
            this.e_1 = new Grid();
            this.e_0.Children.Add(this.e_1);
            this.e_1.Name = "e_1";
            this.e_1.Background = new SolidColorBrush(new ColorW(128, 128, 128, 255));
            Grid.SetRow(this.e_1, 0);
            // e_2 element
            this.e_2 = new Grid();
            this.e_0.Children.Add(this.e_2);
            this.e_2.Name = "e_2";
            ColumnDefinition col_e_2_0 = new ColumnDefinition();
            col_e_2_0.Width = new GridLength(80F, GridUnitType.Pixel);
            this.e_2.ColumnDefinitions.Add(col_e_2_0);
            ColumnDefinition col_e_2_1 = new ColumnDefinition();
            col_e_2_1.Width = new GridLength(1F, GridUnitType.Star);
            this.e_2.ColumnDefinitions.Add(col_e_2_1);
            ColumnDefinition col_e_2_2 = new ColumnDefinition();
            col_e_2_2.Width = new GridLength(120F, GridUnitType.Pixel);
            this.e_2.ColumnDefinitions.Add(col_e_2_2);
            Grid.SetRow(this.e_2, 1);
            // e_3 element
            this.e_3 = new Grid();
            this.e_2.Children.Add(this.e_3);
            this.e_3.Name = "e_3";
            this.e_3.Background = new SolidColorBrush(new ColorW(128, 128, 128, 255));
            Grid.SetColumn(this.e_3, 0);
            // e_4 element
            this.e_4 = new Grid();
            this.e_2.Children.Add(this.e_4);
            this.e_4.Name = "e_4";
            RowDefinition row_e_4_0 = new RowDefinition();
            row_e_4_0.Height = new GridLength(1F, GridUnitType.Star);
            this.e_4.RowDefinitions.Add(row_e_4_0);
            RowDefinition row_e_4_1 = new RowDefinition();
            row_e_4_1.Height = new GridLength(80F, GridUnitType.Pixel);
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
            this.e_6.Background = new SolidColorBrush(new ColorW(128, 128, 128, 255));
            Grid.SetRow(this.e_6, 1);
            // e_7 element
            this.e_7 = new Grid();
            this.e_2.Children.Add(this.e_7);
            this.e_7.Name = "e_7";
            this.e_7.Background = new SolidColorBrush(new ColorW(128, 128, 128, 255));
            Grid.SetColumn(this.e_7, 2);
        }
    }
}
