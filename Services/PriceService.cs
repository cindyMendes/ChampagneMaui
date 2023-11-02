using ChampagneMaui.Models.Price;
using ChampagneMaui.Models;
using MauiBlazorAppTest.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChampagneMaui.Models.Champagne;
using ChampagneMaui.Models.Size;

namespace ChampagneMaui.Services
{
    internal class PriceService : IPriceService
    {
        public async Task<List<PriceResponseModel>> GetAllPrices()
        {
            var _baseUrl = new Uri("https://localhost:7171");
            var returnResponse = new List<PriceResponseModel>();

            using (var client = new HttpClient())
            {
                string url = $"{_baseUrl}{APIs.GetAllPrices}";
                var apiResponse = await client.GetAsync(url);

                if (apiResponse.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var response = await apiResponse.Content.ReadAsStringAsync();
                    var deserializeResponse = JsonConvert.DeserializeObject<MainResponseModel>(response);

                    if (deserializeResponse.IsSuccess)
                    {
                        returnResponse = JsonConvert.DeserializeObject<List<PriceResponseModel>>(deserializeResponse.Content.ToString());
                    }
                }
            }
            return returnResponse;
        }

        public async Task<PriceResponseModel> GetPriceById(int id)
        {
            var _baseUrl = new Uri("https://localhost:7171");
            var returnResponse = new PriceResponseModel();

            try
            {
                using (var client = new HttpClient())
                {
                    string url = $"{_baseUrl}{APIs.GetPriceById}/{id}";
                    var apiResponse = await client.GetAsync(url);

                    if (apiResponse.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var response = await apiResponse.Content.ReadAsStringAsync();
                        var deserializeResponse = JsonConvert.DeserializeObject<MainResponseModel>(response);

                        if (deserializeResponse.IsSuccess)
                        {
                            returnResponse = JsonConvert.DeserializeObject<PriceResponseModel>(deserializeResponse.Content.ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }
            return returnResponse;
        }

        public async Task<ChampagneResponseModel> GetChampagneInfoByPriceId(int id)
        {
            var _baseUrl = new Uri("https://localhost:7171");
            var returnResponse = new ChampagneResponseModel();

            using (var client = new HttpClient())
            {
                string url = $"{_baseUrl}{APIs.GetChampagneInfoByPriceId}/{id}"; 
                var apiResponse = await client.GetAsync(url);

                if (apiResponse.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var response = await apiResponse.Content.ReadAsStringAsync();
                    var deserializeResponse = JsonConvert.DeserializeObject<MainResponseModel>(response);

                    if (deserializeResponse.IsSuccess)
                    {
                        returnResponse = JsonConvert.DeserializeObject<ChampagneResponseModel>(deserializeResponse.Content.ToString());
                    }
                }
            }
            return returnResponse;
        }

        public async Task<SizeResponseModel> GetSizeInfoByPriceId(int id)
        {
            var _baseUrl = new Uri("https://localhost:7171");
            var returnResponse = new SizeResponseModel();

            using (var client = new HttpClient())
            {
                string url = $"{_baseUrl}{APIs.GetSizeInfoByPriceId}/{id}";
                var apiResponse = await client.GetAsync(url);

                if (apiResponse.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var response = await apiResponse.Content.ReadAsStringAsync();
                    var deserializeResponse = JsonConvert.DeserializeObject<MainResponseModel>(response);

                    if (deserializeResponse.IsSuccess)
                    {
                        returnResponse = JsonConvert.DeserializeObject<SizeResponseModel>(deserializeResponse.Content.ToString());
                    }
                }
            }
            return returnResponse;
        }

        public async Task<MainResponseModel> AddPrice(AddPriceRequestModel addPriceRequest)
        {
            var _baseUrl = new Uri("https://localhost:7171");
            var returnResponse = new MainResponseModel();

            try
            {
                using (var client = new HttpClient())
                {
                    string url = $"{_baseUrl}{APIs.AddPrice}";
                    var serializedContent = JsonConvert.SerializeObject(addPriceRequest);
                    var apiResponse = await client.PostAsync(url, new StringContent(serializedContent, Encoding.UTF8, "application/json"));

                    if (apiResponse.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var response = await apiResponse.Content.ReadAsStringAsync();
                        returnResponse = JsonConvert.DeserializeObject<MainResponseModel>(response);
                    }
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }
            return returnResponse;
        }

        public async Task<MainResponseModel> UpdatePrice(UpdatePriceRequestModel updatePriceRequest)
        {
            var _baseUrl = new Uri("https://localhost:7171");
            var returnResponse = new MainResponseModel();

            try
            {
                using (var client = new HttpClient())
                {
                    string url = $"{_baseUrl}{APIs.UpdatePrice}";
                    var serializedContent = JsonConvert.SerializeObject(updatePriceRequest);
                    var apiResponse = await client.PutAsync(url, new StringContent(serializedContent, Encoding.UTF8, "application/json"));

                    if (apiResponse.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var response = await apiResponse.Content.ReadAsStringAsync();
                        returnResponse = JsonConvert.DeserializeObject<MainResponseModel>(response);
                    }
                    else
                    {
                        returnResponse.IsSuccess = false;
                        returnResponse.Content = apiResponse.Content;
                        returnResponse.Message = apiResponse.StatusCode.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }
            return returnResponse;
        }

        public async Task<MainResponseModel> DeletePrice(int id)
        {
            var _baseUrl = new Uri("https://localhost:7171");
            var returnResponse = new MainResponseModel();

            try
            {
                using (var client = new HttpClient())
                {
                    string url = $"{_baseUrl}{APIs.DeletePrice}/{id}";
                    var serializedContent = JsonConvert.SerializeObject(id);

                    var request = new HttpRequestMessage();
                    request.Method = HttpMethod.Delete;
                    request.RequestUri = new Uri(url);
                    request.Content = new StringContent(serializedContent, Encoding.UTF8, "application/json");

                    var apiResponse = await client.SendAsync(request);

                    if (apiResponse.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var response = await apiResponse.Content.ReadAsStringAsync();
                        returnResponse = JsonConvert.DeserializeObject<MainResponseModel>(response);
                    }
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }
            return returnResponse;
        }
    }
}
