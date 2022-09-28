using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace FabricApp.Views.Elements
{
    /// <summary>
    /// Логика взаимодействия для InputForm.xaml
    /// </summary>
    public partial class InputForm : UserControl
    {
        #region Input
        public ObservableCollection<InputItem> Input
        {
            get { return (ObservableCollection<InputItem>)GetValue(InputProperty); }
            set { SetValue(InputProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Input.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty InputProperty =
            DependencyProperty.Register("Input", typeof(ObservableCollection<InputItem>), typeof(InputForm), new PropertyMetadata());
        #endregion

        #region Title
        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Title.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(InputForm), new PropertyMetadata(string.Empty));
        #endregion

        #region Count
        public string Count
        {
            get { return (string)GetValue(CountProperty); }
            set { SetValue(CountProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Count.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CountProperty =
            DependencyProperty.Register("Count", typeof(string), typeof(InputForm), new PropertyMetadata(string.Empty));
        #endregion

        #region AddCommand
        public ICommand AddCommand
        {
            get { return (ICommand)GetValue(AddCommandProperty); }
            set { SetValue(AddCommandProperty, value); }
        }

        // Using a DependencyProperty as the backing store for AddCommand.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AddCommandProperty =
            DependencyProperty.Register("AddCommand", typeof(ICommand), typeof(InputForm), new PropertyMetadata());
        #endregion

        #region SendCommand
        public ICommand SendCommand
        {
            get { return (ICommand)GetValue(SendCommandProperty); }
            set { SetValue(SendCommandProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SendCommand.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SendCommandProperty =
            DependencyProperty.Register("SendCommand", typeof(ICommand), typeof(InputForm), new PropertyMetadata());
        #endregion

        #region Template
        public DataTemplate Template
        {
            get { return (DataTemplate)GetValue(TemplateProperty); }
            set { SetValue(TemplateProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Template.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TemplateProperty =
            DependencyProperty.Register("Template", typeof(DataTemplate), typeof(InputForm), new PropertyMetadata());
        #endregion

        #region ItemTitle
        public string ItemTitle
        {
            get { return (string)GetValue(ItemTitleProperty); }
            set { SetValue(ItemTitleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ItemTitle.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ItemTitleProperty =
            DependencyProperty.Register("ItemTitle", typeof(string), typeof(InputForm), new PropertyMetadata(string.Empty));
        #endregion

        #region ItemAmount
        public int ItemAmount
        {
            get { return (int)GetValue(ItemAmountProperty); }
            set { SetValue(ItemAmountProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ItemAmount.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ItemAmountProperty =
            DependencyProperty.Register("ItemAmount", typeof(int), typeof(InputForm), new PropertyMetadata(0));
        #endregion

        #region ItemPrice
        public int ItemPrice
        {
            get { return (int)GetValue(ItemPriceProperty); }
            set { SetValue(ItemPriceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ItemPrice.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ItemPriceProperty =
            DependencyProperty.Register("ItemPrice", typeof(int), typeof(InputForm), new PropertyMetadata(0)); 
        #endregion

        public InputForm()
        {
            InitializeComponent();
        }
    }
}
