using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPositionMush : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 nouvellePosition = Vector3.zero;

        float number = Random.Range(0f, 1f);
    Debug.Log(number);

        if(number < 0.5f){
            nouvellePosition.x = 2.722f;
            nouvellePosition.z = -4.365f;
            nouvellePosition.y = 1f;
        }
        else if(number > 0.5f){
            nouvellePosition.x = -1.248f;
            nouvellePosition.z = -4.365f;
            nouvellePosition.y = 1f;
        }
        
        transform.position = nouvellePosition;

    }

}
