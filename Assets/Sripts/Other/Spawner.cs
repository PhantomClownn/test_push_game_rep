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
        spawn_pos = gameObject.transform;
    }

    void Update(){
        if(check){
            StartCoroutine(timer());
            check = false;
        }
    }

    IEnumerator timer(){
        yield return new WaitForSeconds(timer_spawn);
        Vector3 temp_pos = new Vector3(spawn_pos.position.x, spawn_pos.position.y,0);
        for(int i = 0; i < count_enemy; i++){
            float rnd_pos = Random.Range(-2f, 2f);
            temp_pos.x = temp_pos.x + rnd_pos;
            rnd_pos = Random.Range(-2f, 2f);
            temp_pos.y = temp_pos.y + rnd_pos;
            Instantiate(Enemy_pref, temp_pos, spawn_pos.rotation);
        }
        check = true;
    }
}
