﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace GetListBoxItem.Desktop
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            GreekGod greekGod = (GreekGod)(listBox.Items[0]);
            ListBoxItem lbi1 = (ListBoxItem)(listBox.ItemContainerGenerator.ContainerFromIndex(0));
            ListBoxItem lbi2 = (ListBoxItem)(listBox.ItemContainerGenerator.ContainerFromItem(listBox.SelectedItem));
        }
    }
}
