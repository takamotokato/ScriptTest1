using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] array = { 10, 20, 30, 40, 50 };

        for(int i = array.Length; i > 0; i--)
        {
            Debug.Log(array[i - 1]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
