using Prove.Attributes;

[assembly: Actor(Actors.WORKER)]
[assembly: Actor(Actors.ADMIN)]

public static class Actors
{
    public const string WORKER = "Worker";
    public const string ADMIN = "Admin";
}
