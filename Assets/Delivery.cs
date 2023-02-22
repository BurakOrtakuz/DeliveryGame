using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;
    [SerializeField] Color32 hasPachageColor = new Color32(1,1,1,1); 
    [SerializeField] Color32 noPachageColor  = new Color32(1,1,1,1); 
    [SerializeField] float delayTime = 0.5f;
    SpriteRenderer spriteRenderer;
    public void Start()
    {
        hasPackage = false;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    public void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Ouch!!");    
    }
    public void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Package" && !hasPackage)
        {
            Debug.Log("Packege alindi");
            hasPackage = true;
            spriteRenderer.color = hasPachageColor;
            Destroy(other.gameObject, delayTime);
        }else if(other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Paket teslim edildi");
            hasPackage = false;
            spriteRenderer.color = noPachageColor;
        }
    }
}
