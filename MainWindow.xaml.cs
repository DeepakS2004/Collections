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
using System.Collections;
using System.Diagnostics;
using System.Collections.Generic;

namespace Collection
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList oarray;
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnarray_Click(object sender, RoutedEventArgs e)
        {
           
           // int[] v = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,28,19,20};
           // int[] t = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 28, 19, 20 };
           // int[] d = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 28, 19, 20 };
           // string[] s = {"q","w","e","r","t","y","u","i","o","p","a","as","d","f","g","h","j","k","l","s"};
           // string[] y = { "q", "w", "e", "r", "t", "y", "u", "i", "o", "p", "a", "as", "d", "f", "g", "h", "j", "k", "l", "s" };
           // string[] sa = { "q", "w", "e", "r", "t", "y", "u", "i", "o", "p", "a", "as", "d", "f", "g", "h", "j", "k", "l", "s" };
           // int[] ds = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 28, 19, 20 };
           // string[] sd = { "q", "w", "e", "r", "t", "y", "u", "i", "o", "p", "a", "as", "d", "f", "g", "h", "j", "k", "l", "s" };
           // int[] da = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 28, 19, 20 };
           // string[] ss = { "q", "w", "e", "r", "t", "y", "u", "i", "o", "p", "a", "as", "d", "f", "g", "h", "j", "k", "l", "s" };
           // ArrayList arraylist = new ArrayList();
           // arraylist.Add("ram");
           // arraylist.Add(123);
           // arraylist.Add(false);
           // arraylist.Add("arun");
           // arraylist.Add(154);
           // arraylist.Add(true);
           // arraylist.Add(78);
           // arraylist.AddRange(v);
           // arraylist.AddRange(s);
           // arraylist.AddRange(y);
           // arraylist.AddRange(t);
           // arraylist.AddRange(sa);
           // arraylist.AddRange(d);
           // arraylist.AddRange(ds);
           // arraylist.AddRange(sd);
           // arraylist.AddRange(ss);
           // arraylist.AddRange(da);
           // //MessageBox.Show("Before Trim :" + arraylist.Capacity.ToString());
           // arraylist.TrimToSize();
           // //MessageBox.Show("After Trim :" + arraylist.Capacity.ToString());
           // //Stopwatch stopwatch = new Stopwatch();
           // //stopwatch.Start();
           // //for (int i = 1; i < arraylist.Count; i++)
           // //{
           // //    arraylist[i].ToString();
           // //}
           // //stopwatch.Stop();
           // //MessageBox.Show("Millisecond :"+stopwatch.ElapsedMilliseconds.ToString());
           // MessageBox.Show("Before Insert :" + arraylist[1].ToString());
           // arraylist.Insert(1, "deepak");
           //MessageBox.Show( "after Insert :" +arraylist[1].ToString());
           // MessageBox.Show("after InsertRange :" + arraylist[3].ToString());
           // arraylist.InsertRange(3, sa);
           // MessageBox.Show("after Insertrange :" + arraylist[3].ToString());
           // arraylist.Remove("arun");
           // arraylist.RemoveAt(3);
           // arraylist.RemoveRange(0, 3);
           // arraylist.Reverse();

        }

        private void btntocmb_Click(object sender, RoutedEventArgs e)
        {
            //if(oarray==null)
            //{
            //    oarray = new ArrayList();
            //}
            //oarray.Add(txtname.Text);
            //MessageBox.Show("value inserted");
            //txtname.Clear();
            //if(oarray.Count > 3)
            //{ 
            //Details details = new Details(oarray);
            //details.Show();
            //}
        }

        private void btnhashtable_Click(object sender, RoutedEventArgs e)
        {
            Hashtable ht = new Hashtable();
            ht.Add("Name", txtname);
            ht.Add("Age", txtage);
            ht.Add("Email",txtemail);
            ht.Add("Mark",txtmark);
            //foreach(DictionaryEntry item in ht)
            //{
            //    MessageBox.Show(item.Key.ToString() +":"+ item.Value.ToString());
            //}
            //if(ht.ContainsKey("Mark"))
            //{
            //    MessageBox.Show("Individual value :"+ht["Mark"].ToString());
            //}
            //ht.Remove("Location");
            //foreach (DictionaryEntry item in ht)
            //{
            //    MessageBox.Show("After Remove :"+item.Key.ToString() + ":" + item.Value.ToString());
            //}
            Details details = new Details(ht);
            details.Show();
        }

        private void btnstack_Click(object sender, RoutedEventArgs e)
        {
            Stack stack = new Stack();
            stack.Push("Deepak");
            stack.Push("20");
            stack.Push("DK");
            stack.Push("90");           
            string remove = stack.Pop().ToString();
            MessageBox.Show("Remove value :" + remove);
            //string value = stack.Peek().ToString();
            //MessageBox.Show(value);
            foreach (string item  in stack)
            {
                MessageBox.Show(item.ToString());
            }
        }
        private void btnqueue_Click(object sender, RoutedEventArgs e)
        {
            Queue queue = new Queue();
            queue.Enqueue("Deepak");
            queue.Enqueue("20");
            queue.Enqueue("DK");
            queue.Enqueue("90"); 
           string remove = queue.Dequeue().ToString();
            MessageBox.Show("Remove value :"+ remove);
            //string value = queue.Peek().ToString();
            //MessageBox.Show(value);
            foreach (string item in queue)
            {
                MessageBox.Show(item.ToString());
            }
        }
    }
}