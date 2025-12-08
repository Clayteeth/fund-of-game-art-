using UnityEngine;

public class LeafCrunch : MonoBehaviour
{

    public AudioSource audioSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Leaf" && !audioSource.isPlaying)
        {
            audioSource.Play();
            Debug.Log("On leaf");
        }
    }
}
