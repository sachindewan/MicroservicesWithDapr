start dapr run --app-id mvcfront-service --app-port 5002  --dapr-http-port 50002 --components-path "./components" -- dotnet run --project "./MvcFront/MvcFront.csproj"
start dapr run --app-id ordersapi-service --app-port 5003 --dapr-http-port 50003 --components-path "./components" -- dotnet run --project "./OrdersApi/OrdersApi.csproj" 
 start dapr run --app-id facesapi-service --app-port 5004  --dapr-http-port 50004 --components-path "./components" -- dotnet run --project "./FacesApi/FacesApi.csproj"  
 start dapr run --app-id notification-service --app-port 5005 --dapr-http-port 50005 --components-path "./components" -- dotnet run --project "./NotificationApi/NotificationApi.csproj" 


 

 