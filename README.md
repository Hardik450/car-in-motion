
# Unity 3D Player Controller 🚀

This project is a simple 3D player controller built using Unity's **new Input System**. The player can:
- Rotate left/right using `A`, `D` or `←`, `→` arrow keys
- Move forward/backward using `W`, `S` or `↑`, `↓` arrow keys
- Jump using the `Spacebar`

It features basic physics with `Rigidbody`, `Jump Detection`, and customizable movement parameters.

---

## 🎮 Controls

| Action   | Keys                  |
|----------|------------------------|
| Rotate Left  | A or Left Arrow (`←`)  |
| Rotate Right | D or Right Arrow (`→`) |
| Move Forward | W or Up Arrow (`↑`)    |
| Move Backward| S or Down Arrow (`↓`)  |
| Jump         | Spacebar               |

---

## 🛠️ How It Works

- Uses Unity's **Input System** (not the legacy input)
- Movement is handled using `Rigidbody.velocity`
- Rotation is applied with `Transform.Rotate`
- Jump is triggered only when grounded (using `OnCollisionEnter`)
- Fully compatible with Unity Physics

---

## 🧩 File Structure

After building the project, you’ll see:

My Project (6).exe
UnityPlayer.dll
UnityCrashHandler64.exe
My Project (6)_Data/

---

> **Note:** All files and folders are required for the game to work properly.

---

## ▶️ Running the Game

1. Download or extract the entire build folder.
2. Double-click `My Project (6).exe` to start the game.
3. Use the controls above to move and jump!

---

## 🛠 Requirements

- Windows OS (64-bit)
- No installation required – just extract and run
---

## 🧠 Learning Outcomes

- Working with Unity Rigidbody and physics
- Understanding Unity's new Input System
- Basics of character control and grounding logic

---

## 📌 Author

**Hardik Jain**  
📅 Built with Unity 2022+

---

## 📄 License

This project is for learning/demo purposes. Free to use, modify, or expand.

```

