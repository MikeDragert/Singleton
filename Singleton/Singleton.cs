using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SingletonProject {
  public sealed class Singleton {

    private static Singleton _instance;
    private static readonly object _lockObject = new object();

    private List<string> logs = new List<string>();
    
    public Singleton() { 
    }

    public static Singleton Instance {
      get {
        lock (_lockObject) {
          if (_instance == null) {
            _instance = new Singleton();
          }
          return _instance;
        }
      }
    }

    public void AddLog(string log) {
      logs.Add(log);
    }

    public string GetLogsAsString() {
      return logs.Aggregate("", (acc, log) => acc + Environment.NewLine + log);
    }

  }
}
