namespace NugetSaver.Domain.Resolvers;

internal sealed class ConcreteResolver : LibraryAbstractResolver
{
    public override void Execute(ResolveOptions options)
    {
        ArgumentNullException.ThrowIfNull(options, nameof(options));
        ArgumentNullException.ThrowIfNull(options.Id, nameof(options.Id));
        ArgumentNullException.ThrowIfNull(options.Version, nameof(options.Version));
    }
}