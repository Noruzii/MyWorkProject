using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using TMPro;

public class StoryDisplayUI : MonoBehaviour
{
    [Header("UI References")]
    public Transform storyListContentParent;
    public GameObject storyItemPrefab;

    [Header("Story Playback UI")]
    public GameObject storyDetailsPanel;
    public TMP_Text storyDescriptionText;


    private void Awake()
    {
        if (storyDetailsPanel != null)
        {
            storyDetailsPanel.SetActive(false);
        }
    }

    private void Start()
    {
        if (StoryDataLoader.Instance != null)
        {
            StoryDataLoader.Instance.OnStoriesLoaded += DisplayStories;
        }
    }

    private void OnEnable()
    {

    }

    private void OnDisable()
    {
        if (StoryDataLoader.Instance != null)
        {
            StoryDataLoader.Instance.OnStoriesLoaded -= DisplayStories;
        }
    }

    private void DisplayStories(List<StoryData> stories)
    {
        foreach (Transform child in storyListContentParent)
        {
            Destroy(child.gameObject);
        }

        foreach (StoryData story in stories)
        {
            GameObject itemGO = Instantiate(storyItemPrefab, storyListContentParent);

            TMP_Text titleText = itemGO.GetComponentInChildren<TMP_Text>();

            if (titleText != null)
            {
                titleText.text = story.title;
            }

            Button button = itemGO.GetComponent<Button>();
            if (button != null)
            {
                button.onClick.AddListener(() => OnStoryClicked(story));
            }
        }
    }

    private void OnStoryClicked(StoryData story)
    {

        if (storyDetailsPanel != null && storyDescriptionText != null)
        {
            storyDescriptionText.text = story.description;
            storyDetailsPanel.SetActive(true);
        }
    }

    public void CloseStoryDetailsPanel()
    {
        if (storyDetailsPanel != null)
        {
            storyDetailsPanel.SetActive(false);
        }
    }
}