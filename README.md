# TempreatureAlarmPubSubPatten

## Overview
**TempreatureAlarmPubSubPatten** is a simple educational C# application that demonstrates the **Publish–Subscribe (Pub/Sub) design pattern**.  
The program simulates a temperature monitoring system where **publishers** send temperature updates and **subscribers** react to them—such as triggering alarms when certain conditions are met.

This example is intended for developers learning about **loose coupling** in software design.

---

## What is the Publish–Subscribe Pattern?

The **Publish–Subscribe** pattern is a messaging design pattern that decouples message senders (**publishers**) from message receivers (**subscribers**) via a message broker or event bus.  
Publishers do not know who will receive their messages, and subscribers decide what messages they want to receive.

### Key Benefits:
- **Loose Coupling:** Publishers and subscribers are independent.
- **Scalability:** Multiple subscribers can respond to the same event without changing the publisher's code.
- **Flexibility:** Easy to add/remove subscribers without affecting other parts of the system.
- **Asynchronous or Synchronous:** Can be implemented either way depending on the use case.

---

## Project Structure

├── Publisher
│ └── TemperatureSensor.cs # Publishes temperature readings
├── Subscriber
│ ├── AlarmSubscriber.cs # Triggers alarm if temperature exceeds a threshold
│ └── DisplaySubscriber.cs # Displays temperature readings
├── EventBus.cs # Manages subscriptions and event distribution
└── Program.cs # Entry point



---

## How It Works

1. **Publisher (TemperatureSensor)**  
   - Reads temperature data (simulated in this project).  
   - Publishes updates to the event bus.

2. **Event Bus**  
   - Keeps track of all subscribers for different events.  
   - Forwards published events to the relevant subscribers.

3. **Subscribers**  
   - **AlarmSubscriber**: Raises an alarm if the temperature is above a certain value.  
   - **DisplaySubscriber**: Shows the current temperature in the console.

---

## Flow Diagram

```text
TemperatureSensor (Publisher)
        │
        ▼
     EventBus
   ┌────┴────┐
   ▼         ▼
Display   Alarm
Subscriber Subscriber

Temperature is 25°C
Temperature is 31°C
⚠️ Alarm! High temperature detected: 31°C
Temperature is 20°C

## Why Not Just Use the Observer Pattern?
While the Observer pattern also allows one-to-many relationships, it typically requires the subject to hold direct references to observers and call them synchronously.
In contrast, Publish–Subscribe:

- Introduces an intermediary (EventBus).

- Allows multiple publishers and subscribers.

- Avoids direct dependency between them.


