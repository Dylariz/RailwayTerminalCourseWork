using System.Collections.Generic;
using System.Linq;


public class BinaryTree
{
    private class Node
    {
        public Train Train { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(Train train)
        {
            Train = train;
            Left = null;
            Right = null;
        }
    }

    private Node _root;

    public BinaryTree()
    {
        _root = null;
    }

    public void Clear()
    {
        _root = null;
    }

    private Node InsertNode(Node current, Train train)
    {
        if (current == null || current.Train.TrainNumber == train.TrainNumber)
        {
            return new Node(train);
        }

        if (train.TrainNumber < current.Train.TrainNumber)
        {
            current.Left = InsertNode(current.Left, train);
        }
        else if (train.TrainNumber > current.Train.TrainNumber)
        {
            current.Right = InsertNode(current.Right, train);
        }

        return current;
    }

    public void Insert(Train train)
    {
        _root = InsertNode(_root, train);
    }

    private List<Train> GetTreeInOrder(Node current, List<Train> result)
    {
        if (current == null)
        {
            return null;
        }

        GetTreeInOrder(current.Left, result);
        result.Add(current.Train);
        GetTreeInOrder(current.Right, result);


        return result;
    }

    public List<string> GetStringsTree()
    {
        var tree = GetTreeInOrder(_root, new List<Train>());

        return tree?.Select(x =>
                $"Номер поезда: {x.TrainNumber}  —  Пункт назначения: {x.DestinationStation}  —  Время отправления: {x.DepartureTime}")
            .ToList();
    }
    
    public List<Train> GetTrainsTree()
    {
        return GetTreeInOrder(_root, new List<Train>());
    }

    private Train FindTrainByNumber(Node current, int trainNumber, Train result)
    {
        if (current == null)
        {
            return null;
        }

        if (trainNumber == current.Train.TrainNumber)
        {
            result = current.Train;
        }
        else if (trainNumber < current.Train.TrainNumber)
        {
            result = FindTrainByNumber(current.Left, trainNumber, result);
        }
        else
        {
            result = FindTrainByNumber(current.Right, trainNumber, result);
        }

        return result;
    }

    public string FindTrain(int trainNumber)
    {
        var train = FindTrainByNumber(_root, trainNumber, null);
        if (train == null)
        {
            return null;
        }
        return $"Номер поезда: {train.TrainNumber}  —  Пункт назначения: {train.DestinationStation}  —  Время отправления: {train.DepartureTime}";
    }

    private List<Train> FindTrainsToDestination(Node current, string destination, List<Train> result)
    {
        if (current == null)
        {
            return null;
        }

        FindTrainsToDestination(current.Left, destination, result);

        if (current.Train.DestinationStation == destination)
        {
            result.Add(current.Train);
        }

        FindTrainsToDestination(current.Right, destination, result);

        return result;
    }

    public List<string> FindTrainsToDestination(string destination)
    {
        var tree = FindTrainsToDestination(_root, destination, new List<Train>());
        if (tree.Count == 0)
        {
            return null;
        }
        return tree.Select(x =>
                $"Номер поезда: {x.TrainNumber}  —  Пункт назначения: {x.DestinationStation}  —  Время отправления: {x.DepartureTime}")
            .ToList();
    }
}
