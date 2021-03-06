﻿//    Copyright 2016 SnapMD, Inc.
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//        http://www.apache.org/licenses/LICENSE-2.0
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.

using System.Linq;
using SnapMD.VirtualCare.ApiModels;
using SnapMD.VirtualCare.Sdk.Interfaces;
using SnapMD.VirtualCare.Sdk.Models;
using SnapMD.VirtualCare.Sdk.Wrappers;

namespace SnapMD.VirtualCare.Sdk
{
    public class EncounterAdminApi : ApiCall
    {
        public EncounterAdminApi(
            string baseUrl,
            string bearerToken,
            string developerId,
            string apiKey,
            IWebClient webClient)
            : base(baseUrl, webClient, bearerToken, developerId, apiKey)
        {
        }

        public EncounterAdminApi(
            string baseUrl,
            string bearerToken,
            string developerId,
            string apiKey)
            : base(baseUrl, new WebClientWrapper(), bearerToken, developerId, apiKey)
        {
        }

        public ScheduledConsultationResult ScheduleEncounter(ScheduleConsultationDetailByUsername encounterData)
        {
            var response = Post("v2/admin/schedule/consultations", encounterData);

            if (response != null)
            {
                var apiResponse = response.ToObject<ApiResponseV2<ScheduledConsultationResult>>();

                if (apiResponse != null && apiResponse.Data != null && apiResponse.Data.Any())
                {
                    return apiResponse.Data.First();
                }
            }

            return null;
        }
    }
}