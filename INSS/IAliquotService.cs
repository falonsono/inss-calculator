using INSS.Data;
using System;

namespace INSS
{
    public interface IAliquotService
    {
        IAliquot GetAliquot(DateTime date);
    }
}
