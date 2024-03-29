﻿using ePozoriste.Model;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Pozoriste.Mobile
{
    public class APIService
    {
        public static string Username { get; set; }
        public static string Password { get; set; }

        private readonly string _route;

#if DEBUG
        private string _apiUrl = "http://localhost:56404/api";
#endif
#if RELEASE
        private string _apiUrl = "https://mywebsite.com/api/";
#endif

        public APIService(string route)
        {
            _route = route;
        }

        public async Task<T> Get<T>(object search)
        {
            var url = $"{_apiUrl}/{_route}";

            try
            {
                if (search != null)
                {
                    url += "?";
                    url += await search.ToQueryString();
                }

                return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.Response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    await Application.Current.MainPage.DisplayAlert("Greska", "Niste autentificirani", "OK");
                    return default;
                }
                else if (ex.Call.Response.StatusCode == System.Net.HttpStatusCode.Forbidden)
                {
                    await Application.Current.MainPage.DisplayAlert("Greska", "Nemate pravo pristupa", "OK");
                    return default;
                }
                else
                {
                    var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                    var stringBuilder = new StringBuilder();
                    if (errors != null)
                    {
                        foreach (var error in errors)
                        {
                            stringBuilder.AppendLine($"{error.Key}, {string.Join(",", error.Value)}");
                        }
                        await Application.Current.MainPage.DisplayAlert("Greska", stringBuilder.ToString(), "OK");
                    }

                    throw;
                }
            }
        }

        public async Task<T> GetById<T>(object id)
        {
            var url = $"{_apiUrl}/{_route}/{id}";

            return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
        }

        public async Task<T> Insert<T>(object request)
        {
            var url = $"{_apiUrl}/{_route}";

            try
            {
                return await url.WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.Response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    await Application.Current.MainPage.DisplayAlert("Greska", "Niste autentificirani", "OK");
                }
                else if (ex.Call.Response.StatusCode == System.Net.HttpStatusCode.Forbidden)
                {
                    await Application.Current.MainPage.DisplayAlert("Greska", "Nemate pravo pristupa", "OK");
                }
                else
                {
                    var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                    var stringBuilder = new StringBuilder();
                    if (errors != null)
                    {
                        foreach (var error in errors)
                        {
                            stringBuilder.AppendLine($"{error.Key}, {string.Join(",", error.Value)}");
                        }
                        await Application.Current.MainPage.DisplayAlert("Greska", stringBuilder.ToString(), "OK");
                    }
                }
                return default(T);
            }

        }

        public async Task<T> Update<T>(int id, object request)
        {
            try
            {
                var url = $"{_apiUrl}/{_route}/{id}";

                return await url.WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.Response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    await Application.Current.MainPage.DisplayAlert("Greska", "Niste autentificirani", "OK");
                }
                else if (ex.Call.Response.StatusCode == System.Net.HttpStatusCode.Forbidden)
                {
                    await Application.Current.MainPage.DisplayAlert("Greska", "Nemate pravo pristupa", "OK");
                }
                else
                {
                    var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                    var stringBuilder = new StringBuilder();
                    if (errors != null)
                    {
                        foreach (var error in errors)
                        {
                            stringBuilder.AppendLine($"{error.Key}, {string.Join(",", error.Value)}");
                        }
                        await Application.Current.MainPage.DisplayAlert("Greska", stringBuilder.ToString(), "OK");
                    }
                }
                return default(T);
            }

        }

        public async Task<T> Delete<T>(int id)
        {
            try
            {
                var url = $"{_apiUrl}/{_route}/{id}";

                return await url.WithBasicAuth(Username, Password).DeleteAsync().ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.Response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    await Application.Current.MainPage.DisplayAlert("Greska", "Niste autentificirani", "OK");
                }
                else if (ex.Call.Response.StatusCode == System.Net.HttpStatusCode.Forbidden)
                {
                    await Application.Current.MainPage.DisplayAlert("Greska", "Nemate pravo pristupa", "OK");
                }
                else
                {
                    var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                    var stringBuilder = new StringBuilder();
                    if (errors != null)
                    {
                        foreach (var error in errors)
                        {
                            stringBuilder.AppendLine($"{error.Key}, {string.Join(",", error.Value)}");
                        }
                        await Application.Current.MainPage.DisplayAlert("Greska", stringBuilder.ToString(), "OK");
                    }
                }
                return default(T);
            }

        }
    }
}
