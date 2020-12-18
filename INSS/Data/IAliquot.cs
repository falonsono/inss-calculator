using INSS.Model;
using System.Collections.Generic;

namespace INSS.Data
{
    public interface IAliquot
    {
        List<AliquotModel> Table { get; set; }

        decimal MaxValue { get; set; }
    }
}
