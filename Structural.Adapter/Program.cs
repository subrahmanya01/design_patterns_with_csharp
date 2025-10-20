using Microsoft.Extensions.DependencyInjection;
using Structural.Adapter;

var serviceCollection = new ServiceCollection();

serviceCollection.AddSingleton<IEmployeeInfoProcessor, EmployeeInfoProcessor>();
serviceCollection.AddSingleton<IEmployeeManager, EmployeeManager>();
serviceCollection.AddSingleton<IEmployeeFormatAdapter, EmployeeFormatAdapter>();

var builder = serviceCollection.BuildServiceProvider();

var adapter = builder.GetRequiredService<IEmployeeFormatAdapter>();

var employeeProcessor = builder.GetRequiredService<IEmployeeInfoProcessor>();

employeeProcessor.ProcessEmployeeExpenseClaims(adapter.GetEmployees());

