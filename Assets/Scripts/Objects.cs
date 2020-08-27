using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Objects : MonoBehaviour
{
    private GameObject[] sphere;
    private IPlaneteryObject[] planet;

    public int numRand;
    public float angle = 1;
    public float radius = 0.5f;
    public float speed = 0.5f;

    void Start()
    {
        if (numRand == 0)
            numRand = Random.Range(1, 30);
        sphere = new GameObject[numRand];
        planet = new IPlaneteryObject[numRand];

        for (int i = 0; i < numRand; i++) {
            IPlaneteryObject planCopy = new IPlaneteryObject();
            planCopy.init();
            planet[i] = planCopy;
            Debug.Log(planet[i].getClass());
        }

        for (int i= 0; i < numRand; i++) {
            GameObject sphereCop = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            sphere[i] = sphereCop;
        }
    }

    void Update()
    {
        angle += Time.deltaTime;

        float space = 1;
        for (int i = 0; i < numRand; i++) {
        var x = Mathf.Cos ((angle * speed)/ planet[i].getMass());
        var y = Mathf.Sin ((angle * speed)/ planet[i].getMass());
            sphere[i].transform.localScale = new Vector3(planet[i].getRadius(), planet[i].getRadius(), planet[i].getRadius());
            space = space + 10;

            sphere[i].transform.position = new Vector2(x * space , y * space);
        }
    }
}


