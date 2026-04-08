using UnityEngine;

namespace Motor.Runtime
{
    public class MotorController : MonoBehaviour
    {
        #region Unity API

        private void Update()
        {
            if (!headAnchor) return;
            if (isActive) RotateMotorHead();

        }

        #endregion
        
        #region Utils



        private void RotateMotorHead()
        {
            if (isReverse)
            {
                headAnchor.Rotate(Vector3.up * (90f * speed * -1f * Time.deltaTime),Space.Self);
            }
            else
            {
                headAnchor.Rotate(Vector3.up * (90f * speed * 1f * Time.deltaTime),Space.Self);
            }
        }

        #endregion
        
        
        
        
        #region Private and Protected
        

        [Header("Dev properties")]
        [SerializeField] private Transform headAnchor;
        
        [Header("Designer properties")]
        [SerializeField][Range(0f,100f)] private float speed = 1f;
        [SerializeField] private bool isActive;
        [SerializeField] private bool isReverse;


        #endregion

    }
}
