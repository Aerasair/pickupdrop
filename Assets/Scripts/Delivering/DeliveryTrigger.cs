using DG.Tweening;
using UnityEngine;

public class DeliveryTrigger : MonoBehaviour
{
    [SerializeField] private Transform _point;
    private int _quantity = 0;
    private bool pause = true;
    private float _localTimer = 0;

    private void OnTriggerStay(Collider other)
    {
        if (pause) return;
        if (other.TryGetComponent(out BackPack backPack) == false) return;

        IGRABABLE item = backPack.TryTake();
        if (item == null) return;
        _quantity++;
        item.GameObject.transform.parent = _point;
        Vector3 finalPosition = new Vector3(0, _quantity * item.Height, 0);
        item.GameObject.transform.DOLocalMove(finalPosition, 0.3f);
        item.Disable();
        pause = true;
    }

    private void Update()
    {
        _localTimer += Time.deltaTime;
        if (_localTimer < 0.3f) return;

        _localTimer = 0;
        pause = false;
    }


}
