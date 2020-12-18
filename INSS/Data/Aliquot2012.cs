using INSS.Model;
using System.Collections.Generic;

namespace INSS.Data
{
    public class Aliquot2012 : IAliquot
    {
        public List<AliquotModel> Table { get; set; }

        public decimal MaxValue { get; set; }
        public Aliquot2012()
        {
            Table = new List<AliquotModel>();
            Table.Add(new AliquotModel() { Limit = 1000, Percentage = 7 });
            Table.Add(new AliquotModel() { Limit = 1500, Percentage = 8 });
            Table.Add(new AliquotModel() { Limit = 3000, Percentage = 9 });
            Table.Add(new AliquotModel() { Limit = 4000, Percentage = 11 });

            MaxValue = 500;
        }
    }
}
