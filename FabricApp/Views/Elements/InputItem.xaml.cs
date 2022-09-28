using System.Windows;
using System.Windows.Controls;

namespace FabricApp.Views.Elements
{
    /// <summary>
    /// Логика взаимодействия для InputItem.xaml
    /// </summary>
    public partial class InputItem : UserControl
    {
        #region Title
        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Title.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(InputItem), new PropertyMetadata(string.Empty));
        #endregion

        #region Count
        public int Count
        {
            get { return (int)GetValue(CountProperty); }
            set { SetValue(CountProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Count.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CountProperty =
            DependencyProperty.Register("Count", typeof(int), typeof(InputItem), new PropertyMetadata(0));
        #endregion

        #region Price
        public int Price
        {
            get { return (int)GetValue(PriceProperty); }
            set { SetValue(PriceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Price.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PriceProperty =
            DependencyProperty.Register("Price", typeof(int), typeof(InputItem), new PropertyMetadata(0)); 
        #endregion

        public InputItem()
        {
            InitializeComponent();
        }
    }
}
