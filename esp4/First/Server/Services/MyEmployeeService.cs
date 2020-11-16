using Grpc.Core;
using Microsoft.Extensions.Logging;
using Server.Data;
using Server.Protos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Server.Protos.EmployeeService;

namespace Server.Services
{
    public class MyEmployeeService : EmployeeServiceBase
    {
        private readonly ILogger<MyEmployeeService> _logger;
        
        public MyEmployeeService(ILogger<MyEmployeeService> logger)
        { 
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public override Task<EmployeeResponse> GetByNo(GetByNoRequest request, ServerCallContext context)
        {
            var md = context.RequestHeaders;
            foreach(var pair in md)
            {
                _logger.LogWarning($"{pair.Key} : {pair.Value}");
            }

            var employee = InMemoryData.Employees.SingleOrDefault(x => x.No == request.No);

            if(employee != null)
            {
                var response = new EmployeeResponse
                { 
                    Employee = employee
                };

                return Task.FromResult(response);
            }

            throw new Exception("Employee is not found.");
        }
    }
}
