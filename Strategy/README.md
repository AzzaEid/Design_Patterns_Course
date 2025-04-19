
## 🦆 Duck Strategy Pattern - C# Implementation

### 🧠 Strategy & Design

This project demonstrates the use of the **Strategy Design Pattern** in C# by replacing **inheritance** with **composition**, enabling dynamic changes in behavior at runtime.

Instead of defining all flying and quacking behavior in a `Duck` superclass, we **delegate these behaviors** to interfaces (`FlyBehavior`, `QuackBehavior`) and set them dynamically in each duck instance.

**Key Principles Followed:**
- **Favor composition over inheritance**
- **Program to an interface, not an implementation**
- Follows **Open/Closed Principle**: easy to extend with new behaviors without modifying existing code

---

### 🎯 Instructor Challenge

We implemented the instructor's challenge which involved the following tasks:

- ✅ Create a `Simulator` class that instantiates and shows behavior of a `MallardDuck`
- ✅ Add a new duck type: `ModelDuck` (can quack, but initially can't fly)
- ✅ Add new behavior: `FlyRocketPowered`
- ✅ Modify the code to **change fly behavior at runtime**
- ✅ Let the user choose the desired fly and quack behavior interactively
- ✅ Use `setFlyBehavior()` and `setQuackBehavior()` methods to inject new behaviors dynamically

---

### 📦 Output

> The screenshot here showing user interaction and the behavior change at runtime.

![output screenshot](/Output.png)

---

### 💬 Personal Feedback

I'm very satisfied with the final result.  
The code structure is **clean, flexible, and follows SOLID principles**.

However, I believe there is room for optimization.  
The way we instantiate behavior classes with `new` (e.g., `new FlyWithWings()`) inside the simulator might be costly, especially if behaviors are created frequently at runtime.  
This could be improved using **dependency injection**, **singleton**, or a **behavior factory** pattern to avoid unnecessary allocations.

---

### 📐 Class Diagram 

![classdiagram](/class%20diagram.png)