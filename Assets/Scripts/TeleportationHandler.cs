using UnityEngine;
using UnityEngine.Events;
public class TeleportationHandler : MonoBehaviour
{
    public MeshRenderer TeleportationBase;
    public TeleportationType TeleportationType;
    public UnityEvent OnTeleportationEnter; 
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            DisableTeleportation();
            if(TeleportationType == TeleportationType.K2Teleportation)
            {
                DoAction();
            }
            //Teleportation.SetActive(false);
        }
    }

    public void DoAction()
    {
        OnTeleportationEnter.Invoke();
    }

    private void DisableTeleportation()
    {
        gameObject.GetComponent<MeshRenderer>().enabled = false;
        gameObject.GetComponent<CapsuleCollider>().enabled = false;
        TeleportationBase.enabled = false;

    }


}


public enum TeleportationType
{
    None,
    K2Teleportation
}