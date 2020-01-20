using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.StructuralPatterns.Facade
{
    public class PictureDataSubSystem
    {
        public string GetPicture(int picId)
        {
            // Connect Picture Database
            string imgPath = "\\Product\\Car\\Tesla_Model3_2020.jpg";
            return imgPath;
        }
    }
}
