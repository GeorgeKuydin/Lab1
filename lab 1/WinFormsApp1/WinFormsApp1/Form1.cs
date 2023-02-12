namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuestFactory factory = new LostKeyFactory();
            Quest quest = factory.CreateQuest();
            Object obj = factory.CreateObject();

            MessageBox.Show(quest.Description);
            quest.Execute();
            MessageBox.Show(obj.Description);
            obj.Interact();
        }
    }
}