using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;


namespace Irina.Models
{

  public class Home
  {
    public string[] files = null;
    public string[] Main()
    {
      files= System.IO.Directory.GetFiles("wwwroot/images/Portfolio/Makeup/");
      return files;
    }

    
  }
}
