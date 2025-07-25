# 📱 Daily Expense Tracker  
> Cross-platform personal finance logger built with .NET MAUI

---

## 🧠 Overview

This app helps users **track daily transactions** by entering a product name and the amount spent. Designed with **.NET MAUI**, it runs seamlessly on **Android**, **iOS**, **Windows**, and **macOS** — all from a single codebase. It's perfect for individuals who want a minimalist yet effective way to monitor daily expenses.

---

## 🎯 Features

- ✅ **Add & View Transactions**  
  Log expenses instantly with just a product name and price.

- 📅 **Auto-Date Grouping**  
  Transactions are grouped by the date they were added.

- 📊 **Daily Summaries**  
  Instant view of total spending per day.

- 📦 **Local Storage (SQLite)**  
  Keeps data on-device, no internet required.

- 🌈 **Responsive UI**  
  Built with .NET MAUI's adaptive layout engine for a native feel on all devices.

---

## 🖼️ Screenshots

| Android | Windows | macOS |
|--------|---------|-------|
| ![Android Screenshot](screenshots/android.png) | ![Windows Screenshot](screenshots/windows.png) | ![macOS Screenshot](screenshots/macos.png) |

> 📸 *Screenshots coming soon*

---

## 🧰 Tech Stack

| Layer         | Technology            |
|---------------|------------------------|
| Frontend      | .NET MAUI (XAML + C#)  |
| Backend       | .NET 8                 |
| Architecture  | MVVM (Model-View-ViewModel) |
| Database      | SQLite (via EF Core)   |
| Local Storage | EF Core with Migrations |
| Platform APIs | MAUI Essentials        |

---

## 🏗️ Project Structure

```
/DailyExpenseTracker
├── Models
│   └── Transaction.cs
├── ViewModels
│   └── MainViewModel.cs
├── Views
│   └── MainPage.xaml
├── Data
│   └── AppDbContext.cs
├── Services
│   └── TransactionService.cs
├── Resources
│   └── Fonts, Styles, Icons
├── Platforms
│   └── Android, iOS, Windows, MacCatalyst
└── App.xaml / AppShell.xaml
```

---

## 🚀 Getting Started

### 🔧 Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download)
- [Visual Studio 2022+](https://visualstudio.microsoft.com/) with **.NET MAUI workload** installed
- MAUI check tool (optional):  
  ```bash
  dotnet tool install -g redth.net.maui.check
  ```

### 🛠 Build & Run

1. Clone the repo:
   ```bash
   git clone https://github.com/your-username/DailyExpenseTracker.git
   cd DailyExpenseTracker
   ```

2. Run the app on your desired platform:
   ```bash
   dotnet build
   dotnet maui run --platform android
   ```

3. Or select your target platform in Visual Studio and hit **Run**.

---

## 📌 Roadmap

- [x] Daily tracking
- [ ] Export to PDF/Excel
- [ ] Monthly summaries
- [ ] Cloud sync (Azure or Firebase)
- [ ] Notifications/reminders

---

## 🧑‍💻 Author

**Yusuf Nviiri**  
`C# | .NET MAUI | React | EFC | SQL`  
[Portfolio](#) • [LinkedIn](#) • [Email](mailto:yusufnviiri@gmail.com)
