using ExamenHansOrtiz.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenHansOrtiz.Services;

namespace ExamenHansOrtiz.ViewModels
{
    public class HO_CallesViewModel
    {
        public ObservableCollection<HO_Calle> Calles { get; set; } = new();

        private readonly HO_APIService _apiService;

        public HO_CallesViewModel(HO_APIService apiService)
        {
            _apiService = apiService;
            LoadCallesAsync();
        }

        private async Task LoadCallesAsync()
        { 
            var calles = await _apiService.GetCallesAsync();
            foreach (var calle in calles)
            {
                Calles.Add(calle);
            }
        }
    }
}
