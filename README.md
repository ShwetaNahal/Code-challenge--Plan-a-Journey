# STA Code Challenge: TFL Plan a Journey with Selenium and C#

This project demonstrates automated browser testing for the TFL "Plan a Journey" feature using Behavior-Driven Development (BDD) with Selenium and C#. It applies various design patterns and practices to ensure maintainable and robust test automation.

## Key Features

- **BDD with Selenium and C#**  
  Utilizes SpecFlow to define test scenarios in Gherkin syntax, combined with Selenium WebDriver for browser automation, making tests easy to understand and collaborate on.

- **Factory Design Pattern**  
  Implements the Factory pattern to manage WebDriver instances, ensuring flexibility and consistency in WebDriver initialization.

- **Page Object Model (POM)**  
  Follows the Page Object Model pattern, organizing code with a clear separation between test logic and page-specific interactions for improved readability and maintainability.

- **log4net Integration**  
  Configures log4net for detailed logging of each test step, which aids debugging and provides insights into test execution.

- **Hooks Implementation**  
  Uses SpecFlow hooks (`[BeforeScenario]`, `[AfterScenario]`) to manage WebDriver lifecycles, ensuring a fresh test environment for each scenario.

## Necessary Installations for the Repository

To get started with this repository, install the following:

### 1. .NET SDK
- **Description:** Required to build and run the project.
- **Installation:** Download and install from the official [.NET website](https://dotnet.microsoft.com/download).

### 2. Visual Studio or Visual Studio Code
- **Description:** IDE for editing, building, and running the project.
- **Installation:** 
  - **Visual Studio:** Download from [Visual Studio website](https://visualstudio.microsoft.com/). Select the ".NET desktop development" workload during installation.
  - **Visual Studio Code:** Download from [Visual Studio Code website](https://code.visualstudio.com/). Add the **C# extension** if using VS Code.

### 3. NuGet Packages
- **Description:** This project relies on several NuGet packages for Selenium, SpecFlow, logging, and more.
- **Installation:** Use NuGet Package Manager in Visual Studio or the `dotnet CLI` to install the following packages:
  - `Selenium.WebDriver`
  - `Selenium.WebDriver.ChromeDriver` (or other WebDriver binaries as needed)
  - `SpecFlow`
  - `SpecFlow.NUnit` (or other test runners like `SpecFlow.xUnit`)
  - `log4net`
  - `Microsoft.Extensions.Configuration`
  - `Microsoft.Extensions.Configuration.Json`

### 4. WebDriver Binaries
- **Description:** Browser-specific WebDriver binaries are necessary to automate different browsers.
- **Installation:** 
  - **ChromeDriver:** Required for Google Chrome. Can be installed via NuGet or downloaded from the [ChromeDriver website](https://sites.google.com/chromium.org/driver/).
  - **Note:** This project is configured for ChromeDriver by default.

### 5. Browser Installation
- **Description:** Ensure browsers like Chrome, Firefox, or Edge are installed on your machine.
  - This project specifically uses **Google Chrome** for testing.

### 6. Configuration Files
- **Description:** Configuration files (e.g., `appsettings.json`) are generally used to manage environment and settings. In this project, the configuration is based directly on ChromeDriver.
  
---

This README provides setup instructions and an overview of the project structure, enabling you to set up and run tests with ease.
