using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_again
{
    
    internal class clsFruta : Button
    {
        int x;
        int y;
        public clsFruta() 
        {
            this.BackColor = Color.Red;
            this.Size = new Size(40, 40);
            this.Location = new Point(480, 240);
        }

        public void random()
        {
            var guid = Guid.NewGuid();
            var justNumbers = new String(guid.ToString().Where(Char.IsDigit).ToArray());
            var seed = int.Parse(justNumbers.Substring(0, 4));

            var guidy = Guid.NewGuid();
            var justNumbersy = new String(guidy.ToString().Where(Char.IsDigit).ToArray());
            var seedy = int.Parse(justNumbersy.Substring(0, 4));

            var random = new Random(seed);
            var value = random.Next(0, 18);
            int valorInt = Convert.ToInt32(value);
            x = valorInt * 40;

            var randomy = new Random(seedy);
            var valuey = randomy.Next(0, 18);
            int valorInty = Convert.ToInt32(valuey);
            y = valorInty * 40;

            this.Location = new Point(x,y);
        }

    }
}
