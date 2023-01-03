using Domain.Entities;

namespace Domain.Dtos;

public class GetActorDto
{
    public int ActorId { get; set; }
    public string FullName { get; set; }
    public int Gender { get; set; }
    public int BirthYear { get; set; }
    public int DeathYear { get; set; }
}

public class AddActorDto
{
    public int ActorId { get; set; }
    public string FullName { get; set; }
    public int Gender { get; set; }
    public int BirthYear { get; set; }
    public int DeathYear { get; set; }
}