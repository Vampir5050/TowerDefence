using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Yadra : MonoBehaviour
{
    [SerializeField] GameObject yadro_abstr, tower;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float power = 1200;
        GameObject yadro = Instantiate(yadro_abstr) as GameObject;
        yadro.transform.position = tower.transform.position;
        yadro.transform.rotation = tower.transform.rotation;
        yadro.transform.Translate(0, 0, 5f);
        yadro.GetComponent<Rigidbody>().AddRelativeForce(yadro.transform.forward * power, ForceMode.Force);
    }
}
