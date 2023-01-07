using UnityEngine;

public interface IGRABABLE 
{
    public GameObject GameObject { get; }
    public float Height { get; }
    public TypeItems Type { get; }

    public IGRABABLE Collect();

    public void Disable();
}
