﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

namespace Microsoft.DigitalWorkplace.DigitalTwins.Models.Generator;

internal class DurationProperty : Property
{
    internal DurationProperty(DTNamedEntityInfo entity, ModelGeneratorOptions options) : base(options)
    {
        Name = entity.Name;
        JsonName = entity.Name;
        FieldNumber = int.TryParse(entity.Comment, out int fieldNumber) ? fieldNumber : int.MinValue;
        Obsolete = entity.IsObsolete();
        Type = "TimeSpan?";
    }

    internal override void WriteTo(StreamWriter streamWriter)
    {
        streamWriter.WriteLine($"{indent}{indent}[JsonConverter(typeof(DurationConverter))]");
        base.WriteTo(streamWriter);
    }
}