string path = Console.ReadLine();
string fileName = string.Empty;
string fileExtension = string.Empty;

int indexOfFileName = path.LastIndexOf('\\');
int indexOfFileExtension = path.LastIndexOf('.');

if (indexOfFileExtension != -1 && indexOfFileName != -1 && indexOfFileExtension > indexOfFileName)
{

    fileName = path.Substring(indexOfFileName + 1, indexOfFileExtension - indexOfFileName - 1);
    fileExtension = path.Substring(indexOfFileExtension + 1);

}

Console.WriteLine($"File name: {fileName}");
Console.WriteLine($"File extension: {fileExtension}");