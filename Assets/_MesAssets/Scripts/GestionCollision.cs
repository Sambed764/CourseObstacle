using UnityEngine;

public class GestionCollision : MonoBehaviour
{
    private bool _estToucher = false;
    
    private void OnCollisionEnter(Collision collision)
    {
        if(!_estToucher)
        {
            GetComponent<MeshRenderer>().material.color = Color.red;

            // Ajouter une collision
            GameManager.Instance.AugmenterCollisions();
            _estToucher = true;
        }
    }
}
