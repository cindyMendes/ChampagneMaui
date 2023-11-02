using ChampagneMaui.Models;
using ChampagneMaui.Models.Champagne;
using ChampagneMaui.Models.Size;
using ChampagneMaui.Models.GrapeVariety;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChampagneMaui.Services
{
    internal interface IChampagneService
    {
        Task<List<ChampagneResponseModel>> GetAllChampagnes();
        Task<ChampagneResponseModel> GetChampagneById(int id);
        Task<ChampagneResponseModel> GetChampagneByName(string name);
        Task<List<SizeResponseModel>> GetSizesByChampagneId(int champagneId);
        Task<List<GrapeVarietyResponseModel>> GetGrapeVarietiesByChampagneId(int champagneId);
        Task<List<ChampagneResponseModel>> GetChampagnesByAlcoholLevel(float threshold, string sign);
        Task<MainResponseModel> AddChampagne(AddChampagneRequestModel addChampagneRequest);
        Task<MainResponseModel> UpdateChampagne(UpdateChampagneRequestModel updateChampagneRequest);
        Task<MainResponseModel> DeleteChampagne(DeleteChampagneRequestModel deleteChampagneRequest);
        Task<MainResponseModel> DeleteChampagneWithPricesAndCompositions(int champagneId);
        Task<MainResponseModel> DeleteChampagneIfNoPricesAndCompositions(int champagneId);
        
    }
}
