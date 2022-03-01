using UnityEngine;

public class Portal : MonoBehaviour
{
  public Vector3 scale = new Vector3(0.5f, 0.5f, 0.5f);
  private bool isModified = false;
  public GameObject player;
  Vector3 playerScale;
    void Start()
    {
      playerScale = player.transform.localScale;
      Debug.Log(playerScale);
    }

    void Update()
    {
        
    }
    void OnTriggerExit(Collider other) {
      if (other.gameObject.name == "Player")
      {
        if (!isModified)
        {
          other.gameObject.transform.localScale -= scale;
          isModified = true;
        }
        else
        {
          other.gameObject.transform.localScale = playerScale;
          isModified = false;
        }
      }
    }
}
