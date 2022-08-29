using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PokeFusionApp
{
    public interface IEmbeddedResourceQuery
    {
        Stream? Read<T>(string resource);
        Stream? Read(Assembly assembly, string resource);
        Stream? Read(string assemblyName, string resource);
    }
}
