
using UnityEngine;

public class StarCollector : MonoBehaviour
{
    [SerializeField] private CounterController counter;
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        print(other.transform.tag);
        if (other.transform.CompareTag("Star"))
        {
            counter.Increment();
            Destroy(other.gameObject);
        }
    }
}
