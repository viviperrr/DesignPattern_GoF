using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.StructuralPatterns.Facade
{
    public class ProductSubSystem
    {
        public int GetPictureId(int productId)
        {
            // Connect Product DB
            int picId = 1234;

            return picId;
        }

        // ... Other methods
    }
}
