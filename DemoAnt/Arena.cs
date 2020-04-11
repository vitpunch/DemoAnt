using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoAnt
{
    class Arena
    {
        static public Size mainFieldPictureSize { get; private set; }
        static public Random random = new Random();
        PictureBox picture;
        Graphics graphics;
        public Arena(PictureBox picture)
        {
            this.picture = picture;
            mainFieldPictureSize = picture.Size;
            this.picture.Image = new Bitmap(mainFieldPictureSize.Width, mainFieldPictureSize.Height);
            graphics = Graphics.FromImage(this.picture.Image);
            Clear();
        }

        private void Clear()
        {
            graphics.Clear(picture.BackColor);
        }
    }
}
