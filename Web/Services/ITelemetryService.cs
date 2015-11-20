﻿// ---------------------------------------------------------------
//  Copyright (c) Microsoft Corporation. All rights reserved.
// ---------------------------------------------------------------

namespace Microsoft.Azure.Devices.Applications.PredictiveMaintenance.Web.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Contracts;

    public interface ITelemetryService
    {
        Task<IEnumerable<Telemetry>> GetLatestTelemetryData();

        Task<IEnumerable<Prediction>> GetLatestPredictionData();
    }
}