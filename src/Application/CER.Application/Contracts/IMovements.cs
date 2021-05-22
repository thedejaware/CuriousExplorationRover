using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CER.Application.Contracts
{
    public interface IMovements
    {
        void MoveForward();
        void Spin90Left();
        void Spin90Right();
    }
}
