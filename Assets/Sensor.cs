
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider2D))]
public class Sensor : MonoBehaviour
{
    [SerializeField] private string targetTag;
    [SerializeField] UnityEvent onTrigger;

    private void  OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag(targetTag))
            onTrigger.Invoke();
    }
}
