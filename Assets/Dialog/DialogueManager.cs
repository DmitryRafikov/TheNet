using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// The dialogue manager is resposible for adding new dialogue boxes to the conversion when requested
public class DialogueManager : MonoBehaviour {

	[SerializeField] private GameObject dialogueContainer;
	[SerializeField] private GameObject textBoxPrefab;

	RectTransform containerRectTrans;

	// Keeps track of the transform of the previous addition
	private RectTransform lastRectTransformChange = null;

	void Awake ()
	{
		containerRectTrans = dialogueContainer.GetComponent<RectTransform>();
	}

	void AddDialogueBox()
	{
		RectTransform containerRectTrans = dialogueContainer.GetComponent<RectTransform>();

		GameObject newBox = Instantiate(textBoxPrefab, dialogueContainer.transform, false) as GameObject;
		RectTransform newRectTrans = newBox.GetComponent<RectTransform>();

		// If this isn't the first dialog box being added
		if (lastRectTransformChange != null)
		{
			Vector2 newPos = new Vector2(lastRectTransformChange.localPosition.x, 
										 lastRectTransformChange.localPosition.y - newRectTrans.rect.height);

			newRectTrans.localPosition = newPos;

		}

		lastRectTransformChange = newRectTrans;

		CheckContainerLength();
	}

	// Checks if the dialogue items have ran off the container length and adjusts accordingly
	void CheckContainerLength()
	{
		// If the last item goes off the bottom edge of the container
		if (containerRectTrans.rect.y > lastRectTransformChange.localPosition.y)
		{	
			float extendDistance = Mathf.Abs(lastRectTransformChange.rect.y) + lastRectTransformChange.rect.height/2;
			
			// Resizing the container extends it in both directions, so we must reposition it accordingly 
			Vector2 newPos = new Vector2(containerRectTrans.localPosition.x, 
										 containerRectTrans.localPosition.y - extendDistance/2);

			containerRectTrans.sizeDelta = new Vector2(0f, containerRectTrans.sizeDelta.y + extendDistance);
			containerRectTrans.localPosition = newPos;
		}
	}


	void OnGUI()
	{
		if (GUI.Button(new Rect(20, 40, 100, 200), "Add box" ))
		{
			AddDialogueBox();
		}
	}
}
