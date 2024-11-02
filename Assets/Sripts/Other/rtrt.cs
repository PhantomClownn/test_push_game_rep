using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rtrt : MonoBehaviour
{
    // Список объектов
    public List<GameObject> objectList = new List<GameObject>();

    // Метод Update вызывается один раз за кадр
    void Update()
    {
        // Итерируйтесь в обратном порядке, чтобы избежать ошибок при удалении
        for (int i = objectList.Count - 1; i >= 0; i--)
        {
            if (objectList[i] != null) // Если объект существует
            {
                Debug.Log(objectList[i].name);
            }
            else // Если объект равен null, удалить его из списка
            {
                objectList.RemoveAt(i);
            }
        }
    }
}
