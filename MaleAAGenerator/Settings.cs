using System.Collections.Generic;
using Mutagen.Bethesda.Plugins;

namespace MaleAAGenerator
{
    public record Settings
    {
        public List<ModKey> TargetMods = new List<ModKey>();
        public string Suffix = "_m";
        public bool patchCirclets = false;
        public bool patchHelmets = true;
        public bool patchFirstPerson = true;
        public bool deleteFirstPerson = false;
    }
}