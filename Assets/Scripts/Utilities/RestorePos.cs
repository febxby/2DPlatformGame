using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestorePos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Restore()
    {
        SaveSystem.SaveByJson("Player", new PlayerData()
        {
            position = new Vector3(0, 0, 0)
        });
    }
}
