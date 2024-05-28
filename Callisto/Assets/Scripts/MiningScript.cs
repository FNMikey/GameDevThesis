using UnityEngine;

public class MiningScript : MonoBehaviour
{

    public GameObject kamienPrefab;
    public GameObject srebroPrefab;
    public GameObject zlotoPrefab;
    public int health = 10;

    [Range(0, 100)] public int kamienChance = 70;
    [Range(0, 100)] public int srebroChance = 20;
    [Range(0, 100)] public int zlotoChance = 10;

    public float miningRange = 2.0f;
    private GameObject player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            TryMine();
        }
    }

    void TryMine()
    {
        float distance = Vector3.Distance(player.transform.position, transform.position);

        if (distance <= miningRange)
        {
            int randomValue = Random.Range(0, 100);

            if (randomValue < kamienChance)
            {
                Instantiate(kamienPrefab, transform.position + Vector3.up, Quaternion.identity);
            }
            else if (randomValue < kamienChance + srebroChance)
            {
                Instantiate(srebroPrefab, transform.position + Vector3.up, Quaternion.identity);
            }
            else if (randomValue < kamienChance + srebroChance + zlotoChance)
            {
                Instantiate(zlotoPrefab, transform.position + Vector3.up, Quaternion.identity);
            }

            TakeDamage();
        }
    }

    void TakeDamage()
    {

        health -= 2;

        if (health <= 0) {

            Destroy(gameObject);

        }

        Debug.Log(health.ToString());
    
    }

}
