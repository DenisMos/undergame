using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.sripts.Interfaces
{
    /// <summary>Интефрейс блокирования.</summary>
    public interface IBlockable
    {
        void Block();

        void Unblock();
    }
}
