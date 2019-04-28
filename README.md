# CatlogAPI
Its a demo project that demonstrate the process of using Ocelot Gateway as a gateway to access multiple isolated microservices in SOA. 

Steps to follow.
1. Create multiple API projects, host them in different ports. in my case i have created 2 API's one CatlogAPI and other OrdersAPI with ports 7001 and 7002 respectively.
2. Add another API project. This is as a Gateway through which you are going to access other two API's.In my case i've named it GatewayAPI with port 7000.
3. Now need to add Ocelot from nudget packages in Gateway API.
4. Add a configuration file to GatewayAPI i.e. Ocelot.json in my case, which is a central part that helps on routing of your requests.
  It consists of ReRoutes and Globalconfigurations. ReRoutes includes the connection properties of multiple APIs which will be routed through our main gateway API and GlobalCOnfiguration contains our main Gateway URl i.e. BaseUrl
5. Now need to add ocelot Middleware.
  for Program.cs add configuration for ocelot
            .ConfigureAppConfiguration((hostingContext, config) =>
            {
                // Informs the app to use the ocelot.json file
                config.AddJsonFile("Ocelot.json");
            })  
  
  for startup.cs
      add  services.AddOcelot(); on ConfigureServices() method.
      add 
            // Includes Ocelot middleware.
            app.UseOcelot().Wait();
    on Configure method.
 6. This conmpletes the basic configuration process of OcelotGateway.
 Check, Test, and add additional properties for betterment of this demo version.
 Hope you guys will updates with better solutions.
 
