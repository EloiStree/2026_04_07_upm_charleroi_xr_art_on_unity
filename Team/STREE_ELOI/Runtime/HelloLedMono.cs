using UnityEngine;
using UnityEngine.Events;

namespace Eloi.ArtXR
{
    public class HelloLedMono : MonoBehaviour
    {

        [SerializeField] MeshRenderer m_meshToAffect;
        [SerializeField] Color m_colorWhenOn = Color.red;
        [SerializeField] Color m_colorWhenOff = Color.red*0.05f;

        [SerializeField] bool m_isOn = false;

        [Header("Events")]
        public UnityEvent<Color> m_onColorChanged;
        public UnityEvent<bool> m_onStateChanged;
        public UnityEvent m_onTurnedOn;
        public UnityEvent m_onTurnedOff;

        private void Start()
        {
            Debug.Log("Hello Led ;)");
            SetAsOn(m_isOn);
        }   

        public void SetAsOn(bool isOn)
        {
            bool changed= m_isOn != isOn;
            m_isOn = isOn;
            Color color =isOn? m_colorWhenOn:m_colorWhenOff;

            if (m_meshToAffect != null)
            {
                m_meshToAffect.material.color = color;
            }
            m_onColorChanged?.Invoke(color);
            if (changed) {
                m_onStateChanged?.Invoke(true);
                if (isOn)
                { 
                    m_onTurnedOn?.Invoke();
                }
                else           {
                    m_onTurnedOff?.Invoke();
                }
            }
        }
        [ContextMenu("Turn On")]
        public void TurnOn()
        {
            SetAsOn(true);
        }
        [ContextMenu("Turn Off")]
        public void TurnOff()
        {
            SetAsOn(false);
            m_onStateChanged?.Invoke(false);
            m_onTurnedOff?.Invoke();
        }

        public bool IsOn() { return m_isOn; }
       
    }
}
