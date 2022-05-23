using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckNetworkScript : MonoBehaviour
{
    [SerializeField] private GameObject _networkPanel;
    public void CheckNetwork()
    {
        if (!(Application.internetReachability == NetworkReachability.NotReachable))
        {
            _networkPanel.SetActive(false);
        }
    }

    private void Awake()
    {
        CheckNetwork();
    }

    
}
