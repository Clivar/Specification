﻿using FluentAssertions;
using Ardalis.Specification.UnitTests.Fixture.Entities;
using Ardalis.Specification.UnitTests.Fixture.Specs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Ardalis.Specification.UnitTests
{
    public class OrderedBuilderExtensions_ThenByDescending
    {
        [Fact]
        public void AppendsOrderExpressionToListWithThenByDescendingType_GivenThenByDescendingExpression()
        {
            var spec = new StoresByCompanyOrderedDescByNameThenByDescIdSpec(1);

            var orderExpressions = spec.OrderExpressions.ToList();

            // The list must have two items, since Then can be applied once the first level is applied.
            orderExpressions.Should().HaveCount(2);

            orderExpressions[1].OrderType.Should().Be(OrderTypeEnum.ThenByDescending);
        }
    }
}
