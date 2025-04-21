
# ☕ Coffee Shop – Decorator Pattern

In this project, I implemented the **Decorator Pattern** using a real-life example: a **coffee shop**.

Using this pattern felt very logical when it comes to systems like coffee shops, ice cream parlors, or even pizza places – maybe because these things naturally involve some *decoration*! 👾

---

## 💡 Why Decorator?

All of these products usually start with a **base**, and then we add various **toppings** or extras on top.

The Decorator Pattern lets me create the base component and then pass it **sequentially** through any number or combination of decorators (like Milk, Caramel, Chocolate Syrup...).

✔️ It prevents **inheritance explosion**  
✔️ And it preserves two very important principles:

- **Encapsulation**: The decorator doesn't need to know the internal details of the component it's decorating. It just adds its own behavior on top.
- **Open/Closed Principle**: The system is **open for extension but closed for modification** — I can add new types of add-ons without touching the existing code.

---

## 🎯 Code Experience

I tried to make the code experience more interactive and friendly by adding a simple console interface:
- The user picks a coffee type  
- Adds the desired toppings  
- And finally gets a full description and the final price 💸

---

## 📸 Visuals

> Class diagram for the **Decorator Pattern**

![Decorator Pattern](https://github.com/user-attachments/assets/9270dcf5-fec3-4f87-8bfd-1300b8d41bc7)

> Class diagram for the actual **Coffee Shop design**

![Coffee Shop design](https://github.com/user-attachments/assets/2e648b53-8fe3-46a3-a895-da13da0dcaab)

> Screenshot of the output (user interaction)

![output](https://github.com/user-attachments/assets/8beadace-83c5-4484-b13f-458321412f8c)


---

## 🔚 Final Thoughts

This pattern was genuinely fun to implement —— mostly because of the **fun and delicious** kind of systems where it fits naturally 🙄

But one thing kept bothering me: the heavy use of nested `new` calls. It works, but feels messy.  🤷🏻‍♀️

Is that just a readability issue, or a sign of deeper design flaws? 🤔  
Maybe I’ll figure it out as I try it in larger, real-world systems.