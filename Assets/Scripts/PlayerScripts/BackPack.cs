using DG.Tweening;
using System.Collections.Generic;
using UnityEngine;

public class BackPack : MonoBehaviour, ICOLLECTOR
{
    [SerializeField] private Transform _point;
    private List<IGRABABLE> _gameObjects;
    private int _quantity;

    public Transform Point => _point;

    private void Start()
    {
        _gameObjects = new List<IGRABABLE>();
    }

    public void Put(IGRABABLE item)
    {
        _quantity++;
        item.GameObject.transform.parent = _point;
        Vector3 finalPosition =  new Vector3(0, _quantity * item.Height, 0);//0.7f - height object
        item.GameObject.transform.DOLocalMove(finalPosition, 0.3f);
        _gameObjects.Add(item);
    }

    public IGRABABLE TryTake()
    {
        _quantity--;
        if (_quantity < 0) _quantity = 0;
        if (_gameObjects.Count > 0)
        {
            IGRABABLE newItem =  _gameObjects[_gameObjects.Count - 1];
            _gameObjects.Remove(newItem);
            return newItem;
        }
        else
            return null;
    }
}
