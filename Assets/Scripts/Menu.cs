using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public bool GameIsPaused = false;

    [SerializeField]
    private GameObject messagePanel;
    [SerializeField]
    private PauseMenu pause;

    private GameObject _interactable;
    private GameObject _player;
    //private PlayerController _playerController;

    private void Start()
    {
        _player = GameObject.FindWithTag("Player");
        //_playerController = _player.GetComponent<PlayerController>();
    }

    public void GoToZone(int zoneId = 0)
    {
        //_playerController.CanMove(false);
        SceneManager.LoadScene(zoneId);
    }

    public void GoToZoneWithDesrtoy(int zoneId = 0)
    {
       // _playerController.CanMove(false);
        //GameManager.Instance.DestroyAll();
        SceneManager.LoadScene(zoneId);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pause.Toggle();
        }
        else if (_interactable is not null)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                _interactable.SetActive(!_interactable.activeSelf);
                messagePanel.SetActive(!messagePanel.activeSelf);
            }
        }
    }

    public void SetInteractable(GameObject interactable)
    {
        _interactable = interactable;
    }

    public void RemoveInteractable()
    {
        _interactable?.SetActive(false);
        _interactable = null;
    }

    public void ShowMessage(string message)
    {
        TextMeshProUGUI tmp = messagePanel.GetComponentInChildren(typeof(TextMeshProUGUI)) as TextMeshProUGUI;
        tmp.text = message;
        messagePanel.SetActive(true);
    }

    public void HideMessage()
    {
        messagePanel.SetActive(false);
    }

    public void Quit()
    {
        GoToZone();
        //GameManager.Instance.DestroyAll();
    }
}
