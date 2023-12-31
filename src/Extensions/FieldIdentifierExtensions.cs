﻿using Microsoft.AspNetCore.Components.Forms;

namespace Radical.Presenting.Components;

public static class FieldIdentifierExtensions
{
    public static string GetDisplayName(this FieldIdentifier fieldIdentifier) => Utility.GetDisplayName(fieldIdentifier.Model, fieldIdentifier.FieldName);

    public static string? GetPlaceHolder(this FieldIdentifier fieldIdentifier) => Utility.GetPlaceHolder(fieldIdentifier.Model, fieldIdentifier.FieldName);
}
