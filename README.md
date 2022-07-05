![Structr](assets/logo/logo_100x100.png)

# Structr

**Structr** is a framework composed of several components for development of cross-platform applications on .NET by following the software development best practices and patterns. Most of components have [.NET Standard 2.0](https://docs.microsoft.com/en-us/dotnet/standard/net-standard?tabs=net-standard-2-0) as a target framework which allows you to use them in .NET Framework and any new .NET projects. All Structr components have few or no external dependencies.

[![Build Status](https://ci.appveyor.com/api/projects/status/github/askalione/structr?branch=master&svg=true)](https://ci.appveyor.com/project/askalione/structr)
[![CodeFactor](https://www.codefactor.io/repository/github/askalione/structr/badge)](https://www.codefactor.io/repository/github/askalione/structr) 
[![GitHub license](https://img.shields.io/github/license/askalione/structr)](https://github.com/askalione/Structr/blob/master/LICENSE)
[![Join the chat at https://gitter.im/Structr-dotnet/community](https://badges.gitter.im/Structr-dotnet/community.svg)](https://gitter.im/Structr-dotnet/community?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)  

## Packages

| Package name | NuGet | Downloads | Docs |
| --- | --- | --- |
| Structr.Abstractions | [![NuGet Structr.Abstractions](https://img.shields.io/nuget/v/Structr.Abstractions)](https://www.nuget.org/packages/Structr.Abstractions/) | [![Downloads Structr.Abstractions](https://img.shields.io/nuget/dt/Structr.Abstractions)](https://www.nuget.org/stats/packages/Structr.Abstractions?groupby=Version) | [![Documentation Structr.Abstractions](https://img.shields.io/badge/%20-docs-blue)](https://github.com/askalione/Structr/blob/master/docs/Abstractions/Abstractions.md) |
| Structr.AspNetCore | [![NuGet Structr.AspNetCore](https://img.shields.io/nuget/v/Structr.AspNetCore)](https://www.nuget.org/packages/Structr.AspNetCore/) | [![Downloads Structr.AspNetCore](https://img.shields.io/nuget/dt/Structr.AspNetCore)](https://www.nuget.org/stats/packages/Structr.AspNetCore?groupby=Version) | [![Documentation Structr.AspNetCore](https://img.shields.io/badge/%20-docs-blue)](https://github.com/askalione/Structr/blob/master/docs/AspNetCore/AspNetCore.md) |
| Structr.AspNetCore.Validation | [![NuGet Structr.AspNetCore.Validation](https://img.shields.io/nuget/v/Structr.AspNetCore.Validation)](https://www.nuget.org/packages/Structr.AspNetCore.Validation/) | [![Downloads Structr.AspNetCore.Validation](https://img.shields.io/nuget/dt/Structr.AspNetCore.Validation)](https://www.nuget.org/stats/packages/Structr.AspNetCore.Validation?groupby=Version) | [![Documentation Structr.AspNetCore.Validation](https://img.shields.io/badge/%20-docs-blue)](https://github.com/askalione/Structr/blob/master/docs/AspNetCore/AspNetCore.Validation.md) |
| Structr.Collections | [![NuGet Structr.Collections](https://img.shields.io/nuget/v/Structr.Collections)](https://www.nuget.org/packages/Structr.Collections/) | [![Downloads Structr.Collections](https://img.shields.io/nuget/dt/Structr.Collections)](https://www.nuget.org/stats/packages/Structr.Collections?groupby=Version) | [![Documentation Structr.Collections](https://img.shields.io/badge/%20-docs-blue)](https://github.com/askalione/Structr/blob/master/docs/Collections/Collections.md) |
| Structr.Collections.Extensions.AutoMapper | [![NuGet Structr.Collections.Extensions.AutoMapper](https://img.shields.io/nuget/v/Structr.Collections.Extensions.AutoMapper)](https://www.nuget.org/packages/Structr.Collections.Extensions.AutoMapper/) | [![Downloads Structr.Collections.Extensions.AutoMapper](https://img.shields.io/nuget/dt/Structr.Collections.Extensions.AutoMapper)](https://www.nuget.org/stats/packages/Structr.Collections.Extensions.AutoMapper?groupby=Version) | [![Documentation Structr.Collections.Extensions.AutoMapper](https://img.shields.io/badge/%20-docs-blue)](https://github.com/askalione/Structr/blob/master/docs/Collections/Collections-Automapper-extensions.md) |
| Structr.Configuration | [![NuGet Structr.Configuration](https://img.shields.io/nuget/v/Structr.Configuration)](https://www.nuget.org/packages/Structr.Configuration/) | [![Downloads Structr.Configuration](https://img.shields.io/nuget/dt/Structr.Configuration)](https://www.nuget.org/stats/packages/Structr.Configuration?groupby=Version) | [![Documentation Structr.Configuration](https://img.shields.io/badge/%20-docs-blue)](https://github.com/askalione/Structr/blob/master/docs/Configuration/Configuration.md) |
| Structr.Domain | [![NuGet Structr.Domain](https://img.shields.io/nuget/v/Structr.Domain)](https://www.nuget.org/packages/Structr.Domain/) | [![Downloads Structr.Domain](https://img.shields.io/nuget/dt/Structr.Domain)](https://www.nuget.org/stats/packages/Structr.Domain?groupby=Version) | [![Documentation Structr.Domain](https://img.shields.io/badge/%20-docs-blue)](https://github.com/askalione/Structr/blob/master/docs/Domain/Domain.md) |
| Structr.Email | [![NuGet Structr.Email](https://img.shields.io/nuget/v/Structr.Email)](https://www.nuget.org/packages/Structr.Email/) | [![Downloads Structr.Email](https://img.shields.io/nuget/dt/Structr.Email)](https://www.nuget.org/stats/packages/Structr.Email?groupby=Version) | [![Documentation Structr.Email](https://img.shields.io/badge/%20-docs-blue)](https://github.com/askalione/Structr/blob/master/docs/Email/Email.md) |
| Structr.Email.Razor | [![NuGet Structr.Email](https://img.shields.io/nuget/v/Structr.Email.Razor)](https://www.nuget.org/packages/Structr.Email.Razor/) | [![Downloads Structr.Email.Razor](https://img.shields.io/nuget/dt/Structr.Email.Razor)](https://www.nuget.org/stats/packages/Structr.Email.Razor?groupby=Version) | [![Documentation Structr.Email.Razor](https://img.shields.io/badge/%20-docs-blue)](https://github.com/askalione/Structr/blob/master/docs/Email/Email-Razor.md) |
| Structr.EntityFramework | [![NuGet Structr.EntityFramework](https://img.shields.io/nuget/v/Structr.EntityFramework)](https://www.nuget.org/packages/Structr.EntityFramework/) | [![Downloads Structr.EntityFramework](https://img.shields.io/nuget/dt/Structr.EntityFramework)](https://www.nuget.org/stats/packages/Structr.EntityFramework?groupby=Version) | [![Documentation Structr.EntityFramework](https://img.shields.io/badge/%20-docs-blue)](https://github.com/askalione/Structr/blob/master/docs/EntityFramework.md) |
| Structr.EntityFrameworkCore | [![NuGet Structr.EntityFrameworkCore](https://img.shields.io/nuget/v/Structr.EntityFrameworkCore)](https://www.nuget.org/packages/Structr.EntityFrameworkCore/) | [![Downloads Structr.EntityFrameworkCore](https://img.shields.io/nuget/dt/Structr.EntityFrameworkCore)](https://www.nuget.org/stats/packages/Structr.EntityFrameworkCore?groupby=Version) | [![Documentation Structr.EntityFrameworkCore](https://img.shields.io/badge/%20-docs-blue)](https://github.com/askalione/Structr/blob/master/docs/EntityFrameworkCore.md) |
| Structr.IO | [![NuGet Structr.IO](https://img.shields.io/nuget/v/Structr.IO)](https://www.nuget.org/packages/Structr.IO/) | [![Downloads Structr.IO](https://img.shields.io/nuget/dt/Structr.IO)](https://www.nuget.org/stats/packages/Structr.IO?groupby=Version) | [![Documentation Structr.IO](https://img.shields.io/badge/%20-docs-blue)](https://github.com/askalione/Structr/blob/master/docs/IO/IO.md) |
| Structr.Navigation | [![NuGet Structr.Navigation](https://img.shields.io/nuget/v/Structr.Navigation)](https://www.nuget.org/packages/Structr.Navigation/) | [![Downloads Structr.Navigation](https://img.shields.io/nuget/dt/Structr.Navigation)](https://www.nuget.org/stats/packages/Structr.Navigation?groupby=Version) | [![Documentation Structr.Navigation](https://img.shields.io/badge/%20-docs-blue)](https://github.com/askalione/Structr/blob/master/docs/Navigation/Navigation.md) |
| Structr.Notices | [![NuGet Structr.Notices](https://img.shields.io/nuget/v/Structr.Notices)](https://www.nuget.org/packages/Structr.Notices/) | [![Downloads Structr.Notices](https://img.shields.io/nuget/dt/Structr.Notices)](https://www.nuget.org/stats/packages/Structr.Notices?groupby=Version) | [![Documentation Structr.Notices](https://img.shields.io/badge/%20-docs-blue)](https://github.com/askalione/Structr/blob/master/docs/Notices.md) |
| Structr.Operations | [![NuGet Structr.Operations](https://img.shields.io/nuget/v/Structr.Operations)](https://www.nuget.org/packages/Structr.Operations/) | [![Downloads Structr.Operations](https://img.shields.io/nuget/dt/Structr.Operations)](https://www.nuget.org/stats/packages/Structr.Operations?groupby=Version) | [![Documentation Structr.Operations](https://img.shields.io/badge/%20-docs-blue)](https://github.com/askalione/Structr/blob/master/docs/Operations/Operations.md) |
| Structr.Security | [![NuGet Structr.Security](https://img.shields.io/nuget/v/Structr.Security)](https://www.nuget.org/packages/Structr.Security/) | [![Downloads Structr.Security](https://img.shields.io/nuget/dt/Structr.Security)](https://www.nuget.org/stats/packages/Structr.Security?groupby=Version) | [![Documentation Structr.Security](https://img.shields.io/badge/%20-docs-blue)](https://github.com/askalione/Structr/blob/master/docs/Security.md) |
| Structr.Specifications | [![NuGet Structr.Specifications](https://img.shields.io/nuget/v/Structr.Specifications)](https://www.nuget.org/packages/Structr.Specifications/) | [![Downloads Structr.Specifications](https://img.shields.io/nuget/dt/Structr.Specifications)](https://www.nuget.org/stats/packages/Structr.Specifications?groupby=Version) | [![Documentation Structr.Specifications](https://img.shields.io/badge/%20-docs-blue)](https://github.com/askalione/Structr/blob/master/docs/Specifications.md) |
| Structr.SqlServer | [![NuGet Structr.SqlServer](https://img.shields.io/nuget/v/Structr.SqlServer)](https://www.nuget.org/packages/Structr.SqlServer/) | [![Downloads Structr.SqlServer](https://img.shields.io/nuget/dt/Structr.SqlServer)](https://www.nuget.org/stats/packages/Structr.SqlServer?groupby=Version) | ![Documentation Structr.SqlServer](https://img.shields.io/badge/%20-docs-gray) |
| Structr.Stateflows | [![NuGet Structr.Stateflows](https://img.shields.io/nuget/v/Structr.Stateflows)](https://www.nuget.org/packages/Structr.Stateflows/) | [![Downloads Structr.Stateflows](https://img.shields.io/nuget/dt/Structr.Stateflows)](https://www.nuget.org/stats/packages/Structr.Stateflows?groupby=Version) | [![Documentation Structr.Stateflows](https://img.shields.io/badge/%20-docs-blue)](https://github.com/askalione/Structr/blob/master/docs/Stateflows/Stateflows.md) |
| Structr.Validation | [![NuGet Structr.Validation](https://img.shields.io/nuget/v/Structr.Validation)](https://www.nuget.org/packages/Structr.Validation/) | [![Downloads Structr.Validation](https://img.shields.io/nuget/dt/Structr.Validation)](https://www.nuget.org/stats/packages/Structr.Validation?groupby=Version) | [![Documentation Structr.Validation](https://img.shields.io/badge/%20-docs-blue)](https://github.com/askalione/Structr/blob/master/docs/Stateflows/Validation.md) |

## Documentation

* [ASP.NET Core](docs/AspNetCore/AspNetCore.md)
    * [Validation](docs/AspNetCore/AspNetCore.Validation.md)
* [Collections](docs/Collections/Collections.md)
    * [AutoMapper extensions](docs/Collections/Collections-Automapper-extensions.md)
* [Email](docs/Email/Email.md)
    * [Razor](docs/Email/Email-Razor.md)
* [Abstractions](vAbstractions/Abstractions.md)
    * [Check](docs/Abstractions/Abstractions-Check.md)
    * [Ensure](docs/Abstractions/Abstractions-Ensure.md)
    * [HierarchyId](docs/Abstractions/Abstractions-HierarchyId.md)
    * [Money](docs/Abstractions/Abstractions-Money.md)
    * [SequentialGuid](docs/Abstractions/Abstractions-SequentialGuid.md)
    * Extensions
        * [DateTime](docs/Abstractions/Extensions/Abstractions-DateTimeExtensions.md)
        * [Dictionary](docs/Abstractions/Extensions/Abstractions-DictionaryExtensions.md)
        * [DirectoryInfo](docs/Abstractions/Extensions/Abstractions-DirectoryInfoExtensions.md)
        * [Enumerable](docs/Abstractions/Extensions/Abstractions-EnumerableExtensions.md)
        * [Enum](docs/Abstractions/Extensions/Abstractions-EnumExtensions.md)
        * [Expression](docs/Abstractions/Extensions/Abstractions-ExpressionExtensions.md)
        * [Long](docs/Abstractions/Extensions/Abstractions-LongExtensions.md)
        * [MemberInfo](docs/Abstractions/Extensions/Abstractions-MemberInfoExtensions.md)
        * [Object](docs/Abstractions/Extensions/Abstractions-ObjectExtensions.md)
        * [Queryable](docs/Abstractions/Extensions/Abstractions-QueryableExtensions.md)
        * [ServiceCollection](docs/Abstractions/Extensions/Abstractions-ServiceCollectionExtensions.md)
        * [String](docs/Abstractions/Extensions/Abstractions-StringExtensions.md)
        * [Type](docs/Abstractions/Extensions/Abstractions-TypeExtensions.md)
    * Helpers
        * [AsyncHelper](docs/Abstractions/Helpers/Abstractions-AsyncHelper.md)
        * [BindHelper](docs/Abstractions/Helpers/Abstractions-BindHelper.md)
* [Configuration](docs/Configuration/Configuration.md)
    * [Get settings](docs/Configuration/Configuration-Get-settings.md.md)
    * [Set settings](docs/Configuration/Configuration-Set-settings.md.md)
    * [Customization](docs/Configuration/Configuration-Customization.md.md)
* [Domain](docs/Domain/Domain.md)
    * [Entities](docs/Domain/Domain-Entities.md)
    * [Value objects](docs/Domain/Domain-ValueObjects.md)
* [Entity Framework 6](docs/EntityFramework.md)
* [Entity Framework Core](docs/EntityFrameworkCore.md)
* [IO](docs/IO/IO.md)
    * [FileHelper](docs/IO/IO-FileHelper.md)
    * [MimeTypeHelper](docs/IO/IO-MimeTypeHelper.md)
    * [PathHelper](docs/IO/IO-PathHelper.md)
    * [SequentialFileName](docs/IO/IO-SequentialFileName.md)
* [Navigation](docs/Navigation/Navigation.md)
    * [Menu](docs/Navigation/Navigation-Menu.md)
    * [Breadcrumbs](docs/Navigation/Navigation-Breadcrumbs.md)
* [Notices](docs/Notices.md)
* [Operations](docs/Operations/Operations.md)
    * [Filtering](docs/Operations/Operations-Filtering.md)
    * [Decoration](docs/Operations/Operations-Decoration.md)
* [Security](docs/Security.md)
* [Specifications](docs/Specifications.md)
* [Stateflows](docs/Stateflows/Stateflows.md)
    * [StateMachine](docs/Stateflows/Stateflows-StateMachine.md)
    * [Configurations](docs/Stateflows/Stateflows-Configurations.md)
* [Validation](docs/Validation.md)

## License

Structr is open source, licensed under the [MIT License](https://github.com/askalione/Structr/blob/master/LICENSE).