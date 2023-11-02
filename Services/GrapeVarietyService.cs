using ChampagneMaui.Models.Champagne;
using ChampagneMaui.Models;
using ChampagneMaui.Models.GrapeVariety;
using MauiBlazorAppTest.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChampagneMaui.Services
{
    internal class GrapeVarietyService : IGrapeVarietyService
    {
        public async Task<List<GrapeVarietyResponseModel>> GetAllGrapeVarieties()
        {
            var _baseUrl = new Uri("https://localhost:7171");
            var returnResponse = new List<GrapeVarietyResponseModel>();

            using (var client = new HttpClient())
            {
                string url = $"{_baseUrl}{APIs.GetAllGrapeVarieties}";
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
            return returnResponse;
        }

        public async Task<GrapeVarietyResponseModel> GetGrapeVarietyById(int id)
        {
            var _baseUrl = new Uri("https://localhost:7171");
            var returnResponse = new GrapeVarietyResponseModel();

            try
            {
                using (var client = new HttpClient())
                {
                    string url = $"{_baseUrl}{APIs.GetGrapeVarietyById}/{id}";
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
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }
            return returnResponse;
        }

        public async Task<MainResponseModel> AddGrapeVariety(AddGrapeVarietyRequestModel addGrapeVarietyRequest)
        {
            var _baseUrl = new Uri("https://localhost:7171");
            var returnResponse = new MainResponseModel();

            try
            {
                using (var client = new HttpClient())
                {
                    string url = $"{_baseUrl}{APIs.AddGrapeVariety}";
                    var serializedContent = JsonConvert.SerializeObject(addGrapeVarietyRequest);
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

        public async Task<MainResponseModel> UpdateGrapeVariety(UpdateGrapeVarietyRequestModel updateGrapeVarietyRequest)
        {
            var _baseUrl = new Uri("https://localhost:7171");
            var returnResponse = new MainResponseModel();

            try
            {
                using (var client = new HttpClient())
                {
                    string url = $"{_baseUrl}{APIs.UpdateGrapeVariety}";
                    var serializedContent = JsonConvert.SerializeObject(updateGrapeVarietyRequest);
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

        public async Task<MainResponseModel> DeleteGrapeVariety(int id)
        {
            var _baseUrl = new Uri("https://localhost:7171");
            var returnResponse = new MainResponseModel();

            try
            {
                using (var client = new HttpClient())
                {
                    string url = $"{_baseUrl}{APIs.DeleteGrapeVariety}/{id}";
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
