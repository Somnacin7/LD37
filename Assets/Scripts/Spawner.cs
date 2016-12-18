using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Spawner : MonoBehaviour {

    public List<GameObject> items;
    public List<Transform> spawnPoints;
    public Vector2 intervalRange = new Vector2(1, 1);
    public bool active = true;

    private float interval;

    void Start() {
        SetInterval();
        StartCoroutine(SpawnItem());
    }

    IEnumerator SpawnItem() {
        yield return new WaitForSeconds(interval);

        if (active) {
            var spawner = spawnPoints[Random.Range(0, spawnPoints.Count)];
            var item = items[Random.Range(0, items.Count)];

            var go = GameObjectUtil.Instantiate(item, spawner.position);
            SetInterval();
        }
        StartCoroutine(SpawnItem());
    }

    void SetInterval() {
        interval = Random.Range(intervalRange.x, intervalRange.y);
    }
}
