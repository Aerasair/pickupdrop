using UnityEngine;

public class Apple : MonoBehaviour, IGRABABLE
{
    [SerializeField] private Collider _collider;
    [SerializeField] private TypeItems _type;

    public GameObject GameObject => gameObject;
    public float Height => gameObject.transform.localScale.y;

    public TypeItems Type => _type;

    public IGRABABLE Collect()
    {
        return this;
    }

    public void Disable()
    {
        _collider.enabled = false;
    }
}
