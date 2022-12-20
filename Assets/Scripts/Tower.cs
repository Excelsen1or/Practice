using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour {
    public Transform shootElement;
    public Transform lookAtObject;
    public int damage = 10;
    public float shootingDelay;
    public float shootingRange;
    public GameObject bullet;
    public Transform target;
    bool isShoot;

    void Start() {
        
    }

    void Update() {
        if (target) {
            lookAtObject.transform.LookAt(target);
            if (!isShoot) {
                StartCoroutine(Shoot());
            }
        }
    }

    IEnumerator Shoot() {
        isShoot = true;
        yield return new WaitForSeconds(shootingDelay);
        GameObject bulletObj = Instantiate(bullet, shootElement.position, Quaternion.identity);
        bulletObj.GetComponent<TowerBullet>().target = target;
        bulletObj.GetComponent<TowerBullet>().tower = this;
        isShoot = false;
    }
}
