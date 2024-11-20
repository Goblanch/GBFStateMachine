using UnityEngine;

public class GBStateSOBase : ScriptableObject
{
    protected GBGenericController owner;

    public virtual void Initialize(GBGenericController owner){
        this.owner = owner;
    }

    public virtual void EnterState(){}
    public virtual void ExitState(){}
    public virtual void TickState(){}
    public virtual void PhysicsTickState(){}
}
