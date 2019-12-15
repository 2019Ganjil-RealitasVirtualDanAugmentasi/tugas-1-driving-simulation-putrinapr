using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public GameObject pickupEffect;
    public float duration = 10f;

    void OnTriggerEnter (Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(Pickup(other));
        }
    }

    IEnumerator Pickup(Collider player)
    {
        Debug.Log("Power up picked up!");

        Instantiate(pickupEffect, transform.position, transform.rotation);

        PlayerStats stats = player.GetComponent<PlayerStats>();
        stats.rb.drag = 0;

        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;

        yield return new WaitForSeconds(duration);

        stats.rb.drag += 0.25f;

        Destroy(gameObject);
    }
}
