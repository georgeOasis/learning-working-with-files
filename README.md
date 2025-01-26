### Resources that I studied:<br>
- [Working with Files in C# 10 - Pluralsight](https://www.pluralsight.com/courses/c-sharp-10-working-files)
- [Getting Started with JSON in C# Using Json.NET 12 - Pluralsight](https://www.pluralsight.com/courses/getting-started-json-csharp-jsondotnet)

# Working with Files in C# 10 - Pluralsight
## Module 2 : Managing Files and Directories

- ` File.Exists()`
- `Directory.Exists()`
- `Directory.CreateDirectory()`
- `File.Copy()`
- `File.Move() `
- `Directory.Delete()`
- `Directory.GetFiles()`
- `Path.Combine()`
- `Path.GetExtension()`
- `Path.ChangeExtension()`

## Module 3: Monitoring the File System for Changes
#### buffer size property:
- Each operation with FileSystemWatcher needs [16 byte + File name]
- Buffer size range is [4 KB --> 64 KB] 
- Default is  8 KB
- It is recommended using mutliple of 4 KB in Intel based CPU




"If there are many changes in a short time, the buffer can overflow. This causes the component to lose track of changes in the directory, and it will only provide blanket notification." [Microsoft documantation](https://learn.microsoft.com/en-us/dotnet/api/system.io.filesystemwatcher.error?view=net-8.0) 


## Module 4 : Reading and Writing Entire Files Into Memory

- `File.ReadAllText()`
- `File.WriteAllText()`
- `File.ReadAllLines()`
- `File.WriteAllLines()`
- `File.AppendAllText() `
- `File.ReadAllBytes()`
- `File.WriteAllBytes()`

<br>

## Module 5: Reading and Writing Data Incrementally Using Streams
Streams benefits

1. **Efficient Memory Usage**
2. **Asynchronous Processing**
3. **Abstraction from backing store**
4. **Seekability**
5. **Performance**: By using streams, you can perform read and write operations in a buffered manner, which can significantly improve the performance of your application. This is because buffered operations reduce the number of I/O operations, which are typically slow.

   
Notes:
- you can specify `Encoding` in `StreamReader` and `StreamWriter`.
- you can append data to `StreamWriter` using a constructor parameter.
- you can randomly access bytes of the Streams.
- you can use memory as a backing store using `MemoryStream`.


# Getting Started with JSON in C# Using Json.NET 12 - Pluralsight
## Module 2 : The case for Json and Json.NET
![Screenshot 2025-01-26 205049](https://github.com/user-attachments/assets/7ea305ff-a553-47e5-b0d1-714bcad8a216)
![image](https://github.com/user-attachments/assets/10001703-12be-45d3-a6be-1200e63d6a90)
## Module 3 : Serialization fundamentals
