# Calculator_App
A simple console application built in C# that performs a variety of mathematical operations through an interactive menu. This project was built as a practice exercise to apply core C# fundamentals: methods, loops, arrays, `out` parameters, and control flow.

## ✨ Features

The calculator supports the following operations:

| # | Operation      | Description                                      |
|---|----------------|---------------------------------------------------|
| 1 | Addition       | Adds two numbers                                   |
| 2 | Subtraction    | Subtracts two numbers                              |
| 3 | Multiplication | Multiplies two numbers                             |
| 4 | Division       | Divides two numbers (blocks division by zero)      |
| 5 | Modulus        | Returns the remainder of a division                |
| 6 | Power          | Raises a base to an exponent (supports negative exponents) |
| 7 | Average        | Calculates the average of a list of numbers        |
| 8 | Maximum        | Finds the maximum value in a list of numbers       |
| 9 | Minimum        | Finds the minimum value in a list of numbers       |
| 10| Exit           | Exits the application                              |

## 🖥️ How It Works

1. The app welcomes the user and displays a menu of available operations.
2. The user selects an operation by entering a number from 1–10.
3. Input is validated — invalid or out-of-range choices prompt the user to try again.
4. Based on the choice, the corresponding operation is executed:
   - **Two-value operations** (Addition, Subtraction, Multiplication, Division, Modulus, Power) prompt for two numbers.
   - **List-based operations** (Average, Maximum, Minimum) first ask how many values to enter, then read each value.
5. The result is displayed, and the menu loops until the user selects **Exit**.

## 📂 Project Structure

The code is organized into two logical regions inside `Program.cs`:

- **`GeneralMethods`** — Reusable helper methods:
  - `WelcomeApp()` – Displays a welcome banner.
  - `Separator()` – Prints a visual divider line.
  - `IsNumber()` – Overloaded methods to safely parse `byte` or `int` input.
  - `ReadValues()` – Reads a set of integers into an array.

- **`AppMethods`** — Core calculator logic:
  - `IsValidNumber()` – Validates the menu choice range.
  - `Addition()`, `Subtraction()`, `Multiplication()`, `Division()`, `Modulus()`, `PowerApp()` – Two-operand operations.
  - `Power()` – Calculates the result of an exponentiation.
  - `AverageApp()`, `MaxApp()`, `MinApp()` – List-based operations.
  - `Average()`, `Max()`, `Min()` – Core calculations for list-based operations.
  - `SelectApp()` – Routes the user's menu choice to the correct method.

## ⚙️ Requirements

- [.NET SDK](https://dotnet.microsoft.com/download) (6.0 or later recommended)
- A C# IDE or editor (Visual Studio, Visual Studio Code, or JetBrains Rider)

## ▶️ Getting Started

1. Clone or download this repository.
2. Open the project in your preferred IDE, or navigate to the project folder in a terminal.
3. Run the application:
   ```bash
   dotnet run
   ```
4. Follow the on-screen menu to perform calculations.

## 📝 Notes

- Input validation ensures the app doesn't crash on invalid or non-numeric input.
- Division and Modulus operations explicitly guard against division by zero.
- The `Power` function supports negative exponents by returning the reciprocal of the positive-exponent result.

## 🚀 Possible Improvements

- Support decimal/double input instead of integers for more precise calculations.
- Replace `goto` statements with cleaner loop-based validation.
- Add unit tests for the calculation methods.
- Add a history feature to track previous calculations.

## 📄 License

This project is open for educational and personal use.

## Author

**Mohammed Salem**

C# Developer | ASP.NET Core MVC Learner

---

⭐ If you find this project useful, feel free to give it a star!
