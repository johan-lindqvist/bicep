// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System.Text.Json;
using Bicep.Core.Extensions;
using Bicep.Core.Json;

namespace Bicep.Core.Configuration;

public record ExperimentalFeaturesEnabled(
    bool? SymbolicNameCodegen,
    bool? Extensibility,
    bool? ResourceTypedParamsAndOutputs,
    bool? SourceMapping,
    bool? ParamsFiles,
    bool? UserDefinedTypes,
    bool? UserDefinedFunctions)
{
    public static ExperimentalFeaturesEnabled Bind(JsonElement element, string? configurationPath)
        => element.ToNonNullObject<ExperimentalFeaturesEnabled>();

    public void WriteTo(Utf8JsonWriter writer) => JsonElementFactory.CreateElement(this).WriteTo(writer);
}
