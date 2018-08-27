using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireGun : MonoBehaviour {
    [SerializeField] GameObject bullet;
    [SerializeField] float fireRate = 1;
    [SerializeField] GameObject bulletEmitter;

    private float timerLastShot = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timerLastShot += Time.deltaTime;
        if(timerLastShot > fireRate)
        {
            var fire1 = Input.GetAxis("Fire1");
            if (fire1 > 0)
            {
                Instantiate(bullet, bulletEmitter.transform.position, bulletEmitter.transform.rotation);
                timerLastShot = 0;
            }
        }
	}
}
