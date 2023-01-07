using DG.Tweening;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BackPack : MonoBehaviour, ICOLLECTOR
{
    [SerializeField] private Transform _point;
    private List<IGRABABLE> _items;
    private int _quantity;

    public Transform Point => _point;

    private void Start()
    {
        _items = new List<IGRABABLE>();
    }

    public void Put(IGRABABLE item)
    {
        _quantity++;
        item.GameObject.transform.parent = _point;
        Vector3 finalPosition =  new Vector3(0, _quantity * item.Height, 0);//0.7f - height object
        item.GameObject.transform.DOLocalMove(finalPosition, 0.3f);
        _items.Add(item);
    }

    public IGRABABLE TryTake(TypeItems type)
    {
        IGRABABLE newItem = _items.Where(r => r.Type == type).LastOrDefault();
        if (newItem == null) return null;

        _quantity--;
        if (_quantity < 0) _quantity = 0;

        _items.Remove(newItem);
        ResortObjects();
        return newItem;

    }

    private void ResortObjects()
    {
        for(int i = 0; i < _quantity; i++)
        {
            Vector3 finalPosition = new Vector3(0, (i+1) * _items[i].Height, 0);
            _items[i].GameObject.transform.DOLocalMove(finalPosition, 0.1f);
        }
    }
}
