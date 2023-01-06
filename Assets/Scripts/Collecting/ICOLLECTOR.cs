using UnityEngine;

public interface ICOLLECTOR 
{
    public Transform Point { get; }

    public void Put(IGRABABLE item);
    public IGRABABLE TryTake();
}
