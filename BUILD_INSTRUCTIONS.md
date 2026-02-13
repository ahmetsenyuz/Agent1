# Build and Deployment Instructions

This document provides clear, concise instructions for building and running the Agent1 console application.

## Prerequisites

Before building and running the application, ensure you have the following installed:

1. **.NET 6.0 SDK** - Required to build and run the application
   - Download from: https://dotnet.microsoft.com/download/dotnet/6.0

2. **A code editor or IDE** (optional but recommended)
   - Visual Studio 2022 or later
   - Visual Studio Code with C# extension
   - JetBrains Rider

## Building the Application

To build the application, follow these steps:

1. Open a terminal/command prompt
2. Navigate to the project root directory (where `Agent1.sln` is located)
3. Run the following command:
   ```
   dotnet build
   ```

This will compile the application and create the executable in the `bin/Debug/net6.0` directory.

## Running the Application

To run the application, follow these steps:

1. Ensure the application is built (see "Building the Application" section)
2. In the terminal/command prompt, navigate to the project root directory
3. Run the following command:
   ```
   dotnet run
   ```

Alternatively, you can run the compiled executable directly:
```
dotnet bin/Debug/net6.0/Agent1.dll
```

## Troubleshooting

### Common Issues and Solutions

1. **.NET SDK not found**
   - Problem: `The specified SDK version could not be found`
   - Solution: Install the correct .NET 6.0 SDK from Microsoft's website

2. **Build fails with compilation errors**
   - Problem: Errors during `dotnet build`
   - Solution: Check that all dependencies are correctly referenced in the `.csproj` file

3. **Runtime errors when executing**
   - Problem: Application crashes or throws exceptions at runtime
   - Solution: Verify that the correct target framework is specified in the project file

4. **Permission denied errors**
   - Problem: Unable to execute the built application
   - Solution: Ensure you have appropriate permissions in the directory

### Verifying Installation

To verify that everything is set up correctly:

1. Run `dotnet --version` to confirm the .NET SDK is installed
2. Run `dotnet build` in the project directory to ensure it compiles successfully
3. Run `dotnet run` to confirm the application executes correctly

## Additional Information

The application is designed to:
- Print "Hello World" n times based on user input
- Handle invalid input gracefully
- Limit iterations to prevent excessive resource usage
- Provide clear feedback during execution

For more information about the application's functionality, refer to the source code in `src/Program.cs`.