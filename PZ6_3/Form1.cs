namespace PZ6_3
{
    public partial class Form1 : Form
    {
        private List<Student> Students { get; set; }
        public Form1()
        {
            InitializeComponent();
            Students = new List<Student>();
            Students.Add(new Student("is_pro_31", "��������", 78, 5));
            Students.Add(new Student("is_pro_32", "��������", 55, -4));
            Students.Add(new Student("is_pro_31", "�������", 33, 3));
            Students.Add(new Student("is_pro_32", "�������", 17, 6));
            Students.Add(new Student("prs_32", "����������", 6, 7));
            Students.Add(new Student("prs_31", "�������", 89, 20));
            Students.Add(new Student("abd_32", "��������", 63, -6));
            Students.Add(new Student("abd_31", "����������", 20, -9));
            Students.Add(new Student("is_vp_31", "��������", 45, 20));
            Students.Add(new Student("is_vp_32", "�������", 20, -9));
            StudentView.DataSource = Students;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}