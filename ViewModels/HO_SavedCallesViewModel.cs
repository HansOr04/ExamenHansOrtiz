using ExamenHansOrtiz.Models;
using ExamenHansOrtiz.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenHansOrtiz.ViewModels
{
    public class HO_SavedCallesViewModel
    {
        public ObservableCollection<HO_CalleLocal> SavedCalles { get; set; } = new();

        private readonly HO_DatabaseService _databaseService;

        public HO_SavedCallesViewModel(HO_DatabaseService databaseService)
        {
            _databaseService = databaseService;
            LoadSavedCallesAsync();
        }

        private async Task LoadSavedCallesAsync()
        {
            var calles = await _databaseService.GetSavedCallesAsync();
            foreach (var calle in calles)
            {
                SavedCalles.Add(calle);
            }
        }
    }
}
