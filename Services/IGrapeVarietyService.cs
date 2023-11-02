using ChampagneMaui.Models.Champagne;
using ChampagneMaui.Models;
using ChampagneMaui.Models.GrapeVariety;
using ChampagneMaui.Models.Size;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChampagneMaui.Services
{
    internal interface IGrapeVarietyService
    {
        Task<List<GrapeVarietyResponseModel>> GetAllGrapeVarieties();
        Task<GrapeVarietyResponseModel> GetGrapeVarietyById(int id);
        Task<MainResponseModel> AddGrapeVariety(AddGrapeVarietyRequestModel addGrapeVarietyRequest);
        Task<MainResponseModel> UpdateGrapeVariety(UpdateGrapeVarietyRequestModel updateGrapeVarietyRequest);
        Task<MainResponseModel> DeleteGrapeVariety(int id);
    }
}
