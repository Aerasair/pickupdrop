using UnityEngine;

public class Apple : MonoBehaviour, IGRABABLE
{
    [SerializeField] private Collider _collider;

    public GameObject GameObject => gameObject;
    public float Height => gameObject.transform.localScale.y;

    public IGRABABLE Collect()
    {
        return this;
    }

    public void Disable()
    {
        _collider.enabled = false;
    }
}
