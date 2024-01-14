using NuGet.Versioning;
using NuGet.Protocol.Core.Types;

namespace NugetSaver.Domain;

public sealed record Library(string Id, NuGetVersion Version, SourceRepository Repository);