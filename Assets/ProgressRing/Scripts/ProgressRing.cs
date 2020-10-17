using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace chiritsumo
{
    public class ProgressRing : MonoBehaviour
    {
        /// <summary>
        /// プログレスリング Image
        /// </summary>
        [SerializeField]
        private Image m_imgPrgRing = null;

        /// <summary>
        /// プログレス値(%) Text
        /// </summary>
        [SerializeField]
        private Text m_txtValue = null;

        /// <summary>
        /// プログレス単位 Text
        /// </summary>
        [SerializeField]
        private Text m_txtUnit = null;

        /// <summary>
        /// プログレス値
        /// </summary>
        [SerializeField]
        [Range(0, 1.0f)]
        private float m_fProgress = 0.0f;

        /// <summary>
        /// プログレスリング色
        /// </summary>
        [SerializeField]
        private Color m_colorRing = Color.red;

        //--------------------------------------------------------------------------

        /// <summary>
        /// Start : 初期処理
        /// </summary>
        void Start()
        {
            SetProgress(m_fProgress);
            SetColor();
        }

#if UNITY_EDITOR
        /// <summary>
        /// Onvaldate:Inspectorで値が変更された時呼び出される
        /// </summary>
        private void OnValidate()
        {
            SetProgress(m_fProgress);
            SetColor();
        }
#endif

        //--------------------------------------------------------------------------

        /// <summary>
        /// プログレス値設定
        /// </summary>
        /// <param name="fProgress"></param>
        public void SetProgress(float fProgress)
        {
            // メンバ変数に設定
            m_fProgress = fProgress;

            // Fill Amount 設定
            if (m_imgPrgRing != null)
            {
                m_imgPrgRing.fillAmount = fProgress;
            }

            // テキスト設定
            if (m_txtValue != null)
            {
                int nPercent = (int)(fProgress * 100.0f);
                m_txtValue.text = nPercent.ToString();
            }
        }

        //--------------------------------------------------------------------------

        /// <summary>
        /// 色設定
        /// </summary>
        private void SetColor()
        {
            if (m_imgPrgRing != null)
            {
                m_imgPrgRing.color = m_colorRing;
            }

            if (m_txtUnit != null)
            {
                m_txtUnit.color = m_colorRing;
            }
        }
    }

}
