using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWaves : MonoBehaviour {
    public int WaveSize;
    public GameObject EnemyPrefab;
    public float SpawnInterval;
    public Transform SpawnPoint;
    public float StartTime;
    public Transform[] WayPoints;
    int EnemyCount = 0;
    public GameObject Hp;
    public GameObject canvas;

    void Start() {
        InvokeRepeating("SpawnEnemy", StartTime, SpawnInterval);
    }

    void Update() {
        if (WaveSize == EnemyCount) {
            CancelInvoke("SpawnEnemy");
        }
    }

    void SpawnEnemy() {
        EnemyCount++;
        GameObject enemy = Instantiate(EnemyPrefab, SpawnPoint.position, Quaternion.identity);
        enemy.GetComponent<MoveEnemies>().waypoints = WayPoints;
        
        GameObject hp = Instantiate(Hp, Vector3.zero, Quaternion.identity);
        hp.transform.SetParent(canvas.transform);
        hp.GetComponent<HealthBar>().enemy = enemy;
        enemy.GetComponent<MoveEnemies>().hp = hp;
    }
}
