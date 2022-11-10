using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Create a project named ClassicBookSelector that contains a Form with a ListBox that lists at least five classic books that you think all educated
//people should have read. When the user places the mouse over the ListBox, display a Label that contains a general statement about the benefits 
//of reading. The Label disappears when the user’s mouse leaves the ListBox area. When the user clicks a book title in the ListBox, display another 
//Label that contains a brief synopsis of the specific book. Also, change the BackColor of the Form to a different color for each book.
namespace ClassicBookSelector
{
    public partial class Form1 : Form
    {
        string a = "Expand your knowledge by reading important material!";
        public bool t = true;
        string zero = "Pete the Cat is wearing his favorite shirt- the one with four totally groovy \nbuttons. But when one falls off, does Pete cry?";
        string one = "Cats do not meow randomly, nor do they growl or hiss because they have nothing better to do. Cat sounds have \na purpose, and they can carry important messages, whether for us or other cats.";
        string two = "A single word of text per spread teaches readers “how to be a cat”―how to stretch, clean, pounce, feast―while \nthe striking paper cuts illustrate the kitten's attempts to imitate an adult cat's \nmastery of each skill.";
        string three = "Internet sensation Grumpy Cat's epic feline frown has inspired legions of devoted fans. Celebrating the grouch \nin everyone,the Grumpy Cat book teaches the fine art of grumpiness and includes \nenough bad attitude to cast a dark cloud over the whole world.";
        string four = "Long gone are the good old days when a cat’s biggest worries were mean dogs or a bath. Modern cats \nmust confront satanists, online predators, the possibility of needing to survive in a post-apocalyptic \nwasteland, and countless other threats to their nine lives.";
        public Form1()
        {
            InitializeComponent();
            label1.Enabled = false;
            label1.Text = "";
            label1.Text = "";
            label2.Enabled = false;

     
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_MouseHover(object sender, EventArgs e)
        {
            label1.Enabled = true;
            label1.Text = a;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_MouseLeave(object sender, EventArgs e)
        {
            label1.Enabled = false;
            label1.Text = "";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex % 5 == 0)
            {
                this.BackColor = Color.AliceBlue;
                label2.Enabled = true;
                label2.Text = zero;
            }
            else if (listBox1.SelectedIndex % 5 == 1)
            {
                this.BackColor = Color.SlateBlue;
                label2.Enabled = true;
                label2.Text = one;
            }
            else if (listBox1.SelectedIndex % 5 == 2)
            {
                this.BackColor = Color.SteelBlue;
                label2.Enabled = true;
                label2.Text = two;
            }
            else if (listBox1.SelectedIndex % 5 == 3)
            {
                this.BackColor = Color.LightSkyBlue;
                label2.Enabled = true;
                label2.Text = three;
            }
            else if (listBox1.SelectedIndex % 5 == 4)
            {
                this.BackColor = Color.CornflowerBlue;
                label2.Enabled = true;
                label2.Text = four;
            }
        }
    }
}
