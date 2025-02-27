namespace ylialia
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Dictionary<string, int>> graph;
        public Form1()
        {
            InitializeComponent();
            InitializeGraph();
        }
        private void InitializeGraph()
        {
            graph = new Dictionary<string, Dictionary<string, int>>
            {
                { "A", new Dictionary<string, int> { { "B", 4 } } },
                { "B", new Dictionary<string, int> { { "C", 6 }, { "D", 3 }, { "E", 6 } } },
                { "C", new Dictionary<string, int>() },
                { "D", new Dictionary<string, int> { { "E", 2 } } },
                { "E", new Dictionary<string, int> { { "C", 4 }, { "F", 5 } } },
                { "F", new Dictionary<string, int>() }
            };
        }
        private void btnFindPath_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            random.Next(15);
        }
    }
}
