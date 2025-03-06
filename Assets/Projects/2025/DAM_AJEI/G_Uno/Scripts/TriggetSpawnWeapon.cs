using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggetSpawnWeapon : MonoBehaviour
{
    public Transform spawner;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pistol"))
        {
            other.gameObject.transform.position = spawner.position;
        }




    }


}
