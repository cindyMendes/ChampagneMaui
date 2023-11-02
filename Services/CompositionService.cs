using ChampagneMaui.Models;
using MauiBlazorAppTest.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChampagneMaui.Models.Composition;
using ChampagneMaui.Models.Champagne;
using ChampagneMaui.Models.GrapeVariety;
using ChampagneMaui.Models.Price;

namespace ChampagneMaui.Services
{
    internal class CompositionService : ICompositionService
    {
        public async Task<List<CompositionResponseModel>> GetAllCompositions()
        {
            var _baseUrl = new Uri("https://localhost:7171");
            var returnResponse = new List<CompositionResponseModel>();

            using (var client = new HttpClient())
            {
                string url = $"{_baseUrl}{APIs.GetAllCompositions}";
                var apiResponse = await client.GetAsync(url);

                if (apiResponse.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var response = await apiResponse.Content.ReadAsStringAsync();
                    var deserializeResponse = JsonConvert.DeserializeObject<MainResponseModel>(response);

                    if (deserializeResponse.IsSuccess)
                    {
                        returnResponse = JsonConvert.DeserializeObject<List<CompositionResponseModel>>(deserializeResponse.Content.ToString());
                    }
                }
            }
            return returnResponse;
        }

        public async Task<CompositionResponseModel> GetCompositionById(int id)
        {
            var _baseUrl = new Uri("https://localhost:7171");
            var returnResponse = new CompositionResponseModel();

            try
            {
                using (var client = new HttpClient())
                {
                    string url = $"{_baseUrl}{APIs.GetCompositionById}/{id}";
                    var apiResponse = await client.GetAsync(url);

                    if (apiResponse.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var response = await apiResponse.Content.ReadAsStringAsync();
                        var deserializeResponse = JsonConvert.DeserializeObject<MainResponseModel>(response);

                        if (deserializeResponse.IsSuccess)
                        {
                            returnResponse = JsonConvert.DeserializeObject<CompositionResponseModel>(deserializeResponse.Content.ToString());
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

        public async Task<ChampagneResponseModel> GetChampagneInfoByCompositionId(int id)
        {
            var _baseUrl = new Uri("https://localhost:7171");
            var returnResponse = new ChampagneResponseModel();

            using (var client = new HttpClient())
            {
                string url = $"{_baseUrl}{APIs.GetChampagneInfoByCompositionId}/{id}";
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

        public async Task<GrapeVarietyResponseModel> GetGrapeVarietyInfoByCompositionId(int id)
        {
            var _baseUrl = new Uri("https://localhost:7171");
            var returnResponse = new GrapeVarietyResponseModel();

            using (var client = new HttpClient())
            {
                string url = $"{_baseUrl}{APIs.GetGrapeVarietyInfoByCompositionId}/{id}";
                var apiResponse = await client.GetAsync(url);

                if (apiResponse.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var response = await apiResponse.Content.ReadAsStringAsync();
                    var deserializeResponse = JsonConvert.DeserializeObject<MainResponseModel>(response);

                    if (deserializeResponse.IsSuccess)
                    {
                        returnResponse = JsonConvert.DeserializeObject<GrapeVarietyResponseModel>(deserializeResponse.Content.ToString());
                    }
                }
            }
            return returnResponse;
        }

        public async Task<MainResponseModel> AddComposition(AddCompositionRequestModel addCompositionRequest)
        {
            var _baseUrl = new Uri("https://localhost:7171");
            var returnResponse = new MainResponseModel();

            try
            {
                using (var client = new HttpClient())
                {
                    string url = $"{_baseUrl}{APIs.AddComposition}";
                    var serializedContent = JsonConvert.SerializeObject(addCompositionRequest);
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

        public async Task<MainResponseModel> UpdateComposition(UpdateCompositionRequestModel updateCompositionRequest)
        {
            var _baseUrl = new Uri("https://localhost:7171");
            var returnResponse = new MainResponseModel();

            try
            {
                using (var client = new HttpClient())
                {
                    string url = $"{_baseUrl}{APIs.UpdateComposition}";
                    var serializedContent = JsonConvert.SerializeObject(updateCompositionRequest);
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

        public async Task<MainResponseModel> DeleteComposition(int id)
        {
            var _baseUrl = new Uri("https://localhost:7171");
            var returnResponse = new MainResponseModel();

            try
            {
                using (var client = new HttpClient())
                {
                    string url = $"{_baseUrl}{APIs.DeleteComposition}/{id}";
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
