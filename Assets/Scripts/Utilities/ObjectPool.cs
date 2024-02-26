using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool
{
    private static ObjectPool instance;
    private Dictionary<string, Queue<GameObject>> objectPool = new Dictionary<string, Queue<GameObject>>();
    private GameObject pool;
    public static ObjectPool Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new ObjectPool();
            }
            return instance;
        }

    }
    public GameObject GetObject(GameObject prefab)
    {
        GameObject _obj;
        if (!objectPool.ContainsKey(prefab.name) || objectPool[prefab.name].Count == 0)
        {
            _obj = GameObject.Instantiate(prefab);
            PushObject(_obj);
            if (pool == null || !GameObject.Find("ObjectPool"))
                pool = new GameObject("ObjectPool");
            GameObject child = GameObject.Find(prefab.name);
            if (!child)
            {
                child = new GameObject(prefab.name);
                child.transform.SetParent(pool.transform);
            }
            _obj.transform.SetParent(child.transform);
        }
        _obj = objectPool[prefab.name].Dequeue();
        _obj.SetActive(true);
        return _obj;
    }
    public void PushObject(GameObject prefab)
    {
        string _name = prefab.name.Replace("(Clone)", string.Empty);
        if (!objectPool.ContainsKey(_name))
            objectPool.Add(_name, new Queue<GameObject>());
        objectPool[_name].Enqueue(prefab);
        prefab.SetActive(false);
    }
    public void ResetObject()
    {
        objectPool.Clear();
    }
}
