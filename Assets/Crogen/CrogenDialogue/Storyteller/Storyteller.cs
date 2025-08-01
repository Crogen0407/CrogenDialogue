using Crogen.CrogenDialogue.UI;
using UnityEngine;

namespace Crogen.CrogenDialogue
{
    public class Storyteller : MonoBehaviour
    {
        [field: SerializeField] public StorytellerBaseSO StorytellerBase { get; private set; }
		[field: SerializeField] public bool StartAndGo { get; private set; } = false;
		public TalkPanel DialogueUI { get; private set; }

		private void Start()
		{
			if (StartAndGo)
				Go();
		}

		public bool Go()
        {
			if (StorytellerBase.StartNode == null)
			{
				Debug.LogError("Start node is empty!");
				return false;
			}
			if (StorytellerBase.IsError() == true)
			{
				Debug.LogError("StorytellerBase is error!");
				return false;
			}

			StorytellerBase.StartNode.Go(this);

			return true;
		}

		public void SetTalk(string name, string talk)
		{

		}
	}
}
