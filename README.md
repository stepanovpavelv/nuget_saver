# NugetSaver

NugetSaver gives you the ability to download NuGet packages from nuget.org or
any additional source with all transitive dependencies to your computer for offline use.

Supported platforms: Windows, macOS and Linux.

## Usage

Check `NugetSaver --help` for usage options.

There are next options for all NugetSaver's modes:
1) --source - additional sources for search Nuget packages;
2) --allowPrerelease - lets you search and download pre-release versions of packages;
3) --allowUnlisted - lets you search and install versions of packages that are at unlisted on the server (for example, at NuGet website);
4) --background - option allows you not to gives all messages during NugetSaver's work;
5) --framework - lets you indicate target framework for which package will be downloaded.

### Save a single NuGet package with all dependencies

```shell
NugetSaver download library "Newtonsoft.Json@12.0.3" --output "C:\path\to\my-offline-storage"
```

The command above will bring all packages that Newtonsoft.Json depend on, and if there are
any duplicates, they will be ignored. NugetSaver checks for existing `.nupkg` files.

The combination of NugetSaver and NuGet.Server gives you the ability to download all
packages needed on your laptop or workstation for offline use where the Internet connection is absent.

### Save multiple NuGet packages from a `.csproj` file

```shell
NugetSaver download project "C:\path\to\project.csproj" --output "C:\path\to\my-offline-storage"
```

### Save multiple NuGet packages from an `.sln` file

```shell
NugetSaver download solution "C:\path\to\solution.sln" --output "C:\path\to\my-offline-storage"
```

### Save multiple NuGet packages from several `.sln` files

```shell
NugetSaver download solutions "C:\path\to\solution1.sln,C:\path\to\solution2.sln,..." --output "C:\path\to\my-offline-storage"
```

### Restore and build a solution using NugetSaver offline cache

```shell
cd C:\path\to\my-solution
dotnet restore --source C:\path\to\my-offline-storage
dotnet build --no-restore
```

## Install

Published application is not needed for .NET 8 so you may choose self-contained deployment mode.
Add the binary to the path. Enjoy the app!

## Build

Build `NugetSaver.sln` .

Don't forget to add the location of `NugetSaver.exe` or `NugetSaver` to the `$PATH`.

.NET 8 is needed to build and run NugetSaver.