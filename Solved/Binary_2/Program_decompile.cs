// Decompiled with JetBrains decompiler
// Type: Employee_Payroll.Program
// Assembly: Employee_Payroll, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 436284E8-B80D-406A-93C5-7DE7662EB4F2
// Assembly location: C:\Users\zst\Desktop\Employee_Payroll.exe

using System;
using System.Windows.Forms;

namespace Employee_Payroll
{
  internal static class Program
  {
    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run((Form) new employee_payroll());
    }
  }
}
