using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Crogen.CrogenDialogue.UI
{
    public class ChoicePanel : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _choiceText;
        [SerializeField] private Button _button;
        private ChoiceContainer _choiceContainer;

		public void Initialize(ChoiceContainer choiceContainer)
        {
            this._choiceContainer = choiceContainer;
			_button.onClick.AddListener(HandleChoiseSelectComplete);
		}

		public void SetText(string text) 
            => _choiceText.text = text;

		private void HandleChoiseSelectComplete() 
            => _choiceContainer.ChoiseSelectComplete();
	}
}
