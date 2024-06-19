namespace StationApiExercise.Dtos;

public class StationDto
{
    public StationDto(int id, int stationUicPart)
    {
        Id = id;
        StationUicPart = stationUicPart;
    }

    public int Id { get; set; }
    // Station UIC code which has the following format: 3-digit number
    public int StationUicPart { get; set; }
}