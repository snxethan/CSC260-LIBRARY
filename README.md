# CSC260 Library - Course Projects Collection

This repository contains a collection of .NET 8.0 web applications and learning projects for the CSC260 Computer Science course. Each project demonstrates different aspects of web development, APIs, and modern .NET technologies.

## Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- Visual Studio 2022, Visual Studio Code, or any compatible IDE

## Projects Overview

### 1. **APis** 📡
API-focused learning project demonstrating RESTful web services and HTTP operations.
- **Location**: `Projects/APis/`
- **Type**: ASP.NET Core Web API

### 2. **HelloBlazor** 🎯
Introduction to Blazor web framework for building interactive web UIs with C#.
- **Location**: `Projects/HelloBlazor/`
- **Type**: Blazor Server Application

### 3. **LearningLayouts** 🎨
Project focused on learning web layouts, CSS styling, and responsive design principles.
- **Location**: `Projects/LearningLayouts/`
- **Type**: ASP.NET Core Web Application

### 4. **MVCCore** 🏗️
Comprehensive MVC (Model-View-Controller) learning project with API integration.
- **Location**: `Projects/MVCCore/`
- **Type**: ASP.NET Core MVC + Web API
- **Components**:
  - `MVCCore` - Main MVC web application
  - `MVCCore.Api` - Separate API project
  - `MVCCore.Shared` - Shared components and models

### 5. **MadForInputs** 🎮
Focuses on handling various types of user inputs, forms, and data validation.
- **Location**: `Projects/MadForInputs/`
- **Type**: ASP.NET Core Web Application

### 6. **MyBlazorApp** ⚡
Additional Blazor project for advanced Blazor concepts and interactive components.
- **Location**: `Projects/MyBlazorApp/`
- **Type**: Blazor Application

### 7. **PlayingWithParams** 🔧
Learning project focused on parameter handling, routing, and URL parameters.
- **Location**: `Projects/PlayingWithParams/`
- **Type**: ASP.NET Core Web Application

### 8. **WidgetPersistence** 💾
Project demonstrating data persistence, database operations, and state management.
- **Location**: `Projects/WidgetPersistence/`
- **Type**: ASP.NET Core Web Application

## How to Run Projects

### Running Individual Projects

1. **Navigate to a project directory**:
   ```bash
   cd Projects/[ProjectName]/[ProjectName]
   ```

2. **Restore dependencies**:
   ```bash
   dotnet restore
   ```

3. **Run the project**:
   ```bash
   dotnet run
   ```

4. **Access the application** in your browser at the URL shown in the terminal (typically `https://localhost:5001` or `http://localhost:5000`)

### Using Visual Studio

1. Open the solution file (`.sln`) in the respective project folder
2. Set the desired project as the startup project
3. Press F5 or click "Start Debugging"

## Project Structure

```
CSC260-LIBRARY/
├── Projects/
│   ├── APis/
│   ├── HelloBlazor/
│   ├── LearningLayouts/
│   ├── MVCCore/
│   ├── MadForInputs/
│   ├── MyBlazorApp/
│   ├── PlayingWithParams/
│   └── WidgetPersistence/
├── .gitattributes
├── .gitignore
└── README.md
```

## Learning Objectives

This collection covers:
- **Web APIs**: RESTful services, HTTP methods, JSON handling
- **Blazor**: Component-based UI development with C#
- **MVC Pattern**: Model-View-Controller architecture
- **User Input Handling**: Forms, validation, data binding
- **Routing**: URL parameters, route configuration
- **Data Persistence**: Database operations, state management
- **Layout Design**: CSS, responsive design principles

## Technologies Used

- **.NET 8.0**: Latest version of the .NET framework
- **ASP.NET Core**: Cross-platform web framework
- **Blazor**: Web framework for building interactive web UIs
- **C#**: Primary programming language
- **HTML/CSS**: Frontend markup and styling

## Getting Help

If you encounter issues:
1. Ensure you have .NET 8.0 SDK installed
2. Check that all dependencies are restored with `dotnet restore`
3. Verify the project builds successfully with `dotnet build`
4. Check the console output for any error messages

---

*This repository is part of the CSC260 Computer Science course curriculum.*