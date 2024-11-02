using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootweapon : MonoBehaviour
{
    public float KD;
    public bool check_hit;
    public int dmg;
    public GameObject bullet;
    public List<GameObject> Enemy_list = new List<GameObject>();
    public GameObject targetObject;
    // Start is called before the first frame update
    void Start()
    {
        check_hit = true;
    }

    void OnTriggerStay2D(Collider2D col){
        if(col.gameObject.tag == "Enemy"){
            targetObject = col.gameObject;
            //bool chek_now = false;
            if(!Enemy_list.Contains(col.gameObject)){
                Enemy_list.Add(targetObject);
            }
        }
    }

    void Update(){
        if(check_hit == true){
            //OnTriggerStay2D();
            if(Enemy_list.Count > 0){
                targetObject = FindNearestObject();
                StartCoroutine(hit(targetObject));
                check_hit = false;
                Debug.Log(targetObject.name + " no");
                Debug.Log("shoot_trig");
            }
        }
    }

    void OnTriggerExit2D(Collider2D col){
        if (Enemy_list.Contains(col.gameObject))
        {
            Enemy_list.Remove(col.gameObject);
        }
    }

    IEnumerator hit(GameObject enemy_obj){
        GameObject temp_bullet = Instantiate(bullet, transform.position, Quaternion.identity);
        Vector3 direction = (targetObject.transform.position - temp_bullet.transform.position).normalized;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        temp_bullet.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
        temp_bullet.GetComponent<move_bullet>().dmg = dmg;
        Debug.Log("dmg_s");
        yield return new WaitForSeconds(KD);
        check_hit = true;
    }

    GameObject FindNearestObject(){
        // Проверяем, есть ли объекты в списке
        if (Enemy_list == null || Enemy_list.Count == 0)
        {
            Debug.LogWarning("Список объектов пуст или не установлен.");
            return null;
        }

        GameObject nearestObject = null;
        float nearestDistance = Mathf.Infinity; // Инициализируем бесконечным значением

        // Перебираем объекты в списке
        foreach (GameObject obj in Enemy_list)
        {
            if (obj != null) // Проверяем, не равен ли объект null
            {
                // Вычисляем расстояние до каждого объекта
                float distance = Vector3.Distance(transform.position, obj.transform.position);

                // Если новый объект ближе, обновляем ближайший объект и расстояние
                if (distance < nearestDistance)
                {
                    nearestDistance = distance;
                    nearestObject = obj;
                }
            }
        }

        return nearestObject;
    }
}
