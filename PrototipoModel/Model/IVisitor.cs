using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace POSsys.Model
{
    public interface IVisitor
    {
        void Visit(Evento evento);
    }
}
