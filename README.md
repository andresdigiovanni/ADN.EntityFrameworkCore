# Entity Framework Core Utils Library for .NET

ADN.EntityFrameworkCore is a cross-platform open-source library which provides entity framework core utilities to .NET developers.

[![Build Status](https://travis-ci.org/andresdigiovanni/ADN.EntityFrameworkCore.svg?branch=master)](https://travis-ci.org/andresdigiovanni/ADN.EntityFrameworkCore)
[![NuGet](https://img.shields.io/nuget/v/ADN.EntityFrameworkCore.svg)](https://www.nuget.org/packages/ADN.EntityFrameworkCore/)
[![BCH compliance](https://bettercodehub.com/edge/badge/andresdigiovanni/ADN.EntityFrameworkCore?branch=master)](https://bettercodehub.com/)
[![Maintainability Rating](https://sonarcloud.io/api/project_badges/measure?project=andresdigiovanni_ADN.EntityFrameworkCore&metric=sqale_rating)](https://sonarcloud.io/dashboard?id=andresdigiovanni_ADN.EntityFrameworkCore)
[![Quality](https://sonarcloud.io/api/project_badges/measure?project=andresdigiovanni_ADN.EntityFrameworkCore&metric=alert_status)](https://sonarcloud.io/dashboard?id=andresdigiovanni_ADN.EntityFrameworkCore)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

## Basic usage

Insert or update an element in a database.

```csharp
IPersonRepository sut = GetInMemoryPersonRepository();
Person person = new Person()
{
    PersonId = 1,
    FirstName = "Luke",
    Surname = "Skywalker",
};
sut.Add(person);

Person savedPerson = sut.GetAll().FirstOrDefault();

Assert.Equal(1, sut.GetAll().Count);
Assert.Equal("Luke", savedPerson.FirstName);
Assert.Equal("Skywalker", savedPerson.Surname);
```

## Installation

ADN.EntityFrameworkCore runs on Windows, Linux, and macOS.

Once you have an app, you can install the ADN.EntityFrameworkCore NuGet package from the NuGet package manager:

```
Install-Package ADN.EntityFrameworkCore
```

Or alternatively you can add the ADN.EntityFrameworkCore package from within Visual Studio's NuGet package manager.

## Examples

Please find examples and the documentation at the [wiki](https://github.com/andresdigiovanni/ADN.EntityFrameworkCore/wiki) of this repository.

## Contributing

We welcome contributions! Please review our [contribution guide](CONTRIBUTING.md).

## License

ADN.EntityFrameworkCore is licensed under the [MIT license](LICENSE).
