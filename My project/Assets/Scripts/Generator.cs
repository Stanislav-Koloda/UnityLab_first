using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{

    [SerializeField] private GameObject interactablePrefab;

    private float delay = 0.5f;
    private float timer = 0f;
    private int result =0;
    private int missedObjects = 0;


    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= delay)
        {
            timer = 0f;
            var x = Random.Range(-5f, 5f);
            var y = 3f;
            var position = new Vector3(x, y, 0f);

            var clickable = Instantiate(interactablePrefab, position, Quaternion.identity).GetComponent<ICollectable>();

            clickable.Initialixed(OnCOllectObject, OnMissedObject);

        }

    }
    private void OnCOllectObject()
    {
        result++;
        Debug.Log(result);
    }

    private void OnMissedObject()
    {
        missedObjects++;
        Debug.Log(missedObjects);

        if(missedObjects > 10)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

}
