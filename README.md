# 🐶 C# Abstract Class: Animal va Dog sinflari

Ushbu loyiha C# dasturlash tilida yozilgan bo‘lib, unda **abstrakt sinflar** va **meros olish (inheritance)** kabi obyektga yo‘naltirilgan dasturlash (OOP) tushunchalari amalda ko‘rsatilgan.

## 📋 Vazifa mazmuni

- `Animal` nomli **abstrakt sinf** yaratiladi.
- Unda quyidagi metod va xususiyatlar mavjud:
  - `Name` (string)
  - `SetName(string name)` — hayvon nomini o‘rnatadi
  - `GetName()` — hayvon nomini qaytaradi
  - `Eat()` — **abstrakt metod** bo‘lib, har bir hayvon turida alohida aniqlanadi

- `Dog` sinfi `Animal` sinfidan **meros oladi** va `Eat()` metodini quyidagicha aniqlaydi:
  - `"Eating"` matnini konsolga chiqaradi

- `Main` metodda foydalanuvchidan **itning ismi** olinadi, va quyidagi amallar bajariladi:
  - It obyektiga nom beriladi
  - `GetName()` va `Eat()` metodlari chaqiriladi

## 💻 Ishlash printsipi

### 🔹 Kirish (Input):

