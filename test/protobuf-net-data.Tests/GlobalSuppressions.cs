﻿// Copyright (c) Richard Dingwall, Arjen Post. See LICENSE in the project root for license information.

// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.
#if NET40
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Assertions", "xUnit2006:Do not use invalid string equality check", Justification = "AssertEqualGenericShouldNotBeUsedForStringValue should not error.", Scope = "module")]
#endif
