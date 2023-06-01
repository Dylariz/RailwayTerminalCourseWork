using System;

public class Train
{
    public int TrainNumber { get; set; }
    public string DestinationStation { get; set; }
    public DateTime DepartureTime { get; set; }

    public Train(int trainNumber, string destinationStation, DateTime departureTime)
    {
        TrainNumber = trainNumber;
        DestinationStation = destinationStation;
        DepartureTime = departureTime;
    }
}
