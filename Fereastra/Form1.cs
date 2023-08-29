using System.Windows.Forms;

namespace Fereastra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int currentCoordinateIndex = 0;
        private void button1_Click_Move(object sender, MouseEventArgs e)
        {
            List<Point> coordinateList = new List<Point>
                    {
                        new Point(10,10),
                        new Point(500,20),
                        new Point(150,100),
                        new Point(310,120),
                        new Point(100, 80),
                        new Point(310,120),
                        new Point(430, 110),
                        new Point(330, 130)
                    };

            if (e.Button == MouseButtons.None) // Move only when the mouse is not being clicked
            {
                button3.Visible = false; // Makes the button invisible after hovering over it
                                         //button3.MouseClick += ;
                                         //Random random = new Random();
                                         //int maxX = this.ClientSize.Width - button1.Width;
                                         //int maxY = this.ClientSize.Height - button1.Height;
                                         //int newX = 20;
                                         //int newY = 30;

                //button1.Location = new Point(newX, newY);



                if (currentCoordinateIndex < coordinateList.Count)
                {
                    button1.Location = coordinateList[currentCoordinateIndex];
                    currentCoordinateIndex++;
                }
                else
                {
                    if (currentCoordinateIndex == 8)// idk how but it works only with 8
                    {
                        label2.Visible = true;
                    }
                    // If all coordinates have been used, reset the index and move to the first coordinate
                    currentCoordinateIndex = 0;
                    button1.Location = coordinateList[currentCoordinateIndex];
                }


            }

        }
        private void button1_Click_OpenForm2(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
        private void Form1_KeyDown_KeyPress(object sender, KeyEventArgs e)
        {
            // Check if the desired key is pressed (e.g., Enter key)
            if (e.KeyCode == Keys.Enter)
            {
                // Programmatically invoke the button's Click event
                button3.PerformClick();
            }
        }


        private void Button3_MouseClick(object? sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_MouseClick_Close(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}