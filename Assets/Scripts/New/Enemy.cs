using UnityEngine;

public class Enemy : MonoBehaviour
{
     
    [SerializeField] Transform exit;
    [SerializeField] Transform[] wayPoints;
    [SerializeField] float navigationSpeed = 1f;

    Transform enemy;
    float currentDistance = 0f;
    int target = 0;

    void Start()
    {
        enemy = GetComponent<Transform>();
    }

    void Update()
    {
        if (wayPoints != null && target < wayPoints.Length)
        {
            currentDistance += Time.deltaTime * navigationSpeed;
            Vector3 currentPosition = enemy.position;
            Vector3 nextPosition = wayPoints[target].position;

            enemy.position = Vector3.MoveTowards(currentPosition, nextPosition, navigationSpeed * Time.deltaTime);

            if (Vector3.Distance(currentPosition, nextPosition) < 0.01f)
            {
                target++;
                currentDistance = 0f;
            }
            transform.LookAt(wayPoints[target]);
        }
        else if (exit != null)
        {
            enemy.position = Vector3.MoveTowards(enemy.position, exit.position, navigationSpeed * Time.deltaTime);
        }
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "MovingPoint")
        {
            target++;
        }
        else if (collision.tag == "Finish")
        {
            Manager.Instance.removeEnemyFromScreen();
            Destroy(gameObject);
        }
    }
}
