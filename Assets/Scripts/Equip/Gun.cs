using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Gun", menuName = "Equip/Gun")]
public class Gun : Equip
{
    [SerializeField] GameObject bulletPrefab;
    GameObject bullet;
    [SerializeField] float speed;
    [SerializeField] float attack;
    public override void Use()
    {
        if(!isCoolDown)
        {
            return;
        }
        bullet = ObjectPool.Instance.GetObject(bulletPrefab);
        bullet.transform.position = equipManager.firePos.position;
        bullet.GetComponent<Bullet>().SetForce((playerController.isFlipX ? Vector2.left : Vector2.right) * speed, attack, player.tag);
    }
}
