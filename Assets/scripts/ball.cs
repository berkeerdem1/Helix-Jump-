using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpforce;
    public GameObject splashPrefab;
    public gamemanager gm;
    void Start()
    {
        gm = FindObjectOfType<gamemanager>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision other)
    {
        rb.AddForce(Vector3.up * jumpforce);
        GameObject splash = Instantiate(splashPrefab, transform.position + new Vector3(0f, -0.2f, 0f), transform.rotation);
        splash.transform.SetParent(other.gameObject.transform);


        string materialName = other.gameObject.GetComponent<MeshRenderer>().material.name;
        Debug.Log("materyal adı:" + materialName);

        if (materialName == "unsafe color (Instance)")
        {
            gm.restartgame();
        }
        else if (materialName == "Last Ring (Instance)")
        {
            Debug.Log("next level");
        }
    }
}
