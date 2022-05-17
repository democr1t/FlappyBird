using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] protected GameObject Prefab;
    [SerializeField] protected int Capacity;
    [SerializeField] protected GameObject Container;

    private Camera _camera;
    private List<GameObject> _pool = new List<GameObject>();  

    public void Initialize()
    {
        _camera = Camera.main;
        for (int i = 0; i < Capacity; i++)
        {
            var poolObject = Instantiate(Prefab, Container.transform);
            poolObject.SetActive(false);
            _pool.Add(poolObject);
        }
    }

    public bool GetObject()
    {
        var poolObject = _pool.FirstOrDefault(obj => obj.activeSelf == false);
        return poolObject != null;
    }

    public void ResetPool()
    {
        foreach (var obj in _pool)
        {
            obj.SetActive(false);
        }
    }

}
