using INSS.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace INSS
{
    public class CalculadorInss : ICalculadorInss
    {
        private readonly IAliquotService _aliquotService;

        public CalculadorInss(IAliquotService aliquotService)
        {
            _aliquotService = aliquotService;
        }

        public decimal CalcularDesconto(DateTime data, decimal salario)
        {
            if (salario == 0) return 0;

            IAliquot aliquotTable = _aliquotService.GetAliquot(data);

            if (aliquotTable != null)
            {
                decimal minValue = 0;
                for (int i = 0; i < aliquotTable.Table.Count; i++)
                {
                    var result = aliquotTable.Table.Where(a => salario > minValue && salario <= a.Limit).FirstOrDefault();

                    if (result != null)
                    {
                        return (decimal)result.Percentage * salario / 100;
                    }
                    else
                    {
                        minValue = aliquotTable.Table[i].Limit;
                    }
                }

                return aliquotTable.MaxValue;
            }
            else
            {
                throw new Exception(string.Format("Table of the year {0} not available!", data.Year));
            }
        }
    }
}
