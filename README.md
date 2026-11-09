# WinForms Machine Inspection Simulator

A Windows Forms (WinForms) application built with C# and .NET. This application simulates a quality control or machine inspection process, allowing users to inspect different product models, simulate automated sensor checks, and export inspection logs to JSON.

## 🚀 Features

* **Dynamic Multi-Model Support:** Easily switch between different product models (e.g., Model A-01, B-02, C-03) using a dropdown. The UI dynamically generates the correct number of inspection items for the selected model.
* **Interactive Inspection:** Click on individual item blocks to toggle their status between **OK** (Green) and **NG / Not Good** (Red).
* **Accumulated NG Tracking:** Calculates and tracks the total number of defective items (NG) for the currently selected model, as well as a running daily total.
* **Automated Sensor Simulation:** An "Auto Check" feature uses a background timer to simulate real-time temperature readings (20°C - 100°C). If the temperature exceeds 85°C, it triggers a warning visual.
* **Activity Logging:** Every inspection check is recorded in a history log with a timestamp and the result status.
* **JSON Data Export:** Export the entire inspection history log into a neatly formatted JSON file for external reporting or database integration.

## 🛠️ Technology Stack

* C#
* .NET WinForms
* `System.Text.Json` for data serialization

## 📦 How It Works (Code Overview)

* **`ModelData` Class:** A helper class that acts as a blueprint for each model. It stores the model's name, a dynamic `List<bool>` representing the status of each item, and the accumulated NG count for that specific model.
* **Dynamic UI Rendering (`FlowLayoutPanel`):** Instead of hardcoding labels, the application uses a `FlowLayoutPanel`. When a model is selected, the app clears the panel and programmatically generates `Label` controls based on the item count of the selected model.
* **State Management:** The application remembers the OK/NG status of each item even when you switch back and forth between different models in the `ComboBox`.

## 🎮 How to Use

1. **Select a Model:** Use the dropdown menu at the top to select a model. Note that the number of inspection items will change based on your selection.
2. **Manual Inspection:** Click on the green `Item` boxes to mark them as defective (Red). Click again to mark them as passed (Green).
3. **Check Status:** Click the **Cek** button to record the current status. The Total NG and Daily NG counters will update, and a new log entry will appear at the bottom.
4. **Auto Check:** Check the **Auto Check** checkbox to start the automated simulation. The machine temperature will fluctuate, and automated checks will be performed continuously.
5. **Export Data:** Click the **Export Log** button to save all the records from the history list into a `.json` file in your application's directory.

## ⚙️ Setup and Installation

1. Open the project in Visual Studio.
2. Ensure you have the necessary .NET SDK installed (compatible with .NET Core 3.1, .NET 5/6/7/8, or .NET Framework depending on your initial project setup).
3. Press `F5` or click **Start** to run the application.
