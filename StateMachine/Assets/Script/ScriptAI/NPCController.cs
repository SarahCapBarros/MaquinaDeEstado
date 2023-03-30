using UnityEngine;

public class NPCController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float maxDistanceToTarget = 0.1f;
    public LayerMask obstacleLayer;
    public float detectionRadius = 1f;
    private Vector3 targetPosition;

    private void Start()
    {
        // Define a posição inicial do NPC para uma posição aleatória no plano X-Z
        targetPosition = new Vector3(Random.Range(-10f, 10f), transform.position.y, Random.Range(-10f, 10f));
    }

    private void Update()
    {
        // Calcula a direção para a posição alvo
        Vector3 direction = (targetPosition - transform.position).normalized;
        direction.y = 0f; // Define a componente Y como 0 para prevenir movimento no eixo Y

        // Detecta obstáculos na frente do NPC
        Collider[] obstacles = Physics.OverlapSphere(transform.position, detectionRadius, obstacleLayer);
        if (obstacles.Length > 0)
        {
            // Se houver obstáculos na frente, escolhe uma nova posição alvo aleatória
            targetPosition = new Vector3(Random.Range(-10f, 10f), transform.position.y, Random.Range(-10f, 10f));
        }
        else
        {
            // Move o NPC no eixo X-Z em direção à posição alvo
            transform.position += new Vector3(direction.x * moveSpeed * Time.deltaTime, 0f, direction.z * moveSpeed * Time.deltaTime);

            // Se o NPC estiver próximo o suficiente da posição alvo, escolhe uma nova posição alvo aleatória
            if (Vector3.Distance(transform.position, targetPosition) < maxDistanceToTarget)
            {
                targetPosition = new Vector3(Random.Range(-10f, 10f), transform.position.y, Random.Range(-10f, 10f));
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        // Desenha uma esfera representando a área de detecção de obstáculos
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, detectionRadius);
    }
}

