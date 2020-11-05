using Demo.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class CarApi
    {
        public List<Image> GetPlate(string input)
        {
            List<Image> result = new List<Image>();

            //TODO:暫時直接傳送,記得亂序
            result.Add(Resources._001);
            result.Add(Resources._002);
            result.Add(Resources._003);
            result.Add(Resources._004);

            ////另一種方式
            //for (int i = 0; i < 4; i++)
            //{
            //    string resourceName = (i + 1).ToString("000");
            //    Bitmap bmp = (Bitmap)Properties.Resources.ResourceManager.GetObject(resourceName);
            //    result.Add(bmp);
            //}

            return result;
        }


    }
}
