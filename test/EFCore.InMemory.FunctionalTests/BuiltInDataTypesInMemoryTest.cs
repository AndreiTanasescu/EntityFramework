// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Xunit;

namespace Microsoft.EntityFrameworkCore
{
    public class BuiltInDataTypesInMemoryTest : BuiltInDataTypesTestBase<BuiltInDataTypesInMemoryFixture>
    {
        public BuiltInDataTypesInMemoryTest(BuiltInDataTypesInMemoryFixture fixture)
            : base(fixture)
        {
        }

        [Fact]
        public virtual void Can_perform_query_with_ansi_strings()
        {
            Can_perform_query_with_ansi_strings_test(supportsAnsi: false);
        }
    }
}
