using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_weapon : MonoBehaviour
{
    public int dmg;
    public int KD;
    private GameObject player;
    private bool check_hit;

    void Start(){
        check_hit = true;
    }

    void OnTriggerStay2D(Collider2D col){
        if(col.gameObject.tag == "Player_Body" && check_hit == true){
            player = col.gameObject;
            StartCoroutine(hit());
            check_hit = false;
            Debug.Log("hit player");
        }
    }

    IEnumerator hit(){
        player.GetComponent<hp_player>().hp -= dmg;
        yield return new WaitForSeconds(KD);
        check_hit = true;
    }
}
