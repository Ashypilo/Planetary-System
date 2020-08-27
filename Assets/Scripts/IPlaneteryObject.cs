using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum MassClass
{
    Asteroidan,
    Mercurian,
    Subterran,
    Terran,
    Superterran,
    Neptunian,
    Jovian
}

public class IPlaneteryObject
{

    private MassClass massClass;

    private float mass;
    private float radius;
    private int rand;

    public void init() {

        rand = Random.Range(0, 6);
        switch (rand) {
            case 0:
                massClass = MassClass.Asteroidan;
                mass = Random.Range(0f, 0.00001f);
                radius = Random.Range(0f, 0.03f);
                break;
            case 1:
                massClass = MassClass.Mercurian;
                mass = Random.Range(0.00001f, 0.1f);
                radius = Random.Range(0.03f, 0.7f);
                break;
            case 2:
                massClass = MassClass.Subterran;
                mass = Random.Range(0.1f, 0.5f);
                radius = Random.Range(0.5f, 1.2f);
                break;
            case 3:
                massClass = MassClass.Terran;
                mass = Random.Range(0.5f, 2f);
                radius = Random.Range(0.8f, 1.9f);
                break;
            case 4:
                massClass = MassClass.Superterran;
                mass = Random.Range(2f, 10f);
                radius = Random.Range(1.3f, 3.3f);
                break;
            case 5:
                massClass = MassClass.Neptunian;
                mass = Random.Range(10f, 50f);
                radius = Random.Range(2.1f, 5.7f);
                break;
            case 6:
                massClass = MassClass.Jovian;
                mass = Random.Range(50f, 5000f);
                radius = Random.Range(3.5f, 27f);
                break;
            default:
                break;
        }
    }

    public MassClass getClass() {
        return massClass;
    }

    public float getMass() {
        return mass;
    }

    public float getRadius() {
        return radius;
    }

}
