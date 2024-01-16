using FP.Patterns.Factory.Exercice3;

ConsoleLoggerFactory consoleLogFactory = new();
FileLoggerFactory fileLogFactory = new();
DatabaseLoggerFactory databaseLogFactory = new();

ILogger consoleLogger = consoleLogFactory.CreateLogger();
ILogger fileLoggger = fileLogFactory.CreateLogger();
ILogger databaseLogger = databaseLogFactory.CreateLogger();

string msg = "This is an important message";
consoleLogger.LogMessage(msg);
fileLoggger.LogMessage(msg);
databaseLogger.LogMessage(msg);