# Csharp-IO-programming
This repository focuses on **Input/Output (I/O) programming in C#**, covering practical techniques for **reading, writing, and processing data from different sources**.

It includes hands-on examples and programs for:
- **CSV data handling** (reading, writing, parsing structured data)
- **Stream-based I/O** using FileStream, StreamReader, StreamWriter, BinaryReader, and BinaryWriter
- **JSON data handling** for serialization and deserialization of objects

The goal of this repository is to strengthen understanding of **file handling, data streams, and structured data processing in C#**, which are essential for real-world applications.

---

## 🛠 Tech Stack
- **Language:** C#
- **Framework:** .NET
- **Tools:** Visual Studio Code
- **Version Control:** Git & GitHub

---

## ✨ Features
- Structured **concept-wise and example-driven learning approach**
- Covers **CSV, JSON, and stream-based I/O operations** in C#
- Practical, **beginner-friendly programs** for file handling
- Focus on **real-world data processing**, streams, and serialization fundamentals
- Clean and readable code for **easy understanding and reuse**

---

## 📂 Branch Structure

### 🔹 `csv-file-handling` branch
This branch focuses on **handling CSV files in C#**, covering reading, writing, filtering, updating, validating, and transforming CSV data.  
The problems are designed to simulate **real-world data processing tasks** commonly used in applications like reporting systems, ETL pipelines, and data analysis tools.

---

## 📝 Practice Problems

### 🔹 Basic Level

- **Read a CSV File and Print Data**  
  Read a CSV file containing student details (ID, Name, Age, Marks) and print each record in a structured format.

- **Write Data to a CSV File**  
  Create a CSV file with employee details (ID, Name, Department, Salary) and write at least five records.

- **Read and Count Rows in a CSV File**  
  Read a CSV file and count the total number of records, excluding the header row.

---

### 🔹 Intermediate Level

- **Filter Records from CSV**  
  Read a CSV file and display students who scored more than 80 marks.

- **Search for a Record in CSV**  
  Search an employee record by name and display their department and salary.

- **Modify a CSV File (Update Values)**  
  Increase the salary of employees from the IT department by 10% and save the updated data to a new CSV file.

- **Sort CSV Records by a Column**  
  Sort employee records by salary in descending order and display the top five highest-paid employees.

---

### 🔹 Advanced Level

- **Validate CSV Data Before Processing**  
  Validate email format using regex and ensure phone numbers contain exactly 10 digits.  
  Print invalid rows with appropriate error messages.

- **Convert CSV Data into Objects**  
  Read CSV data and convert each row into a `Student` object, storing all objects in a list.

- **Merge Two CSV Files**  
  Merge two CSV files based on a common ID field and generate a new CSV with combined data.

- **Detect Duplicate Records**  
  Identify and print duplicate records in a CSV file based on the ID column.

- **Convert CSV ↔ JSON**  
  Convert student data from JSON format to CSV and implement reverse conversion from CSV to JSON.

---

### 🎯 Learning Outcomes

- File I/O operations using **StreamReader and StreamWriter**
- Parsing and writing **CSV data manually**
- Data filtering, searching, sorting, and merging
- Data validation using **Regex**
- Converting CSV data into **C# objects**
- Transforming data between **CSV and JSON formats**

---

### 🔹 `streams-problems` branch
This branch focuses on **Stream-based I/O operations in C#**, covering low-level and high-level stream handling techniques.  
The problems emphasize **efficient file processing, serialization, memory streams, buffering, and binary data handling**, which are essential for building scalable and performance-aware applications.

---

## 📝 Practice Problems

### 🔹 File & Basic Stream Operations

- **File Handling – Read and Write a Text File**  
  Read the contents of a text file and write them into a new file.  
  Handle missing source files and ensure destination file creation using `FileStream`.

- **Read User Input from Console and Save to File**  
  Accept user details (name, age, favorite programming language) from the console and store them in a file using stream readers and writers.

---

### 🔹 Buffered & Performance-Oriented Streams

- **Buffered Streams – Efficient File Copy**  
  Copy a large file using `BufferedStream` and compare its performance with unbuffered file streams using a stopwatch.

- **Filter Streams – Uppercase to Lowercase Conversion**  
  Read text from a file and write it to another file while converting all uppercase characters to lowercase efficiently.

---

### 🔹 Memory & Byte Streams

- **ByteArray Stream – Convert Image to Byte Array**  
  Convert an image file into a byte array using `MemoryStream` and recreate the image from the byte array.

---

### 🔹 Serialization & Binary Streams

- **Serialization – Save and Retrieve Objects**  
  Serialize and deserialize a list of employee objects using binary or JSON serialization techniques.

- **Data Streams – Store and Retrieve Primitive Data**  
  Store student details (roll number, name, GPA) in a binary file using `BinaryWriter` and retrieve them using `BinaryReader`.

---

### 🔹 Stream-Based Data Processing

- **Count Words in a File**  
  Read a text file, count word occurrences using a dictionary, and display the top five most frequently occurring words.

---

### 🎯 Learning Outcomes

- Understanding **FileStream, StreamReader, and StreamWriter**
- Efficient file handling using **BufferedStream**
- Working with **MemoryStream and byte arrays**
- Binary data processing with **BinaryReader and BinaryWriter**
- Object serialization and deserialization
- Performance comparison between buffered and unbuffered streams
- Real-world text analysis using streams and collections
  
---

## 👤 Author
**Prashant Varshney**  
B.Tech CSE (Data Analytics)  
