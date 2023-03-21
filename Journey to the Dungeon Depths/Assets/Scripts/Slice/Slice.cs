using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Slice : MonoBehaviour {
    public static Slice instance;
    public static UnityEvent finishAttack = new UnityEvent();
    private new Camera camera;

    [SerializeField]private GameObject sliceCollider;
    [SerializeField]private GameObject attackPrefab;
    private List<Vector3> attackLine = new List<Vector3>();

    private TrailRenderer trail;
    private new EdgeCollider2D collider;

    private void Awake() {
        if (instance == null) {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else {
            Destroy(gameObject);
        }
    }

    private void Start() {
        camera = Camera.main;
        trail = GetComponent<TrailRenderer>();

        GameObject newCollider = Instantiate(sliceCollider);
        collider = newCollider.GetComponent<EdgeCollider2D>();

        DontDestroyOnLoad(newCollider);
    }

    private void Update() {
        UpdateMovement();
        UpdateCollider();
        UpdateAttack();
    }

    private void UpdateMovement() {
        Vector2 mousePosition = camera.ScreenToWorldPoint(Input.mousePosition);
    
        if (Input.GetMouseButtonDown(0)) {
            ResetPosition(mousePosition);
        }

        if (Input.GetMouseButton(0)) {
            transform.position = mousePosition;
        }
    }

    private void UpdateCollider() {
        List<Vector2> points = new List<Vector2>();

        collider.enabled = true;
        if (trail.positionCount < 2) {
            collider.enabled = false;
        }

        for (int i = 0; i < trail.positionCount; i++) {
            points.Add(trail.GetPosition(i));
        }


        collider.SetPoints(points);
    }

    private void UpdateAttack() {
        if (Input.GetMouseButtonUp(0)) {
            FinishAttack();
        }
    }

    private void ResetPosition(Vector2 position) {
        transform.position = position;
        trail.Clear();
    }

    private void FinishAttack() {
        UpdateCollider();
        finishAttack.Invoke();

        trail.Clear();
        attackLine.Clear();
    }

    public void SetAttack(Vector2 position) {
        attackLine.Add(position);

        if (attackLine.Count == 2) {
            GameObject newAttack = Instantiate(attackPrefab);
            LineRenderer lineRenderer = newAttack.GetComponent<LineRenderer>();

            lineRenderer.positionCount += 2;
            lineRenderer.SetPositions(attackLine.ToArray());

            FinishAttack();
        }
    }
}