using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_bullet : MonoBehaviour
{
    public float speed;
    public int dmg;

    void Update()
    {
        Vector3 direction = transform.right; // В 2D пространстве 'up' является вперед

        // Двигаем объект в заданном направлении
        transform.position += direction * speed * Time.deltaTime;
    }

    void OnTriggerStay2D(Collider2D col){
        if(col.gameObject.tag == "Enemy"){
            col.gameObject.GetComponent<hp_Enemy>().hp -= dmg;
            Destroy(gameObject);
        }
    }
}
