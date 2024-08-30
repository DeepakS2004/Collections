using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Collection
{
    /// <summary>
    /// Interaction logic for Details.xaml
    /// </summary>
    public partial class Details : Window
    {
        public Details(ArrayList value)
        {
            InitializeComponent();
            cmbname.ItemsSource = value;
            
        }
        public Details(Hashtable value)
        {
            InitializeComponent();
           
            StringBuilder sb = new StringBuilder();
            foreach(DictionaryEntry item in value)
            {
                sb.AppendFormat("Key {0} value {1} \n",item.Key,item.Value );
            }
            MessageBox.Show( sb.ToString() );

        }
    }
}
