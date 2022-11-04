using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class VersionNumberDisplay : MonoBehaviour
{
	[SerializeField] private TMP_Text versionNumberText;

	private void Awake()
	{
		versionNumberText.text = $"Version {Application.version}";
	}
}
