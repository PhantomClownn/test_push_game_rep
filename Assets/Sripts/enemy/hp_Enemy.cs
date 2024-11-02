using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hp_Enemy : MonoBehaviour
{
    public int hp;

    void Update(){
        if(hp <= 0){
            Debug.Log(gameObject.name + " - dead");
            Destroy(gameObject);
        }
    }
}
