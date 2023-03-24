using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS_CourseWork
{
    class DnD : Question
    {
        private string[] text;
        private Image[] image;

        public string[] Text { get => text; set => text = value; }
        public Image[] Image { get => image; set => image = value; }

        public DnD()
        {
            Text = new string[3];
            Image = new Image[3];
        }


        public  bool CheckAnswer(string text, Image image)
        {
            if (Array.IndexOf(Text, text) == Array.IndexOf(Image, image))
                return true;
            else
                return false;

        }
    
    }

}
