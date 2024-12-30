using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_again
{
    internal class clsSnake : Button

    {
        char direccion;
        public clsSnake() 
        {
            this.BackColor= Color.DarkGreen;
            this.Size = new Size(40, 40);
            this.Location = new Point(400, 240);
            direccion = 'd';
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Snake_KeyPress);
        }
        private void Snake_KeyPress(object sender, KeyPressEventArgs e)
        {
            char dir = direccion;
            char d;
            d = e.KeyChar;
            if (dir == 'd' && d != 'a')
            {
                direccion = d;
            }
            if (dir == 'a' && d != 'd')
            {
                direccion = d;
            }
            if (dir == 'w' && d != 's')
            {
                direccion = d;
            }
            if (dir == 's' && d != 'w')
            {
                direccion = d;
            }
        }
        public void Mover()
        {
                switch (direccion)
                {
                    case 'd':
                        this.Location = new Point(this.Location.X + 40, this.Location.Y);
                        break;
                    case 'a':
                        this.Location = new Point(this.Location.X - 40, this.Location.Y);
                        break;
                    case 'w':
                        this.Location = new Point(this.Location.X, this.Location.Y - 40);
                        break;
                    case 's':
                        this.Location = new Point(this.Location.X, this.Location.Y + 40);
                        break;
                }
        }

        public bool comer(clsFruta cereza)
        {
            if (this.Location.X == cereza.Location.X && this.Location.Y == cereza.Location.Y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
