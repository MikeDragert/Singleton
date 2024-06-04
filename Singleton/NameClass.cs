using System;

namespace SingletonProject {
  public class NameClass {

    private string _name = "";
    private Singleton _singleton = Singleton.Instance;

    public NameClass (string name) {
      _name = name;
      _singleton.AddLog($"Created class {_name} at " + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
    }

    public string GetLogs() {
      return _singleton.GetLogsAsString();
    }

  }
}
