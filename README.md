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