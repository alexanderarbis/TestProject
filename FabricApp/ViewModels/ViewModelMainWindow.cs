using FabricApp.Models;
using FabricApp.Views.Pages;
using MvvmCross.ViewModels;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace FabricApp.ViewModels
{
    public class ViewModelMainWindow : MvxViewModel
    {
        #region ViewModelMainWindowLink
        public static ViewModelMainWindow viewModelMainWindow;
        public ViewModelMainWindow()
        {
            viewModelMainWindow = this;
        }
        #endregion

        #region Pages
        private static ObservableCollection<Page> _Pages = new ObservableCollection<Page>()
        {
            new AuthorisationPage(),
            new CustomerPage(),
            new ManagerPage(),
            new Workspace(),
            new DirectorPage()
        };
        public ObservableCollection<Page> Pages
        {
            get => _Pages;
            set => SetProperty(ref _Pages, value);
        }
        #endregion

        #region CurrentPage
        private Page _Page = _Pages[0];
        public Page Page
        {
            get => _Page;
            set => SetProperty(ref _Page, value);
        }
        #endregion

        #region Role
        private int _Role = 0;
        public int Role
        {
            get => _Role;
            set
            {
                SetProperty(ref _Role, value);
                Page = Pages[Role];
            }
        }
        #endregion

        #region User
        private User _User;
        public User User
        {
            get => _User;
            set
            {
                SetProperty(ref _User, value);
                Role = (int)User.RoleId;
            }
        }
        #endregion

        //User change => Role change => Page change
    }
}
