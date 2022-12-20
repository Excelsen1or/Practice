using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemies : MonoBehaviour {
    public float Speed;
    public Transform[] waypoints;
    int CurrentWaypointIndex = 0;
    public GameObject hp;

    void Update() {
        if (CurrentWaypointIndex < waypoints.Length) {
            transform.position = Vector3.MoveTowards(transform.position, waypoints[CurrentWaypointIndex].position, Time.deltaTime * Speed);
            transform.LookAt(waypoints[CurrentWaypointIndex].position);
            if (Vector3.Distance(transform.position, waypoints[CurrentWaypointIndex].position) < 0.5f) {
                CurrentWaypointIndex++;
            }
        }

        if (hp.GetComponent<HealthBar>().currentHealth <= 0) {
            Destroy(gameObject);
            Destroy(hp);
        }
    }
}
