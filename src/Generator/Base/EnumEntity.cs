﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

namespace Microsoft.DigitalWorkplace.DigitalTwins.Models.Generator;

internal class EnumEntity : Entity
{
    internal EnumEntity(ModelGeneratorOptions options) : base(options)
    {
    }

    protected override void WriteSignature(StreamWriter streamWriter)
    {
        streamWriter.WriteLine($"enum {Name}");
    }

    protected override void WriteContent(StreamWriter streamWriter)
    {
    }
}