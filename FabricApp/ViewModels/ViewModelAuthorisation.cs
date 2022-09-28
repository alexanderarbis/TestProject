using FabricApp.Data;
using MvvmCross.Commands;
using MvvmCross.ViewModels;
using System.Windows;
using System.Windows.Input;

namespace FabricApp.ViewModels
{
    public class ViewModelAuthorisation : MvxViewModel
    {
        #region FabricContext
        private readonly FabricContext fabricContext;
        public ViewModelAuthorisation()
        {
            fabricContext = new FabricContext();
        } 
        #endregion

        #region LoginInput
        private string _Login;
        public string Login
        {
            get => _Login;
            set => SetProperty(ref _Login, value);
        }
        #endregion

        #region PasswordInput
        private string _Password;
        public string Password
        {
            get => _Password;
            set => SetProperty(ref _Password, value);
        }
        #endregion

        #region AuthorisationCommand
        public ICommand AuthorisationCommand => new MvxCommand(TryLogin);

        public void TryLogin()
        {
            foreach(var user in fabricContext.Users)
            {
                if(Login == user.Login && Password == user.Password)
                {
                    ViewModelMainWindow.viewModelMainWindow.User = user;
                    return;
                }  
            }
            MessageBox.Show(
                        "Неверный логин и/или пароль!",
                        "Ошибка!",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error);
        }
        #endregion

        #region RegistrationCommand
        public ICommand RegistrationCommand => new MvxCommand(TryReg);

        public void TryReg()
        {
            foreach (var user in fabricContext.Users)
            {
                if (Login == user.Login)
                {
                    MessageBox.Show(
                        "Пользователь с таким именем уже зарегистрирован!",
                        "Ошибка!",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error);
                    return;
                }
            }

            fabricContext.Users.Add(new Models.User
            {
                Login = Login,
                Password = Password,
                RoleId = 1
            });
            fabricContext.SaveChanges();

            MessageBox.Show(
                        "Пользователь зарегистрирован!",
                        "Успешно!",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
        } 
        #endregion
    }
}
