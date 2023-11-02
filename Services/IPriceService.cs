using ChampagneMaui.Models.Price;
using ChampagneMaui.Models.Champagne;
using ChampagneMaui.Models.Size;
using ChampagneMaui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChampagneMaui.Services
{
    internal interface IPriceService
    {
        Task<List<PriceResponseModel>> GetAllPrices();
        Task<PriceResponseModel> GetPriceById(int id);
        Task<ChampagneResponseModel> GetChampagneInfoByPriceId(int id);
        Task<SizeResponseModel> GetSizeInfoByPriceId(int id);
        Task<MainResponseModel> AddPrice(AddPriceRequestModel addPriceRequest);
        Task<MainResponseModel> UpdatePrice(UpdatePriceRequestModel updatePriceRequest);
        Task<MainResponseModel> DeletePrice(int id);
    }
}
