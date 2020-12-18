using INSS.Model;
using System.Collections.Generic;

namespace INSS.Data
{
    public class Aliquot2011 : IAliquot
    {
        public List<AliquotModel> Table { get; set; }

        public decimal MaxValue { get; set; }
        public Aliquot2011()
        {
            Table = new List<AliquotModel>();
            Table.Add(new AliquotModel() { Limit = 1196.90m, Percentage = 8 });
            Table.Add(new AliquotModel() { Limit = 1844.83m, Percentage = 9 });
            Table.Add(new AliquotModel() { Limit = 3689.66m, Percentage = 11 });

            MaxValue = 405.86m;
        }
    }
}
