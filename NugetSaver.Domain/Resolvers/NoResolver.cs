using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetSaver.Domain.Resolvers;

internal sealed class NoResolver : LibraryAbstractResolver
{
    public override void Execute(ResolveOptions options)
    {
        throw new NotImplementedException();
    }
}