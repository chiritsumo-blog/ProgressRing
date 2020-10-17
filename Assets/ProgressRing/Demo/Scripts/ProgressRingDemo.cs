using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace chiritsumo
{
    public class ProgressRingDemo : MonoBehaviour
    {
        /// <summary>
        /// ProgressRing
        /// </summary>
        [SerializeField]
        private ProgressRing m_prgRing = null;

        /// <summary>
        /// 操作用 Slider
        /// </summary>
        [SerializeField]
        private Slider m_slider = null;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void SliderValueChange()
        {
            m_prgRing.SetProgress(m_slider.value);
        }
    }

}
