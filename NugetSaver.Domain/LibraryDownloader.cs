using NuGet.Common;
using NuGet.Packaging;
using NuGet.Protocol;
using NuGet.Protocol.Core.Types;
using NuGet.Versioning;

namespace NugetSaver.Domain;

internal sealed class LibraryDownloader
{
    // TODO: удалить выводы в консоль (теги и описание)
    // сделать класс для параметров
    // добавить AllowPrerelease и Unlisted

    public async Task Download(string source, string outputPath, string packageId, string version)
    {
        ILogger logger = NullLogger.Instance;
        CancellationToken cancellationToken = CancellationToken.None;

        SourceCacheContext cache = new();
        SourceRepository repository = Repository.Factory.GetCoreV3(source);
        FindPackageByIdResource resource = await repository.GetResourceAsync<FindPackageByIdResource>();

        NuGetVersion packageVersion = new(version);
        using FileStream packageStream = File.OpenWrite(outputPath);

        await resource.CopyNupkgToStreamAsync(
            packageId,
            packageVersion,
            packageStream,
            cache,
            logger,
            cancellationToken);

        Console.WriteLine($"Downloaded package {packageId} {packageVersion}");

        using PackageArchiveReader packageReader = new(packageStream);
        NuspecReader nuspecReader = await packageReader.GetNuspecReaderAsync(cancellationToken);

        //Console.WriteLine($"Tags: {nuspecReader.GetTags()}");
        //Console.WriteLine($"Description: {nuspecReader.GetDescription()}");
    }
}