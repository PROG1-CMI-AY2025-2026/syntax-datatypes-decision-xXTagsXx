# My Console App

This is a simple C# console application.

## Getting Started

To build and run this application, follow these steps:

1. **Clone the repository** (if applicable):
   ```bash
   git clone <repository-url>
   cd my-console-app
   ```

2. **Build the application**:
   You can build the application using the .NET CLI. Run the following command in the project directory:
   ```bash
   dotnet build
   ```

3. **Run the application**:
   After building the application, you can run it with the following command:
   ```bash
   dotnet run
   ```

## Activities Instructions

### Activity 1: Variable Data Types
- Open `PROG1-Activities/Activity1.cs`.
- Identify and fix the error in the code related to variable data types.
- Make sure each variable has the correct data type and value.

### Activity 2: Umbrella Checker
- Open `PROG1-Activities/Activity2.cs`.
- Create an umbrella checker program using conditional statements (`if`, `else if`, `else`).
- The program should:
  - Return "Bring an umbrella!" if the weather is "rainy".
  - Return "No umbrella needed." if the weather is "sunny".
  - Return "Invalid weather condition." for any other input.

### Activity 3: Voting Eligibility Checker
- Open `PROG1-Activities/Activity3.cs`.
- Create a voting eligibility program.
- The program should:
  - Check if the person is 18 years or older **and** a Filipino citizen.
  - Return "You are eligible to vote." if both conditions are met.
  - Otherwise, return "You are not eligible to vote."

## How to Check Your Work

- **To run the application:**
  ```bash
  dotnet run
  ```

- **To test your code and check if you passed the unit tests:**
  ```bash
  dotnet test ../midterm-csharp-activity.sln
  ```
  (Make sure you are in the `my-console-app` directory.)

- If all tests pass, you will see output indicating all tests passed.

## Submitting Your Work

1. Open the Source Control tab in VS Code.
2. Stage and commit your changes with the message:
   ```
   Complete Name-activities
   ```
3. Push your code to GitHub.
4. Your submission should reflect on your GitHub account.

## Project Structure

- `Program.cs`: The entry point of the application.
- `PROG1-Activities/Activity1.cs`: Activity 1 code.
- `PROG1-Activities/Activity2.cs`: Activity 2 code.
- `PROG1-Activities/Activity3.cs`: Activity 3 code.
- `my-console-app.csproj`: The project file containing configuration and dependencies.
- `README.md`: Documentation for the project.