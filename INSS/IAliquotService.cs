using INSS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS
{
    public interface IAliquotService
    {
        IAliquot GetAliquot(DateTime date);
    }
}
