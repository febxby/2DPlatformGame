using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public delegate void OnAttack();
public class Door : MonoBehaviour
{
    public UnityEvent onAttack;
    [SerializeField] GameObject door;
    [SerializeField] GameObject HealthBar;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "Player")
        {
            // Debug.Log("Close Door");
            door?.SetActive(true);
            onAttack?.Invoke();
            HealthBar?.SetActive(true);
        }
    }
}
