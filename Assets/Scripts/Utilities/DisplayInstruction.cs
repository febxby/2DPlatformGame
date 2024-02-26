using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayInstruction : MonoBehaviour
{
    GameObject instruction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OpenInstruction(){
        instruction.SetActive(true);
    }
}
