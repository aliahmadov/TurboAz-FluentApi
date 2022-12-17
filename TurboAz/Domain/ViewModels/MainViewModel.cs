using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using TurboAz.Commands;
using TurboAz.Domain.Entities;
using TurboAz.Domain.Views;

namespace TurboAz.Domain.ViewModels
{
    public class MainViewModel : BaseViewModel
    {

        private ObservableCollection<string> energyTypes;

        public ObservableCollection<string> EnergyTypes
        {
            get { return energyTypes; }
            set { energyTypes = value; OnPropertyChanged(); }
        }


        private ObservableCollection<string> banTypes;

        public ObservableCollection<string> BanTypes
        {
            get { return banTypes; }
            set { banTypes = value; OnPropertyChanged(); }
        }

        private ObservableCollection<string> models;

        public ObservableCollection<string> Models
        {
            get { return models; }
            set { models = value; OnPropertyChanged(); }
        }

        private ObservableCollection<string> colors;

        public ObservableCollection<string> Colors
        {
            get { return colors; }
            set { colors = value; OnPropertyChanged(); }
        }



        private double minPrice;

        public double MinPrice
        {
            get { return minPrice; }
            set { minPrice = value; OnPropertyChanged(); }
        }

        private double maxPrice;

        public double MaxPrice
        {
            get { return maxPrice; }
            set { maxPrice = value; OnPropertyChanged(); }
        }


        private int maxDistance;

        public int MaxDistance
        {
            get { return maxDistance; }
            set { maxDistance = value; OnPropertyChanged(); }
        }


        private int minDistance;

        public int MinDistance
        {
            get { return minDistance; }
            set { minDistance = value; OnPropertyChanged(); }
        }


        private int minYear;

        public int MinYear
        {
            get { return minYear; }
            set { minYear = value; OnPropertyChanged(); }
        }

        private int maxYear;

        public int MaxYear
        {
            get { return maxYear; }
            set { maxYear = value; OnPropertyChanged(); }
        }


        private bool isOld;

        public bool IsOld
        {
            get { return isOld; }
            set { isOld = value; OnPropertyChanged(); }
        }

        private bool isNew;

        public bool IsNew
        {
            get { return isNew; }
            set { isNew = value; OnPropertyChanged(); }
        }


        public RelayCommand NewCommand { get; set; }

        public RelayCommand OldCommand { get; set; }

        public RelayCommand ShowCommand { get; set; }

        public RelayCommand SelectedColorCommand { get; set; }
        public RelayCommand SelectedBanCommand { get; set; }
        public RelayCommand SelectedModelCommand { get; set; }
        public RelayCommand SelectedEnergyTypeCommand { get; set; }

        public RelayCommand ClearCommand { get; set; }


        private string selectedColor;

        public string SelectedColor
        {
            get { return selectedColor; }
            set { selectedColor = value; OnPropertyChanged(); }
        }

        private string selectedBan;

        public string SelectedBan
        {
            get { return selectedBan; }
            set { selectedBan = value; OnPropertyChanged(); }
        }

        private string selectedModel;

        public string SelectedModel
        {
            get { return selectedModel; }
            set { selectedModel = value; OnPropertyChanged(); }
        }

        private string selectedEnergyType;

        public string SelectedEnergyType
        {
            get { return selectedEnergyType; }
            set { selectedEnergyType = value; OnPropertyChanged(); }
        }


        public WrapPanel WrapPanel { get; set; }
        public MainViewModel()
        {
            EnergyTypes = new ObservableCollection<string>(App.DB.EnergyTypeRepository.GetAll().Select(c => c.TypeName));
            Colors = new ObservableCollection<string>(App.DB.ColorRepository.GetAll().Select(c => c.ColorName));
            BanTypes = new ObservableCollection<string>(App.DB.BanTypeRepository.GetAll().Select(c => c.TypeName));
            Models = new ObservableCollection<string>(App.DB.ManufacturerRepository.GetAll().Select(c => c.Name));



            //NewCommand = new RelayCommand(c =>
            //{
            //    IsOld = false;

            //});

            //OldCommand = new RelayCommand(c =>
            //{
            //    IsOld = true;
            //});

            ShowCommand = new RelayCommand(c =>
            {
                WrapPanel.Children.Clear();
                IEnumerable<Car> cars = App.DB.CarRepository.GetAll();

                if (SelectedColor != null) cars = cars.Where(d => d.Color.ColorName == SelectedColor);

                if (SelectedModel != null) cars = cars.Where(d => d.Manufacturer.Name == SelectedModel);

                if (SelectedEnergyType != null) cars = cars.Where(d => d.EnergyType.TypeName == SelectedEnergyType);

                if (SelectedBan != null) cars = cars.Where(d => d.BanType.TypeName == SelectedBan);

                if (MinDistance >= 0 && MaxDistance != 0) cars.Where(d => d.UsageDistance >= MinDistance && d.UsageDistance <= MaxDistance);
                if (MinYear >= 0 && MaxYear != 0) cars.Where(d => d.ProductionYear >= MinYear && d.ProductionYear <= MaxYear);
                if (MinPrice >= 0 && MaxPrice != 0) cars.Where(d => d.Price >= MinPrice && d.Price <= MaxPrice);

                if (isNew != false) cars.Where(d => d.IsOld == isNew);
                if (isOld != false) cars.Where(d => d.IsOld == IsOld);

                var filteredCars = cars.ToList();

                //var cars = App.DB.CarRepository
                //.GetAll()
                //.Where(d => d.Manufacturer.Name == SelectedModel)
                //.Where(d => d.BanType.TypeName == SelectedBan)
                //.Where(d => d.EnergyType.TypeName == SelectedEnergyType)
                //.Where(d => d.Color.ColorName == SelectedColor)
                ////.Where(d => d.ProductionYear >= MinYear && d.ProductionYear <= MaxYear)
                ////.Where(d => d.Price >= MinPrice && d.Price <= MaxPrice)
                ////.Where(d => d.UsageDistance >= MinDistance && d.UsageDistance <= MaxDistance)
                ////.Where(d => d.IsOld = d.IsOld == true ? IsOld : IsNew)
                //.ToList();

                for (int i = 0; i < filteredCars.Count; i++)
                {
                    var uc = new CarDisplayUC();
                    var viewModel = new CarDisplayUCViewModel();
                    uc.DataContext = viewModel;

                    viewModel.ImagePath = filteredCars[i].ImagePath;
                    uc.Margin = new System.Windows.Thickness(10, 40, 10, 10);
                    uc.Height = 300;
                    uc.Width = 250;
                    WrapPanel.Children.Add(uc);
                }

            });





            ClearCommand = new RelayCommand(c =>
            {
                SelectedBan = null;
                SelectedModel = null;
                SelectedEnergyType = null;
                SelectedColor = null;
                MinYear = 0;
                MaxYear = 0;
                MinDistance = 0;
                MaxDistance = 0;
                MinPrice = 0;
                MaxPrice = 0;
                IsNew = false;
                IsOld = false;
                WrapPanel.Children.Clear();

            });

        }



    }
}
