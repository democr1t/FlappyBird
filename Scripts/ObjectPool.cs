using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] protected int Capacity;
    [SerializeField] protected GameObject Container;

    private Camera _camera;
    private List<GameObject> _pool = new List<GameObject>();  

    public void Initialize(GameObject prefab)
    {
        _camera = Camera.main;
        for (int i = 0; i < Capacity; i++)
        {
            var poolObject = Instantiate(prefab, Container.transform);
            poolObject.SetActive(false);
            _pool.Add(poolObject);
        }
    }

    protected bool GetObject(out GameObject result)
    {
        result = _pool.FirstOrDefault(obj => obj.activeSelf == false);
        return result != null;
    }

    public void ResetPool()
    {
        foreach (var obj in _pool)
        {
            obj.SetActive(false);
        }
    }

}
