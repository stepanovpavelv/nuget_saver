using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NugetSaver.Domain.Entities
{
    public sealed class LibrarySettings
    {
        public required Library Package { get; set; }
    }
}