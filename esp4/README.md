# gRPC in ASP.NET Core


<br><br><br>


## Demo 結構
___
gRPC Server: ASP.NET Core <br>
gRPC Client: .NET Core (Console)

1. Server 要安裝一個 package
    > Grpc.AspNetCore

1. client 要安裝三個 package
    > Grpc.Net.Client <br>
    > Google.Protobuf <br>
    > Grpc.Tools


<br><br><br >

## Server 端
___
1. **安裝 package**
    > Grpc.AspNetCore   

1. **寫 proto 文件**
    ```proto
    syntax = "proto3";

    option csharp_namespace = "Server.Protos";

    message Employee {
        int32 id = 1;
        int32 no = 2;
        string firstName = 3;
        string lastName = 4;
        float salary = 5;
    }

    message GetByNoRequest {
        int32 no = 1;
    }

    message EmployeeResponse {
        Employee employee = 1;

    }

    message GetAllRequest {

    }

    message AddPhotoRequest {
        bytes data = 1;
    }

    message AddPhotoResponse {
        bool isOk = 1;
    }

    message EmployeeRequest {
        Employee employee = 1;
    }

    // 
    // 重點在這裡
    // DotNet Core 會為這個 service 建立一個 EmployeeServiceBase Class
    // 在這個 Class 裡面, 每一個 rpc 都會有一個相對應的 handler method 可以被 override
    //
    service EmployeeService {
        // 單一響應
        rpc GetByNo(GetByNoRequest) returns (EmployeeResponse);

        // service streaming
        rpc GetAll(GetAllRequest) returns (stream EmployeeResponse);

        // client streaming
        rpc AddPhoto(stream AddPhotoRequest) returns (AddPhotoResponse);

        // 雙向 streaming
        rpc SaveAll(stream EmployeeRequest) returns (stream EmployeeResponse);

        rpc Save(EmployeeRequest) returns (EmployeeResponse);
    }
    ```
1. **build 一下 dotnet core 程序, 在 build 修改一下 protoco 文件的屬性**
    - Build Action : Protobuf Compiler

1. **建立一個服務器 derivde from EmployeeServiceBase**
    ```c#
    public class MyEmployeeService : EmployeeServiceBase
    {
        private readonly ILogger<MyEmployeeService> _logger;
        
        public MyEmployeeService(ILogger<MyEmployeeService> logger)
        { 
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        // rpc handler
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
    ```

1.  **Regsiter the grpc service**
    ```c#
    services.AddGrpc();
    ```

1. **Map the grpc message to grpc service**
    ```c#
    app.UseEndpoints(endpoints =>
    {
        endpoints.MapGrpcService<MyEmployeeService>();
    });
    ```

<br><br><br>

## Client 端
___
1. 安裝 package
    > Grpc.Net.Client <br>
    > Google.Protobuf <br>
    > Grpc.Tools

1. 寫代碼
```c# 
var md = new Metadata
{
    { "username" , "po" },
    { "role", "administrator" }
};



using (var channel = GrpcChannel.ForAddress("https://localhost:5001"))
{
    var client = new EmployeeService.EmployeeServiceClient(channel);

    var response = await client.GetByNoAsync(new GetByNoRequest
    {
        No = 1994
    },md);


    Console.WriteLine($"Response message = {response}");
}
```