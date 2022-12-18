### Table of Contents
- [What are Design Patterns ?](#what-are-design-patterns-)
  - [Creational design patterns](#creational-design-patterns)
  - [Structural design patterns](#structural-design-patterns)
  - [Behavioral design patterns](#behavioral-design-patterns)
## What are Design Patterns ?
Design patterns are reusable solutions to common problems in software design. They are a way of documenting and sharing knowledge about the most effective ways to design software systems. Design patterns can be classified into three main categories: creational, structural, and behavioral.

### Creational design patterns
Deal with object creation mechanisms, trying to create objects in a manner suitable to the situation.

These patterns help to create objects in a flexible and efficient manner, and can be useful in situations where the exact type of object that needs to be created is not known at compile time, or when the cost of creating a new object is high.

  - #### The factory pattern
    provides an interface for creating objects in a super class, but allows subclasses to alter the type of objects that will be created.

  - #### The abstract factory pattern
    provides an interface for creating families of related or dependent objects without specifying their concrete classes.

  - #### The builder pattern
    separates the construction of a complex object from its representation, allowing the same construction process to create various representations.

  - #### The prototype pattern
    allows new objects to be created by copying existing objects.

  - #### The singleton pattern
    ensures that a class has only one instance, and provides a global point of access to it.

### Structural design patterns
Deal with object composition, creating relationships between objects to form larger structures.

These patterns help to structure objects and classes in a flexible and efficient manner, and can be useful in situations where the relationships between objects need to be dynamic or where the implementation details of a system need to be abstracted and hidden.

  - #### The adapter pattern
    allows you to use an existing class in a system, even if its interface is incompatible with the rest of the system.

  - #### The bridge pattern
    separates an abstraction from its implementation, allowing the two to vary independently.

  - #### The composite pattern
    allows you to compose objects into tree structures, and treat individual objects and compositions of objects uniformly.

  - #### The decorator pattern
    allows you to add new behavior to existing objects dynamically, by wrapping them in a decorator object.

  - #### The facade pattern 
    provides a simplified interface to a complex system, hiding its internal complexity and allowing you to work with it more easily.

  - #### The flyweight pattern
    allows you to efficiently share data and resources among objects, by creating shared objects that can be used by multiple objects instead of creating a new object each time.

  - #### The proxy pattern
    provides a surrogate or placeholder for another object, allowing you to control access to that object.

### Behavioral design patterns
Focus on communication between objects, what goes on between objects and how they operate together.
These patterns help to define the communication between objects, and can be useful in situations where you need to decouple objects from each other, or where the behavior of an object needs to be dynamic and flexible.

  - #### The chain of responsibility pattern
    allows you to pass requests along a dynamic chain of objects, with each object having the option to handle the request or pass it along to the next object in the chain.

  - #### The command pattern 
    allows you to encapsulate a request as an object, allowing you to parametrize clients with different requests, queue or log requests, and support undoable operations.

  - #### The interpreter pattern 
    allows you to define a grammar for a simple language, and use it to interpret sentences in that language.

  - #### The iterator pattern 
    allows you to access the elements of an object sequentially, without exposing its underlying representation.

  - #### The mediator pattern 
    allows you to define an object that encapsulates how a set of objects interact, allowing you to change the interactions independently.

  - #### The memento pattern 
    allows you to capture the internal state of an object, store it externally, and restore it later.

  - #### The observer pattern 
    allows you to define a one-to-many dependency between objects, such that when one object changes state, all of its dependents are notified and updated automatically.

  - #### The state pattern 
    allows you to encapsulate state-dependent behavior, allowing an object to change its behavior when its internal state changes.

  - #### The strategy pattern 
    allows you to define a family of algorithms, encapsulate each one as an object, and make them interchangeable.

  - #### The template method pattern 
    allows you to define the skeleton of an algorithm, deferring some steps to subclasses.

  - #### The visitor pattern 
    allows you to separate an algorithm from an object structure, by moving the algorithm into a separate class with a visit method for each element in the object structure.