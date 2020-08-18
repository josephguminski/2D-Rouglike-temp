using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.PlayerLoop;

public class CharacterSelection : MonoBehaviour
{
    private int selectedCharacterIndex;

    [Header("List of characters")]
    [SerializeField] private List<CharacterSelectObject> 
        characterList = new List<CharacterSelectObject>();
     

    [Header("UI References")]
    [SerializeField] private TextMeshProUGUI characterName;
    [SerializeField] private TextMeshProUGUI characterDetails;
    [SerializeField] private Image characterSplash;
    [SerializeField] private Image backgroundcolor;
    [SerializeField] private Image characterInfo;

    [Header("Sounds")]
    [SerializeField] private AudioClip arrowClicksSFX;

    private void Start()
    {
        UpdateCharacterSelectionUI();
    }

    public void LeftArrow()
    {
        selectedCharacterIndex--;
        if (selectedCharacterIndex < 0)
            selectedCharacterIndex = characterList.Count - 1;

        UpdateCharacterSelectionUI();
    }
     public void RightArrow()
    {
        selectedCharacterIndex++;
        if (selectedCharacterIndex == characterList.Count)
            selectedCharacterIndex = 0;

        UpdateCharacterSelectionUI();
    }

    public void ConfirmButton()
    {

    }


    private void UpdateCharacterSelectionUI()
    {
       characterSplash.sprite = characterList[selectedCharacterIndex].splash;
       characterName.text = characterList[selectedCharacterIndex].characterName;
       characterDetails.text = characterList[selectedCharacterIndex].characterDetails;
    }

    [System.Serializable]
    public class CharacterSelectObject
    {
        public Sprite splash;
        public string characterName;
        public string characterDetails;
    }
}
