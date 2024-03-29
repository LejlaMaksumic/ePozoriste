﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flurl.Http;
using Flurl;
using ePozoriste.Model;
using System.Windows.Forms;
using Microsoft.AspNetCore.Mvc;

namespace ePozoriste.WinUI
{
    public class APIService
    {
        public static string Username { get; set; }
        public static string Password { get; set; }

        private readonly string _route;
        public APIService(string route)
        {
            _route = route;
        }

        public async Task<T> Get<T>(object search)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}";

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
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized)
                {
                    MessageBox.Show("Niste autentificrani", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return default(T);
                }
                else if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Forbidden)
                {
                    MessageBox.Show("Nemate pravo pristupa", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return default(T);
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
                    }
                    else
                    {
                        var errors2 = await ex.GetResponseJsonAsync<ValidationProblemDetails>();
                        if (errors2 != null)
                            foreach (var error in errors2.Errors)
                            {
                                stringBuilder.AppendLine($"{error.Key}, {string.Join(",", error.Value)}");
                            }
                        else
                        {
                            var errors3 = await ex.GetResponseStringAsync();
                            if (errors3 != null) stringBuilder.AppendLine(errors3);
                        }
                    }

                    MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                throw;
            }
        }

        public async Task<T> GetById<T>(object id)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";

            try
            {
                return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized)
                {
                    MessageBox.Show("Niste autentificrani", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Forbidden)
                {
                    MessageBox.Show("Nemate pravo pristupa", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    }
                    else
                    {
                        var errors2 = await ex.GetResponseJsonAsync<ValidationProblemDetails>();
                        if (errors2 != null)
                            foreach (var error in errors2.Errors)
                            {
                                stringBuilder.AppendLine($"{error.Key}, {string.Join(",", error.Value)}");
                            }
                        else
                        {
                            var errors3 = await ex.GetResponseStringAsync();
                            if (errors3 != null) stringBuilder.AppendLine(errors3);
                        }
                    }

                    MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return default(T);
            }

        }

        public async Task<T> Insert<T>(object request)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}";

            try
            {
                return await url.WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized)
                {
                    MessageBox.Show("Niste autentificrani", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Forbidden)
                {
                    MessageBox.Show("Nemate pravo pristupa", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    }
                    else
                    {
                        var errors2 = await ex.GetResponseJsonAsync<ValidationProblemDetails>();
                        if (errors2 != null)
                            foreach (var error in errors2.Errors)
                            {
                                stringBuilder.AppendLine($"{error.Key}, {string.Join(",", error.Value)}");
                            }
                        else
                        {
                            var errors3 = await ex.GetResponseStringAsync();
                            if (errors3 != null) stringBuilder.AppendLine(errors3);
                        }
                    }

                    MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return default(T);
            }

        }

        public async Task<T> Update<T>(int id, object request)
        {
            try
            {
                var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";

                return await url.WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized)
                {
                    MessageBox.Show("Niste autentificrani", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Forbidden)
                {
                    MessageBox.Show("Nemate pravo pristupa", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    }
                    else
                    {
                        var errors2 = await ex.GetResponseJsonAsync<ValidationProblemDetails>();
                        if (errors2 != null)
                            foreach (var error in errors2.Errors)
                            {
                                stringBuilder.AppendLine($"{error.Key}, {string.Join(",", error.Value)}");
                            }
                        else
                        {
                            var errors3 = await ex.GetResponseStringAsync();
                            if (errors3 != null) stringBuilder.AppendLine(errors3);
                        }
                    }

                    MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return default(T);
            }
        }

    }
}
