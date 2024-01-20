using NuGet.Protocol.Core.Types;
using NuGet.Versioning;

namespace NugetSaver.Domain.Entities;

public sealed record Library(string Id, NuGetVersion Version, SourceRepository Repository);