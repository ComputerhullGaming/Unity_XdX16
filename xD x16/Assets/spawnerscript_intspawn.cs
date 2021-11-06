using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerscript_intspawn : MonoBehaviour
{
    public GameObject Spawnspher3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(Spawnspher3, transform.position, Quaternion.identity);
    }
}
