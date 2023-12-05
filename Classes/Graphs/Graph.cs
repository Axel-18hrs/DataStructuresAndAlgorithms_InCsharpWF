using DataStructuresAndAlgorithms_InCSharp.Interfaces;
using System.Text;

namespace DataStructuresAndAlgorithms_InCSharp.Classes.Graphs
{
    internal class Graph<T>
    {
        private Dictionary<T, List<(T, int)>> graph = new Dictionary<T, List<(T, int)>>();
        private Dictionary<T, int> weights = new Dictionary<T, int>();

        public void AddVertex(T vertex)
        {
            if (!graph.ContainsKey(vertex))
            {
                graph[vertex] = new List<(T, int)>();
            }
        }

        public void AddEdge(T source, T destination, int weight)
        {
            if (graph.ContainsKey(source) && graph.ContainsKey(destination))
            {
                graph[source].Add((destination, weight));
            }
        }

        public void RemoveEdge(T source, T destination)
        {
            if (graph.ContainsKey(source))
            {
                graph[source].RemoveAll(edge => edge.Item1.Equals(destination));
            }
        }

        public IEnumerable<(T, int)> GetNeighbors(T vertex)
        {
            if (graph.ContainsKey(vertex))
            {
                return graph[vertex];
            }
            else
            {
                return Enumerable.Empty<(T, int)>();
            }
        }

        public IEnumerable<T> GetVertices()
        {
            return graph.Keys;
        }

        public void RemoveVertex(T vertex)
        {
            if (graph.ContainsKey(vertex))
            {
                graph.Remove(vertex);

                foreach (var key in graph.Keys)
                {
                    graph[key].RemoveAll(tuple => tuple.Item1.Equals(vertex));
                }
            }
        }

        public (List<T> bestPath, List<List<T>> steps) DFS(T start, T goal)
        {
            if (!graph.ContainsKey(start))
            {
                Console.WriteLine($"The starting vertex {start} is not present in the graph.");
                return (new List<T>(), new List<List<T>>());
            }

            Stack<T> stack = new Stack<T>();
            Dictionary<T, T> parents = new Dictionary<T, T>();
            weights.Clear();

            stack.Push(start);
            parents[start] = default;

            List<List<T>> steps = new List<List<T>>();

            while (stack.Count > 0)
            {
                T currentVertex = stack.Pop();
                List<T> currentStep = new List<T> { currentVertex };

                foreach ((T neighbor, int weight) in graph[currentVertex])
                {
                    if (!parents.ContainsKey(neighbor))
                    {
                        stack.Push(neighbor);
                        parents[neighbor] = currentVertex;
                        weights[neighbor] = weight;

                        // Add the vertex to the current step
                        currentStep.Add(neighbor);
                    }
                    else
                    {
                        if (weight < weights[neighbor])
                        {
                            weights[neighbor] = weight;
                            parents[neighbor] = currentVertex;
                        }
                    }
                }

                // Add the current step to the list of steps
                steps.Add(new List<T>(currentStep));
            }

            List<T> bestPath = BuildPath(parents, goal);
            return (bestPath, steps);
        }

        private void PrintDFSSteps(List<List<T>> steps)
        {
            Console.WriteLine("Depth-First Search (DFS) Steps:");
            for (int i = 0; i < steps.Count; i++)
            {
                Console.WriteLine($"Step {i + 1}: {string.Join(" -> ", steps[i])}");
            }
        }

        private List<T> BuildPath(Dictionary<T, T> parents, T goal)
        {
            List<T> path = new List<T>();

            T current = goal;
            while (!EqualityComparer<T>.Default.Equals(current, default))
            {
                path.Insert(0, current);

                // Check if the key is present in the dictionary
                if (parents.ContainsKey(current))
                {
                    current = parents[current];
                }
                else
                {
                    // Handle the case where the key is not present
                    break;
                }
            }

            return path;
        }

        public List<string> GetAdjacencyMatrix()
        {
            List<string> matrixStrings = new List<string>();
            int numVertices = graph.Count;

            StringBuilder header = new StringBuilder("   ");
            foreach (var vertex in graph.Keys)
            {
                header.Append($"{vertex} ");
            }
            matrixStrings.Add(header.ToString());

            foreach (var vertex in graph.Keys)
            {
                StringBuilder row = new StringBuilder($"{vertex} ");
                foreach (var otherVertex in graph.Keys)
                {
                    bool hasEdge = graph[vertex].Any(edge => edge.Item1.Equals(otherVertex));
                    row.Append(hasEdge ? "1 " : "0 ");
                }
                matrixStrings.Add(row.ToString().Trim());
            }

            return matrixStrings;
        }
    }

}