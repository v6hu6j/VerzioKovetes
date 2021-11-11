using gyak7.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gyak7.Entities
{
    public class Ball : Toy
    {
        public SolidBrush BallColor { get; private set; }
        public Ball(Color color)
        {
            AutoSize = false;
            Width = 50;
            Height = Width;
            Paint += Ball_Paint;
            BallColor = new SolidBrush(color);
        }


        private void Ball_Paint(object sender, PaintEventArgs e)
        {
            DrawImage(e.Graphics);
        }

        protected override void DrawImage(Graphics g)
        {
            g.FillEllipse(BallColor, 0, 0, Width, Height);
        }
        public void MoveBall()
        {
            Left += 1;
        }
    }
}
