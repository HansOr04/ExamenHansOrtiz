using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenHansOrtiz.Models;
using SQLite;

namespace ExamenHansOrtiz.Services
{
    public class HO_DatabaseService
    {
        private readonly SQLiteAsyncConnection _database;
        public HO_DatabaseService()
        {
            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "HO_calles.db");
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<HO_CalleLocal>().Wait();
        }
        public async Task SaveCalleAsync(HO_CalleLocal calle)
        {
            try
            {
                await _database.InsertAsync(calle);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al guardar la calle{ex.Message}");
            }
        }
        public async Task<List<HO_CalleLocal>> GetSavedCalleAsync()
        {
            try
            {
                return await _database.Table<HO_CalleLocal>().ToListAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener las calles guardadas {ex.Message}");
                return new List<HO_CalleLocal>();
            }
        }
        public async Task DeleteCalleAsync(int localId)
        {
            try
            {
                var calle = await _database.Table<HO_CalleLocal>()
                                           .Where(c => c.LocalId == localId)
                                           .FirstOrDefaultAsync();
                if (calle != null)
                {
                    await _database.DeleteAsync(calle);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar la calle: {ex.Message}");
            }
        }

    }
}
