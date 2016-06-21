﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CampaignTestRequest.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
<<<<<<< HEAD
=======

using MailChimp.Net.Models;

>>>>>>> refs/remotes/origin/pr/42
using Newtonsoft.Json;

namespace MailChimp.Net.Core
{
    /// <summary>
    /// The content request.
    /// </summary>
    public class CampaignScheduleRequest
    {

        /// <summary>
        /// Gets or sets the schedule_time property in UTC  format
        /// </summary>
        [JsonProperty("schedule_time")]
        public string ScheduleTime { get; set; }

        /// <summary>
        /// Gets or sets 'timewarp' to send emails at localized time
        /// </summary>
        [JsonProperty("timewarp")]
        public bool? Timewarp { get; set; }

        /// <summary>
        /// Choose whether the campaign should use Batch Delivery. Cannot be set to true for campaigns using Timewarp. 
        /// </summary>
        [JsonProperty("batch_delivery")]
        public bool? BatchDelivery { get; set; }



    }
}