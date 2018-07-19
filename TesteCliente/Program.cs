﻿using Iatec.Adems.PeopleManagement.Client;
using Iatec.Adems.PeopleManagement.Client.Api;
using Iatec.Adems.PeopleManagement.Client.Model;
using IdentityModel.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace TesteCliente
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            //client-credentials application
            const string CLIENT_ID = "valid_guid";
            const string CLIENT_SECRET = "valid_secret";
            const string SCOPE = "api_scope";

            var httpClient = new HttpClient();
            var discovery = httpClient.GetDiscoveryDocumentAsync("https://login.sdasystems.org").Result;

            var clientCredentialsTokenRequest = new ClientCredentialsTokenRequest()
            {
                ClientId = CLIENT_ID,
                ClientSecret = CLIENT_SECRET,
                Scope = SCOPE,
                Address = discovery.TokenEndpoint,
            };

            var tokens = httpClient.RequestClientCredentialsTokenAsync(clientCredentialsTokenRequest).Result;
            // ---------------------------------------------------------------------------------------------------------- //
            var apiConfig = new Configuration()
            {
                AccessToken = tokens.AccessToken,
                BasePath = "https://ws-peoplemgmt.sdasystems.org/bra/",//-dev,-ho
            };

            EmergencyContactTest(apiConfig);
            AddressTest(apiConfig);
            //NaturalPersonTest(apiConfig);
            //AddressTypeTest(apiConfig);
            //AllergyTypeTeste(apiConfig);
            //DisabilityTypeTeste(apiConfig);


            Console.WriteLine("-- END --");
            Console.ReadLine();
        }

        private static bool EmergencyContactTest(Iatec.Adems.PeopleManagement.Client.Configuration apiConfig)
        {
            try
            {
                var npApi = new NaturalPersonApi(apiConfig);
                var person2 = npApi.GetPageActiveByFilterForExternal(10, 0, "william de qua");

                npApi.NaturalPersonSaveSystemReference(person2.Items.Select(x => x.Id).ToList());

                var api = new EmergencyContactApi(apiConfig);
                var saved = api.SaveEmergencyContact(new EmergencyContactLiteModel
                {
                    ContactPhone = "Phone",
                    Name = "Name",
                    Relationship = "Pai",
                    NaturalPersonId = person2.Items.First().Id,
                });

                return true;
            }
            catch (ApiException ex)
            {
                throw ex;
            }
        }


        private static bool NaturalPersonTest(Iatec.Adems.PeopleManagement.Client.Configuration apiConfig)
        {
            try
            {
                var npApi = new NaturalPersonApi(apiConfig);

                var teste = npApi.SaveForExternal(new NaturalPersonLiteExternalModel
                {
                    AuthenticationUserName = "jabes.tao",
                    FirstName = "Jabes",
                    Gender = GenderModel.Male,
                    BirthDate = new DateTime(1994, 2, 5),
                    IdentifierDocumentNumber = "87708647053",
                    MiddleName = "ta",
                    LastName = "o",
                    FullName = "Jabes ta o",
                    MotherName = "mae",
                });

                //var teste2 = npApi.GetByUserName("jabes.tao");

                //basicPropList.Add(new NPBasicPropertyModel
                //{
                //    BirthDate = teste.BirthDate,
                //    Gender = teste.Gender,
                //    Name = teste.FirstName,
                //});

                //var personList = npApi.GetListByBasicPropertyList(basicPropList);

                //npApi.NaturalPersonDeleteNaturalPerson(new System.Collections.Generic.List<Guid> { teste.Id });

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static bool AddressTest(Iatec.Adems.PeopleManagement.Client.Configuration apiConfig)
        {
            try
            {
                var api = new PersonAddressApi(apiConfig);
                var atapi = new AddressTypeApi(apiConfig);
                var npApi = new NaturalPersonApi(apiConfig);

                var list = atapi.GetListAddressTypeByFilter();
                var person2 = npApi.GetPageActiveByFilterForExternal(10, 0, "william de qua");
                var saved = api.SavePersonAddress(new PersonAddressLiteModel
                {
                    AddressLine01 = "teste erro",
                    AddressType = new AddressTypeModel { Id = list.First().Id },
                    PersonId = person2.Items.FirstOrDefault().Id
                });

                return true;
            }
            catch (ApiException ex)
            {
                throw ex;
            }
        }

        private static bool AddressTypeTest(Iatec.Adems.PeopleManagement.Client.Configuration apiConfig)
        {
            try
            {
                var api = new AddressTypeApi(apiConfig);

                var list = api.GetListAddressTypeByFilter();

                var obj = api.GetAddressTypeById(list.First().Id);

                var idList = list.Select(a => a.Id).ToList();
                var t2 = api.GetListAddressTypeByIdList(idList);

                api.AddressTypeSaveSystemReference(obj.Id);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static bool AllergyTypeTeste(Iatec.Adems.PeopleManagement.Client.Configuration apiConfig)
        {
            try
            {
                var api = new AllergyTypeApi(apiConfig);

                var list = api.GetListAllergyTypeByFilter();

                var obj = api.GetAllergyTypeById(list.First().Id);


                var idList = list.Select(a => a.Id).ToList();
                var t2 = api.GetListAllergyTypeByIdList(idList);

                api.AllergyTypeSaveSystemReference(obj.Id);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static bool DisabilityTypeTeste(Iatec.Adems.PeopleManagement.Client.Configuration apiConfig)
        {
            try
            {
                var api = new DisabilityTypeApi(apiConfig);

                var list = api.GetListDisabilityTypeByFilter();

                var obj = api.GetDisabilityTypeById(list.First().Id);

                var idList = list.Select(a => a.Id).ToList();
                var t2 = api.GetListDisabilityByIdList(idList);

                api.DisabilityTypeSaveSystemReference(obj.Id);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
