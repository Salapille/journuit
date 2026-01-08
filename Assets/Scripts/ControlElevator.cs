using UnityEngine;

public class ControlElevator : MonoBehaviour
{
    [SerializeField] private Elevator elevatorDroite;
    [SerializeField] private Elevator elevatorGauche;
    [SerializeField] private int firstElevator;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void InteractionElevator()
    {
        if (firstElevator == 0)
        {
            elevatorGauche.ToTop();
            elevatorDroite.ToBottom();
        }
        else
        {
            elevatorGauche.ToBottom(); 
            elevatorDroite.ToTop();
        }
    }

}
