# 🌐 C# Events vs Observer Pattern – A Personal & Practical Comparison

During this project, I wanted to revisit the **Observer Pattern** I previously implemented for a **Weather Station** example—this time using **C#’s native event and delegate system**.

I was curious:  
*Could the event-based approach in C# achieve the same goals and principles of the traditional Observer Pattern?*  
And more importantly,  
*Would it offer additional benefits—like solving some of the manual implementation's pain points (e.g., verbosity, error-prone handling)?*

---

## 🔍 Part 1: Why Explore Events?

I’ve already explored the classic Observer Pattern with custom interfaces, observer lists, and `Notify()` logic. It worked well, but felt a bit heavy-handed.

That’s where I turned to C#’s native tools.

In C#, the `event` keyword simplifies observer-like behavior by wrapping a **multicast delegate**. This allows us to:
- Notify all subscribers automatically
- Avoid manually managing lists
- Gain type safety and compiler support

It felt like a natural upgrade.

---

## 🧠 Part 2: What Are Delegates and Events?

To understand `event`, you first need to understand `delegate`.  
A `delegate` is like a **function pointer**, holding a reference to one or more methods that match a specific signature.

```csharp
// A delegate that points to methods taking a string parameter
public delegate void NotifyHandler(string message);
```

When combined with `event`, we can safely broadcast messages to all registered listeners.

- ✅ Holds a list of methods (invocation list)
- ✅ Executes them in order
- ✅ Prevents direct invocation from outside the publisher

This is ideal for notifying subscribers in a clean, decoupled way.

---

## 🖼️ Visual Explanation

1. **Delegate pointing to multiple methods**  
   📌 
   ![Delegate list](https://github.com/user-attachments/assets/28b6727c-c889-405d-b7f4-a3e0fccf8865)

2. **Event publisher/subscriber model**  
   📌
   ![Event publisher/subscriber model](https://github.com/user-attachments/assets/c17b9dd7-7a13-43f1-bdf2-fa17663ff476)

---

## 💻 Part 3: How I Used Events in My Weather Example

Here’s how I allowed a subscriber to **subscribe and unsubscribe**:

```csharp
public void Subscribe(WeatherData weatherData)
{
    weatherData.WeatherDataChanged += Update;
}

public void Unsubscribe(WeatherData weatherData)
{
    weatherData.WeatherDataChanged -= Update;
}
```

And here’s how the **publisher** broadcasts the update to all listeners:

```csharp
public event WeatherDataChangedHandler WeatherDataChanged;

private float temperature, humidity, pressure;

public void SetMeasurements(float temperature, float humidity, float pressure)
{
    this.temperature = temperature;
    this.humidity = humidity;
    this.pressure = pressure;
    OnMeasurementsChanged();
}

protected void OnMeasurementsChanged()
{
    WeatherDataChanged?.Invoke(temperature, humidity, pressure);
}
```

The `event` keyword ensures only the publisher can trigger the event, making it safer and more predictable.

---
![Image](https://github.com/user-attachments/assets/6139ed0f-8367-43cb-9135-117669268ce3)
---
## Result
![Output](https://github.com/user-attachments/assets/a242fa43-883e-4efa-b9e1-a23aa8710079)

---

## 🔁 Bonus: A Different Subscription Style

We can also reverse the structure—subscribing from **within the event-holding class**, simply in the Main, like this:

```csharp
static void Main(string[] args)
{
   WeatherData weatherData = new WeatherData();

    // Create display instances
    var currentDisplay = new CurrentConditionsDisplay();
    var statisticsDisplay = new StatisticsDisplay();
    var forecastDisplay = new ForecastDisplay();

    // Subscribe their Update methods directly
    weatherData.WeatherDataChanged += currentDisplay.Update;
    weatherData.WeatherDataChanged += statisticsDisplay.Update;
    weatherData.WeatherDataChanged += forecastDisplay.Update;

    // Simulate new weather measurements
    weatherData.SetMeasurements(27.0f, 65.0f, 1012.0f);
    weatherData.SetMeasurements(29.0f, 70.0f, 1010.0f);

    // Other program logic
}
```
This could easily be applied to the weather scenario, giving us even more flexibility in how we wire up listeners.

---

## ⚖️ Observer Pattern vs C# Event – Comparison

| Feature                     | Manual Observer Pattern      | C# Event-based Approach          |
|----------------------------|------------------------------|----------------------------------|
| Subscription               | Custom method (`Register()`) | `+=` event assignment            |
| Notification               | Manual `Notify()`            | Automatic invocation list        |
| Type safety                | None                         | Enforced by compiler             |
| Error handling             | More error-prone             | Safer and cleaner                |

---

## 🧠 Final Thoughts – Which One Do I Prefer?

Honestly? I really enjoyed both approaches.

The manual **Observer Pattern** gave me deep insight into how the pattern works behind the scenes. It enforced strong separation of concerns and let me control every detail.

But the **event-based version** felt **cleaner**, **safer**, and much more **in line with modern C# practices**.  
If I had to choose for a production app, I’d lean towards the `event` version for its simplicity and built-in safety.

> What do you think? Which one would *you* prefer—raw control, or built-in power?
