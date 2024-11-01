using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform spawn_pos;
    public GameObject Enemy_pref;
    public float timer_spawn;
    public int count_enemy;
    private bool check;

    void Start(){
        check = true;
    }

    void Update(){
        if(check){
            StartCoroutine(timer());
            check = false;
        }
    }

    IEnumerator timer(){
        yield return new WaitForSeconds(timer_spawn);
        for(int i = 0; i < count_enemy; i++){
            Instantiate(Enemy_pref, spawn_pos.position, spawn_pos.rotation);
        }
        check = true;
    }
}
