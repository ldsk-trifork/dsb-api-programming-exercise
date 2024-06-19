namespace StationApiExercise.Models;

public class Station
{
    public int Id { get; set; }
    // Station UIC code which has the following format:
    // - 3-digit number OR
    // - 7-digit number where the first 4 digits are always 8600 and the last 3 digits are the station UIC part
    public int StationUicOrPart { get; set; }
}