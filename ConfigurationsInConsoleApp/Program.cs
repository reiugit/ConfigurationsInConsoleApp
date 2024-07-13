using ConfigurationsInConsoleApp;
using Microsoft.Extensions.Configuration;

var configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .Build()
    .GetSection("ParentSettings");

// 1.) Using the options pattern (strongly typed configuration)
var parentSettings = configuration.Get<ParentSettings>();

Console.WriteLine("\n1.) Using the options pattern (strongly typed configuration):\n");
Console.WriteLine($"    * via options object:  {parentSettings?.ChildrenSettings?.ChildrenList?[0]}");

// 2.) Reading the configuration-section directly:
Console.WriteLine("\n\n2.) Reading the configuration-section directly:\n");
Console.WriteLine($"    * via GetSection(key).Value:  {configuration.GetSection("ChildrenSettings:ChildrenList:0").Value}");
Console.WriteLine($"    * via GetValue(key):  {configuration.GetValue<string>("ChildrenSettings:ChildrenList:1")}");
Console.WriteLine($"    * via Indexer:  {configuration["ChildrenSettings:ChildrenList:2"]}");

Keyhandler.WaitForKey();
