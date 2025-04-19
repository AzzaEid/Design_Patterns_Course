## 🌦️ Weather Station – Observer Pattern Implementation

### 📌 Real-life Example of the Observer Pattern

This project demonstrates a real-life implementation of the **Observer Pattern** using a simple **Weather Station** system.

The system successfully achieves:
- **Loosely coupled design** by depending on interfaces rather than concrete implementations.
- Use of **composition over inheritance**, allowing flexible reuse of behavior.
- Clear separation of concerns between the Subject and Observers.

---

### 🖼️ System Architecture Diagram

![System Diagram](https://github.com/user-attachments/assets/504c1c29-de7e-4ccf-acc9-dc123fa22dea)

> The system consists of a `WeatherData` subject and multiple observers like `CurrentConditionsDisplay`, `ForecastDisplay`, and `StatisticsDisplay`, all communicating through defined interfaces.

---

### 🧠 Course Challenge

As part of the assignment, the course instructor challenged us to:
- Extend the basic code.
- Implement the **Pull** version of the Observer Pattern alongside the **Push** version.

I successfully implemented **both approaches**.

---

### 🧭 Dual Mode Support – Push & Pull

The console application allows users to choose which pattern they want to experience:
- **Push Mode**: Subject sends all data directly to observers.
- **Pull Mode**: Observers pull the data they need from the subject.

This design enhances flexibility and highlights the difference between both techniques.

---

### 🎯 Additional Pull Design Consideration

To implement the **Pull** approach **without tightly coupling observers to the concrete subject**,  
I introduced an **additional interface** layer to expose only the required data (`GetTemperature`, `GetHumidity`, `GetPressure`).  
This helped avoid direct dependence on the `WeatherData` class and maintained the principle of **programming to an interface**.

> ✅ This is a good design decision and aligns well with the Open/Closed Principle and Dependency Inversion Principle. Well done!

---

### 📸 Sample Results

Here are a screenshot from the console showing the output in **Pull** mode, including:

- Normal updates
- Color-coded displays
- Removal of observers at runtime

![output](https://github.com/user-attachments/assets/f6692514-0565-4af8-94a1-d8d20907781d)

---

### 💬 Personal Reflection

I’m satisfied with my implementation of the Observer Pattern.  
I believe I have followed most of the important design principles correctly.  
Using the Pull method helped me understand the importance of abstraction and interface design even more deeply.

When implementing Pull, I added another interface layer to avoid direct dependency on concrete classes, which I believe was the right design decision.

> If you have any suggestions for improvement, I’d love to hear them!

---

