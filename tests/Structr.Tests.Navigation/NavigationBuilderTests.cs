using FluentAssertions;
using Microsoft.Extensions.Caching.Memory;
using Structr.Navigation;
using Structr.Navigation.Internal;
using Structr.Navigation.Providers;
using System.IO;
using System.Reflection;
using Xunit;

namespace Structr.Tests.Navigation
{
    public class NavigationBuilderTests
    {
        [Fact]
        public void Correct_navigation_after_build()
        {
            // Arrange

            var path = Path.Combine(
                new DirectoryInfo(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)).Parent.Parent.Parent.FullName,
                "Data/menu.json");
            var provider = new JsonNavigationProvider<InternalNavigationItem>(path);
            var options = new NavigationOptions<InternalNavigationItem>();
            var navigationCache = new NavigationCache(new MemoryCache(new MemoryCacheOptions { SizeLimit = 1024 }));

            var builder = new NavigationBuilder<InternalNavigationItem>(provider, options, navigationCache);

            // Act

            var result = builder.BuildNavigation();

            // Assert

            result.Should().NotBeEmpty()
                .And.HaveCount(3)
                .And.SatisfyRespectively(
                    firstParent =>
                    {
                        firstParent.Id.Should().Be("Parent_1");
                        firstParent.Title.Should().Be("Parent 1");
                        firstParent.Children.Should().NotBeEmpty()
                            .And.HaveCount(2)
                            .And.SatisfyRespectively(
                                firstChild =>
                                {
                                    firstChild.Id.Should().Be("Child_1_1");
                                    firstChild.Title.Should().Be("Child 1 1");
                                    firstChild.Children.Should().NotBeEmpty()
                                        .And.HaveCount(1)
                                        .And.SatisfyRespectively(
                                            grandson =>
                                            {
                                                grandson.Id.Should().Be("Child_1_1_1");
                                                grandson.Title.Should().Be("Child 1 1 1");
                                                grandson.Children.Should().BeEmpty();
                                            }
                                        );
                                },
                                secondChild =>
                                {
                                    secondChild.Id.Should().Be("Child_1_2");
                                    secondChild.Title.Should().Be("Child 1 2");
                                    secondChild.Children.Should().BeEmpty();
                                }
                            );
                    },
                    secondParent =>
                    {
                        secondParent.Id.Should().Be("Parent_2");
                        secondParent.Title.Should().Be("Parent 2");
                        secondParent.Children.Should().NotBeEmpty()
                            .And.HaveCount(1)
                            .And.SatisfyRespectively(
                                firstChild =>
                                {
                                    firstChild.Id.Should().Be("Child_2_1");
                                    firstChild.Title.Should().Be("Child 2 1");
                                    firstChild.Children.Should().BeEmpty();
                                }
                            );
                    },
                    thirdParent =>
                    {
                        thirdParent.Id.Should().Be("Parent_3");
                        thirdParent.Title.Should().Be("Parent 3");
                        thirdParent.Children.Should().BeEmpty();
                    }
                );
        }
    }
}