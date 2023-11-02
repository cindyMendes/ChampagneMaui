using ChampagneMaui.Models;
using ChampagneMaui.Models.Champagne;
using ChampagneMaui.Models.Size;
using ChampagneMaui.Models.GrapeVariety;
using ChampagneMaui.Shared;
using MauiBlazorAppTest.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChampagneMaui.Services
{
    internal class ChampagneService : IChampagneService
    {
        public async Task<List<ChampagneResponseModel>> GetAllChampagnes()
        {
            var _baseUrl = new Uri("https://localhost:7171");
            var returnResponse = new List<ChampagneResponseModel>();

            try
            {
                using (var client = new HttpClient())
                {
                    string url = $"{_baseUrl}{APIs.GetAllChampagnes}";
                    var apiResponse = await client.GetAsync(url);

                    if (apiResponse.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var response = await apiResponse.Content.ReadAsStringAsync();
                        var deserializeResponse = JsonConvert.DeserializeObject<MainResponseModel>(response);

                        if (deserializeResponse.IsSuccess)
                        {
                            returnResponse = JsonConvert.DeserializeObject<List<ChampagneResponseModel>>(deserializeResponse.Content.ToString());
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

        public async Task<ChampagneResponseModel> GetChampagneById(int id)
        {
            var _baseUrl = new Uri("https://localhost:7171");
            var returnResponse = new ChampagneResponseModel();

            try
            {
                using (var client = new HttpClient())
                {
                    string url = $"{_baseUrl}{APIs.GetChampagneById}/{id}";
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
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }
            return returnResponse;
        }

        public async Task<ChampagneResponseModel> GetChampagneByName(string name)
        {
            var _baseUrl = new Uri("https://localhost:7171");
            var returnResponse = new ChampagneResponseModel();

            try
            {
                using (var client = new HttpClient())
                {
                    string url = $"{_baseUrl}{APIs.GetChampagneByName}/{name}";
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
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }
            return returnResponse;
        }

        public async Task<List<SizeResponseModel>> GetSizesByChampagneId(int champagneId)
        {
            var _baseUrl = new Uri("https://localhost:7171");
            var returnResponse = new List<SizeResponseModel>();

            try
            {
                using (var client = new HttpClient())
                {
                    string url = $"{_baseUrl}{APIs.GetSizesByChampagneId}/{champagneId}";
                    var apiResponse = await client.GetAsync(url);

                    if (apiResponse.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var response = await apiResponse.Content.ReadAsStringAsync();
                        var deserializeResponse = JsonConvert.DeserializeObject<MainResponseModel>(response);

                        if (deserializeResponse.IsSuccess)
                        {
                            returnResponse = JsonConvert.DeserializeObject<List<SizeResponseModel>>(deserializeResponse.Content.ToString());
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

        public async Task<List<GrapeVarietyResponseModel>> GetGrapeVarietiesByChampagneId(int champagneId)
        {
            var _baseUrl = new Uri("https://localhost:7171");
            var returnResponse = new List<GrapeVarietyResponseModel>();

            try
            {
                using (var client = new HttpClient())
                {
                    string url = $"{_baseUrl}{APIs.GetGrapeVarietiesByChampagneId}/{champagneId}";
                    var apiResponse = await client.GetAsync(url);

                    if (apiResponse.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var response = await apiResponse.Content.ReadAsStringAsync();
                        var deserializeResponse = JsonConvert.DeserializeObject<MainResponseModel>(response);

                        if (deserializeResponse.IsSuccess)
                        {
                            returnResponse = JsonConvert.DeserializeObject<List<GrapeVarietyResponseModel>>(deserializeResponse.Content.ToString());
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

        public async Task<List<ChampagneResponseModel>> GetChampagnesByAlcoholLevel(float threshold, string sign)
        {
            var _baseUrl = new Uri("https://localhost:7171");
            var returnResponse = new List<ChampagneResponseModel>();

            try
            {
                using (var client = new HttpClient())
                {
                    string url = $"{_baseUrl}{APIs.GetChampagnesByAlcoholLevel}?threshold={threshold}&sign={sign}";
                    var apiResponse = await client.GetAsync(url);

                    if (apiResponse.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var response = await apiResponse.Content.ReadAsStringAsync();
                        var deserializeResponse = JsonConvert.DeserializeObject<MainResponseModel>(response);

                        if (deserializeResponse.IsSuccess)
                        {
                            returnResponse = JsonConvert.DeserializeObject<List<ChampagneResponseModel>>(deserializeResponse.Content.ToString());
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

        public async Task<MainResponseModel> AddChampagne(AddChampagneRequestModel addChampagneRequest)
        {
            var _baseUrl = new Uri("https://localhost:7171");
            var returnResponse = new MainResponseModel();

            try
            {
                using (var client = new HttpClient())
                {
                    string url = $"{_baseUrl}{APIs.AddChampagne}";
                    var serializedContent = JsonConvert.SerializeObject(addChampagneRequest);
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

        public async Task<MainResponseModel> UpdateChampagne(UpdateChampagneRequestModel updateChampagneRequest)
        {
            var _baseUrl = new Uri("https://localhost:7171");
            var returnResponse = new MainResponseModel();

            try
            {
                using (var client = new HttpClient())
                {
                    string url = $"{_baseUrl}{APIs.UpdateChampagne}";
                    var serializedContent = JsonConvert.SerializeObject(updateChampagneRequest);
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

        public async Task<MainResponseModel> DeleteChampagne(DeleteChampagneRequestModel deleteChampagneRequest)
        {
            var _baseUrl = new Uri("https://localhost:7171");
            var returnResponse = new MainResponseModel();

            try
            {
                using (var client = new HttpClient())
                {
                    string url = $"{_baseUrl}{APIs.DeleteChampagne}";
                    var serializedContent = JsonConvert.SerializeObject(deleteChampagneRequest);

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

        public async Task<MainResponseModel> DeleteChampagneWithPricesAndCompositions(int champagneId)
        {
            var _baseUrl = new Uri("https://localhost:7171");
            var returnResponse = new MainResponseModel();

            try
            {
                using (var client = new HttpClient())
                {
                    string url = $"{_baseUrl}{APIs.DeleteChampagneWithPricesAndCompositions}/{champagneId}";
                    var apiResponse = await client.DeleteAsync(url);

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

        public async Task<MainResponseModel> DeleteChampagneIfNoPricesAndCompositions(int champagneId)
        {
            var _baseUrl = new Uri("https://localhost:7171");
            var returnResponse = new MainResponseModel();

            try
            {
                using (var client = new HttpClient())
                {
                    string url = $"{_baseUrl}{APIs.DeleteChampagneIfNoPricesAndCompositions}/{champagneId}";
                    var apiResponse = await client.DeleteAsync(url);

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
