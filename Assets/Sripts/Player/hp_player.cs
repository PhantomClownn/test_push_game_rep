using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hp_player : MonoBehaviour
{
    public int hp;
    public Slider slider;

    void Update(){
        if(hp <= 0){
            Destroy(gameObject);
        }else{
            slider.value = hp;
        }
    }
}
