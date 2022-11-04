using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Week06_JLY8UL.Abstractions;

namespace Week06_JLY8UL.Entities
{
    public class Present : Toy
    {
        public Present()
        {
            
            Width = 50;
            Height = Width;
            Paint += Present_Paint;
        }

        private void Present_Paint(object sender, PaintEventArgs e)
        {
            DrawImage(e.Graphics);
        }
        public SolidBrush PresentColor { get; private set; }
        public Present(Color color)
        {
            PresentColor = new SolidBrush(color);
        }

        protected override void DrawImage(Graphics g)
        {
            g.FillRectangle(PresentColor, 0, 0, Width, Height);
            
        }
        public void MovePresent()
        {
            Left += 1;
        }
    }
}
