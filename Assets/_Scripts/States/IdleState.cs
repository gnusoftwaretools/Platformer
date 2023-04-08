using UnityEngine;

namespace _Scripts.States
{
    public class IdleState : State
    {
        public State MoveState;
        protected override void EnterState()
        {
            agent.animationManager.PlayAnimation(AnimationType.idle);
        }

        protected override void HandleMovement(Vector2 input)
        {
            if (Mathf.Abs(input.x) > 0)
            {
                agent.TransitionToState(MoveState);
            }
        }
    }
}