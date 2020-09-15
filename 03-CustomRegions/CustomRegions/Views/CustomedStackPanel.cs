using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CustomRegions.Views
{
   public class CustomedStackPanel : System.Windows.Controls.StackPanel
   {
      Button buttonAdd = new Button();
      Button buttonSub = new Button();

      public CustomedStackPanel()
      {
         buttonAdd.Content = "ADD";
         buttonAdd.FontSize = 20;
         buttonAdd.Margin = new System.Windows.Thickness(5);
         buttonAdd.Padding = new System.Windows.Thickness(5);
         buttonAdd.Click += ButtonAdd_Click;

         buttonSub.Content = "SUB";
         buttonSub.FontSize = 20;
         buttonSub.Margin = new System.Windows.Thickness(5);
         buttonSub.Padding = new System.Windows.Thickness(5);
         buttonSub.Click += ButtonSub_Click;


         this.Children.Add(buttonAdd);
         this.Children.Add(buttonSub);
      }

      private void ButtonSub_Click(object sender, System.Windows.RoutedEventArgs e)
      {
         if (this.Children[this.Children.Count - 1] is TextBlock)
            this.Children.RemoveAt(this.Children.Count - 1);
      }

      private void ButtonAdd_Click(object sender, System.Windows.RoutedEventArgs e)
      {
         TextBlock textBlock = new TextBlock();
         textBlock.Text = "TextBlock";
         textBlock.HorizontalAlignment = System.Windows.HorizontalAlignment.Center;
         textBlock.VerticalAlignment = System.Windows.VerticalAlignment.Center;
         textBlock.FontSize = 20;
         textBlock.Margin = new System.Windows.Thickness(5);
         textBlock.Padding = new System.Windows.Thickness(5);

         this.Children.Add(textBlock);
      }
   }
}
