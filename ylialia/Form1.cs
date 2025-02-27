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

        private int Dijkstra(Dictionary<string, Dictionary<string, int>> graph, string start, string end)
        {
            var distances = new Dictionary<string, int>();
            var priorityQueue = new SortedSet<(int distance, string node)>();
            var previous = new Dictionary<string, string>();

            foreach (var node in graph.Keys)
            {
                distances[node] = int.MaxValue;
                previous[node] = null;
            }

            distances[start] = 0;
            priorityQueue.Add((0, start));

            while (priorityQueue.Count > 0)
            {
                var (currentDistance, currentNode) = priorityQueue.Min;
                priorityQueue.Remove(priorityQueue.Min);

                if (currentNode == end)
                    return currentDistance;

                foreach (var neighbor in graph[currentNode])
                {
                    var newDistance = currentDistance + neighbor.Value;

                    if (newDistance < distances[neighbor.Key])
                    {
                        distances[neighbor.Key] = newDistance;
                        previous[neighbor.Key] = currentNode;
                        priorityQueue.Add((newDistance, neighbor.Key));
                    }
                }
            }

            return distances[end];
        }
    }
}
