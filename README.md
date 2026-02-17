# AI vs Human Coding Experiment (C#)

## Overview

This repository contains a series of coding challenges designed to evaluate the impact of AI-assisted tools on programming performance.

Participants complete programming tasks of increasing difficulty under controlled conditions, either with or without access to AI assistance.

---

## Challenge Structure

The experiment consists of four challenge levels:

1. Beginner
2. Intermediate
3. Advanced
4. Expert

Each challenge is self-contained and includes:
- A starter C# file
- A README file describing the task requirements

---

## How to Run

## How to Run the Project

### Option 1: Using Visual Studio

1. Open the solution file (.sln) in Visual Studio.
2. Restore NuGet packages if prompted.
3. Press **F5** or click **Run**.

---

### Option 2: Using VS Code

#### Prerequisites

You must have:

- .NET SDK installed  
- C# extension installed in VS Code  

---

### Step 1: Install the .NET SDK

1. Go to: https://dotnet.microsoft.com/download
2. Download and install the latest **.NET SDK** (not just the runtime).
3. After installation, verify it is installed by running:


   ```bash
   dotnet --version

   
You should see a version number.

---

### Step 2: Install the C# Extension in VS Code

1. Open VS Code.
2. Click the **Extensions** icon (left sidebar).
3. Search for:

   ```bash
   C#

   4. Install the extension published by **Microsoft**.
5. Restart VS Code if prompted.

---

### Step 3: Run the Project

1. Open the project folder in VS Code.
2. Open the integrated terminal:
   - Terminal → New Terminal

3. Restore dependencies (if required):
         ```bash
   dotnet restore

4. Run the project:
         ```bash
   dotnet run


The application should now build and execute.

---

### Troubleshooting

If you see an error such as:

- "The term 'dotnet' is not recognized"

This means the .NET SDK is not installed correctly or not added to your system PATH. Reinstall the SDK and restart your computer.


