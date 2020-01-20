using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.StructuralPatterns.Facade
{
    public class HtmlSubSystem
    {
        public void LoadImage(byte[] imgData)
        {
            string base64 = Convert.ToBase64String(imgData);
            Console.WriteLine($"<img src=\"data:image/png;base64, {base64}\" alt=\"Tesla model3 2020\" />");
        }
    }
}
