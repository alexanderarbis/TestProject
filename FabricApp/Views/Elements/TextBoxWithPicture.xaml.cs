using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace FabricApp.Views.Elements
{
    /// <summary>
    /// Логика взаимодействия для TextBoxWithPicture.xaml
    /// </summary>
    public partial class TextBoxWithPicture : UserControl
    {
        #region Image
        public ImageSource Image
        {
            get { return (ImageSource)GetValue(ImageProperty); }
            set { SetValue(ImageProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Image.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ImageProperty =
            DependencyProperty.Register("Image", typeof(ImageSource), typeof(TextBoxWithPicture), new PropertyMetadata());
        #endregion

        #region Text
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Text.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(TextBoxWithPicture), new PropertyMetadata(string.Empty));
        #endregion


        public TextBoxWithPicture()
        {
            InitializeComponent();
        }
    }
}
