// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Infrastructure;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.JSInterop;

namespace Microsoft.AspNetCore.Components.Server.Circuits
{
    internal interface ICircuitHandleRegistry
    {
        CircuitHandle GetCircuitHandle(IDictionary<object, object?> circuitHandles, object circuitKey);

        CircuitHost GetCircuit(IDictionary<object, object?> circuitHandles, object circuitKey);

        void SetCircuit(IDictionary<object, object?> circuitHandles, object circuitKey, CircuitHost circuitHost);
    }
}
