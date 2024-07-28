// Create factory instances
using FP.Patterns.Factory.Exercice8;

ILoggerFactory fileLoggerFactory = new FileLoggerFactory();
ILoggerFactory consoleLoggerFactory = new ConsoleLoggerFactory();
ILoggerFactory databaseLoggerFactory = new DatabaseLoggerFactory();

// Create logger instances using factories
ILogger fileLogger = fileLoggerFactory.CreateLogger();
ILogger consoleLogger = consoleLoggerFactory.CreateLogger();
ILogger databaseLogger = databaseLoggerFactory.CreateLogger();

// Log messages using different loggers
fileLogger.Log();
consoleLogger.Log();
databaseLogger.Log();