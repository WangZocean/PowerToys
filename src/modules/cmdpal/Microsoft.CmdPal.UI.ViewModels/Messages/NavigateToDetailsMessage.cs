﻿// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Microsoft.CmdPal.UI.ViewModels.Messages;

// Want to know what a record is?  here is a TLDR
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/record
public record NavigateToDetailsMessage(ListItemViewModel ListItem)
{
}