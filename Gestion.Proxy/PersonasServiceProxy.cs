﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

using Helpers;
//using Gestion.Entities;
using Gestion.EntitiesDTO;
using Gestion.Proxy.Models;
using Newtonsoft.Json;

namespace Gestion.Proxy {
    public class PersonasServiceProxy {

        public static string GetAPIDomain() {
            string strReturnValue;
            strReturnValue = AppSettingsHelper.GetAppSetting("HTTPDomainAPI", "");
            return strReturnValue;
        }

        public static PersonaDTO GetById(int intId) {
            PersonaDTO          returnEntity = null;
            string              strBaseAdressURL;
            HttpResponseMessage response;

            using (HttpClient client = new HttpClient()) {
                strBaseAdressURL = GetAPIDomain();
                client.BaseAddress = new Uri(strBaseAdressURL);

                // Add an Accept header for JSON format.
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                response = client.GetAsync("api/v1/personas/" + intId.ToString()).Result;
                if (response.IsSuccessStatusCode) {
                    returnEntity = response.Content.ReadAsAsync<PersonaDTO>().Result;
                }
                //client.Dispose();
            }

            return returnEntity;
        }

        public static List<PersonaDTO> GetAll() {
            List<PersonaDTO>    returnList = new List<PersonaDTO>();
            string              strBaseAdressURL;
            HttpResponseMessage response;

            using (HttpClient client = new HttpClient()){
                strBaseAdressURL = GetAPIDomain();
                client.BaseAddress = new Uri(strBaseAdressURL);

                // Add an Accept header for JSON format.
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                response = client.GetAsync("api/v1/personas").Result; 
                if (response.IsSuccessStatusCode) {
                    returnList = response.Content.ReadAsAsync<List<PersonaDTO>>().Result;
                }
                //client.Dispose();
            }

            return returnList;
        }

        public static List<PersonaDTO> GetActivos() {
            List<PersonaDTO> returnList = new List<PersonaDTO>();
            string strBaseAdressURL;
            HttpResponseMessage response;

            using (HttpClient client = new HttpClient()) {
                strBaseAdressURL = GetAPIDomain();
                client.BaseAddress = new Uri(strBaseAdressURL);

                // Add an Accept header for JSON format.
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                response = client.GetAsync("api/v1/personas/activos").Result;
                if (response.IsSuccessStatusCode) {
                    returnList = response.Content.ReadAsAsync<List<PersonaDTO>>().Result;
                }
                //client.Dispose();
            }

            return returnList;
        }

        public static List<PersonaDTO> GetInActivos() {
            List<PersonaDTO> returnList = new List<PersonaDTO>();
            string strBaseAdressURL;
            HttpResponseMessage response;

            using (HttpClient client = new HttpClient()) {
                strBaseAdressURL = GetAPIDomain();
                client.BaseAddress = new Uri(strBaseAdressURL);

                // Add an Accept header for JSON format.
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                response = client.GetAsync("api/v1/personas/inactivos").Result; 
                if (response.IsSuccessStatusCode) {
                    returnList = response.Content.ReadAsAsync<List<PersonaDTO>>().Result;
                }
                //client.Dispose();
            }

            return returnList;
        }

        public static ResponseProxyDTO Insert(PersonaDTO newEntity) {
            ResponseProxyDTO    returnEntity = null;
            string              strBaseAdressURL;
            ByteArrayContent    byteContent;
            HttpResponseMessage response;

            using (HttpClient client = new HttpClient()) {
                strBaseAdressURL    = GetAPIDomain();
                client.BaseAddress  = new Uri(strBaseAdressURL);

                // Add an Accept header for JSON format.
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // Serializo el Objeto a enviar.
                byteContent = ObjectToByteArrayContent(newEntity);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                //

                response = client.PostAsync("api/v1/personas", byteContent).Result;
                if (response.IsSuccessStatusCode) {
                    returnEntity = response.Content.ReadAsAsync<ResponseProxyDTO>().Result;
                } else {
                    returnEntity = new ResponseProxyDTO();
                }
            }

            return returnEntity;
        }


        #region Funciones Utiles
        private static ByteArrayContent ObjectToByteArrayContent(object currentObject) {
            ByteArrayContent    returnByteArrayContent;
            string              myContent;
            byte[]              buffer;

            myContent    = JsonConvert.SerializeObject(currentObject);
            buffer       = System.Text.Encoding.UTF8.GetBytes(myContent);
            returnByteArrayContent = new ByteArrayContent(buffer);

            returnByteArrayContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            return returnByteArrayContent;
        }
        #endregion
    }
}
