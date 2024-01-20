namespace NugetSaver.Domain.Entities;

public sealed class LibrarySearchOptions
{
    public required List<string> Sources { get; set; }

    public bool AllowPrerelease { get; set; }

    public bool AllowUnlisted { get; set; }
}