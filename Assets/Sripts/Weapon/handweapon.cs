using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handweapon : MonoBehaviour
{
    public float KD;
    private bool check_hit;
    public int dmg;
    // Start is called before the first frame update
    void Start()
    {
        check_hit = true;
    }

    void OnTriggerStay2D(Collider2D col){
        if(col.gameObject.tag == "Enemy" && check_hit == true){
            StartCoroutine(hit(col.gameObject));
            check_hit = false;
            Debug.Log("good");
        }
    }

    IEnumerator hit(GameObject enemy_obj){
        enemy_obj.GetComponent<hp_Enemy>().hp -= dmg;
        Debug.Log("dmg");
        yield return new WaitForSeconds(KD);
        check_hit = true;
    }
}
