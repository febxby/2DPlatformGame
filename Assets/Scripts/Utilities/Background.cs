using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    SpriteRenderer render;
    [Tooltip("背景移动速度"), Range(0.01f, 0.1f)]
    public float speed = 0.02f;

    GameObject player;
    // Start is called before the first frame update
    void Awake()
    {
        render = GetComponent<SpriteRenderer>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        // render.material.mainTextureOffset += Vector2.right * speed * Time.deltaTime;
        transform.position=player.transform.position;

    }
}
