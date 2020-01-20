using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.StructuralPatterns.Facade
{
    public class Facade
    {
        public void LoadProductPicture(int productId)
        {
            ProductSubSystem product = new ProductSubSystem();
            int picId = product.GetPictureId(productId);

            PictureDataSubSystem pictureData = new PictureDataSubSystem();
            string picPath = pictureData.GetPicture(picId);

            FileStorageSubSystem fileStorage = new FileStorageSubSystem();
            byte[] fileData = fileStorage.GetFile(picPath);

            HtmlSubSystem html = new HtmlSubSystem();
            html.LoadImage(fileData);
        }
    }
}
