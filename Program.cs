

string workingPath = @"D:\career\programming\.net\codes\working with files\working path";


string copiedDir = Path.Combine(workingPath, "copied");

if (!Directory.Exists(copiedDir))
    Console.WriteLine("I'am gonna create new directory");

Directory.CreateDirectory(copiedDir);


if (!File.Exists(Path.Combine(workingPath, "text.txt")))
{
    Console.WriteLine($"there is no file in {workingPath}");
    return;
}
File.Copy(Path.Combine(workingPath,"text.txt"), Path.Combine(copiedDir, "text.txt"),true);

string redundantFolder = Path.Combine(workingPath, "redundant directory");
Directory.Delete(redundantFolder);