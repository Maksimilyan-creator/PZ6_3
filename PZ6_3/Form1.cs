using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace PZ6_3
{
    public partial class Form1 : Form
    {
        private List<Student> Students { get; set; }
        public Form1()
        {
            InitializeComponent();
            Students = new List<Student>();
            Students.Add(new Student("is_pro_31", "Пирожков", 78, 5));
            Students.Add(new Student("is_pro_32", "Казакова", 55, -4));
            Students.Add(new Student("is_pro_31", "Андреев", 33, 3));
            Students.Add(new Student("is_pro_32", "Тарасов", 17, 6));
            Students.Add(new Student("prs_32", "Коновалова", 6, 7));
            Students.Add(new Student("prs_31", "Королев", 89, 20));
            Students.Add(new Student("abd_32", "Антонова", 63, -6));
            Students.Add(new Student("abd_31", "Кудрявцева", 20, -9));
            Students.Add(new Student("is_vp_31", "Семенова", 45, 20));
            Students.Add(new Student("is_vp_32", "Крылова", 20, -9));
            StudentView.DataSource = Students.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            StudentView.DataSource = Students.Where(u => u.Group == textBox1.Text).ToList();
            if (textBox1.Text == "")
            {
                StudentView.DataSource = Students.ToList();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           switch(comboBox1.SelectedIndex)
            {
                case 0: //0-20

                    StudentView.DataSource = Students.Where(u => u.Progress >=0 && u.Progress <=20 ).ToList();
                    

                    break;
                case 1: //21-50

                    StudentView.DataSource = Students.Where(u => u.Progress >= 21 && u.Progress <= 50).ToList();

                    break;
                case 2: //51-70

                    StudentView.DataSource = Students.Where(u => u.Progress >= 51 && u.Progress <= 70).ToList();

                    break;
                case 3: //71-100

                    StudentView.DataSource = Students.Where(u => u.Progress >= 71 && u.Progress <= 100).ToList();

                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StudentView.DataSource = Students.Where(u => u.Rating >= 0).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentView.DataSource = Students.OrderBy(u => u.Surname).ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentView.DataSource = Students.ToList();
        }
    }
}