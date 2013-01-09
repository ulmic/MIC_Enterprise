using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace EnterpriseMICApplicationDemo {
  public static class AnyCatches {
    public static string[] ReadAllLines(string adress, System.Text.Encoding enc) {
      string[] lines;
      try {
        lines = File.ReadAllLines(@adress, enc);
      } catch {
        return null;
      }
      return lines;
    }

    public static bool IfThereIsNot(object text) {
      if (text == null) {
        MessageBox.Show("Невозможно получить данные. Проверьте доступ к сети Интернет.");
        return true;
      }
      return false;
    }
  }
}