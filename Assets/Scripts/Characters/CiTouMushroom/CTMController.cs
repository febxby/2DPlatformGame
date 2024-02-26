using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CTMController : MonsterController
{
    ObjectDetector[] objectDetector;
    public bool  isAttackDetected => objectDetector[0].isDetected;
    public bool isChaseDetected => objectDetector[1].isDetected;
    protected override void Awake() {
        base.Awake();
        objectDetector = GetComponentsInChildren<ObjectDetector>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
