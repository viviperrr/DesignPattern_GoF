## Singleton in Creational Pattern

** What's is Singleton Pattern **

- The Singleton allows a class to have only one instance.
- A pattern that gives access to an instacne in the Global Scope.

public sealed class BasicSingleton
{
public static readonly BasicSingleton instantce = new BasicSingleton();
private BasicSingleton() { /_ ... _/ }
}
