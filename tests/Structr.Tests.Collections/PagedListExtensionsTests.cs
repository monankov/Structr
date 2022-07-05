using FluentAssertions;
using Structr.Collections;
using System;
using System.Collections.Generic;
using Xunit;

namespace Structr.Tests.Collections
{
    public class PagedListExtensionsTests
    {
        [Fact]
        public void ToSerializablePagedList()
        {
            // Arrange
            var totalItems = 10;
            var pageNumber = 2;
            var pageSize = 3;
            var sourcePageList = new PagedList<int>(new List<int> { 1, 2, 3 },
                totalItems: totalItems,
                pageNumber: pageNumber,
                pageSize: pageSize);

            // Act
            var result = sourcePageList.ToSerializablePagedList();

            // Assert
            result.Should().NotBeNull();
            result.Items.Should().BeEquivalentTo((IEnumerable<int>)sourcePageList);
            result.TotalItems.Should().Be(totalItems);
            result.PageNumber.Should().Be(pageNumber);
            result.PageSize.Should().Be(pageSize);
        }

        [Fact]
        public void ToSerializablePagedList_throws_when_source_is_null()
        {
            // Arrange
            PagedList<int> sourcePageList = null!;

            // Act
            Action act = () => sourcePageList.ToSerializablePagedList();

            // Assert
            act.Should().Throw<ArgumentNullException>();
        }
    }
}
