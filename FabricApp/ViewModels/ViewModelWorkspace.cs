using FabricApp.Data;
using FabricApp.Models;
using FabricApp.Views.Elements;
using FabricApp.Views.Pages;
using Microsoft.EntityFrameworkCore;
using MvvmCross.Commands;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace FabricApp.ViewModels
{
    internal class ViewModelWorkspace : MvxViewModel
    {
        #region FabricContext
        private readonly FabricContext fabricContext;
        public ViewModelWorkspace()
        {
            fabricContext = new FabricContext();
        }
        #endregion

        #region Title
        private string _Title;
        public string Title
        {
            get => _Title;
            set => SetProperty(ref _Title, value);
        }
        #endregion

        #region Amount
        private string _Amount;
        public string Amount
        {
            get => _Amount;
            set => SetProperty(ref _Amount, value);
        }
        #endregion

        #region Price
        private string _Price;
        public string Price
        {
            get => _Price;
            set => SetProperty(ref _Price, value);
        }
        #endregion

        #region Element
        private ObservableCollection<InputItem> _Elements;
        public ObservableCollection<InputItem> Elements
        {
            get => _Elements;
            set => SetProperty(ref _Elements, value);
        }
        #endregion

        #region Commands
        public ICommand commandShowCloths => new MvxCommand(ShowCloths);
        public void ShowCloths()
        {
            ObservableCollection<InputItem> inputItems = new ObservableCollection<InputItem>();

            foreach (Furniture furniture in fabricContext.Furnitures)
            {
                inputItems.Add(new InputItem
                {
                    Title = furniture.Name,
                    Count = 0,
                    Price = (int)furniture.Price,
                    Width = 800
                });
            }

            Elements = inputItems;
        }

        public ICommand commandShowFurniture => new MvxCommand(ShowFurniture);
        public void ShowFurniture()
        {
            ObservableCollection<InputItem> inputItems = new ObservableCollection<InputItem>();

            foreach (Cloth cloth in fabricContext.Cloths)
            {
                inputItems.Add(new InputItem
                {
                    Title = cloth.Name,
                    Count = 0,
                    Price = (int)cloth.Price,
                    Width = 800
                });
            }
 
            Elements = inputItems;
        } 
        #endregion
    }
}
