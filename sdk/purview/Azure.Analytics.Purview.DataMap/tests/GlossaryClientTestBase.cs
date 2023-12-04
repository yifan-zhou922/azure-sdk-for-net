﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Net.Http;
using Azure.Analytics.Purview.Tests;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Core.TestFramework;

namespace Azure.Analytics.Purview.DataMap.Tests
{
    public class GlossaryClientTestBase : RecordedTestBase<PurviewDataMapTestEnvironment>
    {
        public GlossaryClientTestBase(bool isAsync, RecordedTestMode? mode = default) : base(isAsync, mode)
        {
            this.AddPurviewSanitizers();
        }
        public PurviewGlossaries GetGlossariesClient()
        {
            var httpHandler = new HttpClientHandler();
            httpHandler.ServerCertificateCustomValidationCallback = (_, _, _, _) =>
            {
                return true;
            };
            var options = new PurviewDataMapClientOptions { Transport = new HttpClientTransport(httpHandler) };
            var catalogclient = new PurviewDataMapClient(TestEnvironment.Endpoint, TestEnvironment.Credential, InstrumentClientOptions(options));
            return InstrumentClient(catalogclient.Glossaries);
        }
    }
}
