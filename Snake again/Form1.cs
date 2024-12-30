namespace Snake_again
{
    public partial class Form1 : Form
    {
        clsSnake Snake;
        clsFruta cereza;
        clsSnake[] piezaS;
        int longitud;
        public Form1()
        {
            InitializeComponent();
            Snake = new clsSnake();
            Snake.BackColor = Color.LawnGreen;
            cereza= new clsFruta();
            piezaS = new clsSnake[50];
            piezaS[0] = Snake;
            this.Controls.Add( Snake );
            this.Controls.Add(cereza);
            longitud= 1;
        }
        private void tmrMovimiento_Tick(object sender, EventArgs e)
        {
            Snake.Mover();
            Recorrer(); 
            
            if (Snake.comer(cereza))
            {
                cereza.random();
                piezaS[longitud] = new clsSnake();
                piezaS[longitud].Location = new Point(cereza.Location.X, cereza.Location.Y);    
                this.Controls.Add(piezaS[longitud]);
                longitud++;
            }
            if (Muerte())
            {
                tmrMovimiento.Enabled = false;
            }
        }
        public void Recorrer()
        {
            for (int i = longitud-1 ; i > 0; i--)
            {
                piezaS[i].Location = piezaS[i - 1].Location;
            }
        }
        public bool Muerte()
        {
            if (piezaS[0].Location.X == -1 || piezaS[0].Location.Y == -1 || 
                piezaS[0].Location.X == 760 || piezaS[0].Location.Y == 760)
            {
                MessageBox.Show("You are Dead");
                return true;
            }
            return false;
        }
    }
}