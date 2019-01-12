# design-patterns
This repository contains a bunch of simple design patterns examples.

## Mediator
Event-driven chat-room implementations
Every user can send a message to the ChatBox, which then broadcasts it to the remaining users.

## Chain Of Responsibility
Simulator of an ATM that accepts an amount in dollars and in cents and then prints out the minimum
number of bills / coins and their respective values needed to match the given amount.

## Builder
A scalable tool allowing the user to create reports of different types: XML reports and JSON reports.
The user may also specify what information needs to be included in the report.

## Composite
A program used to send notifications to customers. Each customer can either be "simple", meaning a physical person with an inbox, or "composite",
that is, composed of a group of simple and/or composite customers.
This program wraps each type of customer with a common interface and hides the implementation from the process of sending notifications.

## Iterator
This application consists of User objects and ChatRoom objects. Each user can join a nubmer of ChatRooms. Also, users are able to set their
global status: visible or hidden.
One can only iterate through the users in a chatroom, using special Iterator objects for the specific ChatRoom.
The Iterator only caters for visible users.

## Singleton
This project consists of a singleton Logger class which caters for writing information to a file and a set of worker classes.
The worker classess calculate a certain number of the harmonic series
#### H_n = 1 + 1/2 + 1/3 + 1/4 + ... + 1/n
and then write information about their execution
to a file, using the previously mentioned logger.

*NOTICE* This implementation of Singleton is not thread safe.

## Thread Safe Singleton
The `ConsoleLogger` is a singleton class, which stores a counter and can log its value, together with the hash of the current object
instance, to the console. Multiple threads are fetching an instance of the logger and calling its method. Because of enhanced 
singleton constructor (prior to the previous example) only one instance is ever created.

## Adapter
We have an existing interface `ISquare` which provides two methods: `GetArea()` and `GetPerimeter()`. We need to work with
a legacy class `StrangeSquare` with one method: `GetDiagonal()`.
An adapter is used to match the interface of the square with `IShape`.

## Decorator
We have a class responsible of processing and displaying messages: `MessageChannel`. This example provides an interface for extending (decorating) the
message preparation process. `TrimmedMessageChannel` and `CensoredMessageChannel` augment the way messages are processed. Because of applied layers
of abstraction, it is easy to add more decorator implementations.

## State
This application is a simulation of a simple ATM which can function in any of these states: `NoCard`, `CardEntered`. `PINEnterd`, `NoMoney`.
Depending on the current state of the `ATM` object, its behavior changes respectively.
Different operations are allowed and are implemented in a different way.