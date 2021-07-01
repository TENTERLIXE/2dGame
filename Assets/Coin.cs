using UnityEngine;public class Coin : MonoBehaviour{    public float value = 1;    public string resourceName = "Gold";    private AudioSource _audioSource;    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }    public void Collect()    {        Resources.Find(resourceName).Change(value);        _audioSource.Play();        GetComponent<Collider2D>().enabled = false;        GetComponentInChildren<MeshRenderer>().enabled = false;        Destroy(gameObject, 2);    }}
