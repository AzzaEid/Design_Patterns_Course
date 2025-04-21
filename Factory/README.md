
# 🍕 Too Many Pizzas, Too Many Classes? Meet the Factory Method Pattern
>You can view the notes in Arabic in the attached PDF file.
---
We implemented the **Pizza example**, which goes beyond simply choosing a pizza type like we did in the Decorator Pattern. Instead, this example simulates the **full process**:  
Choosing the pizza type, creating the pizza object, and then proceeding with baking, cutting, and boxing.

### 🧩 The Challenge

The challenge was: how do we create the correct pizza type based on the user's choice, then apply the same sequence of operations to it?

If we try to create the correct pizza in the `Main` or `Client` using `new`, we will run into several issues:

- **Code repetition** – we’ll likely repeat the same instantiation logic in many places in the project, leading to:
  - Difficult maintenance.
  - The client gets exposed to unnecessary details (like internal variables used in construction).
- **Reduced flexibility.**
- Using `new` directly causes **tight coupling** with the concrete classes.


---

🧠 **In short:**

> Object creation is the part that **varies**, while the other steps (bake, cut...) are fixed → we must **separate the variable part** (creation) from the rest.

So, we move the creation logic to a separate component: the **factory**.  
=> As the principle says: **Encapsulate what varies**

This gives us the **Simple Factory**  
> Note: Simple Factory is **not** an official GoF pattern, but it's often used as a first step toward improving object creation.
---

**👀 Check the diagram**

![Image](https://github.com/user-attachments/assets/e653c4b7-8452-4203-b187-8c3ab7aec633)

---

However, the Simple Factory has a **limitation**: it only supports a **single factory**.  
Once we needed **multiple factories**, we transitioned to the **Factory Method Pattern**.

In Factory Method:

- The factory itself becomes **abstract**.
- We create different factories as subclasses depending on the context.
- Each factory **customizes** the creation logic for the specific pizza types and region.

✅ Now, we're only working with **abstractions**, and concrete classes don’t know about each other → **Decoupling**

---

🎯 **The goal of the pattern is:**

> **Encapsulate instantiation**  
> Follow the **Dependency Inversion Principle**, which states:  
> - High-level components should **not depend** on low-level components.  
> - Avoid any direct reference to concrete classes.  
> - Never use `new` directly — always go through the factory.  
> - Everything should derive from abstractions.  
> - No direct overrides — just provide custom implementations.

---
**👀 The system Now:**

![Image](https://github.com/user-attachments/assets/461603c7-885d-427e-b76c-9820784ea7b1)

---

But when each factory needed to produce **multiple variants** (Cheese, Greek, Pepperoni...), we started using `if-else` or `switch` based on the `type`.

And that brings us to:

❌ **Violation of the Open/Closed Principle**  
(If we want to add a new type, we need to **modify** existing code instead of **extending** it.)

So we almost needed **another layer of Factory Pattern**!

But if we go further and create a separate factory for **each variant**, we’ll end up with:

🔺 **Class Explosion**  
Each product type will require its own factory class, which leads to an overwhelming number of files and classes, adding complexity instead of reducing it.

---
**⛔ Method Factory pattern Issue**

![Image](https://github.com/user-attachments/assets/6727f381-327a-408b-9589-a05751a3dc9b)

---

✅ **The better approach:**  
Let each regional store (like `NYPizzaStore` or `ChicagoPizzaStore`) contain internal factory methods that create the variants it needs.  
This way, we keep the flexibility and avoid exploding the project with too many classes 😄

---
**👀Our New Desigen!**
>*Abstract class diagram*

![Image](https://github.com/user-attachments/assets/b6e3b31a-8951-469a-93e2-3b73b56b3ad4)

**👀Updated Pizza Store system**
![Image](https://github.com/user-attachments/assets/73c26358-f0ff-464a-9c66-21fc227d6684)

---
## The Output
![Image](https://github.com/user-attachments/assets/610c2e78-4016-4e18-aaa7-7ca1d99b1bf8)

![Image](https://github.com/user-attachments/assets/f968be42-e9ba-4cc6-94d1-a6258ca3f7d5)

![Image](https://github.com/user-attachments/assets/5a5c6b3b-0b9f-40c8-bc46-62058f96e94b)

---
#### 😩It was a great effort!