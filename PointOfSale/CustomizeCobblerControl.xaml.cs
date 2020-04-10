using ExamTwoCodeQuestions.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ExamTwoQuestions.PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCobblerControl.xaml
    /// </summary>
    public partial class CustomizeCobblerControl : UserControl
    {
        public CustomizeCobblerControl()
        {
            InitializeComponent();
            PeachButton.Click += OnPeachButtonClicked;
            CherryButton.Click += OnCherryButtonClicked;
            BlueberryButton.Click += OnBlueberryButtonClicked;
        }

        //Event handlers to set fruit filling flavor
        public void OnPeachButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Cobbler c)
            {
                c.Fruit = FruitFilling.Peach;
            }
        }

        public void OnCherryButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Cobbler c)
            {
                c.Fruit = FruitFilling.Cherry;
            }
        }

        public void OnBlueberryButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Cobbler c)
            {
                c.Fruit = FruitFilling.Blueberry;
            }
        }
    }
}
