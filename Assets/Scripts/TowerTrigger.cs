using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerTrigger : MonoBehaviour {
    public Tower tower;
    public bool lockEnemy;
    public GameObject currentTarget;

    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("enemyLight") && !lockEnemy) {
            tower.target = other.gameObject.transform;
            currentTarget = other.gameObject;
            lockEnemy = true;
        }
    }

    void Update() {
        if (!currentTarget) {
            lockEnemy = false;
        }
    }

    void OnTriggerExit(Collider other) {
        if (other.CompareTag("enemyLight") && other.gameObject == currentTarget) {
            lockEnemy = false;
        }
    }
}
