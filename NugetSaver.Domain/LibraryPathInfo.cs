using NuGet.Versioning;

namespace NugetSaver.Domain;

public sealed class LibraryPathInfo(string directory)
{
    public required string Root { get; init; } = directory;

    public bool PackageExists(string id, NuGetVersion version)
    {
        return File.Exists(GetFullNuGetPackagePath(id, version)) || Directory.Exists(GetNuGetHierarchicalPath(id, version));
    }

    public string GetFullNuGetPackagePath(string id, NuGetVersion version)
    {
        return Path.Combine(Root, $"{id}.{version}.nupkg".ToLower());
    }

    private string GetNuGetHierarchicalPath(string id, NuGetVersion version)
    {
        return Path.Combine(Root, id.ToLower(), version.ToString());
    }

    private void CreateDirectoryIfNotExists(string root)
    {
        if (!string.IsNullOrWhiteSpace(root) && Directory.Exists(root))
        {
            return;
        }

        if (!Directory.Exists(root))
        {
            Directory.CreateDirectory(root);
        }
    }
}