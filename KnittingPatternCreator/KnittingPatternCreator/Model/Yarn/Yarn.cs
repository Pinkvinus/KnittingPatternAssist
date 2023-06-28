using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnittingPatternCreator.Model
{
    class Yarn
    {
        private int Needlesize { get; }
        private int Hooksize { get; }
        private string Name { get; }
        private string Producername { get; }
        private YarnMaterial[] Materials { get; }

        public Yarn(int needlesize, int hooksize, string name, string producername, YarnMaterial[] materials)
        {
            Needlesize = needlesize;
            Hooksize = hooksize;
            Name = name;
            Producername = producername;

            if (materials.Length != 0)
            {
                Materials = materials;
            }
            else
            {

            }
        }
    }
}