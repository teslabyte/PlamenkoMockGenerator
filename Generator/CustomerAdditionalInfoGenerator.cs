using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlamenkoMockGenerator.Generator
{
    internal class CustomerAdditionalInfoGenerator
    {
        string additionalInfoTemplateTemp = "Isporuka izmedju ";

        public string GenerateCustomerAdditionalInfo()
        {
            Random rnd = new Random();
            int before = rnd.Next(7, 13);
            int after = rnd.Next(13, 22);

            return additionalInfoTemplateTemp + before + ".00 - " + after + ".00";
        }
    }
}
