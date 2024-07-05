### Resources that I studied:<br>
- [Working with Files in C# 10 - Pluralsight](https://www.pluralsight.com/courses/c-sharp-10-working-files)
- 

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


