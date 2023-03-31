//using UnityEngine;

//public class NPCController : MonoBehaviour
//{
//    public float moveSpeed = 5f;
//    public float maxDistanceToTarget = 0.1f;
//    public LayerMask obstacleLayer;
//    public float detectionRadius = 1f;
//    private Vector3 targetPosition;
//    public Rigidbody rb;
//    public StateManager stateM;
//    private void Start()
//    {
//        // Define a posi��o inicial do NPC para uma posi��o aleat�ria no plano X-Z
//        targetPosition = new Vector3(Random.Range(-50f, 50f), transform.position.y, Random.Range(-50f, 50f));
//    }

//    private void Update()
//    {
//        stateM.RunCurrentState();
//        // Calcula a dire��o para a posi��o alvo
//        Vector3 direction = (targetPosition - transform.position).normalized;
//        direction.y = 0f; // Define a componente Y como 0 para prevenir movimento no eixo Y

//        // Detecta obst�culos na frente do NPC
//        Collider[] obstacles = Physics.OverlapSphere(transform.position, detectionRadius, obstacleLayer);
//        if (obstacles.Length > 0)
//        {
//            // Se houver obst�culos na frente, escolhe uma nova posi��o alvo aleat�ria
//            targetPosition = new Vector3(Random.Range(-50f, 50f), transform.position.y, Random.Range(-50f, 50f));
//            //rb.MovePosition(targetPosition * Time.deltaTime);
//            transform.Translate(targetPosition * moveSpeed * Time.deltaTime, Space.World);
//        }
//        else
//        {
//            // Move o NPC no eixo X-Z em dire��o � posi��o alvo
//            transform.position += new Vector3(direction.x * moveSpeed * Time.deltaTime, 0f, direction.z * moveSpeed * Time.deltaTime);

//            // Se o NPC estiver pr�ximo o suficiente da posi��o alvo, escolhe uma nova posi��o alvo aleat�ria
//            if (Vector3.Distance(transform.position, targetPosition) < maxDistanceToTarget)
//            {
//                targetPosition = new Vector3(Random.Range(-50f, 50f), transform.position.y, Random.Range(-50f, 50f));
//            }
//        }
//    }

//    private void OnDrawGizmosSelected()
//    {
//        // Desenha uma esfera representando a �rea de detec��o de obst�culos
//        Gizmos.color = Color.red;
//        Gizmos.DrawWireSphere(transform.position, detectionRadius);
//    }
//}

