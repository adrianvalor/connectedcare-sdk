﻿using System;
using SnapMD.VirtualCare.ApiModels.Attributes;

namespace SnapMD.VirtualCare.ApiModels
{

    /// <summary>
    /// Wraps a consultation ID in a response for scheduled consultation POST APIs.
    /// </summary>
    [ModelName("ApiModels.ScheduledConsultationResult")]
    public class ScheduledConsultationResult
    {
        /// <summary>
        /// The ID of the newly-created consultation.
        /// </summary>
        public int ConsultationId { get; set; }

        /// <summary>
        /// The ID of the newly-created PatientQueue.
        /// </summary>
        public Guid PatientQueueId { get; set; }

        /// <summary>
        /// The meeting identifier.
        /// </summary>
        public Guid MeetingId { get; set; }
    }
}
