using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDragon : MonoBehaviour
{
    public GameObject dragonEggPrefab;
    public GameObject bombPrefab;
    public float speed = 1;
    public float timeBetweenItemDrops = 2f;
    public float leftRightDistance = 10f;
    public float chanceDirection = 0.1f;
    void Start()
    {
        Invoke("ChooseItem", timeBetweenItemDrops);
    }

    void ChooseItem()
    {
        var rnd = new System.Random();
        int number = rnd.Next(1, 3);
        if (number == 1) {
            DropEgg();
        }
        else {
            DropBomb();
        }
        Invoke("ChooseItem", timeBetweenItemDrops);
    }

    void DropEgg()
    {
        Vector3 myVector = new Vector3(0.0f, 5.0f, 0.0f);
        GameObject egg = Instantiate<GameObject>(dragonEggPrefab);
        egg.transform.position = transform.position + myVector;
    }

    void DropBomb()
    {

        Vector3 myVector = new Vector3(0.0f, 5.0f, 0.0f);
        GameObject bomb = Instantiate<GameObject>(bombPrefab);
        bomb.transform.position = transform.position + myVector;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        if (pos.x < -leftRightDistance)
        {
            speed = Mathf.Abs(speed);
        }
        else if (pos.x > leftRightDistance) { 
            speed = -Mathf.Abs(speed);
        }
    }

    private void FixedUpdate()
    {
        if (Random.value < chanceDirection)
        {
            speed *= -1;
        }
    }
}
