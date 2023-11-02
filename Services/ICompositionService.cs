using ChampagneMaui.Models.Champagne;
using ChampagneMaui.Models.Composition;
using ChampagneMaui.Models.GrapeVariety;
using ChampagneMaui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChampagneMaui.Services
{
    internal interface ICompositionService
    {
        Task<List<CompositionResponseModel>> GetAllCompositions();
        Task<CompositionResponseModel> GetCompositionById(int id);
        Task<ChampagneResponseModel> GetChampagneInfoByCompositionId(int id);
        Task<GrapeVarietyResponseModel> GetGrapeVarietyInfoByCompositionId(int id);
        Task<MainResponseModel> AddComposition(AddCompositionRequestModel addCompositionRequest);
        Task<MainResponseModel> UpdateComposition(UpdateCompositionRequestModel updateCompositionRequest);
        Task<MainResponseModel> DeleteComposition(int id);
    }
}
