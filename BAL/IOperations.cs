using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public interface IOperations
    {
        OperationResponse Add(OperationRequest request);

        OperationResponse Subtraction(OperationRequest request);
        
        OperationResponse Multiplication(OperationRequest request);
       
        OperationResponse Division(OperationRequest request);
    }
}
