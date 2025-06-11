using UnityEngine;

public class PlayerInteractor : MonoBehaviour {
    public float interactRadius = 2f;
    void Update() {
        if (Input.GetKeyDown(KeyCode.E)) {
            Collider[] hits = Physics.OverlapSphere(transform.position, interactRadius);
            foreach (var col in hits) {
                var inter = col.GetComponent<IInteractable>();
                if (inter != null) { inter.Interact(); break; }
            }
        }
    }
    void OnDrawGizmosSelected() {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, interactRadius);
    }
}
