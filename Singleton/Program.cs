using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SingletonProject {
  internal class Program {
    static void Main(string[] args) {
      Console.WriteLine("This shows the use of a singleton.  No matter how many times the \"Singleton\" is created, ");
      Console.WriteLine("there is only one actual instance and it is reused no matter which classes reference it.");
      Console.WriteLine();

      NameClass george = new NameClass("George");
      Thread.Sleep(1000);
      NameClass kim = new NameClass("Kim");
      Thread.Sleep(1000);

      Console.WriteLine("We should have accumulated George and Kim...");
      Console.WriteLine(george.GetLogs());
      Console.WriteLine("Press enter to continue: ");
      Console.ReadLine();

      NameClass hank = new NameClass("Hank");
      Thread.Sleep(1000);
      NameClass Hayley = new NameClass("Hayley");


      Console.WriteLine("We should have accumulated George, Kim, Hank, and Hayley...");
      Console.WriteLine(george.GetLogs());
      Console.WriteLine("Press enter to continue: ");
      Console.ReadLine();
    }
  }
}
