using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public Transform Character;

    public float staringArea = 10;
    public float shootingArea = 8;
    public float accuracyControl = 5;
    public float rotationVelocityControl = 3;

    public float dist;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dist = Vector3.Distance(Character.position, transform.position);

        if (dist <= staringArea)
        {
            stare();
        }

        if (dist <= shootingArea)
        {
            shoot(dist);
        }

        //transform.Translate(Vector3.forward * Time.deltaTime);
    }

    private void stare()
    {
        float rotationVelocity = rotationVelocityControl / dist;
        
        //transform.LookAt(Character);
        Vector3 direction = Character.transform.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(direction);
        
        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, Time.deltaTime * rotationVelocity);
    }

    private void shoot(float dist)
    {
        /*transform.LookAt(Character);
        
        float accuracy = accuracyControl / dist ;

        Vector3 randRotation = new Vector3(Random.Range(-accuracy, accuracy), Random.Range(-accuracy, accuracy), Random.Range(-accuracy, accuracy));

        transform.Rotate(randRotation);*/

    }

}
