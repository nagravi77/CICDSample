using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class Operations : IOperations
    {

        public OperationResponse Add(OperationRequest request)
        {
            var response = new OperationResponse();
            response.Result = request.Number1 + request.Number2;
            return response;
        }

        public OperationResponse Subtraction(OperationRequest request)
        {
            var response = new OperationResponse();
            if (request.Number1 < request.Number2)
            {
                response.Result = request.Number2 - request.Number1;
            }
            else if (request.Number1 > request.Number2)
            {
                response.Result = request.Number1 - request.Number2;
            }
            else
            {
                response.Result = 0;
            }
            return response;
        }

        public OperationResponse Multiplication(OperationRequest request)
        {
            var response = new OperationResponse();
            response.Result = request.Number2 * request.Number1;
            return response;
        }

        public OperationResponse Division(OperationRequest request)
        {
            var response = new OperationResponse();
            response.Result = request.Number1 / request.Number2;
            return response;
        }
    }
}
