using UnityEngine;

public class GoldenWall : MonoBehaviour
{
  public GameObject player;
  private float timeRemaining = 2f;
  private bool timerIsActive = false;
    void Start()
    {
      timerIsActive = true;
    }

    void Update()
    {

    }
    void Teleport()
    {
      player.transform.position = new Vector3(Random.Range(0f, 6f), Random.Range(0f, 6f), Random.Range(0f, 6f));
      player.transform.rotation = new Quaternion(Random.Range(0f, 6f), Random.Range(0f, 6f), Random.Range(0f, 6), Random.Range(0f, 6f));
    }
    void OnTriggerStay(Collider other) {
      if (other.gameObject.name == "Player")
      {
          if (timeRemaining > 0)
          {
            timeRemaining -= Time.deltaTime;
          } else 
          {
            Teleport();
            timeRemaining = 2f;
          }
        }
    }
}
