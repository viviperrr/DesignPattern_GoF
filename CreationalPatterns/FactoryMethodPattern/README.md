## Factory Method in Creational Pattern

** What's is Factory Method Pattern **

- Factory pattern determines that an object is created in a single method
- Factory Method pattern is a pattern that creates the Creator's Base class (or interface)
  and its subclasses to determine which objects to create in the subclass.

// Factory Pattern
public class LoggerFactory
{
public ILogger Create(string option)
{
switch (option)
{
case "DB": return new DbLogger();
case "XML": return new XmlLogger();
case "JSON": return new JsonLogger();
default: throw new InvalidOperationException();
}
}
}

// Factory Method Pattern
public abstract class LoggerCreator
{
public abstract ILogger Create(string option);
}

public class DbLoggerCreator : LoggerCreator
{
public override ILogger Create(string conn)
{
var logger = new DbLogger();
logger.ConnectionString = conn;
return logger;
}
}
