// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

namespace Microsoft.DigitalWorkplace.DigitalTwins.Models.Generator;

internal class EnumProperty : Property
{
    internal EnumProperty(DTNamedEntityInfo entityInfo, DTEnumInfo enumInfo, string enclosingClass, ModelGeneratorOptions options) : base(options)
    {
        var enumEntity = new EnumPropEntity(enumInfo, enclosingClass, options);
        Type = enumEntity.Name;
        Name = entityInfo.Name;
        FieldNumber = int.TryParse(entityInfo.Comment, out int fieldNumber) ? fieldNumber : int.MinValue;
        JsonName = entityInfo.Name;
        Obsolete = entityInfo.IsObsolete();
        ProducedEntities.Add(enumEntity);
    }
}