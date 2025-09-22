Console.WriteLine("*** Path ***\n");

Console.WriteLine($"Path.VolumeSeparatorChar => {Path.VolumeSeparatorChar}");
Console.WriteLine($"Path.DirectorySeparatorChar => {Path.DirectorySeparatorChar}");

string path = Path.Combine("c:", "users", "chris", "downloads", "Disturbed - Down with the sickness.mp3");
Console.WriteLine($"path = {path}");

Console.WriteLine($"Path.GetFileName(path) => {Path.GetFileName(path)}");
Console.WriteLine($"Path.GetFileNameWithoutExtension(path) => {Path.GetFileNameWithoutExtension(path)}");
Console.WriteLine($"Path.GetExtension(path) => {Path.GetExtension(path)}");
Console.WriteLine($"Path.GetDirectoryName(path) => {Path.GetDirectoryName(path)}");
Console.WriteLine($"Path.GetFullPath(path) => {Path.GetFullPath(path)}");

Console.WriteLine($"\nPath.Exists(path) => {Path.Exists(path)}");

Console.WriteLine("\n*** Directory ***\n");

path = @"C:\Users\chris\Downloads";
Console.WriteLine($"path = {path}\n");

Console.WriteLine($"Directory.Exists(path) => {Directory.Exists(path)}");
Console.WriteLine($"Directory.GetDirectoryRoot(path) => {Directory.GetDirectoryRoot(path)}");
Console.WriteLine($"Directory.GetParent(path) => {Directory.GetParent(path)}");

Console.WriteLine("Subdirectories:");
foreach (string subdir in Directory.GetDirectories(path))
{
    Console.WriteLine(subdir);
}

Console.WriteLine("\nFiles:");
foreach (string filepath in Directory.GetFiles(path, "*.txt"))
{
    Console.WriteLine(filepath);
}

path = Path.Combine(path, "newFolder", "test", "csharp");
Console.WriteLine($"\nCreate folder: {path}");

//Directory.CreateDirectory(path);

// Removes directory only if empty, otherwise throws exception:
Directory.Delete(path);

// WARNING: Removes directory and all subdirectories (and files) without asking:
//Directory.Delete(path, true);