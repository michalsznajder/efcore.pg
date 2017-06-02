﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Microsoft.EntityFrameworkCore.Utilities
{
    public static class DbContextOptionsBuilderExtensions
    {
        public static NpgsqlDbContextOptionsBuilder ApplyConfiguration(this NpgsqlDbContextOptionsBuilder optionsBuilder)
        {
            return optionsBuilder;
        }
    }
}
