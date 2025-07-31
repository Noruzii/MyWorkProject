using UnityEngine;
using System.Collections; 
using UnityEngine.Networking; 
using System.Collections.Generic; 

public class StoryDataLoader : MonoBehaviour
{
    public static StoryDataLoader Instance { get; private set; }

    public event System.Action<List<StoryData>> OnStoriesLoaded;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        StartCoroutine(LoadStoriesFromJSON());
    }

    private IEnumerator LoadStoriesFromJSON()
    {
        string filePath = System.IO.Path.Combine(Application.streamingAssetsPath, "stories.json");

        UnityWebRequest request = UnityWebRequest.Get(filePath);
        yield return request.SendWebRequest(); 

        if (request.result == UnityWebRequest.Result.ConnectionError ||
            request.result == UnityWebRequest.Result.ProtocolError)
        {
            Debug.LogError("Error loading stories: " + request.error);
        }
        else
        {
            string jsonText = request.downloadHandler.text;

            try
            {
                StoryList storyList = JsonUtility.FromJson<StoryList>(jsonText);
                if (storyList != null && storyList.stories != null)
                {
                    List<StoryData> loadedStories = new List<StoryData>(storyList.stories);

                    OnStoriesLoaded?.Invoke(loadedStories);
                }
                else
                {
                    Debug.LogError("Failed to parse stories from JSON");
                }
            }
            catch (System.Exception e)
            {
                Debug.LogError("JSON parsing error: " + e.Message);
            }
        }
        request.Dispose(); 
    }
}