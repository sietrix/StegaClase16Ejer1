using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject flowerPrefab;
    public GameObject flower2Prefab;

    public Transform posFlower;
    public float thrustY, thrustZ;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            CreateFlower();
        }

        if (Input.GetMouseButtonDown(1))
        {
            CreateFlower2();
        }

    }

    void CreateFlower()
    {
        // instancio un GameObject
        GameObject cloneFlower = Instantiate(flowerPrefab, posFlower.position, posFlower.rotation);
        // apunto al Rigidbody del GameObject
        Rigidbody rgFlower = cloneFlower.GetComponent<Rigidbody>();
        // Vector3.up hace referencia la Y global de la escena
        rgFlower.AddForce(Vector3.up * thrustY);
        // transform.forward hace referencia eje Z local de la escena de posFlower
        rgFlower.AddForce(transform.forward * thrustZ);

        Destroy(cloneFlower, 3);
    }

    void CreateFlower2()
    {
        // instancio un GameObject
        GameObject cloneFlower = Instantiate(flower2Prefab, posFlower.position, posFlower.rotation);
        // apunto al Rigidbody del GameObject
        Rigidbody rgFlower = cloneFlower.GetComponent<Rigidbody>();
        // Vector3.up hace referencia la Y global de la escena
        rgFlower.AddForce(Vector3.up * thrustY);
        // transform.forward hace referencia eje Z local de la escena de posFlower
        rgFlower.AddForce(transform.forward * thrustZ);

        Destroy(cloneFlower, 3);
    }


}
