using UnityEngine;

using UnityEngine.UI;

public class Progress : MonoBehaviour {

    public Slider progressBar;

    [SerializeField] private float time;

    [SerializeField] private float progress;

    private void Start() {

        progressBar.value = 0;

    }

    private void Update() {

        if (time <= 0) {

            progress += Random.Range(0.001f, 0.03f);

            progressBar.value = progress;

            time = Random.Range(150f, 15000f);

        }

        if (time >= 0) {

            time -= Time.deltaTime;

        }

    }

}