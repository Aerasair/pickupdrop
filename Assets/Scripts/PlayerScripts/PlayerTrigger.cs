using UnityEngine;

public class PlayerTrigger : MonoBehaviour
{
    [SerializeField] private BackPack _backPack;

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out IGRABABLE item))
        {
            IGRABABLE prefab = item.Collect();
            _backPack.Put(prefab);
        }
    }

}
