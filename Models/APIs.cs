using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiBlazorAppTest.Models
{
    internal class APIs
    {
        //public const string Login = "api/AppAuthentication/AuthLogin"; //when using tokens
        
        //User
        public const string Login = "api/ApplicationUser/Login";
        public const string SignUp = "api/ApplicationUser/SignUp";
        public const string GetUserByEmail = "api/ApplicationUser/GetUserByEmail";

        //Champagne
        public const string GetAllChampagnes = "api/Champagne/GetAllChampagnes"; 
        public const string GetChampagneById = "api/Champagne/GetChampagneById";
        public const string GetChampagneByName = "api/Champagne/GetChampagneByName";
        public const string GetSizesByChampagneId = "api/Champagne/GetSizesByChampagneId";
        public const string GetGrapeVarietiesByChampagneId = "api/Champagne/GetGrapeVarietiesByChampagneId";
        public const string GetChampagnesByAlcoholLevel = "api/Champagne/GetChampagnesByAlcoholLevel";
        public const string AddChampagne = "api/Champagne/AddChampagne";
        public const string UpdateChampagne = "api/Champagne/UpdateChampagne";
        public const string DeleteChampagne = "api/Champagne/DeleteChampagne";
        public const string DeleteChampagneWithPricesAndCompositions = "api/Champagne/DeleteChampagneWithPricesAndCompositions";
        public const string DeleteChampagneIfNoPricesAndCompositions = "api/Champagne/DeleteChampagneIfNoPricesAndCompositions";

        //GrapeVariety
        public const string GetAllGrapeVarieties = "api/GrapeVariety/GetAllGrapeVarieties";
        public const string GetGrapeVarietyById = "api/GrapeVariety/GetGrapeVarietyById";
        public const string AddGrapeVariety = "api/GrapeVariety/AddGrapeVariety";
        public const string UpdateGrapeVariety = "api/GrapeVariety/UpdateGrapeVariety";
        public const string DeleteGrapeVariety = "api/GrapeVariety/DeleteGrapeVariety";

        //Size
        public const string GetAllSizes = "api/Size/GetAllSizes";
        public const string GetSizeById = "api/Size/GetSizeById";
        public const string GetChampagnesBySizeId = "api/Size/GetAllChampagnesBySizeId";
        public const string AddSize = "api/Size/AddSize";
        public const string UpdateSize = "api/Size/UpdateSize";
        public const string DeleteSize = "api/Size/DeleteSize";
        public const string DeleteSizeWithPrices = "api/Size/DeleteSizeWithPrices";
        public const string DeleteSizeIfNoPrices = "api/Size/DeleteSizeIfNoPrices";

        //Price
        public const string GetAllPrices = "api/Price/GetAllPrices";
        public const string GetPriceById = "api/Price/GetPriceById";
        public const string GetChampagneInfoByPriceId = "api/Price/GetChampagneInfoByPriceId";
        public const string GetSizeInfoByPriceId = "api/Price/GetSizeInfoByPriceId";
        public const string AddPrice = "api/Price/AddPrice";
        public const string UpdatePrice = "api/Price/UpdatePrice";
        public const string DeletePrice = "api/Price/DeletePrice";

        //Composition
        public const string GetAllCompositions = "api/Composition/GetAllCompositions";
        public const string GetCompositionById = "api/Composition/GetCompositionById";
        public const string GetChampagneInfoByCompositionId = "api/Composition/GetChampagneInfoByCompositionId";
        public const string GetGrapeVarietyInfoByCompositionId = "api/Composition/GetGrapeVarietyInfoByCompositionId";
        public const string AddComposition = "api/Composition/AddComposition";
        public const string UpdateComposition = "api/Composition/UpdateComposition";
        public const string DeleteComposition = "api/Composition/DeleteComposition";

    }
}
