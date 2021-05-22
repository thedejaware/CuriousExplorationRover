using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CER.Application.Contracts
{
    public interface IPosition
    {
        // X-coordinate
        int X { get; set; }
        
        //Y-coordinate
        int Y { get; set; }
    }
}
