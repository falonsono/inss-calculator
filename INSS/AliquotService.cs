using INSS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS
{
    public class AliquotService : IAliquotService
    {
        private readonly Dictionary<int, IAliquot> _tables = new Dictionary<int, IAliquot>();
        
        public AliquotService()
        {
            _tables.Add(2011, new Aliquot2011());
            _tables.Add(2012, new Aliquot2012());
        }
        
        public IAliquot GetAliquot(DateTime date)
        {
            return _tables.ContainsKey(date.Year) ? _tables[date.Year] : null;
        }
    }
}
