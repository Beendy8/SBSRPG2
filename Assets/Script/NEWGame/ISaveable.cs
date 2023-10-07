using System;

public interface ISaveable
{
    public event Action<ISaveable> onChange;
    public string name { get; }
}
public interface ICustomLoadable: ISaveable
{
    public void Load();
}
