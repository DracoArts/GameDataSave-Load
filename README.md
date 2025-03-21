
# Welcome to DracoArts
![Logo](https://dracoarts-logo.s3.eu-north-1.amazonaws.com/DracoArts.png)



# GameDataSave-Load
## Easy Save - The Complete Save Game & Data Serializer System
 is a powerful and user-friendly asset available on the Unity Asset Store. It simplifies the process of saving and loading game data, making it an essential tool for Unity developers. Below is a detailed description of its features and functionality:

## Overview
Easy Save is designed to handle all aspects of saving and loading game data in Unity. It provides a simple yet flexible API to serialize and deserialize data, making it easy to save player progress, game settings, or any other data your game requires. It supports a wide range of data types and formats, ensuring compatibility with most Unity projects.

# Key Features
## 1. Save and Load Game Data:

Save and load data with just one line of code.

Supports saving to and loading from files, PlayerPrefs, or memory.

 ## 2.Data Types Supported:

Primitive types (e.g., int, float, string, bool).

Complex types (e.g., Vector3, Quaternion, Color).

Custom classes and structs.

Lists, arrays, and dictionaries.

Unity-specific types (e.g., GameObject, Transform, Material).

## 3.File Management:

Automatically handles file creation, reading, writing, and deletion.

Supports encryption for secure data storage.

Compresses files to save disk space.

## 4.Cross-Platform Compatibility:

Works seamlessly across all platforms supported by Unity (e.g., PC, mobile, consoles).

Handles platform-specific file paths automatically.

## 5.Performance Optimization:

Fast serialization and deserialization.

Asynchronous saving and loading to avoid frame rate drops.

PlayerPrefs Integration:

Extends Unity’s PlayerPrefs to support more data types and larger data sizes.

 ## 6.Cloud Saving:

Integrates with cloud storage services for cross-device synchronization.

 ## 7.Customization:

Allows custom serialization and deserialization for advanced use cases.

Supports custom file formats and encryption methods.

## 8.Debugging Tools:

Provides detailed logs and error messages for debugging.

Includes a built-in file browser to inspect saved data.

# How It Works


## Usage/Examples
Saving Data:

Use the ES3.Save method to save data to a file or PlayerPrefs.
Example:

     public void SaveData()
    {

      ES3.Save("playerName", "JohnDoe");
      ES3.Save("playerScore", 1000);
      ES3.Save("playerPosition", new Vector3(10, 5, 0));

    }





Use the ES3.Load method to retrieve saved data.


Example:

    public void LoadData()
    {
        string playerName = ES3.Load<string>("playerName");
        int playerScore = ES3.Load<int>("playerScore");
         Vector3 playerPosition = ES3.Load<Vector3>("playerPosition");
    }

Save Game Progress: Save player stats, inventory, and level progress.

Persistent Settings: Store audio volume, graphics settings, and control bindings.

Procedural Generation: Save and load seed values for procedural content.

Cross-Device Play: Sync game data across multiple devices using cloud saving.
## Images

![](https://raw.githubusercontent.com/AzharKhemta/DemoClient/refs/heads/main/Save%20and%20Load%20Data.gif)

## Authors

- [@MirHamzaHasan](https://github.com/MirHamzaHasan)
- [@WebSite](https://mirhamzahasan.com)


## 🔗 Links

[![linkedin](https://img.shields.io/badge/linkedin-0A66C2?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/company/mir-hamza-hasan/posts/?feedView=all/)
## Tech Stack
**Client:** Unity,C#




## Documentation

[Documentation](https://docs.moodkie.com/product/easy-save-3/)

