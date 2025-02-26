using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreationBronze : MonoBehaviour
{
     [SerializeField] GameObject _prefabOriginal;

    // Start is called before the first frame update
    void Start()
    {
        Quaternion _rotation = Quaternion.Euler(0f, 90f, 0f);
        Instantiate(_prefabOriginal, transform.position, transform.rotation);
        
    }

}
