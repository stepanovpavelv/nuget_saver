using System;
namespace NugetSaver.Domain.Resolvers;

internal abstract class LibraryAbstractResolver
{
    public abstract void Execute(ResolveOptions options);
}