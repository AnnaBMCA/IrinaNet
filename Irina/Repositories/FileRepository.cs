using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Irina.Repositories
{
  public class FileRepository
  {
    private const string PortfolioDirectory = "PortfolioFiles";
    private const string SertificateDirectory = "DertificateFiles";
    private const string ImagePath = "Files";
    public string SaveFile(byte[] img, FileType type, string name)
    {
      string path = Assembly.GetCallingAssembly().Location;
      path = Directory.GetDirectoryRoot(path);
      path = Path.Combine(path, ImagePath);
      if (!Directory.Exists(path))
        Directory.CreateDirectory(path);
      switch (type)
      {
        case FileType.Portfolio: { path = Path.Combine(path, PortfolioDirectory); break; }
        case FileType.Sertificate: { path = Path.Combine(path, SertificateDirectory); break; }
      }
      if (!Directory.Exists(path))
        Directory.CreateDirectory(path);
      path = Path.Combine(path, name);
      if (File.Exists(path))
      {
        int index = path.LastIndexOf('.');
        string extention = path.Substring(index, path.Length - index);

        path = Directory.GetDirectoryRoot(path);
        path = Path.Combine(path, name + DateTime.Now.ToString() + extention);
        
      }
      File.Create(path).Close();
      using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Open)))
      {
        writer.Write(img);
      }
      return path;
    }
  }
  public enum FileType
    {
    Portfolio, Sertificate
    }
}
