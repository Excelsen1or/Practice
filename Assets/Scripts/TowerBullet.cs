using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerBullet : MonoBehaviour {
    public float bulletSpeed;
    public Transform target;
    public Tower tower;

    void Update() {
        if (target) {
            transform.position = Vector3.MoveTowards(transform.position, target.position, Time.deltaTime * bulletSpeed);
        } else {
            Destroy(gameObject);
        }
    }

   private void OnTriggerEnter(Collider other) {
        if (other.gameObject.transform == target) {
            target.GetComponent<MoveEnemies>().hp.GetComponent<HealthBar>().Damage(tower.damage);
            Destroy(gameObject);
        }
    }
}
