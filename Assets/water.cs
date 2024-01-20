using UnityEngine;

public class Water : MonoBehaviour
{
        [SerializeField] private int value; 
private bool hasTriggered; 

private void OnTriggerEnter2D(Collider2D collision)
 {
if (collision. CompareTag("Player") && !hasTriggered) 
{
hasTriggered = true;
Destroy(gameObject); //give score to player; Destroy(ganeObject);
}
}
}