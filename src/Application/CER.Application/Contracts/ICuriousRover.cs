using CER.Application.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CER.Application.Contracts
{
    public interface ICuriousRover
    {
        IPlateau Plateau { get; set; }
        IPosition Position { get; set; }
        Directions Facing { get; set; }

        void StartMoving(string letters);
        void CheckBoundary();
        string GetCurrentPosition();
    }
}
