using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FireBulletOnValidate : MonoBehaviour
{
    public ParticleSystem particles;

    public GameObject bullet;
    public Transform spawnPoint;
    public float fireSpeed = 20;

    private bool hasFired = false;

    void Start()
    {
        XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
        grabbable.activated.AddListener(FireBullet);
    }

    void Update()
    {

    }

    public void FireBullet(ActivateEventArgs arg)
    {
        if (!hasFired)
        {
            particles.Play();
            hasFired = true;

            StartCoroutine(ResetFire());
        }

        GameObject spawnBullet = Instantiate(bullet);
        spawnBullet.transform.position = spawnPoint.position;
        spawnBullet.GetComponent<Rigidbody>().velocity = spawnPoint.forward * fireSpeed;
        Destroy(spawnBullet, 5);
    }

    IEnumerator ResetFire()
    {
        yield return new WaitForSeconds(0.2f);
        hasFired = false;
    }
}
