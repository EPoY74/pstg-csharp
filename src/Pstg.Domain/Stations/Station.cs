namespace Pstg.Domain.Stations;

public sealed class Station
{
    public Guid Id {get; init;}
    public required string Name {get; init;}
    public required string Host {get; init;}
    public int Port {get; init;}
    public byte UnitId {get; init;} = 1;
    public bool IsEnable {get; private set;} = true;

    public void Disable() => IsEnable = false;
    public void Enable() => IsEnable = true;
}
