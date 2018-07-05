using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static Dictionary<int, Tree<int>> tree = new Dictionary<int, Tree<int>>();

    static void Main(string[] args)
    {
        int numberOfNodes = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberOfNodes - 1; i++)
        {
            int[] nodes = Console.ReadLine()
                        .Split()
                        .Select(int.Parse)
                        .ToArray();
            int parent = nodes[0];
            int child = nodes[1];

            if (!tree.ContainsKey(parent))
            {
                tree.Add(parent, new Tree<int>(parent));
            }
            if (!tree.ContainsKey(child))
            {
                tree.Add(child, new Tree<int>(child));
            }

            Tree<int> parentNode = tree[parent];
            Tree<int> childNode = tree[child];
            parentNode.Children.Add(childNode);
            childNode.Parent = parentNode;
        }
        int sum = int.Parse(Console.ReadLine());

        Tree<int> root = tree.FirstOrDefault(x => x.Value.Parent == null).Value;

        //Task 1
        //Console.WriteLine($"Root node: {root.Value}");

        //Task 2
        //root.Print();

        //Task 3
        //var leafs = tree.Where(x => x.Value.Children.Count == 0)
        //                       .Select(x => x.Value.Value)
        //                       .OrderBy(x => x)
        //                       .ToList();
        // Console.WriteLine($"Leaf nodes: {string.Join(" ",leafs)}");

        //Task 4
        //var middleNodes = tree.Where(x => (x.Value.Children.Count != 0) && (x.Value.Parent != null))
        //                        .Select(x => x.Value.Value)
        //                        .OrderBy(x => x)
        //                        .ToList();
        //Console.WriteLine($"Middle nodes: {string.Join(" ", middleNodes)}");

        //Task 7
        //Console.WriteLine($"Paths of sum {sum}:");
        //DFS(root, sum);

        //Task 8
        Console.WriteLine($"Subtrees of sum {sum}:");
        SubTreeDFS(root, sum);
    }
    static void SubTreeDFS(Tree<int> node, int sum)
    {
        int currentSum = node.Value;
        foreach (var child in node.Children)
        {
            currentSum += child.Value;
            SubTreeDFS(child, sum);
        }
        if (currentSum == sum)
        {
            List<int> subTreeValue = new List<int>();
            TreeNodePrintLine(node,subTreeValue);
            Console.WriteLine(string.Join(" ",subTreeValue));
        }
    }
    
    static void TreeNodePrintLine(Tree<int> node, List<int> result)
    {
        result.Add(node.Value);
        foreach (var child in node.Children)
        {
           TreeNodePrintLine(child,result);
        }     
    }
    static void DFS(Tree<int> node, int target, int sum = 0)
    {
        sum += node.Value;

        if (sum == target)
        {
            PrintPath(node);
        }

        foreach (var child in node.Children)
        {
            DFS(child, target, sum);
        }
    }
    static void PrintPath(Tree<int> node)
    {
        Stack<int> path = new Stack<int>();
        Tree<int> start = node;
        path.Push(start.Value);
        while (start.Parent != null)
        {
            start = start.Parent;
            path.Push(start.Value);
        }
        Console.WriteLine(string.Join(" ", path));
    }
}
class Tree<T>
{
    public T Value { get; set; }
    public List<Tree<T>> Children { get; set; } = new List<Tree<T>>();
    public Tree<T> Parent { get; set; }

    public Tree(T value, params Tree<T>[] children)
    {
        this.Value = value;
        foreach (var item in children)
        {
            this.Children.Add(item);
        }
    }
    public void Print(int indent = 0)
    {
        Console.WriteLine($"{new string(' ', indent)}{this.Value}");
        foreach (var child in Children)
        {
            child.Print(indent + 2);
        }
    }
}
