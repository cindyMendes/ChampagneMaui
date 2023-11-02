using ChampagneMaui.Models.Champagne;
using ChampagneMaui.Models;
using ChampagneMaui.Models.Size;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChampagneMaui.Services
{
    internal interface ISizeService
    {
        Task<List<SizeResponseModel>> GetAllSizes();
        Task<SizeResponseModel> GetSizeById(int id);
        Task<List<ChampagneResponseModel>> GetChampagnesBySizeId(int sizeId);
        Task<MainResponseModel> AddSize(AddSizeRequestModel addSizeRequest);
        Task<MainResponseModel> UpdateSize(UpdateSizeRequestModel updateSizeRequest);
        Task<MainResponseModel> DeleteSize(DeleteSizeRequestModel deleteSizeRequest);
        Task<MainResponseModel> DeleteSizeWithPrices(int sizeId);
        Task<MainResponseModel> DeleteSizeIfNoPrices(int sizeId);
    }
}
