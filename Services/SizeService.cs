using ChampagneMaui.Models.Size;
using ChampagneMaui.Models;
using MauiBlazorAppTest.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChampagneMaui.Models.Champagne;

namespace ChampagneMaui.Services
{
    internal class SizeService : ISizeService
    {
        public async Task<List<SizeResponseModel>> GetAllSizes()
        {
            var _baseUrl = new Uri("https://localhost:7171");
            var returnResponse = new List<SizeResponseModel>();

            using (var client = new HttpClient())
            {
                string url = $"{_baseUrl}{APIs.GetAllSizes}";
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
            return returnResponse;
        }

        public async Task<SizeResponseModel> GetSizeById(int id)
        {
            var _baseUrl = new Uri("https://localhost:7171");
            var returnResponse = new SizeResponseModel();

            try
            {
                using (var client = new HttpClient())
                {
                    string url = $"{_baseUrl}{APIs.GetSizeById}/{id}";
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
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }
            return returnResponse;
        }

        public async Task<List<ChampagneResponseModel>> GetChampagnesBySizeId(int sizeId)
        {
            var _baseUrl = new Uri("https://localhost:7171");
            var returnResponse = new List<ChampagneResponseModel>();

            try
            {
                using (var client = new HttpClient())
                {
                    string url = $"{_baseUrl}{APIs.GetChampagnesBySizeId}/{sizeId}";
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

        public async Task<MainResponseModel> AddSize(AddSizeRequestModel addSizeRequest)
        {
            var _baseUrl = new Uri("https://localhost:7171");
            var returnResponse = new MainResponseModel();

            try
            {
                using (var client = new HttpClient())
                {
                    string url = $"{_baseUrl}{APIs.AddSize}";
                    var serializedContent = JsonConvert.SerializeObject(addSizeRequest);
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

        public async Task<MainResponseModel> UpdateSize(UpdateSizeRequestModel updateSizeRequest)
        {
            var _baseUrl = new Uri("https://localhost:7171");
            var returnResponse = new MainResponseModel();

            try
            {
                using (var client = new HttpClient())
                {
                    string url = $"{_baseUrl}{APIs.UpdateSize}";
                    var serializedContent = JsonConvert.SerializeObject(updateSizeRequest);
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

        public async Task<MainResponseModel> DeleteSize(DeleteSizeRequestModel deleteSizeRequest)
        {
            var _baseUrl = new Uri("https://localhost:7171");
            var returnResponse = new MainResponseModel();

            try
            {
                using (var client = new HttpClient())
                {
                    string url = $"{_baseUrl}{APIs.DeleteSize}";
                    var serializedContent = JsonConvert.SerializeObject(deleteSizeRequest);

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

        public async Task<MainResponseModel> DeleteSizeWithPrices(int sizeId)
        {
            var _baseUrl = new Uri("https://localhost:7171");
            var returnResponse = new MainResponseModel();

            try
            {
                using (var client = new HttpClient())
                {
                    string url = $"{_baseUrl}{APIs.DeleteSizeWithPrices}/{sizeId}";
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

        public async Task<MainResponseModel> DeleteSizeIfNoPrices(int sizeId)
        {
            var _baseUrl = new Uri("https://localhost:7171");
            var returnResponse = new MainResponseModel();

            try
            {
                using (var client = new HttpClient())
                {
                    string url = $"{_baseUrl}{APIs.DeleteSizeIfNoPrices}/{sizeId}";
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
