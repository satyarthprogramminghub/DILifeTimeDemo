# DILifeTimeDemo

## Overview
DILifeTimeDemo is a project demonstrating the use of Dependency Injection in a lifetime context. This application showcases the principles of Dependency Injection and how different lifetimes can affect object instantiation and management.

## Table of Contents
- [Project Structure](#project-structure)
- [Installation](#installation)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)

## Project Structure
```
DILifeTimeDemo/
│
├── src/                     # Source Files
│   ├── Controllers/         # API Controllers
│   ├── Services/            # Application Services
│   ├── Models/              # Data Models
│   ├── Repositories/        # Data Access Layer
│   └── Program.cs           # Entry Point
│
├── tests/                   # Unit Tests
│   └── DILifeTimeDemo.Tests/ # Test Project
│
├── README.md                # Documentation
└── DILifeTimeDemo.sln        # Solution File
```

## Installation
1. Clone the repository:
   ```bash
   git clone https://github.com/satyarthprogramminghub/DILifeTimeDemo.git
   ```
2. Navigate into the project directory:
   ```bash
   cd DILifeTimeDemo
   ```
3. Restore dependencies:
   ```bash
   dotnet restore
   ```

## Usage
To run the application, use the following command:
```bash
dotnet run
```
Visit `http://localhost:5000` to access the API.

## Contributing
Contributions are welcome! Please submit a pull request or open an issue for any suggestions or improvements.

## License
This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.