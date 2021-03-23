// Decompiled with JetBrains decompiler
// Type: WindowsFormsApp2.Program
// Assembly: WindowsFormsApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6D991277-C4E9-46C5-9894-13C427645C33
// Assembly location: C:\Users\huso\source\repos\WindowsFormsApp2\WindowsFormsApp2\obj\Debug\WindowsFormsApp2.exe

using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
  internal static class Program
  {
    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run((Form) new Form1());
    }
  }
}
